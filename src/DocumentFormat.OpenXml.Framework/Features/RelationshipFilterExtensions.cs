// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features;

internal static class RelationshipFilterExtensions
{
    internal static void IgnoreRelationship(this OpenXmlPackage package, string relationshipType)
    {
        if (package.Features.Get<Relationships>() is not { } relationships)
        {
            relationships = new() { relationshipType };
            var filter = package.Features.GetRequired<IRelationshipFilterFeature>();

            filter.AddFilter(r =>
            {
                if (relationships.Contains(r.RelationshipType))
                {
                    r.IsRemoved = true;
                }
            });
        }

        relationships.Add(relationshipType);
    }

    private sealed class Relationships : HashSet<string>
    {
        public Relationships()
            : base(StringComparer.OrdinalIgnoreCase)
        {
        }
    }
}
