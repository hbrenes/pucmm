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
            Player player1 = new Player("Hernando", 10);
           

            Console.WriteLine("Player name is {0} and has {1} HP.", player1.Name, player1.HeathPoints);
            Console.WriteLine("Player name is " + player1.Name);



            player1.Walk();

            //TODO: Arreglar esto, debe ser parte del constructor.
            player1.HeathPoints = 1000;

            Console.WriteLine("Player 1 took damage, curren hp is {0}",player1.Attack(70));
            Console.WriteLine("Player 1 took damage, curren hp is {0}", player1.Attack(10));
            player1.Attack(5);
            Console.WriteLine("Current HP is {0}", player1.HeathPoints);

            player1.Attack(400);

            player1.Attack(10);

            
              


            //llamar el constructor

            Console.Read();
        }
    }
}
 