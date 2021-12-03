using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Samar Karnani
 * PE12-Custom Stacks and Queues
 * Prof E. Cascioli
 * 28/02/20
 */

namespace PE12_CustomStacksandQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            GameStack gameStack = new GameStack();
            Console.WriteLine("Strings added to stack");
            Console.WriteLine("abcd");
            Console.WriteLine("efgh");
            Console.WriteLine("ijkl");
            Console.WriteLine("mnop");
            Console.WriteLine("qrst\n\n");

            gameStack.Push("abcd");
            gameStack.Push("efgh");
            gameStack.Push("ijkl");
            gameStack.Push("mnop");
            gameStack.Push("qrst");


            Console.WriteLine("Removing strings from stack");
            for(int i = 0; i<gameStack.Count; i++)
            {
                string popped = gameStack.Pop();
                Console.WriteLine("Popped string: " + popped + "\n");
                i--;
            }

            GameQueue gameQueue = new GameQueue();
            Console.WriteLine("Players added to queue");
            Console.WriteLine("Player1");
            Console.WriteLine("Player2");
            Console.WriteLine("Player3");
            Console.WriteLine("Player4");
            Console.WriteLine("Player5\n\n");

            gameQueue.Enqueue("Player1");
            gameQueue.Enqueue("Player2");
            gameQueue.Enqueue("Player3");
            gameQueue.Enqueue("Player4");
            gameQueue.Enqueue("Player5");

            Console.WriteLine("Adding players to game");
            for (int i = 0; i < gameQueue.Count; i++)
            {
                string popped = gameQueue.Dequeue();
                Console.WriteLine("Player Added to game: " + popped + "\n");
                i--;
            }
        }
    }
}
