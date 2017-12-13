// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class FontPartTypeInfo
    {
        internal static string GetContentType(FontPartType fontType)
        {
            switch (fontType)
            {
                case FontPartType.FontData:
                    return "application/x-fontdata";

                case FontPartType.FontTtf:
                    return "application/x-font-ttf";

                case FontPartType.FontOdttf:
                    return "application/vnd.openxmlformats-officedocument.obfuscatedFont";

                default:
                    throw new ArgumentOutOfRangeException(nameof(fontType));
            }
        }

        internal static string GetTargetExtension(FontPartType fontType)
        {
            switch (fontType)
            {
                case FontPartType.FontData:
                    return ".fntdata";

                case FontPartType.FontTtf:
                    return ".ttf";

                case FontPartType.FontOdttf:
                    return ".odttf";

                default:
                    return ".font";
            }
        }
    }
}
