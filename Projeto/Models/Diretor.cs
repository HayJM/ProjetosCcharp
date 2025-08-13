using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public sealed class Diretor : Pessoa
    {
                public Diretor() { }
        public Diretor(string nome) : base(nome)
        {
        }
        public decimal Salario { get; set; }


        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, Sou Diretor e meu salário é {Salario:C}.");
        }
        
    }
}