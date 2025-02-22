using Lini.Graph;
using Lini.Graph.Components;

namespace Client;

public struct EventsPrinter : IComponent
{
    static int IComponent.TypeID { get; set; }

    public void Update(UpdateArgs args)
    {
        foreach (var ev in args.EventsQueue.Events)
            Console.Write(ev);
    }
}