static class LogLine
{
    public static string Message(string logLine) => logLine.Split(':')[1].Trim();

    public static string LogLevel(string logLine) => logLine.Split(':')[0].Replace("[","").Replace("]","").ToLower();

    public static string Reformat(string logLine)
    {
        string message = logLine.Split(':')[1].Trim();
        string logLevel = logLine.Split(':')[0].Replace("[","(").Replace("]",")").ToLower();
        return $"{message} {logLevel}";
    }
}
