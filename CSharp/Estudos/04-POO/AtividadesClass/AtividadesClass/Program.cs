using System;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());

            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa;");
            Console.WriteLine($"Nome: {p1.nome}");
            Console.WriteLine($"Idade: {p1.idade}");

            Console.WriteLine("Dados da segunda pessoa;");
            Console.WriteLine($"Nome : {p2.nome}");
            Console.WriteLine($"Idade: {p2.idade}");

            Console.WriteLine();

            if (p1.idade > p2.idade)
            {Console.WriteLine($"A pessoa mais velha é : {p1.nome}");}

            else
            {Console.WriteLine($"A pessoa mais velha é : {p2.nome}"); }
        }
    }
}