using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.Decorator
{
    public class DataAberturaFiltro : Filtro
    {

        public DataAberturaFiltro() : base() { }

        public DataAberturaFiltro(Filtro filtro) : base(filtro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return AcrescentaContaNovoFiltro(contas.Where(c => c.DataAbertura.Month == DateTime.Now.Month).ToList());
        }
    }
}
