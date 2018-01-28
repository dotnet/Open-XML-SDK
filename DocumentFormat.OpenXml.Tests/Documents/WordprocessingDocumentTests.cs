// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.IO.Packaging;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    public class WordprocessingDocumentTests : DocumentTests<WordprocessingDocument>
    {
        protected override string Path => TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm;

        protected override void AddMainPart(WordprocessingDocument source)
        {
            source.AddMainDocumentPart().Document = new Document();
        }

        protected override WordprocessingDocument Create(Stream stream, bool autosave) => WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document, autosave);

        protected override WordprocessingDocument Create(Stream stream) => WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

        protected override void DuplicateMainPart(WordprocessingDocument source, WordprocessingDocument result)
        {
            var part = result.AddMainDocumentPart();
            part.Document = (Document)source.MainDocumentPart.Document.CloneNode(true);
        }

        protected override WordprocessingDocument FromFlatOpcDocument(XDocument document) => WordprocessingDocument.FromFlatOpcDocument(document);

        protected override WordprocessingDocument FromFlatOpcDocument(XDocument document, Stream stream, bool isEditable) => WordprocessingDocument.FromFlatOpcDocument(document, stream, isEditable);

        protected override WordprocessingDocument FromFlatOpcDocument(XDocument document, string path, bool isEditable) => WordprocessingDocument.FromFlatOpcDocument(document, path, isEditable);

        protected override WordprocessingDocument FromFlatOpcDocument(XDocument document, Package package) => WordprocessingDocument.FromFlatOpcDocument(document, package);

        protected override WordprocessingDocument FromFlatOpcString(string text) => WordprocessingDocument.FromFlatOpcString(text);

        protected override WordprocessingDocument FromFlatOpcString(string text, Stream stream, bool isEditable) => WordprocessingDocument.FromFlatOpcString(text, stream, isEditable);

        protected override WordprocessingDocument FromFlatOpcString(string text, string path, bool isEditable) => WordprocessingDocument.FromFlatOpcString(text, path, isEditable);

        protected override WordprocessingDocument FromFlatOpcString(string text, Package package) => WordprocessingDocument.FromFlatOpcString(text, package);

        protected override WordprocessingDocument Open(Stream stream, bool isEditable) => WordprocessingDocument.Open(stream, isEditable);

        protected override WordprocessingDocument Open(Package package) => WordprocessingDocument.Open(package);

        protected override WordprocessingDocument Open(string path, bool isEditable) => WordprocessingDocument.Open(path, isEditable);
    }
}
