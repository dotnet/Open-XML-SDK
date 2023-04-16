// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines FontPartType - types of FontPart.
    /// </summary>
    public static class FontPartType
    {
        /// <summary>
        /// Defines type information for FontData font part.
        /// </summary>
        public static readonly PartTypeInfo FontData = new("application/x-fontdata", ".fntdata");

        /// <summary>
        /// Defines type information for FontTtf font part.
        /// </summary>
        public static readonly PartTypeInfo FontTtf = new("application/x-font-ttf", ".ttf");

        /// <summary>
        /// Defines type information for FontOdttf font part.
        /// </summary>
        public static readonly PartTypeInfo FontOdttf = new("application/vnd.openxmlformats-officedocument.obfuscatedFont", ".odttf");
    }
}
