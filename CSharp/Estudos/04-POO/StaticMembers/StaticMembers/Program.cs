using System;
using esfera;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esf = new Esfera();
            Console.Write("Entre com o valor do Raio: ");
            esf.Raio = double.Parse(Console.ReadLine());

            
            esf.Circunferencia();
            esf.Volume();

            Console.WriteLine("Circunferência: " + esf.Circunferencia());
            Console.WriteLine("Volume: " + esf.Volume().ToString("F2"));
            Console.WriteLine("Valor de PI: " + esf.Pi);
        }
    }
}