// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*/

/*
Questão:
Read 2 variables, named A and B and make the sum of these two variables, assigning its result to the variable X. Print X as shown below. Print endline after the result otherwise you will get “Presentation Error”.
Input

The input file will contain 2 integer numbers.
Output

Print the letter X (uppercase) with a blank space before and after the equal signal followed by the value of X, according to the following example.

Obs.: don't forget the endline after all..

Samples Input 	Samples Output

10                   X = 19
9
                      

-10                  X = -6
4


15                   X = 8
-7


using System;
using System.Numerics;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double x = A + B;


            Console.WriteLine("x = " + x);

        }
    }
}
*/

/* 

QUESTÃO 2:
The formula to calculate the area of a circumference is defined as A = π . R2. Considering to this problem that π = 3.14159:

Calculate the area using the formula given in the problem description.
Input

The input contains a value of floating point (double precision), that is the variable R.
Output

Present the message "A=" followed by the value of the variable, as in the example bellow, with four places after the decimal point. Use all double precision variables. Like all the problems, don't forget to print the end of line after the result, otherwise you will receive "Presentation Error".

 */
using System;
using System.Numerics;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, R;
            double n = 3.14159;
            R = double.Parse(Console.ReadLine());
            A = n * Math.Pow(R,2);
            A = Math.Round(A, 4);
            
            Console.WriteLine("A=" + A.ToString("F4"));

        }
    }
}


