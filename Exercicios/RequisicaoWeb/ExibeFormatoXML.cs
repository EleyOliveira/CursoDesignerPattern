namespace RequisicaoWeb
{
    public class ExibeFormatoXML : IFormato
    {
        public IFormato Proxima { get; set; }

        private readonly IFormato _proxFormato;
        public ExibeFormatoXML(IFormato proxFormato) 
        { 
            _proxFormato = proxFormato;
        }

        public string Formatar(Conta conta, Requisicao requisicao)
        {
            if (EnumFormato.Formato.XML == requisicao.Formato)
            {
                return $"<nome>{conta.Nome}</nome><saldo>{conta.Saldo}</saldo>";
            }
            else
               return _proxFormato.Formatar(conta, requisicao); 
               
            
        }
    }
}
