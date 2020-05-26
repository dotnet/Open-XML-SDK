// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal readonly struct ElementMetadata
    {
        private static readonly ConcurrentDictionary<Type, ReadOnlyArray<ElementProperty<OpenXmlSimpleType>>> _lookup = new ConcurrentDictionary<Type, ReadOnlyArray<ElementProperty<OpenXmlSimpleType>>>(new[]
        {
            new KeyValuePair<Type, ReadOnlyArray<ElementProperty<OpenXmlSimpleType>>>(typeof(OpenXmlUnknownElement), null),
            new KeyValuePair<Type, ReadOnlyArray<ElementProperty<OpenXmlSimpleType>>>(typeof(OpenXmlMiscNode), null),
        });

        private readonly OpenXmlSimpleType[] _data;

        public static ElementMetadata Empty => new ElementMetadata(null);

        public bool IsEmpty => _data is null;

        public static ElementMetadata Create(Type type)
        {
            var data = _lookup.GetOrAdd(type, t =>
            {
                var helper = typeof(CreatorHelper<>).MakeGenericType(t);
                var builder = (IElementMetadataBuilder)Activator.CreateInstance(helper);

                return builder.Create();
            });

            return new ElementMetadata(data);
        }

        public static ElementMetadata Create<TElement>()
            where TElement : OpenXmlElement, new()
        {
            var data = _lookup.GetOrAdd(typeof(TElement), t =>
            {
                var builder = new CreatorHelper<TElement>();

                return builder.Create();
            });

            return new ElementMetadata(data);
        }

        public ElementMetadata(ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> tags)
        {
            Attributes = tags;

            if (tags.Length == 0)
            {
                _data = Array.Empty<OpenXmlSimpleType>();
            }
            else
            {
                _data = new OpenXmlSimpleType[tags.Length];
            }
        }

        public ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> Attributes { get; }

        public bool Any() => Length > 0;

        public ref OpenXmlSimpleType GetProperty(string propertyName)
        {
            for (var i = 0; i < Attributes.Length; i++)
            {
                var property = Attributes[i];

                if (property.PropertyName.Equals(propertyName, StringComparison.Ordinal))
                {
                    return ref _data[i];
                }
            }

            throw new InvalidOperationException();
        }

        public PropertyEntry this[int index] => new PropertyEntry(this, index);

        public PropertyEntry this[string namespaceUri, string tagName] => this[GetIndex(namespaceUri, tagName)];

        public int Length => Attributes.Length;

        public Enumerator GetEnumerator() => new Enumerator(this);

        private int GetIndex(string namespaceUri, string tagName)
        {
            if (!string.IsNullOrEmpty(tagName) && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out var nsId))
            {
                for (var i = 0; i < Attributes.Length; i++)
                {
                    var tag = Attributes[i];

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

            public ref readonly ElementProperty<OpenXmlSimpleType> Property => ref _collection.Attributes[_index];

            public OpenXmlSimpleType Value => _collection._data[_index];

            public void SetValue(OpenXmlSimpleType value) => _collection._data[_index] = value;

            public bool HasValue => Value != null;
        }

        private class CreatorHelper<T> : IElementMetadataBuilder
            where T : OpenXmlElement, new()
        {
            public ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> Create()
            {
                var element = new T();

                var builder = new ElementMetadataBuilder();

                element.ConfigureMetadata(builder);

                return builder.Build();
            }
        }

        private interface IElementMetadataBuilder
        {
            ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> Create();
        }
    }
}
