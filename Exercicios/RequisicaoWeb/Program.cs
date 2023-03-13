// See https://aka.ms/new-console-template for more information
using RequisicaoWeb;

Console.WriteLine("Hello, World!");

Conta conta = new Conta("João José Juarez", 5000);
Requisicao requisicao = new Requisicao(EnumFormato.Formato.PORCENTO);

ExibeFormatoXML F1 = new ExibeFormatoXML(
                     new ExibeFormatoPorcentagem(
                     new ExibeFormatoCSV(
                     new SemFormato())));

Console.WriteLine(F1.Formatar(conta, requisicao));