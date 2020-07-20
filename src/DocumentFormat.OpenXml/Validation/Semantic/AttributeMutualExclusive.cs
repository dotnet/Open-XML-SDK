// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.16 only one of a group attributes can exist
    /// </summary>
    internal class AttributeMutualExclusive : SemanticConstraint
    {
        private readonly byte[] _attributes;

        public AttributeMutualExclusive(params byte[] attributes)
            : base(SemanticValidationLevel.Element)
        {
            _attributes = attributes;
        }

        public override ValidationErrorInfo ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current.Element;
            var attributes = string.Empty;
            var existAttribute = string.Empty;
            var existAttribute2 = string.Empty;

            foreach (byte attribute in _attributes)
            {
                attributes += "," + GetAttributeQualifiedName(element, attribute);

                if (element.ParsedState.Attributes[attribute].HasValue)
                {
                    if (!string.IsNullOrEmpty(existAttribute2))
                    {
                        existAttribute += "," + existAttribute2;
                    }

                    existAttribute2 = GetAttributeQualifiedName(element, attribute).ToString();
                }
            }

            if (string.IsNullOrEmpty(existAttribute))
            {
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_AttributeMutualExclusive",
                ErrorType = ValidationErrorType.Semantic,
                Node = element,
                Description = SR.Format(
                    ValidationResources.Sem_AttributeMutualExclusive,
                    existAttribute.Substring(1),
                    existAttribute2,
                    attributes.Substring(1)),
            };
        }
    }
}
