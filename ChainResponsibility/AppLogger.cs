using System;

namespace ChainResponsibility
{
    public class AppLogger
    {
        public static Logger GetLogger()
        {
            var consoleLogger = new ConsoleLogger(LogLevel.DEBUG);
            var fileLogger = consoleLogger.SetNext(new FileLogger(LogLevel.ERROR));
            fileLogger.SetNext(new EmailLogger(LogLevel.FATAL));

            return consoleLogger;
        }
    }
}