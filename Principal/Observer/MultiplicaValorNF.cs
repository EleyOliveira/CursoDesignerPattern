using CursoDesignerPattern.Builder;

namespace CursoDesignerPattern.Observer
{
    public class MultiplicaValorNF : IAcaoPosGeracaoNF
    {
        private double Fator { get; set; }

        public MultiplicaValorNF(double fator)
        {
            Fator = fator;
        }

        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine($"Valor da nota multiplicado por {Fator} é: {notaFiscal.ValorBruto * Fator}");
        }
    }
}
