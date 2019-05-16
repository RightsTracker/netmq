using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NetMQ.Utils
{
    public class LoggingDebug
    {
        public static void Assert(bool condition)
        {
            if (condition) return;

            //TODO: log here with something else - maybe NLOG?
            Debug.WriteLine("LogginDebug.Assert - condition was not met");
            return;
        }
    }
}
