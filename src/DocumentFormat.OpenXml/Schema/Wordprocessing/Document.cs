// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Framework;
using System;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class Document
    {
        private protected override bool StrictTranslateAttribute(in OpenXmlQualifiedName qname, string? value)
        {
            if (string.Equals("conformance", qname.Name, StringComparison.Ordinal) &&
                string.Equals("strict", value, StringComparison.Ordinal))
            {
                return true;
            }

            return base.StrictTranslateAttribute(qname, value);
        }
    }
}
