// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Framework
{
    [DebuggerDisplay("Length = {Length}")]
    internal readonly struct ReadOnlyArray<T> : IEnumerable<T>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        private readonly T[] _array;

        private ReadOnlyArray(T[] array)
        {
            _array = array;
        }

        public bool IsNull => _array is null;

        public bool Any() => Length > 0;

        public ref T this[int index] => ref _array[index];

        public int Length => IsNull ? 0 : _array.Length;

        public Enumerator GetEnumerator() => new Enumerator(_array);

        IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public struct Enumerator : IEnumerator<T>
        {
            private readonly T[] _array;
            private int _index;

            public Enumerator(T[] array)
            {
                _array = array;
                _index = -1;
            }

            public ref T Current => ref _array[_index];

            T IEnumerator<T>.Current => Current;

            object IEnumerator.Current => Current;

            public bool MoveNext() => _array is null ? false : ++_index < _array.Length;

            void IDisposable.Dispose()
            {
            }

            void IEnumerator.Reset()
            {
            }
        }

        public static implicit operator ReadOnlyArray<T>(T[] array) => new ReadOnlyArray<T>(array);
    }
}
