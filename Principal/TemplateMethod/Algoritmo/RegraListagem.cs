namespace CursoDesignerPattern.TemplateMethod.Algoritmo
{
    public abstract class RegraListagem
    {       

        public List<string> RetornarItens(List<string> lista)
        {
            if (DeveRetornarTodosItens(lista))
            {
                return RetornarTodosItens(lista);
            }
            else
            {
                return RetornarMetadeItens(lista);
            }
        }

        protected abstract List<string> RetornarMetadeItens(List<string> lista);
        protected abstract List<string> RetornarTodosItens(List<string> lista);
        protected abstract bool DeveRetornarTodosItens(List<string> lista);
    }
}
