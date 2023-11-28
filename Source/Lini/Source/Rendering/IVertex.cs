namespace Lini.Rendering;

internal interface IVertex
{
    /// <summary>
    /// This method sets the vertex array attributes of this instance - since the passed information depends entirely on
    /// vertex' layouts, this is the correct place for this method. This method should be implemented explicitely to keep
    /// the visibility of the method the same the one of the interface. It should not be publicly implemented, because it
    /// will wrap plain OpenGL calls and this should not be available to the user.
    /// </summary>
    internal static abstract void SetVertexArrayAttributes();
}