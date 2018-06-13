using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    class Bazooka : IArma
    {
        public void Disparar()
        {
            Console.WriteLine("La Bazooka hace BOOOOOOOOOOOOOMMMM!");
        }
    }
}
