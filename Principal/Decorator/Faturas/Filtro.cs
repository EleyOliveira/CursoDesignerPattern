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
        public abstract List<Fatura> Filtra(List<Fatura> faturas);
    }
}
