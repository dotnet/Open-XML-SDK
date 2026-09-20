// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// State that most elements do not have. It is kept out of <see cref="OpenXmlElement"/> so that each element,
    /// of which a large document may have millions, only pays for a single reference to it.
    /// </summary>
    internal sealed class RareElementState
    {
        internal IFeatureCollection? Features { get; set; }

        internal string? RawOuterXml { get; set; }

        internal List<OpenXmlAttribute>? ExtendedAttributesField { get; set; }

        internal MarkupCompatibilityAttributes? McAttributes { get; set; }

        internal List<KeyValuePair<string, string>>? NsMappings { get; set; }
    }
}
