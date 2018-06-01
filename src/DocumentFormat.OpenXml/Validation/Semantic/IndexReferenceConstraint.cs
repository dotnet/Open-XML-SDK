// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 3.2 Class for package-level constraint "indexed element must exist".
    /// </summary>
    internal class IndexReferenceConstraint : SemanticConstraint
    {
        private byte _attribute;
        private string _refPartType;
        private int _refElementParent;
        private int _refElement;
        private string _refElementName;
        private int _indexBase;
        private int _refElementCount = -1;
        private OpenXmlPart _relatedPart;
        private bool _startCollect;

        public IndexReferenceConstraint(byte attribute, string referencedPart, int referencedElementParent,
                                                    int referencedElement, string referencedElementName, int indexBase)
            : base(SemanticValidationLevel.Package)
        {
            _attribute = attribute;
            _refPartType = referencedPart;
            _refElement = referencedElement;
            _refElementParent = referencedElementParent;
            _refElementName = referencedElementName;
            _indexBase = indexBase;
        }

        public override SemanticValidationLevel StateScope
        {
            get
            {
                return SemanticValidationLevel.Part;
            }
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            var attribute = context.Element.Attributes[_attribute];

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            if (!int.TryParse(attribute.Value, out var index))
            {
                return null; //if attribute is not int, schema validation will cover this error.
            }

            if (index < GetRefElementCount(context) + _indexBase)
            {
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_MissingIndexedElement",
                ErrorType = ValidationErrorType.Semantic,
                Node = context.Element,
                RelatedPart = _relatedPart,
                RelatedNode = null,
                Description = SR.Format(
                    ValidationResources.Sem_MissingIndexedElement,
                    _refElementName, context.Element.LocalName,
                    GetAttributeQualifiedName(context.Element, _attribute),
                    _relatedPart == null ? _refPartType : _relatedPart.PackagePart.Uri.ToString(),
                    index),
            };
        }

        public override void ClearState(ValidationContext context)
        {
            _refElementCount = -1;
            _startCollect = false;
        }

        private int GetRefElementCount(ValidationContext context)
        {
            if (_refElementCount != -1)
            {
                return _refElementCount;
            }

            _refElementCount = 0;

            OpenXmlPart part = GetReferencedPart(context, _refPartType);

            if (part != null)
            {
                _relatedPart = part;

                var validationContext = new ValidationContext
                {
                    FileFormat = context.FileFormat,
                    Package = context.Package,
                    Part = part,
                    Element = part.RootElement,
                };

                if (_refElementParent == -1)
                {
                    _startCollect = true;
                    ValidationTraverser.ValidatingTraverse(validationContext, ElementTraverseStart, null);
                }
                else
                {
                    ValidationTraverser.ValidatingTraverse(validationContext, ElementTraverseStart, ElementTraverseEnd);
                }
            }

            return _refElementCount;
        }

        //On element traverse start.
        private void ElementTraverseStart(ValidationContext context)
        {
            if (!_startCollect)
            {
                _startCollect = context.Element.ElementTypeId == _refElementParent;
            }
            else
            {
                if (context.Element.ElementTypeId == _refElement)
                {
                    ++_refElementCount;
                }
            }
        }

        //On element traverse end.
        private void ElementTraverseEnd(ValidationContext context)
        {
            if (_startCollect && context.Element.ElementTypeId == _refElementParent)
            {
                _startCollect = false;
            }
        }
    }
}
