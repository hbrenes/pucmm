using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Player
    {
        public ScoreBoard score;

        public Player(string name)
        {
            this.Name = name;
            this.score = ScoreBoard.Create();
        }

        public string Name { get; set; }

    }
}
