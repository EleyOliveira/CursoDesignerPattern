using CursoDesignerPattern.TemplateMethod.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.State
{
    public class Negativa : IEstadoConta
    {
        public void Deposito(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) conta.Estado = new Positiva();
        }

        public void Saque(Conta conta, double valor)
        {
            throw new Exception("Conta está negativa");
        }

        
    }
}
