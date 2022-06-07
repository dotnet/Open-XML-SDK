// Copyright (c) Microsoft.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal interface IRootElementFactory
    {
        bool TryCreate(in OpenXmlQualifiedName qname, [NotNullWhen(true)] out OpenXmlElement? element);

        ElementFactoryCollection Collection { get; }
    }
}
