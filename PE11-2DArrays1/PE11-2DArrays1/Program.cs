using System;

/* Samar Karnani
 * Erin Cascioli
 * 16/02/20
 * PE11-2DArrays
 */

namespace PE11_2DArrays1
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
