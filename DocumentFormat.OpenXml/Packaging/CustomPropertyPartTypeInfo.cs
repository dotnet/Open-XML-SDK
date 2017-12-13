// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
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
