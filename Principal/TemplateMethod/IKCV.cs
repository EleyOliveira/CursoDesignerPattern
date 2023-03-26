namespace CursoDesignerPattern.TemplateMethod
{
    public class IKCV : RegraTaxacaoImposto
    {
        public IKCV(Imposto imposto) : base(imposto) { }

        public IKCV() : base() { }
        
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && ValordeItemSuperior(orcamento); 
        }

        private bool ValordeItemSuperior(Orcamento orcamento)
        {
            return orcamento.Itens.Where(i => i.Valor > 100).Count() > 0;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoImpostoComposto(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoImpostoComposto(orcamento);
        }
    }
}
