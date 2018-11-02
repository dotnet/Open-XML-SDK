// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class ConditionalFormatStyle
    {
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

        /// <remarks>
        /// See §14.4.9/§14.11.9 of ISO/IEC 29500-4 for details on this translation
        /// </remarks>
        private protected override bool StrictTranslateAttribute(string namespaceUri, string localName, string value)
        {
            if (s_attributeMap.TryGetValue(localName, out var result))
            {
                localName = "val";

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
        /// §14.11.9 of ISO/IEC 29500-4 specifies that this must be 12 characters, so it is padded with 0 on the left
        /// </remarks>
        private static string ValueToString(long value) => Convert.ToString(value, 2).PadLeft(12, '0');

        private static long StringToValue(string str)
        {
            try
            {
                return Convert.ToInt64(str, 2);
            }
            catch (Exception)
            {
                // TODO: Log or allow user to handle in some way?
                return 0;
            }
        }
    }
}
