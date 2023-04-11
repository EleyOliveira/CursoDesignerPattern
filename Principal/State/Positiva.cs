using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.State
{
    public class Positiva : IEstadoConta
    {
        public void Deposito(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Saque(Conta conta, double valor)
        {
            conta.Saldo -= valor;
            if (conta.Saldo < 0) conta.Estado = new Negativa();
        }
    }
}
