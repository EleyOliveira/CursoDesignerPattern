using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoWeb
{
    public class Requisicao
    {
        public EnumFormato.Formato Formato { get; private set; }

        public Requisicao(EnumFormato.Formato formato)
        {
            this.Formato = formato;
        }
    }
}
