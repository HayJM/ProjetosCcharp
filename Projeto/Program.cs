using Projeto.Models;
using System;

ContaCorrente c1 = new ContaCorrente(12345, 1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();
c1.Sacar(600); // Tentativa de saque com saldo insuficiente



















// // --------- Exemplo de uso da classe Pessoa paradigima de orientação a objetos ---------

// Pessoa p1 = new Pessoa();
// p1.Nome = "João";
// p1.Idade = 30;
// p1.Apresentar();