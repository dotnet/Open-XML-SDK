// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using Xunit;
using P = DocumentFormat.OpenXml.Presentation;
using S = DocumentFormat.OpenXml.Spreadsheet;
using W = DocumentFormat.OpenXml.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;
using OpenXmlPowerTools;
using OxTest;

namespace DocumentFormat.OpenXml.Tests
{
    public class DocxTests01
    {
        [Fact]
        public void W055_Load_Save_Data_Bound_Content_Controls()
        {
            var fileInfo = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx"));
            var orig = new FileInfo(Path.Combine(TestUtil.TestFilesDir, "Data-Bound-Content-Controls.docx"));
            File.Copy(orig.FullName, fileInfo.FullName);

            using (WordprocessingDocument doc =
                WordprocessingDocument.Open(fileInfo.FullName, true))
            {
                W.Body body = doc.MainDocumentPart.Document.Body;
                W.Paragraph para = body.Elements<W.Paragraph>().First();
                var newPara = new W.Paragraph(
                    new W.Run(
                        new W.Text("Test")));
                para.InsertBeforeSelf(newPara);
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
            }
            if (TestUtil.DeleteTempFiles)
                fileInfo.Delete();
        }

        [Fact]
        public void W054_Load_Save_Strict()
        {
            var fileInfo = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx"));
            var orig = new FileInfo(Path.Combine(TestUtil.TestFilesDir, "Strict01.docx"));
            File.Copy(orig.FullName, fileInfo.FullName);

            using (WordprocessingDocument doc =
                WordprocessingDocument.Open(fileInfo.FullName, true))
            {
                W.Body body = doc.MainDocumentPart.Document.Body;
                W.Paragraph para = body.Elements<W.Paragraph>().First();
                var newPara = new W.Paragraph(
                    new W.Run(
                        new W.Text("Test")));
                para.InsertBeforeSelf(newPara);
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
            }
            if (TestUtil.DeleteTempFiles)
                fileInfo.Delete();
        }

        [Fact]
        public void W053_AddPart_ToOpenXmlPackage()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            using (MemoryStream ms2 = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                ms2.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                using (WordprocessingDocument doc2 = WordprocessingDocument.Open(ms2, true))
                {
                    OpenXmlPackage pkg = (OpenXmlPackage)doc;
                    OpenXmlPackage pkg2 = (OpenXmlPackage)doc2;
                    CoreFilePropertiesPart cp = pkg.GetPartsOfType<CoreFilePropertiesPart>().First();
                    CoreFilePropertiesPart cp2 = pkg2.GetPartsOfType<CoreFilePropertiesPart>().First();
                    pkg2.DeletePart(cp2);
                    pkg2.AddPart(cp);
                }
            }
        }

