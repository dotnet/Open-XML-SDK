namespace System.Collections.Generic
{
    internal interface IReadOnlyList<T> : IReadOnlyCollection<T>
    {
        T this[int index] { get; }
    }
}
