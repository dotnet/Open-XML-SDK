// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal class OpenXmlElementData
    {
        private readonly Lazy<ElementTypeInfo> _info;
        private readonly Lazy<ElementLookup> _children;

        public OpenXmlElementData(Type type, PackageCache cache)
        {
            _info = new Lazy<ElementTypeInfo>(() => ElementTypeInfo.Create(type), true);
            _children = new Lazy<ElementLookup>(() => ElementLookup.CreateLookup(type, cache.GetFactory<OpenXmlElement>), true);
        }

        public ElementTypeInfo Info => _info.Value;

        public ElementLookup Children => _children.Value;
    }
}
