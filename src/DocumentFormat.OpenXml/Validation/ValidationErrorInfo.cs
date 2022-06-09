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
        private XmlPath? _xmlPath;
        private OpenXmlElement? _element;
        private OpenXmlPart? _part;

        /// <summary>
        /// Gets the unique identifier of this error.
        /// </summary>
        public string Id { get; internal set; } = null!;

        /// <summary>
        /// Gets the type of this error.
        /// </summary>
        public ValidationErrorType ErrorType { get; internal set; }

        /// <summary>
        /// Gets the description and the suggestion on how to resolve the errors.
        /// </summary>
        public string Description { get; internal set; } = string.Empty;

        /// <summary>
        /// Gets the XmlPath information of this error.
        /// </summary>
        public XmlPath? Path
        {
            get
            {
                if (_xmlPath is null)
                {
                    if (_element is not null)
                    {
                        _xmlPath = XmlPath.GetXPath(_element);
                    }
                    else if (Part is not null)
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
        public OpenXmlElement? Node
        {
            get
            {
                return _element;
            }

            internal set
            {
                Part = value?.GetPart();
                _element = value;
            }
        }

        /// <summary>
        /// Gets the part which the invalid element is in.
        /// </summary>
        public OpenXmlPart? Part
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
        public OpenXmlElement? RelatedNode { get; internal set; }

        /// <summary>
        /// Gets parts related with the invalid node.
        /// </summary>
        public OpenXmlPart? RelatedPart { get; internal set; }
    }
}
