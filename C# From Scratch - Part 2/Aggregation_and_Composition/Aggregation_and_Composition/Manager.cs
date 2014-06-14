using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aggregation_and_Composition
{

    public class Manager : Employee
    {
        //sets a default salary if none is given
        public Manager(string name, string street, string city, string state, string postalCode) :
            this(name, street, city, state, postalCode, 65000)//base constructor values
        {
        }

        //uses the base constructor
        public Manager(string name, string street, string city, string state, string postalCode, double salary) :
            base(name, street, city, state, postalCode, salary)//base constructor values
        {
        }

        public string GivePraise()
        {
            return "Manager giving praise";
        }

        public override string DoWork()
        {
            return "Manager doing work!";
        }

        public override string DoWork(string workType)
        {
            return "supervising " + workType;
        }
    }
}
