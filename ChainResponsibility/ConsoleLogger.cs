using System;

namespace ChainResponsibility
{
    public class ConsoleLogger : Logger
    {
        public ConsoleLogger(LogLevel logLevel) : base(logLevel)
        {
        }

        protected override void WriteMessage(string msg)
        {
            Console.WriteLine("Console logger " + msg);
        }
    }
}