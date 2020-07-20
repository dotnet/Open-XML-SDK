// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// Element's parent must be/not be of a specified type
    /// </summary>
    internal class ParentTypeConstraint : SemanticConstraint
    {
        private readonly Type _parentType;
        private readonly bool _isValid;

        public ParentTypeConstraint(Type parent, bool valid)
            : base(SemanticValidationLevel.Element)
        {
            Debug.Assert(parent != null);

            _parentType = parent;
            _isValid = valid;
        }

        public override ValidationErrorInfo ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current.Element;
            var parent = element.Parent;

            if (parent == null)
            {
                return null;
            }

            // TODO: Need to take ac-block into account.
            if (parent.GetType() == _parentType ^ !_isValid)
            {
                return null;
            }

            return new ValidationErrorInfo() { Id = string.Empty, ErrorType = ValidationErrorType.Semantic, Node = element, Description = string.Empty };
        }
    }
}
