using System.Collections.Generic;

namespace System.Collections.Generic
{
    internal interface IReadOnlyCollection<T> : IEnumerable<T>
    {
        int Count { get; }
    }
}
