namespace CursoDesignerPattern.Decorator.Faturas
{
    public class ExecutaFiltro
    {
        public ExecutaFiltro() 
        {
            Fatura fatura = new Fatura { EstadoEmissao = "SP", Valor = 8100 };
            Fatura fatura1 = new Fatura { EstadoEmissao = "PE", Valor = 3200 };
            Fatura fatura2 = new Fatura { EstadoEmissao = "SP", Valor = 2300 };
            Fatura fatura3 = new Fatura { EstadoEmissao = "SE", Valor = 2001 };
            Fatura fatura4 = new Fatura { EstadoEmissao = "MG", Valor = 3900 };

            List<Fatura> faturas = new List<Fatura> { fatura, fatura1, fatura2, fatura3, fatura4 };

            List<Fatura> faturasFiltradas = new FiltraValor(new FiltraEstado()).Filtra(faturas);
           // FiltraValor filtraValor = new();
            //faturasFiltradas = filtraValor.Filtra(faturas);

            Console.Write($"Total de faturas: {faturasFiltradas.Count}" );
        }         

    }
}
