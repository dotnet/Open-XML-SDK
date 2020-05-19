// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal interface ISemanticConstraint
    {
        SemanticValidationLevel SemanticValidationLevel { get; }

        SemanticValidationLevel StateScope { get; }

        ApplicationType Application { get; }

        FileFormatVersions Version { get; }

        /// <summary>
        /// Semantic validation logic
        /// </summary>
        /// <param name="context">return null if validation succeed</param>
        /// <returns></returns>
        abstract public ValidationErrorInfo Validate(ValidationContext context);
    }
}
