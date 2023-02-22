// See https://aka.ms/new-console-template for more information
using CursoDesignerPattern;

Console.WriteLine("Hello, World!");

IImposto iss = new ISS();
IImposto icms = new ICMS();
IImposto ICCC = new ICCC();

Orcamento orcamento = new Orcamento(500.00);
Console.WriteLine(iss.Calcula(orcamento));
Console.WriteLine(icms.Calcula(orcamento));
Console.WriteLine(ICCC.Calcula(orcamento));

orcamento = new Orcamento(2000);
Console.WriteLine(ICCC.Calcula(orcamento));

orcamento = new Orcamento(4000);
Console.WriteLine(ICCC.Calcula(orcamento));

Console.ReadKey();