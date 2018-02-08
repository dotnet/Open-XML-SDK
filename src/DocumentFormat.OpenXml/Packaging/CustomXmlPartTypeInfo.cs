// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

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
