// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class Document
    {
        private protected override bool StrictTranslateAttribute(string namespaceUri, string localName, string value)
        {
            if (string.Equals("conformance", localName, StringComparison.Ordinal)
                && string.Equals("strict", value, StringComparison.Ordinal))
            {
                return true;
            }

            return base.StrictTranslateAttribute(namespaceUri, localName, value);
        }
    }
}
