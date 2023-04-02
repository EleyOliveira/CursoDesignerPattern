using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.Decorator
{
    public class SaldoMenorFiltro : Filtro
    {
        public SaldoMenorFiltro() : base() { }

        public SaldoMenorFiltro(Filtro filtro) : base(filtro) { }

        public override List<Conta> Filtra(List<Conta> contas)
        {
            List<Conta> contaSuspeita = new List<Conta>();
            contaSuspeita = contas.Where(c => c.Saldo < 100).ToList();
            return AcrescentaContaNovoFiltro(contas, contaSuspeita);
        }
    }
}
