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
    interface IQueue
    {
        bool IsEmpty { get; }
        int Count { get; }
        void Enqueue(string s);
        string Dequeue();
        string Peek();
    }
    class GameQueue : IQueue
    {
        List<string> queue;
        private int count;
        
        public GameQueue()
        {
            queue = new List<string>();
            count = queue.Count;
        }
        
        /// <summary>
        /// removes the first element in the queue and returns it
        /// </summary>
        /// <returns></returns>
        public string Dequeue()
        {
            if(this.IsEmpty == false)
            {
                string element = queue[0];
                queue.RemoveAt(0);
                count--;
                return element;
            }
            return null;
        }

        /// <summary>
        /// adds and element to the back of the queue
        /// </summary>
        /// <param name="s"></param>
        public void Enqueue(string s)
        {
            queue.Add(s);
            count++;
        }

        /// <summary>
        /// returns the element at the start of the queue
        /// </summary>
        /// <returns></returns>
        public string Peek()
        {
            return queue[0];
        }


        public bool IsEmpty
        {
            get
            {
                if(queue.Count == 0)
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
