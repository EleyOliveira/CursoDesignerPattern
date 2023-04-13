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
                    conta.Deposita(200);
                    conta.Saca(80);                    
                }
                else if (conta.Saldo < 0) 
                {                     
                    conta.Estado = new Negativa();
                    conta.Deposita(50);
                    conta.Deposita(50);
                    conta.Deposita(200);
                    conta.Saca(80);                    
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
