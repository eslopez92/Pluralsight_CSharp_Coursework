using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface_1
{
    //IMPORTANT: It IS NOT possible to implement from more than one BASE class
    //           however, it IS possible to implement from multiple interfaces  
    public class Note : Storable //implements storable
                                //NOTE click on blue underline of the interface name to get the psuedo code
    {
        public void Write(object obj)
        {
            Console.Write("writing obj to disk...\n");
        }

        public string Read()
        {
            return "Reading note from disk";
        }

        private ReturnStatus status;

        public ReturnStatus Status//basic getter and setter
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public void OtherMethod()
        {
            Console.WriteLine("Some other method of Note");
        }
    }
}
