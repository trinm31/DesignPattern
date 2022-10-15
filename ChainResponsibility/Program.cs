using System;

namespace ChainResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
           // init chain
           var logger = AppLogger.GetLogger();
           
           // handle by console logger
           logger.Log(LogLevel.INFO, "Info msg");
           logger.Log(LogLevel.DEBUG, "Debug msg");
           logger.Log(LogLevel.WARNING, "Warning msg");
           
           // handle by file logger
           logger.Log(LogLevel.ERROR, "Error msg");
           
           // handle by email logger
           logger.Log(LogLevel.FATAL, "Fatal msg");
        }
    }
}