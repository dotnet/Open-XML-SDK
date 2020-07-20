// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 3.2 Class for package-level constraint "indexed element must exist".
    /// </summary>
    internal class IndexReferenceConstraint : SemanticConstraint
    {
        private readonly byte _attribute;
        private readonly string _refPartType;
        private readonly Type _refElementParent;
        private readonly Type _refElement;
        private readonly int _indexBase;

        public IndexReferenceConstraint(byte attribute, string referencedPart, Type referencedElementParent, Type referencedElement, string referencedElementName, int indexBase)
            : base(SemanticValidationLevel.Package)
        {
            _attribute = attribute;
            _refPartType = referencedPart;
            _refElement = referencedElement ?? throw new ArgumentNullException(nameof(referencedElement));
            _refElementParent = referencedElementParent;
            _indexBase = indexBase;
        }

        public override SemanticValidationLevel StateScope => SemanticValidationLevel.Part;

        public override ValidationErrorInfo ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current.Element;
            var attribute = element.ParsedState.Attributes[_attribute];

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            if (!int.TryParse(attribute.Value, out var index))
            {
                return null; //if attribute is not int, schema validation will cover this error.
            }

            var result = GetRefElementCount(context);

            if (index < result.Item + _indexBase)
            {
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_MissingIndexedElement",
                ErrorType = ValidationErrorType.Semantic,
                Node = element,
                RelatedPart = result.Part,
                RelatedNode = null,
                Description = SR.Format(
                    ValidationResources.Sem_MissingIndexedElement,
                    _refElement.FullName, element.LocalName,
                    GetAttributeQualifiedName(element, _attribute),
                    result.Part == null ? _refPartType : result.Part.PackagePart.Uri.ToString(),
                    index),
            };
        }

        private PartHolder<int> GetRefElementCount(ValidationContext context)
        {
            var part = GetReferencedPart(context, _refPartType);

            if (part?.RootElement is null)
            {
                return new PartHolder<int>(0, null);
            }

            var result = context.State.Get(new { part.Uri, _refElement, _attribute, _refElementParent }, () =>
            {
                var count = 0;

                foreach (var element in part.RootElement.Descendants(context.FileFormat, TraversalOptions.SelectAlternateContent))
                {
                    if (_refElementParent is null || element.Parent?.GetType() == _refElementParent)
                    {
                        count++;
                    }
                }

                return count;
            });

            return new PartHolder<int>(result, part);
        }
    }
}
