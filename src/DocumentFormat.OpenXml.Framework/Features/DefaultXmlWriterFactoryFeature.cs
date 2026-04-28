// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml.Features;

internal sealed class DefaultXmlWriterFactoryFeature : IXmlWriterFactoryFeature
{
    public static readonly DefaultXmlWriterFactoryFeature Instance = new();

    private DefaultXmlWriterFactoryFeature()
    {
    }

    public XmlWriter Create(Stream stream, XmlWriterSettings? settings)
        => settings is null ? XmlWriter.Create(stream) : XmlWriter.Create(stream, settings);

    public XmlWriter Create(TextWriter textWriter, XmlWriterSettings? settings)
        => settings is null ? XmlWriter.Create(textWriter) : XmlWriter.Create(textWriter, settings);
}
