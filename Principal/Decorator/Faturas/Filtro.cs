namespace CursoDesignerPattern.Decorator.Faturas
{
    public abstract class Filtro
    {
        private Filtro NovoFiltro { get; set; }

        protected Filtro(Filtro novoFiltro)
        {
            NovoFiltro = novoFiltro;
        }

        protected Filtro() { }

        protected List<Fatura> UtilizaNovoFiltro(List<Fatura> filtroAtual)
        {
            if (NovoFiltro == null)
            {
                return filtroAtual;
            }
            else 
            { 
                return NovoFiltro.Filtra(filtroAtual);
            }
        }
        public abstract List<Fatura> Filtra(List<Fatura> faturas);
    }
}
