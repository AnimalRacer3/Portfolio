using System;
using System.threading;

namespace Libraries
{
    public class DelayHelper
    {
        public static void Delay(TimeSpan duration)
        {
            Thread.Sleep(duration);
        }
    }
}