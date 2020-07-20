// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class RelationshipExistConstraint : SemanticConstraint
    {
        private readonly byte _rIdAttribute;

        public RelationshipExistConstraint(byte rIdAttribute)
            : base(SemanticValidationLevel.Part)
        {
            _rIdAttribute = rIdAttribute;
        }

        public override ValidationErrorInfo ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current.Element;
            var attribute = element.ParsedState.Attributes[_rIdAttribute];

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            if (context.Stack.Current.Part.PackagePart.RelationshipExists(attribute.Value.InnerText))
            {
                return null;
            }
            else
            {
                return new ValidationErrorInfo()
                {
                    Id = "Sem_InvalidRelationshipId",
                    ErrorType = ValidationErrorType.Semantic,
                    Node = element,
                    Description = SR.Format(
                        ValidationResources.Sem_InvalidRelationshipId,
                        attribute.Value,
                        GetAttributeQualifiedName(element, _rIdAttribute)),
                };
            }
        }
    }
}
