// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal readonly struct ElementMetadata
    {
        private readonly OpenXmlSimpleType[] _data;

        public static ElementMetadata Empty => new ElementMetadata(null);

        public static ElementMetadata Create<TMetadataProvider>()
            where TMetadataProvider : IElementMetadataProvider, new()
            => CreatorHelper<TMetadataProvider>.Instance;

        public ElementMetadata(ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> tags)
        {
            Raw = tags;

            if (tags.Length == 0)
            {
                _data = Array.Empty<OpenXmlSimpleType>();
            }
            else
            {
                _data = new OpenXmlSimpleType[tags.Length];
            }
        }

        public ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> Raw { get; }

        public bool Any() => Length > 0;

        public ref OpenXmlSimpleType GetProperty(string propertyName)
        {
            for (var i = 0; i < Raw.Length; i++)
            {
                var property = Raw[i];

                if (property.PropertyName.Equals(propertyName, StringComparison.Ordinal))
                {
                    return ref _data[i];
                }
            }

            throw new InvalidOperationException();
        }

        public PropertyEntry this[int index] => new PropertyEntry(this, index);

        public PropertyEntry this[string namespaceUri, string tagName] => this[GetIndex(namespaceUri, tagName)];

        public int Length => Raw.Length;

        public Enumerator GetEnumerator() => new Enumerator(this);

        private int GetIndex(string namespaceUri, string tagName)
        {
            if (!string.IsNullOrEmpty(tagName) && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out var nsId))
            {
                for (var i = 0; i < Raw.Length; i++)
                {
                    var tag = Raw[i];

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
            private readonly ElementMetadata _collection;
            private int _index;

            public Enumerator(in ElementMetadata collection)
            {
                _collection = collection;
                _index = -1;
            }

            public PropertyEntry Current => _collection[_index];

            public bool MoveNext() => ++_index < _collection.Length;
        }

        public readonly struct PropertyEntry
        {
            private readonly ElementMetadata _collection;

            private readonly int _index;

            public PropertyEntry(in ElementMetadata collection, int index)
            {
                _collection = collection;
                _index = index;
            }

            public bool IsNil => _index == -1;

            public ref readonly ElementProperty<OpenXmlSimpleType> Property => ref _collection.Raw[_index];

            public OpenXmlSimpleType Value => _collection._data[_index];

            public void SetValue(OpenXmlSimpleType value) => _collection._data[_index] = value;

            public bool HasValue => Value != null;
        }

        private static class CreatorHelper<T>
            where T : IElementMetadataProvider, new()
        {
            public static ElementMetadata Instance { get; } = InternalCreate();

            private static ElementMetadata InternalCreate()
            {
                var metadata = new T();

                var builder = new ElementMetadataBuilder();

                metadata.BuildAttributes(builder);

                return new ElementMetadata(builder.Build());
            }
        }
    }
}
