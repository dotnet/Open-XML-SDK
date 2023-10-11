// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// Extensions to convert to and from FlatOpc
/// </summary>
public static class FlatOpcExtensions
{
    private const string RelationshipContentType = "application/vnd.openxmlformats-package.relationships+xml";

    private const string AltChunkRelationshipType =
        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk";

    private static readonly XNamespace Pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";
    private static readonly XNamespace Rel = "http://schemas.openxmlformats.org/package/2006/relationships";

    /// <summary>
    /// Converts an OpenXml package in OPC format to string in Flat OPC format.
    /// </summary>
    /// <returns>The OpenXml package in Flat OPC format.</returns>
    public static string ToFlatOpcString(this OpenXmlPackage package)
        => package.ToFlatOpcDocument().ToString();

    /// <summary>
    /// Converts an OpenXml package in OPC format to an <see cref="XDocument"/>
    /// in Flat OPC format.
    /// </summary>
    public static XDocument ToFlatOpcDocument(this OpenXmlPackage openXmlPackage)
    {
        if (openXmlPackage is null)
        {
            throw new ArgumentNullException(nameof(openXmlPackage));
        }

        XProcessingInstruction? instruction = default;

        if (openXmlPackage.Features.Get<IProgrammaticIdentifierFeature>() is { ProgramId: { } progId })
        {
            instruction = new("mso-application", $@"progid=""{progId}""");
        }

        // Save the contents of all parts and relationships that are contained
        // in the OpenXml package to make sure we convert a consistent state.
        // This will also invoke ThrowIfObjectDisposed(), so we don't need
        // to call it here.
        openXmlPackage.Save();

        var package = openXmlPackage.Features.GetRequired<IPackageFeature>().Package;

        // Identify all AlternativeFormatInputParts (AltChunk parts).
        // This is necessary because AltChunk parts must be treated as binary
        // parts regardless of the actual content type, which might even be
        // XML-related such as application/xhtml+xml.
        var altChunkPartUris = new HashSet<Uri>(
            package.GetParts()
                .Where(part => part.ContentType != RelationshipContentType)
                .SelectMany(part => part.Relationships.Where(r => string.Equals(r.RelationshipType, AltChunkRelationshipType, StringComparison.Ordinal)))
                .Select(pr => PackUriHelper.ResolvePartUri(pr.SourceUri, pr.TargetUri)));

        // Create an XML document with a standalone declaration, processing
        // instruction (if not null), and a package root element with a
        // namespace declaration and one child element for each part.
        return new XDocument(
            new XDeclaration("1.0", "UTF-8", "yes"),
            instruction!,
            new XElement(
                Pkg + "package",
                new XAttribute(XNamespace.Xmlns + "pkg", Pkg.ToString()),
                package.GetParts().Select(part => GetContentsAsXml(part, altChunkPartUris))));
    }

    /// <summary>
    /// Gets the <see cref="PackagePart"/>'s XML or binary contents as an <see cref="XElement"/>.
    /// </summary>
    /// <param name="part">The package part.</param>
    /// <param name="altChunkPartUris">The collection of AlternativeFormatInputPart URIs.</param>
    /// <returns>The corresponding <see cref="XElement"/>.</returns>
    private static XElement GetContentsAsXml(IPackagePart part, HashSet<Uri> altChunkPartUris)
    {
#if NET35
        var settings = default(XmlReaderSettings);
#else
        var settings = new XmlReaderSettings
        {
            DtdProcessing = DtdProcessing.Ignore,
        };
#endif

        if (part.ContentType.EndsWith("xml", StringComparison.Ordinal) &&
            !altChunkPartUris.Contains(part.Uri))
        {
            using var stream = part.GetStream();
            using var streamReader = new StreamReader(stream);
            using var xmlReader = XmlReader.Create(streamReader, settings);

            // Some content, such as SVG, may have a preamble and doctype. Office does not include this, so we
            // load the content as a document and then just extract the root node.
            var doc = XDocument.Load(xmlReader);

            return new XElement(
                Pkg + "part",
                new XAttribute(Pkg + "name", part.Uri),
                new XAttribute(Pkg + "contentType", part.ContentType),
                new XElement(Pkg + "xmlData", doc.Root));
        }

        return GetBinaryPartContentsAsXml(part);
    }

