// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml;

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly struct ElementProperty<T>
    {
        private readonly ElementPropertyAccessor<T> _accessor;

        internal ElementProperty(
            byte namespaceId,
            string name,
            int order,
            ElementPropertyAccessor<T> accessor)
        {
            _accessor = accessor;

            Order = order;
            Name = name;
            NamespaceId = namespaceId;
        }

        public bool IsValid => Name != null;

        public int Order { get; }

        public string Name { get; }

        public byte NamespaceId { get; }

        public string Namespace => NamespaceIdMap.GetNamespaceUri(NamespaceId);

        public string NamespacePrefix => NamespaceIdMap.GetNamespacePrefix(NamespaceId);

        public T GetValue(OpenXmlElement element) => _accessor.Get(element);

        public void SetValue(OpenXmlElement element, T value) => _accessor.Set(element, value);

        public T CreateNew() => _accessor.Create();

        public XmlQualifiedName GetQName() => new XmlQualifiedName(Name, Namespace);
    }
}
