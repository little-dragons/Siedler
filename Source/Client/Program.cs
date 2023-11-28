using Client;
using Lini;
using Lini.Graph;
using Lini.Graph.Components.BuiltIn;
using Lini.Image;
using Lini.Miscellaneous;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.UI;
using Lini.Windowing;

Run();
// Run();



static void Run()
{
    WindowInfo info = new("Lini", new(800, 800), 60, new(new WindowedInfo(null)), false);

    Sam.Initialize(info);

    var vertices =
        new Vertex[] {
            new() { TextureCoordinates = new(0, 0), Position = new(0.5f, -0.5f, 0.0f) },
            new() { TextureCoordinates = new(1, 0), Position = new(-0.5f, -0.5f, 0.0f) },
            new() { TextureCoordinates = new(0, 1), Position = new(0.5f, 0.5f, 0.0f) },
            new() { TextureCoordinates = new(1, 1), Position = new(-0.5f, 0.5f, 0.0f) } };

    uint[] indices = [0, 1, 2, 1, 2, 3];

    Mesh<Vertex> mesh = new(vertices, indices);
    Texture text = new(ImageData.FromFile(Resources.PathFor(Resources.Type.Texture, "pews.png"))!);

    Rectangle buttonBox = new()
    {
        Point1 = new(),
        Point2 = new()
        {
            Percent = new(0.5f, 0.5f)
        }
    };

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


    Entity buttonEntity = scene.Root.MakeChild();
    buttonEntity.Add<Button>() = new(buttonBox) {
        BackgroundColor = new () {
            X = 1.0f,
            Y = 0.0f,
            Z = 0.0f,
            W = 1.0f,
        }
    };


    Sam.Run(scene);

    // Sam.Terminate();
    Sam.Terminate();
}
