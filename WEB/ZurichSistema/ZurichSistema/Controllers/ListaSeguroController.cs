using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using ZurichSistema.Models;

namespace ZurichSistema.Controllers
{
    public class ListaSeguroController : Controller
    {
        // GET: ListaSeguro
        public ActionResult Index()
        {
            List<ListaSeguro> listSegurado = ListaRelatorio();

            return View(listSegurado);
        }

        public List<ListaSeguro> ListaRelatorio()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);

                // Lista completa de registros
                List<ListaSeguro> Lista = conn.Query<ListaSeguro>(@"SELECT
                                                            TS.Nome,
                                                            TS.CPF,
                                                            TS.Idade,
                                                            TV.ValorVeiculo,
                                                            TV.Marca,
                                                            TV.Modelo,
                                                            TSE.ValorSeguro
                                                        FROM

                                                            tb_Segurado TS
                                                        INNER JOIN tb_Veiculo TV ON TS.idSegurado = TV.Segurado
                                                        INNER JOIN tb_Seguro TSE ON TV.Segurado = TSE.SeguradoId
                                                        WHERE
                                                            TS.Ativo = 1").ToList();


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