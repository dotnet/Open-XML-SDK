// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// Extension methods that enable sanitization of invalid XML characters when writing parts.
/// </summary>
public static class XmlTextSanitizationExtensions
{
    /// <summary>
    /// Enables sanitization of invalid XML characters (per the XML 1.0 specification) in text
    /// content written to this package and its parts. When enabled, characters that would
    /// otherwise cause an <see cref="ArgumentException"/> during save (such as control characters
    /// <c>0x00</c>-<c>0x08</c>, <c>0x0B</c>, <c>0x0C</c>, <c>0x0E</c>-<c>0x1F</c>, and orphaned
    /// surrogates) are silently removed from element text, attribute values, CDATA sections,
    /// comment bodies, and processing-instruction text.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Element and attribute names are not sanitized — invalid characters in names still throw
    /// as before because names are structurally significant. Calls to
    /// <see cref="System.Xml.XmlWriter.WriteRaw(string)"/> are also not sanitized because their
    /// contract is that the caller provides pre-validated XML.
    /// </para>
    /// <para>
    /// This feature is opt-in and pay-for-play. Packages that don't call this method pay
    /// nothing for its presence. Repeated calls are idempotent.
    /// </para>
    /// </remarks>
    /// <param name="package">The package to enable sanitization on.</param>
    /// <returns>The same package, for fluent chaining.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="package"/> is <see langword="null"/>.</exception>
    public static OpenXmlPackage UseXmlTextSanitization(this OpenXmlPackage package)
    {
        if (package is null)
        {
            throw new ArgumentNullException(nameof(package));
        }

        if (package.Features.Get<IXmlWriterFactoryFeature>() is not SanitizingXmlWriterFactoryFeature)
        {
            package.Features.Set<IXmlWriterFactoryFeature>(SanitizingXmlWriterFactoryFeature.Instance);
        }

        return package;
    }
}
