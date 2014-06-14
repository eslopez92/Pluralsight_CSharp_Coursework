using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            string ageAsString = Console.ReadLine();
            int age = int.Parse(ageAsString);//converts string into an int

            do
            {
                Console.Write("Happy Birthday ");
                age--;
            } while (age > 0) ;

            Console.WriteLine("\nTaDa!!");
        }
    }
}
