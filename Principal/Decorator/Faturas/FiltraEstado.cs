namespace CursoDesignerPattern.Decorator.Faturas
{
    public class FiltraEstado : Filtro
    {
        public FiltraEstado() : base() { }

        public FiltraEstado(Filtro novoFiltro) : base(novoFiltro){ }

        public override List<Fatura> Filtra(List<Fatura> faturas)
        {             
            return UtilizaNovoFiltro(faturas.Where(f => f.EstadoEmissao != "SP" && f.Valor >= 2000 && f.Valor <= 8000 || (f.EstadoEmissao == "SP" && f.Valor <= 3000 || f.Valor >= 4500)).ToList());
        }
    }
}
