// See https://aka.ms/new-console-template for more information
using CursoDesignerPattern;

Console.WriteLine("Hello, World!");

//IImposto iss = new ISS();
//IImposto icms = new ICMS();
//IImposto ICCC = new ICCC();

//Orcamento orcamento = new Orcamento(500.00);
//Console.WriteLine(iss.Calcula(orcamento));
//Console.WriteLine(icms.Calcula(orcamento));
//Console.WriteLine(ICCC.Calcula(orcamento));

//orcamento = new Orcamento(2000);
//Console.WriteLine(ICCC.Calcula(orcamento));

//orcamento = new Orcamento(4000);
//Console.WriteLine(ICCC.Calcula(orcamento));

//Console.WriteLine("Desconto");
Orcamento orcamento = new Orcamento(200);
IDesconto di = new DescontoQuantidadeItem();
IDesconto dv = new DescontoValorCompra();
IDesconto dvc = new DescontoPorVendaCasada();
IDesconto sd = new SemDesconto();

Item item = new Item("Caneta", 20);
orcamento.AdicionaItem(item);
item = new Item("Lapiseira", 20);
orcamento.AdicionaItem(item);
item = new Item("Caderno", 20);
orcamento.AdicionaItem(item);
item = new Item("Caderno", 20);
orcamento.AdicionaItem(item);
item = new Item("Caderno", 20);
orcamento.AdicionaItem(item);
//item = new Item("Caderno", 20);
//orcamento.AdicionaItem(item);

di.Proximo = dv;
dv.Proximo = dvc;
dvc.Proximo = sd;

Console.WriteLine(di.Desconta(orcamento));

Console.ReadKey();