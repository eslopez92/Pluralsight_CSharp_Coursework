using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> capitals = new Dictionary<string, string>();//creates a new dictionary called capitals

            //capitals.Add("Alabama", "Montgomery");
            //capitals.Add("Alaska", "Juneau");
            //capitals.Add("Arizona", "Phoenix");
            //capitals.Add("Massachusetts", "Boston");
            //capitals.Add("Wyoming", "Cheyenne");

            //string capitalOfMass = capitals["Massachusetts"];
            //Console.WriteLine("The capital of Massachusetts is " + capitalOfMass);

            var thestates = State.GetStates();

            Console.WriteLine("The capital of Alaska is {0}, its population is {1} and its size is {2} ",
                            thestates["Alaska"].Capital, thestates["Alaska"].Population, thestates["Alaska"].Size);
        }
    }
}
