using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ScoreBoard
    {
        //Singleton
        private static ScoreBoard uniqueInstance;

        private ScoreBoard() { }

        public static ScoreBoard Create()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ScoreBoard();
            }

            return uniqueInstance;
        }

        public int HighScore { get; set; }
        public string HighScoreName { get; set; }

    }
}
