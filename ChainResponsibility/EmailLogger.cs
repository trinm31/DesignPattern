using System;

namespace ChainResponsibility
{
    public class EmailLogger: Logger
    {
        public EmailLogger(LogLevel logLevel) : base(logLevel)
        {
        }

        protected override void WriteMessage(string msg)
        {
            Console.WriteLine("Email logger " + msg);
        }
    }
}