using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoWeb
{
    public class SemFormato : IFormato
    {     
        public IFormato Proxima { get;set; }

        public string Formatar(Conta conta, Requisicao requisicao)
        {
            return "Formato não identificado";
        }
    }
}
