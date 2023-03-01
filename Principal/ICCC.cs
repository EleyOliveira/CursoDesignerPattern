using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double valor = orcamento.Valor;

            if (valor < 1000)
            {
                return valor * 0.05;
            }
            else if(valor >= 1000 && valor <= 3000)
            {
                return valor * 0.07;
            }
            else
            {
                return valor * 0.08 + 30;
            }
        }
    }
}
