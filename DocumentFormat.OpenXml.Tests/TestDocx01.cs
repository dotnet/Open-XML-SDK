// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;
using W = DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Tests
{
    public class DocxTests01
    {
        [Fact]
        public void W055_Load_Save_Data_Bound_Content_Controls()
        {
            using (var stream = GetStream(TestFiles.DataBoundContentControls, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var body = doc.MainDocumentPart.Document.Body;
                var para = body.Elements<W.Paragraph>().First();
                var newPara = new W.Paragraph(
                    new W.Run(
                        new W.Text("Test")));
                para.InsertBeforeSelf(newPara);

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W054_Load_Save_Strict()
        {
            using (var stream = GetStream(TestFiles.Strict01, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var body = doc.MainDocumentPart.Document.Body;
                var para = body.Elements<W.Paragraph>().First();
                var newPara = new W.Paragraph(
                    new W.Run(
                        new W.Text("Test")));
                para.InsertBeforeSelf(newPara);

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
            }
        }

        [Fact]
        public void W053_AddPart_ToOpenXmlPackage()
        {
            using (var stream1 = GetStream(TestFiles.Hyperlink, true))
            using (var stream2 = GetStream(TestFiles.Hyperlink, true))
            {
                using (var doc1 = WordprocessingDocument.Open(stream1, true))
                using (var doc2 = WordprocessingDocument.Open(stream2, true))
                {
                    var pkg1 = (OpenXmlPackage)doc1;
                    var pkg2 = (OpenXmlPackage)doc2;

                    var cp1 = pkg1.GetPartsOfType<CoreFilePropertiesPart>().First();
                    var cp2 = pkg2.GetPartsOfType<CoreFilePropertiesPart>().First();

                    pkg2.DeletePart(cp2);
                    pkg2.AddPart(cp1);
                }
            }
        }

        [Fact]
        public void W052_CreateElementFromOuterXml()
        {
            using (var stream = GetStream(TestFiles.UnknownElement))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var cnt = mdp.Document.Descendants().Count();
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Single(errs);
            }
        }

        [Fact]
        public void W051_AddNewPart_ToOpenXmlPackage()
        {
            using (var stream = GetStream(TestFiles.Hyperlink, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var pkg = (OpenXmlPackage)doc;
                var wpcp = pkg.AddNewPart<RibbonExtensibilityPart>("application/xml", "rid1232131");
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W050_DeleteAdd_CoreExtendedProperties()
        {
            using (var stream = GetStream(TestFiles.Hyperlink, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
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

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W049_AddNewPart_ToPackage()
        {
            using (var stream = GetStream(TestFiles.Hyperlink, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var wpcp = doc.AddNewPart<RibbonExtensibilityPart>("application/xml", "rid1232131");
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W048_AddNewPart_ToPackage()
        {
            using (var stream = GetStream(TestFiles.Hyperlink, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    doc.AddNewPart<RibbonExtensibilityPart>("myfunnycontenttype", "rid1232131");
                });
            }
        }

        [Fact]
        public void W047_AddNewPart_ToPackage()
        {
            using (var stream = GetStream(TestFiles.Hyperlink, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var wpcp = doc.AddNewPart<RibbonExtensibilityPart>("rid123123");
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W046_AddNewPart_ToPackage()
        {
            using (var stream = GetStream(TestFiles.Hyperlink, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var mdp = doc.MainDocumentPart;

                doc.DeletePart(mdp);

                var wpcp = doc.AddNewPart<RibbonExtensibilityPart>();
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Single(errs);
            }
        }

        [Fact]
        public void W045_AddNewPart_ToPart()
        {
            using (var stream = GetStream(TestFiles.Hyperlink, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var wpcp = doc.MainDocumentPart.AddNewPart<WordprocessingCommentsPart>("application/vnd.openxmlformats-officedocument.wordprocessingml.comments+xml", "rid1232131");
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W044_AddNewPart_ToPart()
        {
            using (var stream = GetStream(TestFiles.Hyperlink, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    doc.MainDocumentPart.AddNewPart<WordprocessingCommentsPart>("myfunnycontenttype", "rid1232131");
                });
            }
        }

        [Fact]
        public void W043_AddNewPart()
        {
            using (var stream = GetStream(TestFiles.Hyperlink, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var wpcp = doc.MainDocumentPart.AddNewPart<WordprocessingCommentsPart>("rid123123");
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W042_AddNewPart()
        {
            using (var stream = GetStream(TestFiles.Hyperlink, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var wpcp = doc.MainDocumentPart.AddNewPart<WordprocessingCommentsPart>();
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W041_AddAlternativeFormatImportPart()
        {
            using (var stream = GetStream(TestFiles.Hyperlink, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                doc.MainDocumentPart.AddAlternativeFormatImportPart(AlternativeFormatImportPartType.Html);

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W040_AddExternalRelationship()
        {
            const string ResourceRelationshipType = "http://resourceRelType";

            using (var stream = GetStream(TestFiles.Hyperlink, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var mdp = doc.MainDocumentPart;
                var hl = mdp.HyperlinkRelationships;

                mdp.AddExternalRelationship(ResourceRelationshipType,
                                        new Uri(@"c:/resources/image1.jpg", UriKind.Absolute),
                                        "rId12345");
                mdp.AddExternalRelationship(ResourceRelationshipType,
                                        new Uri(@"c:/resources/image1.jpg", UriKind.Absolute));

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W039_ChangeDocumentType()
        {
            using (var stream = GetStream(TestFiles.Document, true))
            using (var package = Package.Open(stream, FileMode.Open, FileAccess.ReadWrite))
            using (var doc = WordprocessingDocument.Open(package))
            {
                doc.ChangeDocumentType(WordprocessingDocumentType.Template);

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W038_DocxCreation_Package()
        {
            using (var stream = GetStream(TestFiles.Document, true))
            using (var package = Package.Open(stream, FileMode.Open, FileAccess.ReadWrite))
            using (var doc = WordprocessingDocument.Open(package))
            {
                var cnt = doc.MainDocumentPart.Document.Descendants().Count();
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var errcnt = errs.Count();

                Assert.True(errcnt == 416 || errcnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W037_DocxCreation_Package_Settings()
        {
            using (var stream = GetStream(TestFiles.Document, true))
            using (var package = Package.Open(stream, FileMode.Open, FileAccess.ReadWrite))
            {
                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013)
                };

                using (var doc = WordprocessingDocument.Open(package, openSettings))
                {
                    var cnt = doc.MainDocumentPart.Document.Descendants().Count();
                    var s = doc.MarkupCompatibilityProcessSettings;

                    var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt2 = errs.Count();

                    Assert.True(cnt2 == 450 || cnt2 == 36); // v3.0 correctly reports fewer errors than v2.5.1
                }
            }
        }

        [Fact]
        public void W036_DocxCreation_File()
        {
            using (var stream = GetStream(TestFiles.Document, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
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
        }

        [Fact]
        public void W035_DocxCreation_Package()
        {
            using (var ms = new MemoryStream())
            using (var package = Package.Open(ms, FileMode.Create, FileAccess.ReadWrite))
            using (var doc = WordprocessingDocument.Create(package, WordprocessingDocumentType.Document))
            {
                doc.AddMainDocumentPart();
                doc.MainDocumentPart.Document =
                    new W.Document(
                    new W.Body(
                        new W.Paragraph(
                        new W.Run(
                            new W.Text("Hello World!")))));
                doc.MainDocumentPart.Document.Save();

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W034_DocxCreation()
        {
            using (var ms = new MemoryStream())
            using (var doc = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document))
            {
                doc.AddMainDocumentPart();
                doc.MainDocumentPart.Document =
                    new W.Document(
                    new W.Body(
                        new W.Paragraph(
                        new W.Run(
                            new W.Text("Hello World!")))));
                doc.MainDocumentPart.Document.Save();

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W033_DocxCreation()
        {
            using (var ms = new MemoryStream())
            using (var doc = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document))
            {
                doc.AddMainDocumentPart();
                doc.MainDocumentPart.Document =
                    new W.Document(
                    new W.Body(
                        new W.Paragraph(
                        new W.Run(
                            new W.Text("Hello World!")))));
                doc.MainDocumentPart.Document.Save();

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W032_AnnotationsOnElements()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var fp = mdp.Document.Body.ElementAtOrDefault(0);

                fp.AddAnnotation("Test");

                Assert.NotNull(fp.Annotation(typeof(string)));
                Assert.NotNull(fp.Annotation<string>());
                Assert.NotNull(fp.Annotations(typeof(string)));
                Assert.NotNull(fp.Annotations<string>());

                fp.RemoveAnnotations<string>();
                fp.RemoveAnnotations(typeof(string));

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W031_AnnotationsOnParts()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                mdp.AddAnnotation("Test");

                var firstAnno = mdp.Annotation(typeof(string));
                var f = mdp.Annotation<string>();
                var a1 = mdp.Annotations(typeof(string));
                var a2 = mdp.Annotations<string>();

                mdp.RemoveAnnotations<string>();
                mdp.RemoveAnnotations(typeof(string));

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W030_DeleteReferenceRelationship2()
        {
            using (var stream = GetStream(TestFiles.Document, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var mdp = doc.MainDocumentPart;
                var r = mdp.GetReferenceRelationship("rId26");

                mdp.DeleteReferenceRelationship("rId26");

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 417 || cnt == 3); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W029_NonExistant_ReferenceRelationship()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;

                Assert.Throws<KeyNotFoundException>(() => mdp.GetReferenceRelationship("rId1"));
            }
        }

        [Fact]
        public void W028_Ancestors()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var f = mdp.Document.Body.GetFirstChild<W.Paragraph>();

                Assert.NotNull(f.Ancestors());
                Assert.NotNull(f.Ancestors<W.Paragraph>());
            }
        }

        [Fact]
        public void W027_PreviousSibling_NextSibling()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var l = mdp.Document.Body.LastChild;
                var p = l.PreviousSibling();

                p = l.PreviousSibling<W.Paragraph>();

                var f = mdp.Document.Body.GetFirstChild<W.Paragraph>();
                var n = f.NextSibling();

                n = f.NextSibling<W.Paragraph>();
            }
        }

        [Fact]
        public void W026_AddRemoveNamespaceDeclaration()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var firstPara = mdp.Document.Body.LastChild;

                firstPara.AddNamespaceDeclaration("f", "http://ericwhite.com");
                firstPara.RemoveNamespaceDeclaration("f");

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W025_ClearAllAttributes()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var firstPara = mdp.Document.Body.LastChild;

                firstPara.ClearAllAttributes();

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W024_LastChild_LookupPrefix()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var firstPara = mdp.Document.Body.LastChild;
                var p = firstPara.LookupPrefix("http://schemas.openxmlformats.org/wordprocessingml/2006/main");
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W023_NamespaceDeclarations()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var firstPara = mdp.Document.Body.FirstChild;
                var ns = firstPara.NamespaceDeclarations;
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W022_InnerXml_InnerText()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var firstPara = mdp.Document.Body.FirstChild;
                var s = firstPara.InnerXml;
                var s2 = firstPara.InnerText;
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();
                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W021_OuterXml()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var firstPara = mdp.Document.Body.FirstChild;
                var s = firstPara.OuterXml;
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W020_GetAttribute()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var firstPara = mdp.Document.Body.FirstChild;
                var atts = firstPara.GetAttributes();
                var att = atts.First();

                firstPara.GetAttribute(att.LocalName, att.NamespaceUri);

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W019_SetAttributes()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var firstPara = mdp.Document.Body.FirstChild;
                var atts = firstPara.GetAttributes();

                foreach (var att in atts)
                {
                    firstPara.RemoveAttribute(att.LocalName, att.NamespaceUri);
                }

                firstPara.SetAttributes(atts);

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W018_RemoveAttributes()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var firstPara = mdp.Document.Body.FirstChild;
                firstPara.RemoveAttribute("displacedByCustomXml", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W017_InsertBefore_InsertAfter()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var newPara = new W.Paragraph(
                    new W.Run(
                        new W.Text("Hello")));
                var firstPara = mdp.Document.Body.Elements<W.Paragraph>().FirstOrDefault();
                mdp.Document.Body.InsertBefore(newPara, firstPara);

                var newPara2 = (OpenXmlElement)newPara.Clone();
                mdp.Document.Body.InsertAfter(newPara2, firstPara);

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W016_InsertAfterSelf()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var newPara = new W.Paragraph(
                    new W.Run(
                        new W.Text("Hello")));
                var firstPara = mdp.Document.Body.Elements<W.Paragraph>().FirstOrDefault();

                firstPara.InsertAfterSelf(newPara);

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W015_InsertBeforeSelf()
        {
            using (var stream = GetStream(TestFiles.Document))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var newPara = new W.Paragraph(
                    new W.Run(
                        new W.Text("Hello")));
                var firstPara = mdp.Document.Body.Elements<W.Paragraph>().FirstOrDefault();

                firstPara.InsertBeforeSelf(newPara);

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 416 || cnt == 2); // v3.0 correctly reports fewer errors than v2.5.1
            }
        }

        [Fact]
        public void W014_MaxCharactersInPart()
        {
            using (var stream = GetStream(TestFiles.Hyperlink))
            {
                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2013),
                    MaxCharactersInPart = 1000
                };

                using (var doc = WordprocessingDocument.Open(stream, false, openSettings))
                {
                    var validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var cnt = validator.Validate(doc).Count();

                    Assert.Equal(5, cnt);
                }
            }
        }

        [Fact]
        public void W013_MarkupCompat_ProcessLoadedPartsOnly()
        {
            using (var stream = GetStream(TestFiles.Hyperlink))
            {
                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2013)
                };

                using (var doc = WordprocessingDocument.Open(stream, false, openSettings))
                {
                    var validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var results = validator.Validate(doc);

                    Assert.Empty(results);
                }
            }
        }

        [Fact]
        public void W012_MarkupCompat_ProcessAllParts()
        {
            var openSettings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013)
            };

            using (var stream = GetStream(TestFiles.Hyperlink))
            using (var doc = WordprocessingDocument.Open(stream, false, openSettings))
            {
                var validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                var cnt = validator.Validate(doc).Count();

                Assert.Equal(0, cnt);
            }
        }

        [Fact]
        public void W011_MarkupCompat_InvalidValidation()
        {
            var openSettings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013)
            };

            using (var stream = GetStream(TestFiles.Hyperlink))
            using (var doc = WordprocessingDocument.Open(stream, false, openSettings))
            {
                Assert.Throws<InvalidOperationException>(() =>
                {
                    var validator = new OpenXmlValidator(FileFormatVersions.Office2007);
                    var cnt = validator.Validate(doc).Count();

                    validator = new OpenXmlValidator(FileFormatVersions.Office2010);
                    cnt += validator.Validate(doc).Count();

                    validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                    cnt += validator.Validate(doc).Count();

                    Assert.Equal(0, cnt);
                });
            }
        }

        [Fact]
        public void W010_HyperlinkRelationships()
        {
            using (var stream = GetStream(TestFiles.Hyperlink))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var mdp = doc.MainDocumentPart;
                var extRels = mdp.HyperlinkRelationships;
                var hyperlinkRel = extRels.First();
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W009_DeleteAllParts()
        {
            using (var stream = GetStream(TestFiles.CommentsDocx, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var allParts = doc.GetAllParts();

                Assert.Throws<ArgumentOutOfRangeException>(() => doc.DeleteParts(allParts));
            }
        }

        [Fact]
        public void W008_AddImageToDocx()
        {
            using (var stream = GetStream(TestFiles.CommentsDocx, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var mainPart = doc.MainDocumentPart;
                var imagePart = mainPart.AddImagePart(ImagePartType.Jpeg);

                using (var image = GetStream(TestFiles.Image))
                {
                    imagePart.FeedData(image);
                }

                AddImageToBody(doc, mainPart.GetIdOfPart(imagePart));

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Single(errs);
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
                                         )
                                         { Preset = A.ShapeTypeValues.Rectangle }))
                             )
                             { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
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
            using (var stream = GetStream(TestFiles.CommentsDocx, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var partList = new[] { doc.MainDocumentPart.GetPartById("rId1") };
                doc.MainDocumentPart.DeleteParts(partList);

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W006_RemoveCommentsPart()
        {
            using (var stream = GetStream(TestFiles.CommentsDocx, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var commentsPart = doc.MainDocumentPart.WordprocessingCommentsPart;
                doc.MainDocumentPart.DeletePart(commentsPart);

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Equal(3, errs.Count());
            }
        }

        [Fact]
        public void W005_AddCommentsPart()
        {
            const string author = "Some Name";
            const string comment = "A comment.";
            const string initials = "ABC";
            const string id = "0";

            using (var stream = GetStream(TestFiles.Plain, true))
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                W.Paragraph firstParagraph =
                    doc.MainDocumentPart.Document.Descendants<W.Paragraph>().First();
                W.Comments comments = null;

                WordprocessingCommentsPart commentPart =
                    doc.MainDocumentPart.AddNewPart<WordprocessingCommentsPart>();
                commentPart.Comments = new W.Comments();
                comments = commentPart.Comments;

                var p = new W.Paragraph(new W.Run(new W.Text(comment)));
                var cmt =
                    new W.Comment()
                    {
                        Id = id,
                        Author = author,
                        Initials = initials,
                        Date = DateTime.Now
                    };
                cmt.AppendChild(p);
                comments.AppendChild(cmt);
                comments.Save();

                firstParagraph.InsertBefore(new W.CommentRangeStart()
                { Id = id }, firstParagraph.GetFirstChild<W.Run>());

                var cmtEnd = firstParagraph.InsertAfter(new W.CommentRangeEnd()
                { Id = id }, firstParagraph.Elements<W.Run>().Last());

                firstParagraph.InsertAfter(new W.Run(new W.CommentReference() { Id = id }), cmtEnd);
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W004_DocxCreation()
        {
            using (var ms = new MemoryStream())
            using (var doc = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document))
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

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void W003_DocxValidation()
        {
            using (var stream = GetStream(TestFiles.Document, true))
            {
                DocxValidationHelper(stream, 832, 418); // v2.5.1 reports more errors than 3.0
            }
        }

        [Fact]
        public void W002_PlainDocxValidation()
        {
            using (var stream = GetStream(TestFiles.Plain, true))
            {
                DocxValidationHelper(stream, 0, 0); // v2.5.1 reports more errors than 3.0
            }
        }

        private static void DocxValidationHelper(Stream stream, int expectedErrorCount, int expectedErrorCount2)
        {
            using (var doc = WordprocessingDocument.Open(stream, true))
            {
                var validator = new OpenXmlValidator(FileFormatVersions.Office2007);
                var cnt = validator.Validate(doc).Count();

                validator = new OpenXmlValidator(FileFormatVersions.Office2010);
                cnt += validator.Validate(doc).Count();

                validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                cnt += validator.Validate(doc).Count();

                Assert.True(cnt == expectedErrorCount || cnt == expectedErrorCount2);
            }
        }

        [Fact]
        public void W001_OpenMemoryStream()
        {
            using (var stream = GetStream(TestFiles.Plain, true))
            using (var wDoc = WordprocessingDocument.Open(stream, true))
            {
                Assert.Equal(11, wDoc.MainDocumentPart.Document.Descendants().Count());
            }
        }
    }
}
