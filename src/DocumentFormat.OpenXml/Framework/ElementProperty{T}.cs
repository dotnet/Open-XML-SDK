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
            ValidatorCollection validators,
            ElementPropertyAccessor<T> accessor)
        {
            return new AccessorElementProperty(namespaceId, name, validators, accessor);
        }

        public XmlQualifiedName TypeName => Validators.GetSimpleTypeQualifiedName(Type);

        public virtual string PropertyName { get; }

        public abstract string Name { get; }

        public abstract byte NamespaceId { get; }

        public abstract ValidatorCollection Validators { get; }

        public string Namespace => NamespaceIdMap.GetNamespaceUri(NamespaceId);

        public string NamespacePrefix => NamespaceIdMap.GetNamespacePrefix(NamespaceId);

        public abstract T GetValue(OpenXmlElement element);

        public abstract void SetValue(OpenXmlElement element, T value);

        public abstract T CreateNew();

        public abstract Type Type { get; }

        public XmlQualifiedName GetQName() => new XmlQualifiedName(Name, Namespace);

        private class AccessorElementProperty : ElementProperty<T>
        {
            private readonly ElementPropertyAccessor<T> _accessor;

            public AccessorElementProperty(
                byte namespaceId,
                string name,
                ValidatorCollection validators,
                ElementPropertyAccessor<T> accessor)
            {
                _accessor = accessor;

                Name = name;
                NamespaceId = namespaceId;
                Validators = validators;
            }

            public override string Name { get; }

            public override byte NamespaceId { get; }

            public override ValidatorCollection Validators { get; }

            public override T GetValue(OpenXmlElement element) => _accessor.Get(element);

            public override void SetValue(OpenXmlElement element, T value) => _accessor.Set(element, value);

            public override T CreateNew() => _accessor.Create();

            public override Type Type => _accessor?.Type;
        }
    }
}
