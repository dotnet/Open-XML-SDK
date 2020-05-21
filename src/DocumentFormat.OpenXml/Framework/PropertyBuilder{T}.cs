// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DocumentFormat.OpenXml.Framework
{
    internal struct ElementHolder
    {
        private readonly ElementProperty<OpenXmlSimpleType>[] _info;

        private OpenXmlSimpleType[] _values;

        public ElementHolder(ElementProperty<OpenXmlSimpleType>[] info)
        {
            _info = info;
            _values = null;
        }

        public ElementProperty<OpenXmlSimpleType> GetAttribute(string propertyName)
        {
            foreach (var element in _info)
            {
                if (element.PropertyName == propertyName)
                {
                    return element;
                }
            }

            throw new InvalidOperationException();
        }

        public ref OpenXmlSimpleType GetAttributeValue(string propertyName)
        {
            for (int i = 0; i < _info.Length; i++)
            {
                var current = _info[i];

                if (current.PropertyName == propertyName)
                {
                    if (_values is null)
                    {
                        _values = new OpenXmlSimpleType[_info.Length];
                    }

                    return ref _values[i];
                }
            }

            throw new InvalidOperationException();
        }

        public ref OpenXmlSimpleType GetAttributeValue(byte nsId, string name)
        {
            for (int i = 0; i < _info.Length; i++)
            {
                var current = _info[i];

                if (current.Name == name && current.NamespaceId == nsId)
                {
                    if (_values is null)
                    {
                        _values = new OpenXmlSimpleType[_info.Length];
                    }

                    return ref _values[i];
                }
            }

            throw new InvalidOperationException();
        }
    }

    internal class PropertyBuilder<T>
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

        public PropertyBuilder<T> AddAttribute<TProperty>(byte nsId, string localName, Expression<Func<T, TProperty>> expression, Action<AttributeBuilder<TProperty>> action)
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

        internal interface IAttributeBuilder
        {
            ElementProperty<OpenXmlSimpleType> Build();
        }

        public class AttributeBuilder<TSimpleType> : IAttributeBuilder
            where TSimpleType : OpenXmlSimpleType, new()
        {
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

                return new AttributeInfo(Namespace, Name, PropertyName, _validators?.ToArray() ?? Cached.Array<IOpenXmlSimpleTypeValidator>());
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
}
