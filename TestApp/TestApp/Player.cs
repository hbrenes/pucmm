using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Player
    {
        //Propiedades (variables) - Estado
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        //private int highScore;
        public int HighScore {

            get { return this.HighScore; }

        }
        public int HeathPoints { get; set; }
        public int Speed { get; set; }
        public Stance PlayerStance { get; set; }


        //Métodos (funciones) - Comportamiento
       public void Walk()
        {
            this.Speed = 5;
            this.PlayerStance = Stance.Standing;
            Console.WriteLine($"Player is walking at speed {Speed}");
        }
        void Run() { }
        void Shoot() { }
        void Jump() { }
        void Grab() { }
        void Drive() { }
        void Die()
        {
            Console.WriteLine("Player has died! Want to respawn? y o n?");
            Console.ReadLine();


        }

        public int TakeDamage(int damageLevel)
        {
            Console.WriteLine("Player took {0} of damage", damageLevel);
            if (damageLevel >= this.HeathPoints)
            {
                this.HeathPoints = 0;
                
                this.Die();
                return 0;
            }
            else
            {
                this.HeathPoints -= damageLevel;
            }
                
            return this.HeathPoints;
        }

        //Constructor
        //Tiene el nombre de la clase
        //No tiene valor de retorno
        //puede tener cero o más parámetros
        //usualmente es public
        public Player()
        {

        }

    }
}
