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
                string nombre = "Hernando";

                Console.WriteLine(nombre[nombre.Length-1]);
                Console.WriteLine(nombre.Substring(nombre.Length - 1, 1));

                string nameValue = "Hernando:Brenes";



                var parts = nameValue.Split(':');

                string dirtyString = "Hernando - ( Brenes(";

                var cleanString = dirtyString.Replace("(", string.Empty).Replace("-", string.Empty);

                int val = 560;

                Console.WriteLine(val.ToString().PadLeft(6, '0'));

                Console.WriteLine(nombre.Substring(0, 3));

                Console.Write("Escribe tu nombre: ");

                string name = Console.ReadLine();

                if (name.ToLower() == "fuck")
                {
                    throw new NoBadWordException("No es un nombre valido.", name);
                }

                Console.WriteLine("Escribe un numero: ");

                int x = Int32.Parse(Console.ReadLine());



                Console.WriteLine("Escribe otro numero: ");

                int y = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"La division es: {x / y}");
            }
            catch (NoBadWordException ex)
            {
                Console.WriteLine($"Pana, no se puede decir malas palabras: charcount: {ex.charCount}");
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
