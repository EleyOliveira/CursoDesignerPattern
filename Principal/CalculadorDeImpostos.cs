﻿namespace CursoDesignerPattern
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {            
            double resultado = imposto.Calcula(orcamento);
            Console.WriteLine(resultado);
        }               
    }
}
