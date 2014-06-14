using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Class_1
{
    public class Worker : Employee
    {
        public override void GiveRaise()
        {
            salary += salary * 0.03;
        }
    }
}
