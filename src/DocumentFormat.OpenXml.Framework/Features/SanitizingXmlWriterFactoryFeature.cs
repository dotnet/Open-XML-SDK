// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml.Features;

internal sealed class SanitizingXmlWriterFactoryFeature : IXmlWriterFactoryFeature
{
    public static readonly SanitizingXmlWriterFactoryFeature Instance = new();

    private SanitizingXmlWriterFactoryFeature()
    {
    }

    public XmlWriter Create(Stream stream, XmlWriterSettings? settings)
        => new SanitizingXmlWriter(DefaultXmlWriterFactoryFeature.Instance.Create(stream, settings));

    public XmlWriter Create(TextWriter textWriter, XmlWriterSettings? settings)
        => new SanitizingXmlWriter(DefaultXmlWriterFactoryFeature.Instance.Create(textWriter, settings));
}
