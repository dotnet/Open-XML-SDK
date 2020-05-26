// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class AttributeMetadataBuilder<TSimpleType> : IMetadataBuilder<AttributeMetadata>
        where TSimpleType : OpenXmlSimpleType, new()
    {
        private static IOpenXmlSimpleTypeValidator _defaultValidator = GetDefaultValidator();

        private readonly List<IOpenXmlSimpleTypeValidator> _validators;

        public AttributeMetadataBuilder(byte nsId, string name, string propertyName)
        {
            Namespace = nsId;
            Name = name;
            PropertyName = propertyName;
            _validators = new List<IOpenXmlSimpleTypeValidator>();
        }

        public AttributeMetadataBuilder<TSimpleType> AddUnion(Action<AttributeMetadataBuilder<TSimpleType>> action, FileFormatVersions version = FileFormatVersions.Office2007)
        {
            var union = new AttributeMetadataBuilder<TSimpleType>(Namespace, Name, PropertyName);

            action(union);

            return AddValidator(new UnionValidator(union._validators, 0), version);
        }

        public AttributeMetadataBuilder<TSimpleType> AddValidator(IOpenXmlSimpleTypeValidator validator, FileFormatVersions version = FileFormatVersions.Office2007)
        {
            if (validator is RequiredValidatorAttribute)
            {
                _validators.Insert(0, validator);
            }
            else
            {
                _validators.Add(validator);
            }

            return this;
        }

        public AttributeMetadataBuilder<TSimpleType> InsertValidator(int index, IOpenXmlSimpleTypeValidator validator, FileFormatVersions version = FileFormatVersions.Office2007)
        {
            _validators.Insert(index, validator);

            return this;
        }

        public byte Namespace { get; }

        public string Name { get; }

        public string PropertyName { get; }

        AttributeMetadata IMetadataBuilder<AttributeMetadata>.Build()
        {
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
            else if (instance.IsEnum || instance is OnOffValue || instance is TrueFalseBlankValue)
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

        [DebuggerDisplay("{PropertyName,nq}")]
        private class AttributeInfo : AttributeMetadata
        {
            public AttributeInfo(byte ns, string name, string propertyName, IOpenXmlSimpleTypeValidator[] validators)
            {
                PropertyName = propertyName;
                NamespaceId = ns;
                Name = name;
                Validators = new ValidatorCollection(validators);
            }

            public override string PropertyName { get; }

            public override string Name { get; }

            public override byte NamespaceId { get; }

            public override ValidatorCollection Validators { get; }

            public override Type Type => typeof(TSimpleType);

            public override OpenXmlSimpleType CreateNew() => new TSimpleType();

            public override OpenXmlSimpleType GetValue(OpenXmlElement element) => element.EState.Attributes.GetProperty(PropertyName);

            public override void SetValue(OpenXmlElement element, OpenXmlSimpleType value) => element.EState.Attributes.GetProperty(PropertyName) = value;
        }
    }
}
