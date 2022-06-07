// Copyright (c) Microsoft.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Framework
{
    internal interface IPartMetadataFeature
    {
        OpenXmlPartData Parse(OpenXmlPartContainer part);
    }
}
