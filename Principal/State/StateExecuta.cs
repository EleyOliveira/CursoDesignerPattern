using CursoDesignerPattern.TemplateMethod.Relatorio;
using System.ComponentModel;

namespace CursoDesignerPattern.State
{
    public class StateExecuta
    {
        public StateExecuta() 
        { 
            try 
            { 
                //Orcamento orcamento = new Orcamento(1000);
                //orcamento.Estado.ConcedeDesconto(orcamento);
                ////orcamento.Estado.ConcedeDesconto(orcamento);
                //orcamento.Estado.Aprova(orcamento);
                //orcamento.Estado.ConcedeDesconto(orcamento);
                //orcamento.Estado.ConcedeDesconto(orcamento);
                //Console.WriteLine($"Valor com desconto {orcamento.Valor}");

                Conta conta = new()
                {
                    Saldo = 100                    
                };

                if (conta.Saldo >= 0)
                {

                }

                Positiva positiva = new Positiva();                
                positiva.Deposito(conta, 200);
                positiva.Saque(conta, 80);
                Console.WriteLine($"O saldo da conta é {conta.Saldo}");

            } 
            catch (Exception e) 
            { 
                Console.WriteLine (e.ToString());
            } 

        }
    }
}
