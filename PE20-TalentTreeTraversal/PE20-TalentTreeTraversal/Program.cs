using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Samar Karnani
 * Prof E. Cascioli / Prof Alberto
 * PE 20 - Talent tree traversal 
 * 9/4/20
 */

namespace PE20_TalentTreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            TalentTreeNode root = new TalentTreeNode("Italian food", true); //root node (level 0)
            TalentTreeNode left1 = new TalentTreeNode("Pasta", true);       //level 1 
            TalentTreeNode right1 = new TalentTreeNode("Pizza", false);     //level 1
            root.LeftChild = left1;
            root.RightChild = right1;

            TalentTreeNode left11 = new TalentTreeNode("Arrabbiata pasta", false);  //level 2
            TalentTreeNode left12 = new TalentTreeNode("Pesto pasta", true);        //level 2
            left1.LeftChild = left11;
            left1.RightChild = left12;

            TalentTreeNode right11 = new TalentTreeNode("Cheese pizza", false);     //level 2
            TalentTreeNode right12 = new TalentTreeNode("Pepperoni pizza", false);  //level 2
            right1.LeftChild = right11;
            right1.RightChild = right12;

            //lists all abilities
            Console.WriteLine("----Listing all abilities-----");
            root.ListAllAbilities();

            //lists all known abilities
            Console.WriteLine();
            Console.WriteLine("-----Listng all known abilities-----");
            root.ListKnownAbilities();

            //lists all abilities which could be learned
            Console.WriteLine();
            Console.WriteLine("-----Listing all possible abilities-----");
            root.ListPossibleAbilities();
        }
    }
}