        [Fact]
        public void W052_CreateElementFromOuterXml()
        {
            var docName = "UnknownElement.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var cnt = mdp.Document.Descendants().Count();
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(1, errs.Count());
                }
            }
        }

        [Fact]
        public void W051_AddNewPart_ToOpenXmlPackage()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    OpenXmlPackage pkg = (OpenXmlPackage)doc;
                    var wpcp = pkg.AddNewPart<RibbonExtensibilityPart>("application/xml", "rid1232131");
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(0, errs.Count());
                }
            }
        }

        [Fact]
        public void W050_DeleteAdd_CoreExtendedProperties()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    var corePart = doc.CoreFilePropertiesPart;
                    var appPart = doc.ExtendedFilePropertiesPart;
                    doc.DeletePart(corePart);
                    doc.DeletePart(appPart);
                    doc.AddCoreFilePropertiesPart();
                    doc.AddExtendedFilePropertiesPart();
                    doc.AddCustomFilePropertiesPart();
                    doc.AddDigitalSignatureOriginPart();
                    doc.AddExtendedPart("relType", "contentType/xml", ".xml");
                    var tnPart = doc.AddThumbnailPart(ThumbnailPartType.Jpeg);
                    doc.DeletePart(tnPart);
                    tnPart = doc.AddThumbnailPart("image/jpg");
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(0, errs.Count());
                }
            }
        }

        [Fact]
        public void W049_AddNewPart_ToPackage()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    var wpcp = doc.AddNewPart<RibbonExtensibilityPart>("application/xml", "rid1232131");
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(0, errs.Count());
                }
            }
        }

        [Fact]
        public void W048_AddNewPart_ToPackage()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    Assert.Throws<ArgumentOutOfRangeException>(() =>
                    {
                        var wpcp = doc.AddNewPart<RibbonExtensibilityPart>("myfunnycontenttype", "rid1232131");
                    });
                }
            }
        }

        [Fact]
        public void W047_AddNewPart_ToPackage()
        {
            var docName = "Hyperlink.docx";
                        var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    var wpcp = doc.AddNewPart<RibbonExtensibilityPart>("rid123123");
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(0, errs.Count());
                }
            }
        }

        [Fact]
        public void W046_AddNewPart_ToPackage()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    var mdp = doc.MainDocumentPart;
                    doc.DeletePart(mdp);
                    var wpcp = doc.AddNewPart<RibbonExtensibilityPart>();
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(1, errs.Count());
                }
            }
        }

        [Fact]
        public void W045_AddNewPart_ToPart()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    var wpcp = doc.MainDocumentPart.AddNewPart<WordprocessingCommentsPart>("application/vnd.openxmlformats-officedocument.wordprocessingml.comments+xml", "rid1232131");
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(0, errs.Count());
                }
            }
        }

        [Fact]
        public void W044_AddNewPart_ToPart()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    Assert.Throws<ArgumentOutOfRangeException>(() =>
                        {
                            var wpcp = doc.MainDocumentPart.AddNewPart<WordprocessingCommentsPart>("myfunnycontenttype", "rid1232131");
                        });
                }
            }
        }

        [Fact]
        public void W043_AddNewPart()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    var wpcp = doc.MainDocumentPart.AddNewPart<WordprocessingCommentsPart>("rid123123");
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(0, errs.Count());
                }
            }
        }

        [Fact]
        public void W042_AddNewPart()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    var wpcp = doc.MainDocumentPart.AddNewPart<WordprocessingCommentsPart>();
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(0, errs.Count());
                }
            }
        }

        [Fact]
        public void W041_AddAlternativeFormatImportPart()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    doc.MainDocumentPart.AddAlternativeFormatImportPart(AlternativeFormatImportPartType.Html);
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(0, errs.Count());
                }
            }
        }

        [Fact]
        public void W040_AddExternalRelationship()
        {
            var docName = "Hyperlink.docx";
            var ResourceRelationshipType = "http://resourceRelType";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    var mdp = doc.MainDocumentPart;
                    var hl = mdp.HyperlinkRelationships;
                    mdp.AddExternalRelationship(ResourceRelationshipType,
                                            new Uri(@"c:/resources/image1.jpg", UriKind.Absolute),
                                            "rId12345");
                    mdp.AddExternalRelationship(ResourceRelationshipType,
                                            new Uri(@"c:/resources/image1.jpg", UriKind.Absolute));
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(0, errs.Count());
                }
            }
        }

        [Fact]
        public void W039_ChangeDocumentType()
        {
            var docName = "Document.docx";
            var fiSource = new FileInfo(Path.Combine(TestUtil.TestFilesDir, docName));
            var fiCopy = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx"));
            File.Copy(fiSource.FullName, fiCopy.FullName);
            using (Package package = Package.Open(fiCopy.FullName, FileMode.Open, FileAccess.ReadWrite))
            {
                using (WordprocessingDocument doc = WordprocessingDocument.Open(package))
                {
                    doc.ChangeDocumentType(WordprocessingDocumentType.Template);
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
            if (TestUtil.DeleteTempFiles)
                fiCopy.Delete();
        }

        [Fact]
        public void W038_DocxCreation_Package()
        {
            var docName = "Document.docx";
            var fiSource = new FileInfo(Path.Combine(TestUtil.TestFilesDir, docName));
            var fiCopy = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx"));
            File.Copy(fiSource.FullName, fiCopy.FullName);
            using (Package package = Package.Open(fiCopy.FullName, FileMode.Open, FileAccess.ReadWrite))
            {
                using (WordprocessingDocument doc = WordprocessingDocument.Open(package))
                {
                    var cnt = doc.MainDocumentPart.Document.Descendants().Count();
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var errcnt = errs.Count();
                    Assert.True(errcnt == 416 || errcnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
            if (TestUtil.DeleteTempFiles)
                fiCopy.Delete();
        }

        [Fact]
        public void W037_DocxCreation_Package_Settings()
        {
            var docName = "Document.docx";
            var fiSource = new FileInfo(Path.Combine(TestUtil.TestFilesDir, docName));
            var fiCopy = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx"));
            File.Copy(fiSource.FullName, fiCopy.FullName);
            using (Package package = Package.Open(fiCopy.FullName, FileMode.Open, FileAccess.ReadWrite))
            {
                OpenSettings openSettings = new OpenSettings();
                openSettings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(package, openSettings))
                {
                    var cnt = doc.MainDocumentPart.Document.Descendants().Count();
                    var s = doc.MarkupCompatibilityProcessSettings;

                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt2 = errs.Count();
                    Assert.True(cnt2 == 450 || cnt2 == 36); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
            if (TestUtil.DeleteTempFiles)
                fiCopy.Delete();
        }

        [Fact]
        public void W036_DocxCreation_File()
        {
            var docName = "Document.docx";
            var fiSource = new FileInfo(Path.Combine(TestUtil.TestFilesDir, docName));
            var fiCopy = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx"));
            File.Copy(fiSource.FullName, fiCopy.FullName);
            using (WordprocessingDocument doc = WordprocessingDocument.Open(fiCopy.FullName, true))
            {
                Assert.Throws<OpenXmlPackageException>(() =>
                    {
                        doc.AddMainDocumentPart();
                        doc.MainDocumentPart.Document =
                            new W.Document(
                            new W.Body(
                                new W.Paragraph(
                                new W.Run(
                                    new W.Text("Hello World!")))));
                        doc.MainDocumentPart.Document.Save();
                    });
            }
            if (TestUtil.DeleteTempFiles)
                fiCopy.Delete();
        }

        [Fact]
        public void W035_DocxCreation_Package()
        {
            FileInfo fi = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx"));
            using (MemoryStream ms = new MemoryStream())
            using (Package package = Package.Open(ms, FileMode.Create, FileAccess.ReadWrite))
            using (WordprocessingDocument doc = WordprocessingDocument.Create(package, WordprocessingDocumentType.Document))
            {
                doc.AddMainDocumentPart();
                doc.MainDocumentPart.Document =
                    new W.Document(
                    new W.Body(
                        new W.Paragraph(
                        new W.Run(
                            new W.Text("Hello World!")))));
                doc.MainDocumentPart.Document.Save();
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                Assert.Equal(0, errs.Count());
            }
            if (TestUtil.DeleteTempFiles)
                fi.Delete();
        }

        [Fact]
        public void W034_DocxCreation()
        {
            FileInfo fi = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx"));
            using (WordprocessingDocument doc = WordprocessingDocument.Create(fi.FullName, WordprocessingDocumentType.Document))
            {
                doc.AddMainDocumentPart();
                doc.MainDocumentPart.Document =
                    new W.Document(
                    new W.Body(
                        new W.Paragraph(
                        new W.Run(
                            new W.Text("Hello World!")))));
                doc.MainDocumentPart.Document.Save();
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                Assert.Equal(0, errs.Count());
            }
            if (TestUtil.DeleteTempFiles)
                fi.Delete();
        }

        [Fact]
        public void W033_DocxCreation()
        {
            FileInfo fi = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx"));
            using (WordprocessingDocument doc = WordprocessingDocument.Create(fi.FullName, WordprocessingDocumentType.Document))
            {
                doc.AddMainDocumentPart();
                doc.MainDocumentPart.Document =
                    new W.Document(
                    new W.Body(
                        new W.Paragraph(
                        new W.Run(
                            new W.Text("Hello World!")))));
                doc.MainDocumentPart.Document.Save();
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                Assert.Equal(0, errs.Count());
            }
            if (TestUtil.DeleteTempFiles)
                fi.Delete();
        }

        [Fact]
        public void W032_AnnotationsOnElements()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var fp = mdp.Document.Body.ElementAtOrDefault(0);
                    string a = "Test";
                    fp.AddAnnotation(a);
                    var firstAnno = fp.Annotation(typeof(string));
                    var f = fp.Annotation<string>();
                    var a1 = fp.Annotations(typeof(string));
                    var a2 = fp.Annotations<string>();
                    fp.RemoveAnnotations<string>();
                    fp.RemoveAnnotations(typeof(string));
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W031_AnnotationsOnParts()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    string a = "Test";
                    mdp.AddAnnotation(a);
                    var firstAnno = mdp.Annotation(typeof(string));
                    var f = mdp.Annotation<string>();
                    var a1 = mdp.Annotations(typeof(string));
                    var a2 = mdp.Annotations<string>();
                    mdp.RemoveAnnotations<string>();
                    mdp.RemoveAnnotations(typeof(string));
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W030_DeleteReferenceRelationship2()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var r = mdp.GetReferenceRelationship("rId26");
                    mdp.DeleteReferenceRelationship("rId26");
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 417 || cnt == 3); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W029_NonExistant_ReferenceRelationship()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    Assert.Throws<KeyNotFoundException>(() =>
                    {
                        var r = mdp.GetReferenceRelationship("rId1");
                    });
                }
            }
        }

        [Fact]
        public void W028_Ancestors()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var f = mdp.Document.Body.GetFirstChild<W.Paragraph>();
                    var a = f.Ancestors();
                    a = f.Ancestors<W.Paragraph>();
                }
            }
        }

        [Fact]
        public void W027_PreviousSibling_NextSibling()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var l = mdp.Document.Body.LastChild;
                    var p = l.PreviousSibling();
                    p = l.PreviousSibling<W.Paragraph>();
                    var f = mdp.Document.Body.GetFirstChild<W.Paragraph>();
                    var n = f.NextSibling();
                    n = f.NextSibling<W.Paragraph>();
                }
            }
        }

        [Fact]
        public void W026_AddRemoveNamespaceDeclaration()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var firstPara = mdp.Document.Body.LastChild;
                    firstPara.AddNamespaceDeclaration("f", "http://ericwhite.com");
                    firstPara.RemoveNamespaceDeclaration("f");
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W025_ClearAllAttributes()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var firstPara = mdp.Document.Body.LastChild;
                    firstPara.ClearAllAttributes();
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W024_LastChild_LookupPrefix()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var firstPara = mdp.Document.Body.LastChild;
                    var p = firstPara.LookupPrefix("http://schemas.openxmlformats.org/wordprocessingml/2006/main");
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W023_NamespaceDeclarations()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var firstPara = mdp.Document.Body.FirstChild;
                    var ns = firstPara.NamespaceDeclarations;
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W022_InnerXml_InnerText()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var firstPara = mdp.Document.Body.FirstChild;
                    var s = firstPara.InnerXml;
                    var s2 = firstPara.InnerText;
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W021_OuterXml()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var firstPara = mdp.Document.Body.FirstChild;
                    var s = firstPara.OuterXml;
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W020_GetAttribute()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var firstPara = mdp.Document.Body.FirstChild;
                    var atts = firstPara.GetAttributes();
                    var att = atts.First();
                    firstPara.GetAttribute(att.LocalName, att.NamespaceUri);
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W019_SetAttributes()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var firstPara = mdp.Document.Body.FirstChild;
                    var atts = firstPara.GetAttributes();
                    foreach (var att in atts)
                        firstPara.RemoveAttribute(att.LocalName, att.NamespaceUri);
                    firstPara.SetAttributes(atts);
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W018_RemoveAttributes()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var firstPara = mdp.Document.Body.FirstChild;
                    firstPara.RemoveAttribute("displacedByCustomXml", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W017_InsertBefore_InsertAfter()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var newPara = new W.Paragraph(
                        new W.Run(
                            new W.Text("Hello")));
                    var firstPara = mdp.Document.Body.Elements<W.Paragraph>().FirstOrDefault();
                    mdp.Document.Body.InsertBefore(newPara, firstPara);
                    var newPara2 = (OpenXmlElement)newPara.Clone();
                    mdp.Document.Body.InsertAfter(newPara2, firstPara);
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W016_InsertAfterSelf()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var newPara = new W.Paragraph(
                        new W.Run(
                            new W.Text("Hello")));
                    var firstPara = mdp.Document.Body.Elements<W.Paragraph>().FirstOrDefault();
                    firstPara.InsertAfterSelf(newPara);
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W015_InsertBeforeSelf()
        {
            var docName = "Document.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = doc.MainDocumentPart;
                    var newPara = new W.Paragraph(
                        new W.Run(
                            new W.Text("Hello")));
                    var firstPara = mdp.Document.Body.Elements<W.Paragraph>().FirstOrDefault();
                    firstPara.InsertBeforeSelf(newPara);
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();
                    Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W014_MaxCharactersInPart()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                OpenSettings openSettings = new OpenSettings();
                openSettings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(
                    MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2013);
                openSettings.MaxCharactersInPart = 1000;
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true, openSettings))
                {
                    OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                    int cnt = validator.Validate(doc).Count();
                    Assert.Equal(5, cnt);
                }
            }
        }

        [Fact]
        public void W013_MarkupCompat_ProcessLoadedPartsOnly()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                OpenSettings openSettings = new OpenSettings();
                openSettings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(
                    MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2013);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true, openSettings))
                {
                    OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                    int cnt = validator.Validate(doc).Count();
                    Assert.Equal(0, cnt);
                }
            }
        }

        [Fact]
        public void W012_MarkupCompat_ProcessAllParts()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                OpenSettings openSettings = new OpenSettings();
                openSettings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(
                    MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true, openSettings))
                {
                    OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                    int cnt = validator.Validate(doc).Count();
                    Assert.Equal(0, cnt);
                }
            }
        }

        [Fact]
        public void W011_MarkupCompat_InvalidValidation()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                OpenSettings openSettings = new OpenSettings();
                openSettings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true, openSettings))
                {
                    Assert.Throws<InvalidOperationException>(() =>
                    {
                        OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2007);
                        int cnt = validator.Validate(doc).Count();
                        validator = new OpenXmlValidator(FileFormatVersions.Office2010);
                        cnt += validator.Validate(doc).Count();
                        validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                        cnt += validator.Validate(doc).Count();
                        Assert.Equal(0, cnt);
                    });
                }
            }
        }

        [Fact]
        public void W010_HyperlinkRelationships()
        {
            var docName = "Hyperlink.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    var mdp = doc.MainDocumentPart;
                    var extRels = mdp.HyperlinkRelationships;
                    var hyperlinkRel = extRels.First();
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(0, errs.Count());
                }
            }
        }

        [Fact]
        public void W009_DeleteAllParts()
        {
            var docName = "Comments.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    var allParts = doc.GetAllParts();
                    Assert.Throws<ArgumentOutOfRangeException>(() =>
                        {
                            doc.DeleteParts(allParts);
                        });
                }
            }
        }

        [Fact]
        public void W008_AddImageToDocx()
        {
            var docName = "Comments.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            var fiImage = new FileInfo(Path.Combine(TestUtil.TestFilesDir, "Image.png"));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mainPart = doc.MainDocumentPart;

                    ImagePart imagePart = mainPart.AddImagePart(ImagePartType.Jpeg);

                    using (FileStream stream = new FileStream(fiImage.FullName, FileMode.Open))
                    {
                        imagePart.FeedData(stream);
                    }

                    AddImageToBody(doc, mainPart.GetIdOfPart(imagePart));
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(1, errs.Count());
                }
            }
        }

        private void AddImageToBody(WordprocessingDocument wordDoc, string relationshipId)
        {
            // Define the reference of the image.
            var element =
                 new W.Drawing(
                     new DW.Inline(
                         new DW.Extent() { Cx = 990000L, Cy = 792000L },
                         new DW.EffectExtent()
                         {
                             LeftEdge = 0L,
                             TopEdge = 0L,
                             RightEdge = 0L,
                             BottomEdge = 0L
                         },
                         new DW.DocProperties()
                         {
                             Id = (UInt32Value)1U,
                             Name = "Picture 1"
                         },
                         new DW.NonVisualGraphicFrameDrawingProperties(
                             new A.GraphicFrameLocks() { NoChangeAspect = true }),
                         new A.Graphic(
                             new A.GraphicData(
                                 new PIC.Picture(
                                     new PIC.NonVisualPictureProperties(
                                         new PIC.NonVisualDrawingProperties()
                                         {
                                             Id = (UInt32Value)0U,
                                             Name = "New Bitmap Image.jpg"
                                         },
                                         new PIC.NonVisualPictureDrawingProperties()),
                                     new PIC.BlipFill(
                                         new A.Blip(
                                             new A.BlipExtensionList(
                                                 new A.BlipExtension()
                                                 {
                                                     Uri =
                                                       "{28A0092B-C50C-407E-A947-70E740481C1C}"
                                                 })
                                         )
                                         {
                                             Embed = relationshipId,
                                             CompressionState =
                                             A.BlipCompressionValues.Print
                                         },
                                         new A.Stretch(
                                             new A.FillRectangle())),
                                     new PIC.ShapeProperties(
                                         new A.Transform2D(
                                             new A.Offset() { X = 0L, Y = 0L },
                                             new A.Extents() { Cx = 990000L, Cy = 792000L }),
                                         new A.PresetGeometry(
                                             new A.AdjustValueList()
                                         ) { Preset = A.ShapeTypeValues.Rectangle }))
                             ) { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
                     )
                     {
                         DistanceFromTop = (UInt32Value)0U,
                         DistanceFromBottom = (UInt32Value)0U,
                         DistanceFromLeft = (UInt32Value)0U,
                         DistanceFromRight = (UInt32Value)0U,
                         EditId = "50D07946"
                     });
            wordDoc.MainDocumentPart.Document.Body.AppendChild(new W.Paragraph(new W.Run(element)));
        }

        [Fact]
        public void W007_GetPartById_DeleteParts()
        {
            var docName = "Comments.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    var partList = new []{ doc.MainDocumentPart.GetPartById("rId1") };
                    doc.MainDocumentPart.DeleteParts(partList);
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(0, errs.Count());
                }
            }
        }

        [Fact]
        public void W006_RemoveCommentsPart()
        {
            var docName = "Comments.docx";
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    var commentsPart = doc.MainDocumentPart.WordprocessingCommentsPart;
                    doc.MainDocumentPart.DeletePart(commentsPart);
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(3, errs.Count());
                }
            }
        }

        [Fact]
        public void W005_AddCommentsPart()
        {
            var fileInfo = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx"));
            var orig = new FileInfo(Path.Combine(TestUtil.TestFilesDir, "Plain.docx"));
            File.Copy(orig.FullName, fileInfo.FullName);
            string author = "Eric White";
            string comment = "A comment.";
            string initials = "ew";

            using (WordprocessingDocument doc = WordprocessingDocument.Open(fileInfo.FullName, true))
            {
                W.Paragraph firstParagraph = 
                    doc.MainDocumentPart.Document.Descendants<W.Paragraph>().First();
                W.Comments comments = null;
                string id = "0";

                WordprocessingCommentsPart commentPart = 
                    doc.MainDocumentPart.AddNewPart<WordprocessingCommentsPart>();
                commentPart.Comments = new W.Comments();
                comments = commentPart.Comments;

                W.Paragraph p = new W.Paragraph(new W.Run(new W.Text(comment)));
                W.Comment cmt = 
                    new W.Comment() { Id = id, 
                        Author = author, Initials = initials, Date = DateTime.Now };
                cmt.AppendChild(p);
                comments.AppendChild(cmt);
                comments.Save();

                firstParagraph.InsertBefore(new W.CommentRangeStart() 
                    { Id = id }, firstParagraph.GetFirstChild<W.Run>());

                var cmtEnd = firstParagraph.InsertAfter(new W.CommentRangeEnd() 
                    { Id = id }, firstParagraph.Elements<W.Run>().Last());

                firstParagraph.InsertAfter(new W.Run(new W.CommentReference() { Id = id }), cmtEnd);
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                Assert.Equal(0, errs.Count());
            }
            if (TestUtil.DeleteTempFiles)
                fileInfo.Delete();
        }

        [Fact]
        public void W004_DocxCreation()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Create a Wordprocessing document. 
                using (WordprocessingDocument doc = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document))
                {
                    // Add a new main document part. 
                    doc.AddMainDocumentPart();

                    // Create the Document DOM. 
                    doc.MainDocumentPart.Document =
                        new W.Document(
                        new W.Body(
                            new W.Paragraph(
                            new W.Run(
                                new W.Text("Hello World!")))));

                    // Save changes to the main document part. 
                    doc.MainDocumentPart.Document.Save();
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(0, errs.Count());
                }
            }
        }

        [Fact]
        public void W003_DocxValidation()
        {
            var docName = "Document.docx";
            DocxValidationHelper(docName, 832, 418); // v2.5.1 reports more errors than 3.0
        }

        [Fact]
        public void W002_PlainDocxValidation()
        {
            var docName = "Plain.docx";
            DocxValidationHelper(docName, 0, 0); // v2.5.1 reports more errors than 3.0
        }

        private static void DocxValidationHelper(string docName, int expectedErrorCount, int expectedErrorCount2)
        {
            var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ms, true))
                {
                    OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2007);
                    int cnt = validator.Validate(doc).Count();
                    validator = new OpenXmlValidator(FileFormatVersions.Office2010);
                    cnt += validator.Validate(doc).Count();
                    validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                    cnt += validator.Validate(doc).Count();
                    Assert.True(cnt == expectedErrorCount || cnt == expectedErrorCount2);
                }
            }
        }

        [Fact]
        public void W001_OpenMemoryStream()
        {
            var docName = "Plain.docx";
                        var ba = File.ReadAllBytes(Path.Combine(TestUtil.TestFilesDir, docName));
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (WordprocessingDocument wDoc = WordprocessingDocument.Open(ms, true))
                {
                    MainDocumentPart mdp = wDoc.MainDocumentPart;
                    var cnt = mdp.Document.Descendants().Count();
                    Assert.Equal(cnt, 11);
                }
            }
        }
    }
}
