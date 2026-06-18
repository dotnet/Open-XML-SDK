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
            var data = _data;
            if (data.Length == 0)
            {
                return null;
            }

            // This is on a hot-path and using a dictionary adds substantial time to the lookup. Most child lists are small, so use
            // a linear scan for tiny lists and binary search for larger ones. Avoid allocating a temporary ElementFactory lookup key
            // for every element encountered while populating the DOM.
            if (data.Length <= 4)
            {
                for (var i = 0; i < data.Length; i++)
                {
                    if (data[i].Type.Name.Equals(qname))
                    {
                        return data[i].Create();
                    }
                }

                return null;
            }

            var min = 0;
            var max = data.Length - 1;
            while (min <= max)
            {
                var mid = min + ((max - min) >> 1);
                var comparison = data[mid].Type.Name.CompareTo(qname);

                if (comparison == 0)
                {
                    return data[mid].Create();
                }

                if (comparison < 0)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return null;
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

                return x.Type.Name.CompareTo(y.Type.Name);
            }
        }
    }
}
