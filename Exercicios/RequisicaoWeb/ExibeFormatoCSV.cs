using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoWeb
{
    public class ExibeFormatoCSV : IFormato
    {
        public IFormato Proxima { get; set; }

        public string Formatar(Conta conta, Requisicao requisicao)
        {
            if (EnumFormato.Formato.CSV == requisicao.Formato)
            {
                return $"Nome: {conta.Nome};Saldo: {conta.Saldo} ";
            }
            else
                return Proxima.Formatar(conta, requisicao);
        }
    }
}
