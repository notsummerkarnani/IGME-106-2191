using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/* Samar Karnani
 * Prof E cascioli
 * 04/04/19
 * PE07 Events and Delegates
 */

namespace PE07EventsandDelegates
{
    delegate void MessageDelegate(string label, string message); //new delegate of type void and takes in 2 strings
    class Program
    {
        static void Main(string[] args)
        {
            MessageLog messageLog = new MessageLog();
            Die die = new Die();

            die.RolledATwenty += messageLog.Save;

            for(int i =0; i<50; i++) //Rolls 20 die and prints result
            {
                int num = die.DieRoll();
                Console.WriteLine("Rolling..." + num);
                Thread.Sleep(101);
            }
            messageLog.Print();
        }
    }
}
