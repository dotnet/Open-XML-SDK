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
        private readonly ConcurrentDictionary<Type, ElementTypeInfo> _typeConstraintInfoCache = new ConcurrentDictionary<Type, ElementTypeInfo>();
        private readonly ConcurrentDictionary<Type, PartConstraintCollection> _partConstraints = new ConcurrentDictionary<Type, PartConstraintCollection>();
        private readonly ConcurrentDictionary<Type, PartConstraintCollection> _dataPartConstraints = new ConcurrentDictionary<Type, PartConstraintCollection>();
        private readonly ConcurrentDictionary<Type, ReadOnlyArray<AttributeTag>> _attributes = new ConcurrentDictionary<Type, ReadOnlyArray<AttributeTag>>();
        private readonly ConcurrentDictionary<Type, Func<OpenXmlSimpleType>> _simpleTypeFactory = new ConcurrentDictionary<Type, Func<OpenXmlSimpleType>>();

        public static PackageCache Cache { get; } = new PackageCache();

        public ElementTypeInfo GetElementTypeInfo(Type type) => _typeConstraintInfoCache.GetOrAdd(type, ElementTypeInfo.Create);

        public PartConstraintCollection GetPartConstraints(Type type) => _partConstraints.GetOrAdd(type, CreatePartConstraints);

        public PartConstraintCollection GetDataPartConstraints(Type type) => _dataPartConstraints.GetOrAdd(type, CreateDataPartConstraints);

        public ReadOnlyArray<AttributeTag> GetAttributes(Type type) => _attributes.GetOrAdd(type, CreateAttributes);

        public Func<OpenXmlSimpleType> GetSimpleTypeFactory(Type type) => _simpleTypeFactory.GetOrAdd(type, ClassActivator<OpenXmlSimpleType>.CreateActivator);

        private ReadOnlyArray<AttributeTag> CreateAttributes(Type type) => AttributeTagCollection.GetAttributes(this, type);

        private PartConstraintCollection CreatePartConstraints(Type type) => PartConstraintCollection.Create<PartConstraintAttribute>(this, type);

        private PartConstraintCollection CreateDataPartConstraints(Type type) => PartConstraintCollection.Create<DataPartConstraintAttribute>(this, type);

#if NO_CONCURRENT_COLLECTIONS
        private sealed class ConcurrentDictionary<TKey, TValue>
        {
            private readonly Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();

            public TValue GetOrAdd(TKey key, Func<TKey, TValue> create)
            {
                lock (_dictionary)
                {
                    if (!_dictionary.TryGetValue(key, out var result))
                    {
                        result = create(key);
                        _dictionary[key] = result;
                    }

                    return result;
                }
            }
        }
#endif
    }
}
