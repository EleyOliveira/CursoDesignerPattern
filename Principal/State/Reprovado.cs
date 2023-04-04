using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.State
{
    public class Reprovado : IEstadoOrcamento
    {
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está reprovado, não pode mais ser aprovado!");
        }

        public void ConcedeDesconto(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não tem direito a desconto!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já encontra-se reprovado!");
        }
    }
}
