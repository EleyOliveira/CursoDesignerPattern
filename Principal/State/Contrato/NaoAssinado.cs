using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.State.Contrato
{
    internal class NaoAssinado : IEstadoContrato
    {
        public void Assinado(Contrato contrato)
        {
            throw new NotImplementedException();
        }

        public void EmAndamento(Contrato contrato)
        {
            throw new NotImplementedException();
        }

        void IEstadoContrato.NaoAssinado(Contrato contrato)
        {
            throw new NotImplementedException();
        }
    }
}
