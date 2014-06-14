using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_2
{
    public class Tester
    {
        public void Method1()
        {
            Console.WriteLine("method 1 begins");
            Method2();
            Console.WriteLine("method 1 ends");
        }

        public void Method2()
        {
            Console.WriteLine("method 2 begins");
            Method3();
            Console.WriteLine("method 2 ends");
        }

        public void Method3()
        {
            Console.WriteLine("method 3 begins");
            Console.WriteLine("File opened...");
            try //checks to see if the system crashes
            {
                var x = 0;
                var y = 20;
                y /= x;
            }

            catch (Exception e)
            {
                Console.WriteLine("Caught exception " + e.Message);
            }

            finally
            {
                Console.WriteLine("File closed...");
            }

            Console.WriteLine("method 3 ends");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Method1();
        }
    }
}
