// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Threading;
using System.Xml.Linq;
using Xunit;

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

        [Fact]
        public void Open_WithCancellationToken_Stream_Succeeds()
        {
            using var stream = TestAssets.GetStream(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng);
            using var doc = SpreadsheetDocument.Open(stream, false, CancellationToken.None);
            Assert.NotNull(doc);
        }

        [Fact]
        public void Open_WithCancellationToken_StreamAndSettings_Succeeds()
        {
            using var stream = TestAssets.GetStream(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng);
            using var doc = SpreadsheetDocument.Open(stream, false, new OpenSettings(), CancellationToken.None);
            Assert.NotNull(doc);
        }

        [Fact]
        public void Open_WithCancelledToken_Stream_Throws()
        {
            using var stream = TestAssets.GetStream(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng);
            Assert.Throws<OperationCanceledException>(() => SpreadsheetDocument.Open(stream, false, new CancellationToken(canceled: true)));
        }

        [Fact]
        public void Open_WithCancelledToken_StreamAndSettings_Throws()
        {
            using var stream = TestAssets.GetStream(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng);
            Assert.Throws<OperationCanceledException>(() => SpreadsheetDocument.Open(stream, false, new OpenSettings(), new CancellationToken(canceled: true)));
        }

        [Fact]
        public void Open_WithCancellationToken_Path_Succeeds()
        {
            var path = TestAssets.GetTestFilePath(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng);
            try
            {
                using var doc = SpreadsheetDocument.Open(path, false, CancellationToken.None);
                Assert.NotNull(doc);
            }
            finally
            {
                File.Delete(path);
            }
        }

        [Fact]
        public void Open_WithCancelledToken_Path_Throws()
        {
            var path = TestAssets.GetTestFilePath(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng);
            try
            {
                Assert.Throws<OperationCanceledException>(() => SpreadsheetDocument.Open(path, false, new CancellationToken(canceled: true)));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
