namespace CursoDesignerPattern.TemplateMethod
{
    public class IHIT : RegraTaxacaoImposto
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Itens.Where(i => i.Nome == i.Nome).Count() == 2;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return 0;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
    }
}
