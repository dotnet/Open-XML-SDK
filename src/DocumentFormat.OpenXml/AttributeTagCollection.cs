// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    internal readonly struct AttributeTagCollection : IEnumerable<OpenXmlAttribute>
    {
        private readonly ReadOnlyArray<AttributeTag> _tags;
        private readonly OpenXmlElement _element;

        public AttributeTagCollection(OpenXmlElement element, ReadOnlyArray<AttributeTag> tags)
        {
            _tags = tags;
            _element = element;
        }

        public bool IsValid => _element != null;

        public bool Any() => Length > 0;

        public AttributeEntry this[int index] => new AttributeEntry(this, index);

        public AttributeEntry this[string namespaceUri, string tagName] => this[GetIndex(namespaceUri, tagName)];

        public int Length => _tags.Length;

        public Enumerator GetEnumerator() => new Enumerator(this);

        private int GetIndex(string namespaceUri, string tagName)
        {
            if (!string.IsNullOrEmpty(tagName) && namespaceUri != null && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out var nsId))
            {
                for (var i = 0; i < _tags.Length; i++)
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

        public AttributeEntry[] ToArray()
        {
            var array = new AttributeEntry[Length];

            for (var i = 0; i < Length; i++)
            {
                array[i] = this[i];
            }

            return array;
        }

        IEnumerator<OpenXmlAttribute> IEnumerable<OpenXmlAttribute>.GetEnumerator() => ToAttributes().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ToAttributes().GetEnumerator();

        private IEnumerable<OpenXmlAttribute> ToAttributes()
        {
            foreach (var attribute in this)
            {
                yield return new OpenXmlAttribute(attribute.Tag.Name, attribute.Tag.Namespace, null);
            }
        }

        public static ReadOnlyArray<AttributeTag> GetAttributes(PackageCache cache, Type type)
        {
            return type.GetRuntimeProperties()
               .Select(property =>
               {
                   var schema = property.GetCustomAttribute<SchemaAttrAttribute>();

                   if (schema is null)
                   {
                       return default;
                   }

                   return new AttributeTag(
                       schema.NamespaceId,
                       schema.Tag,
                       schema.Index,
                       new OpenXmlElementPropertyAccessor(cache, property));
               })
               .Where(tag => tag.IsValid)
               .OrderBy(tag => tag.Order)
               .ToArray();
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

            public OpenXmlSimpleType Value => _collection._tags[_index].GetValue(_collection._element);

            public void SetValue(OpenXmlSimpleType value) => _collection._tags[_index].SetValue(_collection._element, value);

            public bool HasValue => Value != null;
        }
    }
}
