// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class CustomXmlPartExtensions
    {
        // internal static CustomXmlPart AddCustomXmlPart(OpenXmlPartContainer parent, CustomXmlPartType partType, string? contentType = null, string? relId = null)
        // {
        //    if (parent == null)
        //    {
        //        throw new ArgumentNullException(message: "Parent part MUST be provided.", paramName: nameof(parent));
        //    }

        // if ((contentType == null || contentType.Length == 0) && partType == CustomXmlPartType.Unknown)
        //    {
        //        throw new ArgumentException(message: "A valid contentType or partType MUST be provided");
        //    }

        // // Try to establish the content type first.
        //    if (contentType == null || contentType.Length == 0)
        //    {
        //        if (CustomXmlPartTypeInfo.TryGetContentType(partType))
        //        {
        //            contentType = CustomXmlPartTypeInfo.GetContentType(partType);
        //        }
        //        else
        //        {
        //            throw new ArgumentException(message: "Unable to determine content type from package type", paramName: nameof(contentType));
        //        }
        //    }

        // // At this point we know the content type. Try to get the part type.
        //    if (partType == CustomXmlPartType.Unknown)
        //    {
        //        if (CustomXmlPartTypeInfo.TryGetCustomXmlPartTypeFromContentType(contentType))
        //        {
        //            partType = CustomXmlPartTypeInfo.GetCustomXmlPartTypeFromContentType(contentType);
        //        }
        //    }

        // // Did we get it?
        //    if (partType != CustomXmlPartType.Unknown)
        //    {
        //        var partExtension = CustomXmlPartTypeInfo.GetTargetExtension();
        //        parent.Features.GetRequired<IPartExtensionFeature>().Register(contentType, partExtension);
        //    }

        // if (relId == null || relId.Length == 0)
        //    {
        //        relId = null;
        //    }

        // var childPart = new CustomXmlPart();
        //    parent.InitPart(childPart, contentType, relId);
        //    return childPart;
        // }
    }
}
