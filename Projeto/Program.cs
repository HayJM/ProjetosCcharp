using Projeto.Interfaces;
using Projeto.Models;
using System;

//--- Implemetação de interface calculadora

ICalculadora calculadora = new Calculadora();
Console.WriteLine("Soma: " + calculadora.Somar(5, 3));
Console.WriteLine("Subtração: " + calculadora.Subtrair(5, 3));
Console.WriteLine("Divisão: " + calculadora.Dividir(5, 3));
Console.WriteLine("Multiplicação: " + calculadora.Multiplicar(5, 3));























// // heraquia da classe Object
// Computador c1 = new Computador();
// Console.WriteLine(c1.ToString());

// intruções para o uso de classes seladas
// sealed class Pessoa 
// suas classes não podem ser herdadas

// // Exemplo de uso das classes Pessoa, Aluno e Professor paradigima de orientação a objetos
// // - herança - polimorfismo - construtores
// Pessoa p1 = new Pessoa("João");
// Aluno a1 = new Aluno("Maria");
// a1.Apresentar();

// // --------- Exemplo de uso das classes Conta e Conta Corrente  paradigima de orientação a objetos 
// //herança - abstract ---------

// Corrente c1 = new Corrente();
// c1.Creditar(1000);
// c1.ExibirSaldo();


// // --------- Exemplo de uso das classes Aluno e Professor paradigima de orientação a objetos 
// // - herança - polimorfimo  ---------

// Aluno a1 = new Aluno();
// a1.Nome = "Maria";
// a1.Idade = 20;
// a1.email = "maria@gmail.com";
// a1.Nota = 9.5m;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Carlos";
// p1.Idade = 40;
// p1.email = "carlos@gmail.com";
// p1.Salario = 5000m;
// p1.Apresentar();

// // --------- Exemplo de uso da classe ContaCorrente paradigima de orientação a objetos ---------

// ContaCorrente c1 = new ContaCorrente(12345, 1000);
// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();
// c1.Sacar(600); // Tentativa de saque com saldo insuficiente



// // --------- Exemplo de uso da classe Pessoa paradigima de orientação a objetos ---------

// Pessoa p1 = new Pessoa();
// p1.Nome = "João";
// p1.Idade = 30;
// p1.Apresentar();