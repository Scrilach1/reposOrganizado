using Microsoft.Win32;
using register;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace account
{
    public class Account
    {



        public Account()
        {
        }




        public RegistrationData Registration()
        {
            RegistrationData Register = new RegistrationData();
            int NumberAccount;
            Console.Write("Entre o número da conta: ");
            NumberAccount = int.Parse(Console.ReadLine());
            Console.WriteLine();


            string name;
            Console.Write("Entre o titular da conta: ");
            name = Console.ReadLine();
            Console.WriteLine();

            string entrada;
            bool entradaValida = false;
            double debt = 0;
            double balance = 0;

            do
            {
                Console.Write("Haverá depósito inicial? (s/n): ");
                entrada = Console.ReadLine()?.Trim().ToLower();

                if (entrada == "s" || entrada == "n")
                {
                    entradaValida = true;
                    Console.WriteLine($"Entrada válida registrada: {entrada}");
                    Console.WriteLine("Entre o valor de depósito incial: ");
                    Console.Write("R$");
                    debt = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite 's' para sim ou 'n' para não.");
                }
            } while (!entradaValida);


            balance = balance + debt;
            Console.WriteLine($"Saldo da conta é: R$ {balance:F2}");


            Register.Name = name;
            Register.NumAcc = NumberAccount;
            Register.Balance = balance;

            Debt(0);
            Sacar(0);


            return Register;
        }




        public double Debt(double debt)
        {
            RegistrationData Register = new RegistrationData();
            string entrada;
            bool entradaValida = false;

            do
            {
                Console.WriteLine("Deseja realizar um novo depósito? S/N");
                entrada = Console.ReadLine().ToUpper();
                if (entrada == "S")
                {
                    Console.WriteLine("Valor do depósito: ");
                    debt = double.Parse(Console.ReadLine());
                }
                else { entradaValida = true; }
            } while (entradaValida == false);
            return debt;
            Register.Balance += debt;
        }

        public double Sacar(double sac)
        {
         RegistrationData registrationData = new RegistrationData();

            double tax = 0.05;
        string entrada;
        bool entradaValida = false;
            do
            {
                Console.WriteLine("Deseja realizar um saque? S/N");
                entrada = Console.ReadLine().ToUpper();
                if (entrada == "S")
                {
                    Console.WriteLine("Valor do saque: ");
                    sac = double.Parse(Console.ReadLine());
                } else { entradaValida = true; }
            } while (entradaValida == false);
            return sac;
            Console.WriteLine($"Valor atual em caixa: R$ {registrationData.Balance}, Saque: {sac} - a taxa de 5%");
            registrationData.Balance = registrationData.Balance - sac * tax;
            Console.WriteLine($"Valor atual em caxia: R${registrationData.Balance.ToString("F2")}");

        }
    }
}
