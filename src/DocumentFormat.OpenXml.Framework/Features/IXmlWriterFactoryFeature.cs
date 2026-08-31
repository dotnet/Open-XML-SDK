// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// A feature that produces <see cref="XmlWriter"/> instances used by the SDK when serializing parts.
/// Replace the default implementation on a package to intercept every writer the SDK creates for
/// that package and its parts.
/// </summary>
public interface IXmlWriterFactoryFeature
{
    /// <summary>
    /// Creates an <see cref="XmlWriter"/> that writes to <paramref name="stream"/>.
    /// </summary>
    /// <param name="stream">The destination stream.</param>
    /// <param name="settings">Optional writer settings.</param>
    /// <returns>A new <see cref="XmlWriter"/>.</returns>
    XmlWriter Create(Stream stream, XmlWriterSettings? settings);

    /// <summary>
    /// Creates an <see cref="XmlWriter"/> that writes to <paramref name="textWriter"/>.
    /// </summary>
    /// <param name="textWriter">The destination text writer.</param>
    /// <param name="settings">Optional writer settings.</param>
    /// <returns>A new <see cref="XmlWriter"/>.</returns>
    XmlWriter Create(TextWriter textWriter, XmlWriterSettings? settings);
}
