namespace CursoDesignerPattern.TemplateMethod.Relatorio
{
    public class ImprimeRelatorio
    {
        public ImprimeRelatorio()
        {
            Conta conta = new Conta();
            conta.Titular = "João Primeiro Antes do Segundo";
            conta.Agencia = 12;
            conta.Numero = 210;
            conta.Saldo = 14578.66;

            Conta conta1 = new Conta();
            conta1.Titular = "João Segundo Depois do Primeiro";
            conta1.Agencia = 25;
            conta1.Numero = 356;
            conta1.Saldo = 56878.32;

            Conta conta2 = new Conta();
            conta2.Titular = "Kelio dos Santos";
            conta2.Agencia = 26;
            conta2.Numero = 112;
            conta2.Saldo = 1247895.45;

            Conta conta3 = new Conta();
            conta3.Titular = "Sousitones Vasconcelos";
            conta3.Agencia = 58;
            conta3.Numero = 457;
            conta3.Saldo = 587489.33;

            List<Conta> contas = new List<Conta>();
            contas.Add(conta);
            contas.Add(conta1);
            contas.Add(conta2);
            contas.Add(conta3);

            RelatorioSimples relatorioSimples = new RelatorioSimples();
            RelatorioComplexo relatorioComplexo = new RelatorioComplexo();
            Console.WriteLine(relatorioSimples.Imprimir(contas));
            Console.WriteLine("Complexo");
            Console.WriteLine(relatorioComplexo.Imprimir(contas));
        }
    }
}
