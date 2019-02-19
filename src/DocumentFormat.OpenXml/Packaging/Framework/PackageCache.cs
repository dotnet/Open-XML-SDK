// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;

#if NO_CONCURRENT_COLLECTIONS
using System.Collections.Generic;
#else
using System.Collections.Concurrent;
#endif

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// A cache to hold elements that are relatively expensive to create. Common items held here are reflection related, including objects that hold data parsed from
    /// attributes on a type/property/etc or a generated method via expressions.
    /// </summary>
    /// <remarks>
    /// This class is threadsafe. However, the performance on .NET 3.5 may be lower than elsewhere due to the lack of true concurrent collections and thus resorting to
    /// locking on any retrieval/creation. On all other platforms, a concurrent dictionary is used which is much more performant.
    /// </remarks>
    internal class PackageCache
    {
        private readonly TypeConcurrentDictionary<ElementTypeInfo> _typeConstraintInfoCache = new TypeConcurrentDictionary<ElementTypeInfo>();
        private readonly TypeConcurrentDictionary<PartConstraintCollection> _partConstraints = new TypeConcurrentDictionary<PartConstraintCollection>();
        private readonly TypeConcurrentDictionary<PartConstraintCollection> _dataPartConstraints = new TypeConcurrentDictionary<PartConstraintCollection>();
        private readonly TypeConcurrentDictionary<ReadOnlyArray<ElementProperty<OpenXmlSimpleType>>> _attributes = new TypeConcurrentDictionary<ReadOnlyArray<ElementProperty<OpenXmlSimpleType>>>();
        private readonly TypeConcurrentDictionary<ReadOnlyArray<ElementProperty<OpenXmlElement>>> _elements = new TypeConcurrentDictionary<ReadOnlyArray<ElementProperty<OpenXmlElement>>>();
        private readonly TypeConcurrentDictionary<Func<OpenXmlSimpleType>> _simpleTypeFactory = new TypeConcurrentDictionary<Func<OpenXmlSimpleType>>();
        private readonly TypeConcurrentDictionary<Func<OpenXmlElement>> _elementFactory = new TypeConcurrentDictionary<Func<OpenXmlElement>>();
        private readonly TypeConcurrentDictionary<ElementSchemaLookup> _factory = new TypeConcurrentDictionary<ElementSchemaLookup>();

        public static PackageCache Cache { get; } = new PackageCache();

        public ElementTypeInfo GetElementTypeInfo(Type type) => _typeConstraintInfoCache.GetOrAdd(type, ElementTypeInfo.Create);

        public PartConstraintCollection GetPartConstraints(Type type) => _partConstraints.GetOrAdd(type, CreatePartConstraints);

        public PartConstraintCollection GetDataPartConstraints(Type type) => _dataPartConstraints.GetOrAdd(type, CreateDataPartConstraints);

        public ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> GetAttributes(Type type) => _attributes.GetOrAdd(type, CreateAttributes);

        public ReadOnlyArray<ElementProperty<OpenXmlElement>> GetElements(Type type) => _elements.GetOrAdd(type, CreateElements);

        public OpenXmlElement CreateElement(Type type, byte ns, string name) => _factory.GetOrAdd(type, CreateLookup).Create(ns, name);

        public OpenXmlElement CreateElement(Type type) => GetFactory<OpenXmlElement>(type)();

        public Func<T> GetFactory<T>(Type type)
        {
            if (typeof(T) == typeof(OpenXmlSimpleType))
            {
                return (Func<T>)(object)_simpleTypeFactory.GetOrAdd(type, ClassActivator<OpenXmlSimpleType>.CreateActivator);
            }
            else if (typeof(T) == typeof(OpenXmlElement))
            {
                return (Func<T>)(object)_elementFactory.GetOrAdd(type, ClassActivator<OpenXmlElement>.CreateActivator);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(T));
            }
        }

        private ElementSchemaLookup CreateLookup(Type type) => ElementSchemaLookup.CreateLookup(type, this);

        private ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> CreateAttributes(Type type) => ElementPropertyCollection.GetProperties(this, type);

        private ReadOnlyArray<ElementProperty<OpenXmlElement>> CreateElements(Type type) => ElementPropertyCollection.GetElements(this, type);

        private PartConstraintCollection CreatePartConstraints(Type type) => PartConstraintCollection.Create<PartConstraintAttribute>(this, type);

        private PartConstraintCollection CreateDataPartConstraints(Type type) => PartConstraintCollection.Create<DataPartConstraintAttribute>(this, type);

#if NO_CONCURRENT_COLLECTIONS
        private sealed class TypeConcurrentDictionary<TValue>
        {
            private readonly Dictionary<Type, TValue> _dictionary = new Dictionary<Type, TValue>();

            public TValue GetOrAdd(Type type, Func<Type, TValue> create)
            {
                lock (_dictionary)
                {
                    if (!_dictionary.TryGetValue(type, out var result))
                    {
                        result = create(type);
                        _dictionary[type] = result;
                    }

                    return result;
                }
            }
        }
#else
        private sealed class TypeConcurrentDictionary<TValue> : ConcurrentDictionary<Type, TValue>
        {
        }
#endif
    }
}
