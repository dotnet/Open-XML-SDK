// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal readonly struct SdbSpan
    {
        public SdbSpan(int start, int count, int size)
        {
            Offset = start;
            Count = count;
            Size = size;
        }

        /// <summary>
        /// Gets the offset from the beginning of the array
        /// </summary>
        public int Offset { get; }

        /// <summary>
        /// Gets the count of how many items
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// Gets the size of an individual item in bytes
        /// </summary>
        public int Size { get; }

        /// <summary>
        /// Gets the length of array in bytes
        /// </summary>
        public int Length => Count * Size;

        /// <summary>
        /// Gets the end position in the array
        /// </summary>
        public int End => Offset + Length;

        public override string ToString() => $"{Offset} : {Size} : {Count}";

        public static SdbSpan Create<T>(int start)
            where T : struct
        {
            return new SdbSpan(start, 1, Marshal.SizeOf<T>());
        }

        public static SdbSpan Create<T>(int start, T[] items)
            where T : struct
        {
            return new SdbSpan(start, items.Length, Marshal.SizeOf<T>());
        }
    }
}
