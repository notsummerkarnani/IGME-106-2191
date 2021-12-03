using System;

/* Samar Karnani
 * GDAPS2 Prof E. Cascioli
 * 22/01/2019
 * PE03 MonoGame
 */

namespace PE03_MonoGameBasics
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
