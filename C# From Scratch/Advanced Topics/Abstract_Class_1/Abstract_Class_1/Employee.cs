using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Class_1
{
    //Abstract - you cannot simply create an instance of employee, rather you must create another class that 
    //           derives from employee, ie manager, engineer, hr, etc. 
    public abstract class Employee
    {
        public string Name { get; set; }
        public double salary { get; set; }
        private DateTime HireDate;

        public virtual void Hire()//CAN be overwritten in other classes
        {
            this.HireDate = DateTime.Now;
        }

        public abstract void GiveRaise();//any functions that have abstract MUST be overwritten
    }
}
