using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoWeb
{
    public class ExibeFormatoCSV : IFormato
    {      

        private readonly IFormato? _proxFormato;
        public ExibeFormatoCSV(IFormato proxformato)
        {
            _proxFormato = proxformato;
        }

        public ExibeFormatoCSV() 
        {
            _proxFormato = null;        
        }

        public string Formatar(Conta conta, Requisicao requisicao)
        {
            if (EnumFormato.Formato.CSV == requisicao.Formato)
            {
                return $"Nome: {conta.Nome};Saldo: {conta.Saldo} ";
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
