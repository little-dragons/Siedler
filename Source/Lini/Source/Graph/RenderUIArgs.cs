using Lini.Rendering.GLBindings;

namespace Lini.Graph;

internal class RenderUIArgs
{
    public RenderUIArgs(Program program, double globalTime)
    {
        Program = program;
        Program.Bind();
        GlobalTime = globalTime;
    }

    internal Program Program { get; init; }
    internal double GlobalTime { get; init; }
}