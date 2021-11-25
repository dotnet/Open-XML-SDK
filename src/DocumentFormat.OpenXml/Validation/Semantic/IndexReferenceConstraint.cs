// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 3.2 Class for package-level constraint "indexed element must exist".
    /// </summary>
    internal class IndexReferenceConstraint : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName _attribute;
        private readonly string _refPartType;
        private readonly OpenXmlQualifiedName? _refElementParent;
        private readonly OpenXmlQualifiedName _refElement;
        private readonly int _indexBase;

        public IndexReferenceConstraint(OpenXmlQualifiedName attribute, string referencedPart, OpenXmlQualifiedName? referencedElementParent, OpenXmlQualifiedName referencedElement, string referencedElementName, int indexBase)
            : base(SemanticValidationLevel.Package)
        {
            _attribute = attribute;
            _refPartType = referencedPart;
            _refElement = referencedElement;
            _refElementParent = referencedElementParent;
            _indexBase = indexBase;
        }

        public override SemanticValidationLevel StateScope => SemanticValidationLevel.Part;

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

            // if the attribute is omitted, semantic validation will do nothing
            if (attribute.Value is null || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            if (!int.TryParse(attribute.Value, out var index))
            {
                return null; // if attribute is not int, schema validation will cover this error.
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
                    _refElement, element.LocalName,
                    _attribute,
                    result.Part is null ? _refPartType : result.Part.PackagePart.Uri.ToString(),
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

            var result = context.State.GetOrCreate(new { part, constraint = this }, static (key, context) =>
            {
                var count = 0;

                foreach (var element in key.part.RootElement.Descendants(context.FileFormat, TraversalOptions.SelectAlternateContent))
                {
                    if (!key.constraint._refElementParent.HasValue || key.constraint._refElementParent.Value.Equals(element.Parent?.QName))
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
