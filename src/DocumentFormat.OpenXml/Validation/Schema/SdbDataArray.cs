// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    internal class SdbDataArray<T>
        where T : SdbData, new()
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte[] _sdbDataBytes;

        public SdbDataArray(byte[] sdbDataBytes, int count)
        {
            Debug.Assert(sdbDataBytes != null);
            Debug.Assert(sdbDataBytes.Length > 0);

            _sdbDataBytes = sdbDataBytes;

            Count = count;
        }

        public int Count { get; }

        /// <summary>
        /// Indexer to retrieve data.
        /// </summary>
        /// <param name="index">The index of the data item.</param>
        /// <returns>Always returns a new data object.</returns>
        public T this[int index]
        {
            get
            {
                Debug.Assert(index >= 0);

                var sdbData = new T();

                Debug.Assert(index < _sdbDataBytes.Length / sdbData.DataSize);

                sdbData.LoadFromBytes(_sdbDataBytes, index * sdbData.DataSize);

                return sdbData;
            }
        }
    }
}
