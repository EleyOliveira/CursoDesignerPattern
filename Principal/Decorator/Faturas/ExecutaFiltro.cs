namespace CursoDesignerPattern.Decorator.Faturas
{
    public class ExecutaFiltro
    {
        public ExecutaFiltro() 
        {
            Fatura fatura = new Fatura { EstadoEmissao = "SP", Valor = 3100 };
            Fatura fatura1 = new Fatura { EstadoEmissao = "SP", Valor = 3200 };
            Fatura fatura2 = new Fatura { EstadoEmissao = "SP", Valor = 3300 };
            Fatura fatura3 = new Fatura { EstadoEmissao = "SP", Valor = 3400 };
            Fatura fatura4 = new Fatura { EstadoEmissao = "SP", Valor = 3900 };

            List<Fatura> faturas = new List<Fatura> { fatura, fatura1, fatura2, fatura3, fatura4 };

            List<Fatura> faturasFiltradas = new FiltraValor().Filtra(faturas);
           // FiltraValor filtraValor = new();
            //faturasFiltradas = filtraValor.Filtra(faturas);

            Console.Write($"Total de faturas: {faturasFiltradas.Count}" );
        }         

    }
}
