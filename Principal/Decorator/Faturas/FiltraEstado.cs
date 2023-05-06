namespace CursoDesignerPattern.Decorator.Faturas
{
    public class FiltraEstado : Filtro
    {
        public FiltraEstado() : base() { }

        public FiltraEstado(Filtro novoFiltro) : base(novoFiltro){ }

        public override List<Fatura> Filtra(List<Fatura> faturas)
        {
            return faturas.Where(f => f.EstadoEmissao == "SP" && f.Valor >= 3000 && f.Valor <= 4000).ToList();
        }
    }
}
