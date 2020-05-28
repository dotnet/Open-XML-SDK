// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal readonly struct AttributeCollection : IEnumerable<AttributeCollection.AttributeEntry>
    {
        private readonly OpenXmlSimpleType[] _data;
        private readonly ReadOnlyArray<AttributeMetadata> _attributes;

        public AttributeCollection(ReadOnlyArray<AttributeMetadata> tags)
        {
            _attributes = tags;

            if (tags.Length == 0)
            {
                _data = Cached.Array<OpenXmlSimpleType>();
            }
            else
            {
                _data = new OpenXmlSimpleType[tags.Length];
            }
        }

        public bool IsEmpty => _data is null;

        public bool Any() => Length > 0;

        public AttributeEntry GetProperty(string propertyName) => this[GetIndex(propertyName)];

        public AttributeEntry this[int index] => new AttributeEntry(this, index);

        public AttributeEntry this[string namespaceUri, string tagName] => this[GetIndex(namespaceUri, tagName)];

        public int Length => _attributes.Length;

        private int GetIndex(string namespaceUri, string tagName)
        {
            if (!string.IsNullOrEmpty(tagName) && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out var nsId))
            {
                for (var i = 0; i < _attributes.Length; i++)
                {
                    var tag = _attributes[i];

                    if (tag.Name.Equals(tagName, StringComparison.Ordinal) && tag.NamespaceId == nsId)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        private int GetIndex(string propertyName)
        {
            for (var i = 0; i < _attributes.Length; i++)
            {
                var property = _attributes[i];

                if (property.PropertyName.Equals(propertyName, StringComparison.Ordinal))
                {
                    return i;
                }
            }

            return -1;
        }

        public Enumerator GetEnumerator() => new Enumerator(in this);

        IEnumerator<AttributeEntry> IEnumerable<AttributeEntry>.GetEnumerator() => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public struct Enumerator : IEnumerator<AttributeEntry>
        {
            private readonly AttributeCollection _collection;
            private int _index;

            public Enumerator(in AttributeCollection collection)
            {
                _collection = collection;
                _index = -1;
            }

            public AttributeEntry Current => _collection[_index];

            object IEnumerator.Current => Current;

            public bool MoveNext() => ++_index < _collection.Length;

            void IDisposable.Dispose()
            {
            }

            void IEnumerator.Reset() => throw new NotImplementedException();
        }

        public readonly struct AttributeEntry
        {
            private readonly AttributeCollection _collection;

            private readonly int _index;

            public AttributeEntry(in AttributeCollection collection, int index)
            {
                _collection = collection;
                _index = index;
            }

            public bool IsNil => _index == -1;

            public ref readonly AttributeMetadata Property => ref _collection._attributes[_index];

            public ref OpenXmlSimpleType Value => ref _collection._data[_index];

            public bool HasValue => Value != null;
        }
    }
}
