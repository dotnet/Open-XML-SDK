// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class CustomXmlPartTypeInfo
    {
        internal static string GetContentType(CustomXmlPartType partType)
        {
            switch (partType)
            {
                case CustomXmlPartType.AdditionalCharacteristics:
                    return "application/xml";

                case CustomXmlPartType.Bibliography:
                    return "application/xml";

                case CustomXmlPartType.CustomXml:
                    return "application/xml";

                case CustomXmlPartType.InkContent:
                    return "application/inkml+xml";

                default:
                    throw new ArgumentOutOfRangeException(nameof(partType));
            }
        }

        internal static string GetTargetExtension(CustomXmlPartType partType)
        {
            switch (partType)
            {
                case CustomXmlPartType.AdditionalCharacteristics:
                    return ".xml";

                case CustomXmlPartType.Bibliography:
                    return ".xml";

                case CustomXmlPartType.CustomXml:
                    return ".xml";

                case CustomXmlPartType.InkContent:
                    return ".xml";

                default:
                    return ".xml";
            }
        }
    }
}
