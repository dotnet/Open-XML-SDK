// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class EmbeddedControlPersistenceBinaryDataPartTypeInfo
    {
        internal static string GetContentType(EmbeddedControlPersistenceBinaryDataPartType controlType)
        {
            switch (controlType)
            {
                case EmbeddedControlPersistenceBinaryDataPartType.ActiveXBin:
                    return "application/vnd.ms-office.activeX";

                default:
                    throw new ArgumentOutOfRangeException(nameof(controlType));
            }
        }

        internal static string GetTargetExtension(EmbeddedControlPersistenceBinaryDataPartType controlType)
        {
            switch (controlType)
            {
                case EmbeddedControlPersistenceBinaryDataPartType.ActiveXBin:
                    return ".bin";

                default:
                    return ".bin";
            }
        }
    }
}
