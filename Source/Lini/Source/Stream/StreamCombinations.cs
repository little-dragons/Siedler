namespace Lini.Stream;

public interface IReadWriteStream<T, U> : IReadStream<T>, IWriteStream<U>
{

}

public interface IReadSeekStream<T, U> : IReadStream<T>, ISeekStream<U>
{

}

public interface IWriteSeekStream<T, U> : IWriteStream<T>, ISeekStream<U>
{

}

public interface IReadWriteSeekStream<T, U, V> : IReadWriteStream<T, U>, IReadSeekStream<T, V>, IWriteSeekStream<U, V>
{

}