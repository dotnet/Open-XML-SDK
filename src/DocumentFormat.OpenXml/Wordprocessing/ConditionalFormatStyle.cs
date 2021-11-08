﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class ConditionalFormatStyle
    {
        private static readonly Dictionary<string, long> AttributeMap = new Dictionary<string, long>(StringComparer.Ordinal)
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
        private protected override bool StrictTranslateAttribute(in OpenXmlQualifiedName qname, string? value)
        {
            if (!AttributeMap.TryGetValue(qname.Name, out var result))
            {
                return base.StrictTranslateAttribute(qname, value);
            }

            var updated = new OpenXmlQualifiedName(qname.Namespace, "val");

            var isValueTrue = value == "true" || value == "1";
            var attribute = RawState.Attributes[updated];

            if (attribute.Value is OpenXmlSimpleType simpleType)
            {
                var current = StringToValue(simpleType.InnerText);
                var combined = isValueTrue ? (current | result) : (current & ~result);

                value = ValueToString(combined);
            }
            else
            {
                value = ValueToString(isValueTrue ? result : 0);
            }

            return base.StrictTranslateAttribute(updated, value);
        }

        /// <remarks>
        /// §14.11.9 of ISO/IEC 29500-4 specifies that this must be 12 characters, so it is padded with 0 on the left
        /// </remarks>
        private static string ValueToString(long value) => Convert.ToString(value, 2).PadLeft(12, '0');

        private static long StringToValue(string? str)
        {
            if (str is null)
            {
                return 0;
            }

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
