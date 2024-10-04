

namespace ATMApp.Services
{
    public class FileLoggerService : ILoggerService
    {
        private string folderPath;
        private string logFilePath;

        public FileLoggerService()
        {
            folderPath = Environment.CurrentDirectory + "/Logs";
            logFilePath = folderPath + $"/EOD_Date{DateTime.Now:dd.MM.yyy}.txt";
            FolderWithFileExistsAndCreate();
        }

        public void Write(string value)
        {
            value = $"\n[{DateTime.Now:T}] -->>> Log =>> {value}";
            File.AppendAllText(logFilePath, value);
        }

        private void FolderWithFileExistsAndCreate()
        {
            if(!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            if(!File.Exists(logFilePath))
                File.Create(logFilePath);
        }
    }
}