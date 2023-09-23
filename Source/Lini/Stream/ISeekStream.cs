namespace Lini.Stream;

public interface ISeekStream<T> where T : unmanaged
{
    public nuint Length { get; }
    public nuint Position { get; set; }
}