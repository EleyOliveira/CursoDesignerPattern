namespace CursoDesignerPattern.State
{
    public class EmAprovacao : IEstadoOrcamento
    {
        private bool _descontoConcedido = false;
        public void Aprova(Orcamento orcamento)
        {
            orcamento.Estado = new Aprovado();
        }

        public void ConcedeDesconto(Orcamento orcamento)
        {
            if (_descontoConcedido == false)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                _descontoConcedido = true;
            }   
            else
                throw new Exception("Desconto já foi concedido");
            
            
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
