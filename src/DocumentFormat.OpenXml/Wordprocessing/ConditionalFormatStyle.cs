// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Attributes;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class ConditionalFormatStyle
    {
        private static readonly BinaryValueConverter s_converter = new BinaryValueConverter(12);
        private static readonly Dictionary<string, long> s_attributeMap = new Dictionary<string, long>(StringComparer.Ordinal)
        {
            { "firstRow", 0x800 },
            { "lastRow", 0x400 },
            { "firstColumn", 0x200 },
            { "lastColumn", 0x100 },
            { "oddVBand", 0x080 },
            { "evenVBand", 0x040 },
            { "oddHBand", 0x020 },
            { "evenHBand", 0x010 },
            { "firstRowLastColumn", 0x008 },
            { "firstRowFirstColumn", 0x004 },
            { "lastRowFirstColumn", 0x002 },
            { "lastRowLastColumn", 0x001 },
        };

        private protected override bool StrictTranslateAttribute(string namespaceUri, string localName, string value)
        {
            if (s_attributeMap.TryGetValue(localName, out var result))
            {
                localName = "val";

                var isValueTrue = value == "true" || value == "1";
                var index = FindAttributeIndex(namespaceUri, localName);

                if (index >= 0 && FixedAttributesArray[index] is OpenXmlSimpleType simpleType)
                {
                    var current = s_converter.StringToValue(simpleType.InnerText);
                    var combined = isValueTrue ? (current | result) : (current & ~result);

                    value = s_converter.ValueToString(combined);
                }
                else
                {
                    value = s_converter.ValueToString(isValueTrue ? result : 0);
                }
            }

            return base.StrictTranslateAttribute(namespaceUri, localName, value);
        }
    }
}
