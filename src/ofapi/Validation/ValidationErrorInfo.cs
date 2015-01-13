// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// The type of the validation error.
    /// </summary>
    public enum ValidationErrorType
    {
        /// <summary>
        /// Schema validation error.
        /// </summary>
        Schema,
        /// <summary>
        /// Semantic validation error.
        /// </summary>
        Semantic,
        /// <summary>
        /// Package structure validation error.
        /// </summary>
        Package,
        /// <summary>
        /// Markup Compatibility validation error.
        /// </summary>
        MarkupCompatibility,
    }

    /// <summary>
    /// Defines the ValidationErrorInfo.
    /// </summary>
    [DebuggerDisplay("Description={Description}")]
    public class ValidationErrorInfo
    {
        /// <summary>
        /// Initializes a new instance of the ValidationErrorInfo.
        /// </summary>
        public ValidationErrorInfo()
        {
        }

#if DEBUG
        /// <summary>
        /// The semantic constraint ID in internal tool.
        /// </summary>
        /// <remarks>
        /// This is for debug only.
        /// </remarks>
        public string SemanticConstraintId
        {
            get;
            internal set;
        }

        /// <summary>
        /// Returns the XML qualified name for the attribute.
        /// Returns null if the error is not for attribute.
        /// </summary>
        public string AttributeQualifiedName
        {
            get;
            internal set;
        }

        /// <summary>
        /// Returns schema validation error category.
        /// </summary>
        public string ValidationErrorCategory
        {
            get;
            internal set;
        }
#endif
        /// <summary>
        /// Sets the two fields (AttributeQualifiedName, ValidationErrorCategory) in debug build only.
        /// </summary>
        /// <param name="attributeQualifiedName"></param>
        /// <param name="validationErrorCategory"></param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        [Conditional("DEBUG")]
        public void SetDebugField(string attributeQualifiedName, string validationErrorCategory)
        {
#if DEBUG
            this.AttributeQualifiedName = attributeQualifiedName;
            this.ValidationErrorCategory = validationErrorCategory;
#endif
        }


        /// <summary>
        /// Gets the unique identifier of this error.
        /// </summary>
        public string Id
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the type of this error.
        /// </summary>
        public ValidationErrorType ErrorType
        {
            get;
            internal set;
        }

        ///// <summary>
        ///// Gets the category of this error.
        ///// </summary>
        //public string Category
        //{
        //    get;
        //    internal set;
        //}

        /// <summary>
        /// Gets the description and the suggestion on how to resolve the errors.
        /// </summary>
        public string Description
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the XmlPath information of this error.
        /// </summary>
        public XmlPath Path
        {
            get;
            internal set;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OpenXmlElement _element;

        /// <summary>
        /// Gets the OpenXmlElement of the invalid node.
        /// </summary>
        public OpenXmlElement Node
        {
            get
            {
                return this._element;
            }

            internal set
            {
                this._element = value;
                this.Path = XmlPath.GetXPath( value );
                if (this.Part == null)
                {
                    this.Part = this._element.GetPart();
                }
                else
                {
                    Debug.Assert(this.Part == this._element.GetPart());
                }
            }
        }

        /// <summary>
        /// Gets the part which the invalid element is in.
        /// </summary>
        public OpenXmlPart Part
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets elements related with the invalid node.
        /// </summary>
        public OpenXmlElement RelatedNode
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets parts related with the invalid node.
        /// </summary>
        public OpenXmlPart RelatedPart
        {
            get;
            internal set;
        }
    }
}
