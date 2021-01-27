// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class StylePaneSortMethods
    {
        private const string StrictTranslationLocalName = "val";

        private static readonly Dictionary<string, string> s_attributeMap = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "name", "0000" },
            { "priority", "0001" },
            { "default", "0002" },
            { "font", "0003" },
            { "basedOn", "0004" },
            { "type", "0005" },
        };

        internal static IEnumerable<string> Values => s_attributeMap.Values.Concat(s_attributeMap.Keys);

        /// <remarks>
        /// See §14.11.5 of ISO/IEC 29500-4 for details on this translation
        /// </remarks>
        private protected override bool StrictTranslateAttribute(in OpenXmlQualifiedName qname, string? value)
        {
            if (string.Equals(StrictTranslationLocalName, qname.Name, StringComparison.Ordinal) && value is not null && s_attributeMap.TryGetValue(value, out var result))
            {
                value = result;
            }

            return base.StrictTranslateAttribute(qname, value);
        }
    }
}
