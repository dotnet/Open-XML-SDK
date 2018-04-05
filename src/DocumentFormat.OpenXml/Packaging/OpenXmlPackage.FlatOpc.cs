// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
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
    public abstract partial class OpenXmlPackage : OpenXmlPartContainer, IDisposable
    {
        private static readonly XNamespace pkg = "http://schemas.microsoft.com/office/2006/xmlPackage";
        private static readonly XNamespace rel = "http://schemas.openxmlformats.org/package/2006/relationships";

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

            // Create an XML document with a standalone declaration, processing
            // instruction (if not null), and a package root element with a
            // namespace declaration and one child element for each part.
            return new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                instruction,
                new XElement(
                    pkg + "package",
                    new XAttribute(XNamespace.Xmlns + "pkg", pkg.ToString()),
                    Package.GetParts().Select(part => GetContentsAsXml(part))));
        }

        /// <summary>
        /// Gets the <see cref="PackagePart"/>'s contents as an <see cref="XElement"/>.
        /// </summary>
        /// <param name="part">The package part.</param>
        /// <returns>The corresponding <see cref="XElement"/>.</returns>
        private static XElement GetContentsAsXml(PackagePart part)
        {
            if (part.ContentType.EndsWith("xml"))
            {
                using (Stream stream = part.GetStream())
                using (StreamReader streamReader = new StreamReader(stream))
                using (XmlReader xmlReader = XmlReader.Create(streamReader))
                    return new XElement(pkg + "part",
                        new XAttribute(pkg + "name", part.Uri),
                        new XAttribute(pkg + "contentType", part.ContentType),
                        new XElement(pkg + "xmlData", XElement.Load(xmlReader)));
            }
            else
            {
                using (Stream stream = part.GetStream())
                using (BinaryReader binaryReader = new BinaryReader(stream))
                {
                    int len = (int)binaryReader.BaseStream.Length;
                    byte[] byteArray = binaryReader.ReadBytes(len);

                    // The following expression creates the base64String, then chunks
                    // it to lines of 76 characters long.
                    string base64String = System.Convert.ToBase64String(byteArray)
                        .Select((c, i) => new { Character = c, Chunk = i / 76 })
                        .GroupBy(c => c.Chunk)
                        .Aggregate(
                            new StringBuilder(),
                            (s, i) =>
                                s.Append(
                                    i.Aggregate(
                                        new StringBuilder(),
                                        (seed, it) => seed.Append(it.Character),
                                        sb => sb.ToString())).Append(Environment.NewLine),
                            s => s.ToString());

                    return new XElement(pkg + "part",
                        new XAttribute(pkg + "name", part.Uri),
                        new XAttribute(pkg + "contentType", part.ContentType),
                        new XAttribute(pkg + "compression", "store"),
                        new XElement(pkg + "binaryData", base64String));
                }
            }
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
            // Add all parts (but not relationships).
            foreach (var xmlPart in document.Root
                .Elements()
                .Where(p =>
                    (string)p.Attribute(pkg + "contentType") !=
                        "application/vnd.openxmlformats-package.relationships+xml"))
            {
                string name = (string)xmlPart.Attribute(pkg + "name");
                string contentType = (string)xmlPart.Attribute(pkg + "contentType");
                if (contentType.EndsWith("xml"))
                {
                    Uri uri = new Uri(name, UriKind.Relative);
                    PackagePart part = package.CreatePart(uri, contentType, CompressionOption.SuperFast);
                    using (Stream stream = part.GetStream(FileMode.Create))
                    using (XmlWriter xmlWriter = XmlWriter.Create(stream))
                        xmlPart.Element(pkg + "xmlData")
                            .Elements()
                            .First()
                            .WriteTo(xmlWriter);
                }
                else
                {
                    Uri uri = new Uri(name, UriKind.Relative);
                    PackagePart part = package.CreatePart(uri, contentType, CompressionOption.SuperFast);
                    using (Stream stream = part.GetStream(FileMode.Create))
                    using (BinaryWriter binaryWriter = new BinaryWriter(stream))
                    {
                        string base64StringInChunks = (string)xmlPart.Element(pkg + "binaryData");
                        char[] base64CharArray = base64StringInChunks
                            .Where(c => c != '\r' && c != '\n').ToArray();
                        byte[] byteArray =
                            System.Convert.FromBase64CharArray(
                                base64CharArray, 0, base64CharArray.Length);
                        binaryWriter.Write(byteArray);
                    }
                }
            }

            foreach (var xmlPart in document.Root.Elements())
            {
                string name = (string)xmlPart.Attribute(pkg + "name");
                string contentType = (string)xmlPart.Attribute(pkg + "contentType");
                if (contentType == "application/vnd.openxmlformats-package.relationships+xml")
                {
                    if (name == "/_rels/.rels")
                    {
                        // Add the package level relationships.
                        foreach (XElement xmlRel in xmlPart.Descendants(rel + "Relationship"))
                        {
                            string id = (string)xmlRel.Attribute("Id");
                            string type = (string)xmlRel.Attribute("Type");
                            string target = (string)xmlRel.Attribute("Target");
                            string targetMode = (string)xmlRel.Attribute("TargetMode");
                            if (targetMode == "External")
                                package.CreateRelationship(
                                    new Uri(target, UriKind.Absolute),
                                    TargetMode.External, type, id);
                            else
                                package.CreateRelationship(
                                    new Uri(target, UriKind.Relative),
                                    TargetMode.Internal, type, id);
                        }
                    }
                    else
                    {
                        // Add part level relationships.
                        string directory = name.Substring(0, name.IndexOf("/_rels"));
                        string relsFilename = name.Substring(name.LastIndexOf('/'));
                        string filename = relsFilename.Substring(0, relsFilename.IndexOf(".rels"));
                        PackagePart fromPart = package.GetPart(new Uri(directory + filename, UriKind.Relative));
                        foreach (XElement xmlRel in xmlPart.Descendants(rel + "Relationship"))
                        {
                            string id = (string)xmlRel.Attribute("Id");
                            string type = (string)xmlRel.Attribute("Type");
                            string target = (string)xmlRel.Attribute("Target");
                            string targetMode = (string)xmlRel.Attribute("TargetMode");
                            if (targetMode == "External")
                                fromPart.CreateRelationship(
                                    new Uri(target, UriKind.Absolute),
                                    TargetMode.External, type, id);
                            else
                                fromPart.CreateRelationship(
                                    new Uri(target, UriKind.Relative),
                                    TargetMode.Internal, type, id);
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
