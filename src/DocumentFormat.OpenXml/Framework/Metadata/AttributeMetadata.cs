// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal abstract class AttributeMetadata
    {
        public XmlQualifiedName TypeName => Validators.GetSimpleTypeQualifiedName(Type);

        public abstract string PropertyName { get; }

        public abstract string Name { get; }

        public abstract byte NamespaceId { get; }

        public abstract ReadOnlyArray<IValidator> Validators { get; }

        public string Namespace => NamespaceIdMap.GetNamespaceUri(NamespaceId);

        public string NamespacePrefix => NamespaceIdMap.GetNamespacePrefix(NamespaceId);

        public abstract OpenXmlSimpleType CreateNew();

        public abstract Type Type { get; }

        public XmlQualifiedName GetQName() => new XmlQualifiedName(Name, Namespace);

        public class Builder<TSimpleType> : ValidatorBuilder, IMetadataBuilder<AttributeMetadata>
            where TSimpleType : OpenXmlSimpleType, new()
        {
            private static IValidator _defaultValidator = GetDefaultValidator();

            public Builder(byte nsId, string name, string propertyName)
            {
                Namespace = nsId;
                Name = name;
                PropertyName = propertyName;
            }

            public void AddUnion(Action<Builder<TSimpleType>> action)
            {
                var union = new Builder<TSimpleType>(Namespace, Name, PropertyName);

                action(union);

                AddValidator(new UnionValidator(union.GetValidators(), 0));
            }

            public byte Namespace { get; }

            public string Name { get; }

            public string PropertyName { get; }

            AttributeMetadata IMetadataBuilder<AttributeMetadata>.Build()
            {
                AddValidator(_defaultValidator);

                return new AttributeInfo(Namespace, Name, PropertyName, GetValidators());
            }

            private static IValidator GetDefaultValidator()
            {
                var instance = new TSimpleType();

                if (instance is StringValue)
                {
                    return StringValidator.Instance;
                }
                else if (instance.IsEnum || instance is OnOffValue || instance is TrueFalseBlankValue)
                {
                    return EnumValidator.Instance;
                }
                else if (instance is System.Collections.IEnumerable)
                {
                    return ListValidator.Instance;
                }
                else
                {
                    return NumberValidator.Instance;
                }
            }

            [DebuggerDisplay("{PropertyName,nq}")]
            private class AttributeInfo : AttributeMetadata
            {
                public AttributeInfo(byte ns, string name, string propertyName, IValidator[] validators)
                {
                    PropertyName = propertyName;
                    NamespaceId = ns;
                    Name = name;
                    Validators = validators;
                }

                public override string PropertyName { get; }

                public override string Name { get; }

                public override byte NamespaceId { get; }

                public override ReadOnlyArray<IValidator> Validators { get; }

                public override Type Type => typeof(TSimpleType);

                public override OpenXmlSimpleType CreateNew() => new TSimpleType();
            }
        }
    }
}
