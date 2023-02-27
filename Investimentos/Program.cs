// See https://aka.ms/new-console-template for more information
using Investimentos;

Console.WriteLine("Hello, World!");

IInvestimento tipoInvestimento = new Conservador();
Conta conta = new Conta();
conta.Deposita(1000);

RealizadorDeInvestimentos realizador = new RealizadorDeInvestimentos();
realizador.Realiza(conta, tipoInvestimento);
tipoInvestimento = new Moderado();
realizador.Realiza(conta, tipoInvestimento);
tipoInvestimento = new Arrojado();
realizador.Realiza(conta, tipoInvestimento);


Console.ReadKey();