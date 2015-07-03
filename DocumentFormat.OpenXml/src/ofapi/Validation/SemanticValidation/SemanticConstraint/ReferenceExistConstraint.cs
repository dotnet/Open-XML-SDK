// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
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
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_refAttribute];

            if (attributeValue == null || string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return null;
            }

            if (GetReferencedAttributes(context).Contains(attributeValue.InnerText))
            {
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_MissingReferenceElement",
                ErrorType = ValidationErrorType.Semantic,
                Node = context.Element,
                RelatedPart = this._relatedPart,
                RelatedNode = null,
                Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture, 
                                            ValidationResources.Sem_MissingReferenceElement, _elementName, context.Element.LocalName, 
                                            GetAttributeQualifiedName(context.Element, _refAttribute), _relatedPart == null ? _partPath : _relatedPart.PackagePart.Uri.ToString(), attributeValue.InnerText)
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

                this._relatedPart = part;

                if (part != null)
                {
                    ValidationContext partContext = new ValidationContext();

                    partContext.FileFormat = context.FileFormat;
                    partContext.Package = context.Package;
                    partContext.Part = part;
                    partContext.Element = part.RootElement;

                    ValidationTraverser.ValidatingTraverse(partContext, this.ElementTraverse, null, null);
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
                OpenXmlSimpleType attributeValue = context.Element.Attributes[_attribute];

                //Attributes whose value is empty string or null don't need to be cached. 
                if (attributeValue != null && !string.IsNullOrEmpty(attributeValue.InnerText))
                {
                    Debug.Assert(_referencedAttributes != null);

                    _referencedAttributes.Add(attributeValue.InnerText);
                }
            }
        }
    }
}
