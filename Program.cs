using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQ = new Queue();
            myQ.Enqueue("Allen");
            myQ.Enqueue("Barry");
            myQ.Enqueue("Chris");
            myQ.Enqueue("Dave");
            Console.WriteLine(myQ.Dequeue().name);
            Console.WriteLine(myQ.Dequeue().name);
            Console.WriteLine(myQ.Dequeue().name);
            Console.WriteLine(myQ.Dequeue().name);
            Console.WriteLine(myQ.Dequeue().name);
            myQ.Enqueue("Tony");
            Console.WriteLine(myQ.Dequeue().name);
            Console.WriteLine(myQ.Dequeue().name);
        }
    }
}
