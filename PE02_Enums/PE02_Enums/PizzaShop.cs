using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02_Enums
{
    class PizzaShop
    {
        public PizzaShop() { }
        
        /*Method to "Bake" pizzas
         * takes in the enum type
         * Asks the user for the details of the pizza
         * returns the pizza object created base on thee enum type
         */
        public static Pizza PizzaBake(PizzaType type) 
        {
            string sauce;
            Pizza pizza;

            if(type == PizzaType.Cheese)
            {
                do
                {
                    Console.WriteLine("What kind of sauce would you like on your Pizza? (red/white/alfredo)");
                    sauce = Console.ReadLine().ToLower().Trim();
                    if (!(sauce == "red" || sauce == "white" || sauce == "alfredo"))
                    {
                        Console.WriteLine("Invalid Input! You can only get one of the options.");
                    }
                } while (!(sauce == "red" || sauce == "white" || sauce == "alfredo"));
                pizza = new Cheese();
                Cheese cheese = (Cheese)pizza;
                cheese.Sauce = sauce;
                return cheese;
            }
            else
            {
                string crust;
                int numToppings;
                string[] toppings;
                bool success;
                do
                {
                    Console.WriteLine("What kind of sauce would you like on your Pizza? (red/white/alfredo)");
                    sauce = Console.ReadLine().ToLower().Trim();
                    if (!(sauce == "red" || sauce == "white" || sauce == "alfredo"))
                    {
                        Console.WriteLine("Invalid Input! You can only get one of the options.");
                    }
                } while (!(sauce == "red" || sauce == "white" || sauce == "alfredo"));
                do
                {
                    Console.WriteLine("What kind of crust would you like for your pizza? (thick/thin)");
                    crust = Console.ReadLine().ToLower().Trim();
                    if (!(crust == "thick" || crust == "thin"))
                    {
                        Console.WriteLine("Invalid Input! You can only get one of the options.");
                    }
                } while (!(crust == "thick" || crust == "thin"));
                do
                {
                    Console.WriteLine("How many toppings would you like on your pizza?");
                    success = int.TryParse(Console.ReadLine(), out numToppings);
                    if (success == false)
                    {
                        Console.WriteLine("Invalid Input! Please enter a number.");
                    }
                } while (success == false);
                toppings = new string[numToppings];
                for (int i = 0; i < numToppings; i++)
                {
                    Console.WriteLine($"Please enter topping number {i+1}:");
                    toppings[i] = Console.ReadLine().ToLower().Trim();
                }
                pizza = new Deluxe(crust, sauce, numToppings, toppings);
                Deluxe deluxe = (Deluxe)pizza;
                return deluxe;
            }
            
        }
    }
}
