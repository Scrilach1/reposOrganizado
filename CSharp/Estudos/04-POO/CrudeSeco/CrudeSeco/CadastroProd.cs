using System;
using product;

namespace cadastro
{
    public class Cadastro
    {
        public Cadastro()
        {
        }
        public Product CadastraProdutos(int id)
        {
            Product product = new Product();
            id += 1;

            string name;
            Console.Write("Digite o nome do produto: ");
            name = Console.ReadLine();

            double price;
            Console.Write("Digite o valor do produto: ");
            price = double.Parse(Console.ReadLine().ToString());

            int quantity;
            Console.Write("Quantidade em estoque: ");
            quantity = int.Parse(Console.ReadLine());

            string description;
            Console.Write("Descrição: ");
            description = Console.ReadLine();


            product.Name = name;
            product.Price = price;
            product.Quantity = quantity;
            product.Description = description;
            return product;
        }

        public Product EditProd(Product product)
        {
            string name;
            Console.Write("Digite o nome do produto: ");
            name = Console.ReadLine();

            double price;
            Console.Write("Digite o valor do produto: ");
            price = double.Parse(Console.ReadLine().ToString());

            int quantity;
            Console.Write("Quantidade em estoque: ");
            quantity = int.Parse(Console.ReadLine());

            string description;
            Console.Write("Descrição: ");
            description = Console.ReadLine();


            product.Name = name;
            product.Price = price;
            product.Quantity = quantity;
            product.Description = description;
            return product;

        }
    }
}
