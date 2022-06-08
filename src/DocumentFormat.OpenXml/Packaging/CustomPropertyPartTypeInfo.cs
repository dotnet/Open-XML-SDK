// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;

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
    }
}
