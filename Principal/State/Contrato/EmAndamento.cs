namespace CursoDesignerPattern.State.Contrato
{
    internal class EmAndamento : EstadoContrato
    {
        public override void Ajusta(Contrato contrato)
        {
            Validar(contrato.Estado);
            Console.WriteLine("Contrato ajustado!!!");
            contrato.Estado = this;
        }        

        public override void Altera(Contrato contrato)
        {
            Validar(contrato.Estado);
            Console.WriteLine("Contrato alterado!!!");
            contrato.Estado = this;
        }       

        public override void ConcedeDesconto(Contrato contrato)
        {
            Validar(contrato.Estado);
            Console.WriteLine("Desconto aplicado");
            contrato.Estado = this;
        }        
    }
}
