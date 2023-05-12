using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.State.Contrato
{
    internal interface IEstadoContrato
    {
        void EmAndamento(Contrato contrato);
        void NaoAssinado(Contrato contrato);
        void Assinado(Contrato contrato);
    }
}
