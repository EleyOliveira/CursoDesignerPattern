using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.Decorator
{
    public class SaldoMaiorFiltro : Filtro
    {
        public SaldoMaiorFiltro() : base() { }

        public SaldoMaiorFiltro(Filtro filtro) : base(filtro) { }   

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return AcrescentaContaNovoFiltro(contas.Where(c => c.Saldo > 500000).ToList());
        }
    }
}
