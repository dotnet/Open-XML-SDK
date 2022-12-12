// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Features
{
    internal interface IRootElementFactory
    {
        bool TryCreate(in OpenXmlQualifiedName qname, [NotNullWhen(true)] out OpenXmlElement? element);

        ElementFactoryCollection Collection { get; }
    }
}
