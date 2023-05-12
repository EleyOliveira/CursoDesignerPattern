namespace CursoDesignerPattern.TemplateMethod.Algoritmo
{
    public class Estados : RegraListagem
    {
        protected override bool DeveRetornarTodosItens(List<string> lista)
        {
            return lista.Count < 10;
        }

        protected override List<string> RetornarMetadeItens(List<string> lista)
        {
            return lista.Take(lista.Count() / 2).ToList();
        }

        protected override List<string> RetornarTodosItens(List<string> lista)
        {
            return lista;
        }
    }
}
