using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciar una clase

            //el tipo de dato de la clase
            //una variable que haga referencia al objeto
            Player player1 = new Player();
            player1.Name = "Hernando";
            Console.WriteLine("Player name is " + player1.Name);



            player1.Walk();
            player1.HeathPoints = 100;

            Console.WriteLine("Player 1 took damage, curren hp is {0}",player1.TakeDamage(70));
            Console.WriteLine("Player 1 took damage, curren hp is {0}", player1.TakeDamage(10));
            player1.TakeDamage(5);
            Console.WriteLine("Current HP is {0}", player1.HeathPoints);

            player1.TakeDamage(400);

            

            
              


            //llamar el constructor

            Console.Read();
        }
    }
}
 