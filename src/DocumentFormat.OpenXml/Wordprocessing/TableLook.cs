﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class TableLook
    {
        private const string StrictTranslationLocalName = "val";

        private static readonly Dictionary<string, long> AttributeMap = new Dictionary<string, long>(StringComparer.Ordinal)
        {
            { "firstRow", 0x0020 },
            { "lastRow", 0x040 },
            { "firstColumn", 0x080 },
            { "lastColumn", 0x100 },
            { "noHBand", 0x200 },
            { "noVBand", 0x400 },
        };

        /// <remarks>
        /// See §14.4.11 of ISO/IEC 29500-4 for details on this translation
        /// </remarks>
        private protected override bool StrictTranslateAttribute(in OpenXmlQualifiedName qname, string? value)
        {
            if (!AttributeMap.TryGetValue(qname.Name, out var result))
            {
                return base.StrictTranslateAttribute(qname, value);
            }

            var updated = new OpenXmlQualifiedName(qname.Namespace, StrictTranslationLocalName);

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
        /// According to §14.4.11 of ISO/IEC 29500-4, the string representation of the value must conform to ST_ShortHexNumber as described in §17.18.79 of ISO/IEC 29500-1
        /// </remarks>
        private static string ValueToString(long value) => Convert.ToString(value, 16).PadLeft(4, '0');

        private static long StringToValue(string? str)
        {
            if (str is null)
            {
                return 0;
            }

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
