// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Xml;

namespace DocumentFormat.OpenXml.Framework
{
    /// <summary>
    /// A lookup that identifies properties on an <see cref="OpenXmlElement"/> and caches the schema information
    /// from those elements (identified by the <see cref="SchemaAttrAttribute"/> on the property type.
    /// </summary>
    internal class ElementLookup : IEnumerable<XmlQualifiedName>
    {
        private static readonly ElementLookup Empty = new ElementLookup(null);

        private readonly List<ElementInfo> _lookup;

        private ElementLookup(List<ElementInfo> lookup)
        {
            _lookup = lookup;
        }

        public int Count => _lookup?.Count ?? 0;

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

        public static ElementLookup CreateLookup(Type type, Func<Type, Func<OpenXmlElement>> activatorFactory)
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

                var key = new ElementInfo(schema.NamespaceId, schema.Tag, activatorFactory(child));

                lookup.Add(key);
            }

            if (lookup == null)
            {
                return Empty;
            }

            lookup.Sort(ElementInfoComparer.Instance);

            return new ElementLookup(lookup);
        }

        /// <summary>
        /// Gets the elements that can be created for a given type. If <paramref name="type"/> is <see cref="OpenXmlPartRootElement"/> this will return
        /// all the root elements contained in the assembly.
        /// </summary>
        /// <param name="type">The type to return child types.</param>
        /// <returns>A collection of types that the supplied type can create.</returns>
        private static IEnumerable<Type> GetChildTypes(Type type)
        {
            if (typeof(OpenXmlPartRootElement) == type)
            {
                return GetAllRootElements(type);
            }
            else
            {
                return GetElementChildTypes(type);
            }
        }

        private static IEnumerable<Type> GetAllRootElements(Type type)
        {
            var types = type.GetTypeInfo().Assembly.GetTypes();

            foreach (var elementType in types)
            {
                if (!elementType.GetTypeInfo().IsAbstract && type.GetTypeInfo().IsAssignableFrom(elementType.GetTypeInfo()))
                {
                    yield return elementType;
                }
            }
        }

        private static IEnumerable<Type> GetElementChildTypes(Type type)
        {
            // We need to include inherited attributes as some of the elements are abstract bases that other
            // elements build on top of.
            foreach (var attribute in type.GetTypeInfo().GetCustomAttributes(inherit: true))
            {
                if (attribute is ChildElementInfoAttribute child)
                {
                    if (!typeof(OpenXmlElement).GetTypeInfo().IsAssignableFrom(child.ElementType.GetTypeInfo()))
                    {
                        throw new InvalidOperationException($"{child} must derive from OpenXmlElement");
                    }

                    yield return child.ElementType;
                }
            }
        }

        public IEnumerator<XmlQualifiedName> GetEnumerator() => Names().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private IEnumerable<XmlQualifiedName> Names()
        {
            if (_lookup != null)
            {
                foreach (var item in _lookup)
                {
                    yield return new XmlQualifiedName(item.Name, NamespaceIdMap.GetNamespaceUri(item.Namespace));
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

        [DebuggerDisplay("{Namespace}:{Name}")]
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
        }
    }
}
