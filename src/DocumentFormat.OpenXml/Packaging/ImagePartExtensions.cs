// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;

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
        public static ImagePart AddImagePart(this MainDocumentPart main, string extension)
        {
            if (main is null)
            {
                throw new ArgumentNullException(nameof(main));
            }

            if (string.IsNullOrEmpty(extension))
            {
                throw new ArgumentException($"'{nameof(extension)}' cannot be null or empty.", nameof(extension));
            }

            // return main.AddImagePart(ImagePartTypeInfo.GetImagePartType(extension));
            return (ImagePart)OpenXmlPartExtensions.InitPart(main, new ImagePart(), ImagePartTypeInfo.GetImagePartType(extension));
        }

        /// <summary>
        /// Adds a ImagePart to a parent IAddExtensiblePart class.
        /// </summary>
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static ImagePart AddImagePart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, IAddExtensiblePartSupport<ImagePart>
        {
            return (ImagePart)OpenXmlPartExtensions.InitPart(parent, new ImagePart(), partType, id);
        }
    }
}
