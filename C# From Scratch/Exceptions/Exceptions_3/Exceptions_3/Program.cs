using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions_3
{
    public class Tester
    {
        public double DoDivide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();//throw this message
            if (x == 0)
                throw new MyCustomException("Dividend can't be zero!");//throw my custom exception

            return x / y;
        }
    }

    public class MyCustomException : Exception
    {
        public MyCustomException(string message) :
            base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tester t = new Tester();

                double answer = t.DoDivide(12, 1);
                Console.WriteLine("Answer = " + answer);

                answer = t.DoDivide(0, 12);
                Console.WriteLine("Answer = " + answer);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
