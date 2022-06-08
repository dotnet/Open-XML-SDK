// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Framework;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class RelationshipExistConstraint : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName _attribute;

        public RelationshipExistConstraint(OpenXmlQualifiedName attribute)
            : base(SemanticValidationLevel.Part)
        {
            _attribute = attribute;
        }

        public override ValidationErrorInfo? ValidateCore(ValidationContext context)
        {
            var current = context.Stack.Current;

            if (current is null)
            {
                return null;
            }

            var element = current.Element;

            if (element is null)
            {
                return null;
            }

            if (!TryFindAttribute(element, _attribute, out var attribute))
            {
                return null;
            }

            // if the attribute is omitted, semantic validation will do nothing
            if (attribute.Value is null || attribute.Value.InnerText.IsNullOrEmpty())
            {
                return null;
            }

            if (current.Part is null)
            {
                return null;
            }

            if (current.Part.PackagePart.RelationshipExists(attribute.Value.InnerText))
            {
                return null;
            }
            else
            {
                return new ValidationErrorInfo
                {
                    Id = "Sem_InvalidRelationshipId",
                    ErrorType = ValidationErrorType.Semantic,
                    Node = element,
                    Description = SR.Format(
                        ValidationResources.Sem_InvalidRelationshipId,
                        attribute.Value,
                        attribute.Property.QName),
                };
            }
        }
    }
}
