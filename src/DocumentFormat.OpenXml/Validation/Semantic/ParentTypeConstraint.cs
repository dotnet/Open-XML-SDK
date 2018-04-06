// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
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

            if (parent.GetType() == _parentType ^ !_isValid) // TODO: Need to take ac-block into account.
            {
                return null;
            }

            return new ValidationErrorInfo() { Id = string.Empty, ErrorType = ValidationErrorType.Semantic, Node = context.Element, Description = string.Empty };
        }
    }
}
