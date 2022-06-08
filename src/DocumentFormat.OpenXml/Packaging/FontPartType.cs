// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines FontPartType - types of FontPart.
    /// </summary>
    public enum FontPartType
    {
        /// <summary>
        /// Font Data (.fntdata).
        /// </summary>
        FontData,

        /// <summary>
        /// TrueType Font (.ttf).
        /// </summary>
        FontTtf,

        /// <summary>
        /// Obfuscated TTF Font (.odttf).
        /// </summary>
        FontOdttf,
    }
}
