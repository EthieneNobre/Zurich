using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZurichSistema.Models
{
    public class Veiculo
    {
        /// <summary>
        /// 
        /// </summary>
        public int IdVeiculo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Segurado { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal ValorVeiculo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Marca { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Modelo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Ativo { get; set; }
    }
}