using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoWeb
{
    public class Conta
    {
        public double Saldo { get; private set; } 
        public string? Nome { get; private set; }

        public Conta(string nome, double saldo)
        {
            this.Saldo = saldo;
            this.Nome = nome;
        }
    }
}
