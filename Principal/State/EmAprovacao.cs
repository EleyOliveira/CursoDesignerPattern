using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.State
{
    public class EmAprovacao : IEstadoOrcamento
    {
        public void Aprova(Orcamento orcamento)
        {
            orcamento.Estado = new Aprovado();
        }

        public void ConcedeDesconto(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor * 0.05;
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação, somente pode ser aprovado ou reprovado, não finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }
    }
}
