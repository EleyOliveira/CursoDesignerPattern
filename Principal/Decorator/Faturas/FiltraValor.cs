namespace CursoDesignerPattern.Decorator.Faturas
{
    public class FiltraValor : Filtro
    {
        public FiltraValor() : base() { }
        public FiltraValor(Filtro novoFiltro) : base(novoFiltro) { }
        public override List<Fatura> Filtra(List<Fatura> faturas)
        {
            return UtilizaNovoFiltro(faturas.Where(f => f.Valor > 2000 && f.Valor < 8000).ToList());
        }
    }
}
