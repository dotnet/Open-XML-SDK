// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
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

        public static ElementMetadata Empty => new ElementMetadata(null);

        public bool IsEmpty => Attributes.IsEmpty;

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

        public ElementMetadata(ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> tags)
        {
            Attributes = new AttributeCollection(tags);
        }

        public AttributeCollection Attributes { get; }
    }

    internal readonly struct AttributeCollection : IEnumerable<AttributeCollection.AttributeEntry>
    {
        private readonly OpenXmlSimpleType[] _data;
        private readonly ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> _attributes;

        public AttributeCollection(ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> tags)
        {
            _attributes = tags;

            if (tags.Length == 0)
            {
                _data = Array.Empty<OpenXmlSimpleType>();
            }
            else
            {
                _data = new OpenXmlSimpleType[tags.Length];
            }
        }

        public bool IsEmpty => _data is null;

        public bool Any() => Length > 0;

        public ref OpenXmlSimpleType GetProperty(string propertyName)
        {
            for (var i = 0; i < _attributes.Length; i++)
            {
                var property = _attributes[i];

                if (property.PropertyName.Equals(propertyName, StringComparison.Ordinal))
                {
                    return ref _data[i];
                }
            }

            throw new InvalidOperationException();
        }

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

            public ref readonly ElementProperty<OpenXmlSimpleType> Property => ref _collection._attributes[_index];

            public OpenXmlSimpleType Value => _collection._data[_index];

            public void SetValue(OpenXmlSimpleType value) => _collection._data[_index] = value;

            public bool HasValue => Value != null;
        }
    }
}
