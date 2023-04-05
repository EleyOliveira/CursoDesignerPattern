using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.State
{
    public class Aprovado : IEstadoOrcamento
    {
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está aprovado");
        }

        public void ConcedeDesconto(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já aprovado, não pode mais ser reprovado!");
        }
    }
}
