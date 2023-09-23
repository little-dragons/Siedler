namespace Lini.Stream;

public interface IReadWriteStream<T> : IReadStream<T>, IWriteStream<T> where T : unmanaged
{

}

public interface IReadSeekStream<T> : IReadStream<T>, ISeekStream<T> where T : unmanaged
{

}

public interface IWriteSeekStream<T> : IWriteStream<T>, ISeekStream<T> where T : unmanaged
{

}

public interface IReadWriteSeekStream<T> : IReadWriteStream<T>, IReadSeekStream<T>, IWriteSeekStream<T> where T : unmanaged
{

}