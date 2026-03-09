using Course;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Altura = double.Parse(Console.ReadLine());
            r.Largura = double.Parse(Console.ReadLine());
            r.Area();
            r.Perimetro();
            r.Diagonal();
            Console.WriteLine(r);
           
        }
    }
}