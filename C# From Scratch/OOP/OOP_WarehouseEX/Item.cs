using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Item
    {
        //public declarations
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual void Purchase()//used to make derived classes have their own version
        {
            Console.WriteLine("Purchasing {0}", Name);
            Console.WriteLine("The ID is: " + ID);
        }

        public static Item GetItem()//returns an item and do not need an instance
        {
            var newItem = new Item() { ID = 101, Name = "MyItem" };
            return newItem;
        }

    }

        //these class should be seperate from item
        class Software : Item //software derives from an item
        {
            public string ISBN { get; set; }
            public override void Purchase()
            {
                base.Purchase();//all of the previous functionallity
                Console.WriteLine("The IBSN is: " + ISBN);
            }
        }

        class Hardware : Item //hardware derives from an item
        {
            public string SerialNumber {get;set;}
        }

        class Computer : Hardware //computer derives from a piece of hardware
        {
            public string CPUType { get; set; }
            public string Disks { get; set; }
            public override void Purchase()//changing the function from item
            {
                base.Purchase();
                Console.WriteLine("myCPUType is " + CPUType);
            }
        }

        class Peripheral : Hardware // peripherals derives from hardware
        {
            public string description { get; set; }
        }
    
}
