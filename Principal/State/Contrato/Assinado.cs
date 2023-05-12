using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.State.Contrato
{
    internal class Assinado : IEstadoContrato
    {
        public void EmAndamento(Contrato contrato)
        {
            throw new NotImplementedException();
        }

        public void NaoAssinado(Contrato contrato)
        {
            throw new NotImplementedException();
        }

        void IEstadoContrato.Assinado(Contrato contrato)
        {
            throw new NotImplementedException();
        }
    }
}
