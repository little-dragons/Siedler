using System.Numerics;
using Lini.Rendering.GLBindings;

namespace Lini.Graph;

internal class RenderArgs
{
    internal RenderArgs(Program program, double globalTime)
    {
        Program = program;
        GlobalTime = globalTime;
        Transforms = new();
        Transforms.Push(Matrix4x4.Identity);
    }

    internal Stack<Matrix4x4> Transforms { get; init; }
    internal Program Program { get; init; }
    internal double GlobalTime { get; init; }
}