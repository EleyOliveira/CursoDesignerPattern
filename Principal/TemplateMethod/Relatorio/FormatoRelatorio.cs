namespace CursoDesignerPattern.TemplateMethod.Relatorio
{
    public abstract class FormatoRelatorio
    {
        public string Imprimir (List<Conta> contas) 
        { 
            return Cabecalho() + "/n" + Corpo(contas) + "/n" + Rodape(); 
        }

        protected abstract string Cabecalho();
        protected abstract string Rodape();
        protected abstract string Corpo(List<Conta> contas);
    }
}
