namespace ChainResponsibility
{
    public abstract class Logger
    {
        protected LogLevel _logLevel;
        protected Logger _nextLogger;

        public Logger(LogLevel logLevel)
        {
            _logLevel = logLevel;
        }

        public Logger SetNext(Logger nextLogger)
        {
            _nextLogger = nextLogger;
            return nextLogger;
        }

        public void Log(LogLevel severity, string msg)
        {
            if (_logLevel <= severity)
            {
                WriteMessage(msg);
            }

            if (_nextLogger != null)
            {
                _nextLogger.Log(severity, msg);
            }
        }

        protected abstract void WriteMessage(string msg);
    }
}