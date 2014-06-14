using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Authors = new String[5];
            Authors[0] = "Faulkner"; 
            Authors[1] = "Proust";
            Authors[2] = "Stephenson";
            Authors[3] = "Gibson";
            Authors[4] = "Melville";

            Console.WriteLine("Authors...\n");
            foreach (string author in Authors)
            {
                Console.WriteLine(author);
            }

            Array.Sort(Authors);
            Console.WriteLine("\n\nSorted Authors...\n");
            foreach (string author in Authors)
            {
                Console.WriteLine(author);
            }

        }
    }
}
