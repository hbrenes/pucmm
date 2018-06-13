using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    class Escopeta : Arma
    {
        public override void Disparar()
        {
            //base.Disparar();
            Console.WriteLine("La escopeta hace Boom!");
        }

        public void Cachazo()
        { }
      
    }
}
