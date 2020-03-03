// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DocumentFormat.OpenXml.Framework
{
    internal struct ElementHolder
    {
        private readonly List<AttributeInfo> _info;

        private OpenXmlSimpleType[] _values;

        public ElementHolder(List<AttributeInfo> info)
        {
            _info = info;
            _values = null;
        }

        public ref OpenXmlSimpleType GetAttributeValue(string propertyName)
        {
            for (int i = 0; i < _info.Count; i++)
            {
                var current = _info[i];

                if (current.PropertyName == propertyName)
                {
                    if (_values is null)
                    {
                        _values = new OpenXmlSimpleType[_info.Count];
                    }

                    return ref _values[i];
                }
            }

            throw new InvalidOperationException();
        }

        public ref OpenXmlSimpleType GetAttributeValue(byte nsId, string name)
        {
            for (int i = 0; i < _info.Count; i++)
            {
                var current = _info[i];

                if (current.Name == name && current.Namespace == nsId)
                {
                    if (_values is null)
                    {
                        _values = new OpenXmlSimpleType[_info.Count];
                    }

                    return ref _values[i];
                }
            }

            throw new InvalidOperationException();
        }
    }

    internal class PropertyBuilder<T>
    {
        private List<AttributeInfo> _attributes;

        public static PropertyBuilder<T> Create()
        {
            return new PropertyBuilder<T>();
        }

        public ElementHolder Build() => new ElementHolder(_attributes);

        public PropertyBuilder<T> AddAttribute<TProperty>(byte nsId, string localName, Expression<Func<T, TProperty>> expression, Action<AttributeBuilder> action)
        {
            if (_attributes is null)
            {
                _attributes = new List<AttributeInfo>();
            }

            if (expression.Body is MemberExpression member)
            {
                var builder = new AttributeBuilder(nsId, localName, member.Member.Name);

                action?.Invoke(builder);

                _attributes.Add(builder.Build());

                return this;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public struct AttributeBuilder
        {
            private List<IOpenXmlSimpleTypeValidator> _validators;
            private bool _isRequired;
            private FileFormatVersions? _initialVersion;
            private FileFormatVersions? _version;

            public AttributeBuilder(byte nsId, string name, string propertyName)
            {
                Namespace = nsId;
                Name = name;
                PropertyName = propertyName;
                _validators = null;
                _isRequired = false;
                _initialVersion = null;
                _version = null;
            }

            public AttributeBuilder AddUnion(Action<AttributeBuilder> action, FileFormatVersions version = FileFormatVersions.Office2007)
            {
                var union = new AttributeBuilder(Namespace, Name, PropertyName);

                action(union);

                return AddValidator(new UnionValidator(union._validators, 0), version);
            }

            public AttributeBuilder AddValidator<TSimpleType>(IOpenXmlSimpleTypeValidator validator, FileFormatVersions version = FileFormatVersions.Office2007)
                where TSimpleType : OpenXmlSimpleType
            {
                return AddValidator(new SimpleTypeProxyValidator<TSimpleType>(validator), version);
            }

            public AttributeBuilder SetVersion(FileFormatVersions version, bool isMinimum = true)
            {
                if (isMinimum)
                {
                    if (version != FileFormatVersions.Office2007)
                    {
                        _initialVersion = version;
                    }
                }
                else
                {
                    _version = version;
                }

                return this;
            }

            public AttributeBuilder AddValidator(IOpenXmlSimpleTypeValidator validator, FileFormatVersions version = FileFormatVersions.Office2007)
            {
                if (_validators is null)
                {
                    _validators = new List<IOpenXmlSimpleTypeValidator>();
                }

                if (version == FileFormatVersions.Office2007)
                {
                    _validators.Add(validator);
                }
                else
                {
                    // TODO: Wrap with versioned validator
                    _validators.Add(validator);
                }

                return this;
            }

            public AttributeBuilder IsRequired()
            {
                _isRequired = true;

                return this;
            }

            public byte Namespace { get; }

            public string Name { get; }

            public string PropertyName { get; }

            public AttributeInfo Build()
            {
                if (_isRequired)
                {
                    _validators.Insert(0, new RequiredValidatorAttribute());
                }

                if (_version.HasValue)
                {
                }

                return new AttributeInfo(Namespace, Name, PropertyName, _validators?.ToArray() ?? Cached.Array<IOpenXmlSimpleTypeValidator>());
            }
        }

        private class VersionedValidator : IOpenXmlSimpleTypeValidator
        {
            private readonly FileFormatVersions _version;
            private readonly IOpenXmlSimpleTypeValidator _other;

            public VersionedValidator(FileFormatVersions version, IOpenXmlSimpleTypeValidator other)
            {
                _version = version;
                _other = other;
            }

            public void Validate(ValidationContext context)
            {
                if (_version == context.FileFormat)
                {
                    _other.Validate(context);
                }
            }
        }

        private class MinimumVersionedValidator : IOpenXmlSimpleTypeValidator
        {
            private readonly FileFormatVersions _version;
            private readonly IOpenXmlSimpleTypeValidator _other;

            public MinimumVersionedValidator(FileFormatVersions version, IOpenXmlSimpleTypeValidator other)
            {
                _version = version;
                _other = other;
            }

            public void Validate(ValidationContext context)
            {
                if (context.FileFormat.AtLeast(_version))
                {
                    _other.Validate(context);
                }
            }
        }

        private class SimpleTypeProxyValidator<TSimpleType> : IOpenXmlSimpleTypeValidator
            where TSimpleType : OpenXmlSimpleType
        {
            private readonly IOpenXmlSimpleTypeValidator _other;

            public SimpleTypeProxyValidator(IOpenXmlSimpleTypeValidator other)
            {
                _other = other;
            }

            public void Validate(ValidationContext context)
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class AttributeInfo
    {
        public AttributeInfo(byte nsId, string name, string propertyName, IOpenXmlSimpleTypeValidator[] validators)
        {
            Namespace = nsId;
            Name = name;
            Validators = validators;
            PropertyName = propertyName;
        }

        public byte Namespace { get; }

        public string Name { get; }

        public string PropertyName { get; }

        public ReadOnlyArray<IOpenXmlSimpleTypeValidator> Validators { get; }
    }
}
