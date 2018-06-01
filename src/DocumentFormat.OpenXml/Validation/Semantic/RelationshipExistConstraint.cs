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
            var attribute = context.Element.Attributes[_rIdAttribute];

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            if (context.Part.PackagePart.RelationshipExists(attribute.Value.InnerText))
            {
                return null;
            }
            else
            {
                return new ValidationErrorInfo()
                {
                    Id = "Sem_InvalidRelationshipId",
                    ErrorType = ValidationErrorType.Semantic,
                    Node = context.Element,
                    Description = SR.Format(
                        ValidationResources.Sem_InvalidRelationshipId,
                        attribute.Value,
                        GetAttributeQualifiedName(context.Element, _rIdAttribute)),
                };
            }
        }
    }
}
