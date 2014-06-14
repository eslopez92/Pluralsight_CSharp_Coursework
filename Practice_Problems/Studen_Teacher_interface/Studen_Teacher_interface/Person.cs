using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studen_Teacher_interface
{
    class Person
    {
        public int age {get;set;}

        public void SetAge(int n)
        {
            this.age = n;
        }

        public void Greet()
        {
            Console.WriteLine("Hello there.");
        }
    }
}
