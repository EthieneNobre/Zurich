using Dapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ZurichSistema.Models;

namespace ZurichSistema.Controllers
{
    public class HomeController : Controller
    {

        private char[] serializedObject;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {

            List<Segurado> listSegurado = ListaSegurado();
            ViewBag.listSegurado = new SelectList(listSegurado, "idSegurado", "Nome");

            return View();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        [HttpPost]
        public void Busca(string valor, string segurado)
        {
            try
            {
                //AQUI POR PADRAO CRIPTOGRAFAR INFORMAÇÕES ANTES DE ENVIO OU REQUISIÇÃO POR BODY
                var requisicaoWeb = WebRequest.CreateHttp($"http://localhost:61617/api?ValorCarro={valor}");

                requisicaoWeb.Method = "POST";
                requisicaoWeb.ContentLength = 0;
                requisicaoWeb.UserAgent = "RequisicaoZurich";

                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();
                    var obj = JsonConvert.DeserializeObject<CalculoSeguroVeiculos>(objResponse.ToString());
                    streamDados.Close();
                    resposta.Close();


                    InsereBanco(obj, segurado);
                }
            }
            catch (Exception ex)
            {
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Obj"></param>
        /// <param name="segurado"></param>
        public void InsereBanco(CalculoSeguroVeiculos Obj, string segurado)
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);


                CalculoSeguroVeiculos valores = new CalculoSeguroVeiculos();
                valores.SeguradoId = Convert.ToInt32(segurado);
                valores.ValorVeiculo = Obj.ValorVeiculo;
                valores.PremioRisco = Obj.PremioRisco;
                valores.PremioPuro = Obj.PremioPuro;
                valores.PremioComercial = Obj.PremioComercial;
                valores.ValorSeguro = Obj.ValorSeguro;
                valores.TaxaRisco = Obj.TaxaRisco;


                conn.Execute("INSERT INTO tb_Seguro(SeguradoId, ValorVeiculo, PremioRisco, PremioPuro,PremioComercial,TaxaRisco,ValorSeguro, Ativo) VALUES(@SeguradoId, @ValorVeiculo, @PremioRisco, @PremioPuro, @PremioComercial, @TaxaRisco, @ValorSeguro,1)",
                             valores);

                conn.Close();

    

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdSegurado"></param>
        /// <returns></returns>
        public Segurado SelecionaSegurado(int IdSegurado)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);

                Segurado segurado = conn.QueryFirstOrDefault<Segurado>("SELECT * FROM tb_Segurado WHERE idSegurado=@id",
                                             new { id = IdSegurado });

                conn.Close();
                return segurado;


            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Segurado> ListaSegurado()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);

                // Lista completa de registros
                List<Segurado> Lista = conn.Query<Segurado>("SELECT * FROM tb_Segurado").ToList();


                conn.Close();
                return Lista;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}