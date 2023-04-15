// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// An implementation that is used to provide information for strongly typed <see cref="OpenXmlPart"/>.
/// </summary>
internal abstract class TypedPartFeatureCollection : PartFeatureCollection,
    IPartConstraintFeature,
    IKnownDataPartFeature
{
    protected TypedPartFeatureCollection(OpenXmlPart part)
        : base(part)
    {
    }

    IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => Enumerable.Empty<PartConstraintRule>();

    bool IKnownDataPartFeature.IsKnown(string relationshipId) => false;

    bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule)
    {
        rule = default;
        return false;
    }
}
