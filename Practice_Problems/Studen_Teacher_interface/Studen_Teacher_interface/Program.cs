using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studen_Teacher_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var student_1 = new Student();
            var teacher_1 = new Teacher();

            Console.Write("Please enter the student's age: ");
            student_1.SetAge(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Please enter the teacher's age: ");
            teacher_1.SetAge(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("\nThe Student says:");
            student_1.Greet();
            student_1.ShowAge();

            Console.WriteLine("\nThe Teacher says:");
            teacher_1.Greet();
            teacher_1.Explain();

        }
    }
}
