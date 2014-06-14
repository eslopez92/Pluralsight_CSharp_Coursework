using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Warehouse
    {
        //parameters
        public int ID { get; set; }
        public string Warehousename { get; set; }

        //functions
        public Warehouse(string Name, int ID)//constructor
        {
            Warehousename = Name;
            this.ID = ID;
        }

        //public Item FindAndReturnItem(int itemID, int year)//function that returns a type "Item" which is just an object
        //{

        //  //  Item returnItem = new Item(itemID,year);//new instance of the item class
        // //   return returnItem;//returns an object of type "Item"
        //}

    }
}
