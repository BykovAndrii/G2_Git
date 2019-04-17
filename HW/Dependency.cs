using System;

namespace HW
{
    interface ILogger
    {
        void LoggerLog();
    }

    class Logger : ILogger
    {
        public void LoggerLog()
        {
            Console.WriteLine("From logger"); 
        }
    }

    class NewLogger : ILogger
    {
        public void LoggerLog()
        {
            Console.WriteLine("From new logger");
        }
    }

    class Dependency
    {
        private ILogger internalLogger;

        public Dependency(ILogger logger)
        {
            internalLogger = logger;
        }

        public void Log()
        {
            internalLogger.LoggerLog();
        }
    }
}
