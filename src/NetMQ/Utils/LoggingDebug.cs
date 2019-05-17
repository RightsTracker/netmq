using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using NLog;

namespace NetMQ.Utils
{
    public class LoggingDebug
    {
        public static Logger log = LogManager.GetLogger("NetMQ");

        public static void Assert(bool condition)
        {
            if (condition) return;

            log.Warn($"Assert false! At {Environment.StackTrace}");
        }
    }
}
