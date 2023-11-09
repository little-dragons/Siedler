namespace Lini.Windowing.Input;

public interface IInput
{
    public bool IsDown(Key key);
    public bool IsUp(Key key)
        => !IsDown(key);

    public bool IsDown(MouseButton button);
    public bool IsUp(MouseButton button)
        => !IsDown(button);

    public float GetAxis(MouseAxis axis);

    public string Text { get; }
}