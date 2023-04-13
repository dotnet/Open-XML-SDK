// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
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

            return main.AddImagePart(ImagePartTypeInfo.GetImagePartType(extension));
        }

        internal static ImagePart AddImagePart(OpenXmlPartContainer parent, ImagePartType partType, string? contentType = null, string? relId = null)
        {
            if (parent == null)
            {
                throw new ArgumentNullException(message: "Parent part MUST be provided.", paramName: nameof(parent));
            }

            if ((contentType == null || contentType.Length == 0) && partType == ImagePartType.Unknown)
            {
                throw new ArgumentException(message: "A valid contentType or partType MUST be provided");
            }

            // Try to establish the content type first.
            if (contentType == null || contentType.Length == 0)
            {
                if (ImagePartTypeInfo.TryGetContentType(partType))
                {
                    contentType = ImagePartTypeInfo.GetContentType(partType);
                }
                else
                {
                    throw new ArgumentException(message: "Unable to determine content type from package type", paramName: nameof(contentType));
                }
            }

            // At this point we know the content type. Try to get the part type.
            if (partType == ImagePartType.Unknown)
            {
                if (ImagePartTypeInfo.TryGetImagePartTypeFromContentType(contentType))
                {
                    partType = ImagePartTypeInfo.GetImagePartTypeFromContentType(contentType);
                }
            }

            // Did we get it?
            if (partType != ImagePartType.Unknown)
            {
                var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
                parent.Features.GetRequired<IPartExtensionFeature>().Register(contentType, partExtension);
            }

            if (relId == null || relId.Length == 0)
            {
                relId = null;
            }

            var childPart = new ImagePart();
            parent.InitPart(childPart, contentType, relId);
            return childPart;
        }
    }
}
