using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZurichSeguros.Models;

namespace ZurichSeguros.Manager
{
    /// <summary>
    /// 
    /// </summary>
    public class CalculoSeguroVeiculosManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Valor"></param>
        /// <returns></returns>
        public CalculoSeguroVeiculos CalculoSeguro(string Valor)
        {
            try
            {

                CalculoSeguroVeiculos calculoSeguro = new CalculoSeguroVeiculos();
                double valorVeiculo = Double.Parse(Valor);

                //CALCULO TAXA DE RISCO
                double txRisco = (valorVeiculo * 5) / (2 * valorVeiculo);

                //CALCULO PREMIO DE RISCO
                double PreRisco = ((double)txRisco / 100) * valorVeiculo;

                //CALCULO PREMIO PURO
                double PrePuro = PreRisco * (1 + 0.03);

                //CALCULO PREMIO COMERCIAL
                double PreComercial = 0.05 * PrePuro;

                //CALCULO TOTAL
                double total = PrePuro + PreComercial;
               

                calculoSeguro.ValorVeiculo = Math.Round(valorVeiculo, 2);
                calculoSeguro.TaxaRisco = Math.Round(txRisco, 2);
                calculoSeguro.PremioRisco = Math.Round(PreRisco, 2);
                calculoSeguro.PremioPuro = Math.Round(PrePuro, 2);
                calculoSeguro.PremioComercial = Math.Round(PreComercial, 2);
                calculoSeguro.ValorSeguro = Math.Round(total, 2);

                return calculoSeguro;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}