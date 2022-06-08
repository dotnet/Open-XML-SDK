// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
