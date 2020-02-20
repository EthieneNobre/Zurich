using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZurichSeguros.Manager;
using ZurichSeguros.Models;

namespace ZurichSeguros.Controllers
{

    public class DefaultController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ValorCarro"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api")]
        public CalculoSeguroVeiculos CalculoSeguro(string ValorCarro)
        {
            try
            {
                CalculoSeguroVeiculosManager manager = new CalculoSeguroVeiculosManager();

                var calculoEfetuado = manager.CalculoSeguro(ValorCarro);

                return calculoEfetuado;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
