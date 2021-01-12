// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
