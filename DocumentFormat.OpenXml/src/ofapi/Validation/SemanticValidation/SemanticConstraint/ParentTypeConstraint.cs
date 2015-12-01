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
    /// Element's parent must be/not be of a specified type
    /// </summary>
    internal class ParentTypeConstraint : SemanticConstraint
    {
        private Type _parentType;
        private bool _isValid;

        public ParentTypeConstraint(Type parent, bool valid)
            : base(SemanticValidationLevel.Element) 
        {
            Debug.Assert(parent != null);

            _parentType = parent;
            _isValid = valid;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            OpenXmlElement parent = context.Element.Parent;

            if (parent == null)
            {
                return null;
            }

            if (parent.GetType() == this._parentType ^ !this._isValid) //TODO: (junzha) need to take ac-block into account.
            {
                return null;
            }

            return new ValidationErrorInfo() { Id = "", ErrorType = ValidationErrorType.Semantic, Node = context.Element, Description = "" };
        }
    }
}
