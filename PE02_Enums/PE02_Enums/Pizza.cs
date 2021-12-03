using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02_Enums
{
    //abstract class pizza has two child classes (cheese and deluxe)
    abstract class Pizza
    {
        protected int price;

        public Pizza() //default constructor for pizza
        {
            price = 0;
        }

        public abstract void PrintInformation(); //abstract method for pizza
        public int Price { get { return price; } } //accessor for pizza price
    }

    class Cheese : Pizza
    {
        public Cheese() //default constructor for cheese pizza
        {
            price = 8;
        }
        public override void PrintInformation() //override method for cheese class
        {
            Console.WriteLine("\t-- Cheese Pizza Order --");
            Console.WriteLine($"Sauce: {Sauce}");
            Console.WriteLine($"Price: ${price.ToString("c")}");
        }

        //accessors
        public string Sauce { get; set; }
    }

    class Deluxe : Pizza
    {
        private List<string> toppings = new List<string>();

        //constrctor for deluxe pizza which takes in 4 parameterss
        public Deluxe(string crustType, string sauce, int numToppings, string[] toppings)
        {
            this.CrustType = crustType;
            this.Sauce = sauce;
            this.NumToppings = numToppings;
            price = 10 + (numToppings-1);
            foreach(string value in toppings)
            {
                this.toppings.Add(value);
            }
        }

        public override void PrintInformation() //Override method for Deluxe pizza class
        {
            Console.WriteLine("\t-- Deluxe Pizza Order --");
            Console.WriteLine($"{NumToppings} toppings, {Sauce} sauce, {CrustType} crust");
            string displayToppings = string.Join(",", toppings.ToArray());
            Console.WriteLine($"Toppings: {displayToppings}");
            Console.WriteLine($"Price: ${price.ToString("c")}");
        }

        //accessors
        public string CrustType { get; }

        public string Sauce { get; }

        public int NumToppings { get; }
    }
}