namespace CursoDesignerPattern.State.Contrato
{
    internal class EmAndamento : EstadoContrato
    {
        public override void Ajusta(Contrato contrato)
        {
            Validar(contrato.Estado);
            ExibeMensagem("Contrato ajustado!!!");            
            AlteraEstado(contrato, this);
        }        

        public override void Altera(Contrato contrato)
        {
            Validar(contrato.Estado);
            ExibeMensagem("Contrato alterado!!!");
            AlteraEstado(contrato, this);
        }       

        public override void ConcedeDesconto(Contrato contrato)
        {
            Validar(contrato.Estado);
            ExibeMensagem("Desconto concedido!!!");
            AlteraEstado(contrato, this);
        }        
    }
}
