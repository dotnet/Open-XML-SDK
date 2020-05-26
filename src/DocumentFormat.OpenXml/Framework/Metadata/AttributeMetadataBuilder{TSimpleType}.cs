// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class AttributeMetadataBuilder<TSimpleType> : ValidatorBuilder, IMetadataBuilder<AttributeMetadata>
        where TSimpleType : OpenXmlSimpleType, new()
    {
        private static IOpenXmlSimpleTypeValidator _defaultValidator = GetDefaultValidator();

        public AttributeMetadataBuilder(byte nsId, string name, string propertyName)
        {
            Namespace = nsId;
            Name = name;
            PropertyName = propertyName;
        }

        public void AddUnion(Action<AttributeMetadataBuilder<TSimpleType>> action)
        {
            var union = new AttributeMetadataBuilder<TSimpleType>(Namespace, Name, PropertyName);

            action(union);

            AddValidator(new UnionValidator(union._validators, 0));
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

            public override OpenXmlSimpleType GetValue(OpenXmlElement element) => element.ParsedState.Attributes.GetProperty(PropertyName);

            public override void SetValue(OpenXmlElement element, OpenXmlSimpleType value) => element.ParsedState.Attributes.GetProperty(PropertyName) = value;
        }
    }
}
