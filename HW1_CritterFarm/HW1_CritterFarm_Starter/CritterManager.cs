using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

/* Samar Karnani
 * Prof E. Cascioli
 * 28/01/19
 * HW1 Critter Farm
 */

namespace HW1_CritterFarm_Starter
{
    class CritterManager
    {
        // ** Enter fields here: **
        private List<Critter> critters;
        private Critter activeCritter;
        private string filename;

        // ** Complete ActiveCritter property here: **
        public Critter ActiveCritter
        {
            get
            {
                return activeCritter;
            }
        }


        public CritterManager()
        {
            // ** Complete constructor **
            critters = new List<Critter>();
            activeCritter = null;
            filename = @"C:\Users\Samar_K14501\OneDrive\RESOURCES\GDAPS 2\HW1_CritterFarm\HW1_CritterFarm_Starter\critterData.txt";
            
        }


        // ---------------------------------------------------------------------------------------------------------------
        // Critter initialization, loading and saving
        // ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Initial setup of critters. 
        /// Prompts a user for a number of critters, then their names,
        /// then adds newly instantiated critters to the critter list.
        /// All critters start with 0 hunger and 0 boredom.
        /// </summary>
        public void SetupCritters()
        {
            int numCrit;
            
            Console.WriteLine("How many critters would you like?");
            string input = Console.ReadLine();
            int.TryParse(input, out numCrit);

            for(int i = 0; i<numCrit; i++)
            {
                Console.WriteLine($"What would you like to name critter {i + 1}");
                Critter critter = new Critter(Console.ReadLine().Trim());
                critters.Add(critter);
            }


        }


        /// <summary>
        /// Loads critter data from a file.
        /// If there are no saved critters, allow user to enter their
        /// own critters.
        /// If file data exists, populates critterList with critters
        /// built from the file's data.
        /// </summary>
        public void LoadCrittersFromFile()
        {
            string[] save;
            save = File.ReadAllLines(filename);
            
            foreach(string value in save) //uses data from each line to set attributes for the critter
            {
                string sub = value.Substring(value.IndexOf(' ')+1);
                string[] fields = sub.Split('|');

                critters.Add(new Critter(fields[0], int.Parse(fields[1]), int.Parse(fields[2])));
            }
            if(save.Length<=0)
            {
                Console.WriteLine("You don't have saved data");
                SetupCritters();
            }
        }


        /// <summary>
        /// Saves critter data to a file.
        /// </summary>
        public void SaveCrittersToFile()
        {
            // ********************************
            // File name: critterData.txt
            // File structure (sample line):
            // Critter name|hunger|boredom
            // ********************************
            string[] save = new string[critters.Count];

            for(int i = 0; i<critters.Count; i++)
            {
                string line = $"Critter {critters.ElementAt(i).Name}|{critters.ElementAt(i).Hunger}|{critters.ElementAt(i).Boredom}";
                save[i] = line;
            }

            File.WriteAllLines(filename, save);
        }


        // ---------------------------------------------------------------------------------------------------------------
        // Critter Control
        // ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Sets the active critter to one of the critters in the critter list.
        /// </summary>
        /// <param name="critterName">Name of critter to set the active critter to</param>
        /// <returns>Whether this operation was successful</returns>
        public bool ChooseCritter(string critterName)
        {
            activeCritter = GetCritter(critterName); 
            bool exists = GetCritterNames().Contains(critterName);

            return exists;
        }


        /// <summary>
        /// Retrieves a critter with the specified name.
        /// </summary>
        /// <param name="critterName">Name of the critter to retrieve</param>
        /// <returns>Critter with the specified name. If critter does not exist, returns null.</returns>
        public Critter GetCritter(string critterName)
        {
            bool exists = GetCritterNames().Contains(critterName);
            
            if(exists == true)
            {
                return critters.ElementAt(GetCritterNames().IndexOf(critterName));
            }
            return null;
        }


        /// <summary>
        /// Retrieves a list of the names of all current critters
        /// </summary>
        /// <returns>List of names of all critters</returns>
        public List<string> GetCritterNames()
        {
            List<string> names = new List<string>();
            foreach(Critter critter in critters)
            {
                names.Add(critter.Name);
            }
            return names;
        }


        // ---------------------------------------------------------------------------------------------------------------
        // Critter Actions
        // ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Feeds the active critter 4 units of food.
        /// </summary>
        public void FeedCritter()
        {
            if (activeCritter == null)
            {
                return;
            }
            activeCritter.Eat(4);

        }


        /// <summary>
        /// Plays with the active critter for 4 fun units.
        /// </summary>
        public void PlayWithCritter()
        {
            if (activeCritter == null)
            {
                return;
            }
            activeCritter.Play(4);

        }


        /// <summary>
        /// Talks with the active critter.
        /// </summary>
        public void TalkToCritter()
        {
            if (activeCritter == null)
            {
                return;
            }
            activeCritter.Talk();

        }


        // ---------------------------------------------------------------------------------------------------------------
        // Methods called on Every Critter 
        // ---------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Simulates time passing for every critter for every "round" of user actions.
        /// </summary>
        public void TimePassing()
        {
            foreach(Critter critter in critters)
            {
                critter.PassTime(1);
            }
        }


        /// <summary>
        /// Prints critter data about every critter in the list.
        /// Helpful for testing. 
        /// </summary>
        public void PrintCritters()
        {
            foreach(Critter critter in critters)
            {
                Console.WriteLine($"Critter name:{critter.Name} || hunger:{critter.Hunger} || boredom:{critter.Boredom}");
            }

        }
    }
}
