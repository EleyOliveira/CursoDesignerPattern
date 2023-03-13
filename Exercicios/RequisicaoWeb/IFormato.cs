namespace RequisicaoWeb
{
    public interface IFormato
    {        
        public string Formatar(Conta conta, Requisicao requisicao);
        public IFormato Proxima { get; set; }
    }
}
