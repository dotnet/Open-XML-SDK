// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal class OpenXmlElementData
    {
        private readonly Lazy<ReadOnlyArray<ElementProperty<OpenXmlSimpleType>>> _rawAttributes;
        private readonly Lazy<ReadOnlyArray<ElementProperty<OpenXmlElement>>> _rawElements;
        private readonly Lazy<ElementTypeInfo> _info;
        private readonly Lazy<ElementLookup> _children;

        public OpenXmlElementData(Type type, PackageCache cache)
        {
            _rawAttributes = new Lazy<ReadOnlyArray<ElementProperty<OpenXmlSimpleType>>>(() => ElementPropertyCollection.GetProperties(cache.GetFactory<OpenXmlSimpleType>, type), true);
            _rawElements = new Lazy<ReadOnlyArray<ElementProperty<OpenXmlElement>>>(() => ElementPropertyCollection.GetElements(cache.GetFactory<OpenXmlElement>, t => cache.ParseElement(t).Info.Schema, type), true);
            _info = new Lazy<ElementTypeInfo>(() => ElementTypeInfo.Create(type), true);
            _children = new Lazy<ElementLookup>(() => ElementLookup.CreateLookup(type, cache.GetFactory<OpenXmlElement>), true);
        }

        public static OpenXmlElementData Create(OpenXmlElement element) => PackageCache.Cache.ParseElement(element);

        public ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> RawAttributes => _rawAttributes.Value;

        public ReadOnlyArray<ElementProperty<OpenXmlElement>> RawElements => _rawElements.Value;

        public ElementTypeInfo Info => _info.Value;

        public ElementLookup Children => _children.Value;
    }
}
