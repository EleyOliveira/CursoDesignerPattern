using CursoDesignerPattern.Builder;

namespace CursoDesignerPattern.Observer
{
    public class EnviaEmailNF : IAcaoPosGeracaoNF
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(this.ToString());
        }
    }
}
