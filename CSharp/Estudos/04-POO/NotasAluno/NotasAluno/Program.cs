using AlunoClass;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do Aluno: ");
            string nome = Console.ReadLine();
            Aluno aluno = new Aluno(nome);


            Console.WriteLine("Digite as três notas do aluno: ");
            Console.Write("Nota 1: ");
            aluno.nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            aluno.nota2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            aluno.nota3 = double.Parse(Console.ReadLine());

            aluno.notafinal();
            aluno.resultado();
        }
    }
}
//penis