using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {            
            double resultado = imposto.Calcula(orcamento);
            Console.WriteLine(resultado);
        }               
    }
}
