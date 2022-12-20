// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    /// <summary>
    /// A lookup that identifies properties on an <see cref="OpenXmlElement"/> and caches the schema information
    /// from those elements.
    /// </summary>
    internal class ElementFactoryCollection
    {
        public static readonly ElementFactoryCollection Empty = new(Enumerable.Empty<ElementFactory>());

        private readonly ElementFactory[] _data;

        public ElementFactoryCollection(IEnumerable<ElementFactory> lookup)
        {
            var array = lookup.ToArray();

            Array.Sort(array, ElementChildNameComparer.Instance);

            _data = array;
        }

        public int Count => _data.Length;

        public IEnumerable<ElementFactory> Elements => _data;

        public OpenXmlElement? Create(in OpenXmlQualifiedName qname)
        {
            if (_data.Length == 0)
            {
                return null;
            }

            // This is on a hot-path and using a dictionary adds substantial time to the lookup. Most child lists are small, so using a sorted
            // list to store them with a binary search improves overall performance.
            var idx = Array.BinarySearch(_data, new ElementFactory(null, qname, null!), ElementChildNameComparer.Instance);

            if (idx < 0)
            {
                return null;
            }

            return _data[idx].Create();
        }

        private class ElementChildNameComparer : IComparer<ElementFactory>
        {
            public static IComparer<ElementFactory> Instance { get; } = new ElementChildNameComparer();

            private ElementChildNameComparer()
            {
            }

            public int Compare(ElementFactory? x, ElementFactory? y)
            {
                if (x is null && y is null)
                {
                    return 0;
                }

                if (x is null)
                {
                    return -1;
                }

                if (y is null)
                {
                    return 1;
                }

                return x.QName.CompareTo(y.QName);
            }
        }
    }
}
