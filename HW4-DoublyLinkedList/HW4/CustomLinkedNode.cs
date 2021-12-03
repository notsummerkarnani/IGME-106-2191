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
    class CustomLinkedNode<T>
    {
        private T data;
        private CustomLinkedNode<T> nextNode;
        private CustomLinkedNode<T> prevNode;

        public CustomLinkedNode(T data)
        {
            this.data = data;
            nextNode = null;
            prevNode = null;
        }
        
        //properties
        public T Data 
        { 
            get { return data; }
        }

        public CustomLinkedNode<T> NextNode
        {
            get { return nextNode; }
            set { nextNode = value; }
        }

        public CustomLinkedNode<T> PrevNode
        {
            get { return prevNode; }
            set { prevNode = value; }
        }
    }
}
