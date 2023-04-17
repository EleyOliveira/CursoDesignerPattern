using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.Builder
{
    public class NotaFiscalBuilder
    {
        private string razaoSocial;
        private string cnpj;
        private double valorBruto;
        private double valorImposto;
        private DateTime dataEmissao;
        private string observacoes;

        public NotaFiscalBuilder RazaoSocial(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder CNPJ(string cnpj)
        {
            this.cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ValorBruto(double valorBruto)
        {
            this.valorBruto = valorBruto;
            return this;
        }

        public NotaFiscalBuilder ValorImposto(double valorImposto)
        {
            this.valorImposto = valorImposto;
            return this;
        }

        public NotaFiscalBuilder DataEmissao(DateTime dataEmissao) 
        {
            this.dataEmissao = dataEmissao;
            return this;
        }

        public NotaFiscalBuilder Observacoes(string observacoes)
        {
            this.observacoes = observacoes;
            return this;
        }


    }
}
