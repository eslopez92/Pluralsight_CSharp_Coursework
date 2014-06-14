using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aggregation_and_Composition
{
    public class Employee
    {
        public string Name { get; set; }
        public AddressInfo Address {get; set;}//only is available when emp is avail. (composition
        public InsuranceInfo Insurance { get; set; }//created before or after employee (aggregation)
        public double Salary { get; set; }

        // w.o salary
        public Employee(string name, string street, string city, string state, string postalCode) :
            this(name,street,city,state,postalCode,50000)//assigns 50000 if salary is not indicated in constructor
        {
        }

        // with salary
        public Employee(string name, string street, string city, string state, string postalCode, double salary)
        {
            this.Name = name;
            this.Salary = salary;
            Address = new AddressInfo()
            {
                Street = street,
                City = city,
                State = state,
                PostalCode = postalCode
            };

            
        }

        public override string ToString()
        {
            string retVal = Name + " \n" +
                Address.Street + " \n" +
                Address.City + " " +
                Address.State + ", " +
                Address.PostalCode +
                "\nSalary: " + Salary;

            if (Insurance != null)
            {
                retVal += "\n" +
                    Insurance.PolicyName + ", " +
                    Insurance.PolicyId;
            }

            return retVal;
        }

        public virtual string DoWork()
        {
            return "Employee doing work!";
        }

        public virtual string DoWork(string workType)
        {
            return "Doing " + workType;
        }
    }
}
