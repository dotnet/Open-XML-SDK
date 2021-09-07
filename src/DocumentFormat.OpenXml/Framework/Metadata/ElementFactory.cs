// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    [DebuggerDisplay("{Namespace}:{Name}")]
    internal sealed class ElementFactory
    {
        private readonly Func<OpenXmlElement> _factory;

        public ElementFactory(Type? type, in OpenXmlQualifiedName qname, Func<OpenXmlElement> factory)
        {
            Type = type;
            QName = qname;
            _factory = factory;
        }

        public Type? Type { get; }

        public OpenXmlQualifiedName QName { get; }

        public OpenXmlElement Create() => _factory();

        public static ElementFactory Create<T>()
            where T : OpenXmlElement, new()
        {
            var instance = new T();

            return new ElementFactory(typeof(T), instance.Metadata.QName, static () => new T());
        }

        public static ElementFactory Create(Type type, Func<OpenXmlElement> factory)
        {
            var instance = factory();

            return new ElementFactory(type, instance.Metadata.QName, factory);
        }
    }
}
