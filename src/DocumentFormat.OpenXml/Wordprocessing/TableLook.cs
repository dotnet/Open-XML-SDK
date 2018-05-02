// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Attributes;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class TableLook
    {
        private const string StrictTranslationLocalName = "val";

        private static readonly Dictionary<string, long> s_attributeMap = new Dictionary<string, long>(StringComparer.Ordinal)
        {
            { "firstRow", 0x0020},
            { "lastRow", 0x040},
            { "firstColumn", 0x080},
            { "lastColumn", 0x100},
            { "noHBand", 0x200},
            { "noVBand", 0x400},
        };

        private protected override bool StrictTranslateAttribute(string namespaceUri, string localName, string value)
        {
            if (s_attributeMap.TryGetValue(localName, out var result))
            {
                localName = StrictTranslationLocalName;

                var isValueTrue = value == "true" || value == "1";
                var index = FindAttributeIndex(namespaceUri, localName);

                if (index >= 0 && FixedAttributesArray[index] is OpenXmlSimpleType simpleType)
                {
                    var current = HexValueConverter.Instance.StringToValue(simpleType.InnerText);
                    var combined = isValueTrue ? (current | result) : (current & ~result);

                    value = HexValueConverter.Instance.ValueToString(combined);
                }
                else
                {
                    value = HexValueConverter.Instance.ValueToString(isValueTrue ? result : 0);
                }
            }

            return base.StrictTranslateAttribute(namespaceUri, localName, value);
        }
    }
}
