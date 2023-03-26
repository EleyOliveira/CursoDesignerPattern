namespace CursoDesignerPattern
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto imposto) : base(imposto) { }        

        public ICCC() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            double valor = orcamento.Valor;

            if (valor < 1000)
            {
                return valor * 0.05 + CalculoImpostoComposto(orcamento);
            }
            else if(valor >= 1000 && valor <= 3000)
            {
                return valor * 0.07 + CalculoImpostoComposto(orcamento);
            }
            else
            {
                return valor * 0.08 + 30 + CalculoImpostoComposto(orcamento);
            }
        }
    }
}
