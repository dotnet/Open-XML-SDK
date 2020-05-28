// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Concurrent;

namespace DocumentFormat.OpenXml.Framework
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
        private readonly TypeConcurrentDictionary<Func<OpenXmlSimpleType>> _simpleTypeFactory = new TypeConcurrentDictionary<Func<OpenXmlSimpleType>>();
        private readonly TypeConcurrentDictionary<Func<OpenXmlElement>> _elementFactory = new TypeConcurrentDictionary<Func<OpenXmlElement>>();
        private readonly TypeConcurrentDictionary<OpenXmlPartData> _partData = new TypeConcurrentDictionary<OpenXmlPartData>();

        public static PackageCache Cache { get; } = new PackageCache();

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

        /// <summary>
        /// Extract the part constraints from a given container.
        /// </summary>
        public OpenXmlPartData ParsePartData(OpenXmlPartContainer part) => _partData.GetOrAdd(part.GetType(), CreatePartData);

        private OpenXmlPartData CreatePartData(Type type) => new OpenXmlPartData(type);

        private sealed class TypeConcurrentDictionary<TValue> : ConcurrentDictionary<Type, TValue>
        {
        }
    }
}
