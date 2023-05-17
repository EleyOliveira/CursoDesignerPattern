namespace CursoDesignerPattern.State.Contrato
{
    internal abstract class EstadoContrato
    {        
        public abstract void Ajusta(Contrato contrato);
        public abstract void Altera(Contrato contrato);
        public abstract void ConcedeDesconto(Contrato contrato);

        protected void Validar(EstadoContrato estado)
        {
            if (estado != null && estado.GetType().Equals(typeof(Assinado)))
            {
                throw new ApplicationException("Contrato assinado, não pode sofrer alterações");
            }
        }
    }
}
