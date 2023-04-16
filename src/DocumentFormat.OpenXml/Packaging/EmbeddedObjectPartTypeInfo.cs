// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class EmbeddedObjectPartTypeInfo
    {
        // internal static string GetContentType(EmbeddedObjectPartType embeddedObjectType)
        //    => embeddedObjectType switch
        //    {
        //        EmbeddedObjectPartType.Binary => "application/vnd.openxmlformats-officedocument.oleObject",
        //        _ => throw new ArgumentOutOfRangeException(nameof(embeddedObjectType)),
        //    };

        // internal static string GetTargetExtension(EmbeddedObjectPartType embeddedObjectType)
        //    => embeddedObjectType switch
        //    {
        //        EmbeddedObjectPartType.Unknown => ".bin",
        //        EmbeddedObjectPartType.Binary => ".bin",
        //        _ => ".package",
        //    };

        // internal static EmbeddedObjectPartType GetEmbeddedObjectPartType(string extension)
        //    => extension.ToLower(CultureInfo.CurrentCulture) switch
        //    {
        //        ".bin" => EmbeddedObjectPartType.Binary,
        //        _ => throw new NotSupportedException($"{extension} is not supported"),
        //    };

        // internal static EmbeddedObjectPartType GetEmbeddedObjectPartTypeFromContentType(string contenttype)
        //    => contenttype.ToLower(CultureInfo.CurrentCulture) switch
        //    {
        //        "application/vnd.openxmlformats-officedocument.oleObject" => EmbeddedObjectPartType.Binary,
        //        _ => throw new NotSupportedException($"{contenttype} is not supported"),
        //    };

        // internal static bool TryGetEmbeddedObjectPartTypeFromContentType(string contentType)
        // {
        //    try
        //    {
        //        _ = GetEmbeddedObjectPartTypeFromContentType(contentType);
        //        return true;
        //    }
        //    catch (NotSupportedException)
        //    {
        //    }

        // return false;
        // }

        // internal static bool TryGetContentType(EmbeddedObjectPartType partType)
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
