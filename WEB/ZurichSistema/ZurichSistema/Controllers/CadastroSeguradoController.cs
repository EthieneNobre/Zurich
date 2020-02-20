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
    public class CadastroSeguradoController : Controller
    {
        // GET: CadastroSegurado
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        [HttpPost]
        public void Cadastra(string Nome, string CPF, string Idade)
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);


                Segurado valores = new Segurado();
                valores.Nome = Nome;
                valores.CPF= CPF;
                valores.Idade = Convert.ToInt32(Idade);


                conn.Execute("INSERT INTO tb_Segurado(Nome, CPF, Idade, Ativo) VALUES(@Nome, @CPF, @Idade,1)",
                             valores);

                conn.Close();

        

            }
            catch (Exception ex)
            {
            }


        }

    }


}