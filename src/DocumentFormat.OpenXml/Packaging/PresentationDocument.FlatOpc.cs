// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.IO.Packaging;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines PresentationDocument - an OpenXmlPackage represents a Presentation document
    /// </summary>
    public partial class PresentationDocument : OpenXmlPackage
    {
        /// <summary>
        /// Converts an OpenXml package in OPC format to an <see cref="XDocument"/>
        /// in Flat OPC format.
        /// </summary>
        /// <returns>The OpenXml package in Flat OPC format.</returns>
        public override XDocument ToFlatOpcDocument()
        {
            return ToFlatOpcDocument(new XProcessingInstruction("mso-application", "progid=\"PowerPoint.Show\""));
        }

        /// <summary>
        /// Creates a new editable instance of PresentationDocument from an <see cref="XDocument"/>
        /// in Flat OPC format, opened on a <see cref="MemoryStream"/>.
        /// </summary>
        /// <param name="document">The document in Flat OPC format.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        public static PresentationDocument FromFlatOpcDocument(XDocument document)
        {
            return FromFlatOpcDocument(document, new MemoryStream(), true);
        }

        /// <summary>
        /// Creates a new instance of PresentationDocument from a presentation
        /// in Flat OPC format.
        /// </summary>
        /// <param name="document">The presentation in Flat OPC format.</param>
        /// <param name="stream">The stream on which the PresentationDocument will be created.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        public static PresentationDocument FromFlatOpcDocument(XDocument document, Stream stream, bool isEditable)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            return PresentationDocument.Open(FromFlatOpcDocumentCore(document, stream), isEditable);
        }

        /// <summary>
        /// Creates a new instance of PresentationDocument from a presentation
        /// in Flat OPC format.
        /// </summary>
        /// <param name="document">The presentation in Flat OPC format.</param>
        /// <param name="path">The path and file name of the target PresentationDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        public static PresentationDocument FromFlatOpcDocument(XDocument document, string path, bool isEditable)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            return PresentationDocument.Open(FromFlatOpcDocumentCore(document, path), isEditable);
        }

        /// <summary>
        /// Creates a new instance of PresentationDocument from a presentation
        /// in Flat OPC format on the specified instance of Package.
        /// </summary>
        /// <param name="document">The presentation in Flat OPC format.</param>
        /// <param name="package">The specified instance of Package.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        public static PresentationDocument FromFlatOpcDocument(XDocument document, Package package)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));
            if (package == null)
                throw new ArgumentNullException(nameof(package));

            return PresentationDocument.Open(FromFlatOpcDocumentCore(document, package));
        }

        /// <summary>
        /// Creates a new instance of PresentationDocument from a string
        /// in Flat OPC format on a <see cref="MemoryStream"/> with expandable
        /// capacity.
        /// </summary>
        /// <param name="text">The string in Flat OPC format.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        public static PresentationDocument FromFlatOpcString(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            return FromFlatOpcDocument(XDocument.Parse(text), new MemoryStream(), true);
        }

        /// <summary>
        /// Creates a new instance of PresentationDocument from a string
        /// in Flat OPC format on a
        /// </summary>
        /// <param name="text">The string in Flat OPC format.</param>
        /// <param name="stream">The <see cref="Stream"/> on which the PresentationDocument will be created.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        public static PresentationDocument FromFlatOpcString(string text, Stream stream, bool isEditable)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            return FromFlatOpcDocument(XDocument.Parse(text), stream, isEditable);
        }

        /// <summary>
        /// Creates a new instance of PresentationDocument from a string
        /// in Flat OPC format.
        /// </summary>
        /// <param name="text">The string in Flat OPC format.</param>
        /// <param name="path">The path and file name of the target PresentationDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        public static PresentationDocument FromFlatOpcString(string text, string path, bool isEditable)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            return FromFlatOpcDocument(XDocument.Parse(text), path, isEditable);
        }

        /// <summary>
        /// Creates a new instance of PresentationDocument from a string
        /// in Flat OPC format.
        /// </summary>
        /// <param name="text">The string in Flat OPC format.</param>
        /// <param name="package">The <see cref="Package"/> of the target PresentationDocument.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        public static PresentationDocument FromFlatOpcString(string text, Package package)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));
            if (package == null)
                throw new ArgumentNullException(nameof(package));

            return FromFlatOpcDocument(XDocument.Parse(text), package);
        }
    }
}
