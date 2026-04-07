// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NETSTANDARD || NETCOREAPP

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.IO.Packaging;
#if NET6_0_OR_GREATER
using System.Threading.Tasks;
#endif
using System.Xml;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// Writes an OPC package in forward-only mode to any writable stream,
/// including non-seekable streams. Produces valid .docx/.xlsx/.pptx files
/// without requiring a temporary <see cref="MemoryStream"/>.
/// </summary>
[Experimental(ExperimentalApis.ForwardOnly, UrlFormat = ExperimentalApis.UrlFormat)]
[Obsolete(ExperimentalApis.Message, DiagnosticId = ExperimentalApis.ForwardOnly, UrlFormat = ExperimentalApis.UrlFormat)]
public sealed class OpenXmlPackageWriter :
#if NET6_0_OR_GREATER
    IAsyncDisposable,
#endif
    IDisposable
{
    private readonly ZipArchive _archive;
    private readonly List<(Uri PartUri, string ContentType)> _contentTypes = new();
    private readonly List<(string Id, Uri TargetUri, string RelationshipType, TargetMode TargetMode)> _packageRelationships = new();
    private readonly HashSet<string> _writtenParts = new(StringComparer.OrdinalIgnoreCase);
    private OpenXmlPartEntry? _currentEntry;
    private bool _finished;
    private int _nextRelId;

    /// <summary>
    /// Creates a writer targeting the given stream.
    /// The stream need not be seekable.
    /// </summary>
    /// <param name="stream">Target stream (write-only is sufficient).</param>
    /// <param name="leaveOpen">Whether to leave the stream open after disposal.</param>
    public OpenXmlPackageWriter(Stream stream, bool leaveOpen = false)
    {
        if (stream is null)
        {
            throw new ArgumentNullException(nameof(stream));
        }

        _archive = new ZipArchive(stream, ZipArchiveMode.Create, leaveOpen);
    }

    /// <summary>
    /// Adds a package-level relationship (written to _rels/.rels on finalization).
    /// </summary>
    /// <param name="partUri">Target part URI (e.g., "/word/document.xml").</param>
    /// <param name="relationshipType">The OPC relationship type URI.</param>
    /// <param name="id">Optional explicit relationship ID. Auto-generated if null.</param>
    /// <returns>The assigned relationship ID.</returns>
    public string AddRelationship(Uri partUri, string relationshipType, string? id = null)
    {
        ThrowIfFinished();

        if (partUri is null)
        {
            throw new ArgumentNullException(nameof(partUri));
        }

        if (relationshipType is null)
        {
            throw new ArgumentNullException(nameof(relationshipType));
        }

        id ??= "rId" + (++_nextRelId).ToString(CultureInfo.InvariantCulture);

        _packageRelationships.Add((id, partUri, relationshipType, TargetMode.Internal));
        return id;
    }

    /// <summary>
    /// Creates a new part entry in the package and returns a context object
    /// for writing content and part-level relationships.
    /// Only one part may be open at a time. The previous part is
    /// automatically closed when a new part is created or when the writer is disposed.
    /// </summary>
    /// <param name="partUri">The URI for this part (e.g., "/word/document.xml").</param>
    /// <param name="contentType">The MIME content type.</param>
    /// <returns>A part context for writing content and relationships.</returns>
    public OpenXmlPartEntry CreatePart(Uri partUri, string contentType)
    {
        ThrowIfFinished();

        if (partUri is null)
        {
            throw new ArgumentNullException(nameof(partUri));
        }

        if (contentType is null)
        {
            throw new ArgumentNullException(nameof(contentType));
        }

        // Close previous entry if still open
        _currentEntry?.Dispose();

        var entryPath = partUri.OriginalString.TrimStart('/');

        if (!_writtenParts.Add(entryPath))
        {
            throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "A part with URI '{0}' has already been written.", partUri));
        }

        _contentTypes.Add((partUri, contentType));

        var zipEntry = _archive.CreateEntry(entryPath, CompressionLevel.Optimal);
        var stream = zipEntry.Open();

        _currentEntry = new OpenXmlPartEntry(_archive, partUri, stream);
        return _currentEntry;
    }

    /// <summary>
    /// Creates a new part, writes the given element tree as its content,
    /// and closes the part in one call.
    /// </summary>
    /// <param name="partUri">The URI for this part.</param>
    /// <param name="contentType">The MIME content type.</param>
    /// <param name="rootElement">The root element to serialize.</param>
    /// <param name="relationships">Optional part-level relationships.</param>
    public void WritePart(Uri partUri, string contentType, OpenXmlElement rootElement, IEnumerable<PartRelationship>? relationships = null)
    {
        if (rootElement is null)
        {
            throw new ArgumentNullException(nameof(rootElement));
        }

        using var entry = CreatePart(partUri, contentType);

        if (relationships is not null)
        {
            foreach (var rel in relationships)
            {
                entry.AddRelationship(rel.TargetUri, rel.RelationshipType, rel.TargetMode, rel.Id);
            }
        }

        using var xmlWriter = XmlWriter.Create(entry.Stream, new XmlWriterSettings
        {
            CloseOutput = false,
            Encoding = System.Text.Encoding.UTF8,
        });

        rootElement.WriteTo(xmlWriter);
    }

    /// <summary>
    /// Finalizes the package by writing _rels/.rels and [Content_Types].xml.
    /// Called automatically by Dispose, but can be called explicitly.
    /// After this call, no more parts can be added.
    /// </summary>
    public void Finish()
    {
        if (_finished)
        {
            return;
        }

        _finished = true;

        // Close any open part entry
        _currentEntry?.Dispose();
        _currentEntry = null;

        WritePackageRelationships();
        WriteContentTypes();
    }

    /// <summary>
    /// Disposes the writer, finalizing the package if not already done.
    /// </summary>
    public void Dispose()
    {
        Finish();
        _archive.Dispose();
    }

