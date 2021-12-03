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
    class TalentTreeNode
    {
        private string abilityName;         
        private bool learned;
        private TalentTreeNode leftChild;
        private TalentTreeNode rightChild;

        public TalentTreeNode(string name, bool learned)
        {
            abilityName = name;
            this.learned = learned;
            leftChild = null;
            rightChild = null;
        }

        /// <summary>
        /// Checks if the left node exists and then proceeds to call the method on the left node as long as the condition is met
        /// Prints out the ability of the current node
        /// Checks if the right node exists and then calls the method on it if the condition is met
        /// </summary>
        public void ListAllAbilities()
        {
            //for left child
            if(leftChild != null)
            {
                leftChild.ListAllAbilities();   //recursion
            }

            //for parent (current)
            Console.WriteLine(abilityName);

            //for right child
            if (rightChild != null)
            {
                rightChild.ListAllAbilities();  //recursion
            }
        }

        /// <summary>
        /// Checks if the current ability has been learned and prints it accordingly
        /// if the condition is met it checks the left and right child nodes
        /// </summary>
        public void ListKnownAbilities()
        {
            //for parent (current)
            if (this.learned == true)
            {
                Console.WriteLine("Known ability: " + this.abilityName);

                //for left child
                if (leftChild != null && leftChild.learned == true)
                {
                    leftChild.ListKnownAbilities();     //recursion
                }

                //for right child
                if (rightChild != null && rightChild.learned == true)
                {
                    rightChild.ListKnownAbilities();    //recursion
                }
            }
        }

        /// <summary>
        /// Checks if the parent ability has been learned
        /// if it has been learned it checks if the child nodes exist and have been learned
        /// if the child nodes have not been learned they are printed, otherwise the method is called on them.
        /// </summary>
        public void ListPossibleAbilities()
        {
            //for parent (current)
            if (this.learned == true)
            {
                //for left child
                if (leftChild != null && leftChild.learned != true)
                {
                    Console.WriteLine("Possible ability: " + leftChild.abilityName);
                }
                else if(leftChild != null)
                {
                    leftChild.ListPossibleAbilities();  //recursion
                }

                //for right child
                if (rightChild != null && rightChild.learned != true)
                {
                    Console.WriteLine("Possible ability: " + rightChild.abilityName);
                }
                else if(rightChild != null)
                {
                    rightChild.ListPossibleAbilities(); //recursion
                }
            }
        }

        //properties

        public  TalentTreeNode LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }

        public TalentTreeNode RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }
    }
}
