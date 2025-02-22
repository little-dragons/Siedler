using System.Collections.Immutable;
using System.Numerics;
using Lini.Miscellaneous;

namespace Lini.Windowing.Input;

public record InputState(
    ImmutableDictionary<Key, bool> KeyState,
    ImmutableDictionary<MouseButton, bool> MouseButtonState,
    Vector2 MousePosition)
{
    private ImmutableDictionary<Key, bool> KeyState { get; init; } = KeyState;
    private ImmutableDictionary<MouseButton, bool> MouseButtonState { get; init; } = MouseButtonState;

    public bool IsDown(Key key)
        => KeyState[key];
    public bool IsUp(Key key)
        => !IsDown(key);

    public bool IsDown(MouseButton button)
        => MouseButtonState[button];
    public bool IsUp(MouseButton button)
        => !IsDown(button);

    public InputState MakeNew(InputEvent e)
    {
        if (e is MouseButtonPressedEvent mbpe)
            return this with { MouseButtonState = MouseButtonState.SetItem(mbpe.Button, true) };
        else if (e is MouseButtonReleasedEvent mbre)
            return this with { MouseButtonState = MouseButtonState.SetItem(mbre.Button, false) };
        if (e is KeyPressedEvent kpe)
            return this with { KeyState = KeyState.SetItem(kpe.Key, true) };
        else if (e is KeyReleasedEvent kre)
            return this with { KeyState = KeyState.SetItem(kre.Key, false) };
        else if (e is MouseMoveEvent mme)
            return this with { MousePosition = mme.NewPosition };
        else if (e is not TextInputEvent)
            Logger.Warn($"Unknown event: {e}");

        return this;
    }
}