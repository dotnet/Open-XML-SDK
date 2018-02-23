// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.IO;
using System.IO.Packaging;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    public class PresentationDocumentTests : DocumentTests<PresentationDocument>
    {
        protected override string Path => TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical;

        protected override void AddMainPart(PresentationDocument source)
        {
            source.AddPresentationPart().Presentation = new Presentation.Presentation();
        }

        protected override PresentationDocument Create(Stream stream, bool isEditable) => PresentationDocument.Create(stream, PresentationDocumentType.Presentation, isEditable);

        protected override PresentationDocument Create(Stream stream) => PresentationDocument.Create(stream, PresentationDocumentType.Presentation);

        protected override void DuplicateMainPart(PresentationDocument source, PresentationDocument result)
        {
            var part = result.AddPresentationPart();
            part.Presentation = new Presentation.Presentation(source.PresentationPart.Presentation.OuterXml);
        }

        protected override PresentationDocument FromFlatOpcDocument(XDocument document) => PresentationDocument.FromFlatOpcDocument(document);

        protected override PresentationDocument FromFlatOpcDocument(XDocument document, Stream stream, bool isEditable) => PresentationDocument.FromFlatOpcDocument(document, stream, isEditable);

        protected override PresentationDocument FromFlatOpcDocument(XDocument document, string path, bool isEditable) => PresentationDocument.FromFlatOpcDocument(document, path, isEditable);

        protected override PresentationDocument FromFlatOpcDocument(XDocument document, Package package) => PresentationDocument.FromFlatOpcDocument(document, package);

        protected override PresentationDocument FromFlatOpcString(string text) => PresentationDocument.FromFlatOpcString(text);

        protected override PresentationDocument FromFlatOpcString(string text, Stream stream, bool isEditable) => PresentationDocument.FromFlatOpcString(text, stream, isEditable);

        protected override PresentationDocument FromFlatOpcString(string text, string path, bool isEditable) => PresentationDocument.FromFlatOpcString(text, path, isEditable);

        protected override PresentationDocument FromFlatOpcString(string text, Package package) => PresentationDocument.FromFlatOpcString(text, package);

        protected override PresentationDocument Open(Stream stream, bool isEditable) => PresentationDocument.Open(stream, isEditable);

        protected override PresentationDocument Open(Package package) => PresentationDocument.Open(package);

        protected override PresentationDocument Open(string path, bool isEditable) => PresentationDocument.Open(path, isEditable);
    }
}
