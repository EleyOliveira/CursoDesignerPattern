using CursoDesignerPattern.TemplateMethod.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.Observer
{
    public class FinanceiroConta : IAcaoPosDeposito
    {
        public void Executa(Conta conta)
        {
            Console.WriteLine($"Financeiro depósito na conta: {conta.Agencia} - {conta.Numero} Saldo: {conta.Saldo}");
        }
    }
}
