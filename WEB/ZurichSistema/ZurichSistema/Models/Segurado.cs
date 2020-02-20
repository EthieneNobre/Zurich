using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZurichSistema.Models
{
    public class Segurado : Veiculo
    {
        /// <summary>
        /// 
        /// </summary>
        public int idSegurado { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Idade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Ativo { get; set; }
    }
}