using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Samar Karnani
 * GDAPS 2 PE 23 Graph Searching
 * Prof E. Cascioli / Prof Alberto
 * 19/04/20 
 */

namespace PE22_Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            Console.WriteLine("Listing all rooms:");
            graph.ListAllVertices();

            Console.WriteLine("\n Testing for a room that doesnt exist");

            graph.DepthFirst("exit");

            Console.WriteLine("\nTesting for Drawing Room");

            graph.DepthFirst("Drawing Room");

            Console.WriteLine("\nTesting for Library");

            graph.DepthFirst("Library");
        }
    }
}
