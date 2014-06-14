using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface_1
{
    public class DBEntry : Storable
    {
        public void Write(object obj)
        {
            Console.Write("writing obj to database...\n");
        }

        public string Read()
        {
            return "Reading entry from database";
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
    }
}
