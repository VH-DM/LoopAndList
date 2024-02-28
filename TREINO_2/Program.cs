using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<string> pessoas = new List<string>();

        while (true)
        {
            Console.Write("Digite o nome da pessoa ou digite 'STOP': ");
            string nome = Console.ReadLine().Trim();

            if (nome.ToUpper() == "STOP")
                break;

            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Insira um nome válido.");
                continue;
            }
            if (Regex.IsMatch(nome, @"[^a-zA-Z\s]"))
            {
                Console.WriteLine("Por favor, insira apenas caractéres válidos.");
                continue;
            }

            pessoas.Add(nome);
        }

        Console.WriteLine("Lista de pessoas:");
        foreach (string pessoa in pessoas)
        {
            Console.WriteLine("- {0}",pessoa);
        }
    }
}
