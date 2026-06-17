// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Text;
using System.Threading;

#if !NET35
using System;
using System.Collections.Concurrent;
#endif

namespace DocumentFormat.OpenXml.Framework
{
    /// <summary>
    /// Provides a shared, reusable pool of <see cref="StringBuilder"/> instances to reduce allocations.
    /// </summary>
    /// <remarks>
    /// Design mirrors DefaultObjectPool from Microsoft.Extensions.ObjectPool:
    /// a single lock-free fast-path slot plus a bounded overflow queue capped at
    /// <c>Environment.ProcessorCount * 2</c>.
    /// </remarks>
    internal static class StringBuilderPool
    {
        // Maximum capacity (in characters) a StringBuilder may have before it is not returned to the pool.
        private const int MaxBuilderCapacity = 360;

#if !NET35
        // Secondary queue for concurrent overflow; capacity is ProcessorCount * 2 minus 1 for _fastItem.
        private static readonly ConcurrentQueue<StringBuilder> _items = new ConcurrentQueue<StringBuilder>();
        private static readonly int _maxCapacity = (Environment.ProcessorCount * 2) - 1;
#endif

        // Single fast-path slot; accessed via Interlocked.CompareExchange for lock-free hand-off.
        private static StringBuilder? _fastItem;

#if !NET35
        private static int _numItems;
#endif

        /// <summary>
        /// Acquires a <see cref="StringBuilder"/> from the pool, or creates a new one if the pool is empty.
        /// </summary>
        public static StringBuilder Acquire()
        {
            var item = _fastItem;
            if (item != null && Interlocked.CompareExchange(ref _fastItem, null, item) == item)
            {
                return item;
            }

#if !NET35
            if (_items.TryDequeue(out item))
            {
                Interlocked.Decrement(ref _numItems);
                return item;
            }
#endif

            return new StringBuilder();
        }

        /// <summary>
        /// Returns the string value of the <see cref="StringBuilder"/> and releases it back to the pool.
        /// </summary>
        public static string GetValueAndRelease(StringBuilder sb)
        {
            var result = sb.ToString();
            Release(sb);
            return result;
        }

        /// <summary>
        /// Releases a <see cref="StringBuilder"/> back to the pool after clearing it.
        /// </summary>
        public static void Release(StringBuilder sb)
        {
            // Don't pool excessively large instances to avoid retaining large memory allocations.
            if (sb.Capacity > MaxBuilderCapacity)
            {
                return;
            }

            // Use Length = 0 instead of Clear() for .NET 3.5 compatibility.
            sb.Length = 0;

            if (Interlocked.CompareExchange(ref _fastItem, sb, null) == null)
            {
                return;
            }

#if !NET35
            if (Interlocked.Increment(ref _numItems) <= _maxCapacity)
            {
                _items.Enqueue(sb);
                return;
            }

            // Pool is full; drop the instance so it can be GC'd.
            Interlocked.Decrement(ref _numItems);
#endif
        }
    }
}
