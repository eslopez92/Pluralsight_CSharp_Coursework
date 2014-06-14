using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var storableObjects = new List<Storable>();//a list of interfaces called storableObjects
            
            Note myNote = new Note();
            storableObjects.Add(myNote);
            
            DBEntry myDBEntry = new DBEntry();
            storableObjects.Add(myDBEntry);

            myDBEntry = new DBEntry();
            storableObjects.Add(myDBEntry);

            myNote = new Note();
            storableObjects.Add(myNote);

            myNote = new Note();
            storableObjects.Add(myNote);

            foreach (Storable storable in storableObjects)
            {
                storable.Write(null);//no object to be passed
                Console.WriteLine(storable.Read() + "\n");//the read function returns type string
            }
                   
        }
    }
}
