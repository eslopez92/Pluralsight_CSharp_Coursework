using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEFINITIONS
            //Stack - first in last out (FILO)
            //push - add an item to the stack, goes on top of the stack
            //Pop - removes an item from the stack, removes it from the top of the stack

            var myStack = new Stack<int>();
            myStack.Push(100);
            int val = myStack.Pop();
            Console.WriteLine("val: {0}", val);

            for (int i = 0; i < 50; i++)
                myStack.Push(i);

            foreach (int i in myStack)
                Console.Write(i + ", ");

            var whichvalue = myStack.Pop();
            Console.WriteLine("\nPopped value: {0}", whichvalue);

            foreach (int i in myStack)
                Console.Write(i + ", ");
        }
    }
}
