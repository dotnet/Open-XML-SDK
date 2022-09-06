// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System.ComponentModel;

namespace DocumentFormat.OpenXml;

/// <summary>
/// An implementation of <see cref="OpenXmlElement"/> that provides strongly-typed services.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class TypedOpenXmlElement : OpenXmlElement
{
    private protected TypedOpenXmlElement()
        : base()
    {
    }

    private protected TypedOpenXmlElement(string outerXml)
        : base(outerXml)
    {
    }

    private protected override IFeatureCollection CreateFeatures() => GetTypedElementFeatures(this);

    internal static IFeatureCollection GetTypedElementFeatures(OpenXmlElement owner) => new TypedElementFeatures(owner);

    private sealed class TypedElementFeatures : ElementFeatureCollection
    {
        public TypedElementFeatures(OpenXmlElement owner)
            : base(owner)
        {
        }

        public override IFeatureCollection Default => TypedFeatures.Shared;
    }
}
