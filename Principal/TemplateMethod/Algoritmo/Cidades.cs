namespace CursoDesignerPattern.TemplateMethod.Algoritmo
{
    public class Cidades : RegraListagem
    {
        protected override bool DeveRetornarTodosItens(List<string> lista)
        {
            return lista.Count() < 20;
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
