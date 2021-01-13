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

        public abstract OpenXmlQualifiedName QName { get; }

        public abstract ReadOnlyArray<IValidator> Validators { get; }

        public abstract OpenXmlSimpleType CreateNew();

        public abstract Type Type { get; }

        public class Builder<TSimpleType> : ValidatorBuilder, IMetadataBuilder<AttributeMetadata>
            where TSimpleType : OpenXmlSimpleType, new()
        {
            private static readonly IValidator _defaultValidator = GetDefaultValidator();

            public Builder(in OpenXmlQualifiedName qname, string propertyName)
            {
                QName = qname;
                PropertyName = propertyName;
            }

            public void AddUnion(Action<Builder<TSimpleType>> action)
            {
                var union = new Builder<TSimpleType>(QName, PropertyName);

                action(union);

                AddValidator(new UnionValidator(union.GetValidators(), 0));
            }

            public OpenXmlQualifiedName QName { get; }

            public string PropertyName { get; }

            AttributeMetadata IMetadataBuilder<AttributeMetadata>.Build()
            {
                AddValidator(_defaultValidator);

                return new AttributeInfo(QName, PropertyName, GetValidators());
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
                public AttributeInfo(in OpenXmlQualifiedName qname, string propertyName, IValidator[] validators)
                {
                    PropertyName = propertyName;
                    QName = qname;
                    Validators = validators;
                }

                public override string PropertyName { get; }

                public override OpenXmlQualifiedName QName { get; }

                public override ReadOnlyArray<IValidator> Validators { get; }

                public override Type Type => typeof(TSimpleType);

                public override OpenXmlSimpleType CreateNew() => new TSimpleType();
            }
        }
    }
}
