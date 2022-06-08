// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ReflectionBasedRootElementFactory : IRootElementFactory
    {
        private readonly Lazy<ElementFactoryCollection> _factoryCollection;

        public ReflectionBasedRootElementFactory()
            : this(typeof(ReflectionBasedRootElementFactory).GetTypeInfo().Assembly, ClassActivator<OpenXmlElement>.CreateActivator)
        {
        }

        public ReflectionBasedRootElementFactory(Assembly assembly, Func<Type, Func<OpenXmlElement>> activatorFactory)
        {
            _factoryCollection = new Lazy<ElementFactoryCollection>(() => CreatePartLookup(assembly, activatorFactory), isThreadSafe: true);
        }

        private static ElementFactoryCollection CreatePartLookup(Assembly assembly, Func<Type, Func<OpenXmlElement>> activatorFactory)
        {
            List<ElementFactory>? lookup = null;

            foreach (var child in GetAllRootElements(assembly))
            {
                if (lookup is null)
                {
                    lookup = new List<ElementFactory>();
                }

                var key = ElementFactory.Create(child, activatorFactory(child));

                lookup.Add(key);
            }

            if (lookup is null)
            {
                return ElementFactoryCollection.Empty;
            }

            return new ElementFactoryCollection(lookup);
        }

        private static IEnumerable<Type> GetAllRootElements(Assembly assembly)
        {
            var types = assembly.GetTypes();

            foreach (var elementType in types)
            {
                if (!elementType.GetTypeInfo().IsAbstract && typeof(OpenXmlPartRootElement).GetTypeInfo().IsAssignableFrom(elementType.GetTypeInfo()))
                {
                    yield return elementType;
                }
            }
        }

        public ElementFactoryCollection Collection => _factoryCollection.Value;

        public bool TryCreate(in OpenXmlQualifiedName qname, [NotNullWhen(true)] out OpenXmlElement? element)
        {
            element = _factoryCollection.Value.Create(in qname);
            return element is not null;
        }
    }
}
