namespace CursoDesignerPattern.TemplateMethod.Relatorio
{
    public class Conta
    {
        public string Titular { get; set; }
        public Int16 Agencia { get; set; }
        public Int16 Numero { get; set; }
        public double Saldo { get; set; }

        public DateTime DataAbertura { get; set; }
    }
}