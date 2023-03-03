namespace CursoDesignerPattern
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (AconteceuVendaCasada(orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }            
        }

        private static bool AconteceuVendaCasada(Orcamento orcamento) 
        {
            return orcamento.Itens.Where(i => i.Nome == "Caneta" || i.Nome == "Lapis").Count() == 2;
        }
    }
}
