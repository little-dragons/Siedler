using Lini.Miscellaneous;
using Lini.Rendering.GLBindings;

namespace Lini.Rendering;

internal static class SharedObjects
{
    public static Program Simple = null!;

    internal static void Initialize()
    {
        Logger.Info("Loading shared GL objects.", Logger.Source.GL);

        string vertexShaderSource =
            """
            #version 330

            layout(location = 0) in vec3 coord;
            void main() {
                gl_Position = vec4(coord, 1.0);
            }
            """;

        string fragmentShaderSource =
            """
            #version 330

            out vec4 color;
            void main() {
                color = vec4(1.0);
            }
            """;

        Shader vertexShader = new(ShaderType.Vertex, vertexShaderSource);
        Shader fragmentShader = new(ShaderType.Fragment, fragmentShaderSource);

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