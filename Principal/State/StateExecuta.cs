using System.ComponentModel;

namespace CursoDesignerPattern.State
{
    public class StateExecuta
    {
        public StateExecuta() 
        { 
            try 
            { 
                Orcamento orcamento = new Orcamento(1000);
                orcamento.Estado.ConcedeDesconto(orcamento);
                //orcamento.Estado.ConcedeDesconto(orcamento);
                orcamento.Estado.Aprova(orcamento);
                orcamento.Estado.ConcedeDesconto(orcamento);
                Console.WriteLine($"Valor com desconto {orcamento.Valor}");            
            } 
            catch (Exception e) 
            { 
                Console.WriteLine (e.ToString());
            } 

        }
    }
}
