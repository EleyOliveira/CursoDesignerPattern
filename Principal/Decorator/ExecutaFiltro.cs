using CursoDesignerPattern.TemplateMethod.Relatorio;

namespace CursoDesignerPattern.Decorator
{
    public class ExecutaFiltro
    {
        public ExecutaFiltro()
        {
            Conta conta = new Conta { Titular="João", Saldo=231.99};
            Conta conta2 = new Conta { Titular = "Pedro", Saldo = 58.32 };
            Conta conta3 = new Conta { Titular = "Sandra", Saldo = 625489.65 };

            IList<Conta> contas = new List<Conta> { conta, conta2, conta3};

            SaldoMaiorFiltro saldoMaiorFiltro = new (new SaldoMenorFiltro());
            IList<Conta> resultado = saldoMaiorFiltro.Filtra(contas);

            foreach (var item in resultado)
            {
                Console.WriteLine($"Titular: {item.Titular} Saldo: {item.Saldo}");
            }
            
        }
    }
}
