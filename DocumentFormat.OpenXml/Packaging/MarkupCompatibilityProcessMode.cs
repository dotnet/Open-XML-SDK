// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Specifies the mode in which to process the markup compatibility tags in the document.
    /// </summary>
    public enum MarkupCompatibilityProcessMode
    {
        /// <summary>
        /// Do not process MarkupCompatibility tags.
        /// </summary>
        NoProcess = 0,

        /// <summary>
        /// Process the loaded parts.
        /// </summary>
        ProcessLoadedPartsOnly,

        /// <summary>
        /// Process all the parts in the package.
        /// </summary>
        ProcessAllParts,
    }
}
