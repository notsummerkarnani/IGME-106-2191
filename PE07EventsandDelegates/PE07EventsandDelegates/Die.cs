using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Samar Karnani
 * Prof E cascioli
 * 04/04/19
 * PE07 Events and Delegates
 */

namespace PE07EventsandDelegates
{
    class Die
    {
        private int numDie = 0;
        public event MessageDelegate RolledATwenty; //new event of type MessageDelegate

        //Rolls a 20 sided die
        //returns the roll
        //increments number of die rolled
        public int DieRoll() 
        {
            Random rng = new Random();
            numDie++;
            int roll = rng.Next(0, 21);

            if(roll == 20 && RolledATwenty != null)
            {
                RolledATwenty("Rolled a 20", $"This was roll number {numDie}");
            }
            return roll;
        }
    }
}
