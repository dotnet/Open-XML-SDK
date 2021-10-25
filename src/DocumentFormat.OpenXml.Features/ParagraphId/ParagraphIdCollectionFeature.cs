// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
    internal class ParagraphIdCollectionFeature : IParagraphIdCollectionFeature
    {
        private const int DefaultSize = 20;

        private readonly HashSet<string> _set;

        public ParagraphIdCollectionFeature(HashSet<string> set)
        {
            _set = set;
        }

        internal static HashSet<string> CreateSet(int? count = DefaultSize)
#if NET5_0_OR_GREATER
            => new(count ?? DefaultSize, StringComparer.OrdinalIgnoreCase);
#else
            => new(StringComparer.OrdinalIgnoreCase);
#endif

        public static IParagraphIdCollectionFeature CreateSnapshot(IParagraphIdCollectionFeature other)
        {
            var set = CreateSet(other.Count);

            set.UnionWith(other);

            return new ParagraphIdCollectionFeature(set);
        }

        public int Count => _set.Count;

        public bool Contains(string id) => _set.Contains(id);

        public IEnumerator<string> GetEnumerator() => _set.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
