// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 3.1 Class for package-level constraint "referenced element must exist".
    /// </summary>
    internal class ReferenceExistConstraint : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName _refAttribute;
        private readonly string _partPath;
        private readonly OpenXmlQualifiedName _element;
        private readonly string _elementName;
        private readonly OpenXmlQualifiedName _attribute;

        public ReferenceExistConstraint(OpenXmlQualifiedName refAttribute, string part, OpenXmlQualifiedName element, string elementName, OpenXmlQualifiedName attribute)
            : base(SemanticValidationLevel.Package)
        {
            Debug.Assert(!string.IsNullOrEmpty(part));

            _refAttribute = refAttribute;
            _partPath = part;
            _element = element;
            _elementName = elementName;
            _attribute = attribute;
        }

        public override SemanticValidationLevel StateScope => SemanticValidationLevel.Part;

        public override ValidationErrorInfo? ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current?.Element;

            if (element is null)
            {
                return null;
            }

            if (!TryFindAttribute(element, _refAttribute, out var attribute))
            {
                return null;
            }

            if (attribute.Value is null || attribute.Value.InnerText.IsNullOrEmpty())
            {
                return null;
            }

            var result = GetReferencedAttributes(context);

            if (result.Item.Contains(attribute.Value.InnerText))
            {
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_MissingReferenceElement",
                ErrorType = ValidationErrorType.Semantic,
                Node = element,
                RelatedPart = result.Part,
                RelatedNode = null,
                Description = SR.Format(
                    ValidationResources.Sem_MissingReferenceElement,
                    _elementName,
                    element.LocalName,
                    attribute.Property.QName,
                    result.Part is null ? _partPath : result.Part.PackagePart.Uri.ToString(),
                    attribute.Value.InnerText),
            };
        }

        private PartHolder<ICollection<string>> GetReferencedAttributes(ValidationContext context)
        {
            var part = GetReferencedPart(context, _partPath);

            if (part?.RootElement is null)
            {
                return new PartHolder<ICollection<string>>(Cached.Array<string>(), part);
            }

            var result = context.State.GetOrCreate(new { part, constraint = this }, static (key, context) =>
            {
                var referencedAttributes = new HashSet<string>(StringComparer.Ordinal);

                foreach (var element in key.part.RootElement.Descendants(context.FileFormat, TraversalOptions.SelectAlternateContent))
                {
                    if (element.QName.Equals(key.constraint._element))
                    {
                        // Attributes whose value is empty string or null don't need to be cached.
                        if (TryFindAttribute(element, key.constraint._attribute, out var attribute) && attribute.Value is not null && !attribute.Value.InnerText.IsNullOrEmpty())
                        {
                            referencedAttributes.Add(attribute.Value.InnerText);
                        }
                    }
                }

                return referencedAttributes;
            });

            return new PartHolder<ICollection<string>>(result, part);
        }
    }
}
