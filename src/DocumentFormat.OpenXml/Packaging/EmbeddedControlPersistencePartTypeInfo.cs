// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class EmbeddedControlPersistencePartTypeInfo
    {
        internal static string GetContentType(EmbeddedControlPersistencePartType controlType)
            => controlType switch
            {
                EmbeddedControlPersistencePartType.ActiveX => "application/vnd.ms-office.activeX+xml",
                EmbeddedControlPersistencePartType.ActiveXBin => "application/vnd.ms-office.activeX",
                _ => throw new ArgumentOutOfRangeException(nameof(controlType)),
            };

        internal static string GetTargetExtension(EmbeddedControlPersistencePartType controlType)
            => controlType switch
            {
                EmbeddedControlPersistencePartType.ActiveX => ".xml",
                EmbeddedControlPersistencePartType.ActiveXBin => ".bin",
                _ => ".bin",
            };
    }
}
