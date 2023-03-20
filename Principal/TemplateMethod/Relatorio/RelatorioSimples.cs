namespace CursoDesignerPattern.TemplateMethod.Relatorio
{
    public class RelatorioSimples : FormatoRelatorio
    {
        protected override string Cabecalho()
        {
            return "Banco: Tenho Dinheiro S.A.";
        }

        protected override string Corpo(List<Conta> contas)
        {
            return "";
        }

        protected override string Rodape()
        {
            return "Telefone: 551125252626";
        }
    }
}
