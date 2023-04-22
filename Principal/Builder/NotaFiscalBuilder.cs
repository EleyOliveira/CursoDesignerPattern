using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.Builder
{
    public class NotaFiscalBuilder
    {
        private String RazaoSocial { get; set; }
        private String CNPJ { get; set; }        
        private double ValorBruto { get; set; }
        private double ValorImposto { get; set; }
        private DateTime? DataEmissao { get; set; }
        private String Observacoes { get; set; }

        private List<ItemNota> itens = new();

        public NotaFiscalBuilder()
        {
            this.DataEmissao = DateTime.Now;
        }

        public NotaFiscalBuilder InformaRazaoSocial(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder InformaCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
            return this;
        }
        
        public NotaFiscalBuilder NaData(DateTime data) 
        {            
            this.DataEmissao = (DateTime)data;
            return this;
        }

        public NotaFiscalBuilder InformaObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder AdicionaItem(string descricao, double valor)
        {
            ItemNotaBuilder itemNotaBuilder = new ItemNotaBuilder();

            itemNotaBuilder.InformeDescricao(descricao)
                .InformeValor(valor);

            itens.Add(itemNotaBuilder.Constroi());
            ValorBruto += valor;
            ValorImposto += valor * 0.05;

            return this;
        }

        public NotaFiscal Constroi()
        {            
            return new NotaFiscal(RazaoSocial, CNPJ, ValorBruto, ValorImposto, (DateTime)DataEmissao, Observacoes, itens);
        }
    }
}
