using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoWeb
{
    public class ExibeFormatoPorcentagem : IFormato
    {
        public IFormato Proxima { get; set; }

        private readonly IFormato _proxFormato;
        public ExibeFormatoPorcentagem(IFormato proxFormato)
        {
            _proxFormato = proxFormato;            
        }

        public string Formatar(Conta conta, Requisicao requisicao)
        {
            if (EnumFormato.Formato.PORCENTO == requisicao.Formato)
            {
                return $"Nome: {conta.Nome} % Saldo: {conta.Saldo}";
            }
            else
                return _proxFormato.Formatar(conta, requisicao);        
        }
        
    }
}
