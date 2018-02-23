// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class RelationshipExistConstraint : SemanticConstraint
    {
        private byte _rIdAttribute;

        public RelationshipExistConstraint(byte rIdAttribute)
            : base(SemanticValidationLevel.Part)
        {
            _rIdAttribute = rIdAttribute;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_rIdAttribute];

            //if the attribute is omited, semantic validation will do nothing
            if (attributeValue == null || string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return null;
            }

            if (context.Part.PackagePart.RelationshipExists(attributeValue.InnerText))
            {
                return null;
            }
            else
            {
                string errorDescription = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_InvalidRelationshipId,
                                                        attributeValue, GetAttributeQualifiedName(context.Element, _rIdAttribute));

                return new ValidationErrorInfo()
                {
                    Id = "Sem_InvalidRelationshipId",
                    ErrorType = ValidationErrorType.Semantic,
                    Node = context.Element,
                    Description = errorDescription
                };
            }
        }
    }
}
