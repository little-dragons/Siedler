namespace Lini.Windowing.Input;

public class KeyboardState
{
    Dictionary<Key, bool> Keys { get; init; }



    public KeyboardState(Func<Key, bool> query)
    {
        Keys = new();

        foreach (var val in Enum.GetValues<Key>())
            Keys.Add(val, query(val));
    }

    public bool ControlDown 
        => IsDown(Key.LeftControl) || IsDown(Key.RightControl);
    public bool ShiftDown 
        => IsDown(Key.LeftShift) || IsDown(Key.RightShift);
    public bool AltDown 
        => IsDown(Key.LeftAlt) || IsDown(Key.RightAlt);


    public bool IsDown(Key key)
        => Keys[key];

    public bool IsUp(Key key)
        => !IsDown(key);
}