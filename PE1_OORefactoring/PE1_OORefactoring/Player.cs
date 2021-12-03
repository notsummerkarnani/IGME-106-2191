using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE1_OORefactoring
{
    class Player
    {
        string name;
        int score;

        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        //gets the number of players form the user and returns it
        public static int NumPlayers()
        {
            int numPlayers;
            do
            {
                Console.WriteLine("Please enter the number of players. Minimum number of players = 2, maximum nnumber of players = 10");
                int.TryParse(Console.ReadLine(), out numPlayers);
                Console.WriteLine("\n\n");

                if (!(numPlayers <= 10 && numPlayers >= 2))
                {
                    Console.WriteLine("Invalid Input! Minimum number of players = 2, maximum nnumber of players = 10");
                }
            } while (!(numPlayers <= 10 && numPlayers >= 2));
            return numPlayers;
        }

        //Accessors
        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
        }
    }
}
