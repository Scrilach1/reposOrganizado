using System;

namespace salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pessoa f1 = new pessoa();
            pessoa f2 = new pessoa();
            double media;

            Console.WriteLine("Digite o nome do primeiro funcionário e sálário;");

            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();

            Console.Write("Salario: ");
            f1.salary = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Digite o nome do segundo funcionário e salário: ");

            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();

            Console.Write("Salario: ");
            f2.salary = int.Parse(Console.ReadLine());

            Console.WriteLine($"{media = (f1.salary + f2.salary) / 2 } O salario médio dos funcionários é de = R${media}");
            
        }
    }
}

