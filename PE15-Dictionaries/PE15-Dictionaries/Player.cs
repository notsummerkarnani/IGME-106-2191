using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Samar Karnani
 * PE15 Dictionaries
 * prof E. Cascioli
 * 29/02/20
 */

namespace PE15_Dictionaries
{
    class Player
    {
        private string name;
        private int score;

        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public override string ToString()
        {
            return $"Player {name}: Score = {score}";
        }


        //Accessors
        public string Name { get { return name; } }
        public int Score { get { return score; } }
    }
}
