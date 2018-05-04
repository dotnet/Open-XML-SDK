// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    internal readonly struct AttributeTagCollection
    {
        private readonly ReadOnlyArray<AttributeTag> _tags;
        private readonly OpenXmlSimpleType[] _fields;

        public AttributeTagCollection(in ReadOnlyArray<AttributeTag> tags)
        {
            _tags = tags;

            if (tags.Length == 0)
            {
                _fields = Cached.Array<OpenXmlSimpleType>();
            }
            else
            {
                _fields = new OpenXmlSimpleType[tags.Length];
            }
        }

        public bool Any() => Length > 0;

        public AttributeEntry this[int index] => new AttributeEntry(this, index);

        public AttributeEntry this[string namespaceUri, string tagName] => this[GetIndex(namespaceUri, tagName)];

        public int Length => _fields.Length;

        public Enumerator GetEnumerator() => new Enumerator(this);

        private int GetIndex(string namespaceUri, string tagName)
        {
            if (!string.IsNullOrEmpty(tagName) && namespaceUri != null && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out byte nsId))
            {
                for (int i = 0; i < _tags.Length; i++)
                {
                    var tag = _tags[i];

                    if (tag.Name.Equals(tagName, StringComparison.Ordinal) && tag.NamespaceId == nsId)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public struct Enumerator
        {
            private readonly AttributeTagCollection _collection;
            private int _index;

            public Enumerator(in AttributeTagCollection collection)
            {
                _collection = collection;
                _index = -1;
            }

            public AttributeEntry Current => _collection[_index];

            public bool MoveNext() => ++_index < _collection.Length;
        }

        public readonly struct AttributeEntry
        {
            private readonly AttributeTagCollection _collection;
            private readonly int _index;

            public AttributeEntry(in AttributeTagCollection collection, int index)
            {
                _collection = collection;
                _index = index;
            }

            public bool IsNil => _index == -1;

            public ref readonly AttributeTag Tag => ref _collection._tags[_index];

            public ref OpenXmlSimpleType Value => ref _collection._fields[_index];

            public bool HasValue => Value != null;
        }

        public static implicit operator AttributeTagCollection(in ReadOnlyArray<AttributeTag> array) => new AttributeTagCollection(array);

        public static implicit operator AttributeTagCollection(AttributeTag[] array) => new AttributeTagCollection(array);
    }
}
