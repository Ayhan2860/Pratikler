
namespace Interfaces
{
    public class LoggerManager : ILogger
    {
        private readonly List<ILogger> _logger;
        public LoggerManager(params ILogger[] logger)
        {
            _logger = logger.ToList();
        }
        public void WriteLog()
        {
            _logger.ForEach(x => x.WriteLog());
        }
    }
}