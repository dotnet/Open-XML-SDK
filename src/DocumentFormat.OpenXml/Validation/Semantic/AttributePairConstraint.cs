// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// Two attributes of one element must appear as a pair.
    /// </summary>
    internal class AttributePairConstraint : SemanticConstraint
    {
        private readonly string _attribute1LocalName;
        private readonly string _attribute1Namespace;
        private readonly string _attribute2LocalName;
        private readonly string _attribute2Namespace;

        public AttributePairConstraint(string attribute1Namespace, string attribute1LocalName, string attribute2Namespace, string attribute2LocalName)
            : base(SemanticValidationLevel.Element)
        {
            _attribute1Namespace = attribute1Namespace;
            _attribute1LocalName = attribute1LocalName;
            _attribute2Namespace = attribute2Namespace;
            _attribute2LocalName = attribute2LocalName;
        }

        public override ValidationErrorInfo? ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current?.Element;

            if (element is null)
            {
                return null;
            }

            var attribute1Exist = element.GetAttributeValueEx(_attribute1LocalName, _attribute1Namespace) is not null;
            var attribute2Exist = element.GetAttributeValueEx(_attribute2LocalName, _attribute2Namespace) is not null;

            if (!(attribute1Exist ^ attribute2Exist))
            {
                return null;
            }

            return new ValidationErrorInfo
            {
                Id = string.Empty,
                ErrorType = ValidationErrorType.Semantic,
                Node = element,
                Description = string.Empty,
            };
        }
    }
}
