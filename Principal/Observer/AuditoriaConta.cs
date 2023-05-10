using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.Observer
{
    public class AuditoriaConta : IAcaoPosDeposito
    {
        public void Executa(Conta conta)
        {
            Console.WriteLine($"Auditoria depósito na conta: {conta.Agencia} - {conta.Numero} Saldo: {conta.Saldo}");
        }
    }
}
