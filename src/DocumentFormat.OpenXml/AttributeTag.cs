// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    [DebuggerDisplay("{Namespace,nq}:{Name,nq}")]
    internal readonly struct AttributeTag
    {
        private readonly Func<OpenXmlSimpleType> _factory;

        private AttributeTag(byte namespaceId, string name, Func<OpenXmlSimpleType> factory)
        {
            _factory = factory;

            Name = name;
            NamespaceId = namespaceId;
        }

        public static AttributeTag Create<T>(byte namespaceId, string name)
            where T : OpenXmlSimpleType, new()
        {
            return new AttributeTag(namespaceId, name, Cached.Activator<T, OpenXmlSimpleType>());
        }

        public string Name { get; }

        public byte NamespaceId { get; }

        public string Namespace => NamespaceIdMap.GetNamespaceUri(NamespaceId);

        public string NamespacePrefix => NamespaceIdMap.GetNamespacePrefix(NamespaceId);

        public OpenXmlSimpleType CreateNew() => _factory();

        public XmlQualifiedName GetQName() => new XmlQualifiedName(Name, Namespace);
    }
}
