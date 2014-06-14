using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Class_1
{
    //only can implement from one abstract class. Cannot create an instance of that abstract class Polymorphism
    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Worker();
            emp1.Name = "David";
            emp1.salary = 50000;

            var emp2 = new Manager();
            emp2.Name = "Brian";
            emp2.salary = 90000;

            var emp3 = new Manager();
            emp3.Name = "Andy";
            emp3.salary = 120000;

            var employees = new List<Employee>();//list of employees called "employees"
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            foreach (Employee emp in employees)
            {
                Console.WriteLine("{0} made {1} a year", emp.Name, emp.salary);
                emp.GiveRaise();
                Console.WriteLine("{0} now makes {1} a year with their new raise \n", emp.Name, emp.salary);
            }

        }
    }
}
