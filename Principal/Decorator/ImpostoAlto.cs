namespace CursoDesignerPattern.Decorator
{
    public class ImpostoAlto : Imposto
    {
        public ImpostoAlto() : base() { }
        public ImpostoAlto(Imposto imposto) : base(imposto) { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoImpostoComposto(orcamento);
        }
    }
}
