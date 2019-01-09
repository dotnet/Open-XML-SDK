// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    internal readonly struct AttributeTag
    {
        private readonly Func<OpenXmlSimpleType> _factory;
        private readonly Func<OpenXmlElement, OpenXmlSimpleType> _getter;
        private readonly Action<OpenXmlElement, OpenXmlSimpleType> _setter;

        internal AttributeTag(
            byte namespaceId,
            string name,
            Func<OpenXmlElement, OpenXmlSimpleType> getter,
            Action<OpenXmlElement, OpenXmlSimpleType> setter,
            Func<OpenXmlSimpleType> factory)
        {
            _factory = factory;
            _getter = getter;
            _setter = setter;

            Name = name;
            NamespaceId = namespaceId;
        }

        public string Name { get; }

        public byte NamespaceId { get; }

        public string Namespace => NamespaceIdMap.GetNamespaceUri(NamespaceId);

        public string NamespacePrefix => NamespaceIdMap.GetNamespacePrefix(NamespaceId);

        public OpenXmlSimpleType GetValue(OpenXmlElement element) => _getter(element);

        public void SetValue(OpenXmlElement element, OpenXmlSimpleType value) => _setter(element, value);

        public OpenXmlSimpleType CreateNew() => _factory();

        public XmlQualifiedName GetQName() => new XmlQualifiedName(Name, Namespace);
    }
}
