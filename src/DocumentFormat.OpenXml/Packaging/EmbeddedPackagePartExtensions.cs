// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class EmbeddedPackagePartExtensions
    {
        internal static EmbeddedPackagePart AddEmbeddedPackagePart(OpenXmlPartContainer parent, EmbeddedPackagePartType partType, string? contentType = null, string? relId = null)
        {
            if (parent == null)
            {
                throw new ArgumentNullException(message: "Parent part MUST be provided.", paramName: nameof(parent));
            }

            if (string.IsNullOrWhiteSpace(contentType) && !Enum.IsDefined(partType))
            {
                throw new ArgumentException(message: "A valid contentType or partType MUST be provided");
            }

            // Try to establish the content type first.
            if (string.IsNullOrWhiteSpace(contentType))
            {
                if (EmbeddedPackagePartTypeInfo.TryGetContentType(partType))
                {
                    contentType = EmbeddedPackagePartTypeInfo.GetContentType(partType);
                }
                else
                {
                    throw new ArgumentException(message: "Unable to determine content type from package type", paramName: nameof(contentType));
                }
            }

            // At this point we know the content type. Try to get the part type.
            if (!Enum.IsDefined(partType) || partType == EmbeddedPackagePartType.Unknown)
            {
                if (EmbeddedPackagePartTypeInfo.TryGetEmbeddedPackagePartTypeFromContentType(contentType))
                {
                    partType = EmbeddedPackagePartTypeInfo.GetEmbeddedPackagePartTypeFromContentType(contentType);
                }
            }

            // Did we get it?
            if (Enum.IsDefined(partType) && partType != EmbeddedPackagePartType.Unknown)
            {
                var partExtension = EmbeddedPackagePartTypeInfo.GetTargetExtension(partType);
                parent.Features.GetRequired<IPartExtensionFeature>().Register(contentType, partExtension);
            }

            if (string.IsNullOrWhiteSpace(relId))
            {
                relId = null;
            }

            var childPart = new EmbeddedPackagePart();
            parent.InitPart(childPart, contentType, relId);
            return childPart;
        }
    }
}
