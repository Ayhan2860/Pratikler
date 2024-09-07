using System;
namespace arayuzler
{
    public class LoggerManager:ILogger
    {
        public ILogger _logger;

        public LoggerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}