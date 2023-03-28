using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.Decorator
{
    public class SaldoMenorFiltro : Filtro
    {
        public SaldoMenorFiltro() : base() { }

        public SaldoMenorFiltro(Filtro filtro) : base(filtro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return AcrescentaContaNovoFiltro(contas.Where(c => c.Saldo < 100).ToList());
        }
    }
}
