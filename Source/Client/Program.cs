using System.Numerics;
using Lini;
using Lini.Graph;
using Lini.Graph.Components;
using Lini.Image;
using Lini.Miscellaneous;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.Windowing;

Run();
// Run();


static void Run()
{
    WindowInfo info = new()
    {
        Width = 600,
        Height = 600,
        FullScreen = false,
        Title = "Lini"
    };

    Sam.Initialize(info);

    var vertices =
        new Vertex[] {
        new() { TextureCoordinates = new(0, 0), Position = new(0.5f, -0.5f, 0.0f) },
        new() { TextureCoordinates = new(1, 0), Position = new(-0.5f, -0.5f, 0.0f) },
        new() { TextureCoordinates = new(0, 1), Position = new(0.5f, 0.5f, 0.0f) },
        new() { TextureCoordinates = new(1, 1), Position = new(-0.5f, 0.5f, 0.0f) },
            };
    var indices =
        new uint[] { 0, 1, 2, 1, 2, 3 };

    Mesh mesh = new(vertices, indices);
    Texture text = new(ImageData.FromFile(Resources.PathFor(Resources.Type.Texture, "pews.png"))!);

    MeshRenderer renderer = new(mesh, text);

    Entity meshEntity = new();
    meshEntity.SetComponent(renderer);

    Entity camEntity = new();
    camEntity.Transform.Position.Z = -3f;
    camEntity.Transform.Position.Y = 1f;

    Camera cam = new()
    {
        FieldOfView = MathF.PI / 1.9f,
        NearPlane = 0.1f,
        FarPlane = 100f,
        AspectRatio = 1,
    };
    camEntity.SetComponent(cam);

    Entity root = new();
    root.AddChild(meshEntity);
    root.AddChild(camEntity);

    Scene scene = new() {
        Root = root,
        ActiveCamera = cam,
    };

    Sam.Run(scene);

    Sam.Terminate();
}

