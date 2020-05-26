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
        private readonly string _refElementName;
        private readonly int _indexBase;

        public IndexReferenceConstraint(byte attribute, string referencedPart, Type referencedElementParent, Type referencedElement, string referencedElementName, int indexBase)
            : base(SemanticValidationLevel.Package)
        {
            _attribute = attribute;
            _refPartType = referencedPart;
            _refElement = referencedElement;
            _refElementParent = referencedElementParent;
            _refElementName = referencedElementName;
            _indexBase = indexBase;
        }

        public override SemanticValidationLevel StateScope => SemanticValidationLevel.Part;

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            var element = context.Stack.Current.Element;
            var attribute = element.Metadata[_attribute];

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
                    _refElementName, element.LocalName,
                    GetAttributeQualifiedName(element, _attribute),
                    result.Part == null ? _refPartType : result.Part.PackagePart.Uri.ToString(),
                    index),
            };
        }

        private PartHolder<int> GetRefElementCount(ValidationContext context)
        {
            var count = 0;
            var startCollect = false;

            //On element traverse start.
            void ElementTraverseStart(ValidationContext ctx)
            {
                var element = ctx.Stack.Current.Element;

                if (!startCollect)
                {
                    startCollect = element.GetType() == _refElementParent;
                }
                else
                {
                    if (element.GetType() == _refElement)
                    {
                        ++count;
                    }
                }
            }

            //On element traverse end.
            void ElementTraverseEnd(ValidationContext ctx)
            {
                if (startCollect && ctx.Stack.Current.Element.GetType() == _refElementParent)
                {
                    startCollect = false;
                }
            }

            var part = GetReferencedPart(context, _refPartType);

            var validationContext = new ValidationContext(context);

            using (validationContext.Stack.Push(context.Stack.Current.Package, part, part.RootElement))
            {
                if (_refElementParent is null)
                {
                    startCollect = true;
                    ValidationTraverser.ValidatingTraverse(validationContext, ElementTraverseStart, null);
                }
                else
                {
                    ValidationTraverser.ValidatingTraverse(validationContext, ElementTraverseStart, ElementTraverseEnd);
                }
            }

            return new PartHolder<int>(count, part);
        }
    }
}
