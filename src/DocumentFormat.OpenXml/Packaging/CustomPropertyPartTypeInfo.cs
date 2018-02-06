// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class CustomPropertyPartTypeInfo
    {
        internal static string GetContentType(CustomPropertyPartType partType)
        {
            switch (partType)
            {
                case CustomPropertyPartType.Spreadsheet:
                    return "application/vnd.openxmlformats-officedocument.spreadsheetml.customProperty";

                case CustomPropertyPartType.Xml:
                    return "application/xml";

                default:
                    throw new ArgumentOutOfRangeException(nameof(partType));
            }
        }

        internal static string GetTargetExtension(CustomPropertyPartType partType)
        {
            switch (partType)
            {
                case CustomPropertyPartType.Spreadsheet:
                    return ".xml";

                case CustomPropertyPartType.Xml:
                    return ".xml";

                default:
                    return ".xml";
            }
        }
    }
}
