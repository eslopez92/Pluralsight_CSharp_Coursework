using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];//array of integers
            int i;
            Console.WriteLine("Please enter 5 numbers for the array.\n");

            for (i = 0; i < 5; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nThe array in reverse order is:\n");

            for(i=4;i>=0;i--)
            {
                Console.WriteLine("arr[{0}] = {1}",i,arr[i]);
            }
        }
    }
}
