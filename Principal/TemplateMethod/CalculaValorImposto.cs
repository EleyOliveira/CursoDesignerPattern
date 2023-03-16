namespace CursoDesignerPattern.TemplateMethod
{
    public class CalculaValorImposto
    {
        public CalculaValorImposto() 
        {
            Orcamento orcamento = new Orcamento(1000);
            orcamento.Itens.Add(new Item("blabla", 150));

            ICPP iCPP = new ICPP();
            IKCV iKCV = new IKCV();
            
            Console.WriteLine($"O valor do imposto ICPP {iCPP.Calcula(orcamento)}");
            Console.WriteLine($"O valor do imposto IKCV {iKCV.Calcula(orcamento)}");
        }
    }
}
