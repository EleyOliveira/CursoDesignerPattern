using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.Builder
{
    public class ItemNota
    {
        public ItemNota(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
