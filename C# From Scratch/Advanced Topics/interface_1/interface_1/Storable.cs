using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface_1
{
    public enum ReturnStatus //proptery
    {
        OK,
        FAIL
    };
    public interface Storable
    {
        void Write(object obj);
        string Read();
        ReturnStatus Status { get; set; }
    }
}
