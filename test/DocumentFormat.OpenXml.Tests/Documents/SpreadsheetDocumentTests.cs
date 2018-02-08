// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    public class SpreadsheetDocumentTests : DocumentTests<SpreadsheetDocument>
    {
        protected override string Path => TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng;

        protected override void AddMainPart(SpreadsheetDocument source)
        {
            source.AddWorkbookPart().Workbook = new Workbook();
        }

        protected override SpreadsheetDocument Create(Stream stream, bool autosave) => SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook, autosave);

        protected override SpreadsheetDocument Create(Stream stream) => SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook);

        protected override void DuplicateMainPart(SpreadsheetDocument source, SpreadsheetDocument result)
        {
            var part = result.AddWorkbookPart();
            part.Workbook = new Workbook();
            part.Workbook.Append(source.WorkbookPart.Workbook.ChildElements.Select(c => c.CloneNode(true)));
        }

        protected override SpreadsheetDocument FromFlatOpcDocument(XDocument document) => SpreadsheetDocument.FromFlatOpcDocument(document);

        protected override SpreadsheetDocument FromFlatOpcDocument(XDocument document, Stream stream, bool isEditable) => SpreadsheetDocument.FromFlatOpcDocument(document, stream, isEditable);

        protected override SpreadsheetDocument FromFlatOpcDocument(XDocument document, string path, bool isEditable) => SpreadsheetDocument.FromFlatOpcDocument(document, path, isEditable);

        protected override SpreadsheetDocument FromFlatOpcDocument(XDocument document, Package package) => SpreadsheetDocument.FromFlatOpcDocument(document, package);

        protected override SpreadsheetDocument FromFlatOpcString(string text) => SpreadsheetDocument.FromFlatOpcString(text);

        protected override SpreadsheetDocument FromFlatOpcString(string text, Stream stream, bool isEditable) => SpreadsheetDocument.FromFlatOpcString(text, stream, isEditable);

        protected override SpreadsheetDocument FromFlatOpcString(string text, string path, bool isEditable) => SpreadsheetDocument.FromFlatOpcString(text, path, isEditable);

        protected override SpreadsheetDocument FromFlatOpcString(string text, Package package) => SpreadsheetDocument.FromFlatOpcString(text, package);

        protected override SpreadsheetDocument Open(Stream stream, bool isEditable) => SpreadsheetDocument.Open(stream, isEditable);

        protected override SpreadsheetDocument Open(Package package) => SpreadsheetDocument.Open(package);

        protected override SpreadsheetDocument Open(string path, bool isEditable) => SpreadsheetDocument.Open(path, isEditable);
    }
}
