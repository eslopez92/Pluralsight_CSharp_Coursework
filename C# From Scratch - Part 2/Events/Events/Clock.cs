using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Events
{
    public class Clock
    {
        private int hour;
        private int minute;
        private int second;
        
        public delegate void TimeChangeHandler(object clock, TimeEventArgs timeInfo);//definition
        public event TimeChangeHandler TimeChanged;//delgete to refer that a second has elapsed

        public void RunClock()
        {

            while (true)
            {
                Thread.Sleep(100);//sleep 100 ms
                DateTime currentTime = DateTime.Now;//date time object

                //checks to see if a second has passed by
                //notify to the subscribers
                if (currentTime.Second != this.second)
                {
                    //Other classes are ENABLED to execute their functions that refer to this delegate
                    TimeEventArgs timeEventArgs = new TimeEventArgs()//create an instance of this class with these parameters
                    {
                        Hour = currentTime.Hour,
                        Minute = currentTime.Minute,
                        Second = currentTime.Second
                    };
                  
                    //this will always be true because an instance of that delegate
                    if (TimeChanged != null)//means an even happened from the delegate
                    {
                        //other classes that are subcribed to this event, are NOW going to execute their functions/methods
                        TimeChanged(this/*.clock*/, timeEventArgs);
                    }

                    this.second = currentTime.Second;
                    this.minute = currentTime.Minute;
                    this.hour = currentTime.Hour;
                }
            }
        }
    }
}
