using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_POO_AppInvestimento
{
    internal class Investe
    {
        public double caixa,taxa,juros;
        public int mes, count=1;
        public double mensagem;

        public double Taxa(double taxa)
        {
            double juros;
            juros = taxa / 100;                      
            return juros;                                       
        }
        public double Caixa(double caixa,double juros)
        {
            caixa = caixa +(caixa*juros);
            return caixa;                                        
        }

        public double Aumento(double caixa,double juros)
        {
            caixa = caixa + (caixa * juros);
            return caixa;
        }



       
    }
}
