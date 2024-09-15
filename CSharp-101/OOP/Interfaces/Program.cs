// See https://aka.ms/new-console-template for more information


using Interfaces;

// StandartMetot();
LoggerManager  loggerManager = new(new SmsLogger(), new DatabaseLogger(), new FileLogger());
loggerManager.WriteLog();

static void StandartMetot()
{
    SmsLogger smsLogger = new();
    smsLogger.WriteLog();
    FileLogger fileLogger = new();
    fileLogger.WriteLog();
    DatabaseLogger databaseLogger = new();
    databaseLogger.WriteLog();
}

