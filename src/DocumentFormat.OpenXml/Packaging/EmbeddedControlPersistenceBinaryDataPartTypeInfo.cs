// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class EmbeddedControlPersistenceBinaryDataPartTypeInfo
    {
        // internal static string GetContentType(EmbeddedControlPersistenceBinaryDataPartType controlType)
        //    => controlType switch
        //    {
        //        EmbeddedControlPersistenceBinaryDataPartType.ActiveXBin => "application/vnd.ms-office.activeX",
        //        _ => throw new ArgumentOutOfRangeException(nameof(controlType)),
        //    };

        // internal static string GetTargetExtension() => ".bin";

        // internal static EmbeddedControlPersistenceBinaryDataPartType GetEmbeddedControlPersistenceBinaryDataPartTypeFromContentType(string contenttype)
        //    => contenttype.ToLower(CultureInfo.CurrentCulture) switch
        //    {
        //        // If just application/xml, then just use EmbeddedControlPersistenceBinaryData type.
        //        "application/vnd.ms-office.activeX" => EmbeddedControlPersistenceBinaryDataPartType.ActiveXBin,
        //        _ => throw new NotSupportedException($"{contenttype} is not supported"),
        //    };

        // internal static bool TryGetEmbeddedControlPersistenceBinaryDataPartTypeFromContentType(string contentType)
        // {
        //    try
        //    {
        //        _ = GetEmbeddedControlPersistenceBinaryDataPartTypeFromContentType(contentType);
        //        return true;
        //    }
        //    catch (NotSupportedException)
        //    {
        //    }

        // return false;
        // }

        // internal static bool TryGetContentType(EmbeddedControlPersistenceBinaryDataPartType partType)
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
