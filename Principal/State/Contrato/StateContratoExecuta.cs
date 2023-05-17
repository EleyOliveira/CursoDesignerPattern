using System.Globalization;

namespace CursoDesignerPattern.State.Contrato
{
    internal class StateContratoExecuta
    {
        public StateContratoExecuta()
        {
            try
            {
                Contrato contrato = new()
                {
                    Numero = "gg 12"
                };

                EmAndamento emAndamento = new();
                emAndamento.Ajusta(contrato);
                Assinado assinado = new();
                assinado.Altera(contrato);
                assinado.Altera(contrato);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
