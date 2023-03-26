namespace CursoDesignerPattern.TemplateMethod
{
    public abstract class RegraTaxacaoImposto : Imposto
    {
        protected RegraTaxacaoImposto(Imposto imposto) : base(imposto) { }

        protected RegraTaxacaoImposto() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento)) 
            {
                return MaximaTaxacao(orcamento);
            }
            else 
            {
                return MinimaTaxacao(orcamento);
            }
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);

    }
}
