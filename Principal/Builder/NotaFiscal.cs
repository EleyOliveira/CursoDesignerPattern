using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.Builder
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cnpj, double valorBruto, double valorImposto, DateTime dataEmissao, string observacoes)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            ValorBruto = valorBruto;
            ValorImposto = valorImposto;
            DataEmissao = dataEmissao;
            Observacoes = observacoes;
        }

        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public double ValorBruto { get; set; }
        public double ValorImposto { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Observacoes { get; set; }
        public IEnumerable<ItemNota> itens { get; set; }        
    }
}
