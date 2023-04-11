using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.State
{
    public interface IEstadoConta
    {        
        void Saque(Conta conta, double valor);
        void Deposito(Conta conta, double valor);
    }
}