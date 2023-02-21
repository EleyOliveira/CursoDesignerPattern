using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern
{
    public class Orcamento
    {
        public Orcamento(double valor)
        {
            Valor = valor;
        }

        public double Valor { get; private set; } 
    }
}
