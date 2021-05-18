using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Queue
    {
        public Node front = null;
        public Node back = null;

        public Queue()
        {

        }

        public void Enqueue(string name)
        {
            Node newNode = new Node(name, null);
            if(front == null)
            {
                front = newNode;
                
            }
            else
            {
                back.next = newNode;
                
            }
            back = newNode;
                    
        }
        public Node Dequeue()
        {
            if(front == null)
            {
                return new Node("Queue is empty", null);
            }
            Node returnNode = front;
            front = front.next;
            return returnNode;
        }
    }
}
