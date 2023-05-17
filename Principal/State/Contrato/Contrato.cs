using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.State.Contrato
{
    internal class Contrato
    { 
        public Contrato() 
        {
            Estado = null;
        }
        public string Numero {get; set;}
        public EstadoContrato? Estado { get; set; }
    }
}
