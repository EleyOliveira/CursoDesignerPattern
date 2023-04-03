using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.State
{
    public class Finalizado : IEstadoOrcamento
    {
        public double ConcedeDesconto(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado não direito a desconto!");
        }
    }
}
