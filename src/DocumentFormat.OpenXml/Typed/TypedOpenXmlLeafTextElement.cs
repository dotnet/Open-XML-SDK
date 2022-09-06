// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System.ComponentModel;

namespace DocumentFormat.OpenXml;

/// <summary>
/// An implementation of <see cref="OpenXmlLeafTextElement"/> that provides strongly-typed services.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class TypedOpenXmlLeafTextElement : OpenXmlLeafTextElement
{
    private protected TypedOpenXmlLeafTextElement()
    {
    }

    private protected TypedOpenXmlLeafTextElement(string text)
        : base(text)
    {
    }

    private protected override IFeatureCollection CreateFeatures() => TypedOpenXmlElement.GetTypedElementFeatures(this);
}
