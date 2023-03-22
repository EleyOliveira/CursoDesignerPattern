namespace CursoDesignerPattern.TemplateMethod.Relatorio
{
    public class RelatorioComplexo : FormatoRelatorio
    {
        protected override string Cabecalho()
        {
            return "Banco: Tenho Dinheiro S.A. \n" + 
                   "Endereço: Ruas dos tenho dinheiro, 122 - Milionários - MI - CEP: 99999-999 \n" +
                   "Telefone: 551125252626";
        }

        protected override string Corpo(List<Conta> contas)
        {
            string textoCorpo = "";

            contas.ForEach(contas =>
            {
                textoCorpo += $"Titular: {contas.Titular} - Agência: {contas.Agencia} - Número: {contas.Numero} - Saldo: {contas.Saldo} \n";
            });
            
            return textoCorpo;
        }

        protected override string Rodape()
        {
            return "Email: tenhodinheiro@dinheiro.com.br \n" +
                   $"Data: {DateTime.Now}";
        }
    }
}
