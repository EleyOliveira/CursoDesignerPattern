using CursoDesignerPattern.TemplateMethod.Relatorio;
using System.ComponentModel;

namespace CursoDesignerPattern.State
{
    public class StateExecuta
    {
        public StateExecuta() 
        {
            Conta conta = new()
            {
                Saldo = -100
            };

            try 
            { 
                //Orcamento orcamento = new Orcamento(1000);
                //orcamento.Estado.ConcedeDesconto(orcamento);
                ////orcamento.Estado.ConcedeDesconto(orcamento);
                //orcamento.Estado.Aprova(orcamento);
                //orcamento.Estado.ConcedeDesconto(orcamento);
                //orcamento.Estado.ConcedeDesconto(orcamento);
                //Console.WriteLine($"Valor com desconto {orcamento.Valor}");                

                if (conta.Saldo > 0)
                {                    
                    conta.Estado = new Positiva();
                    conta.Estado.Deposito(conta, 200);
                    conta.Estado.Saque(conta, 80);                    
                }
                else if (conta.Saldo < 0) 
                {                     
                    conta.Estado = new Negativa();
                    conta.Estado.Deposito(conta, 50);
                    conta.Estado.Deposito(conta, 50);
                    conta.Estado.Deposito(conta, 200);
                    conta.Estado.Saque(conta, 200);
                }
            } 
            catch (Exception e) 
            { 
                Console.WriteLine (e.ToString());
            }
            finally 
            {
                Console.WriteLine($"O saldo da conta é {conta.Saldo} e Situação {conta.Estado.ToString()}");
            }     

        }
    }
}
