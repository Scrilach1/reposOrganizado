using Course;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            //dados do produto
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());         
            Produto produto = new Produto(nome, preco, quantidade);
            Console.WriteLine("Dados do produto: " + produto);

            //ADD quantidades
            Console.WriteLine("Deseja adicionar quantas unidades em estoque?");
            int qnt = int.Parse(Console.ReadLine());
            produto.AddProd(qnt);
            Console.WriteLine("Dados do produto: " + produto);

            //Remover Quantidades
            Console.WriteLine("Deseja remover unidades em estoque?");
            qnt = int.Parse(Console.ReadLine());
            produto.RemProd(qnt);
            Console.WriteLine("Dados do produto: " + produto);

        }
    }
}