// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;

namespace DocumentFormat.OpenXml.Framework
{
    internal abstract class AttributeMetadata
    {
        public XmlQualifiedName TypeName => Validators.GetSimpleTypeQualifiedName(Type);

        public abstract string PropertyName { get; }

        public abstract string Name { get; }

        public abstract byte NamespaceId { get; }

        public abstract ValidatorCollection Validators { get; }

        public string Namespace => NamespaceIdMap.GetNamespaceUri(NamespaceId);

        public string NamespacePrefix => NamespaceIdMap.GetNamespacePrefix(NamespaceId);

        public abstract OpenXmlSimpleType GetValue(OpenXmlElement element);

        public abstract void SetValue(OpenXmlElement element, OpenXmlSimpleType value);

        public abstract OpenXmlSimpleType CreateNew();

        public abstract Type Type { get; }

        public XmlQualifiedName GetQName() => new XmlQualifiedName(Name, Namespace);
    }
}
