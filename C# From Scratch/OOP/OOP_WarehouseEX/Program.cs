using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Warehouse newWarehouse = new Warehouse("China Warehouse INC.", 100);
            //Item myItem = newWarehouse.FindAndReturnItem(1, 2014);//gets item #1

            //Console.WriteLine("My new item is: " + myItem.Name);
            //Console.WriteLine("And comes from: {0} - {1}.", newWarehouse.Warehousename, newWarehouse.ID);

            //========================================================================================================
            var myComputer = new Computer();//has item and hardware properties properties
            myComputer.SerialNumber = "123456789";

            Item mySecondComputer = new Computer();//only has item properties
            mySecondComputer.ID = 103;

            Computer mySecondComputer2 = mySecondComputer as Computer;//now inherites all of mySecondComputer 
                                                                      // properties but now has computer parameters
            mySecondComputer2.CPUType= "fast";
            mySecondComputer2.Name = "Jupiter";
            Console.WriteLine("Computer : Hardware\n");
            mySecondComputer2.Purchase();//this is an item function but calls overwritten funciton in computer

            //========================================================================================================
            Software mySoftware = new Software();
            mySoftware.ID = 123;
            mySoftware.ISBN = "123456789";
            mySoftware.Name = "Microsoft Office";

            Console.WriteLine("\n\nSoftware\n");
            mySoftware.Purchase();

            //========================================================================================================
            Item newItem = Item.GetItem();//calling a static item
            Console.WriteLine("\n\n\n\nnewitem ID is: {0} newitem name is {1}", newItem.ID, newItem.Name);
        }
    }
}