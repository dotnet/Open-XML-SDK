// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class EmbeddedControlPersistencePartTypeInfo
    {
        internal static string GetContentType(EmbeddedControlPersistencePartType controlType)
        {
            switch (controlType)
            {
                case EmbeddedControlPersistencePartType.ActiveX:
                    return "application/vnd.ms-office.activeX+xml";

                case EmbeddedControlPersistencePartType.ActiveXBin:
                    return "application/vnd.ms-office.activeX";

                default:
                    throw new ArgumentOutOfRangeException(nameof(controlType));
            }
        }

        internal static string GetTargetExtension(EmbeddedControlPersistencePartType controlType)
        {
            switch (controlType)
            {
                case EmbeddedControlPersistencePartType.ActiveX:
                    return ".xml";

                case EmbeddedControlPersistencePartType.ActiveXBin:
                    return ".bin";

                default:
                    return ".bin";
            }
        }
    }
}
