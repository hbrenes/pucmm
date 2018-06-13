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
            






            //string[] arr = new string[3]; //{5, 6, 8,10,50 };

            //arr[0] = "Hola";
            //arr[1] = "Como";
            //arr[2] = "Estas";

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Position {i}: {arr[i]}");
            //}

            //List<string> names = new List<string>();
            //names.Add("Juan");
            //names.Add("Pedro");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}




            //Refactoring

     /*
            var contacto = new Contact("0012222222", "Hernando Brenes", "hbrenes@gmail.com", "Frank Felix Miranda 32", "809-729-2899", "123456789", 100);
            PrintBalance(contacto);

            


            //deposit 500
            contacto.Deposit("123456789", 500);

            PrintBalance(contacto);

            //withdrawl 700
            bool result = contacto.Withdrawl("123456789", 700);

            if (result == false)
            {
                Console.WriteLine("Fondos insuficientes.");
            }

            PrintBalance(contacto);

            result = contacto.Withdrawl("123456789", 400);

            PrintBalance(contacto);

            contacto.CreateBankAccount("2222", 100, BankAccountType.Checking);

            PrintBalance(contacto);

            contacto.Deposit("2222", 500);

            PrintBalance(contacto);

            //switch (contacto.Account.Type)
            //{
            //    case BankAccountType.Savings:
            //    case BankAccountType.SuperSuperSavings:
            //        Console.WriteLine("This is a savings account.");


            //        //Console.WriteLine("This is a super super savings account.");
            //        break;
            //    case BankAccountType.Checking:
            //        break;
            //    default:
            //        break;
            //}

        */
            Console.Read();
        }

        public static void PrintBalance(Contact cont)
        {
            Console.WriteLine("The account balance is " + cont.Balance);
        }
    }
}
