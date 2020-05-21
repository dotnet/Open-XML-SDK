// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;

namespace DocumentFormat.OpenXml.Framework
{
    internal abstract class ElementProperty<T>
    {
        public static ElementProperty<T> Create(
            byte namespaceId,
            string name,
            int order,
            ValidatorCollection validators,
            ElementPropertyAccessor<T> accessor)
        {
            return new AccessorElementProperty(namespaceId, name, order, validators, accessor);
        }

        public abstract XmlQualifiedName TypeName { get; }

        public abstract int Order { get; }

        public abstract string Name { get; }

        public abstract byte NamespaceId { get; }

        public abstract ValidatorCollection Validators { get; }

        public abstract string Namespace { get; }

        public abstract string NamespacePrefix { get; }

        public abstract T GetValue(OpenXmlElement element);

        public abstract void SetValue(OpenXmlElement element, T value);

        public abstract T CreateNew();

        public abstract Type Type { get; }

        public abstract XmlQualifiedName GetQName();

        private class AccessorElementProperty : ElementProperty<T>
        {
            private readonly ElementPropertyAccessor<T> _accessor;

            public AccessorElementProperty(
                byte namespaceId,
                string name,
                int order,
                ValidatorCollection validators,
                ElementPropertyAccessor<T> accessor)
            {
                _accessor = accessor;

                Order = order;
                Name = name;
                NamespaceId = namespaceId;
                Validators = validators;
            }

            public override XmlQualifiedName TypeName => Validators.GetSimpleTypeQualifiedName(Type);

            public override int Order { get; }

            public override string Name { get; }

            public override byte NamespaceId { get; }

            public override ValidatorCollection Validators { get; }

            public override string Namespace => NamespaceIdMap.GetNamespaceUri(NamespaceId);

            public override string NamespacePrefix => NamespaceIdMap.GetNamespacePrefix(NamespaceId);

            public override T GetValue(OpenXmlElement element) => _accessor.Get(element);

            public override void SetValue(OpenXmlElement element, T value) => _accessor.Set(element, value);

            public override T CreateNew() => _accessor.Create();

            public override Type Type => _accessor?.Type;

            public override XmlQualifiedName GetQName() => new XmlQualifiedName(Name, Namespace);
        }
    }
}
