using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("Hernando");

            p1.score.HighScore = 100;
            p1.score.HighScoreName = p1.Name;


            var p2 = new Player("Sebastián");

            p2.score.HighScore = 200;
            p2.score.HighScoreName = p2.Name;

        }
    }
}
