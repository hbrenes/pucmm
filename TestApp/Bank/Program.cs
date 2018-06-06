using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Refactoring

            Contact contacto = new Contact("0012222222", "Hernando Brenes", "hbrenes@gmail.com", "Frank Felix Miranda 32", "809-729-2899", "123456789", 100);
            PrintBalance(contacto);
            //deposit 500
            contacto.Account.Deposit(500);

            PrintBalance(contacto);

            //withdrawl 700
            bool result = contacto.Account.Withdrawl(700);

            if (result == false)
            {
                Console.WriteLine("Fondos insuficientes.");
            }

            PrintBalance(contacto);

            result = contacto.Account.Withdrawl(400);

            PrintBalance(contacto);

            Console.Read();
        }

        public static void PrintBalance(Contact cont)
        {
            Console.WriteLine("The account balance is " + cont.Balance);
        }
    }
}
