using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoWeb
{
    public class ExibeFormatoPorcentagem : IFormato
    {       

        private readonly IFormato? _proxFormato;
        public ExibeFormatoPorcentagem(IFormato proxFormato)
        {
            _proxFormato = proxFormato;            
        }

        public ExibeFormatoPorcentagem()
        {
            _proxFormato = null;
        }

        public string Formatar(Conta conta, Requisicao requisicao)
        {
            if (EnumFormato.Formato.PORCENTO == requisicao.Formato)
            {
                return $"Nome: {conta.Nome} % Saldo: {conta.Saldo}";
            }
            else if (_proxFormato != null)
            {
                return _proxFormato.Formatar(conta, requisicao);
            }
            else
                return "Formato Inválido";
        }
        
    }
}
