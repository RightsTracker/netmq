using System;
using NLog;

namespace NetMQ.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public class LoggingDebug
    {
        /// <summary>
        /// 
        /// </summary>
        public static Logger log = LogManager.GetLogger("NetMQ");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="condition"></param>
        public static void Assert(bool condition)
        {
            if (condition) return;

            log.Warn($"Assert false! At {Environment.StackTrace}");
        }
    }
}
