using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    interface Printable
    {
        void Print();
        int Status { get; }//read only
    }
}
