// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml
{
    internal class OpenXmlElementData
    {
        private readonly Type _type;
        private readonly PackageCache _cache;

        private ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> _rawAttributes;
        private ReadOnlyArray<ElementProperty<OpenXmlElement>> _rawElements;
        private ElementTypeInfo _info;
        private ElementSchemaLookup _lookup;

        public OpenXmlElementData(Type type, PackageCache cache)
        {
            _type = type;
            _cache = cache;
        }

        public static OpenXmlElementData Create(OpenXmlElement element) => PackageCache.Cache.ParseData(element);

        public ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> RawAttributes
        {
            get
            {
                if (_rawAttributes.IsNull)
                {
                    _rawAttributes = ElementPropertyCollection.GetProperties(_cache, _type);
                }

                return _rawAttributes;
            }
        }

        public ReadOnlyArray<ElementProperty<OpenXmlElement>> RawElements
        {
            get
            {
                if (!_rawElements.IsNull)
                {
                    _rawElements = ElementPropertyCollection.GetElements(_cache, _type);
                }

                return _rawElements;
            }
        }

        public ElementTypeInfo Info
        {
            get
            {
                if (_info == null)
                {
                    _info = _cache.GetElementTypeInfo(_type);
                }

                return _info;
            }
        }

        public ElementSchemaLookup SchemaLookup
        {
            get
            {
                if (_lookup == null)
                {
                    _lookup = _cache.GetElementLookup(_type);
                }

                return _lookup;
            }
        }
    }
}
