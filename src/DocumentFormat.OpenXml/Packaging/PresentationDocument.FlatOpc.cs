// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
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
        => CreateDefaultBuilder()
            .Build()
            .WithFlatOpcTemplate(document)
            .Open();

    /// <summary>
    /// Creates a new instance of PresentationDocument from a presentation
    /// in Flat OPC format.
    /// </summary>
    /// <param name="document">The presentation in Flat OPC format.</param>
    /// <param name="stream">The stream on which the PresentationDocument will be created.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcDocument(XDocument document, Stream stream, bool isEditable)
        => CreateDefaultBuilder()
            .Build()
            .WithFlatOpcTemplate(document, isEditable)
            .Open(stream, PackageOpenMode.Create);

    /// <summary>
    /// Creates a new instance of PresentationDocument from a presentation
    /// in Flat OPC format.
    /// </summary>
    /// <param name="document">The presentation in Flat OPC format.</param>
    /// <param name="path">The path and file name of the target PresentationDocument.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcDocument(XDocument document, string path, bool isEditable)
        => CreateDefaultBuilder()
            .Build()
            .WithFlatOpcTemplate(document, isEditable)
            .Open(path, PackageOpenMode.Create);

    /// <summary>
    /// Creates a new instance of PresentationDocument from a presentation
    /// in Flat OPC format on the specified instance of Package.
    /// </summary>
    /// <param name="document">The presentation in Flat OPC format.</param>
    /// <param name="package">The specified instance of Package.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcDocument(XDocument document, Package package)
        => CreateDefaultBuilder()
            .Build()
            .WithFlatOpcTemplate(document)
            .Open(package);

    /// <summary>
    /// Creates a new instance of PresentationDocument from a string
    /// in Flat OPC format on a <see cref="MemoryStream"/> with expandable
    /// capacity.
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcString(string text)
        => CreateDefaultBuilder()
            .Build()
            .WithFlatOpcTemplate(text)
            .Open();

    /// <summary>
    /// Creates a new instance of PresentationDocument from a string
    /// in Flat OPC format on a
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <param name="stream">The <see cref="Stream"/> on which the PresentationDocument will be created.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcString(string text, Stream stream, bool isEditable)
        => CreateDefaultBuilder()
            .Build()
            .WithFlatOpcTemplate(text, isEditable)
            .Open(stream, PackageOpenMode.Create);

    /// <summary>
    /// Creates a new instance of PresentationDocument from a string
    /// in Flat OPC format.
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <param name="path">The path and file name of the target PresentationDocument.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcString(string text, string path, bool isEditable)
        => CreateDefaultBuilder()
            .Build()
            .WithFlatOpcTemplate(text, isEditable)
            .Open(path, PackageOpenMode.Create);

    /// <summary>
    /// Creates a new instance of PresentationDocument from a string
    /// in Flat OPC format.
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <param name="package">The <see cref="Package"/> of the target PresentationDocument.</param>
    /// <returns>A new instance of PresentationDocument.</returns>
    public static PresentationDocument FromFlatOpcString(string text, Package package)
        => CreateDefaultBuilder()
            .Build()
            .WithFlatOpcTemplate(text)
            .Open(package);
}
