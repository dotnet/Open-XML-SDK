// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
