// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class FontPartTypeInfo
    {
        // internal static string GetContentType(FontPartType fontType)
        //    => fontType switch
        //    {
        //        FontPartType.FontData => "application/x-fontdata",
        //        FontPartType.FontTtf => "application/x-font-ttf",
        //        FontPartType.FontOdttf => "application/vnd.openxmlformats-officedocument.obfuscatedFont",
        //        _ => throw new ArgumentOutOfRangeException(nameof(fontType)),
        //    };

        // internal static string GetTargetExtension(FontPartType fontType)
        //    => fontType switch
        //    {
        //        FontPartType.FontData => ".fntdata",
        //        FontPartType.FontTtf => ".ttf",
        //        FontPartType.FontOdttf => ".odttf",
        //        _ => ".font",
        //    };

        // internal static FontPartType GetFontPartTypeFromContentType(string contenttype)
        //    => contenttype.ToLower(CultureInfo.CurrentCulture) switch
        //    {
        //        "application/x-fontdata" => FontPartType.FontData,
        //        "application/x-font-ttf" => FontPartType.FontTtf,
        //        "application/vnd.openxmlformats-officedocument.obfuscatedFont" => FontPartType.FontOdttf,
        //        _ => throw new NotSupportedException($"{contenttype} is not supported"),
        //    };

        // internal static bool TryGetFontPartTypeFromContentType(string contentType)
        // {
        //    try
        //    {
        //        _ = GetFontPartTypeFromContentType(contentType);
        //        return true;
        //    }
        //    catch (NotSupportedException)
        //    {
        //    }

        // return false;
        // }

        // internal static bool TryGetContentType(FontPartType partType)
        // {
        //    try
        //    {
        //        _ = GetContentType(partType);
        //        return true;
        //    }
        //    catch (NotSupportedException)
        //    {
        //    }

        // return false;
        // }
    }
}
