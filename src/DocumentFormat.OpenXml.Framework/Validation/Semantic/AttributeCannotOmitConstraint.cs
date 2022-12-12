// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class AttributeCannotOmitConstraint : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName _attribute;

        public AttributeCannotOmitConstraint(OpenXmlQualifiedName attribute)
            : base(SemanticValidationLevel.Element)
        {
            _attribute = attribute;
        }

        public override ValidationErrorInfo? ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current?.Element;

            if (element is null)
            {
                return null;
            }

            if (!TryFindAttribute(element, _attribute, out var attribute))
            {
                return null;
            }

            if (attribute.Value is not null)
            {
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_MissRequiredAttribute",
                ErrorType = ValidationErrorType.Schema,
                Node = element,
                Description = SR.Format(ValidationResources.Sch_MissRequiredAttribute, attribute.Property.QName),
            };
        }
    }
}
