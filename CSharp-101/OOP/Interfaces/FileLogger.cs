
namespace Interfaces
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
           Console.WriteLine("File loglama");
        }
    }
}