using CursoDesignerPattern.Builder;

namespace CursoDesignerPattern.Observer
{
    public class GravaBancoDadosNF : IAcaoPosGeracaoNF
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(this.ToString());
        }
    }
}
