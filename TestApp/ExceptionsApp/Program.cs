using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsApp
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.Write("Escribe tu nombre: ");

                string name = Console.ReadLine();

                if (name.ToLower() == "fuck")
                {
                    throw new NoBadWordException("No es un nombre valido.");
                }

                Console.WriteLine("Escribe un numero: ");

                int x = Int32.Parse(Console.ReadLine());



                Console.WriteLine("Escribe otro numero: ");

                int y = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"La division es: {x / y}");
            }
            catch (NoBadWordException ex)
            {
                Console.WriteLine("Pana, no se puede decir malas palabras");
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("Pana, no se puede dividir por cero. Trata again");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Hubo un error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Yo siempre corro.");
            }
            
            

            Console.Read();
        }
    }
}
