using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern
{
    public class ISS : Imposto
    {        
        public ISS(Imposto imposto) : base(imposto) {}

        public ISS() : base() { }
        
        public override double Calcula(Orcamento orcamento) 
        {
            return orcamento.Valor * 0.06 + CalculoImpostoComposto(orcamento);
        }
    }
}
