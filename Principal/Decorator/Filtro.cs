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

        protected List<Conta> AcrescentaContaNovoFiltro (List<Conta> contas, List<Conta> contasAnalisar)
        {
            if (NovoFiltro == null)
            {
                return contasAnalisar;
            }
            else 
            {
                contasAnalisar.AddRange(NovoFiltro.Filtra(contas));
                return contasAnalisar;
            }           
        }
        public abstract List<Conta> Filtra(List<Conta> contas);
    }
}
