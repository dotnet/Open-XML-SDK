// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging;

public abstract partial class OpenXmlPart
{
    private protected partial class PartFeatureCollection :
        IFeatureCollection,
        IContainerFeature<OpenXmlPart>,
        ITargetFeature,
        IPartConstraintFeature,
        IKnownDataPartFeature
    {
        private readonly OpenXmlPart _part;

        private FeatureContainer _container;

        public PartFeatureCollection(OpenXmlPart part)
        {
            _part = part;
        }

        public bool IsReadOnly => false;

        public int Revision => _container.Revision + (Parent?.Revision ?? 0);

        OpenXmlPart IContainerFeature<OpenXmlPart>.Value => _part;

        private IFeatureCollection? Parent => _part?._openXmlPackage?.Features;

        string ITargetFeature.Path => ".";

        string ITargetFeature.Extension => ".xml";

        string ITargetFeature.Name => string.Empty;

        public TFeature? Get<TFeature>()
        {
            if (_container.Get<TFeature>() is { } other)
            {
                return other;
            }

            if (this is TFeature @this)
            {
                return @this;
            }

            if (GetInternal<TFeature>() is { } @internal)
            {
                return @internal;
            }

            if (Parent is { } parent && parent.Get<TFeature>() is { } fromParent)
            {
                return fromParent;
            }

            return default;
        }

        [KnownFeature(typeof(AnnotationsFeature))]
        private partial T? GetInternal<T>();

        public void Set<TFeature>(TFeature? instance)
            => _container.Set(instance);

        IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => Enumerable.Empty<PartConstraintRule>();

        bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule)
        {
            rule = default;
            return false;
        }

        bool IKnownDataPartFeature.IsKnown(string relationshipId) => false;
    }
}
