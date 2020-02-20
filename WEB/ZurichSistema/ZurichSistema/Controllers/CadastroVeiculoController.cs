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
    public class CadastroVeiculoController : Controller
    {
        // GET: CadastroVeiculo
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
        public void Cadastra(string segurado, string Valor, string Marca, string Modelo)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);

                Veiculo valores = new Veiculo();
                valores.Segurado = Convert.ToInt32(segurado);
                valores.ValorVeiculo = Convert.ToDecimal(Valor);
                valores.Marca = Marca;
                valores.Modelo = Modelo;


                conn.Execute("INSERT INTO tb_Veiculo(Segurado, ValorVeiculo, Marca,Modelo, Ativo) VALUES(@Segurado, @ValorVeiculo, @Marca, @Modelo, 1)",
                             valores);

                conn.Close();

            }
            catch (Exception ex)
            {
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