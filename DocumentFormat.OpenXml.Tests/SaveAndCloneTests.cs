﻿/*
 * SaveAndCloneFixture.cs - Testing Save and Clone functionality in Open XML SDK
 * 
 * Copyright 2014-2015 Thomas Barnekow
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * Developer: Thomas Barnekow
 * Email: thomas<at/>barnekow<dot/>info
 */

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.IO.Packaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Xunit;

using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace DocumentFormat.OpenXml.Tests
{
    public class SaveAndCloneTests : BaseFixture
    {
        [Fact]
        public void CanCloneDocument()
        {
            using (var file = TemporaryFile.Create())
            {
                using (var stream = TestFileStreams.Document)
                using (var source = WordprocessingDocument.Open(stream, false))
                using (var clone = (WordprocessingDocument)source.Clone())
                {
                    var body = clone.MainDocumentPart.Document.Body;
                    body.InsertBefore(new Paragraph(new Run(new Text("Hello World"))), body.FirstChild);
                    clone.SaveAs(file.Path).Close();

                    using (var dest = WordprocessingDocument.Open(file.Path, false))
                    {
                        // We want the documents to be different.
                        Assert.Throws<Xunit.Sdk.EqualException>(() => AssertThatPackagesAreEqual(source, dest));
                    }
                }
            }
        }

        [Fact]
        public void CanDoFileBasedClone()
        {
            using (var tempFile = TemporaryFile.Create())
            using (var stream = TestFileStreams.Document)
            using (var source = WordprocessingDocument.Open(stream, false))
            using (source.Clone(tempFile.Path, false))
            using (var dest = WordprocessingDocument.Open(tempFile.Path, false))
            {
                AssertThatPackagesAreEqual(source, dest);
            }
        }

        [Fact]
        public void CanDoFileBasedCloneSpreadsheet()
        {
            using (var tempFile = TemporaryFile.Create())
            using (var stream = TestFileStreams.Spreadsheet)
            using (var source = SpreadsheetDocument.Open(stream, false))
            using (source.Clone(tempFile.Path, false))
            using (var dest = SpreadsheetDocument.Open(tempFile.Path, false))
            {
                AssertThatPackagesAreEqual(source, dest);
            }
        }

        [Fact]
        public void CanDoFileBasedClonePresentation()
        {
            using (var tempFile = TemporaryFile.Create())
            using (var stream = TestFileStreams.Presentation)
            using (var source = PresentationDocument.Open(stream, false))
            using (source.Clone(tempFile.Path, false))
            using (var dest = PresentationDocument.Open(tempFile.Path, false))
            {
                AssertThatPackagesAreEqual(source, dest);
            }
        }

        [Fact]
        public void CanDoMultithreadedMultipleCloning()
        {
            using (var stream = TestFileStreams.Document.AsMemoryStream())
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
            using (var stream = TestFileStreams.Document.AsMemoryStream())
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
            using (var input = TestFileStreams.Document.AsMemoryStream())
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
                        using (var docProperties = TestFileStreams.DocPropertiesPath)
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
            using (var stream = TestFileStreams.Document.AsMemoryStream())
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
                    AssertThatPackagesAreEqual(source, destination);
                }
            }
        }

        [Fact]
        public void CanDoPackageBasedCloningSpreadsheet()
        {
            using (var stream = TestFileStreams.Spreadsheet.AsMemoryStream())
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
                    AssertThatPackagesAreEqual(source, destination);
                }
            }
        }

        [Fact]
        public void CanDoPackageBasedCloningPowerpoint()
        {
            using (var stream = TestFileStreams.Presentation.AsMemoryStream())
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
                    AssertThatPackagesAreEqual(source, destination);
                }
            }
        }

        [Fact]
        public void CanSave()
        {
            using (var stream = TestFileStreams.Document)
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
                var partXml = GetXmlString(dest.MainDocumentPart);

                Assert.Equal(sourceXml, partXml);
            }
        }

        [Fact]
        public void CanSaveAsWord()
        {
            using (var tempFile = TemporaryFile.Create())
            using (var stream = TestFileStreams.Document)
            using (var source = WordprocessingDocument.Open(stream, false))
            {
                using (source.SaveAs(tempFile.Path))
                {
                }

                using (var dest = WordprocessingDocument.Open(tempFile.Path, false))
                {
                    AssertThatPackagesAreEqual(source, dest);
                }
            }
        }

        [Fact]
        public void CanSaveAsExcel()
        {
            using (var tempFile = TemporaryFile.Create())
            using (var stream = TestFileStreams.Spreadsheet)
            using (var source = SpreadsheetDocument.Open(stream, false))
            {
                using (source.SaveAs(tempFile.Path))
                {
                }

                using (var dest = SpreadsheetDocument.Open(tempFile.Path, false))
                {
                    AssertThatPackagesAreEqual(source, dest);
                }
            }
        }

        [Fact]
        public void CanSaveAsPowerpoint()
        {
            using (var stream = TestFileStreams.Presentation)
            using (var source = PresentationDocument.Open(stream, false))
            using (var tempFile = TemporaryFile.Create())
            {
                using (source.SaveAs(tempFile.Path))
                {
                }

                using (var dest = PresentationDocument.Open(tempFile.Path, false))
                {
                    AssertThatPackagesAreEqual(source, dest);
                }
            }
        }

        [Fact]
        public void CanDoStreamBasedCloningWord()
        {
            using (var stream = TestFileStreams.Document)
            using (var source = WordprocessingDocument.Open(stream, false))
            using (var memoryStream = new MemoryStream())
            {
                using (source.Clone(memoryStream, true))
                {
                }

                memoryStream.Position = 0;

                using (var dest = WordprocessingDocument.Open(memoryStream, false))
                {
                    AssertThatPackagesAreEqual(source, dest);
                }
            }
        }

        [Fact]
        public void CanDoStreamBasedCloningExcel()
        {
            using (var stream = TestFileStreams.Spreadsheet)
            using (var source = SpreadsheetDocument.Open(stream, false))
            using (var memoryStream = new MemoryStream())
            {
                using (source.Clone(memoryStream, true))
                {
                }

                memoryStream.Position = 0;

                using (var dest = SpreadsheetDocument.Open(memoryStream, false))
                {
                    AssertThatPackagesAreEqual(source, dest);
                }
            }
        }

        [Fact]
        public void CanDoStreamBasedCloningPowerpoint()
        {
            using (var stream = TestFileStreams.Presentation)
            using (var source = PresentationDocument.Open(stream, false))
            using (var memoryStream = new MemoryStream())
            {
                using (source.Clone(memoryStream, false))
                {
                }

                memoryStream.Position = 0;

                using (var dest = PresentationDocument.Open(memoryStream, false))
                {
                    AssertThatPackagesAreEqual(source, dest);
                }
            }
        }
    }
}
