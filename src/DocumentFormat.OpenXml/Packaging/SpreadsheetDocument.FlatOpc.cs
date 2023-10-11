// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
using System.IO;
using System.IO.Packaging;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging;

public partial class SpreadsheetDocument
{
    /// <summary>
    /// Creates a new editable instance of SpreadsheetDocument from an <see cref="XDocument"/>
    /// in Flat OPC format, opened on a <see cref="MemoryStream"/>.
    /// </summary>
    /// <param name="document">The document in Flat OPC format.</param>
    /// <returns>A new instance of SpreadsheetDocument.</returns>
    public static SpreadsheetDocument FromFlatOpcDocument(XDocument document)
        => CreateDefaultBuilder()
            .UseFlatOpcTemplate(document)
            .Open();

    /// <summary>
    /// Creates a new instance of SpreadsheetDocument from a workbook
    /// in Flat OPC format.
    /// </summary>
    /// <param name="document">The workbook in Flat OPC format.</param>
    /// <param name="stream">The stream on which the SpreadsheetDocument will be created.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of SpreadsheetDocument.</returns>
    public static SpreadsheetDocument FromFlatOpcDocument(XDocument document, Stream stream, bool isEditable)
        => CreateDefaultBuilder()
            .UseFlatOpcTemplate(document)
            .Open(stream, isEditable);

    /// <summary>
    /// Creates a new instance of SpreadsheetDocument from a workbook
    /// in Flat OPC format.
    /// </summary>
    /// <param name="document">The workbook in Flat OPC format.</param>
    /// <param name="path">The path and file name of the target SpreadsheetDocument.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of SpreadsheetDocument.</returns>
    public static SpreadsheetDocument FromFlatOpcDocument(XDocument document, string path, bool isEditable)
        => CreateDefaultBuilder()
            .UseFlatOpcTemplate(document)
            .Open(path, isEditable);

    /// <summary>
    /// Creates a new instance of SpreadsheetDocument from a workbook
    /// in Flat OPC format on the specified instance of Package.
    /// </summary>
    /// <param name="document">The workbook in Flat OPC format.</param>
    /// <param name="package">The specified instance of Package.</param>
    /// <returns>A new instance of SpreadsheetDocument.</returns>
    public static SpreadsheetDocument FromFlatOpcDocument(XDocument document, Package package)
        => CreateDefaultBuilder()
            .UseFlatOpcTemplate(document)
            .Open(package);

    /// <summary>
    /// Creates a new instance of SpreadsheetDocument from a string
    /// in Flat OPC format on a <see cref="MemoryStream"/> with expandable
    /// capacity.
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <returns>A new instance of SpreadsheetDocument.</returns>
    public static SpreadsheetDocument FromFlatOpcString(string text)
        => CreateDefaultBuilder()
            .UseFlatOpcTemplate(text)
            .Open();

    /// <summary>
    /// Creates a new instance of SpreadsheetDocument from a string
    /// in Flat OPC format on a
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <param name="stream">The <see cref="Stream"/> on which the SpreadsheetDocument will be created.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of SpreadsheetDocument.</returns>
    public static SpreadsheetDocument FromFlatOpcString(string text, Stream stream, bool isEditable)
        => CreateDefaultBuilder()
            .UseFlatOpcTemplate(text)
            .Open(stream, isEditable);

    /// <summary>
    /// Creates a new instance of SpreadsheetDocument from a string
    /// in Flat OPC format.
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <param name="path">The path and file name of the target SpreadsheetDocument.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>A new instance of SpreadsheetDocument.</returns>
    public static SpreadsheetDocument FromFlatOpcString(string text, string path, bool isEditable)
        => CreateDefaultBuilder()
            .UseFlatOpcTemplate(text)
            .Open(path, isEditable);

    /// <summary>
    /// Creates a new instance of SpreadsheetDocument from a string
    /// in Flat OPC format.
    /// </summary>
    /// <param name="text">The string in Flat OPC format.</param>
    /// <param name="package">The <see cref="Package"/> of the target SpreadsheetDocument.</param>
    /// <returns>A new instance of SpreadsheetDocument.</returns>
    public static SpreadsheetDocument FromFlatOpcString(string text, Package package)
        => CreateDefaultBuilder()
            .UseFlatOpcTemplate(text)
            .Open(package);
}
