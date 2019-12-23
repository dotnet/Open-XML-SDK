// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Defines the ValidationErrorInfo.
    /// </summary>
    [DebuggerDisplay("Description={Description}")]
    public class ValidationErrorInfo
    {
        private XmlPath _xmlPath;
        private OpenXmlElement _element;
        private OpenXmlPart _part;

#if DEBUG
        /// <summary>
        /// Gets the XML qualified name for the attribute.
        /// Returns null if the error is not for attribute.
        /// </summary>
        public string AttributeQualifiedName { get; private set; }

        /// <summary>
        /// Gets schema validation error category.
        /// </summary>
        public string ValidationErrorCategory { get; private set; }
#endif

        /// <summary>
        /// Sets the two fields (AttributeQualifiedName, ValidationErrorCategory) in debug build only.
        /// </summary>
        /// <param name="attributeQualifiedName"></param>
        /// <param name="validationErrorCategory"></param>
        [Conditional("DEBUG")]
#pragma warning disable CA1822 // Mark members as static
        public void SetDebugField(string attributeQualifiedName, string validationErrorCategory)
#pragma warning restore CA1822 // Mark members as static
        {
#if DEBUG
            AttributeQualifiedName = attributeQualifiedName;
            ValidationErrorCategory = validationErrorCategory;
#endif
        }

        /// <summary>
        /// Gets the unique identifier of this error.
        /// </summary>
        public string Id { get; internal set; }

        /// <summary>
        /// Gets the type of this error.
        /// </summary>
        public ValidationErrorType ErrorType { get; internal set; }

        /// <summary>
        /// Gets the description and the suggestion on how to resolve the errors.
        /// </summary>
        public string Description { get; internal set; }

        /// <summary>
        /// Gets the XmlPath information of this error.
        /// </summary>
        public XmlPath Path
        {
            get
            {
                if (_xmlPath is null)
                {
                    if (_element != null)
                    {
                        _xmlPath = XmlPath.GetXPath(_element);
                    }
                    else if (Part != null)
                    {
                        _xmlPath = XmlPath.GetXPath(Part);
                    }
                }

                return _xmlPath;
            }
        }

        /// <summary>
        /// Gets the OpenXmlElement of the invalid node.
        /// </summary>
        public OpenXmlElement Node
        {
            get
            {
                return _element;
            }

            internal set
            {
                Part = value.GetPart();
                _element = value;
            }
        }

        /// <summary>
        /// Gets the part which the invalid element is in.
        /// </summary>
        public OpenXmlPart Part
        {
            get => _part;

            internal set
            {
                _part = value;
                _element = null;
                _xmlPath = null;
            }
        }

        /// <summary>
        /// Gets elements related with the invalid node.
        /// </summary>
        public OpenXmlElement RelatedNode { get; internal set; }

        /// <summary>
        /// Gets parts related with the invalid node.
        /// </summary>
        public OpenXmlPart RelatedPart { get; internal set; }
    }
}
