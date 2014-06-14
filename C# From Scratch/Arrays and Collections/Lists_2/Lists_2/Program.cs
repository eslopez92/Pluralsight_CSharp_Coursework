using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lists_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<Item>();//creating a new list of "Item"'s
            myList = Item.GetItems(10);//ten items are created

            foreach (Item item in myList)
                Console.WriteLine("Name: {0}, ID: {1}",item.Name,item.ID);
        }
    }
}
