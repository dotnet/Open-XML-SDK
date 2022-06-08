// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
    internal class ParagraphIdCollectionFeature : IParagraphIdCollectionFeature
    {
        internal static readonly StringComparer Comparer = StringComparer.OrdinalIgnoreCase;

        private readonly HashSet<string> _set;

        public ParagraphIdCollectionFeature(IEnumerable<string> set)
        {
            _set = new HashSet<string>(set, Comparer);
        }

        public int Count => _set.Count;

        public bool Contains(string id) => _set.Contains(id);

        public IEnumerator<string> GetEnumerator() => _set.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
