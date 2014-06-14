using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lists_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            List<int> myList = new List<int>();//list of int

            for (int i = 0; i < 10; i++)
            {
                myList.Add(r.Next());
            }

            myList.Sort();

            foreach (int number in myList)
                Console.WriteLine(number);

        }
    }
}
