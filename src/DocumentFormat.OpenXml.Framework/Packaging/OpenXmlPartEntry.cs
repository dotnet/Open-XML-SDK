// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NETSTANDARD || NETCOREAPP

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;
using System.IO.Packaging;
using System.Xml;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// Represents a part being written in forward-only mode.
/// Provides access to the part's output stream and the ability to add part-level relationships.
/// </summary>
[Experimental(ExperimentalApis.ForwardOnly, UrlFormat = ExperimentalApis.UrlFormat)]
[Obsolete(ExperimentalApis.Message, DiagnosticId = ExperimentalApis.ForwardOnly, UrlFormat = ExperimentalApis.UrlFormat)]
public sealed class OpenXmlPartEntry : IDisposable
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2213:Disposable fields should be disposed", Justification = "Archive is owned by OpenXmlPackageWriter")]
    private readonly ZipArchive _archive;
    private readonly Uri _partUri;
    private readonly Stream _stream;
    private List<(string Id, Uri TargetUri, string RelationshipType, TargetMode TargetMode)>? _relationships;
    private bool _disposed;
    private int _nextRelId;

    internal OpenXmlPartEntry(ZipArchive archive, Uri partUri, Stream stream)
    {
        _archive = archive;
        _partUri = partUri;
        _stream = stream;
    }

    /// <summary>
    /// Gets the writable stream for this part's ZIP entry.
    /// Write XML content to this stream using <see cref="OpenXmlWriter"/> or <see cref="XmlWriter"/>.
    /// </summary>
    public Stream Stream
    {
        get
        {
            ThrowIfDisposed();
            return _stream;
        }
    }

    /// <summary>
    /// Adds a relationship for this part.
    /// </summary>
    /// <param name="targetUri">Target URI (relative or absolute).</param>
    /// <param name="relationshipType">The relationship type.</param>
    /// <param name="targetMode">Internal or External.</param>
    /// <param name="id">Optional explicit ID. Auto-generated if null.</param>
    /// <returns>The assigned relationship ID.</returns>
    public string AddRelationship(Uri targetUri, string relationshipType, TargetMode targetMode = TargetMode.Internal, string? id = null)
    {
        ThrowIfDisposed();

        if (targetUri is null)
        {
            throw new ArgumentNullException(nameof(targetUri));
        }

        if (relationshipType is null)
        {
            throw new ArgumentNullException(nameof(relationshipType));
        }

        _relationships ??= new List<(string, Uri, string, TargetMode)>();

        id ??= "rId" + (++_nextRelId).ToString(System.Globalization.CultureInfo.InvariantCulture);

        _relationships.Add((id, targetUri, relationshipType, targetMode));
        return id;
    }

    /// <summary>
    /// Closes the part stream and writes the part's .rels file if any relationships were added.
    /// </summary>
    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;
        _stream.Dispose();

        if (_relationships is not null && _relationships.Count > 0)
        {
            WriteRelationships();
        }
    }

    private void WriteRelationships()
    {
        var partPath = _partUri.OriginalString.TrimStart('/');
        var lastSlash = partPath.LastIndexOf('/');
        string relsPath;

        if (lastSlash >= 0)
        {
            var dir = partPath.Substring(0, lastSlash + 1);
            var file = partPath.Substring(lastSlash + 1);
            relsPath = string.Concat(dir, "_rels/", file, ".rels");
        }
        else
        {
            relsPath = string.Concat("_rels/", partPath, ".rels");
        }

        var relsEntry = _archive.CreateEntry(relsPath, CompressionLevel.Optimal);
        using var relsStream = relsEntry.Open();
        OpenXmlPackageWriter.WriteRelationshipsXml(relsStream, _relationships!);
    }

    private void ThrowIfDisposed()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(nameof(OpenXmlPartEntry));
        }
    }
}

#endif
