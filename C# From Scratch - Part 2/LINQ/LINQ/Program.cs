using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var primes = new List<int> { 3, 5, 7, 11, 13, 17, 19, 23 };

        //    var query = from val in primes//use val as a scanner through primes
        //                where val < 13//if (scaned_number < 13) { val = scaned_number;}//then val is added to the list
        //                select val;
        //    foreach (var val in query)
        //        Console.WriteLine(val);

        //    var methodQuery = primes.Where(x => x < 13);
        //    foreach (var val in methodQuery)
        //        Console.WriteLine(val);

        //    Console.WriteLine("\n\n===================================");

        //    //========================================================================
        //    var query_2 = from method in typeof(double).GetMethods()//extract all of the names of type double
        //                  orderby method.Name//order alphabetically
        //                  group method by method.Name into groups//the 'method' in getmethods are grouped into a group called 'groups' 
        //                  select new { MethodName = groups.Key, NumberOfOverloads = groups.Count() };

        //    foreach (var item in query_2)
        //        Console.WriteLine(item);
        //}
//=========================================================================================================================================================
        //static void Main(string[] args)
        //{
        //    var listOne = Enumerable.Empty<int>();
        //    var listTwo = Enumerable.Range(1, 20);

        //    bool listOneEmpty = listOne.Any();//checks to see if the list is empty or not
        //    bool listTwoEmpty = listTwo.Any();

        //    Console.WriteLine("List one have members? " + listOneEmpty +
        //                      "\nList two has members? " + listTwoEmpty);

        //    Console.WriteLine("\nlistTwo has 12? " + listTwo.Contains(12) +
        //                      "\nlistTwo has 30? " + listTwo.Contains(30));

        //}
        //=========================================================================================================================================================
        //static void Main(string[] args)
        //{
        //    var bigList = Enumerable.Range(1, 20);
        //    //little list takes 5 values from big list and multiplies each number by 10
        //    var littleList = bigList.Take(5).Select(x => x * 10);

        //    foreach (var i in littleList)
        //        Console.WriteLine(i);

        //}
        //=========================================================================================================================================================
        static void Main(string[] args)
        {
            string[] postalCodes = {"AL","AK","AZ","AR","CA","CO","CT","DE","FL"};
            string[] states = { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorodo", "Connecticut", "Deleware", "Florida" };

            var statesWithCodes = postalCodes.Zip(states, (code, state) => code + ": " + state);
            //zip means take each element in the array and add the other array string

            foreach (var stateWithCode in statesWithCodes)
            {
                Console.WriteLine(stateWithCode);
            }

        }
    }
}
