// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class CustomXmlPartTypeInfo
    {
        internal static string GetContentType(CustomXmlPartType partType)
            => partType switch
            {
                CustomXmlPartType.AdditionalCharacteristics => "application/xml",
                CustomXmlPartType.Bibliography => "application/xml",
                CustomXmlPartType.CustomXml => "application/xml",
                CustomXmlPartType.InkContent => "application/inkml+xml",
                _ => throw new ArgumentOutOfRangeException(nameof(partType)),
            };

        internal static string GetTargetExtension(CustomXmlPartType partType)
            => partType switch
            {
                CustomXmlPartType.AdditionalCharacteristics => ".xml",
                CustomXmlPartType.Bibliography => ".xml",
                CustomXmlPartType.CustomXml => ".xml",
                CustomXmlPartType.InkContent => ".xml",
                _ => ".xml",
            };
    }
}
