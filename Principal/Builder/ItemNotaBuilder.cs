using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPattern.Builder
{
    public class ItemNotaBuilder
    {
        private string Descricao { get; set; }
        private double Valor { get; set; }

        public ItemNotaBuilder InformeDescricao(string descricao)
        {
            this.Descricao = descricao;
            return this;
        }

        public ItemNotaBuilder InformeValor(double valor)
        { 
            this.Valor = valor; 
            return this; 
        }

        public ItemNota Constroi()
        {
            return new ItemNota(Descricao, Valor);
        }
    }
}
