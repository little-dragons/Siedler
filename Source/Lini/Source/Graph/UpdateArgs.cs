using Lini.Windowing;
using Lini.Windowing.Input;

namespace Lini.Graph;

public record UpdateArgs(float DeltaTime, IInput Input)
{
    public required WindowInfo WindowInfo { get; set; }
}