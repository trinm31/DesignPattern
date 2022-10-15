using System;

namespace ChainResponsibility
{
    public class FileLogger: Logger
    {
        public FileLogger(LogLevel logLevel) : base(logLevel)
        {
        }

        protected override void WriteMessage(string msg)
        {
            Console.WriteLine("File logger " + msg);
        }
    }
}