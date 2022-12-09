// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features;

internal interface IPartConstraintFeature
{
    bool TryGetRule(string relationshipId, out PartConstraintRule rule);

    IEnumerable<PartConstraintRule> Rules { get; }
}
