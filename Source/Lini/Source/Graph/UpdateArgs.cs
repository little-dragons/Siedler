using Lini.Windowing;
using Lini.Windowing.Input;

namespace Lini.Graph;

public record UpdateArgs(float DeltaTime, IInput Input, WindowInfo CurrentWindowInfo)
{
    /// <summary>
    /// The target info of the rendering window. This will be applied to the window after the updating and rendering is done.
    /// This variable may be changed by the user freely. To see the current info the window which is valid for this update
    /// and rendering cycle, see <see cref="CurrentWindowInfo"/>.
    /// </summary>
    public required WindowInfo TargetWindowInfo { get; set; }
}