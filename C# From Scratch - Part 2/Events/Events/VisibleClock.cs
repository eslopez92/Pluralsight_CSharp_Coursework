using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    class VisibleClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.TimeChanged += new Clock.TimeChangeHandler(NewTime);//a new delegate
            //subscribe to that event through the delegate time change, then add to your set of subscriptions
            //when the delegate is invoked, call the method NewTime
        }

        public void NewTime(object theClock, TimeEventArgs e)//standard convention
        {
            Console.WriteLine("{0}:{1}:{2}",
                e.Hour.ToString(),
                e.Minute.ToString(),
                e.Second.ToString());
        }
    }
}
