// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal interface IRootElementFactory
    {
        bool TryCreate(in OpenXmlQualifiedName qname, [NotNullWhen(true)] out OpenXmlElement? element);

        ElementFactoryCollection Collection { get; }
    }
}
