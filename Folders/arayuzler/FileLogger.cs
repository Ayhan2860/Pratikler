using System;
namespace arayuzler
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
           Console.WriteLine("File olarak loglandı.");
        }
    }
}