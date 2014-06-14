using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Class
{
    public abstract class Control
    {
        protected int top;
        protected int left;

        public Control(int top, int left)//input constructor
        {
            this.top = top;
            this.left = left;
        }

        public Control()//default constructor
            :this(0,0)//calls other constructor with a default left = 0 and top = 0
        {}

        public abstract void DrawMe();
    }

    public class Button : Control
    {
        public string Contents { get; private set; }

        public Button(int top, int left, string contents)//constructor
            : base(top, left)
        {
            this.Contents = contents;
        }

        public override void DrawMe()//overriding from control class
        {
            Console.WriteLine("Drawing button with contents: " + Contents);
        }

    }

    public class TextBlock : Control
    {
        public string Text { get; private set; }

        public TextBlock(int top, int left, string text)//constructor
            : base(top, left)
        {
            this.Text = text;
        }

        public override void DrawMe()//overriding from control class
        {
            Console.WriteLine(Text);
        }
    }
}
