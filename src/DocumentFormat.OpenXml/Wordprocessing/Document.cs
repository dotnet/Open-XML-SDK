// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class Document
    {
        private protected override bool StrictTranslateAttribute(in OpenXmlQualifiedName qname, string? value)
        {
            if (string.Equals("conformance", qname.Name, StringComparison.Ordinal)
                && string.Equals("strict", value, StringComparison.Ordinal))
            {
                return true;
            }

            return base.StrictTranslateAttribute(qname, value);
        }
    }
}
