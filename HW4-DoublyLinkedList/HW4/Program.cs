using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Samar Karnani
 * GDAPS 2 Prof E. Cascioli
 * 5/4/20
 * HW4
 */

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<string> customLinkedList = new CustomLinkedList<string>();
            string input = null;

            while(input != "q" && input != "quit")
            {
                Console.Write("\nType Something: ");
                input = Console.ReadLine();

                switch(input)
                {
                    //prints elements to console from head to tail
                    case "printf":
                        customLinkedList.Print();
                        break;

                    //prints elements to console from tail to head
                    case "printr":
                        customLinkedList.PrintReverse();
                        break;

                        //prints the number of elements in the list
                    case "count":
                        Console.WriteLine($"\nnumber of items in list: {customLinkedList.Count}");
                        break;

                        //clears all elements from the list
                    case "clear":
                        Console.WriteLine("\nClearing list...");
                        customLinkedList.Clear();
                        Console.WriteLine("List clear.");
                        break;

                        //asks the user for the index and then removes the element at that index
                    case "remove":
                        string indexS = null;
                        int index = -1;
                        while (int.TryParse(indexS, out index) == false)
                        {
                            Console.WriteLine("\nAt what index would you like to remove an element?");
                            indexS = Console.ReadLine();

                            if(int.TryParse(indexS, out index) == false)
                            {
                                Console.WriteLine("Please enter a number");
                            }
                        }

                        customLinkedList.RemoveAt(index);
                        break;

                        //asks the user for an index and then inserts an element at that index
                    case "insert":
                        indexS = null;
                        index = -1;

                        while (int.TryParse(indexS, out index) == false)
                        {
                            Console.WriteLine("\nAt what index would you like to insert an element?");
                            indexS = Console.ReadLine();

                            if (int.TryParse(indexS, out index) == false)
                            {
                                Console.WriteLine("Please enter a number");
                            }
                        }

                        Console.WriteLine("Enter the data you would like to insert");
                        customLinkedList.Insert(Console.ReadLine(), index);

                        break;

                        //changes the index of an element in the list
                    case "scramble":
                        if (customLinkedList.Count >= 2)
                        {
                            Random rng = new Random();
                            int index1 = rng.Next(0, customLinkedList.Count);
                            int index2 = rng.Next(0, customLinkedList.Count);
                            Console.WriteLine($"\nRemoving element at index {index1}");
                            customLinkedList.Insert(customLinkedList.RemoveAt(index1), index2);
                            Console.WriteLine($"Element moved from index {index1} to {index2}");
                        }
                        else
                        {
                            Console.WriteLine("\nList does not contain enough elements to scramble");
                        }
                        break;

                        //quit
                    case "q":
                        Console.WriteLine("See you soon!");
                        break;

                        //quit
                    case "quit":
                        Console.WriteLine("See you soon!");
                        break;

                        //adds input to the list
                    default:
                        if (input != "")
                        {
                            customLinkedList.Add(input);
                        }
                        break;
                }
            }
        }
    }
}
