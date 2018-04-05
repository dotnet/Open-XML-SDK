// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
