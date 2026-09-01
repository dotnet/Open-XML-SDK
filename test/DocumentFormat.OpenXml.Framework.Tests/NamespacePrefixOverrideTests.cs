// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Xunit;

using Bold = DocumentFormat.OpenXml.Wordprocessing.Bold;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using RunProperties = DocumentFormat.OpenXml.Wordprocessing.RunProperties;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class NamespacePrefixOverrideTests
    {
        private const string SpreadsheetNamespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";
        private const string WordprocessingNamespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";

        [Fact]
        public void WithoutOverridePrefixIsUnchanged()
        {
            var xml = CreateSpreadsheet(configure: null);

            Assert.Contains("<x:worksheet ", xml, StringComparison.Ordinal);
            Assert.Contains($"xmlns:x=\"{SpreadsheetNamespace}\"", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void DefaultForWritesUnprefixedRoot()
        {
            var xml = CreateSpreadsheet(package =>
                package.Features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(SpreadsheetNamespace)));

            Assert.Contains($"<worksheet xmlns=\"{SpreadsheetNamespace}\"", xml, StringComparison.Ordinal);
            Assert.DoesNotContain("xmlns:x=", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void DefaultForWritesUnprefixedDescendants()
        {
            var xml = CreateSpreadsheet(package =>
                package.Features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(SpreadsheetNamespace)));

            Assert.Contains("<sheetData>", xml, StringComparison.Ordinal);
            Assert.Contains("<c r=\"A1\"", xml, StringComparison.Ordinal);
            Assert.DoesNotContain("<x:", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void OverrideCanSupplyACustomPrefix()
        {
            var xml = CreateSpreadsheet(package =>
                package.Features.SetNamespacePrefixOverride(ns => ns == SpreadsheetNamespace ? "ss" : null));

            Assert.Contains("<ss:worksheet ", xml, StringComparison.Ordinal);
            Assert.Contains($"xmlns:ss=\"{SpreadsheetNamespace}\"", xml, StringComparison.Ordinal);
            Assert.DoesNotContain("<x:", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void OverrideOnlyAffectsTheNamespacesItClaims()
        {
            var xml = CreateSpreadsheet(
                package => package.Features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(SpreadsheetNamespace)),
                part: "workbook");

            // The relationship namespace is untouched, so r:id keeps working.
            Assert.Contains("r:id=", xml, StringComparison.Ordinal);
            Assert.Contains("xmlns:r=", xml, StringComparison.Ordinal);
            Assert.Contains($"<workbook xmlns=\"{SpreadsheetNamespace}\"", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void ReturningNullFallsBackToTheBuiltInPrefix()
        {
            var xml = CreateSpreadsheet(package =>
                package.Features.SetNamespacePrefixOverride(_ => null));

            Assert.Contains("<x:worksheet ", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void OverrideAppliesToWordprocessingToo()
        {
            using var stream = new MemoryStream();

            using (var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                document.Features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(WordprocessingNamespace));

                var mainPart = document.AddMainDocumentPart();
                mainPart.Document = new Document(new Body(new Paragraph(new Run(new Text("hello")))));
                mainPart.Document.Save();
            }

            var xml = ReadPart(stream, "word/document.xml");

            Assert.Contains($"<document xmlns=\"{WordprocessingNamespace}\"", xml, StringComparison.Ordinal);
            Assert.DoesNotContain("<w:", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void NamespaceQualifiedAttributesDoNotFlipDescendantsBack()
        {
            // A w:-qualified attribute forces the underlying writer to declare xmlns:w on its
            // element, after which XmlWriter.LookupPrefix reports "w" for the namespace. Anything
            // resolving prefixes from the writer's scope would silently revert the rest of the
            // subtree to w:. WordprocessingML is full of such attributes; SpreadsheetML is not,
            // which is why the other tests here cannot catch this.
            using var stream = new MemoryStream();

            using (var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                document.Features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(WordprocessingNamespace));

                var mainPart = document.AddMainDocumentPart();
                var paragraph = new Paragraph(new Run(new RunProperties(new Bold { Val = true }), new Text("hello")))
                {
                    RsidParagraphAddition = "00AB12CD",
                };

                mainPart.Document = new Document(new Body(paragraph));
                mainPart.Document.Save();
            }

            var xml = ReadPart(stream, "word/document.xml");

            // The attribute itself must keep a real prefix - an empty prefix on an attribute means
            // "no namespace" - but no element may be prefixed.
            Assert.Contains("w:rsidR=\"00AB12CD\"", xml, StringComparison.Ordinal);
            Assert.Contains("<r>", xml, StringComparison.Ordinal);
            Assert.Contains("<t>hello</t>", xml, StringComparison.Ordinal);
            Assert.DoesNotContain("<w:", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void OverrideAppliesToUnknownElements()
        {
            // OpenXmlUnknownElement writes the prefix it was parsed with rather than resolving one,
            // so extension content would otherwise keep the built-in prefix.
            var worksheet = new Worksheet(new SheetData());
            worksheet.AppendChild(new OpenXmlUnknownElement("x", "custom", SpreadsheetNamespace));

            var xml = SaveWorksheet(
                worksheet,
                features => features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(SpreadsheetNamespace)));

            Assert.Contains("<custom", xml, StringComparison.Ordinal);
            Assert.DoesNotContain("<x:", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void ExistingPrefixDeclarationIsPreservedButNoElementUsesIt()
        {
            // A document loaded from disk carries its own xmlns:x declaration. It is kept - binding
            // both a prefix and the default prefix to one namespace is legal, and dropping it would
            // strand qualified attributes and mc:Ignorable values that name the prefix - but the
            // override still decides every element name.
            var element = new Worksheet(new SheetData(new Row(new Cell { CellReference = "A1" })));
            element.AddNamespaceDeclaration("x", SpreadsheetNamespace);

            using var stream = new MemoryStream();

            using (var document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook))
            {
                document.Features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(SpreadsheetNamespace));

                var workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = element;
                worksheetPart.Worksheet.Save();
            }

            var xml = ReadPart(stream, "xl/worksheets/sheet1.xml");

            Assert.Contains($"xmlns=\"{SpreadsheetNamespace}\"", xml, StringComparison.Ordinal);
            Assert.DoesNotContain("<x:", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void UnparsedRootIsWrittenVerbatim()
        {
            // A root supplied as raw XML and never parsed is copied through unchanged, so the
            // override does not reach it. Forcing a parse to close that gap would re-serialize
            // content the SDK can copy but not always re-read, so the copy wins.
            using var stream = new MemoryStream();

            using (var document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook))
            {
                document.Features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(SpreadsheetNamespace));

                var workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(
                    $"<x:worksheet xmlns:x=\"{SpreadsheetNamespace}\"><x:sheetData /></x:worksheet>");
                worksheetPart.Worksheet.Save();
            }

            var xml = ReadPart(stream, "xl/worksheets/sheet1.xml");

            Assert.Contains("<x:worksheet ", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void ADeclaredRootPrefixKeepsQualifiedAttributesFromRedeclaringIt()
        {
            // With the prefix declared once on the root, a qualified attribute resolves against it
            // instead of forcing a fresh declaration onto every element that carries one. Dropping
            // the root declaration - as an earlier revision did - caused measurable bloat.
            using var stream = new MemoryStream();

            using (var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                document.Features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(WordprocessingNamespace));

                var mainPart = document.AddMainDocumentPart();
                var body = new Body();

                for (var i = 0; i < 5; i++)
                {
                    body.AppendChild(new Paragraph(new Run(new Text("p" + i)))
                    {
                        RsidParagraphAddition = "00AB12CD",
                    });
                }

                var root = new Document(body);
                root.AddNamespaceDeclaration("w", WordprocessingNamespace);

                mainPart.Document = root;
                mainPart.Document.Save();
            }

            var xml = ReadPart(stream, "word/document.xml");
            var declarations = xml.Split(new[] { "xmlns:w=" }, StringSplitOptions.None).Length - 1;

            Assert.Equal(1, declarations);
            Assert.DoesNotContain("<w:", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void GeneratedDocumentRedeclaresThePrefixPerQualifiedAttribute()
        {
            // Documented characteristic rather than a defect: with no declaration on the root, each
            // element carrying a qualified attribute gets its own. Elements stay unprefixed either
            // way; see ADeclaredRootPrefixKeepsQualifiedAttributesFromRedeclaringIt for the remedy.
            using var stream = new MemoryStream();

            using (var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                document.Features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(WordprocessingNamespace));

                var mainPart = document.AddMainDocumentPart();
                var body = new Body();

                for (var i = 0; i < 3; i++)
                {
                    body.AppendChild(new Paragraph(new Run(new Text("p" + i)))
                    {
                        RsidParagraphAddition = "00AB12CD",
                    });
                }

                mainPart.Document = new Document(body);
                mainPart.Document.Save();
            }

            var xml = ReadPart(stream, "word/document.xml");

            Assert.Equal(3, xml.Split(new[] { "xmlns:w=" }, StringSplitOptions.None).Length - 1);
            Assert.DoesNotContain("<w:", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void ReservedPrefixIsRejectedRatherThanLeftToTheWriter()
        {
            // Claiming "r" for SpreadsheetML has no good outcome: where the relationships namespace
            // is declared on the same element the writer refuses it outright, and where it is
            // declared further out the writer silently rebinds it to a generated prefix, shipping
            // r:id as p3:id with no error. Both become one actionable exception instead.
            var exception = Assert.Throws<InvalidOperationException>(() => CreateSpreadsheet(
                package => package.Features.SetNamespacePrefixOverride(ns => ns == SpreadsheetNamespace ? "r" : null)));

            Assert.Contains("'r'", exception.Message, StringComparison.Ordinal);
            Assert.Contains(SpreadsheetNamespace, exception.Message, StringComparison.Ordinal);
            Assert.Contains("relationships", exception.Message, StringComparison.Ordinal);
        }

        [Fact]
        public void APrefixOutsideTheBuiltInTableIsAccepted()
        {
            var xml = CreateSpreadsheet(package =>
                package.Features.SetNamespacePrefixOverride(ns => ns == SpreadsheetNamespace ? "sheet" : null));

            Assert.Contains("<sheet:worksheet ", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void ElementsInTheEmptyNamespaceAreLeftAlone()
        {
            // A resolver that answers for the empty namespace must not produce a prefixed element
            // there - a prefix cannot be bound to the empty namespace.
            var builder = new StringBuilder();
            var element = new Worksheet(new SheetData());

            using (var writer = XmlWriter.Create(builder, new XmlWriterSettings { OmitXmlDeclaration = true }))
            using (var wrapper = new NamespacePrefixOverrideXmlWriter(
                writer,
                OpenXmlNamespacePrefix.Create(_ => "p"),
                new OpenXmlNamespaceResolver()))
            {
                wrapper.WriteStartElement(string.Empty, "plain", string.Empty);
                wrapper.WriteEndElement();
            }

            Assert.Equal("<plain />", builder.ToString());
            Assert.NotNull(element);
        }

        [Fact]
        public void DefaultForRejectsANullEntry()
        {
            var exception = Assert.Throws<ArgumentNullException>(
                () => OpenXmlNamespacePrefix.DefaultFor(SpreadsheetNamespace, null!));

            Assert.Equal("namespaceUris", exception.ParamName);
        }

        [Fact]
        public void ResolverOverloadReportsANullCollection()
        {
            var exception = Assert.Throws<ArgumentNullException>(
                () => ((IFeatureCollection)null!).SetNamespacePrefixOverride(_ => null));

            Assert.Equal("features", exception.ParamName);
        }

        [Fact]
        public void OutputRoundTripsBackThroughTheSdk()
        {
            using var stream = new MemoryStream();

            using (var document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook))
            {
                document.Features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(SpreadsheetNamespace));
                Populate(document);
            }

            stream.Position = 0;

            using var reopened = SpreadsheetDocument.Open(stream, false);
            var worksheetPart = reopened.WorkbookPart!.WorksheetParts.Single();
            var cell = worksheetPart.Worksheet!.Descendants<Cell>().Single();

            Assert.Equal("A1", cell.CellReference);
            Assert.Equal("hello", cell.CellValue!.InnerText);

            var errors = new OpenXmlValidator(FileFormatVersions.Office2019)
                .Validate(reopened, TestContext.Current.CancellationToken)
                .ToList();

            Assert.Empty(errors);
        }

        [Fact]
        public void PrefixPropertyIsNotAffectedByTheOverride()
        {
            // Prefix feeds XmlPath, which builds validation XPaths. An empty prefix there makes
            // XmlPath emit the raw namespace URI where a prefix belongs, producing an XPath that
            // is neither legal nor resolvable against the reported namespace manager.
            using var stream = new MemoryStream();
            using var document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook);

            var workbookPart = document.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();

            var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            Assert.Equal("x", worksheetPart.Worksheet.Prefix);

            document.Features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(SpreadsheetNamespace));

            Assert.Equal("x", worksheetPart.Worksheet.Prefix);
        }

        [Fact]
        public void ValidationXPathsStayWellFormedUnderTheOverride()
        {
            using var stream = new MemoryStream();
            using var document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook);

            document.Features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(SpreadsheetNamespace));

            var workbookPart = document.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();

            var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData(new Row(new Cell(new SheetData())
            {
                CellReference = "A1",
            })));

            var error = new OpenXmlValidator(FileFormatVersions.Office2019)
                .Validate(document, TestContext.Current.CancellationToken)
                .First();

            Assert.DoesNotContain("http://", error.Path!.XPath, StringComparison.Ordinal);
            Assert.StartsWith("/x:", error.Path.XPath, StringComparison.Ordinal);
        }

        [Fact]
        public void OverrideOutranksADeclarationOnADescendant()
        {
            // A descendant carrying its own xmlns:x must not keep using it, or the override is
            // silently ignored for that subtree and the writer re-emits the declaration.
            var sheetData = new SheetData(new Row(new Cell { CellReference = "A1" }));
            sheetData.AddNamespaceDeclaration("x", SpreadsheetNamespace);

            var xml = SaveWorksheet(
                new Worksheet(sheetData),
                features => features.SetNamespacePrefixOverride(OpenXmlNamespacePrefix.DefaultFor(SpreadsheetNamespace)));

            Assert.Contains($"<worksheet xmlns=\"{SpreadsheetNamespace}\"", xml, StringComparison.Ordinal);
            Assert.DoesNotContain("<x:", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void CustomPrefixOverrideAppliesToDescendantsToo()
        {
            // A declaration for a different prefix on the same namespace is left alone; what
            // matters is that the override, not the declaration, decides every element name.
            var worksheet = new Worksheet(new SheetData(new Row(new Cell { CellReference = "A1" })));
            worksheet.AddNamespaceDeclaration("x", SpreadsheetNamespace);

            var xml = SaveWorksheet(
                worksheet,
                features => features.SetNamespacePrefixOverride(ns => ns == SpreadsheetNamespace ? "ss" : null));

            Assert.Contains("<ss:worksheet ", xml, StringComparison.Ordinal);
            Assert.Contains("<ss:sheetData>", xml, StringComparison.Ordinal);
            Assert.DoesNotContain("<x:", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void CallerSuppliedWriterIsUnaffectedWhenNoFeatureIsRegistered()
        {
            // Writing into a writer that already binds the namespace as the default must still
            // produce the built-in prefix, so output is genuinely unchanged without an override.
            var builder = new StringBuilder();

            using (var writer = XmlWriter.Create(builder, new XmlWriterSettings { OmitXmlDeclaration = true }))
            {
                writer.WriteStartElement(string.Empty, "wrapper", WordprocessingNamespace);
                new Paragraph(new Run(new Text("hi"))).WriteTo(writer);
                writer.WriteEndElement();
            }

            Assert.Contains("<w:p ", builder.ToString(), StringComparison.Ordinal);
        }

        [Fact]
        public void FeatureReportingSuccessWithANullPrefixIsTreatedAsTheDefaultNamespace()
        {
            var xml = CreateSpreadsheet(package =>
                package.Features.SetNamespacePrefixOverride(new NullPrefixFeature()));

            Assert.Contains($"<worksheet xmlns=\"{SpreadsheetNamespace}\"", xml, StringComparison.Ordinal);
        }

        [Fact]
        public void SetNamespacePrefixOverrideRejectsAReadOnlyCollection()
        {
            using var stream = new MemoryStream();
            using var document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook);

            var workbookPart = document.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();

            Assert.Throws<InvalidOperationException>(() =>
                workbookPart.Workbook.Features.SetNamespacePrefixOverride(
                    OpenXmlNamespacePrefix.DefaultFor(SpreadsheetNamespace)));
        }

        private sealed class NullPrefixFeature : IOpenXmlNamespacePrefixFeature
        {
            public bool TryGetPrefix(string namespaceUri, out string prefix)
            {
                prefix = null!;
                return namespaceUri == SpreadsheetNamespace;
            }
        }

        private static string SaveWorksheet(Worksheet worksheet, Action<IFeatureCollection> configure)
        {
            using var stream = new MemoryStream();

            using (var document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook))
            {
                configure(document.Features);

                var workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = worksheet;
                worksheetPart.Worksheet.Save();
            }

            return ReadPart(stream, "xl/worksheets/sheet1.xml");
        }

        [Fact]
        public void DefaultForRejectsNull()
            => Assert.Throws<ArgumentNullException>(() => OpenXmlNamespacePrefix.DefaultFor(null!));

        [Fact]
        public void CreateRejectsNull()
            => Assert.Throws<ArgumentNullException>(() => OpenXmlNamespacePrefix.Create(null!));

        [Fact]
        public void SetNamespacePrefixOverrideRejectsNullFeature()
        {
            var features = new FeatureCollection();

            Assert.Throws<ArgumentNullException>(() => features.SetNamespacePrefixOverride((IOpenXmlNamespacePrefixFeature)null!));
        }

        private static string CreateSpreadsheet(Action<SpreadsheetDocument>? configure, string part = "worksheet")
        {
            using var stream = new MemoryStream();

            using (var document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook))
            {
                configure?.Invoke(document);
                Populate(document);
            }

            return ReadPart(stream, part == "workbook" ? "xl/workbook.xml" : "xl/worksheets/sheet1.xml");
        }

        private static void Populate(SpreadsheetDocument document)
        {
            var workbookPart = document.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();

            var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData(new Row(new Cell
            {
                CellReference = "A1",
                DataType = CellValues.String,
                CellValue = new CellValue("hello"),
            })));

            var sheets = workbookPart.Workbook.AppendChild(new Sheets());
            sheets.Append(new Sheet
            {
                Id = workbookPart.GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "Sheet1",
            });
        }

        private static string ReadPart(MemoryStream stream, string uri)
        {
            stream.Position = 0;

            using var package = System.IO.Packaging.Package.Open(stream, FileMode.Open, FileAccess.Read);
            using var partStream = package.GetPart(new Uri("/" + uri, UriKind.Relative)).GetStream();
            using var reader = new StreamReader(partStream);

            return reader.ReadToEnd();
        }
    }
}
