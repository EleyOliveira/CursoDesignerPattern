using CursoDesignerPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.Builder
{
    public class MontaNotaFiscal
    {
        public MontaNotaFiscal() 
        { 
            NotaFiscalBuilder notaFiscalBuilder = new NotaFiscalBuilder();

            notaFiscalBuilder.InformaRazaoSocial("Empresa Malucos S.A.")
                .InformaCNPJ("12.345.678.0009-99")
                .InformaObservacoes("Essa empresa é muito doida")
                .NaData(Convert.ToDateTime("15/02/2022"))
                .AdicionaItem("muita maluquice", 120)
                .AdicionaItem("Birutice", 450)
                .AdicionaItem("Doideira", 380)
                .AcrescentaAcaoPosGeracao(new GravaBancoDadosNF())
                .AcrescentaAcaoPosGeracao(new EnviaEmailNF());

            NotaFiscal notaFiscal = notaFiscalBuilder.Constroi();

            Console.WriteLine($"Nome da empresa: {notaFiscal.RazaoSocial}");
            Console.WriteLine($"CNPJ: {notaFiscal.CNPJ}");
            Console.WriteLine($"Observações: {notaFiscal.Observacoes}");
            Console.WriteLine($"Valor Bruto: {notaFiscal.ValorBruto}");
            Console.WriteLine($"Valor Imposto: {notaFiscal.ValorImposto}");
            Console.WriteLine($"Data de emissão: {notaFiscal.DataEmissao}");

            foreach (var item in notaFiscal.Itens)
            {
                Console.WriteLine($"Descrição: {item.Descricao} Valor: {item.Valor}");
            }
            
        }
    }
}
