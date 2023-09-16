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
        Control,
        GLFW,
        GL
    }

    public static void Info(string message, Source? source = null)
    {
        Console.WriteLine($"Info{(source is null ? "" : $"[{source}]")}: " + message);
    }
    public static void Warn(string message, Source? source = null)
    {
        Console.WriteLine($"WARN{(source is null ? "" : $"[{source}]")}: " + message);
    }
    public static void Error(string message, Source? source = null)
    {
        Console.WriteLine($"ERROR{(source is null ? "" : $"[{source}]")}: " + message);
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