    private static XElement GetBinaryPartContentsAsXml(IPackagePart part)
    {
        return new XElement(
            Pkg + "part",
            new XAttribute(Pkg + "name", part.Uri),
            new XAttribute(Pkg + "contentType", part.ContentType),
            new XAttribute(Pkg + "compression", "store"),
            new XElement(Pkg + "binaryData", ToChunkedBase64String(part)));
    }

    private static string ToChunkedBase64String(IPackagePart part)
    {
        using var stream = part.GetStream();
        var size = checked((int)stream.Length);
        var buffer = new byte[size];
        stream.ReadExactly(buffer);

        return ToChunkedBase64String(buffer);
    }

    private static string ToChunkedBase64String(byte[] byteArray)
    {
        // The MIME specification defines a maximum line length of 76 characters
        // for a Base64-encoded string. Therefore, we need to break down the
        // Base64 string into chunks of up to 76 characters each.
        const int maxLineLength = 76;

        return Convert.ToBase64String(byteArray)
            .Select((@char, index) => new { Character = @char, Chunk = index / maxLineLength })
            .GroupBy(charAndChunk => charAndChunk.Chunk)
            .Aggregate(
                new StringBuilder(),
                (sb, grouping) => sb
                    .Append(grouping.Aggregate(
                        new StringBuilder(),
                        (chunkSb, charAndChunk) => chunkSb.Append(charAndChunk.Character),
                        chunkSb => chunkSb.ToString()))
                    .Append(Environment.NewLine),
                sb => sb.ToString());
    }

    internal static IPackageBuilder<TPackage> UseFlatOpcTemplate<TPackage>(this IPackageBuilder<TPackage> builder, string text)
        where TPackage : OpenXmlPackage
        => builder.UseFlatOpcTemplate(XDocument.Parse(text));

    internal static IPackageBuilder<TPackage> UseFlatOpcTemplate<TPackage>(this IPackageBuilder<TPackage> builder, XDocument document)
        where TPackage : OpenXmlPackage
        => builder.Use((package, next) =>
        {
            var p = package.Features.GetRequired<IPackageFeature>().Package;

            if (p.GetParts().Any())
            {
                throw new InvalidOperationException("FlatOpc must be loaded into an empty package");
            }

            if (document.Root is not null)
            {
                // Add package parts and relationships.
                AddPackageParts(document.Root, p);
                AddPackageRelationships(document.Root, p);
            }

#if NETFRAMEWORK
            if (package.CanSave)
            {
                package.Save();
            }
#endif

            next(package);
        });

    private static void AddPackageParts(XElement flatOpcPackage, IPackage package)
    {
        var flatOpcParts = flatOpcPackage
            .Elements()
            .Where(p => p.Attribute(Pkg + "contentType")?.Value != RelationshipContentType);

        foreach (var flatOpcPart in flatOpcParts)
        {
            if (flatOpcPart.Elements(Pkg + "xmlData").Any())
            {
                AddXmlPackagePart(flatOpcPart, package);
            }
            else if (flatOpcPart.Elements(Pkg + "binaryData").Any())
            {
                AddBinaryPackagePart(flatOpcPart, package);
            }
            else
            {
                // We expect the Flat OPC part to have either a pkg:xmlData
                // or a pkg:binaryData child element.
                throw new ArgumentOutOfRangeException(nameof(flatOpcPackage));
            }
        }
    }

    private static void AddXmlPackagePart(XElement flatOpcPart, IPackage package)
    {
        var part = CreatePackagePart(flatOpcPart, package);

        using var stream = part.GetStream(FileMode.Create);
        using var xmlWriter = XmlWriter.Create(stream);

        XElement rootElement = flatOpcPart.Elements(Pkg + "xmlData").Elements().First();
        rootElement.WriteTo(xmlWriter);
    }

