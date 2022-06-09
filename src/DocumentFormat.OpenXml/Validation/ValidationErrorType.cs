// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
}
