// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 2.3 Element's attribute value should be unique within specified type of element.
    /// </summary>
    internal class UniqueAttributeValueConstraint : SemanticConstraint
    {
        private readonly byte _attribute;
        private readonly Type _parent;
        private readonly StringComparer _comparer;

        public UniqueAttributeValueConstraint(byte attribute, bool caseSensitive, Type parent)
            : base(SemanticValidationLevel.Part)
        {
            _attribute = attribute;
            _parent = parent;
            _comparer = caseSensitive ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase;
        }

        public override ValidationErrorInfo ValidateCore(ValidationContext context)
        {
            if (_parent != null)
            {
                return null;
            }

            var element = context.Stack.Current.Element;
            var attribute = element.ParsedState.Attributes[_attribute];
            var elementType = element.GetType();

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            var part = element.GetPart();
            var root = GetRoot(element);

            if (root is null)
            {
                return null;
            }

            var attributeText = attribute.Value.InnerText;

            var added = false;
            var isDuplicate = context.State.Get(new { part.Uri, elementType, _parent, attributeText, _attribute, _comparer }, () =>
            {
                added = true;

                foreach (var e in root.Descendants(context.FileFormat, TraversalOptions.SelectAlternateContent))
                {
                    if (e != element & e.GetType() == elementType)
                    {
                        var eValue = e.ParsedState.Attributes[_attribute];

                        if (eValue.HasValue && _comparer.Equals(attributeText, eValue.Value.InnerText))
                        {
                            return true;
                        }
                    }
                }

                return false;
            });

            if (!isDuplicate || !added)
            {
                return null;
            }

            return new ValidationErrorInfo
            {
                Id = "Sem_UniqueAttributeValue",
                ErrorType = ValidationErrorType.Semantic,
                Node = element,
                Description = SR.Format(
                    ValidationResources.Sem_UniqueAttributeValue,
                    GetAttributeQualifiedName(element, _attribute),
                    attribute.Value.InnerText),
            };
        }

        private OpenXmlElement GetRoot(OpenXmlElement element)
        {
            if (_parent is null)
            {
                return element.GetPart()?.RootElement;
            }

            foreach (var ancestor in element.Ancestors())
            {
                if (ancestor.GetType() == _parent)
                {
                    return ancestor;
                }
            }

            return null;
        }
    }
}
