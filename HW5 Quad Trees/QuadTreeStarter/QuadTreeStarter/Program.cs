using System;

/* Samar Karnani   
 * Gdaps 2 HW5 Quad Trees
 * Prof E. Cascioli / Prof Alberto / Jake!
 * 4/20
 */

namespace QuadTreeStarter
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
