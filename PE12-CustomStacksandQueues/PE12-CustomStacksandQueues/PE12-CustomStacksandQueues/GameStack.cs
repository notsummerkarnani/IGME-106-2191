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
    interface IStack
    {
        bool IsEmpty { get; }
        int Count { get; }
        void Push(string s);
        string Pop();
        string Peek();
    }

    
    class GameStack : IStack
    {
        List<string> stack;
        private int count;

        public GameStack()
        {
            stack = new List<string>();
            count = stack.Count;
        }
        
        /// <summary>
        /// Removes the element at the top of the stack
        /// </summary>
        /// <returns></returns>
        public string Pop()
        {
            if (this.IsEmpty == false)
            {
                string element = stack[count-1];
                stack.RemoveAt(count-1);
                count--;
                return element;
            }
            return null;
        }

        /// <summary>
        /// adds an element to the top of the stack
        /// </summary>
        /// <param name="s"></param>
        public void Push(string s)
        {
            stack.Add(s);
            count++;
        }

        /// <summary>
        /// returns the element at the top of the stack
        /// </summary>
        /// <returns></returns>
        public string Peek()
        {
            if (this.IsEmpty == false)
            {
                return stack[0];
            }
            return null;
        }

        public bool IsEmpty
        {
            get
            {
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
    }
}
