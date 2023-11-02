namespace Lini.Miscellaneous;

public static class Resources
{
    public enum Type
    {
        Shader,
        Texture,
    }

    /// <summary>
    /// The value of this variable should, if supplied at all, point directly to the folder name of 
    /// the resources folder.
    /// </summary>
    public const string EnvironmentDir = "LINI_RESOURCE_DIR";
    public const string FallbackName = "Resources";

    /// <summary>
    /// This method initializes the <see cref="ResourceRootPath"/> by either extracting the environment variable
    /// with the name of <see cref="EnvironmentDir"/> or defaulting to <see cref="FallbackName"/>.
    /// </summary>
    internal static void Initialize()
    {
        ResolvedTypeFolders.Clear();

        string? env = Environment.GetEnvironmentVariable(EnvironmentDir);
        if (env is null)
        {
            Logger.Info("No resource path environment variable given.", Logger.Source.Resources);
            ResourceRootPath = FallbackName;
        }
        else
        {
            Logger.Info("Read resource path from environment variable.", Logger.Source.Resources);
            ResourceRootPath = env;
        }

        ResourceRootPath = Path.GetFullPath(ResourceRootPath);

        Logger.Info($"Resolved {nameof(ResourceRootPath)} to \"{ResourceRootPath}\".", Logger.Source.Resources);
        ValidateResourcePath();

        foreach (var (t, s) in TypeFolderNames)
            ResolvedTypeFolders.Add(t, Path.Join(ResourceRootPath, s));
    }

    /// <summary>
    /// Validates that the <see cref="ResourceRootPath"/> contains all expected folder names
    /// and is in fact a folder itself.
    /// </summary>
    private static void ValidateResourcePath()
    {
        if (!Directory.Exists(ResourceRootPath))
        {
            Logger.Error($"{nameof(ResourceRootPath)} does not exist.", Logger.Source.Resources);
            return;
        }

        var notContainedFolders = TypeFolderNames.Values.Where(x => !Directory.GetDirectories(ResourceRootPath).Contains(Path.Join(ResourceRootPath, x)));
        if (notContainedFolders.Any())
        {
            Logger.Error(
                $"{nameof(ResourceRootPath)} does not contain the folder(s): {notContainedFolders.Aggregate("", string.Concat)}",
                Logger.Source.Resources);

            return;
        }
    }


    public static string ResourceRootPath { get; private set; } = "";
    private readonly static Dictionary<Type, string> TypeFolderNames = new() {
        { Type.Shader, "Shaders" },
        { Type.Texture, "Textures" },
    };

    private readonly static Dictionary<Type, string> ResolvedTypeFolders = new();

    public static string PathFor(Type type)
    {
        return ResolvedTypeFolders[type];
    }
    public static string PathFor(Type type, string fileName)
    {
        return Path.Join(ResolvedTypeFolders[type], fileName);
    }
}