// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class Indentation
    {
        private static readonly Dictionary<string, string> s_attributeMap = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "left", "start" },
            { "leftChars", "startChars" },
            { "right", "end" },
            { "rightChars", "endChars" },
        };

        /// <remarks>
        /// See §14.3.1.2 of ISO/IEC 29500-4 for details on this translation
        /// </remarks>
        private protected override bool StrictTranslateAttribute(string namespaceUri, string localName, string value)
        {
            if (s_attributeMap.TryGetValue(localName, out var result))
            {
                localName = result;
            }

            return base.StrictTranslateAttribute(namespaceUri, localName, value);
        }
    }
}
