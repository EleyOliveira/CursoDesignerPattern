using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.Observer
{
    public class AgenciaConta : IAcaoPosDeposito
    {
        public void Executa(Conta conta)
        {
            Console.WriteLine($"Agência depósito na conta: {conta.Agencia} - {conta.Numero} Saldo: {conta.Saldo}");
        }
    }
}