    private static void AddBinaryPackagePart(XElement flatOpcPart, IPackage package)
    {
        var part = CreatePackagePart(flatOpcPart, package);

        using var stream = part.GetStream(FileMode.Create);
        using var binaryWriter = new BinaryWriter(stream);

        var chunkedBase64String = flatOpcPart.Element(Pkg + "binaryData")?.Value;
        byte[] byteArray = FromChunkedBase64String(chunkedBase64String);
        binaryWriter.Write(byteArray);
    }

    private static IPackagePart CreatePackagePart(XElement flatOpcPart, IPackage package)
    {
        var name = flatOpcPart.Attribute(Pkg + "name")?.Value;
        var contentType = flatOpcPart.Attribute(Pkg + "contentType")?.Value;

        if (name is null || contentType is null)
        {
            throw new InvalidDataException();
        }

        var uri = new Uri(name, UriKind.Relative);
        return package.CreatePart(uri, contentType, CompressionOption.SuperFast);
    }

    private static byte[] FromChunkedBase64String(string? chunkedBase64String)
    {
        if (chunkedBase64String is null)
        {
            return Cached.Array<byte>();
        }

        char[] base64CharArray = chunkedBase64String.Where(c => c != '\r' && c != '\n').ToArray();
        return Convert.FromBase64CharArray(base64CharArray, 0, base64CharArray.Length);
    }

    private static void AddPackageRelationships(XElement flatOpcPackage, IPackage package)
    {
        var flatOpcRelationshipParts = flatOpcPackage
            .Elements()
            .Where(p => p.Attribute(Pkg + "contentType")?.Value == RelationshipContentType);

        foreach (var flatOpcRelationshipPart in flatOpcRelationshipParts)
        {
            var name = flatOpcRelationshipPart.Attribute(Pkg + "name")?.Value;
            if (name == "/_rels/.rels")
            {
                AddPackageLevelRelationships(flatOpcRelationshipPart, package);
            }
            else
            {
                AddPartLevelRelationships(flatOpcRelationshipPart, package);
            }
        }
    }

    private static void AddPackageLevelRelationships(XElement flatOpcRelationshipPart, IPackage package)
    {
        foreach (var relationship in flatOpcRelationshipPart.Descendants(Rel + "Relationship"))
        {
            var id = relationship.Attribute("Id")?.Value;
            var type = relationship.Attribute("Type")?.Value;
            var target = relationship.Attribute("Target")?.Value;
            var targetMode = relationship.Attribute("TargetMode")?.Value;

            if (target is null || type is null)
            {
                continue;
            }

            if (targetMode == "External")
            {
                package.Relationships.Create(new Uri(target, UriKind.Absolute), TargetMode.External, type, id);
            }
            else
            {
                package.Relationships.Create(new Uri(target, UriKind.Relative), TargetMode.Internal, type, id);
            }
        }
    }

    private static void AddPartLevelRelationships(XElement flatOpcRelationshipPart, IPackage package)
    {
        var sourcePart = GetSourcePart(flatOpcRelationshipPart, package);

        foreach (var relationship in flatOpcRelationshipPart.Descendants(Rel + "Relationship"))
        {
            var id = relationship.Attribute("Id")?.Value;
            var type = relationship.Attribute("Type")?.Value;
            var target = relationship.Attribute("Target")?.Value;
            var targetMode = relationship.Attribute("TargetMode")?.Value;

            if (target is null || type is null)
            {
                continue;
            }

            if (targetMode == "External")
            {
                sourcePart.Relationships.Create(new Uri(target, UriKind.Absolute), TargetMode.External, type, id);
            }
            else
            {
                sourcePart.Relationships.Create(new Uri(target, UriKind.Relative), TargetMode.Internal, type, id);
            }
        }
    }

    private static IPackagePart GetSourcePart(XElement flatOpcRelationshipPart, IPackage package)
    {
        var name = flatOpcRelationshipPart.Attribute(Pkg + "name")?.Value;

        if (name is null)
        {
            throw new InvalidDataException();
        }

        var directory = name.Substring(0, name.IndexOf("/_rels", StringComparison.Ordinal));
        var relsFilename = name.Substring(name.LastIndexOf('/'));
        var filename = relsFilename.Substring(0, relsFilename.IndexOf(".rels", StringComparison.Ordinal));

        return package.GetPart(new Uri(directory + filename, UriKind.Relative));
    }
}
