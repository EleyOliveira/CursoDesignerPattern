using CursoDesignerPattern.Observer;
using CursoDesignerPattern.State;
namespace CursoDesignerPattern.TemplateMethod.Relatorio
{
    public class Conta
    {
        public string Titular { get; set; }
        public Int16 Agencia { get; set; }
        public Int16 Numero { get; set; }
        public double Saldo { get; set; }

        public DateTime DataAbertura { get; set; }
        public IEstadoConta Estado;

        private List<IAcaoPosDeposito> acaoPosDepositos;

        public Conta()
        {
            acaoPosDepositos = new();
        }

        public void AcrescentaAcaoPosDeposito(IAcaoPosDeposito acaoposDeposito)
        {
            acaoPosDepositos.Add(acaoposDeposito);
        }

        public void Saca(double valor)
        {
            Estado.Saque(this, valor);
        }

        public void Deposita(double valor) 
        { 
            Estado.Deposito(this, valor);

            foreach (var acao in acaoPosDepositos)
            {
                acao.Executa(this);
            }
        }
        
    }
}