// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Features;

internal partial class TypedRootElementFactory : IRootElementFactory
{
    private readonly Lazy<ElementFactoryCollection> _collection;

    public TypedRootElementFactory()
    {
        _collection = new Lazy<ElementFactoryCollection>(() => new ElementFactoryCollection(GetAllRootElements()));
    }

    public ElementFactoryCollection Collection => _collection.Value;

    public bool TryCreate(in OpenXmlQualifiedName qname, [NotNullWhen(true)] out OpenXmlElement? element)
    {
        element = _collection.Value.Create(in qname);
        return element is not null;
    }
}
