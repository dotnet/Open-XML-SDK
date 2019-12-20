// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents a base class for strong typed Open XML document classes.
    /// </summary>
    public abstract partial class OpenXmlPackage
    {
        private static readonly XNamespace Pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";
        private static readonly XNamespace Rel = "http://schemas.openxmlformats.org/package/2006/relationships";

        private const string RelationshipContentType =
            "application/vnd.openxmlformats-package.relationships+xml";

        private const string AltChunkRelationshipType =
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk";

        /// <summary>
        /// Converts an OpenXml package in OPC format to string in Flat OPC format.
        /// </summary>
        /// <returns>The OpenXml package in Flat OPC format.</returns>
        public string ToFlatOpcString()
        {
            return ToFlatOpcDocument().ToString();
        }

        /// <summary>
        /// Converts an OpenXml package in OPC format to an <see cref="XDocument"/>
        /// in Flat OPC format.
        /// </summary>
        /// <returns>The OpenXml package in Flat OPC format.</returns>
        public abstract XDocument ToFlatOpcDocument();

        /// <summary>
        /// Converts an OpenXml package in OPC format to an <see cref="XDocument"/>
        /// in Flat OPC format.
        /// </summary>
        /// <param name="instruction">The processing instruction.</param>
        /// <returns>The OpenXml package in Flat OPC format.</returns>
        protected XDocument ToFlatOpcDocument(XProcessingInstruction instruction)
        {
            // Save the contents of all parts and relationships that are contained
            // in the OpenXml package to make sure we convert a consistent state.
            // This will also invoke ThrowIfObjectDisposed(), so we don't need
            // to call it here.
            Save();

            // Identify all AlternativeFormatInputParts (AltChunk parts).
            // This is necessary because AltChunk parts must be treated as binary
            // parts regardless of the actual content type, which might even be
            // XML-related such as application/xhtml+xml.
            var altChunkPartUris = new HashSet<Uri>(
                Package.GetParts()
                    .Where(part => part.ContentType != RelationshipContentType)
                    .SelectMany(part => part.GetRelationshipsByType(AltChunkRelationshipType))
                    .Select(pr => PackUriHelper.ResolvePartUri(pr.SourceUri, pr.TargetUri)));

            // Create an XML document with a standalone declaration, processing
            // instruction (if not null), and a package root element with a
            // namespace declaration and one child element for each part.
            return new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                instruction,
                new XElement(
                    Pkg + "package",
                    new XAttribute(XNamespace.Xmlns + "pkg", Pkg.ToString()),
                    Package.GetParts().Select(part => GetContentsAsXml(part, altChunkPartUris))));
        }

        /// <summary>
        /// Gets the <see cref="PackagePart"/>'s XML or binary contents as an <see cref="XElement"/>.
        /// </summary>
        /// <param name="part">The package part.</param>
        /// <param name="altChunkPartUris">The collection of AlternativeFormatInputPart URIs.</param>
        /// <returns>The corresponding <see cref="XElement"/>.</returns>
        private static XElement GetContentsAsXml(PackagePart part, HashSet<Uri> altChunkPartUris)
        {
            if (part.ContentType.EndsWith("xml") && !altChunkPartUris.Contains(part.Uri))
            {
                using (Stream stream = part.GetStream())
                using (var streamReader = new StreamReader(stream))
                using (XmlReader xmlReader = XmlReader.Create(streamReader))
                {
                    return new XElement(
                        Pkg + "part",
                        new XAttribute(Pkg + "name", part.Uri),
                        new XAttribute(Pkg + "contentType", part.ContentType),
                        new XElement(Pkg + "xmlData", XElement.Load(xmlReader)));
                }
            }

            return GetBinaryPartContentsAsXml(part);
        }

        private static XElement GetBinaryPartContentsAsXml(PackagePart part)
        {
            return new XElement(
                Pkg + "part",
                new XAttribute(Pkg + "name", part.Uri),
                new XAttribute(Pkg + "contentType", part.ContentType),
                new XAttribute(Pkg + "compression", "store"),
                new XElement(Pkg + "binaryData", ToChunkedBase64String(part)));
        }

        private static string ToChunkedBase64String(PackagePart part)
        {
            using (Stream stream = part.GetStream())
            {
                var byteArray = new byte[stream.Length];
                stream.Read(byteArray, 0, byteArray.Length);
                return ToChunkedBase64String(byteArray);
            }
        }

        private static string ToChunkedBase64String(byte[] byteArray)
        {
            return Convert.ToBase64String(byteArray)
                .Select((@char, index) => new { Character = @char, Chunk = index / 76 })
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

        /// <summary>
        /// Converts an <see cref="XDocument"/> in Flat OPC format to an OpenXml package
        /// stored on a <see cref="Stream"/>.
        /// </summary>
        /// <param name="document">The document in Flat OPC format.</param>
        /// <param name="stream">The <see cref="Stream"/> on which to store the OpenXml package.</param>
        /// <returns>The <see cref="Stream"/> containing the OpenXml package.</returns>
        protected static Stream FromFlatOpcDocumentCore(XDocument document, Stream stream)
        {
            using (Package package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
            {
                FromFlatOpcDocumentCore(document, package);
            }

            return stream;
        }

        /// <summary>
        /// Converts an <see cref="XDocument"/> in Flat OPC format to an OpenXml package
        /// stored in a file.
        /// </summary>
        /// <param name="document">The document in Flat OPC format.</param>
        /// <param name="path">The path and file name of the file in which to store the OpenXml package.</param>
        /// <returns>The path and file name of the file containing the OpenXml package.</returns>
        protected static string FromFlatOpcDocumentCore(XDocument document, string path)
        {
            using (Package package = Package.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
            {
                FromFlatOpcDocumentCore(document, package);
            }

            return path;
        }

        /// <summary>
        /// Converts an <see cref="XDocument"/> in Flat OPC format to an OpenXml package
        /// stored in a <see cref="Package"/>.
        /// </summary>
        /// <param name="document">The document in Flat OPC format.</param>
        /// <param name="package">The <see cref="Package"/> in which to store the OpenXml package.</param>
        /// <returns>The <see cref="Package"/> containing the OpenXml package.</returns>
        protected static Package FromFlatOpcDocumentCore(XDocument document, Package package)
        {
            if (document is null)
            {
                throw new ArgumentNullException(nameof(document));
            }

            if (package is null)
            {
                throw new ArgumentNullException(nameof(package));
            }

            if (document.Root is null)
            {
                throw new ArgumentException(ExceptionMessages.RootElementIsNull, nameof(document));
            }

            // Add all parts (but not relationships).
            foreach (XElement xmlPart in document.Root
                .Elements()
                .Where(p =>
                    (string) p.Attribute(Pkg + "contentType") !=
                    "application/vnd.openxmlformats-package.relationships+xml"))
            {
                var name = (string) xmlPart.Attribute(Pkg + "name");
                var contentType = (string) xmlPart.Attribute(Pkg + "contentType");
                if (contentType.EndsWith("xml"))
                {
                    var uri = new Uri(name, UriKind.Relative);
                    PackagePart part = package.CreatePart(uri, contentType, CompressionOption.SuperFast);
                    using (Stream stream = part.GetStream(FileMode.Create))
                    using (XmlWriter xmlWriter = XmlWriter.Create(stream))
                    {
                        xmlPart.Elements(Pkg + "xmlData")
                            .Elements()
                            .First()
                            .WriteTo(xmlWriter);
                    }
                }
                else
                {
                    var uri = new Uri(name, UriKind.Relative);
                    PackagePart part = package.CreatePart(uri, contentType, CompressionOption.SuperFast);
                    using (Stream stream = part.GetStream(FileMode.Create))
                    using (var binaryWriter = new BinaryWriter(stream))
                    {
                        var base64StringInChunks = (string) xmlPart.Element(Pkg + "binaryData");
                        char[] base64CharArray = base64StringInChunks.Where(c => c != '\r' && c != '\n').ToArray();
                        byte[] byteArray = Convert.FromBase64CharArray(base64CharArray, 0, base64CharArray.Length);
                        binaryWriter.Write(byteArray);
                    }
                }
            }

            foreach (XElement xmlPart in document.Root.Elements())
            {
                var name = (string) xmlPart.Attribute(Pkg + "name");
                var contentType = (string) xmlPart.Attribute(Pkg + "contentType");
                if (contentType == "application/vnd.openxmlformats-package.relationships+xml")
                {
                    if (name == "/_rels/.rels")
                    {
                        // Add the package level relationships.
                        foreach (XElement xmlRel in xmlPart.Descendants(Rel + "Relationship"))
                        {
                            var id = (string) xmlRel.Attribute("Id");
                            var type = (string) xmlRel.Attribute("Type");
                            var target = (string) xmlRel.Attribute("Target");
                            var targetMode = (string) xmlRel.Attribute("TargetMode");
                            if (targetMode == "External")
                            {
                                package.CreateRelationship(
                                    new Uri(target, UriKind.Absolute),
                                    TargetMode.External, type, id);
                            }
                            else
                            {
                                package.CreateRelationship(
                                    new Uri(target, UriKind.Relative),
                                    TargetMode.Internal, type, id);
                            }
                        }
                    }
                    else
                    {
                        // Add part level relationships.
                        string directory = name.Substring(0, name.IndexOf("/_rels", StringComparison.Ordinal));
                        string relsFilename = name.Substring(name.LastIndexOf('/'));
                        string filename = relsFilename.Substring(0, relsFilename.IndexOf(".rels", StringComparison.Ordinal));
                        PackagePart fromPart = package.GetPart(new Uri(directory + filename, UriKind.Relative));
                        foreach (XElement xmlRel in xmlPart.Descendants(Rel + "Relationship"))
                        {
                            var id = (string) xmlRel.Attribute("Id");
                            var type = (string) xmlRel.Attribute("Type");
                            var target = (string) xmlRel.Attribute("Target");
                            var targetMode = (string) xmlRel.Attribute("TargetMode");
                            if (targetMode == "External")
                            {
                                fromPart.CreateRelationship(
                                    new Uri(target, UriKind.Absolute),
                                    TargetMode.External, type, id);
                            }
                            else
                            {
                                fromPart.CreateRelationship(
                                    new Uri(target, UriKind.Relative),
                                    TargetMode.Internal, type, id);
                            }
                        }
                    }
                }
            }

            // Save contents of all parts and relationships contained in package.
            package.Flush();
            return package;
        }
    }
}
