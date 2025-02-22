using System.Collections.Immutable;
using System.Numerics;
using Lini.Miscellaneous;

namespace Lini.Windowing.Input;


public record InputEvent()
{
    public record Collection
    {
        public ImmutableQueue<KeyPressedEvent> KeyPressedEvents { get; init; } = [];
        public ImmutableQueue<KeyReleasedEvent> KeyReleasedEvents { get; init; } = [];
        public ImmutableQueue<MouseMoveEvent> MouseMoveEvents { get; init; } = [];
        public ImmutableQueue<TextInputEvent> TextInputEvents { get; init; } = [];
        public ImmutableQueue<MouseButtonPressedEvent> MouseButtonPressedEvents { get; init; } = [];
        public ImmutableQueue<MouseButtonReleasedEvent> MouseButtonReleasedEvents { get; init; } = [];

        public Collection()
        {

        }
        public Collection(IEnumerable<InputEvent> events)
        {
            ImmutableQueue<KeyPressedEvent> keyPressedEvents = [];
            ImmutableQueue<KeyReleasedEvent> keyReleasedEvents = [];
            ImmutableQueue<MouseMoveEvent> mouseMoveEvents = [];
            ImmutableQueue<TextInputEvent> textInputEvents = [];
            ImmutableQueue<MouseButtonPressedEvent> mouseButtonPressedEvents = [];
            ImmutableQueue<MouseButtonReleasedEvent> mouseButtonReleasedEvents = [];

            foreach (var e in events)
            {
                switch (e)
                {
                    case MouseButtonPressedEvent mbpe:
                        mouseButtonPressedEvents = mouseButtonPressedEvents.Enqueue(mbpe);
                        continue;
                    case MouseButtonReleasedEvent mbre:
                        mouseButtonReleasedEvents = mouseButtonReleasedEvents.Enqueue(mbre);
                        continue;
                    case KeyPressedEvent kpe:
                        keyPressedEvents = keyPressedEvents.Enqueue(kpe);
                        continue;
                    case KeyReleasedEvent kre:
                        keyReleasedEvents = keyReleasedEvents.Enqueue(kre);
                        continue;
                    case TextInputEvent tie:
                        textInputEvents = textInputEvents.Enqueue(tie);
                        continue;
                    case MouseMoveEvent mme:
                        mouseMoveEvents = mouseMoveEvents.Enqueue(mme);
                        continue;
                    default:
                        Logger.Warn($"Unknown event: {e}");
                        break;
                }
            }

            KeyPressedEvents = keyPressedEvents;
            KeyReleasedEvents = keyReleasedEvents;
            MouseMoveEvents = mouseMoveEvents;
            TextInputEvents = textInputEvents;
            MouseButtonPressedEvents = mouseButtonPressedEvents;
            MouseButtonReleasedEvents = mouseButtonReleasedEvents;
        }
    };

    public record Queue(ImmutableQueue<InputEvent> Events)
    {
        public Collection Collection { get; init; } = new(Events);
        public Queue Enqueue(InputEvent ev)
            => new(Events.Enqueue(ev));
    }
}

public record KeyPressedEvent(Key Key) : InputEvent();
public record KeyReleasedEvent(Key Key) : InputEvent();
public record MouseMoveEvent(Vector2 Delta, Vector2 NewPosition) : InputEvent();
public record TextInputEvent(string Text) : InputEvent();
public record MouseButtonPressedEvent(MouseButton Button) : InputEvent();
public record MouseButtonReleasedEvent(MouseButton Button) : InputEvent();
