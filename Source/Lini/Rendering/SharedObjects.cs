using System.Numerics;
using Lini.Miscellaneous;
using Lini.Rendering.GLBindings;

namespace Lini.Rendering;

internal static class SharedObjects
{
    public static Program Simple = null!;

    internal static void Initialize()
    {
        Logger.Info("Loading shared GL objects.", Logger.Source.GL);


        Shader vertexShader = new(ShaderType.Vertex, File.ReadAllText(Resources.PathFor(Resources.Type.Shader, "SimpleVertex.glsl")));
        Shader fragmentShader = new(ShaderType.Fragment, File.ReadAllText(Resources.PathFor(Resources.Type.Shader, "SimpleFragment.glsl")));

        Simple = new(new[] { vertexShader, fragmentShader });

        vertexShader.Delete();
        fragmentShader.Delete();
    }

    internal static void Terminate()
    {
        Logger.Info("Deleting shared GL objects.", Logger.Source.GL);
        Simple.Delete();
    }
}