using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops
{
    class IfStatements
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            string ageAsString = Console.ReadLine();
            int age = int.Parse(ageAsString);//converts string into an int

            if (age > 65)
            {
                Console.WriteLine("You are a senior citizen");
            }
            else if (age >= 21)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are not legally an adult");
            }

        }
    }
}
