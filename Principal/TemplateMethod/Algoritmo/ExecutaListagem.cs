namespace CursoDesignerPattern.TemplateMethod.Algoritmo
{
    public class ExecutaListagem
    {
        public ExecutaListagem()
        {
            List<string> estados = new List<string>()
            {
                "Minas Gerais",
                "Sergipe",
                "Paraíba",
                "Bahia",
                "Amazonas",
                "Tocantins",
                "Paraná",
                "Pernambuco",
                "Ceará"
            };

            foreach (string estado in new Estados().RetornarItens(estados))
            {
                Console.WriteLine(estado);
            }

            List<string> cidades = new List<string>()
            {
                "Campina Grande - PB",
                "Pelotas - RS",
                "São João Del Rey - MG",
                "Carpina - PE",
                "Joinville - SC",
                "Blumenau - SC",
                "Cabo de Santo Agostinho - PE",
                "Diamantina - MG",
                "Bonito - MS",
                "Campinas - SP",
                "Cabo Frio - RJ",
                "Petrópolis - RJ",
                "Sete Lagoas - MG",
                "Ilha do Governador - RJ",
                "Macaé - RJ",
                "Jundiaí - SP",
                "Tiradentes - MG",
                "Itatiba - SP",
                "Maragogi - AL",
                "Atibaia - SP"
            };

            foreach (var cidade in new Cidades().RetornarItens(cidades))
            {
                Console.WriteLine(cidade);
            }

        }
    }
}
