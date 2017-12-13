// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
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
