// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.IO.Packaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace DocumentFormat.OpenXml.Tests
{
    public class SaveAndCloneTests
    {
        [Fact]
        public void CanCloneDocument()
        {
            using (var file = TemporaryFile.Create())
            {
                using (var stream = GetStream(TestFiles.Document))
                using (var source = WordprocessingDocument.Open(stream, false))
                using (var clone = (WordprocessingDocument)source.Clone())
                {
                    var body = clone.MainDocumentPart.Document.Body;
                    body.InsertBefore(new Paragraph(new Run(new Text("Hello World"))), body.FirstChild);
                    clone.SaveAs(file.Path).Close();

                    using (var dest = WordprocessingDocument.Open(file.Path, false))
                    {
                        // We want the documents to be different.
                        Assert.Throws<Xunit.Sdk.EqualException>(() => PackageAssert.Equal(source, dest));
                    }
                }
            }
        }

        [Fact]
        public void CanDoFileBasedClone()
        {
            using (var tempFile = TemporaryFile.Create())
            using (var stream = GetStream(TestFiles.Document))
            using (var source = WordprocessingDocument.Open(stream, false))
            using (source.Clone(tempFile.Path, false))
            using (var dest = WordprocessingDocument.Open(tempFile.Path, false))
            {
                PackageAssert.Equal(source, dest);
            }
        }

        [Fact]
        public void CanDoFileBasedCloneSpreadsheet()
        {
            using (var tempFile = TemporaryFile.Create())
            using (var stream = GetStream(TestFiles.Spreadsheet))
            using (var source = SpreadsheetDocument.Open(stream, false))
            using (source.Clone(tempFile.Path, false))
            using (var dest = SpreadsheetDocument.Open(tempFile.Path, false))
            {
                PackageAssert.Equal(source, dest);
            }
        }

        [Fact]
        public void CanDoFileBasedClonePresentation()
        {
            using (var tempFile = TemporaryFile.Create())
            using (var stream = GetStream(TestFiles.Presentation))
            using (var source = PresentationDocument.Open(stream, false))
            using (source.Clone(tempFile.Path, false))
            using (var dest = PresentationDocument.Open(tempFile.Path, false))
            {
                PackageAssert.Equal(source, dest);
            }
        }

        [Fact]
        public void CanDoMultithreadedMultipleCloning()
        {
            using (var stream = GetStream(TestFiles.Document, true))
            using (var source = WordprocessingDocument.Open(stream, true))
            {
                Parallel.For(0, 10, index =>
                {
                    using (var clone1 = (WordprocessingDocument)source.Clone())
                    {
                        var body1 = clone1.MainDocumentPart.Document.Body;
                        body1.GetFirstChild<Paragraph>()
                            .InsertBeforeSelf(new Paragraph(new Run(new Text("Clone 1"))));

                        using (var tempFile = TemporaryFile.Create())
                        using (var clone2 = (WordprocessingDocument)clone1.SaveAs(tempFile.Path))
                        {
                            var body2 = clone2.MainDocumentPart.Document.Body;
                            body2.GetFirstChild<Paragraph>()
                                .InsertBeforeSelf(new Paragraph(new Run(new Text("Clone 2"))));
                        }

                        // Clone clone1 again.
                        var clone3 = (WordprocessingDocument)clone1.Clone();
                        var body3 = clone3.MainDocumentPart.Document.Body;
                        body3.GetFirstChild<Paragraph>()
                            .InsertBeforeSelf(new Paragraph(new Run(new Text("Clone 3"))));
                        clone3.Close();

                        // Clone source again.
                        var clone4 = (WordprocessingDocument)source.Clone();
                        var body4 = clone4.MainDocumentPart.Document.Body;
                        body4.GetFirstChild<Paragraph>()
                            .InsertBeforeSelf(new Paragraph(new Run(new Text("Clone 4"))));
                        clone4.Close();
                    }
                });
            }
        }

        [Fact]
        public void CanDoMultithreadedSimpleCloning()
        {
            using (var stream = GetStream(TestFiles.Document, true))
            using (var source = WordprocessingDocument.Open(stream, true))
            {
                Parallel.For(0, 10, index =>
                {
                    using (var clone = (WordprocessingDocument)source.Clone())
                    {
                        var body = clone.MainDocumentPart.Document.Body;
                        body.GetFirstChild<Paragraph>().InsertBeforeSelf(new Paragraph(new Run(new Text("Hello"))));
                    }
                });
            }
        }

        [Fact]
        public void CanWildlyCloneAndFlush()
        {
            using (var input = GetStream(TestFiles.Document, true))
            using (var wordDoc = WordprocessingDocument.Open(input, true))
            {
                Parallel.For(0, 10, index =>
                {
                    using (var clone = (WordprocessingDocument)wordDoc.Clone())
                    {
                        var secondClone = (WordprocessingDocument)clone.Clone();
                        secondClone.MainDocumentPart.Document.Body
                            .GetFirstChild<Paragraph>()
                            .InsertBeforeSelf(new Paragraph(new Run(new Text("Changes."))));
                        secondClone.Package.Flush();

                        // Change the main document part.
                        clone.MainDocumentPart.Document.Body
                                .GetFirstChild<Paragraph>()
                                .InsertBeforeSelf(new Paragraph(new Run(new Text("Changes."))));

                        // Create a new Custom XML part.
                        var part = clone.MainDocumentPart.AddCustomXmlPart(CustomXmlPartType.CustomXml);

                        using (var stream = part.GetStream())
                        using (var xw = XmlWriter.Create(stream))
                        using (var docProperties = GetStream(TestFiles.DocPropertiesPath))
                        {
                            XElement.Load(docProperties).WriteTo(xw);
                        }

                        // Flush the clone (the removal of which fixed the original error).
                        clone.Package.Flush();

                        var thirdClone = (WordprocessingDocument)clone.Clone();
                        thirdClone.MainDocumentPart.Document.Body
                            .GetFirstChild<Paragraph>()
                            .InsertBeforeSelf(new Paragraph(new Run(new Text("Changes."))));
                        thirdClone.Package.Flush();

                        using (var tempFile = TemporaryFile.Create())
                        {
                            clone.SaveAs(tempFile.Path).Close();
                        }
                    }
                });
            }
        }

        [Fact]
        public void CanDoPackageBasedCloningWord()
        {
            using (var stream = GetStream(TestFiles.Document, true))
            using (var source = WordprocessingDocument.Open(stream, true))
            using (var ms = new MemoryStream())
            {
                using (var package = Package.Open(ms, FileMode.Create))
                {
                    source.Clone(package).Close();
                }

                ms.Position = 0;

                using (var destination = WordprocessingDocument.Open(ms, true))
                {
                    PackageAssert.Equal(source, destination);
                }
            }
        }

        [Fact]
        public void CanDoPackageBasedCloningSpreadsheet()
        {
            using (var stream = GetStream(TestFiles.Spreadsheet, true))
            using (var source = SpreadsheetDocument.Open(stream, true))
            using (var ms = new MemoryStream())
            {
                using (var package = Package.Open(ms, FileMode.Create))
                {
                    source.Clone(package).Close();
                }

                ms.Position = 0;

                using (var destination = SpreadsheetDocument.Open(ms, true))
                {
                    PackageAssert.Equal(source, destination);
                }
            }
        }

        [Fact]
        public void CanDoPackageBasedCloningPowerpoint()
        {
            using (var stream = GetStream(TestFiles.Presentation, true))
            using (var source = PresentationDocument.Open(stream, true))
            using (var ms = new MemoryStream())
            {
                using (var package = Package.Open(ms, FileMode.Create))
                {
                    source.Clone(package).Close();
                }

                ms.Position = 0;

                using (var destination = PresentationDocument.Open(ms, true))
                {
                    PackageAssert.Equal(source, destination);
                }
            }
        }

        [Fact]
        public void CanSaveAutosaveFalse()
        {
            using (var stream = new MemoryStream())
            {
                using (var package = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
                {
                    package.AddMainDocumentPart();
                }

                using (var package = WordprocessingDocument.Open(stream, true, new OpenSettings { AutoSave = false }))
                {
                    Assert.Null(package.MainDocumentPart.Document);
                    package.MainDocumentPart.Document = new Document();
                    Assert.NotNull(package.MainDocumentPart.Document);

                    package.Save();
                }

                using (var package = WordprocessingDocument.Open(stream, false, new OpenSettings { AutoSave = false }))
                {
                    Assert.NotNull(package.MainDocumentPart);
                    Assert.NotNull(package.MainDocumentPart.Document);
                }
            }
        }

        [Fact]
        public void CanSave()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var source = WordprocessingDocument.Open(stream, false))
            using (var memoryStream = new MemoryStream())
            using (var dest = (WordprocessingDocument)source.Clone(memoryStream))
            {
                var document = dest.MainDocumentPart.Document;
                var body = document.Body;

                // Make whatever changes you want to make on any part of the document.
                body.GetFirstChild<Paragraph>().InsertBeforeSelf(new Paragraph(new Run(new Text("Hello World"))));

                // Get the document element's XML.
                var sb = new StringBuilder();
                using (var xw = XmlWriter.Create(sb))
                {
                    document.WriteTo(xw);
                }

                var sourceXml = sb.ToString();

                // Save the document.
                dest.Save();

                // Get the part's root element's XML.
                var partXml = dest.MainDocumentPart.GetXmlString();

                Assert.Equal(sourceXml, partXml);
            }
        }

        [Fact]
        public void CanSaveAsWord()
        {
            using (var tempFile = TemporaryFile.Create())
            using (var stream = GetStream(TestFiles.Document))
            using (var source = WordprocessingDocument.Open(stream, false))
            {
                using (source.SaveAs(tempFile.Path))
                {
                }

                using (var dest = WordprocessingDocument.Open(tempFile.Path, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanSaveAsExcel()
        {
            using (var tempFile = TemporaryFile.Create())
            using (var stream = GetStream(TestFiles.Spreadsheet))
            using (var source = SpreadsheetDocument.Open(stream, false))
            {
                using (source.SaveAs(tempFile.Path))
                {
                }

                using (var dest = SpreadsheetDocument.Open(tempFile.Path, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanSaveAsPowerpoint()
        {
            using (var stream = GetStream(TestFiles.Presentation))
            using (var source = PresentationDocument.Open(stream, false))
            using (var tempFile = TemporaryFile.Create())
            {
                using (source.SaveAs(tempFile.Path))
                {
                }

                using (var dest = PresentationDocument.Open(tempFile.Path, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanDoStreamBasedCloningWord()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var source = WordprocessingDocument.Open(stream, false))
            using (var memoryStream = new MemoryStream())
            {
                using (source.Clone(memoryStream, true))
                {
                }

                memoryStream.Position = 0;

                using (var dest = WordprocessingDocument.Open(memoryStream, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanDoStreamBasedCloningExcel()
        {
            using (var stream = GetStream(TestFiles.Spreadsheet))
            using (var source = SpreadsheetDocument.Open(stream, false))
            using (var memoryStream = new MemoryStream())
            {
                using (source.Clone(memoryStream, true))
                {
                }

                memoryStream.Position = 0;

                using (var dest = SpreadsheetDocument.Open(memoryStream, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanDoStreamBasedCloningPowerpoint()
        {
            using (var stream = GetStream(TestFiles.Presentation))
            using (var source = PresentationDocument.Open(stream, false))
            using (var memoryStream = new MemoryStream())
            {
                using (source.Clone(memoryStream, false))
                {
                }

                memoryStream.Position = 0;

                using (var dest = PresentationDocument.Open(memoryStream, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }
    }
}
