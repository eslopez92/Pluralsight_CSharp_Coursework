using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEFINITIONS
            //queue - first in first out (FIFO)
            //Enqueue - add an item to the queue, adds it to the back of the queue
            //Dequeue - removes an item from the queue, removes it from front of queue

            var myQueue = new Queue<int>();
            myQueue.Enqueue(100);
            int val = myQueue.Dequeue();
            Console.WriteLine("val: {0}", val);

            for (int i = 0; i < 50; i++)
                myQueue.Enqueue(i);

            foreach (int i in myQueue)
                Console.Write(i + ", ");

            var whichvalue = myQueue.Dequeue();
                Console.WriteLine("\nDequeued value: {0}",whichvalue);

                foreach (int i in myQueue)
                    Console.Write(i + ", ");
        }
    }
}
