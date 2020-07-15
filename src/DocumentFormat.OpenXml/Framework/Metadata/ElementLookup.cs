// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    /// <summary>
    /// A lookup that identifies properties on an <see cref="OpenXmlElement"/> and caches the schema information
    /// from those elements (identified by the <see cref="SchemaAttrAttribute"/> on the property type.
    /// </summary>
    internal class ElementLookup
    {
        public static ElementLookup Parts { get; } = CreatePartLookup(typeof(OpenXmlPartRootElement), PackageCache.Cache.GetFactory);

        public static readonly ElementLookup Empty = new ElementLookup(Enumerable.Empty<ElementChild>());

        private readonly ElementChild[] _data;

        public ElementLookup(IEnumerable<ElementChild> lookup)
        {
            var array = lookup.ToArray();

            Array.Sort(array, ElementChildNameComparer.Instance);

            _data = array;
        }

        public int Count => _data.Length;

        public IEnumerable<ElementChild> Elements => _data;

        public OpenXmlElement Create(byte id, string name)
        {
            if (_data.Length == 0)
            {
                return null;
            }

            // This is on a hot-path and using a dictionary adds substantial time to the lookup. Most child lists are small, so using a sorted
            // list to store them with a binary search improves overall performance.
            var idx = Array.BinarySearch(_data, new ElementChild(null, id, name), ElementChildNameComparer.Instance);

            if (idx < 0)
            {
                return null;
            }

            return _data[idx].Create();
        }

        private static ElementLookup CreatePartLookup(Type type, Func<Type, Func<OpenXmlElement>> activatorFactory)
        {
            List<ElementChild> lookup = null;

            foreach (var child in GetAllRootElements(type))
            {
                if (lookup == null)
                {
                    lookup = new List<ElementChild>();
                }

                var key = new ActivatorElementChild(child, activatorFactory(child));

                lookup.Add(key);
            }

            if (lookup == null)
            {
                return Empty;
            }

            return new ElementLookup(lookup);
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

        private class ElementChildNameComparer : IComparer<ElementChild>
        {
            public static IComparer<ElementChild> Instance { get; } = new ElementChildNameComparer();

            private ElementChildNameComparer()
            {
            }

            public int Compare(ElementChild x, ElementChild y)
            {
                var nsCompare = x.NamespaceId.CompareTo(y.NamespaceId);

                if (nsCompare != 0)
                {
                    return nsCompare;
                }

                return string.CompareOrdinal(x.Name, y.Name);
            }
        }

        [DebuggerDisplay("{Namespace}:{Name}")]
        public class ElementChild
        {
            public ElementChild(Type type, byte nsId, string name)
            {
                Type = type;
                NamespaceId = nsId;
                Name = name;
            }

            public Type Type { get; }

            public byte NamespaceId { get; }

            public string Namespace => NamespaceIdMap.GetNamespaceUri(NamespaceId);

            public string Name { get; }

            public virtual OpenXmlElement Create() => throw new NotImplementedException();
        }

        private class ActivatorElementChild : ElementChild
        {
            private readonly Func<OpenXmlElement> _activator;

            public ActivatorElementChild(Type child, Func<OpenXmlElement> activator)
                : this(child, GetSchema(child, activator))
            {
                _activator = activator;
            }

            private ActivatorElementChild(Type child, SchemaAttrAttribute schema)
                : base(child, schema.NamespaceId, schema.Tag)
            {
            }

            public override OpenXmlElement Create() => _activator();

            private static SchemaAttrAttribute GetSchema(Type child, Func<OpenXmlElement> activator)
            {
                var schema = child.GetTypeInfo().GetCustomAttribute<SchemaAttrAttribute>();

                if (schema is null)
                {
                    var instance = activator();

                    schema = instance.Metadata.Schema;

                    if (schema is null)
                    {
                        throw new InvalidOperationException($"{child} does not contain schema information");
                    }
                }

                return schema;
            }
        }
    }
}
