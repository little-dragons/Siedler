using Lini.UI;

namespace Lini.Graph.Components.BuiltIn;

public struct UITransform : IComponent
{
    static int IComponent.TypeID { get; set; }

    public Point Point;
}