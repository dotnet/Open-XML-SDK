// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.16 only one of a group attributes can exist
    /// </summary>
    internal class AttributeMutualExclusive : SemanticConstraint
    {
        private byte[] _attributes;

        public AttributeMutualExclusive(params byte[] attributes)
            : base(SemanticValidationLevel.Element)
        {
            _attributes = attributes;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            string attributes = string.Empty;
            string existAttribute = string.Empty;
            string existAttribute2 = string.Empty;

            foreach (byte attribute in _attributes)
            {
                attributes += "," + GetAttributeQualifiedName(context.Element, attribute);

                if (context.Element.Attributes[attribute].HasValue)
                {
                    if (!string.IsNullOrEmpty(existAttribute2))
                    {
                        existAttribute += "," + existAttribute2;
                    }

                    existAttribute2 = GetAttributeQualifiedName(context.Element, attribute).ToString();
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
                Node = context.Element,
                Description = SR.Format(
                    ValidationResources.Sem_AttributeMutualExclusive,
                    existAttribute.Substring(1),
                    existAttribute2,
                    attributes.Substring(1)),
            };
        }
    }
}
