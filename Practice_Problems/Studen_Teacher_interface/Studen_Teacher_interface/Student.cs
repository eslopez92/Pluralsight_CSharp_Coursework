using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studen_Teacher_interface
{
    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("\nI'm going to class.");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", this.age);
        }
    
    }
}
