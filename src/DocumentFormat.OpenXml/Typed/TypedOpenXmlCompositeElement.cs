// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DocumentFormat.OpenXml;

/// <summary>
/// An implementation of <see cref="OpenXmlCompositeElement"/> that provides strongly-typed services.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class TypedOpenXmlCompositeElement : OpenXmlCompositeElement
{
    private protected TypedOpenXmlCompositeElement()
    {
    }

    private protected TypedOpenXmlCompositeElement(IEnumerable<OpenXmlElement> elements)
        : base(elements)
    {
    }

    private protected TypedOpenXmlCompositeElement(string outerXml)
        : base(outerXml)
    {
    }

    [Obsolete(UseGenericVersion)]
    private protected TypedOpenXmlCompositeElement(IEnumerable elements)
        : base(elements)
    {
    }

    private protected override IFeatureCollection CreateFeatures() => TypedOpenXmlElement.GetTypedElementFeatures(this);
}
