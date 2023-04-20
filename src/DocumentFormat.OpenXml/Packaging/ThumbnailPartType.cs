// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines ThumbnailPartType - types of ThumbnailPart.
    /// </summary>
    public static class ThumbnailPartType
    {
        /// <summary>
        /// Defines type information for JPEG/JIFF Image (.jpeg) thumbnail part.
        /// </summary>
        public static readonly PartTypeInfo Jpeg = new("image/jpeg", ".jpg");

        /// <summary>
        /// Defines type information for Extended (Enhanced) Windows Metafile Format (.emf) thumbnail part.
        /// </summary>
        public static readonly PartTypeInfo Emf = new("image/x-emf", ".emf");

        /// <summary>
        /// Defines type information for Windows Metafile (.wmf) thumbnail part.
        /// </summary>
        public static readonly PartTypeInfo Wmf = new("image/x-wmf", ".wmf");
    }
}
