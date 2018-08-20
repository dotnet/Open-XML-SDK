// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class AttributeCannotOmitConstraint : SemanticConstraint
    {
        private byte _attribute;

        public AttributeCannotOmitConstraint(byte attribute)
            : base(SemanticValidationLevel.Element)
        {
            _attribute = attribute;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            if (context.Element.Attributes[_attribute].HasValue)
            {
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_MissRequiredAttribute",
                ErrorType = ValidationErrorType.Schema,
                Node = context.Element,
                Description = SR.Format(ValidationResources.Sch_MissRequiredAttribute, GetAttributeQualifiedName(context.Element, _attribute)),
            };
        }
    }
}
