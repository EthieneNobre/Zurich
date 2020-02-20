using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZurichSistema.Models
{
    public class CalculoSeguroVeiculos
    {
        /// <summary>
        /// 
        /// </summary>
        public int SeguradoId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double ValorVeiculo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double PremioRisco { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double PremioPuro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double PremioComercial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double ValorSeguro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double TaxaRisco { get; set; }

    }
}