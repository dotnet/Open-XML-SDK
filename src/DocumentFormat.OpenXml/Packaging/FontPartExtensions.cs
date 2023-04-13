// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class FontPartExtensions
    {
        internal static FontPart AddFontPart(OpenXmlPartContainer parent, FontPartType partType, string? contentType = null, string? relId = null)
        {
            if (parent == null)
            {
                throw new ArgumentNullException(message: "Parent part MUST be provided.", paramName: nameof(parent));
            }

            if ((contentType == null || contentType.Length == 0) && partType == FontPartType.Unknown)
            {
                throw new ArgumentException(message: "A valid contentType or partType MUST be provided");
            }

            // Try to establish the content type first.
            if (contentType == null || contentType.Length == 0)
            {
                if (FontPartTypeInfo.TryGetContentType(partType))
                {
                    contentType = FontPartTypeInfo.GetContentType(partType);
                }
                else
                {
                    throw new ArgumentException(message: "Unable to determine content type from package type", paramName: nameof(contentType));
                }
            }

            // At this point we know the content type. Try to get the part type.
            if (partType == FontPartType.Unknown)
            {
                if (FontPartTypeInfo.TryGetFontPartTypeFromContentType(contentType))
                {
                    partType = FontPartTypeInfo.GetFontPartTypeFromContentType(contentType);
                }
            }

            // Did we get it?
            if (partType != FontPartType.Unknown)
            {
                var partExtension = FontPartTypeInfo.GetTargetExtension(partType);
                parent.Features.GetRequired<IPartExtensionFeature>().Register(contentType, partExtension);
            }

            if (relId == null || relId.Length == 0)
            {
                relId = null;
            }

            var childPart = new FontPart();
            parent.InitPart(childPart, contentType, relId);
            return childPart;
        }
    }
}
