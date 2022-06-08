// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
    internal class MiscAttrContainer
    {
        internal List<OpenXmlAttribute>? ExtendedAttributesField { get; set; }

        internal MarkupCompatibilityAttributes? McAttributes { get; set; }

        internal List<KeyValuePair<string, string>>? NsMappings { get; set; }
    }
}
