using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    class Revolver : Arma
    {
        public override void Disparar()
        {
            //base.Disparar();
            Console.WriteLine("El revolver hace Boom!");
        }
    }
}
