using Lini;
using Lini.Rendering;
using Lini.Windowing;


WindowInfo info = new()
{
    Width = 800,
    Height = 600,
    FullScreen = false,
    Title = "Linchen ist toll"
};

Sam.Initialize(info);

var vertices =
    new Vertex[] {
        new() { TextureCoordinates = new(0, 0), Position = new(0.5f, -0.5f, 0.0f) },
        new() { TextureCoordinates = new(0, 0), Position = new(-0.5f, -0.5f, 0.0f) },
        new() { TextureCoordinates = new(0, 0), Position = new(0.5f, 0.5f, 0.0f) },
        new() { TextureCoordinates = new(0, 0), Position = new(-0.5f, 0.5f, 0.0f) },
        };
var indices =
    new uint[] { 0, 1, 2, 1, 2, 3 };

Mesh mesh = new(vertices, indices);

Sam.Run(mesh);

Sam.Terminate();