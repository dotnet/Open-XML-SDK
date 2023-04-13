// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class AlternativeFormatImportPartExtensions
    {
        internal static AlternativeFormatImportPart AddAlternativeFormatImportPart(OpenXmlPartContainer parent, AlternativeFormatImportPartType partType, string? contentType = null, string? relId = null)
        {
            if (parent == null)
            {
                throw new ArgumentNullException(message: "Parent part MUST be provided.", paramName: nameof(parent));
            }

            if ((contentType == null || contentType.Length == 0) && partType == AlternativeFormatImportPartType.Unknown)
            {
                throw new ArgumentException(message: "A valid contentType or partType MUST be provided");
            }

            // Try to establish the content type first.
            if (contentType == null || contentType.Length == 0)
            {
                if (AlternativeFormatImportPartTypeInfo.TryGetContentType(partType))
                {
                    contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
                }
                else
                {
                    throw new ArgumentException(message: "Unable to determine content type from package type", paramName: nameof(contentType));
                }
            }

            // At this point we know the content type. Try to get the part type.
            if (partType == AlternativeFormatImportPartType.Unknown)
            {
                if (AlternativeFormatImportPartTypeInfo.TryGetAlternativeFormatImportPartTypeFromContentType(contentType))
                {
                    partType = AlternativeFormatImportPartTypeInfo.GetAlternativeFormatImportPartTypeFromContentType(contentType);
                }
            }

            // Did we get it?
            if (partType != AlternativeFormatImportPartType.Unknown)
            {
                var partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
                parent.Features.GetRequired<IPartExtensionFeature>().Register(contentType, partExtension);
            }

            if (relId == null || relId.Length == 0)
            {
                relId = null;
            }

            var childPart = new AlternativeFormatImportPart();
            parent.InitPart(childPart, contentType, relId);
            return childPart;
        }
    }
}
