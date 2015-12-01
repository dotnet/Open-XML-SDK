// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
    /// <summary>
    /// Two attributes of one element must appear as a pair.
    /// </summary>
    internal class AttributePairConstraint : SemanticConstraint
    {
        public string _attribute1LocalName;
        public string _attribute1Namespace;
        public string _attribute2LocalName;
        public string _attribute2Namespace;

        //string MissedAttribute { get; set; }
        //string ExistAttribute { get; set; }

        public AttributePairConstraint(string attribute1Namespace, string attribute1LocalName, string attribute2Namespace, string attribute2LocalName)
            : base(SemanticValidationLevel.Element)
        {
            Debug.Assert(attribute1Namespace != null);
            Debug.Assert(attribute2Namespace != null);
            Debug.Assert(!string.IsNullOrEmpty(attribute1LocalName));
            Debug.Assert(!string.IsNullOrEmpty(attribute2LocalName));

            _attribute1Namespace = attribute1Namespace;
            _attribute1LocalName = attribute1LocalName;
            _attribute2Namespace = attribute2Namespace;
            _attribute2LocalName = attribute2LocalName;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            bool attribute1Exist = context.Element.GetAttributeValueEx(this._attribute1LocalName, this._attribute1Namespace) != null;
            bool attribute2Exist = context.Element.GetAttributeValueEx(this._attribute2LocalName, this._attribute2Namespace) != null;

            //if (attribute1Exist)
            //{
            //    this.MissedAttribute = this._attribute2LocalName;
            //    this.ExistAttribute = this._attribute1LocalName;
            //}
            //else
            //{
            //    this.MissedAttribute = this._attribute1LocalName;
            //    this.ExistAttribute = this._attribute2LocalName;
            //}

            if (!(attribute1Exist ^ attribute2Exist))
            {
                return null;
            }

            return new ValidationErrorInfo() { Id = "", ErrorType = ValidationErrorType.Semantic, Node = context.Element, Description = "" };
        }
    }
}
