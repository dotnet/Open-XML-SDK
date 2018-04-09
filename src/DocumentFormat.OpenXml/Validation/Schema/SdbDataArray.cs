// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    internal class SdbDataArray<T>
    {
        private readonly Func<byte[], int, T> _factory;
        private readonly byte[] _data;
        private readonly int _typeSize;

        public SdbDataArray(Stream stream, int count, int typeSize, Func<byte[], int, T> factory)
        {
            _factory = factory;
            _typeSize = typeSize;

            var size = count * typeSize;
            _data = new byte[size];
            stream.Read(_data, 0, size);
        }

        public T this[int index]
        {
            get => _factory(_data, index * _typeSize);
        }
    }
}
