/*
using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            double[] N = new double[v];
            for (int i = 0; i < N.Length; i++) //vai ir daposição 0 até o final do vetor que eu criei 0<N incrementando 1 a mais pra ir passando as posições
            {
                N[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }
            for (int i = 0; i < N.Length; i++) {

                Console.WriteLine(N[i].ToString("F1"), CultureInfo.InvariantCulture);
            }
        }
    }
}
*/

/*
using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            double[] N = new double[v];
            String[] separadores = Console.ReadLine().Split(' ');
            for (int i = 0;i<N.Length; i++)
            { N[i] = double.Parse(separadores[i]);}
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] < 0) { Console.WriteLine(N[i].ToString("F1"), CultureInfo.InvariantCulture); }                
            }
        }
    }
}
*/

/*
using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace MyApp
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            String[] s = Console.ReadLine().Split(' ');
            double soma = 0;
            double media = 0;
            // pegar o conteúdo do array em string do s[] e alocar no vet[]
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(s[i]);
            }
            //escrever o conteúdo de cada posição do array
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i].ToString("F1") + " ", CultureInfo.InvariantCulture);
            }
            Console.WriteLine();
            //vai percorrer o array somando os valores de cada posição
            for (int i = 0; i < vet.Length; i++) // soma dos valores
            {
                soma = soma + vet[i]; 
            }
            Console.WriteLine(soma.ToString("F2"), CultureInfo.InvariantCulture);
            //vai fazer a média pegando o total da soma e dividindo pela quantidade de valores somados.
            media = soma / n;
            Console.WriteLine(media.ToString("F2"), CultureInfo.InvariantCulture);   
        }
    }
}
*/


/* Fazer um programa para ler um número N, depois nome (apenas uma palavra), idade e altura de N pessoas, conforme exemplo.
Depois, mostrar na tela a altura média das pessoas, e mostrar também a porcentagem de pessoas com menos de 16 anos.
*/
using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] altura = new double[n];
            String[] nome = new string[n];
            int[] idade = new int[n];

            
            for (int i = 0; i < n; i++)
            {
                String[] s = Console.ReadLine().Split(' ');
                nome[i] = (s[0]);
                idade[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2]);
            }
            double altmed = 0.0;
            double alttotal = 0.0;
            for (int i = 0; i < n; ++i)
            {
                alttotal += altura[i];
            }
            altmed = alttotal / n;
            Console.WriteLine("A altura média dos alunos é de: " + altmed.ToString("F2", CultureInfo.InvariantCulture));

            double dmenor = 0.0;
            double dmenortotal = 0.0;
            for (int i = 0; i < n; ++i) 
            { 
            if (idade[i] < 16)
                {
                    dmenor++;
                }

            }
            dmenortotal = (dmenor / n) * 100;
            Console.WriteLine(("Pessoas com menos de 16 anos: ") + dmenortotal.ToString("F1", CultureInfo.InvariantCulture) + "%");

        }
    }
}
