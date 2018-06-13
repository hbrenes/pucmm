using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    class Metralleta : IArma
    {
        public void Disparar()
        {
            Console.WriteLine("La Metralleta hace BOOOOOOOOOOOOOMMMM!");
        }
    }
}
