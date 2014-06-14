using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeofarray;
            Console.Write("Please enter the size of the array: ");
            sizeofarray = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[sizeofarray];

            for(int i = 0;i<sizeofarray;i++)
            {
                Console.Write("Number [{0}]: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe even numbers you entered in the array are");
            foreach (int j in arr)
            {
                if (j % 2 == 0)
                    Console.WriteLine(j);
            }

            Array.Sort(arr);

            Console.WriteLine("The sorted array is as followed");
            for (int j = 0; j < sizeofarray; j++)
            {
                Console.WriteLine("arr[{0}] = {1}", j, arr[j]);
            }

        }
    }
}
