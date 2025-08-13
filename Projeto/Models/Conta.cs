using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public abstract class Conta
    {
        protected decimal Saldo { get; set; }

        public abstract void Creditar(decimal valor);
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo:C}");
        }


        
    }
}