using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            doc.Print();
            doc.CountCharacters();

            Printable printableItem = doc;
            printableItem.Print();//this variable can only execute methods in the printable interface but not the doc

            Document theDoc = printableItem as Document;//the doc takes all properties from printable item and creates a document object out of it
            if (theDoc != null)
                theDoc.CountCharacters();
            string contents = theDoc.Read();
            Console.WriteLine("contents: " + contents);
        }
    }
}
