// See https://aka.ms/new-console-template for more information
using RequisicaoWeb;

Console.WriteLine("Hello, World!");

Conta conta = new Conta("João José Juarez", 5000);
Requisicao requisicao = new Requisicao(EnumFormato.Formato.CSV);

ExibeFormatoXML F1 = new ExibeFormatoXML(
                     new ExibeFormatoPorcentagem(
                     new ExibeFormatoCSV()));

Console.WriteLine(F1.Formatar(conta, requisicao));