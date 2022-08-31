// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;
using System.ComponentModel;

namespace DocumentFormat.OpenXml;

/// <summary>
/// An implementation of <see cref="OpenXmlPartRootElement"/> that provides strongly-typed services.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class TypedOpenXmlPartRootElement : OpenXmlPartRootElement
{
    private protected TypedOpenXmlPartRootElement()
    {
    }

    private protected TypedOpenXmlPartRootElement(IEnumerable<OpenXmlElement> elements)
        : base(elements)
    {
    }

    private protected TypedOpenXmlPartRootElement(OpenXmlPart part)
        : base(part)
    {
    }

    private protected TypedOpenXmlPartRootElement(string outerXml)
        : base(outerXml)
    {
    }

    private protected override IFeatureCollection CreateFeatures() => TypedOpenXmlElement.GetTypedElementFeatures(this);
}