#if NET6_0_OR_GREATER
    /// <summary>
    /// Asynchronously disposes the writer, finalizing the package if not already done.
    /// </summary>
    public ValueTask DisposeAsync()
    {
        Dispose();
        return default;
    }
#endif

    private void WritePackageRelationships()
    {
        if (_packageRelationships.Count == 0)
        {
            return;
        }

        var entry = _archive.CreateEntry("_rels/.rels", CompressionLevel.Optimal);
        using var stream = entry.Open();
        WriteRelationshipsXml(stream, _packageRelationships);
    }

    internal static void WriteRelationshipsXml(Stream stream, List<(string Id, Uri TargetUri, string RelationshipType, TargetMode TargetMode)> relationships)
    {
        using var writer = XmlWriter.Create(stream, new XmlWriterSettings
        {
            CloseOutput = false,
            Encoding = System.Text.Encoding.UTF8,
        });

        writer.WriteStartDocument();
        writer.WriteStartElement("Relationships", "http://schemas.openxmlformats.org/package/2006/relationships");

        foreach (var rel in relationships)
        {
            writer.WriteStartElement("Relationship");
            writer.WriteAttributeString("Id", rel.Id);
            writer.WriteAttributeString("Type", rel.RelationshipType);
            writer.WriteAttributeString("Target", rel.TargetUri.OriginalString);

            if (rel.TargetMode == TargetMode.External)
            {
                writer.WriteAttributeString("TargetMode", "External");
            }

            writer.WriteEndElement();
        }

        writer.WriteEndElement();
    }

    private void WriteContentTypes()
    {
        var entry = _archive.CreateEntry("[Content_Types].xml", CompressionLevel.Optimal);
        using var stream = entry.Open();
        using var writer = XmlWriter.Create(stream, new XmlWriterSettings
        {
            CloseOutput = false,
            Encoding = System.Text.Encoding.UTF8,
        });

        writer.WriteStartDocument();
        writer.WriteStartElement("Types", "http://schemas.openxmlformats.org/package/2006/content-types");

        // Write default for .rels files
        writer.WriteStartElement("Default");
        writer.WriteAttributeString("Extension", "rels");
        writer.WriteAttributeString("ContentType", "application/vnd.openxmlformats-package.relationships+xml");
        writer.WriteEndElement();

        // Write default for .xml files
        writer.WriteStartElement("Default");
        writer.WriteAttributeString("Extension", "xml");
        writer.WriteAttributeString("ContentType", "application/xml");
        writer.WriteEndElement();

        // Write overrides for each part
        foreach (var ct in _contentTypes)
        {
            writer.WriteStartElement("Override");
            var partName = ct.PartUri.OriginalString;
            writer.WriteAttributeString("PartName", partName.Length > 0 && partName[0] == '/' ? partName : "/" + partName);
            writer.WriteAttributeString("ContentType", ct.ContentType);
            writer.WriteEndElement();
        }

        writer.WriteEndElement();
    }

    private void ThrowIfFinished()
    {
        if (_finished)
        {
            throw new InvalidOperationException("The package writer has already been finalized. No more parts can be added.");
        }
    }
}

#endif
