// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 3.1 Class for package-level constraint "referenced element must exist".
    /// </summary>
    internal class ReferenceExistConstraint : SemanticConstraint
    {
        private byte _refAttribute;
        private string _partPath;
        private int _element;
        private string _elementName;
        private byte _attribute;
        private List<string> _referencedAttributes;
        private OpenXmlPart _relatedPart;

        public ReferenceExistConstraint(byte refAttribute, string part, int element, string elementName, byte attribute)
            : base(SemanticValidationLevel.Package)
        {
            Debug.Assert(!string.IsNullOrEmpty(part));
            Debug.Assert(element > 0);

            _refAttribute = refAttribute;
            _partPath = part;
            _element = element;
            _elementName = elementName;
            _attribute = attribute;
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
            var attribute = context.Element.Attributes[_refAttribute];

            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            if (GetReferencedAttributes(context).Contains(attribute.Value.InnerText))
            {
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_MissingReferenceElement",
                ErrorType = ValidationErrorType.Semantic,
                Node = context.Element,
                RelatedPart = _relatedPart,
                RelatedNode = null,
                Description = SR.Format(
                    ValidationResources.Sem_MissingReferenceElement,
                    _elementName,
                    context.Element.LocalName,
                    GetAttributeQualifiedName(context.Element, _refAttribute),
                    _relatedPart == null ? _partPath : _relatedPart.PackagePart.Uri.ToString(),
                    attribute.Value.InnerText),
            };
        }

        public override void ClearState(ValidationContext context)
        {
            _referencedAttributes = null;
        }

        private List<string> GetReferencedAttributes(ValidationContext context)
        {
            if (_referencedAttributes == null)
            {
                _referencedAttributes = new List<string>();

                OpenXmlPart part = GetReferencedPart(context, _partPath);

                _relatedPart = part;

                if (part != null)
                {
                    var partContext = new ValidationContext
                    {
                        FileFormat = context.FileFormat,
                        Package = context.Package,
                        Part = part,
                        Element = part.RootElement,
                    };

                    ValidationTraverser.ValidatingTraverse(partContext, ElementTraverse, null);
                }
            }

            return _referencedAttributes;
        }

        //This method is for validation traverse.
        private void ElementTraverse(ValidationContext context)
        {
            Debug.Assert(context.Element != null);

            if (context.Element.ElementTypeId == _element)
            {
                var attribute = context.Element.Attributes[_attribute];

                //Attributes whose value is empty string or null don't need to be cached.
                if (attribute.HasValue && !string.IsNullOrEmpty(attribute.Value.InnerText))
                {
                    Debug.Assert(_referencedAttributes != null);

                    _referencedAttributes.Add(attribute.Value.InnerText);
                }
            }
        }
    }
}
