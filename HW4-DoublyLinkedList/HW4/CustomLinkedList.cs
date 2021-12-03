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
    class CustomLinkedList<T>
    {
        private int count;
        private CustomLinkedNode<T> head;
        private CustomLinkedNode<T> tail;

        public CustomLinkedList()
        {
            count = 0;
        }

        /// <summary>
        /// Finds the last index of the linked list and then adds a new node after it
        /// </summary>
        /// <param name="data"> data to be added in the new node</param>
        public void Add(T data)
        {
            CustomLinkedNode<T> newNode = new CustomLinkedNode<T>(data);
            if (count == 0)
            {
                head = newNode;
                newNode.PrevNode = null;
                tail = newNode;
            }
            else
            {
                tail.NextNode = newNode;
                newNode.PrevNode = tail;
                tail = newNode;
            }
            count++;

            Console.WriteLine($"{newNode.Data} has been added to the list");
        }

        /// <summary>
        /// resets the values for head tail and count, clearing the list
        /// </summary>
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        /// <summary>
        /// Finds and returns data at a particular index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetData(int index)
        {
            if (index < count)
            {
                CustomLinkedNode<T> current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.NextNode;
                }
                return current.Data;
            }

            return default;
        }

        /// <summary>
        /// Inserts data at a particular index in the list
        /// cannot accept index less than zero
        /// for indices > count, it adds the element to the end of the list
        /// </summary>
        /// <param name="data"> data to be added to the list </param>
        /// <param name="index"> position in the list at which to add the data </param>
        public void Insert(T data, int index)
        {
            CustomLinkedNode<T> newNode = new CustomLinkedNode<T>(data);

            if(index <0)
            {
                Console.WriteLine("Index cannot be negative!");
                return;
            }
            else if(index == 0)
            {
                newNode.NextNode = head;    //places the newNode before the first index
                head.PrevNode = newNode;
                head = newNode;             //makes newNode the new first index
                count++;
            }
            else if(index >= count)
            {
                Add(data);
            }
            else
            {
                //finds the index at which the node needs to be added
                //places the node in that position and pushes any index after it by 1 position
                CustomLinkedNode<T> current = head;
                for(int i = 0; i < index-1; i++)
                {
                    current = current.NextNode;
                }

                newNode.NextNode = current.NextNode;
                current.NextNode.PrevNode = newNode;
                current.NextNode = newNode;
                newNode.PrevNode = current;
            }
        }

        /// <summary>
        /// prints all elements in the list to the console 
        /// </summary>
        public void Print()
        {
            CustomLinkedNode<T> current = head;
            if(count == 0)
            {
                Console.WriteLine("\nNothing to print. List is empty!\n");
                return;
            }
            Console.WriteLine("\n\nElements in list:\n");
            while (current.Data != null)
            {
                Console.WriteLine(current.Data);
                if(current.NextNode != null)
                {
                    current = current.NextNode;
                }
                else
                {
                    return;
                }
            }

        }

        /// <summary>
        /// prints all elements in the list to the screen in reverse
        /// </summary>
        public void PrintReverse()
        {
            CustomLinkedNode<T> current = tail;
            if (count == 0)
            {
                Console.WriteLine("\nNothing to print. List is empty!\n");
                return;
            }
            Console.WriteLine("\n\nElements in list (in reverse):\n");
            while (current.Data != null)
            {
                Console.WriteLine(current.Data);
                if (current.PrevNode != null)
                {
                    current = current.PrevNode;
                }
                else
                {
                    return;
                }
            }

        }

        /// <summary>
        /// Checks if the index is available and then removes the element at that index
        /// adjusts the count
        /// </summary>
        /// <param name="index"></param>
        /// <returns>element removed from index</returns>
        public T RemoveAt(int index)
        {
            T output = default;
            CustomLinkedNode<T> current = head;
            if (index>= count || index < 0)
            {
                //throw new IndexOutOfRangeException("Index must be present within the list!");
                Console.WriteLine("Index must be present within the list!");
                return default;
            }
            else if(index == 0) //removes the head element and sets the next element as the head
            {
                output = head.Data;
                if (head.NextNode != null)
                {
                    head = head.NextNode;
                    head.PrevNode = null;
                }
                else
                {
                    head = null;
                    tail = head;
                }
                count--;
                return output;
            }
            else if(index == count-1) //removes the tail element and sets the previous element to the tail
            {
                output = tail.Data;
                tail = tail.PrevNode;
                tail.NextNode = null;
                count--;
                return output;
            }
            else // removes the required node and adjusts the previous and next nodes so that the link is not broken
            {
                for(int i = 0; i<index; i++)
                {
                    current = current.NextNode;
                }
                output = current.Data;

                current.PrevNode.NextNode = current.NextNode;
                current.NextNode.PrevNode = current.PrevNode;
                current.NextNode = null;
                current.PrevNode = null;

                count--;
                return output;
            }
            
        }

        //properties
        public int Count { get { return count; } }
    }
}
