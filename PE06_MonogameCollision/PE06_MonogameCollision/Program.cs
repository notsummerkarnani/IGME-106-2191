using System;

/* Samar Karnani
 * Prof E. Cascioli
 * 30/01/19
 * PE06 Monogame Collision
 */

namespace PE06_MonogameCollision
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
