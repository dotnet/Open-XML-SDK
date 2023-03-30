// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using System.IO.Packaging;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// Defines PresentationDocument - an OpenXmlPackage represents a Presentation document
/// </summary>
public partial class PresentationDocument
{
    /// <summary>
    /// Creates a new editable instance of PresentationDocument from an <see cref="XDocument"/>
    /// in Flat OPC format, opened on a <see cref="MemoryStream"/>.
    /// </summary>
    /// <param name="document">The document in Flat OPC format.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcDocument(XDocument document)
        => FromFlatOpcDocument(document, new MemoryStream(), true);

    /// <summary>
    /// Creates a new instance of PresentationDocument from a presentation
    /// in Flat OPC format.
    /// </summary>
    /// <param name="document">The presentation in Flat OPC format.</param>
    /// <param name="stream">The stream on which the PresentationDocument will be created.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcDocument(XDocument document, Stream stream, bool isEditable)
        => new PresentationDocument().LoadFlatOpcInternal(document, stream, isEditable);

    /// <summary>
    /// Creates a new instance of PresentationDocument from a presentation
    /// in Flat OPC format.
    /// </summary>
    /// <param name="document">The presentation in Flat OPC format.</param>
    /// <param name="path">The path and file name of the target PresentationDocument.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcDocument(XDocument document, string path, bool isEditable)
        => new PresentationDocument().LoadFlatOpcInternal(document, path, isEditable);

    /// <summary>
    /// Creates a new instance of PresentationDocument from a presentation
    /// in Flat OPC format on the specified instance of Package.
    /// </summary>
    /// <param name="document">The presentation in Flat OPC format.</param>
    /// <param name="package">The specified instance of Package.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcDocument(XDocument document, Package package)
        => new PresentationDocument().LoadFlatOpcInternal(document, package);

    /// <summary>
    /// Creates a new instance of PresentationDocument from a string
    /// in Flat OPC format on a <see cref="MemoryStream"/> with expandable
    /// capacity.
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcString(string text)
        => new PresentationDocument().LoadFlatOpcStringInternal(text);

    /// <summary>
    /// Creates a new instance of PresentationDocument from a string
    /// in Flat OPC format on a
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <param name="stream">The <see cref="Stream"/> on which the PresentationDocument will be created.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcString(string text, Stream stream, bool isEditable)
        => new PresentationDocument().LoadFlatOpcStringInternal(text, stream, isEditable);

    /// <summary>
    /// Creates a new instance of PresentationDocument from a string
    /// in Flat OPC format.
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <param name="path">The path and file name of the target PresentationDocument.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcString(string text, string path, bool isEditable)
        => new PresentationDocument().LoadFlatOpcStringInternal(text, path, isEditable);

    /// <summary>
    /// Creates a new instance of PresentationDocument from a string
    /// in Flat OPC format.
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <param name="package">The <see cref="Package"/> of the target PresentationDocument.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcString(string text, Package package)
        => new PresentationDocument().LoadFlatOpcStringInternal(text, package);
}
