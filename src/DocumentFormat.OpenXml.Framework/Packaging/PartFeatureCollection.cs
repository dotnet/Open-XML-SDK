// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging;

internal partial class PartFeatureCollection :
    FeatureCollectionBase,
    ITargetFeature,
    IPartConstraintFeature,
    IContentTypeFeature,
    IKnownDataPartFeature,
    IDisposableFeature,
    IContainerDisposableFeature
{
    private readonly OpenXmlPart _part;
    private Action? _disposable;
    private AnnotationsFeature? _annotationsFeature;

    public PartFeatureCollection(OpenXmlPart part)
    {
        _part = part;
    }

    protected override IFeatureCollection? Parent => _part?._openXmlPackage?.Features;

    string ITargetFeature.Path => ".";

    string ITargetFeature.Extension => ".xml";

    string ITargetFeature.Name => string.Empty;

    protected override object? GetKnown(Type key)
    {
        if (key == typeof(AnnotationsFeature))
        {
            return _annotationsFeature ??= new();
        }

        return null;
    }

    protected override IEnumerable<Type> KnownTypes => new[] { typeof(AnnotationsFeature) };

    IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => Enumerable.Empty<PartConstraintRule>();

    bool IContentTypeFeature.IsConstant => _part is IFixedContentTypePart;

    bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule)
    {
        rule = default;
        return false;
    }

    bool IKnownDataPartFeature.IsKnown(string relationshipId) => false;

    void IDisposableFeature.Register(Action disposable) => _disposable = disposable + _disposable;

    void IContainerDisposableFeature.Dispose()
    {
        _disposable?.Invoke();
        _disposable = null;
    }
}
