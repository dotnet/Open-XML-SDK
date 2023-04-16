// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class EmbeddedControlPersistencePartTypeInfo
    {
        // internal static string GetContentType(EmbeddedControlPersistencePartType controlType)
        //    => controlType switch
        //    {
        //        EmbeddedControlPersistencePartType.ActiveX => "application/vnd.ms-office.activeX+xml",
        //        EmbeddedControlPersistencePartType.ActiveXBin => "application/vnd.ms-office.activeX",
        //        _ => throw new ArgumentOutOfRangeException(nameof(controlType)),
        //    };

        // internal static string GetTargetExtension(EmbeddedControlPersistencePartType controlType)
        //    => controlType switch
        //    {
        //        EmbeddedControlPersistencePartType.ActiveX => ".xml",
        //        EmbeddedControlPersistencePartType.ActiveXBin => ".bin",
        //        _ => ".bin",
        //    };

        // internal static EmbeddedControlPersistencePartType GetEmbeddedControlPersistencePartTypeFromContentType(string contenttype)
        //    => contenttype.ToLower(CultureInfo.CurrentCulture) switch
        //    {
        //        "application/vnd.ms-office.activeX+xml" => EmbeddedControlPersistencePartType.ActiveX,
        //        "application/vnd.ms-office.activeX" => EmbeddedControlPersistencePartType.ActiveXBin,
        //        _ => throw new NotSupportedException($"{contenttype} is not supported"),
        //    };

        // internal static bool TryGetEmbeddedControlPersistencePartTypeFromContentType(string contentType)
        // {
        //    try
        //    {
        //        _ = GetEmbeddedControlPersistencePartTypeFromContentType(contentType);
        //        return true;
        //    }
        //    catch (NotSupportedException)
        //    {
        //    }

        // return false;
        // }

        // internal static bool TryGetContentType(EmbeddedControlPersistencePartType partType)
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
