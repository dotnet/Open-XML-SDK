// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    internal sealed class PartConstraints : IEnumerable<string>
    {
        private readonly Dictionary<string, PartConstraintRule> _rules = new();

        public void Add(string relationship, string name, string? contentType, bool minOccursIsNonZero, bool maxOccursGreatThanOne, FileFormatVersions versions)
        {
            var info = new PartConstraintRule(relationship, name, contentType, minOccursIsNonZero, maxOccursGreatThanOne, versions);
            _rules.Add(info.RelationshipType, info);
        }

        public IEnumerable<PartConstraintRule> Rules => _rules.Values;

        public bool TryGetRule(string relationshipId, out PartConstraintRule rule)
            => _rules.TryGetValue(relationshipId, out rule);

        public IEnumerator<string> GetEnumerator() => _rules.Keys.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
