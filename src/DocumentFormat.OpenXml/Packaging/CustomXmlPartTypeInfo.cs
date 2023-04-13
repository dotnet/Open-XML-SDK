// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

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

        internal static string GetTargetExtension() => ".xml";

        internal static CustomXmlPartType GetCustomXmlPartTypeFromContentType(string contenttype)
            => contenttype.ToLower(CultureInfo.CurrentCulture) switch
            {
                // If just application/xml, then just use CustomXml type.
                "application/xml" => CustomXmlPartType.CustomXml,
                "application/inkml+xml" => CustomXmlPartType.InkContent,
                _ => throw new NotSupportedException($"{contenttype} is not supported"),
            };

        internal static bool TryGetCustomXmlPartTypeFromContentType(string contentType)
        {
            try
            {
                _ = GetCustomXmlPartTypeFromContentType(contentType);
                return true;
            }
            catch (NotSupportedException)
            {
            }

            return false;
        }

        internal static bool TryGetContentType(CustomXmlPartType partType)
        {
            try
            {
                _ = GetContentType(partType);
                return true;
            }
            catch (NotSupportedException)
            {
            }

            return false;
        }
    }
}
