// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.Reflection;

namespace DocumentFormat.OpenXml.Framework
{
    internal class DefaultServices : IServiceProvider
    {
        public static IServiceProvider Instance { get; } = new DefaultServices();

        private readonly Lazy<IRootElementFactory> _rootElementFactory = new(() => new ReflectionBasedRootElementFactory(typeof(ReflectionBasedRootElementFactory).GetTypeInfo().Assembly, ClassActivator<OpenXmlElement>.CreateActivator));

        public object? GetService(Type serviceType)
        {
            if (serviceType == typeof(IRootElementFactory))
            {
                return _rootElementFactory.Value;
            }

            return null;
        }
    }
}
