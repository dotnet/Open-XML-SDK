// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    internal class ElementSchemaLookup
    {
        private static readonly ElementSchemaLookup Empty = new ElementSchemaLookup(null);

        private readonly List<ElementInfo> _lookup;

        private ElementSchemaLookup(List<ElementInfo> lookup)
        {
            _lookup = lookup;
        }

        public OpenXmlElement Create(byte id, string name)
        {
            if (_lookup == null)
            {
                return null;
            }

            // This is on a hot-path and using a dictionary adds substantial time to the lookup. Most child lists are small, so using a sorted
            // list to store them with a binary search improves overall performance.
            var idx = _lookup.BinarySearch(new ElementInfo(id, name), ElementInfoComparer.Instance);

            if (idx < 0)
            {
                return null;
            }

            return _lookup[idx].Create();
        }

        public static ElementSchemaLookup CreateLookup(Type type, PackageCache cache)
        {
            List<ElementInfo> lookup = null;

            foreach (var child in GetChildTypes(type))
            {
                if (lookup == null)
                {
                    lookup = new List<ElementInfo>();
                }

                var schema = child.GetTypeInfo().GetCustomAttribute<SchemaAttrAttribute>();

                if (schema == null)
                {
                    throw new InvalidOperationException($"{child} does not contain schema information");
                }

                var key = new ElementInfo(schema.NamespaceId, schema.Tag, cache.GetElementFactory(child));

                lookup.Add(key);
            }

            if (lookup == null)
            {
                return Empty;
            }

            lookup.Sort(ElementInfoComparer.Instance);

            return new ElementSchemaLookup(lookup);
        }

        private static IEnumerable<Type> GetChildTypes(Type type)
        {
            if (typeof(OpenXmlPartReader) == type)
            {
#if NETSTANDARD1_3
                var types = typeof(OpenXmlPartRootElement).GetTypeInfo().Assembly.DefinedTypes;
#else
                var types = typeof(OpenXmlPartRootElement).Assembly.GetTypes();
#endif

                foreach (var elementType in types)
                {
                    if (!elementType.IsAbstract && typeof(OpenXmlPartRootElement).GetTypeInfo().IsAssignableFrom(elementType))
                    {
#if NETSTANDARD1_3
                        yield return elementType.AsType();
#else
                        yield return elementType;
#endif
                    }
                }
            }
            else
            {
                // We need to include inherited attributes as some of the elements are abstract bases that other
                // elements build on top of.
                foreach (var attribute in type.GetTypeInfo().GetCustomAttributes(inherit: true))
                {
                    if (attribute is ChildElementInfoAttribute child)
                    {
                        yield return child.ElementType;
                    }
                }
            }
        }

        private class ElementInfoComparer : IComparer<ElementInfo>
        {
            public static IComparer<ElementInfo> Instance { get; } = new ElementInfoComparer();

            private ElementInfoComparer()
            {
            }

            public int Compare(ElementInfo x, ElementInfo y)
            {
                var nsCompare = x.Namespace.CompareTo(y.Namespace);

                if (nsCompare != 0)
                {
                    return nsCompare;
                }

                return string.CompareOrdinal(x.Name, y.Name);
            }
        }

        private readonly struct ElementInfo
        {
            private readonly Func<OpenXmlElement> _activator;

            public ElementInfo(byte ns, string name)
                : this(ns, name, null)
            {
            }

            public ElementInfo(byte ns, string name, Func<OpenXmlElement> activator)
            {
                Namespace = ns;
                Name = name;

                _activator = activator;
            }

            public byte Namespace { get; }

            public string Name { get; }

            public OpenXmlElement Create() => _activator();

            public override string ToString()
            {
                return $"{Namespace}:{Name}";
            }
        }
    }
}
