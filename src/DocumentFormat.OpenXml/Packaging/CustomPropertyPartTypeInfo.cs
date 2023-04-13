// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class CustomPropertyPartTypeInfo
    {
        internal static string GetContentType(CustomPropertyPartType partType)
            => partType switch
            {
                CustomPropertyPartType.Spreadsheet => "application/vnd.openxmlformats-officedocument.spreadsheetml.customProperty",
                CustomPropertyPartType.Xml => "application/xml",
                _ => throw new ArgumentOutOfRangeException(nameof(partType)),
            };

        internal static string GetTargetExtension() => ".xml";

        internal static CustomPropertyPartType GetCustomPropertyPartTypeFromContentType(string contenttype)
            => contenttype.ToLower(CultureInfo.CurrentCulture) switch
            {
                "application/vnd.openxmlformats-officedocument.spreadsheetml.customProperty" => CustomPropertyPartType.Spreadsheet,
                "application/xml" => CustomPropertyPartType.Xml,
                _ => throw new NotSupportedException($"{contenttype} is not supported"),
            };

        internal static bool TryGetCustomPropertyPartTypeFromContentType(string contentType)
        {
            try
            {
                _ = GetCustomPropertyPartTypeFromContentType(contentType);
                return true;
            }
            catch (NotSupportedException)
            {
            }

            return false;
        }

        internal static bool TryGetContentType(CustomPropertyPartType partType)
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
