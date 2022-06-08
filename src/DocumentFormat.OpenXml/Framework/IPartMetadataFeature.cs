// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Framework
{
    internal interface IPartMetadataFeature
    {
        OpenXmlPartData Parse(OpenXmlPartContainer part);
    }
}
