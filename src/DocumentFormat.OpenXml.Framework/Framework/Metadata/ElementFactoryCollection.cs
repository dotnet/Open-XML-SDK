// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Metadata;

/// <summary>
/// A lookup that identifies properties on an <see cref="OpenXmlElement"/> and caches the schema information
/// from those elements.
/// </summary>
internal class ElementFactoryCollection
{
    public static readonly ElementFactoryCollection Empty = new([]);

    private readonly List<ElementFactory> _data;

    public ElementFactoryCollection(List<ElementFactory> lookup)
    {
        lookup.Sort(ElementChildNameComparer.Instance);
        _data = lookup;
    }

    public OpenXmlElement? Create(in OpenXmlQualifiedName qname)
    {
        if (_data.Count == 0)
        {
            return null;
        }

        // This is on a hot-path and using a dictionary adds substantial time to the lookup. Most child lists are small, so using a sorted
        // list to store them with a binary search improves overall performance.
        var idx = _data.BinarySearch(new ElementFactory(new(qname, default), null!), ElementChildNameComparer.Instance);

        if (idx < 0)
        {
            return null;
        }

        return _data[idx].Create();
    }

    private sealed class ElementChildNameComparer : IComparer<ElementFactory>
    {
        public static IComparer<ElementFactory> Instance { get; } = new ElementChildNameComparer();

        public int Compare(ElementFactory x, ElementFactory y) => x.Type.Name.CompareTo(y.Type.Name);
    }
}
