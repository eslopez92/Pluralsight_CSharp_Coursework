using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aggregation_and_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emilio = new Employee("Emilio Lopez", "810 Pawnee Dr.", "Carmel", "IN", "46032");
            Emilio.Insurance = new InsuranceInfo()//no instance within the constructor, need to make one here
            {
                PolicyName = "Life",
                PolicyId = "1234"
            };
            Console.WriteLine("\n\n" + Emilio.ToString());

            Manager Brian = new Manager("Brian Bajgrowicz", "101 W 103rd St", "Indianapolis", "IN", "46290",75000);
            Console.WriteLine("\n"+Brian.ToString());//writeline automatically calls tostring() so it is not necessary

            Console.WriteLine("\nEmilio: " + Emilio.DoWork("Programming"));
            Console.WriteLine("Brian: " + Brian.DoWork("Programming"));

            Employee Steven = new Manager("Steven Hoskins", "101 W 103rd St", "Indianapolis", "IN", "46290");
            Console.WriteLine("Steven: " + Steven.DoWork());

            Console.WriteLine("--------------------------------");

            List<Employee> employees = new List<Employee>();
            employees.Add(Emilio);
            employees.Add(Brian);
            employees.Add(Steven);

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Name + ": " + emp.DoWork());
            }
        }
    }
}
