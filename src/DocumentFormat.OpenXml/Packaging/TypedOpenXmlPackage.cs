// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.ComponentModel;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// An implementation of <see cref="OpenXmlPackage"/> that provides strongly-typed services.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class TypedOpenXmlPackage : OpenXmlPackage
{
    [Obsolete(DoNotUseParameterlessConstructor)]
    private protected TypedOpenXmlPackage()
    {
    }

    private protected TypedOpenXmlPackage(in PackageLoader package, OpenSettings settings)
        : base(package, settings)
    {
    }

    internal override IFeatureCollection CreatePartFeatures(IFeatureCollection? other = null) => new TypedPartFeatures(other);

    private class TypedPartFeatures : PartContainerFeatureCollection
    {
        public TypedPartFeatures(IFeatureCollection? other = null)
            : base(other)
        {
        }

        protected override IFeatureCollection Default => TypedFeatures.Shared;
    }
}
