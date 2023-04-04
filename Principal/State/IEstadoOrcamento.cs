namespace CursoDesignerPattern.State
{
    public interface IEstadoOrcamento
    {
        void ConcedeDesconto(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }
}
