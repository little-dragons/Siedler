using Lini.Scene.Components;

namespace Lini.Scene;

public class Scene
{
    public Camera? ActiveCamera { get; set; }
    public List<Entity> Entities { get; init; } = new();
    
}