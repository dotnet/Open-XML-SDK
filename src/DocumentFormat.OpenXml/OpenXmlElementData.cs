// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml
{
    internal class OpenXmlElementData
    {
        private readonly OpenXmlElement _element;

        private ElementPropertyCollection<OpenXmlSimpleType> _rawAttributes;
        private ElementPropertyCollection<OpenXmlElement> _rawElements;
        private ElementTypeInfo _info;
        private ElementSchemaLookup _lookup;

        public OpenXmlElementData(OpenXmlElement element)
        {
            _element = element;
        }

        public ElementPropertyCollection<OpenXmlSimpleType> RawAttributes
        {
            get
            {
                if (!_rawAttributes.IsValid)
                {
                    _rawAttributes = new ElementPropertyCollection<OpenXmlSimpleType>(_element, PackageCache.Cache.GetAttributes(_element.GetType()));
                }

                return _rawAttributes;
            }
        }

        public ElementPropertyCollection<OpenXmlElement> RawElements
        {
            get
            {
                if (!_rawElements.IsValid)
                {
                    _rawElements = new ElementPropertyCollection<OpenXmlElement>(_element, PackageCache.Cache.GetElements(_element.GetType()));
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
                    _info = PackageCache.Cache.GetElementTypeInfo(_element.GetType());
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
                    _lookup = PackageCache.Cache.GetElementLookup(_element.GetType());
                }

                return _lookup;
            }
        }
    }
}
