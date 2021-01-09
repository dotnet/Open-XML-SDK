// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class FontPartTypeInfo
    {
        internal static string GetContentType(FontPartType fontType)
            => fontType switch
            {
                FontPartType.FontData => "application/x-fontdata",
                FontPartType.FontTtf => "application/x-font-ttf",
                FontPartType.FontOdttf => "application/vnd.openxmlformats-officedocument.obfuscatedFont",
                _ => throw new ArgumentOutOfRangeException(nameof(fontType)),
            };

        internal static string GetTargetExtension(FontPartType fontType)
            => fontType switch
            {
                FontPartType.FontData => ".fntdata",
                FontPartType.FontTtf => ".ttf",
                FontPartType.FontOdttf => ".odttf",
                _ => ".font",
            };
    }
}
