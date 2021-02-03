// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    internal readonly struct Span<T>
    {
        private readonly T[] _array;
        private readonly int _start;

        public Span(T[] array)
        {
            _array = array;
            _start = 0;
            Length = array.Length;
        }

        public int Length { get; }

        public T this[int index]
        {
            get
            {
                index += _start;

                if ((uint)index >= (uint)_array.Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                return _array[index];
            }

            set
            {
                index += _start;

                if ((uint)index >= (uint)_array.Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                _array[index] = value;
            }
        }

        public static implicit operator ReadOnlySpan<T>(Span<T> span) => new ReadOnlySpan<T>(span._array, span._start, span.Length);
    }

    internal readonly struct ReadOnlySpan<T>
    {
        private readonly T[] _array;
        private readonly int _start;

        public ReadOnlySpan(T[] array)
        {
            _array = array;
            _start = 0;
            Length = array.Length;
        }

        public ReadOnlySpan(T[] array, int start, int length)
        {
            _array = array;
            _start = start;
            Length = length;
        }

        public ReadOnlySpan<T> Slice(int start, int length)
            => new ReadOnlySpan<T>(_array, _start + start, length);

        public int Length { get; }

        public T this[int index]
        {
            get
            {
                index += _start;

                if ((uint)index >= (uint)_array.Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                return _array[index];
            }
        }

        public Enumerator GetEnumerator() => new Enumerator(this);

        public ref struct Enumerator
        {
            private readonly ReadOnlySpan<T> _span;
            private int _index;

            public Enumerator(ReadOnlySpan<T> span)
            {
                _span = span;
                _index = -1;
            }

            public bool MoveNext()
            {
                int index = _index + 1;
                if (index < _span.Length)
                {
                    _index = index;
                    return true;
                }

                return false;
            }

            public T Current
            {
                get => _span[_index];
            }
        }
    }
}
