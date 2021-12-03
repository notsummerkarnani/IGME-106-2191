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
    class MessageLog
    {
        private List<string> labels;
        private List<string> messages;

        public MessageLog()
        {
            labels = new List<string>();
            messages = new List<string>();
        }

        //Saves the strings to their respective lists
        public void Save(string label, string message)
        {
            labels.Add(label);
            messages.Add(message);
        }

        //Prints information to screen
        public void Print()
        {
            for(int i =0; i<labels.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(labels.ElementAt(i));
                Console.ResetColor();
                Console.WriteLine(": " + messages.ElementAt(i));
            }
        }
    }
}
