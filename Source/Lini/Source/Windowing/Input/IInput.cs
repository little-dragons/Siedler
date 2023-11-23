using System.Numerics;

namespace Lini.Windowing.Input;

public interface IInput
{
    public bool IsDown(Key key);
    public bool IsPressed(Key key);
    public bool IsReleased(Key key);
    public bool IsUp(Key key)
        => !IsDown(key);

    public bool IsDown(MouseButton button);
    public bool IsPressed(MouseButton button);
    public bool IsReleased(MouseButton button);
    public bool IsUp(MouseButton button)
        => !IsDown(button);


    public Vector2 ScrollDelta { get; }
    public Vector2 MouseDelta { get; }
    public Vector2 MousePosition { get; }


    public string Text { get; }
}