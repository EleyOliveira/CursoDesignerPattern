using CursoDesignerPattern.Decorator;

namespace CursoDesignerPattern.TemplateMethod
{
    public class CalculaValorImposto
    {
        public CalculaValorImposto() 
        {
            Orcamento orcamento = new Orcamento(1000);
            orcamento.Itens.Add(new Item("blablo", 150));
            orcamento.Itens.Add(new Item("blable", 150));
            orcamento.Itens.Add(new Item("blable", 150));
            orcamento.Itens.Add(new Item("blabla", 150));


            ICPP iCPP = new ();
            IKCV iKCV = new ();
            IHIT iHIT = new (new IKCV());
            ISS iISS = new(new ICCC(new ICMS()));
            ImpostoAlto impostoAlto = new(new ISS());

            Console.WriteLine($"O valor do imposto ICPP {iCPP.Calcula(orcamento)}");
            Console.WriteLine($"O valor do imposto IKCV {iKCV.Calcula(orcamento)}");
            Console.WriteLine($"O valor do imposto IHIT {iHIT.Calcula(orcamento)}");
            Console.WriteLine($"O valor do imposto ISS {iISS.Calcula(orcamento)}");
            Console.WriteLine($"O valor do imposto alto {impostoAlto.Calcula(orcamento)}");
        }
    }
}
