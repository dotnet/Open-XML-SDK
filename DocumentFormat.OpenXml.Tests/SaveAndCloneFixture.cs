/*
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

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Xunit;
using OxTest;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace DocumentFormat.OpenXml.Tests
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class SaveAndCloneFixture : BaseFixture
    {

        private static string s_SubDirectory = "SaveAndClone";

        private static string TestResultsDirectory
        {
            get
            {
                return Path.Combine(TestUtil.TestResultsDirectory, s_SubDirectory);
            }
        }

        private const string DirectoryPath = "SaveAndClone";

        private const string DocumentPath = DirectoryPath + "\\Document.docx";
        private const string PresentationPath = DirectoryPath + "\\Presentation.pptx";
        private const string SpreadsheetPath = DirectoryPath + "\\Spreadsheet.xlsx";

        private const string DocPropertiesPath = DirectoryPath + "\\DocProperties.xml";

        /// <summary>
        /// Creates a new instance of this test fixture, registering our test folder
        /// with the base fixture for cleanup after testing.
        /// </summary>
        public SaveAndCloneFixture()
            : base(TestResultsDirectory)
        {
            Directory.CreateDirectory(TestResultsDirectory);

            File.Copy(GetTestFilePath(DocumentPath), Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), true);
            File.Copy(GetTestFilePath(PresentationPath), Path.Combine(TestUtil.TestResultsDirectory, PresentationPath), true);
            File.Copy(GetTestFilePath(SpreadsheetPath), Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath), true);

            File.Copy(GetTestFilePath(DocPropertiesPath), Path.Combine(TestUtil.TestResultsDirectory, DocPropertiesPath), true);

            PrepareWordprocessingDocument(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath));
            PreparePresentationDocument(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath));
            PrepareSpreadsheetDocument(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath));
        }

        [Fact]
        public void CanCloneDocument()
        {
            string file = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            using (var source = WordprocessingDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), false))
            using (var clone = (WordprocessingDocument) source.Clone())
            {
                var body = clone.MainDocumentPart.Document.Body;
                body.InsertBefore(new Paragraph(new Run(new Text("Hello World"))), body.FirstChild);
                clone.SaveAs(file).Close();
            }

            try
            {
                CheckWordprocessingDocument(DocumentPath, file);
            }
            catch (Exception)
            {
                // We want the documents to be different.
                return;
            }
            
            // Fail.
            Assert.True(false);
        }

        [Fact]
        public void CanDoFileBasedClone()
        {
            string file = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            // Test WordprocessingDocument.
            using (var source = WordprocessingDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), false))
            using (source.Clone(file, false))
            {
                CheckWordprocessingDocument(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), file);
            }

            string file2 = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
            // Test SpreadsheetDocument.
            using (var source = SpreadsheetDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath), false))
            using (source.Clone(file2, false))
            {
                CheckSpreadsheetDocument(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath), file2);
            }

            string file3 = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
            // Test PresentationDocument.
            using (var source = PresentationDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath), false))
            using (source.Clone(file3, false))
            {
                CheckPresentationDocument(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath), file3);
            }
        }

        [Fact]
        public void CanDoMultithreadedMultipleCloning()
        {
            var source = WordprocessingDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), true);
            Parallel.For(0, 10, index =>
            {
                using (var clone1 = (WordprocessingDocument) source.Clone())
                {
                    var body1 = clone1.MainDocumentPart.Document.Body;
                    body1.GetFirstChild<Paragraph>()
                        .InsertBeforeSelf(new Paragraph(new Run(new Text("Clone 1"))));

                    using (var clone2 = (WordprocessingDocument) clone1.SaveAs(Path.Combine(TestResultsDirectory, "Test" + index + ".docx")))
                    {
                        var body2 = clone2.MainDocumentPart.Document.Body;
                        body2.GetFirstChild<Paragraph>()
                            .InsertBeforeSelf(new Paragraph(new Run(new Text("Clone 2"))));
                    }

                    // Clone clone1 again.
                    var clone3 = (WordprocessingDocument) clone1.Clone();
                    var body3 = clone3.MainDocumentPart.Document.Body;
                    body3.GetFirstChild<Paragraph>()
                        .InsertBeforeSelf(new Paragraph(new Run(new Text("Clone 3"))));
                    clone3.Close();

                    // Clone source again.
                    var clone4 = (WordprocessingDocument) source.Clone();
                    var body4 = clone4.MainDocumentPart.Document.Body;
                    body4.GetFirstChild<Paragraph>()
                        .InsertBeforeSelf(new Paragraph(new Run(new Text("Clone 4"))));
                    clone4.Close();
                }
            });
            source.Close();
        }

        [Fact]
        public void CanDoMultithreadedSimpleCloning()
        {
            var source = WordprocessingDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), true);
            Parallel.For(0, 10, index =>
            {
                using (var clone = (WordprocessingDocument) source.Clone())
                {
                    var body = clone.MainDocumentPart.Document.Body;
                    body.GetFirstChild<Paragraph>().InsertBeforeSelf(new Paragraph(new Run(new Text("Hello"))));
                }
            });
            source.Close();
        }

        [Fact]
        public void CanWildlyCloneAndFlush()
        {
            var directoryName = Path.GetDirectoryName(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath)) ?? string.Empty;
            var fileName = Path.GetFileNameWithoutExtension(DocumentPath);
            var destDocumentPath = Path.Combine(directoryName, fileName + "_Flushing.docx");

            var wordDoc = WordprocessingDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), false);
            Parallel.For(0, 10, index =>
            {
                using (var clone = (WordprocessingDocument) wordDoc.Clone())
                {

                    var secondClone = (WordprocessingDocument) clone.Clone();
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
                        XElement.Load(Path.Combine(TestUtil.TestResultsDirectory, DocPropertiesPath)).WriteTo(xw);

                    // Flush the clone (the removal of which fixed the original error).
                    clone.Package.Flush();

                    var thirdClone = (WordprocessingDocument) clone.Clone();
                    thirdClone.MainDocumentPart.Document.Body
                        .GetFirstChild<Paragraph>()
                        .InsertBeforeSelf(new Paragraph(new Run(new Text("Changes."))));
                    thirdClone.Package.Flush();

                    clone.SaveAs(destDocumentPath + "." + index + ".docx").Close();
                }
            });
            wordDoc.Close();
        }

        [Fact]
        public void CanDoPackageBasedCloning()
        {
            // Test WordprocessingDocument.
            using (var source = WordprocessingDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), true))
            using (var package = Package.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath + ".Package.docx"), FileMode.Create))
            {
                source.Clone(package).Close();
            }
            CheckWordprocessingDocument(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), Path.Combine(TestUtil.TestResultsDirectory, DocumentPath + ".Package.docx"));

            // Test SpreadsheetDocument.
            using (var source = SpreadsheetDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath), true))
            using (var package = Package.Open(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath + ".Package.xlsx"), FileMode.Create))
            {
                source.Clone(package).Close();
            }
            CheckSpreadsheetDocument(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath), Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath + ".Package.xlsx"));

            // Test PresentationDocument.
            using (var source = PresentationDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath), true))
            using (var package = Package.Open(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath + ".Package.pptx"), FileMode.Create))
            {
                source.Clone(package).Close();
            }
            CheckPresentationDocument(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath), Path.Combine(TestUtil.TestResultsDirectory, PresentationPath + ".Package.pptx"));
        }

        [Fact]
        public void CanSave()
        {
            using (var memoryStream = new MemoryStream())
            using (var source = WordprocessingDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), true))
            using (var dest = (WordprocessingDocument) source.Clone(memoryStream))
            {
                var document = dest.MainDocumentPart.Document;
                var body = document.Body;

                // Make whatever changes you want to make on any part of the document.
                body.GetFirstChild<Paragraph>().InsertBeforeSelf(new Paragraph(new Run(new Text("Hello World"))));

                // Get the document element's XML.
                var sb = new StringBuilder();
                using (var xw = XmlWriter.Create(sb))
                    document.WriteTo(xw);
                var sourceXml = sb.ToString();

                // Save the document. 
                dest.Save();

                // Get the part's root element's XML.
                var partXml = GetXmlString(dest.MainDocumentPart);
                // Assert.That(sourceXml, Is.EqualTo(partXml));
                Assert.Equal(sourceXml, partXml);
            }
        }

        [Fact]
        public void CanSaveAs()
        {
            // This is probably a bit too much as SaveAs(string) really equals Clone(string).
            // But let's pretend we didn't know that.

            // Test WordprocessingDocument.
            using (var source = WordprocessingDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), false))
            using (source.SaveAs(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath + ".SaveAs.docx")))
            {
                CheckWordprocessingDocument(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), Path.Combine(TestUtil.TestResultsDirectory, DocumentPath + ".SaveAs.docx"));
            }

            // Test SpreadsheetDocument.
            using (var source = SpreadsheetDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath), false))
            using (source.SaveAs(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath + ".SaveAs.xlsx")))
            {
                CheckSpreadsheetDocument(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath), Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath + ".SaveAs.xlsx"));
            }

            // Test PresentationDocument.
            using (var source = PresentationDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath), false))
            using (source.SaveAs(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath + ".SaveAs.pptx")))
            {
                CheckPresentationDocument(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath), Path.Combine(TestUtil.TestResultsDirectory, PresentationPath + ".SaveAs.pptx"));
            }
        }

        [Fact]
        public void CanDoStreamBasedCloning()
        {
            // Test WordprocessingDocument.
            using (var source = WordprocessingDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), true))
            using (var memoryStream = new MemoryStream())
            using (source.Clone(memoryStream, true))
            using (var fileStream = new FileStream(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath + ".Stream.docx"), FileMode.Create))
            {
                memoryStream.WriteTo(fileStream);
            }
            CheckWordprocessingDocument(Path.Combine(TestUtil.TestResultsDirectory, DocumentPath), Path.Combine(TestUtil.TestResultsDirectory, DocumentPath + ".Stream.docx"));

            // Test SpreadsheetDocument.
            using (var source = SpreadsheetDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath), true))
            using (var memoryStream = new MemoryStream())
            using (source.Clone(memoryStream, true))
            using (var fileStream = new FileStream(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath + ".Stream.xlsx"), FileMode.Create))
            {
                memoryStream.WriteTo(fileStream);
            }
            CheckSpreadsheetDocument(Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath), Path.Combine(TestUtil.TestResultsDirectory, SpreadsheetPath + ".Stream.xlsx"));

            // Test PresentationDocument.
            using (var source = PresentationDocument.Open(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath), true))
            using (var memoryStream = new MemoryStream())
            using (source.Clone(memoryStream, true))
            using (var fileStream = new FileStream(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath + ".Stream.pptx"), FileMode.Create))
            {
                memoryStream.WriteTo(fileStream);
            }
            CheckPresentationDocument(Path.Combine(TestUtil.TestResultsDirectory, PresentationPath), Path.Combine(TestUtil.TestResultsDirectory, PresentationPath + ".Stream.pptx"));
        }

        /// <summary>
        /// Inserts a new paragraph.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="styleId">The style ID or null</param>
        /// <param name="text"></param>
        //internal void InsertParagraph(Body body, string styleId, string text)
        //{
        //    var p = new Paragraph(new Run(new Text(text)));
        //    if (styleId != null)
        //        p.InsertAt(new ParagraphProperties(new ParagraphStyleId { Val = styleId }), 0);

        //    if (body.LastChild is SectionProperties)
        //    {
        //        body.LastChild.InsertBeforeSelf(p);
        //        return;
        //    }
        //    body.AppendChild(p);
        //}

        private static void CheckPresentationDocument(string path, string clonePath)
        {
            using (var source = PresentationDocument.Open(path, false))
            using (var dest = PresentationDocument.Open(clonePath, false))
            {
                AssertThatPackagesAreEqual(source, dest);
            }
        }

        private static void CheckSpreadsheetDocument(string path, string clonePath)
        {
            using (var source = SpreadsheetDocument.Open(path, false))
            using (var dest = SpreadsheetDocument.Open(clonePath, false))
            {
                AssertThatPackagesAreEqual(source, dest);
            }
        }

        private static void CheckWordprocessingDocument(string path, string clonePath)
        {
            using (var source = WordprocessingDocument.Open(path, false))
            using (var dest = WordprocessingDocument.Open(clonePath, false))
            {
                AssertThatPackagesAreEqual(source, dest);
            }
        }
    }
}