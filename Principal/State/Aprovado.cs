namespace CursoDesignerPattern.State
{
    public class Aprovado : IEstadoOrcamento
    {
        private bool _descontoConcedido = false;

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está aprovado");
        }

        public void ConcedeDesconto(Orcamento orcamento)
        {
            if (_descontoConcedido == false)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                _descontoConcedido = true;
            }
            throw new Exception("Desconto já concedido");
           
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
