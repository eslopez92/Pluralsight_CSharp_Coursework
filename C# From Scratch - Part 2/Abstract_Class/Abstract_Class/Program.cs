using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Button btn = new Button(10, 5, "Click me!");
            TextBlock txt = new TextBlock(10, 6, "Hello world!");

            List<Control> controls = new List<Control>();
            controls.Add(btn);
            controls.Add(txt);

            foreach (Control ctrl in controls)
            {
                ctrl.DrawMe();
            }
        }
    }
}
