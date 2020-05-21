// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal interface IMetadataBuilder
    {
        void BuildAttributes(ElementBuilder builder);
    }

    internal static class AttributeCollectionBuilder
    {
        public static AttributeCollection Create<T>()
            where T : IMetadataBuilder, new()
            => CreatorHelper<T>.Instance;

        private static class CreatorHelper<T>
            where T : IMetadataBuilder, new()
        {
            public static AttributeCollection Instance { get; } = InternalCreate();

            private static AttributeCollection InternalCreate()
            {
                var metadata = new T();

                var builder = ElementBuilder.Create();

                metadata.BuildAttributes(builder);

                return new AttributeCollection(builder.Build());
            }
        }
    }

    internal readonly struct AttributeCollection
    {
        private readonly OpenXmlSimpleType[] _data;

        public static AttributeCollection Empty => new AttributeCollection(null);

        public AttributeCollection(ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> tags)
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
            private readonly AttributeCollection _collection;
            private int _index;

            public Enumerator(in AttributeCollection collection)
            {
                _collection = collection;
                _index = -1;
            }

            public PropertyEntry Current => _collection[_index];

            public bool MoveNext() => ++_index < _collection.Length;
        }

        public readonly struct PropertyEntry
        {
            private readonly AttributeCollection _collection;

            private readonly int _index;

            public PropertyEntry(in AttributeCollection collection, int index)
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
    }

    internal class ElementBuilder
    {
        private readonly List<IElementBuilder> _list = new List<IElementBuilder>();

        private ElementBuilder()
        {
        }

        public static ElementBuilder Create() => new ElementBuilder();

        public PropertyBuilder<T> Add<T>()
        {
            var builder = new PropertyBuilder<T>();
            _list.Add(builder);
            return builder;
        }

        public ElementProperty<OpenXmlSimpleType>[] Build()
        {
            var final = new List<ElementProperty<OpenXmlSimpleType>>();

            foreach (var list in _list)
            {
                final.AddRange(list.Build());
            }

            return final.ToArray();
        }
    }

    internal interface IElementBuilder
    {
        ElementProperty<OpenXmlSimpleType>[] Build();
    }

    internal interface IAttributeBuilder
    {
        ElementProperty<OpenXmlSimpleType> Build();
    }

    internal class PropertyBuilder<T> : IElementBuilder
    {
        private List<IAttributeBuilder> _attributes;

        public static PropertyBuilder<T> Create()
        {
            return new PropertyBuilder<T>();
        }

        public ElementProperty<OpenXmlSimpleType>[] Build()
        {
            if (_attributes is null)
            {
                return Array.Empty<ElementProperty<OpenXmlSimpleType>>();
            }

            var result = new ElementProperty<OpenXmlSimpleType>[_attributes.Count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = _attributes[i].Build();
            }

            return result;
        }

        public PropertyBuilder<T> AddAttribute<TProperty>(byte nsId, string localName, Expression<Func<T, TProperty>> expression, Action<AttributeBuilder<TProperty>> action = null)
            where TProperty : OpenXmlSimpleType, new()
        {
            if (_attributes is null)
            {
                _attributes = new List<IAttributeBuilder>(4);
            }

            if (expression.Body is MemberExpression member)
            {
                var builder = new AttributeBuilder<TProperty>(nsId, localName, member.Member.Name);

                action?.Invoke(builder);

                _attributes.Add(builder);

                return this;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }

    internal class AttributeBuilder<TSimpleType> : IAttributeBuilder
        where TSimpleType : OpenXmlSimpleType, new()
    {
        private static IOpenXmlSimpleTypeValidator _defaultValidator = GetDefaultValidator();

        private List<IOpenXmlSimpleTypeValidator> _validators;
        private bool _isRequired;

        public AttributeBuilder(byte nsId, string name, string propertyName)
        {
            Namespace = nsId;
            Name = name;
            PropertyName = propertyName;
            _validators = null;
            _isRequired = false;
        }

        public AttributeBuilder<TSimpleType> AddUnion(Action<AttributeBuilder<TSimpleType>> action, FileFormatVersions version = FileFormatVersions.Office2007)
        {
            var union = new AttributeBuilder<TSimpleType>(Namespace, Name, PropertyName);

            action(union);

            return AddValidator(new UnionValidator(union._validators, 0), version);
        }

        public AttributeBuilder<TSimpleType> AddValidator(IOpenXmlSimpleTypeValidator validator, FileFormatVersions version = FileFormatVersions.Office2007)
        {
            if (_validators is null)
            {
                _validators = new List<IOpenXmlSimpleTypeValidator>();
            }

            _validators.Add(validator);

            return this;
        }

        public AttributeBuilder<TSimpleType> InsertValidator(int index, IOpenXmlSimpleTypeValidator validator, FileFormatVersions version = FileFormatVersions.Office2007)
        {
            if (_validators is null)
            {
                _validators = new List<IOpenXmlSimpleTypeValidator>();
            }

            _validators.Insert(index, validator);

            return this;
        }

        public AttributeBuilder<TSimpleType> IsRequired()
        {
            _isRequired = true;

            return this;
        }

        public byte Namespace { get; }

        public string Name { get; }

        public string PropertyName { get; }

        ElementProperty<OpenXmlSimpleType> IAttributeBuilder.Build()
        {
            if (_isRequired)
            {
                InsertValidator(0, new RequiredValidatorAttribute());
            }

            AddValidator(_defaultValidator);

            return new AttributeInfo(Namespace, Name, PropertyName, _validators?.ToArray() ?? Cached.Array<IOpenXmlSimpleTypeValidator>());
        }

        private static IOpenXmlSimpleTypeValidator GetDefaultValidator()
        {
            var instance = new TSimpleType();

            if (instance is StringValue)
            {
                return StringValidatorAttribute.Instance;
            }
            else if (instance is OnOffValue || instance is TrueFalseBlankValue || instance.IsEnum)
            {
                return EnumValidatorAttribute.Instance;
            }
            else if (instance is System.Collections.IEnumerable)
            {
                return ListValidator.Instance;
            }
            else
            {
                return NumberValidatorAttribute.Instance;
            }
        }

        private class AttributeInfo : ElementProperty<OpenXmlSimpleType>
        {
            public AttributeInfo(byte ns, string name, string propertyName, IOpenXmlSimpleTypeValidator[] validators)
            {
                PropertyName = propertyName;
                NamespaceId = ns;
                Name = name;
                Validators = new ValidatorCollection(validators);
            }

            public override string PropertyName { get; }

            public override int Order => throw new NotImplementedException();

            public override string Name { get; }

            public override byte NamespaceId { get; }

            public override ValidatorCollection Validators { get; }

            public override Type Type => typeof(TSimpleType);

            public override OpenXmlSimpleType CreateNew() => new TSimpleType();

            public override OpenXmlSimpleType GetValue(OpenXmlElement element) => element.GetAttribute(Name);

            public override void SetValue(OpenXmlElement element, OpenXmlSimpleType value) => element.SetAttribute(Name, value);
        }
    }
}
