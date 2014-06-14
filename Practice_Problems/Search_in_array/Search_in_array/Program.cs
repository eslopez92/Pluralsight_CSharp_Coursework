using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Search_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeofarray = 0;
            string string_value;
            bool listed;//checks to see if the user input is listed in the original array
            int listed_count = 0;//counts to see how many times the user entered
            int number_itt = 0;//counts the number of time the user enters a number

            Console.Write("Please enter the size of the array: ");
            sizeofarray = Convert.ToInt32(Console.ReadLine());
            var arr = new int[sizeofarray];

            Console.WriteLine("\nEnter all {0} numbers into the array", sizeofarray);

            for (int i = 0; i < sizeofarray; i++) 
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please enter numbers. Type ''end'' to stop\n");

            while (true)
            {
                listed = false;
                Console.Write("Number[{0}]: ", number_itt);
                string_value = Console.ReadLine();
                if (string_value == "end")//user wants to 
                    break;

                for (int i = 0; i < sizeofarray; i++)
                {
                    if (arr[i] == Convert.ToInt32(string_value))
                    {
                        listed = true;
                        listed_count++;
                    }
                }

                if (listed)
                    Console.WriteLine("Yes, {0} is in the original array\n", string_value);
                else
                    Console.WriteLine("No, {0} is not in the original array\n", string_value);

                number_itt++;
            }

            Console.WriteLine("{0}% of numbers you entered were actual numbers in the original array", Convert.ToDouble(listed_count) / Convert.ToDouble(number_itt) * 100);

        }
    }
}
