using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

/* Samar Karnani
 * PE15 Dictionaries
 * prof E. Cascioli
 * 29/02/20
 */

namespace PE15_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Player> dictionary = new Dictionary<string, Player>();

            //Adds Players to dict
            for (int i = 0; i < 100; i++)
            {
                Player player = new Player($"P{i+1}", 0);
                dictionary.Add(player.Name, player);
            }

            string input = "";
            //Asks the user for the player they want to search for and prints accordigly
            while (input != "QUIT")
            {
                Console.WriteLine("Please enter the name of the player you want to search for or type \"QUIT\" to exit");
                input = Console.ReadLine();
                Console.WriteLine();

                if(dictionary.ContainsKey(input))
                {
                    Console.WriteLine(dictionary[input].ToString());
                }
                else
                {
                    if(input!="QUIT")
                    {
                        Console.WriteLine("Player not found!");
                    }
                }
            }


            Console.WriteLine("\n PART 2 - PERFORMANCE TESTING");
            List < Player > list = new List<Player>();
            Stopwatch stopwatch = new Stopwatch();
            Random rng = new Random();
            dictionary.Clear();

            //Adds players to list and dict
            for(int i = 0; i<100000; i++)
            {
                Player player = new Player($"P{i + 1}", rng.Next(101));
                dictionary.Add(player.Name, player);
                list.Add(player);
            }

            //Times the time taken for the dict
            stopwatch.Start();
            Player lastPlayer = dictionary[$"P{dictionary.Count}"];
            stopwatch.Stop();
            Console.WriteLine($"Total Time (dict) = {stopwatch.ElapsedMilliseconds}");

            //Times the time taken for the list
            stopwatch.Restart();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[0].Name == $"P{list.Count}")
                {
                    Console.WriteLine("Player found in list!");
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Total Time (list) = {stopwatch.ElapsedMilliseconds}");
        }

    }
}
