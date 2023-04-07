// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class EmbeddedObjectPartExtensions
    {
        internal static EmbeddedObjectPart AddEmbeddedObjectPart(OpenXmlPartContainer parent, EmbeddedObjectPartType partType, string? contentType = null, string? relId = null)
        {
            if (parent == null)
            {
                throw new ArgumentNullException(message: "Parent part MUST be provided.", paramName: nameof(parent));
            }

            if (string.IsNullOrWhiteSpace(contentType) && !Enum.IsDefined<EmbeddedObjectPartType>(partType))
            {
                throw new ArgumentException(message: "A valid contentType or partType MUST be provided");
            }

            // Try to establish the content type first.
            if (string.IsNullOrWhiteSpace(contentType))
            {
                if (EmbeddedObjectPartTypeInfo.TryGetContentType(partType))
                {
                    contentType = EmbeddedObjectPartTypeInfo.GetContentType(partType);
                }
                else
                {
                    throw new ArgumentException(message: "Unable to determine content type from package type", paramName: nameof(contentType));
                }
            }

            // At this point we know the content type. Try to get the part type.
            if (!Enum.IsDefined<EmbeddedObjectPartType>(partType) || partType == EmbeddedObjectPartType.Unknown)
            {
                if (EmbeddedObjectPartTypeInfo.TryGetEmbeddedObjectPartTypeFromContentType(contentType))
                {
                    partType = EmbeddedObjectPartTypeInfo.GetEmbeddedObjectPartTypeFromContentType(contentType);
                }
            }

            // Did we get it?
            if (Enum.IsDefined<EmbeddedObjectPartType>(partType) && partType != EmbeddedObjectPartType.Unknown)
            {
                var partExtension = EmbeddedObjectPartTypeInfo.GetTargetExtension(partType);
                parent.Features.GetRequired<IPartExtensionFeature>().Register(contentType, partExtension);
            }

            if (string.IsNullOrWhiteSpace(relId))
            {
                relId = null;
            }

            var childPart = new EmbeddedObjectPart();
            parent.InitPart(childPart, contentType, relId);
            return childPart;
        }
    }
}
