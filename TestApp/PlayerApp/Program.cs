using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escopeta e = new Escopeta();
            //Revolver r = new Revolver();

            //e.Disparar();
            //r.Disparar(); 

            Arma miArma = new Revolver();
            miArma.Disparar();
            
            miArma = new Escopeta();
            miArma.Disparar();
            


            IArma suArma = new Metralleta();

            suArma.Disparar();

            suArma = new Bazooka();

            suArma.Disparar();

            Console.ReadLine();
        }
    }
}
