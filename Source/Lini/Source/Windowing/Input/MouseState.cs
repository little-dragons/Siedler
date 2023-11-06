namespace Lini.Windowing.Input;

public class MouseState
{
    private Dictionary<MouseAxis, double> Axes { get; init; }
    private Dictionary<MouseButton, bool> Buttons { get; init; }


    public MouseState(Func<MouseButton, bool> buttonFetcher) {
        Axes = new();
        Buttons = new();

        foreach (var val in Enum.GetValues<MouseButton>())
            Buttons.Add(val, buttonFetcher(val));

    }

    public double Vertical => Axes[MouseAxis.Vertical];
    public double Horizontal => Axes[MouseAxis.Horizontal];

    public bool IsDown(MouseButton button)
        => Buttons[button];

    public bool IsUp(MouseButton button)
        => !IsDown(button);
}