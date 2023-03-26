namespace CursoDesignerPattern
{
    public abstract class Imposto
    {
        private readonly Imposto? impostoComposto;    
        public Imposto(Imposto imposto)
        {
            this.impostoComposto = imposto;
        }

        public Imposto()
        {
            this.impostoComposto = null;
        }

        protected double CalculoImpostoComposto(Orcamento orcamento)
        {
            if (impostoComposto == null) return 0;

            return impostoComposto.Calcula(orcamento);
        }

        public abstract double Calcula(Orcamento orcamento);
    }
}
