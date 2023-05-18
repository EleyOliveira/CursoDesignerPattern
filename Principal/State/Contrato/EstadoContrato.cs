namespace CursoDesignerPattern.State.Contrato
{
    internal abstract class EstadoContrato
    {        
        public abstract void Ajusta(Contrato contrato);
        public abstract void Altera(Contrato contrato);
        public abstract void ConcedeDesconto(Contrato contrato);

        protected static void Validar(EstadoContrato estado)
        {
            if (estado != null && estado.GetType().Equals(typeof(Assinado)))
            {
                throw new ApplicationException("Contrato assinado, não pode sofrer alterações");
            }
        }

        protected static void ExibeMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        protected static void AlteraEstado(Contrato contrato, EstadoContrato estado)
        {
            contrato.Estado = estado;
            Console.WriteLine($"O estado atual do contrato {contrato.Numero} é {contrato.Estado}");
        }
    }
}
