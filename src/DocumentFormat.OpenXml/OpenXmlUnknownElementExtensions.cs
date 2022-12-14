// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml;

/// <summary>
/// Extension methods for managing unknown elements
/// </summary>
public static class OpenXmlUnknownElementExtensions
{
    /// <summary>
    /// Creates a new OpenXmlUnknownElement class by using the outer XML.
    /// </summary>
    /// <param name="container">Container to create unknown element from.</param>
    /// <param name="outerXml">The outer XML of the element.</param>
    /// <returns>A new OpenXmlUnknownElement class.</returns>
    public static OpenXmlUnknownElement CreateUnknownElement(this OpenXmlPartContainer container, string outerXml)
        => CreateOpenXmlUnknownElement(container.Features, outerXml);

    internal static OpenXmlUnknownElement CreateOpenXmlUnknownElement(IFeatureCollection features, string outerXml)
    {
        if (string.IsNullOrEmpty(outerXml))
        {
            throw new ArgumentNullException(nameof(outerXml));
        }

        using var stringReader = new StringReader(outerXml);
        using var xmlReader = XmlConvertingReaderFactory.Create(stringReader, features.GetNamespaceResolver(), OpenXmlElementContext.CreateDefaultXmlReaderSettings());

        // Skip the leading whitespace as OpenXmUnknownlElement ignores the Whitespace NodeType.
        do
        {
            if (xmlReader.Read() && xmlReader.NodeType == XmlNodeType.Element)
            {
                return new OpenXmlUnknownElement(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI)
                {
                    OuterXml = outerXml,
                };
            }
        }
        while (xmlReader.NodeType == XmlNodeType.Whitespace);

        // This method always expects an Element NodeType is passed, and there may be one or more preceding Whitespace NodeTypes before the Element.
        // If it's not the case, then throw an exception.
        throw new ArgumentException(ExceptionMessages.InvalidOuterXml, nameof(outerXml));
    }
}
