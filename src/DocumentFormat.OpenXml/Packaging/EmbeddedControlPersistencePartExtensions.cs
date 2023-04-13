// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class EmbeddedControlPersistencePartExtensions
    {
        internal static EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(OpenXmlPartContainer parent, EmbeddedControlPersistencePartType partType, string? contentType = null, string? relId = null)
        {
            if (parent == null)
            {
                throw new ArgumentNullException(message: "Parent part MUST be provided.", paramName: nameof(parent));
            }

            if ((contentType == null || contentType.Length == 0) && partType == EmbeddedControlPersistencePartType.Unknown)
            {
                throw new ArgumentException(message: "A valid contentType or partType MUST be provided");
            }

            // Try to establish the content type first.
            if (contentType == null || contentType.Length == 0)
            {
                if (EmbeddedControlPersistencePartTypeInfo.TryGetContentType(partType))
                {
                    contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
                }
                else
                {
                    throw new ArgumentException(message: "Unable to determine content type from package type", paramName: nameof(contentType));
                }
            }

            // At this point we know the content type. Try to get the part type.
            if (partType == EmbeddedControlPersistencePartType.Unknown)
            {
                if (EmbeddedControlPersistencePartTypeInfo.TryGetEmbeddedControlPersistencePartTypeFromContentType(contentType))
                {
                    partType = EmbeddedControlPersistencePartTypeInfo.GetEmbeddedControlPersistencePartTypeFromContentType(contentType);
                }
            }

            // Did we get it?
            if (partType != EmbeddedControlPersistencePartType.Unknown)
            {
                var partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
                parent.Features.GetRequired<IPartExtensionFeature>().Register(contentType, partExtension);
            }

            if (relId == null || relId.Length == 0)
            {
                relId = null;
            }

            var childPart = new EmbeddedControlPersistencePart();
            parent.InitPart(childPart, contentType, relId);
            return childPart;
        }
    }
}
