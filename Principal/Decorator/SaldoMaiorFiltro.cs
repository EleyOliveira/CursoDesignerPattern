using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.Decorator
{
    public class SaldoMaiorFiltro : Filtro
    {
        public SaldoMaiorFiltro() : base() { }

        public SaldoMaiorFiltro(Filtro filtro) : base(filtro) { }   

        public override List<Conta> Filtra(List<Conta> contas)
        {
            List<Conta> contaSuspeita = new List<Conta>();
            contaSuspeita = contas.Where(c => c.Saldo > 500000).ToList();
            return AcrescentaContaNovoFiltro(contas, contaSuspeita);
        }
    }
}
