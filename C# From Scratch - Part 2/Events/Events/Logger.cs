using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    public class Logger
    {
        //public void Suscribe(Clock theClock)
        //{
        //    theClock.TimeChanged += new Clock.TimeChangeHandler(NewTime);//make a new delegate
        //}

        //public void NewTime(object theClock, TimeEventArgs e)
        //{
        //    Console.WriteLine("Logging event at {0}:{1}:{2}",
        //        e.Hour.ToString(),
        //        e.Minute.ToString(),
        //        e.Second.ToString());
        //}

                                /*OR*/

        //public void Suscribe(Clock theClock)
        //{
        //    theClock.TimeChanged += delegate(object sender, TimeEventArgs e) //anonymous delegate
        //    {
        //        Console.WriteLine("Logging event at {0}:{1}:{2}",
        //            e.Hour.ToString(),
        //            e.Minute.ToString(),
        //            e.Second.ToString());
        //    };
        //}

        public void Suscribe(Clock theClock)
        {
            //timechanged always refers to TimeChangeHandler thus lambda expressions can be used
            theClock.TimeChanged += (sender, e) => //lambda expression, simple syntax for anonymous delegates
                         //same parameters as TimeChangeHandler
            {
                Console.WriteLine("Logging event at {0}:{1}:{2}",
                    e.Hour.ToString(),
                    e.Minute.ToString(),
                    e.Second.ToString());
            };
        }
    }
}
