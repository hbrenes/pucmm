using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Player
    {

        #region Propiedades
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
        public int HighScore { get; set; }
        public int HeathPoints { get; set; }
        public int Speed { get; set; }
        public Stance PlayerStance { get; set; }

        #endregion

        #region Métodos (funciones) - Comportamiento
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



        public int Attack(int damageLevel)
        {
            Random rnd = new Random();
            int randomNum = rnd.Next();

            if (randomNum == 3)
            {
                return this.Attack(damageLevel, true);
            }
            else
                return this.Attack(damageLevel, false);
        }

        private int Attack(int damageLevel, bool isMiss)
        {
            if (isMiss)
            {
                Console.WriteLine("Player miss!");
                return this.HeathPoints;
            }
            

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

        public int Attack(double damageLevel)
        {
            return 5;
        }

        #endregion

        //Constructor
        //Tiene el nombre de la clase
        //No tiene valor de retorno
        //puede tener cero o más parámetros
        //usualmente es public
        public Player()
        {
            this.HeathPoints = 100;
        }

        public Player(string name) : this() //this() permite llamar una sobrecarga del constructor antes de correr este constructor.
        {
            this.name = name;
        }

        public Player(string name, int score) : this(name)
        {
            this.HighScore = score;
        }

        ~Player()
        {

        }

    }
}
