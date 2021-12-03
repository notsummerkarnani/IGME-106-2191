using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* Name: Samar Karnani
 * Date: 15/01/19
 * Purpose: PE1 OOPRefactoring
 */

namespace PE1_OORefactoring
{
    class Program
    {
        /* 1. Because the thread cycle has not been suspended between assigning player scores
         * 2. 100
         * 3. It assumes that the entered value will be an integer. It does not limit the player from entering a number above 5.
         * 4. The storage of player names and scores must be changed to a list
         */
        static void Main(string[] args)
        {
            //Calls the Numplayers Method and assigns the returned value to numPlayers
            int numPlayers = Player.NumPlayers();

            Player[] players = new Player[numPlayers];
            string[] names = new string[numPlayers];
            int[] scores = new int[numPlayers];
            Random rng = new Random();

            //Gets the names of each of the players and puts them in a list. Also Generates the scores for players and puts them in a list
            for (int i = 0; i < numPlayers; i++)
            {
                do
                {
                    Console.WriteLine("Please enter the name for player " + (i + 1) + ": ");
                    names[i] = Console.ReadLine();

                    if (string.IsNullOrEmpty(names[i]))
                    {
                        Console.WriteLine("Invalid Input! Please enter a name!");
                    }
                } while (string.IsNullOrEmpty(names[i]));
                scores[i] = rng.Next(101);
            }

            //Creates new player objects and assigns them names and scores
            for (int i = 0; i < numPlayers; i++)
            {
                players[i] = new Player(names[i], scores[i]);
            }


            // Print each player's info
            foreach (Player value in players)
            {
                Console.WriteLine($"Name: {value.Name} || Score: {value.Score}");
            }

            // Print the winner
            foreach (Player value in players)
            {
                if(value.Score == scores.Max())
                {
                    Console.WriteLine($"\n\nWinner: {value.Name} || score: {value.Score}");
                }
            }
        }
    }
}
