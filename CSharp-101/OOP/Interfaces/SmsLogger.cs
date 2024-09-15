
namespace Interfaces
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Sms loglama");
        }
    }
}