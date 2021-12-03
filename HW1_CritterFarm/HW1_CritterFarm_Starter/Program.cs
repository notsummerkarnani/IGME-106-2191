using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Samar Karnani
 * Prof E. Cascioli
 * 28/01/19
 * HW1 Critter Farm
 */

namespace HW1_CritterFarm_Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            CritterManager manager = new CritterManager();

            // ------------------------------------------------------------------
            // Welcome the user
            // ------------------------------------------------------------------
            Console.WriteLine("Welcome to the Critter Farm!");
            Console.WriteLine();
            Console.WriteLine("Your job is to keep all of the critters happy.");
            Console.WriteLine("Critters become hungry when they are not fed,");
            Console.WriteLine("and bored when they are not entertained.");
            Console.WriteLine();
            Console.WriteLine("Choose '1' to start a new game, ");
            Console.WriteLine("or '2' to continue from the last save.");

            // Load old save? Or new game? Grab user's preference and validate
            string userChoice = Console.ReadLine();
            int userChoiceInt = -1;
            while (!int.TryParse(userChoice, out userChoiceInt) ||
                    (userChoiceInt != 1 && userChoiceInt != 2))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid choice. ");
                Console.WriteLine("Choose '1' to start a new game, or '2' to continue from the last save.");
                Console.Write("Enter your choice here: ");
                userChoice = Console.ReadLine();
            }

            // Start the game with instantiated Critters
            switch (userChoiceInt)
            {
                case 1:
                    Console.WriteLine("Starting a new game...");
                    manager.SetupCritters();
                    break;
                case 2:
                    Console.WriteLine("Loading from the file...");
                    manager.LoadCrittersFromFile();
                    break;
            }


            // ------------------------------------------------------------------
            // Gameplay
            // ------------------------------------------------------------------
            do
            {
                // ************************************
                // Every "round" print the critters and then menu options
                // ************************************
                Console.WriteLine();
                manager.PrintCritters();
                Console.WriteLine();

                // The menu is different depending on whether or not
                //    there is an active critter.
                if (manager.ActiveCritter == null)
                {
                    Console.WriteLine("You don't have a critter selected.\n");
                    Console.WriteLine("Choose one of the following options: ");
                    Console.WriteLine("'1' to choose a different critter");
                }
                else
                {
                    Console.WriteLine("Your current critter is: " + manager.ActiveCritter + "\n");
                    Console.WriteLine("Choose one of the following options: ");
                    Console.WriteLine("'1' to choose a different critter");
                    Console.WriteLine("'2' to feed your critter");
                    Console.WriteLine("'3' to play with your critter");
                    Console.WriteLine("'4' to talk to your critter");
                }

                Console.WriteLine("'5' to quit the program");
                Console.Write("Enter your choice here: ");
                Console.WriteLine();

                // Gather user's choice and validate. Force re-entry of a valid option. 
                userChoice = Console.ReadLine();
                userChoiceInt = -1;

                // Option is invalid while:
                // 1. Bad parse of data
                // 2. Out of range
                // 3. No active critter AND they tried to choose 1 - 5.
                while (!int.TryParse(userChoice, out userChoiceInt) ||                                  // Bad parse
                        (userChoiceInt < 1 || userChoiceInt > 5) ||                                     // Out of range
                        (manager.ActiveCritter == null && userChoiceInt > 1 && userChoiceInt < 5))      // No active critter    
                {
                    Console.WriteLine("Invalid choice. ");
                    Console.Write("Enter your choice here: ");
                    userChoice = Console.ReadLine();
                }

                // ************************************
                // Perform the user's chosen action
                // ************************************
                switch (userChoiceInt)
                {
                    // CASE 1 --> Active Critter
                    case 1:
                        // Display current critter names
                        List<string> critterNames = manager.GetCritterNames();
                        Console.Write("Choose from one of the following critters: ");
                        for (int i = 0; i < critterNames.Count; i++)
                        {
                            if (critterNames.Count == 1)
                            {
                                Console.WriteLine(critterNames[i]);
                            }
                            else if (i != critterNames.Count - 1)
                            {
                                Console.Write(critterNames[i] + ", ");
                            }
                            else
                            {
                                Console.WriteLine("or " + critterNames[i]);
                            }
                        }

                        // Allow user to choose one of the critters
                        // Force re-entry if critter name is incorrect
                        bool critterExists = false;
                        while (!critterExists)
                        {
                            Console.Write("Which critter would you like? ");
                            string userCritterChoice = Console.ReadLine();
                            critterExists = manager.ChooseCritter(userCritterChoice);

                            if (!critterExists)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Sorry, that critter does not exist. Try again.");
                            }
                        }

                        break;

                    // CASE 2 --> Feed Critter
                    case 2:
                        Console.WriteLine("Feeding your critter...");
                        manager.FeedCritter();
                        manager.TimePassing();
                        break;

                    // CASE 3 --> Play with Critter
                    case 3:
                        Console.WriteLine("Playing with your critter...");
                        manager.PlayWithCritter();
                        manager.TimePassing();
                        break;

                    // CASE 4 --> Talk to Critter
                    case 4:
                        Console.WriteLine("Talking to your critter...");
                        manager.TalkToCritter();
                        break;

                    // CASE 5 --> Quit and save data
                    case 5:
                        Console.WriteLine("Ending program. Saving data.");
                        manager.SaveCrittersToFile();
                        break;
                }
            }
            while (userChoiceInt != 5);

            Console.ReadLine();
        }
    }
}
