using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Item[5];//array of item objects
            Random r = new Random();


            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item(r.Next());//calls constuctor and the paramenter passed is a random number
            }

            Console.WriteLine("Items: ");
            
            foreach (Item item in items)
            {
                Console.WriteLine("item ID = " + item.ID);
            }

            Item myseconditem = items[1];
            Console.WriteLine("My second item in the list ID is: " + myseconditem.ID);

            Item myfifthitem = items[5];
            Console.WriteLine("My fifth item in the list ID is: " + myfifthitem.ID);
        }
    }
}
