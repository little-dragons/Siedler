using Client;
using Lini;
using Lini.Graph;
using Lini.Graph.Components.BuiltIn;
using Lini.Image;
using Lini.Miscellaneous;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.Windowing;

Run();
// Run();



static void Run()
{
    WindowInfo info = new("Lini", 800, 800, false);

    Sam.Initialize(info);

    var vertices =
        new Vertex[] {
            new() { TextureCoordinates = new(0, 0), Position = new(0.5f, -0.5f, 0.0f) },
            new() { TextureCoordinates = new(1, 0), Position = new(-0.5f, -0.5f, 0.0f) },
            new() { TextureCoordinates = new(0, 1), Position = new(0.5f, 0.5f, 0.0f) },
            new() { TextureCoordinates = new(1, 1), Position = new(-0.5f, 0.5f, 0.0f) } };

    var indices =
        new uint[] { 0, 1, 2, 1, 2, 3 };

    Mesh mesh = new(vertices, indices);
    Texture text = new(ImageData.FromFile(Resources.PathFor(Resources.Type.Texture, "pews.png"))!);


    Scene scene = new();
    Entity meshEntity = scene.Root.MakeChild();
    meshEntity.Add<MeshRenderer>() = new(mesh, text);

    Entity camEntity = scene.Root.MakeChild();
    camEntity.Transform.Position.Z = 3f;
    camEntity.Transform.Position.Y = 0f;

    camEntity.Add<Camera>(out var cameraRef) = new()
    {
        FieldOfView = MathF.PI / 1.9f,
        NearPlane = 0.1f,
        FarPlane = 100f,
        AspectRatio = 1,
        Entity = camEntity,
    };

    camEntity.Add<CameraMover>() = new()
    {
        Speed = 0.06f,
        Entity = camEntity,
    };

    scene.ActiveCamera = cameraRef;



    Sam.Run(scene);

    Sam.Terminate();
}
