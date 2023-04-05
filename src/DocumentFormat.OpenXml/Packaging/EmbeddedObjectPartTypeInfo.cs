// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class EmbeddedObjectPartTypeInfo
    {
        internal static string GetContentType(EmbeddedObjectPartType embeddedObjectType)
            => embeddedObjectType switch
            {
                EmbeddedObjectPartType.Binary => "application/vnd.openxmlformats-officedocument.oleObject",
                _ => throw new ArgumentOutOfRangeException(nameof(embeddedObjectType)),
            };

        internal static string GetTargetExtension(EmbeddedObjectPartType embeddedObjectType)
            => embeddedObjectType switch
            {
                EmbeddedObjectPartType.Binary => ".bin",
                _ => ".package",
            };

        internal static EmbeddedObjectPartType GetEmbeddedObjectPartType(string extension)
            => extension.ToLower(CultureInfo.CurrentCulture) switch
            {
                ".bin" => EmbeddedObjectPartType.Binary,
                _ => throw new NotSupportedException($"{extension} is not supported"),
            };
    }
}
