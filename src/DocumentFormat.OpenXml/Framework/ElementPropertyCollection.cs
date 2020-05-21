// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Linq;
using System.Reflection;

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly struct ElementPropertyCollection
    {
        private readonly ReadOnlyArray<ElementProperty<OpenXmlElement>> _tags;
        private readonly OpenXmlElement _element;

        public static ReadOnlyArray<ElementProperty<OpenXmlElement>> GetElements(Func<Type, Func<OpenXmlElement>> activatorFactory, Func<Type, SchemaAttrAttribute> elementSchemaFactory, Type type)
        {
            SchemaIndex GetSchema(PropertyInfo property)
            {
                var index = property.GetCustomAttribute<IndexAttribute>();
                var schema = elementSchemaFactory(property.PropertyType);

                return new SchemaIndex(schema, index);
            }

            return GetProperties(activatorFactory, type, GetSchema);
        }

        public ElementPropertyCollection(OpenXmlElement element, ReadOnlyArray<ElementProperty<OpenXmlElement>> tags)
        {
            _tags = tags;
            _element = element;
        }

        public bool IsValid => _element != null;

        public bool Any() => Length > 0;

        public PropertyEntry this[int index] => new PropertyEntry(this, index);

        public PropertyEntry this[string namespaceUri, string tagName] => this[GetIndex(namespaceUri, tagName)];

        public int Length => _tags.Length;

        public Enumerator GetEnumerator() => new Enumerator(this);

        private int GetIndex(string namespaceUri, string tagName)
        {
            if (!string.IsNullOrEmpty(tagName) && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out var nsId))
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

        public PropertyEntry[] ToArray()
        {
            var array = new PropertyEntry[Length];

            for (var i = 0; i < Length; i++)
            {
                array[i] = this[i];
            }

            return array;
        }

        private static ReadOnlyArray<ElementProperty<OpenXmlElement>> GetProperties(Func<Type, Func<OpenXmlElement>> activator, Type type, Func<PropertyInfo, SchemaIndex> getSchema)
        {
            return type.GetRuntimeProperties()
                .Where(property => typeof(OpenXmlElement).GetTypeInfo().IsAssignableFrom(property.PropertyType.GetTypeInfo()))
                .Select(property =>
                {
                    var schema = getSchema(property);

                    if (!schema.IsValid)
                    {
                        return null;
                    }

                    return ElementProperty<OpenXmlElement>.Create(
                        schema.NamespaceId,
                        schema.Tag,
                        schema.Index,
                        new ValidatorCollection(property),
                        new ElementPropertyAccessor<OpenXmlElement>(activator, property));
                })
                .Where(tag => tag != null)
                .OrderBy(tag => tag.Order)
                .ToArray();
        }

        public struct Enumerator
        {
            private readonly ElementPropertyCollection _collection;
            private int _index;

            public Enumerator(in ElementPropertyCollection collection)
            {
                _collection = collection;
                _index = -1;
            }

            public PropertyEntry Current => _collection[_index];

            public bool MoveNext() => ++_index < _collection.Length;
        }

        public readonly struct PropertyEntry
        {
            private readonly ElementPropertyCollection _collection;

            private readonly int _index;

            public PropertyEntry(in ElementPropertyCollection collection, int index)
            {
                _collection = collection;
                _index = index;
            }

            public bool IsNil => _index == -1;

            public ref readonly ElementProperty<OpenXmlElement> Property => ref _collection._tags[_index];

            public OpenXmlElement Value => _collection._tags[_index].GetValue(_collection._element);

            public void SetValue(OpenXmlElement value) => _collection._tags[_index].SetValue(_collection._element, value);

            public bool HasValue => Value != null;
        }
    }
}
