// See https://aka.ms/new-console-template for more information
using CursoDesignerPattern;

Console.WriteLine("Hello, World!");

IImposto iss = new ISS();
IImposto icms = new ICMS();
IImposto ICCC = new ICCC();

Orcamento orcamento = new Orcamento(500.00);

CalculadorDeImpostos calculador = new CalculadorDeImpostos();
calculador.RealizaCalculo(orcamento, icms);
calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, ICCC);

orcamento = new Orcamento(2000);
calculador.RealizaCalculo(orcamento, ICCC);

orcamento = new Orcamento(4000);
calculador.RealizaCalculo(orcamento, ICCC);


Console.ReadKey();