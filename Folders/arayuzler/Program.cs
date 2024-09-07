using System;

namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
             FileLogger file = new FileLogger();
             file.WriteLog();

             DatabaseLogger databaseLogger = new DatabaseLogger();
             databaseLogger.WriteLog();

             SmsLogger smsLogger = new SmsLogger();
             smsLogger.WriteLog();

             LoggerManager loggerManager = new LoggerManager(new FileLogger());
             loggerManager.WriteLog();


        }
    }
}
