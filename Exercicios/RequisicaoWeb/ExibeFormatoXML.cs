namespace RequisicaoWeb
{
    public class ExibeFormatoXML : IFormato
    {
        private readonly IFormato? _proxFormato;
        public ExibeFormatoXML(IFormato proxFormato) 
        { 
            _proxFormato = proxFormato;
        }

        public ExibeFormatoXML()
        {
            _proxFormato = null;
        }

        public string Formatar(Conta conta, Requisicao requisicao)
        {
            if (EnumFormato.Formato.XML == requisicao.Formato)
            {
                return $"<nome>{conta.Nome}</nome><saldo>{conta.Saldo}</saldo>";
            }
            else if (_proxFormato != null)
            {
                return _proxFormato.Formatar(conta, requisicao);
            }
            else
                return "Formato Inválido";
               
            
        }
    }
}
