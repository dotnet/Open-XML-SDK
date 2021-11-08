﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class Indentation
    {
        private static readonly Dictionary<string, string> AttributeMap = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "left", "start" },
            { "leftChars", "startChars" },
            { "right", "end" },
            { "rightChars", "endChars" },
        };

        /// <remarks>
        /// See §14.3.1.2 of ISO/IEC 29500-4 for details on this translation
        /// </remarks>
        private protected override bool StrictTranslateAttribute(in OpenXmlQualifiedName qname, string? value)
        {
            if (AttributeMap.TryGetValue(qname.Name, out var result))
            {
                return base.StrictTranslateAttribute(new OpenXmlQualifiedName(qname.Namespace, result), value);
            }

            return base.StrictTranslateAttribute(qname, value);
        }
    }
}
