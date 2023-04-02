using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.Decorator
{
    public class DataAberturaFiltro : Filtro
    {

        public DataAberturaFiltro() : base() { }

        public DataAberturaFiltro(Filtro filtro) : base(filtro) { }

        public override List<Conta> Filtra(List<Conta> contas)
        {
            List<Conta> contaSuspeita = new List<Conta>();
            contaSuspeita = contas.Where(c => c.DataAbertura.Month == DateTime.Now.Month).ToList();
            return AcrescentaContaNovoFiltro(contas, contaSuspeita);            
        }
    }
}
