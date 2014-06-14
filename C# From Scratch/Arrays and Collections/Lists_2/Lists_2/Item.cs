using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lists_2
{
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual void Purchase()
        {
            Console.WriteLine("Purchasing {0}", Name);
        }

        public static List<Item> GetItems(int numToGet)
        {
            var r = new Random();
            var newList = new List<Item>();//creating a new list of "Item"'s

            Item newItem;//creates an instance of a new item

            for (int i = 0; i < numToGet; i++)
            {
                newItem = new Item() { ID = r.Next(), Name = "MyItem " + i.ToString() };
                newList.Add(newItem);//the new item is being added to the list
            }

            return newList;

        }
    }
}
