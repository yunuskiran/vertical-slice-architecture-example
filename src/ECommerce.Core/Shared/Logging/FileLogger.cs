namespace ECommerce.Core.Shared.Logging;

public class FileLogger : ILogging
{
    private readonly string logFilePath;

    public FileLogger(string logFilePath)
    {
        this.logFilePath = logFilePath;
    }

    public void Log(string message)
    {
        File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}\n");
    }
}