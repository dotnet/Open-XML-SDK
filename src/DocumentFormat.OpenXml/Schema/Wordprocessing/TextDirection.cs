// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class TextDirection
    {
        private const string StrictTranslationLocalName = "val";

        private static readonly Dictionary<string, string> AttributeMap = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "lr", "btLr" },
            { "tb", "lrTb" },
            { "tbV", "lrTbV" },
            { "lrV", "tbLrV" },
            { "rl", "tbRl" },
            { "rlV", "tbRlV" },
        };

        /// <remarks>
        /// See §14.11.7 of ISO/IEC 29500-4 for details on this translation
        /// </remarks>
        private protected override bool StrictTranslateAttribute(in OpenXmlQualifiedName qname, string? value)
        {
            if (string.Equals(StrictTranslationLocalName, qname.Name, StringComparison.Ordinal) && value is not null && AttributeMap.TryGetValue(value, out var result))
            {
                value = result;
            }

            return base.StrictTranslateAttribute(qname, value);
        }
    }
}
