namespace CursoDesignerPattern.TemplateMethod
{
    public class ICPP : RegraTaxacaoImposto
    {
        public ICPP(Imposto imposto) : base(imposto) { }

        public ICPP() : base() { }
        
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + CalculoImpostoComposto(orcamento);
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculoImpostoComposto(orcamento);
        }
    }
}
