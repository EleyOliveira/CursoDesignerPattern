// See https://aka.ms/new-console-template for more information
using RequisicaoWeb;

Console.WriteLine("Hello, World!");

Conta conta = new Conta("João José Juarez", 5000);
Requisicao requisicao = new Requisicao(EnumFormato.Formato.PORCENTO);

ExibeFormatoXML F1 = new ExibeFormatoXML();
ExibeFormatoPorcentagem F2 = new ExibeFormatoPorcentagem();
ExibeFormatoCSV F3 = new ExibeFormatoCSV();

F1.Proxima = F2;
F2.Proxima = F3;

Console.WriteLine(F1.Formatar(conta, requisicao));