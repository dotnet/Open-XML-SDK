// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.16 only one of a group attributes can exist
    /// </summary>
    internal class AttributeMutualExclusive : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName[] _attributes;

        public AttributeMutualExclusive(OpenXmlQualifiedName attribute)
            : this(new[] { attribute })
        {
        }

        public AttributeMutualExclusive(OpenXmlQualifiedName attribute1, OpenXmlQualifiedName attribute2)
            : this(new[] { attribute1, attribute2 })
        {
        }

        public AttributeMutualExclusive(OpenXmlQualifiedName attribute1, OpenXmlQualifiedName attribute2, OpenXmlQualifiedName attribute3)
            : this(new[] { attribute1, attribute2, attribute3 })
        {
        }

        public AttributeMutualExclusive(OpenXmlQualifiedName attribute1, OpenXmlQualifiedName attribute2, OpenXmlQualifiedName attribute3, OpenXmlQualifiedName attribute4)
            : this(new[] { attribute1, attribute2, attribute3, attribute4 })
        {
        }

        public AttributeMutualExclusive(OpenXmlQualifiedName attribute1, OpenXmlQualifiedName attribute2, OpenXmlQualifiedName attribute3, OpenXmlQualifiedName attribute4, OpenXmlQualifiedName attribute5)
            : this(new[] { attribute1, attribute2, attribute3, attribute4, attribute5 })
        {
        }

        public AttributeMutualExclusive(OpenXmlQualifiedName attribute1, OpenXmlQualifiedName attribute2, OpenXmlQualifiedName attribute3, OpenXmlQualifiedName attribute4, OpenXmlQualifiedName attribute5, OpenXmlQualifiedName attribute6)
            : this(new[] { attribute1, attribute2, attribute3, attribute4, attribute5, attribute6 })
        {
        }

        private AttributeMutualExclusive(OpenXmlQualifiedName[] attributes)
            : base(SemanticValidationLevel.Element)
        {
            _attributes = attributes;
        }

        public override ValidationErrorInfo? ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current?.Element;

            if (element is null)
            {
                return null;
            }

            var attributes = string.Empty;
            var existAttribute = string.Empty;
            var existAttribute2 = string.Empty;

            foreach (var attribute in _attributes)
            {
                attributes += "," + attribute;

                if (!TryFindAttribute(element, attribute, out var found))
                {
                    continue;
                }

                if (found.Value is not null)
                {
                    if (!string.IsNullOrEmpty(existAttribute2))
                    {
                        existAttribute += "," + existAttribute2;
                    }

                    existAttribute2 = found.ToString();
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
