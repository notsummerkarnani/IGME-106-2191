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
    // ** Create your CritterMood enum here: **
    public enum CritterMood
    {
        Happy,
        Frustrated,
        Angry
    }

    class Critter
    {
        private string name;
        private int hungerLevel;
        private int boredomLevel;

        // ** Enter an enum field here: **
        private CritterMood mood;

        public string Name
        {
            get { return name; }
        }

        public int Hunger
        {
            get { return hungerLevel; }
        }

        public int Boredom
        {
            get { return boredomLevel; }
        }

        /*
        // Constructor used when game has not been played in the past
        public Critter(string name)
        {
            this.name = name;
            hungerLevel = 0;
            boredomLevel = 0;
            UpdateMood();
        }

        // Game has been played, so pass in hunger and boredom data
        public Critter(string name, int hungerLevel, int boredomLevel)
        {
            this.name = name;
            this.hungerLevel = hungerLevel;
            this.boredomLevel = boredomLevel;
            UpdateMood();
        }
        */

        // Instead of making 2 constructors - one that assigns hunger level
        //   and boredom level values of 0, can use an optional parameter
        public Critter(string name, int hungerLevel = 0, int boredomLevel = 0)
        {
            this.name = name;
            this.hungerLevel = hungerLevel;
            this.boredomLevel = boredomLevel;

            // Call UpdateMood() to set the initial value of the enum variable
            UpdateMood();
        }


        // ----------------------------------------------------------------------
        // Completed Methods
        // ----------------------------------------------------------------------
        /// <summary>
        /// Feeds a critter so its hunger level will reduce.
        /// Lower levels indicate a happier critter.
        /// </summary>
        /// <param name="food">Amount of food to feed this critter, optional. Must be positive.</param>
        public void Eat(int food)
        {
            Console.WriteLine("{0} eats a bit. Brrrp!", name);

            // Decrease hunger level, but never beyond 0
            if (food >= 0)
            {
                hungerLevel -= food;
            }

            if (hungerLevel < 0)
            {
                hungerLevel = 0;
            }
        }


        /// <summary>
        /// Plays with critter so its boredom level will reduce.
        /// Lower levels indicate a happier critter.
        /// </summary>
        /// <param name="fun">Amount to reduce boredom by, optional. Must be positive.</param>
        public void Play(int fun)
        {
            Console.WriteLine("{0} loves playing. Wheee!", name);

            // Decrease boredom level, but never beyond 0
            if (fun >= 0)
            {
                boredomLevel -= fun;
            }

            if (boredomLevel < 0)
            {
                boredomLevel = 0;
            }
        }


        /// <summary>
        /// Simulates passing of time.
        /// As time progresses, critters become slightly more hungry
        /// and bored. 
        /// </summary>
        /// <param name="timePassed">Amount of minutes that pass, optional. Must be positive.</param>
        public void PassTime(int timePassed)
        {
            // Hunger and boredom increase 1 unit for every minute that passes
            if (timePassed >= 0)
            {
                hungerLevel += timePassed;
                boredomLevel += timePassed;
            }
        }


        /// <summary>
        /// Calculates the current happiness level.
        /// Happiness is determined by a critter's hunger + boredom levels.
        /// </summary>
        /// <returns>Happiness level</returns>
        private int CalcHappiness()
        {
            return hungerLevel + boredomLevel;
        }


        // ----------------------------------------------------------------------
        // Methods you need to finish
        // ----------------------------------------------------------------------

        /// <summary>
        /// Get a visual indication of how this critter feels.
        /// Prints a verbal statement of feelings with an emoticon.
        /// </summary>
        public void Talk()
        {
            // Update this critter's mood.
            UpdateMood();

            // ** Print this critter's feelings based on the set enum variable. **
            if(mood == CritterMood.Happy)
            {
                Console.WriteLine($"{name} feels happy with a full belly and an engaged mind! :)");
            }
            if (mood == CritterMood.Frustrated)
            {
                Console.WriteLine($"{name} feels frustrated; being hungry and bored is not fun. :|");
            }
            if (mood == CritterMood.Angry)
            {
                Console.WriteLine($"{name} feels angry! Critter smash! Please feed and play with the critter! >:");
            }


        }


        /// <summary>
        /// Updates mood variable based on current happiness level.
        /// Only called when:
        /// 1) a Critter is initialized or
        /// 2) A string representation of this critter's mood is needed,
        /// such as in Talk() or ToString()
        /// </summary>
        private void UpdateMood()
        {
            // ** Determine the overall hunger and boredom level total, 
            //   then set the enum variable appropriately. **
            int number = hungerLevel + boredomLevel;

            if(number <=9)
            {
                mood = CritterMood.Happy;
            }
            if (number <= 19 && number >= 10)
            {
                mood = CritterMood.Frustrated;
            }
            if (number >= 20)
            {
                mood = CritterMood.Angry;
            }


        }


        /// <summary>
        /// Returns a string representation of this Critter
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // ** Return a string representation of this character **
            // Should be the form of:
            // "CritterName    Hunger: 4    Boredom: 8    Current Mood: frustrated"
            UpdateMood();
            string toString = $"{name} \t Hunger: {hungerLevel} \t Boredom: {boredomLevel} \t Current mood: {mood}";

            return toString;
        }

    }
}
