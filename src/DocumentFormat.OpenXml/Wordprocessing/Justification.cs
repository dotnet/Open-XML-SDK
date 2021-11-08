﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class Justification
    {
        private static readonly Dictionary<string, string> AttributeMap = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "start", "left" },
            { "end", "right" },
        };

        /// <remarks>
        /// See §14.11.2 of ISO/IEC 29500-4 for details on this translation
        /// </remarks>
        private protected override bool StrictTranslateAttribute(in OpenXmlQualifiedName qname, string? value)
        {
            if (value is not null && AttributeMap.TryGetValue(value, out var result))
            {
                value = result;
            }

            return base.StrictTranslateAttribute(qname, value);
        }
    }
}
