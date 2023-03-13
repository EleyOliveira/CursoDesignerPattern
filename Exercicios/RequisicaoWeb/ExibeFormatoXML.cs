namespace RequisicaoWeb
{
    public class ExibeFormatoXML : IFormato
    {
        public IFormato Proxima { get; set; }

        public string Formatar(Conta conta, Requisicao requisicao)
        {
            if (EnumFormato.Formato.XML == requisicao.Formato)
            {
                return $"<nome>{conta.Nome}</nome><saldo>{conta.Saldo}</saldo>";
            }
            else
               return Proxima.Formatar(conta, requisicao); 
               
            
        }
    }
}
