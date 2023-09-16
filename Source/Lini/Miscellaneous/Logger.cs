namespace Lini.Miscellaneous;

public static class Logger
{
    public enum Level
    {
        Info, Warning, Error
    }
    public enum Source {
        GLCallback, 
        GLFWCallback, 
        RenderThread,
        MainThread,
        GLFW,
        GL
    }

    public static void Info(string message, Source? source = null)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write($"Info{(source is null ? "" : $"[{source}]")}");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(": " + message);
    }
    public static void Warn(string message, Source? source = null)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"WARN{(source is null ? "" : $"[{source}]")}");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(": " + message);
    }
    public static void Error(string message, Source? source = null)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"ERROR{(source is null ? "" : $"[{source}]")}");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(": " + message);
    }
    
    public static void Write(Level level, string msg, Source? source = null)
    {
        switch (level)
        {
            case Level.Info:
                Info(msg, source);
                break;
            case Level.Warning:
                Warn(msg, source);
                break;
            case Level.Error:
                Error(msg, source);
                break;
        }
    }
}