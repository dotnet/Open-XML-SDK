// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Provides extensions to working with ImagePart and ImagePartType
    /// </summary>
    public static class ImagePartExtensions
    {
        /// <summary>
        /// Extends an overloaded AddImagePart method that
        /// handles the process of determining the ImagePartType
        /// for you based on a provided file extension.
        /// </summary>
        /// <param name="main">The source MainDocumentPart that is adding the ImagePart.</param>
        /// <param name="extension">The file extension of the image.</param>
        /// <see cref="MainDocumentPart.AddImagePart(ImagePartType)" />
        public static ImagePart AddImagePart(this MainDocumentPart main, string extension) =>
            main.AddImagePart(ImagePartTypeInfo.GetImagePartType(extension));
    }
}
