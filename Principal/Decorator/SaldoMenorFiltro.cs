using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.Decorator
{
    public class SaldoMenorFiltro : Filtro
    {
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return contas.Where(c => c.Saldo < 100).ToList();
        }
    }
}
