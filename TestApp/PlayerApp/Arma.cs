using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    abstract class Arma
    {
        public virtual void Disparar()
        {
            Console.WriteLine($"El arma generica hace Boom!");
        }
    }
}
