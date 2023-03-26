using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.Decorator
{
    public abstract class Filtro
    {
        private Filtro NovoFiltro { get; set; }

        protected Filtro(Filtro novoFiltro)
        {
            NovoFiltro = novoFiltro;
        }
        protected Filtro() 
        {
            NovoFiltro = null;
        }

        protected IList<Conta> AcrescentaContaNovoFiltro (IList<Conta> contas)
        {
            return NovoFiltro == null ? new List<Conta>() : NovoFiltro.Filtra(contas); 
            
        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);
    }
}
