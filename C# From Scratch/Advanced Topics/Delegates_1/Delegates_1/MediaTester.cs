using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates_1
{
    public class MediaTester
    {
        public delegate int TestMedia();

        public void RunTest(TestMedia testDelegate)
        {
            int result = testDelegate();

            if (result == 0)
                Console.WriteLine("Works!");
            if (result == 1)
                Console.WriteLine("Failed.");
        }
    }
}
