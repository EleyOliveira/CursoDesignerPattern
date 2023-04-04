using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.State
{
    public class Finalizado : IEstadoOrcamento
    {
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado, não pode ser aprovado!");
        }

        public void ConcedeDesconto(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado não tem direito a desconto!");
        }
        
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizado, não pode mais ser reprovado!");
        }
    }
}
