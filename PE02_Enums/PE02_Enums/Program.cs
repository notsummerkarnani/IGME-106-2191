using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Samar Karnani
 * Date: 17/01/19
 * PE02 Enums
 */
namespace PE02_Enums
{
    enum PizzaType //New PizzaType Enum
    {
        Cheese,
        Deluxe
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizzas = new List<Pizza>();
            string input;
            int number;
            bool success;
            do
            {
                Console.WriteLine("\n\nPress 1 or \"order\" to order a pizza");
                Console.WriteLine("Press 2 or \"remove\" to remove a pizza");
                Console.WriteLine("Press 3 or \"display\" to display the order");
                Console.WriteLine("Press 4 or \"calculate\" to calculate the total");
                Console.WriteLine("Press 5 or \"exit\" to exit");
                input = Console.ReadLine().ToLower().Trim();
                
                if(input == "1" || input == "order")
                {
                    do
                    {
                        Console.WriteLine("What kind of piza would you like? (cheese/deluxe)");
                        input = Console.ReadLine().Trim().ToLower();
                        if (!(input == "cheese" || input == "deluxe"))
                        {
                            Console.WriteLine("Invalid Input! Please select one of the options.");
                        }
                    } while (!(input == "cheese" || input == "deluxe"));
                    if(input == "cheese")
                    {
                        pizzas.Add(PizzaShop.PizzaBake(PizzaType.Cheese));
                    }
                    else
                    {
                        pizzas.Add(PizzaShop.PizzaBake(PizzaType.Deluxe));
                    }
                }
                else if (input == "2" || input == "remove")
                {
                    if(pizzas.Count > 0)
                    {
                        Console.WriteLine("Your current order:");
                        for (int i = 0; i < pizzas.Count; i++)
                        {
                            Console.WriteLine("Item number: {0}", i + 1);
                            pizzas.ElementAt(i).PrintInformation();
                        }
                        do
                        {
                            Console.WriteLine("Which item would you like to remove?");
                            input = Console.ReadLine().Trim().ToLower();
                            success = int.TryParse(input, out number);
                            if (number <= pizzas.Count && number > 0)
                            {
                                pizzas.RemoveAt(number - 1);
                            }
                        } while (success == false);
                        input = "3";
                    }
                    else
                    {
                        Console.WriteLine("Your cart is empty");
                    }
                    
                }
                else if (input == "3" || input == "display")
                {
                    Console.WriteLine("Your current order:");
                    for (int i = 0; i < pizzas.Count; i++)
                    {
                        Console.WriteLine("Item number: {0}", i + 1);
                        pizzas.ElementAt(i).PrintInformation();
                    }
                }
                else if (input == "4" || input == "calculate")
                {
                    if(pizzas.Count == 0)
                    {
                        Console.WriteLine("No pizzas in order");
                    }
                    else
                    {
                        int total = 0;
                        for(int i = 0; i<pizzas.Count; i++)
                        {
                            total = total + pizzas.ElementAt(i).Price;
                        }
                        Console.WriteLine("Total: " + total.ToString("c"));
                    }
                }
            } while (!(input == "5" || input == "exit"));
            Environment.Exit(0);
        } 
    }
}
