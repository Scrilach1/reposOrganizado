using System;
using System.Globalization;
using funcionario;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine());

            f1.SalarioLiquido();
            Console.WriteLine("Fucionario: " + f1);

            Console.Write("Digite a porcentagem para aumentar o Salário: ");
            double perc = double.Parse(Console.ReadLine());
            f1.AumentarSalario(perc);
            Console.WriteLine("Salario Atualizado: " + f1);
        }
    }
}