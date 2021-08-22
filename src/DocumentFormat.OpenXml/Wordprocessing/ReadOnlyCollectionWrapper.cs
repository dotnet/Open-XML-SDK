// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// Wraps collections and makes them appear read-only.
    /// </summary>
    /// <remarks>
    /// Can be used when targeting net35 or net40, which do not offer the
    /// IReadOnlyCollection interface. The corresponding interface offered
    /// by the SDK is internal, so cannot be used in public interfaces.
    /// </remarks>
    /// <typeparam name="T">The type of the elements of the collection.</typeparam>
    internal class ReadOnlyCollectionWrapper<T> : ICollection<T>
    {
        private readonly ICollection<T> _collection;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="collection">The collection to be wrapped.</param>
        public ReadOnlyCollectionWrapper(ICollection<T> collection)
        {
            _collection = collection;
        }

        /// <inheritdoc />
        public int Count => _collection.Count;

        /// <inheritdoc />
        public bool IsReadOnly => true;

        /// <inheritdoc />
        public void Add(T item)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        public void Clear()
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        public bool Contains(T item)
        {
            return _collection.Contains(item);
        }

        /// <inheritdoc />
        public void CopyTo(T[] array, int arrayIndex)
        {
            _collection.CopyTo(array, arrayIndex);
        }

        /// <inheritdoc />
        public bool Remove(T item)
        {
            throw new NotSupportedException();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _collection).GetEnumerator();
        }

        /// <inheritdoc />
        public IEnumerator<T> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }
    }
}
