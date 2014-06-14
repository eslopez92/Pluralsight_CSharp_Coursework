using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Employee
    {
        //private int age;
        //public int Age//always need it for public variables
        //{
        //    get { return age; }
        //    set { age = value; }//value is a passed parameter in main, can be any number, ex Dave.Age = 35, value would be 35 in this case
        //}

        public int Age { get; set; }//exactly the same as above
        public string Name { get; set; }
        public double Salary {get;set;}
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }

        public void Bonus(double BonusPercent)
        {
            this.Salary *= 1 + BonusPercent;
        }

        public Employee(int age, string name, double salary, DateTime startingdate, string phoneNumber)//constructor
        {
            this.Age = age;
            this.Name = name;
            this.Salary = salary;
            this.StartingDate = startingdate;
            this.PhoneNumber = phoneNumber;            
        }

        public Employee()//overloading constructor which allows the coder to create
                         //an instance of a class with no constructor parameters safely
        { 
        }

    }
    class Constructors
    {
        static void Main(string[] args)
        {
            //using an overloading constructor
            //======================================================================================================
            Employee Emilio = new Employee()//sort of like a with statement
            {
                Age = 35,
                Name = "Emilio",
                Salary = 20000.00,
                StartingDate = new DateTime(2013, 7, 20),//creates an instance of a date
                PhoneNumber = "317-590-7262"
            };
            Console.WriteLine("{0}'s salary is {1}. He started on {2} and his phone number is {3}",
                Emilio.Name,Emilio.Salary,Emilio.StartingDate,Emilio.PhoneNumber);

            Emilio.Bonus(0.15);//bonuns of 15 percent

            Console.WriteLine("\nHis new salary with bonus percent is " + Emilio.Salary);
            //========================================================================================================

            //using a normal initalized constructor
            //========================================================================================================
            Employee Sofia = new Employee(1, "Sofia Lopez", 150000, new DateTime(2032, 6, 1), "317-590-7262");

            Console.WriteLine("\n\n{0} started on {1} with a starting salary of {2}. \nHer phone number is {3}",
                                Sofia.Name, Sofia.StartingDate, Sofia.Salary, Sofia.PhoneNumber);
            Sofia.Bonus(.25);
            Console.WriteLine("Her new salary with a bonus of 25% is " + Sofia.Salary);
        }
    }
}
