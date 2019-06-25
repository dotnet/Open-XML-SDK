// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Framework
{
    [DebuggerDisplay("Length = {Length}")]
    internal readonly struct ReadOnlyList<T> : IEnumerable<T>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        private readonly List<T> _list;

        private ReadOnlyList(List<T> list)
        {
            _list = list;
        }

        public bool IsNull => _list is null;

        public bool Any() => Length > 0;

        public T this[int index] => _list[index];

        public int Length => IsNull ? 0 : _list.Count;

        public Enumerator GetEnumerator() => new Enumerator(_list);

        IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public struct Enumerator : IEnumerator<T>
        {
            private readonly List<T> _list;
            private int _index;

            public Enumerator(List<T> list)
            {
                _list = list;
                _index = -1;
            }

            public T Current => _list[_index];

            T IEnumerator<T>.Current => Current;

            object IEnumerator.Current => Current;

            public bool MoveNext() => _list is null ? false : ++_index < _list.Count;

            void IDisposable.Dispose()
            {
            }

            void IEnumerator.Reset()
            {
            }
        }

        public static implicit operator ReadOnlyList<T>(List<T> list) => new ReadOnlyList<T>(list);
    }
}
