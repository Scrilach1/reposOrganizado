using System;
using register;
using account;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            RegistrationData registrationData = account.Registration();

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(registrationData);
        }
    }
}
