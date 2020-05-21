// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class AttributeMetadataBuilder<TSimpleType> : IAttributeMetadataBuilder
        where TSimpleType : OpenXmlSimpleType, new()
    {
        private static IOpenXmlSimpleTypeValidator _defaultValidator = GetDefaultValidator();

        private List<IOpenXmlSimpleTypeValidator> _validators;
        private bool _isRequired;

        public AttributeMetadataBuilder(byte nsId, string name, string propertyName)
        {
            Namespace = nsId;
            Name = name;
            PropertyName = propertyName;
            _validators = null;
            _isRequired = false;
        }

        public AttributeMetadataBuilder<TSimpleType> AddUnion(Action<AttributeMetadataBuilder<TSimpleType>> action, FileFormatVersions version = FileFormatVersions.Office2007)
        {
            var union = new AttributeMetadataBuilder<TSimpleType>(Namespace, Name, PropertyName);

            action(union);

            return AddValidator(new UnionValidator(union._validators, 0), version);
        }

        public AttributeMetadataBuilder<TSimpleType> AddValidator(IOpenXmlSimpleTypeValidator validator, FileFormatVersions version = FileFormatVersions.Office2007)
        {
            if (_validators is null)
            {
                _validators = new List<IOpenXmlSimpleTypeValidator>();
            }

            _validators.Add(validator);

            return this;
        }

        public AttributeMetadataBuilder<TSimpleType> InsertValidator(int index, IOpenXmlSimpleTypeValidator validator, FileFormatVersions version = FileFormatVersions.Office2007)
        {
            if (_validators is null)
            {
                _validators = new List<IOpenXmlSimpleTypeValidator>();
            }

            _validators.Insert(index, validator);

            return this;
        }

        public AttributeMetadataBuilder<TSimpleType> IsRequired()
        {
            _isRequired = true;

            return this;
        }

        public byte Namespace { get; }

        public string Name { get; }

        public string PropertyName { get; }

        ElementProperty<OpenXmlSimpleType> IAttributeMetadataBuilder.Build()
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

            public override OpenXmlSimpleType GetValue(OpenXmlElement element) => element.Attributes.GetProperty(PropertyName);

            public override void SetValue(OpenXmlElement element, OpenXmlSimpleType value) => element.Attributes.GetProperty(PropertyName) = value;
        }
    }
}
