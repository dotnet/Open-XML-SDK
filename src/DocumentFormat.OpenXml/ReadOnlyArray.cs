// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    [DebuggerDisplay("Length = {Length}")]
    internal readonly struct ReadOnlyArray<T>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        private readonly T[] _array;

        private ReadOnlyArray(T[] array)
        {
            _array = array;
        }

        public bool Any() => Length > 0;

        public ref T this[int index] => ref _array[index];

        public int Length => _array.Length;

        public Enumerator GetEnumerator() => new Enumerator(_array);

        public struct Enumerator
        {
            private readonly T[] _array;
            private int _index;

            public Enumerator(T[] array)
            {
                _array = array;
                _index = -1;
            }

            public ref T Current => ref _array[_index];

            public bool MoveNext() => ++_index < _array.Length;
        }

        public static implicit operator ReadOnlyArray<T>(T[] array) => new ReadOnlyArray<T>(array);
    }
}
