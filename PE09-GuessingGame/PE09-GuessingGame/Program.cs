using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Samar Karnani
 * Prof E Cascioli
 * 11/02/20
 * PE10 Guessing game multi windowed
 * For ease of grading i have added a console.writeline for every random generated so you know what the number is
 */

namespace PE09_GuessingGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Parameters());
        }
    }
}
