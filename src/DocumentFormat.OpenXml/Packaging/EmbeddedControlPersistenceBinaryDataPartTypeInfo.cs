// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class EmbeddedControlPersistenceBinaryDataPartTypeInfo
    {
        internal static string GetContentType(EmbeddedControlPersistenceBinaryDataPartType controlType)
            => controlType switch
            {
                EmbeddedControlPersistenceBinaryDataPartType.ActiveXBin => "application/vnd.ms-office.activeX",
                _ => throw new ArgumentOutOfRangeException(nameof(controlType)),
            };

        internal static string GetTargetExtension() => ".bin";
    }
}
