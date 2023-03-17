namespace CursoDesignerPattern.TemplateMethod
{
    public class IHIT : RegraTaxacaoImposto
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return DescobreItemDuplicado(orcamento);                              
        }

        private bool DescobreItemDuplicado(Orcamento orcamento)
        {
            return orcamento.Itens
                .GroupBy(i => new { i.Nome })
                .Where(g => g.Count() > 1)
                .Sum(g => g.Count()) == 2;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (orcamento.Itens.Count() * 0.01);
        }
        
    }
}
