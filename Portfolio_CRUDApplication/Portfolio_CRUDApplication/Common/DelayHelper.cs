using System;
using System.Threading;

namespace PackageTracker.Common
{
    public class DelayHelper
    {
        public static void Delay(TimeSpan duration)
        {
            Thread.Sleep(duration);
        }
    }
}