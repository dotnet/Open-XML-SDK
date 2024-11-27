// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    [DebuggerDisplay("{QName,nq}")]
    internal sealed class ElementFactory
    {
        private readonly Func<OpenXmlElement> _factory;

        public ElementFactory(in OpenXmlType type, Func<OpenXmlElement> factory)
        {
            Type = type;
            _factory = factory;
        }

        public OpenXmlType Type { get; }

        public OpenXmlElement Create() => _factory();

        public static ElementFactory Create<T>()
            where T : OpenXmlElement, new()
        {
            var instance = new T();

            return new ElementFactory(instance.Metadata.Type, static () => new T());
        }
    }
}
