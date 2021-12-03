using System;

/* Samar Karnani
 * Prof E. Cascioli / Prof A. Bobadilla
 * 29/03/2020
 * PE19 Recursion
 */

namespace PE19_Recursion
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
#endif
}
