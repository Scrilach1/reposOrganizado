using System;
using product;
using cadastro;
using menu;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            int EditProduct = 2;
            int RemProduct = 3;

            List<Product> products = new List<Product>();
            Menu menu = new Menu();

            Console.WriteLine("Cadastro de Produtos");
            Console.WriteLine("1: Adicionar Produtos");
            Console.WriteLine("2: Editar Produtos");
            Console.WriteLine("3: Remover Produtos");



            do
            {
                int Select = int.Parse(Console.ReadLine());

                switch (Select)
                {
                    case 1:
                        products = menu.AddProd(products);
                        break;
                    case 2:
                        Console.WriteLine("Para remover um produto, você precisa informar o ID dele.");
                        products = menu.EditProd(products, id);
                        break;
                    case 3: products = menu.RemProd(products, id);
                        break;
                }

            } while ();
        }
    }
}