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

            var attributesSb = StringBuilderPool.Acquire();
            var existAttributeSb = StringBuilderPool.Acquire();
            string? existAttribute2 = null;

            foreach (var attribute in _attributes)
            {
                if (attributesSb.Length > 0)
                {
                    attributesSb.Append(',');
                }

                attributesSb.Append(attribute);

                if (!TryFindAttribute(element, attribute, out var found))
                {
                    continue;
                }

                if (found.Value is not null)
                {
                    if (existAttribute2 is not null)
                    {
                        if (existAttributeSb.Length > 0)
                        {
                            existAttributeSb.Append(',');
                        }

                        existAttributeSb.Append(existAttribute2);
                    }

                    existAttribute2 = found.ToString();
                }
            }

            if (existAttributeSb.Length == 0)
            {
                StringBuilderPool.Release(attributesSb);
                StringBuilderPool.Release(existAttributeSb);
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_AttributeMutualExclusive",
                ErrorType = ValidationErrorType.Semantic,
                Node = element,
                Description = SR.Format(
                    ValidationResources.Sem_AttributeMutualExclusive,
                    StringBuilderPool.GetValueAndRelease(existAttributeSb),
                    existAttribute2,
                    StringBuilderPool.GetValueAndRelease(attributesSb)),
            };
        }
    }
}
