using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Hospede
    {
        static void Main()
        {
        // Lê a entrada como uma string no formato: Nome, Número do Quarto, Número de Diárias
        // entrada -Aline, 101, 3	
        // saida - Aline vai se hospedar no quarto 101 por R$450
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Entrada inválida. Por favor, forneça os dados no formato correto.");
            return;
        }

        // Divide a string pelos separadores de vírgula
            string[] parts = input.Split(',');
            if (parts.Length != 3)
            {
            Console.WriteLine("Entrada inválida. Por favor, forneça os dados no formato correto: Nome, Número do Quarto, Número de Diárias.");
            return; 
        }

        // Extrai e trata os dados de entrada
        string guestName = parts[0].Trim();            // Nome do hóspede
        int roomNumber = int.Parse(parts[1].Trim());   // Número do quarto
        int days = int.Parse(parts[2].Trim());         // Quantidade de diárias


            // TODO: Calcule o valor total da estadia (R$150 por diária)
            const decimal dailyRate = 150m; // Valor da diária
            decimal totalCost = dailyRate * days;


            // TODO: Exiba a mensagem formatada conforme solicitado
            Console.WriteLine($"{guestName} vai se hospedar no quarto {roomNumber} por R${totalCost}");
        }
    }
}