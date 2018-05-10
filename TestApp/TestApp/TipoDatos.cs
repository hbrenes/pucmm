using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class TipoDatos
    {
        public void Run()
        {
            //identificador
            //tipo de datos
            //valor
            //direccion de memoria

            //tipo de dato   identificador 

            int x = 0;
            int y = 0;

            //fully qualified name
            Console.WriteLine("Escriba un numero: ");
            string numero1 = Console.ReadLine();

            Console.WriteLine("Escriba otro numero: ");
            string numero2 = Console.ReadLine();

            x = int.Parse(numero1);
            y = int.Parse(numero2);

            Console.WriteLine("La suma es: {0}", x + y);
        }
    }
}
