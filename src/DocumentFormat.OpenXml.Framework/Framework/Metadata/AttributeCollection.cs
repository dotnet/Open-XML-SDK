// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal readonly struct AttributeCollection : IEnumerable<AttributeCollection.AttributeEntry>
    {
        // Each slot holds either the text an attribute was loaded with, or an OpenXmlSimpleType for it. Creating the
        // type is deferred until something asks for the typed value, as most attributes are only ever read as text.
        private readonly object?[] _data;
        private readonly ReadOnlyArray<AttributeMetadata> _attributes;

        public AttributeCollection(ReadOnlyArray<AttributeMetadata> tags, object?[] data)
        {
            _attributes = tags;
            _data = data;
        }

        /// <summary>
        /// Creates the storage for the values of the given attributes, to be viewed with an <see cref="AttributeCollection"/>.
        /// </summary>
        public static object?[] CreateData(ReadOnlyArray<AttributeMetadata> tags)
            => tags.Length == 0 ? Cached.Array<object>() : new object[tags.Length];

        public bool Any() => Length > 0;

        public AttributeEntry GetProperty(string propertyName) => this[GetIndex(propertyName)];

        public AttributeEntry this[int index] => new AttributeEntry(this, index);

        public AttributeEntry this[in OpenXmlQualifiedName qname] => this[GetIndex(qname)];

        public int Length => _attributes.Length;

        private int GetIndex(in OpenXmlQualifiedName qname)
        {
            for (var i = 0; i < _attributes.Length; i++)
            {
                var tag = _attributes[i];

                if (qname.Equals(tag.QName))
                {
                    return i;
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

            public bool IsNil => _index == -1 || _collection._attributes.IsNull || _collection._data is null;

            public ref readonly AttributeMetadata Property => ref _collection._attributes[_index];

            /// <summary>
            /// Gets a value indicating whether the attribute is set, without creating its <see cref="OpenXmlSimpleType"/>.
            /// </summary>
            public bool HasValue => !IsNil && _collection._data[_index] is not null;

            /// <summary>
            /// Gets or sets the value, creating it from the loaded text if that has not happened yet. The created value is stored
            /// so that callers always get the same instance, which they may modify in place.
            /// </summary>
            public OpenXmlSimpleType? Value
            {
                get
                {
                    while (true)
                    {
                        var current = _collection._data[_index];

                        if (current is not string text)
                        {
                            return (OpenXmlSimpleType?)current;
                        }

                        var created = Property.CreateNew();
                        created.InnerText = text;

                        // The slot may change while the value is created; every caller must end up with the stored instance
                        if (ReferenceEquals(Interlocked.CompareExchange(ref _collection._data[_index], created, current), current))
                        {
                            return created;
                        }
                    }
                }

                set => _collection._data[_index] = value;
            }

            /// <summary>
            /// Gets or sets the text of the attribute without creating its <see cref="OpenXmlSimpleType"/>. Setting it
            /// updates the value in place if one has already been created.
            /// </summary>
            public string? InnerText
            {
                get => _collection._data[_index] switch
                {
                    string text => text,
                    OpenXmlSimpleType value => value.InnerText,
                    _ => null,
                };

                set
                {
                    if (_collection._data[_index] is OpenXmlSimpleType existing)
                    {
                        existing.InnerText = value;
                    }
                    else if (value is not null)
                    {
                        _collection._data[_index] = value;
                    }
                    else
                    {
                        // An attribute that is present without text still needs a value to be written back out
                        _collection._data[_index] = Property.CreateNew();
                    }
                }
            }

            /// <summary>
            /// Gets the stored text or value, whichever the attribute currently holds.
            /// </summary>
            public object? RawValue => _collection._data[_index];
        }
    }
}
