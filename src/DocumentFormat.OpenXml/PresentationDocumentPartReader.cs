// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System.IO;

namespace DocumentFormat.OpenXml;

/// <summary>
/// Represents an implementation of <see cref="OpenXmlPartReader"/> that is aware of the strongly typed classes for a <see cref="PresentationDocument"/>.
/// </summary>
public sealed class PresentationDocumentPartReader : OpenXmlPartReader
{
    private static readonly IFeatureCollection _features = new PresentationDocument().Features;

    /// <summary>
    /// Initializes a new instance of the <see cref="PresentationDocumentPartReader"/> class.
    /// </summary>
    /// <param name="partStream">The stream of the part contents.</param>
    /// <param name="options">Options for how to read the part stream.</param>
    public PresentationDocumentPartReader(Stream partStream, OpenXmlPartReaderOptions options = default)
        : base(partStream, _features, options)
    {
    }
}
