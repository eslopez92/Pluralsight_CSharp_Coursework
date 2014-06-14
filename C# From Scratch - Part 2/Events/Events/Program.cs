using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            var theClock = new Clock();//the actual clock

            var logger = new Logger();
            var visibleClock = new VisibleClock();

            visibleClock.Subscribe(theClock);//First to execute its corresponding method to the delgate
            logger.Suscribe(theClock);//Second to execute its corresponding method to the delgate
            theClock.RunClock();
        }

        
        
    }
}
