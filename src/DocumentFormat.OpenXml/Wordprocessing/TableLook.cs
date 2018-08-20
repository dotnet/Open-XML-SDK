// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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

        /// <remarks>
        /// See §14.4.11 of ISO/IEC 29500-4 for details on this translation
        /// </remarks>
        private protected override bool StrictTranslateAttribute(string namespaceUri, string localName, string value)
        {
            if (s_attributeMap.TryGetValue(localName, out var result))
            {
                localName = StrictTranslationLocalName;

                var isValueTrue = value == "true" || value == "1";
                var attribute = RawAttributes[namespaceUri, localName];

                if (attribute.HasValue)
                {
                    var current = StringToValue(attribute.Value.InnerText);
                    var combined = isValueTrue ? (current | result) : (current & ~result);

                    value = ValueToString(combined);
                }
                else
                {
                    value = ValueToString(isValueTrue ? result : 0);
                }
            }

            return base.StrictTranslateAttribute(namespaceUri, localName, value);
        }

        /// <remarks>
        /// According to §14.4.11 of ISO/IEC 29500-4, the string representation of the value must conform to ST_ShortHexNumber as described in §17.18.79 of ISO/IEC 29500-1
        /// </remarks>
        private static string ValueToString(long value) => Convert.ToString(value, 16).PadLeft(4, '0');

        private static long StringToValue(string str)
        {
            try
            {
                return Convert.ToInt64(str, 16);
            }
            catch (Exception)
            {
                // TODO: Log or allow user to handle in some way?
                return 0;
            }
        }
    }
}
