// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class AttributeCannotOmitConstraint : SemanticConstraint
    {
        private readonly byte _attribute;

        public AttributeCannotOmitConstraint(byte attribute)
            : base(SemanticValidationLevel.Element)
        {
            _attribute = attribute;
        }

        public override ValidationErrorInfo ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current.Element;

            if (element.ParsedState.Attributes[_attribute].HasValue)
            {
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_MissRequiredAttribute",
                ErrorType = ValidationErrorType.Schema,
                Node = element,
                Description = SR.Format(ValidationResources.Sch_MissRequiredAttribute, GetAttributeQualifiedName(element, _attribute)),
            };
        }
    }
}
