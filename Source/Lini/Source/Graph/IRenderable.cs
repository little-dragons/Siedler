namespace Lini.Graph;

internal interface IRenderable3D
{
    internal void Render(Render3DArgs args);
}

internal interface IRenderableUI
{
    internal void Render(RenderUIArgs args);
}