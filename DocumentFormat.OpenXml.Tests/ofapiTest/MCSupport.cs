// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Drawing;
using OxTest;
#if WB
using DocumentFormat.OpenXml.WB.Tests;
#endif

namespace DocumentFormat.OpenXml.Tests
{
    public class MCSupport
    {
        ///<summary>
        ///Constructor.
        ///</summary>
        public MCSupport()
        {
        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private void CopyFileStream(byte[] srcBuffer, string fileName)
        {
            using (var target = System.IO.File.Create(fileName))
            {
                using (var src = new System.IO.MemoryStream(srcBuffer, false))
                {
                    src.WriteTo(target);
                }
            }
        }

        /// <summary>
        ///Load MC attribute
        ///set attributes
        ///</summary>
        [Fact]
        public void LoadAttributeTest()
        {
            string file = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            CopyFileStream(TestFileStreams.mcdoc, file);


            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement actual;
                actual = target.RootElement;

                Assert.NotEqual(null, actual.MCAttributes.Ignorable);

                //get attribute, no exception thrown
                OpenXmlAttribute attr = actual.GetAttribute("Ignorable", AlternateContent.MarkupCompatibilityNamespace);
                Assert.Equal("w14 wp14", attr.Value);

                var list = actual.GetAttributes();
                Assert.True(list.Contains(attr));

                //set attribute
                actual.MCAttributes = null;

                actual.FirstChild.MCAttributes = new MarkupCompatibilityAttributes();
                actual.FirstChild.MCAttributes.PreserveAttributes = "w14:editId";
                actual.FirstChild.SetAttribute(new OpenXmlAttribute("mc:PreserveElements", AlternateContent.MarkupCompatibilityNamespace, "w14:para"));

                actual.FirstChild.FirstChild.MCAttributes = new MarkupCompatibilityAttributes();
                actual.FirstChild.FirstChild.MCAttributes.Ignorable = "w14";
                actual.FirstChild.FirstChild.RemoveAllChildren();

                actual.Save();
            }

            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement actual;
                actual = target.RootElement;

                Assert.Equal(null, actual.MCAttributes);

                Assert.NotEqual(null, actual.FirstChild.MCAttributes.PreserveAttributes);

                Assert.True(actual.FirstChild.HasChildren);
                //get attribute, no exception thrown
                OpenXmlAttribute attr = actual.FirstChild.GetAttribute("PreserveAttributes", AlternateContent.MarkupCompatibilityNamespace);
                Assert.Equal("w14:editId", attr.Value);

                var list = actual.FirstChild.GetAttributes();
                Assert.True(list.Contains(attr));
            }
            System.IO.File.Delete(file);
        }

        /// <summary>
        ///Load Ignorable attribute
        ///set attributes
        ///</summary>
        [Fact]
        public void LoadIgnorable()
        {
            string file = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            CopyFileStream(TestFileStreams.mcdoc, file);

            OpenXmlElement p1 = null;
            OpenSettings settings = new OpenSettings();            
            settings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007);
            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true, settings))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement root = target.RootElement;

                p1 = root.FirstChild.FirstChild;
                root.Save();
            }
            //should throw exception
            Assert.Throws<KeyNotFoundException>(() =>
                {
                    p1.GetAttribute("editId", "http://schemas.microsoft.com/office/word/2008/9/12/wordml");
                });
            System.IO.File.Delete(file);
        }

        /// <summary>
        ///Load Preserve attribute
        ///set attributes
        ///</summary>
        [Fact]
        public void LoadPreserveAttr()
        {
            string file = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            CopyFileStream(TestFileStreams.mcdoc, file);
            OpenSettings settings = new OpenSettings();
            settings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007);
            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true, settings))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement root = target.RootElement;
                var ppr = root.FirstChild.FirstChild.FirstChild;

                var attr = ppr.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/12/wordml");
                Assert.Equal("myattr", attr.Value);

                var space = ppr.FirstChild;
                attr = space.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/12/wordml");
                Assert.Equal("myattr", attr.Value);

                Assert.Equal(1, space.ExtendedAttributes.Count());

                var r = ppr.NextSibling();
                attr = r.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/12/wordml");
                Assert.Equal("myattr", attr.Value);
                Assert.Equal(1, r.ExtendedAttributes.Count());

                var rpr = r.FirstChild;
                attr = rpr.GetAttribute("myanotherAttr", "http://schemas.microsoft.com/office/word/2008/9/12/wordml");
                Assert.Equal("anotherattr", attr.Value);
                Assert.Equal(1, r.ExtendedAttributes.Count());

            }
            System.IO.File.Delete(file);
        }

        /// <summary>
        ///Load ProcessContent
        ///</summary>
        [Fact]
        public void LoadProcessContent()
        {
            string file = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            CopyFileStream(TestFileStreams.MCExecl, file);
            OpenSettings settings = new OpenSettings();
            settings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007);
            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(file,true,settings))
            {
                OpenXmlPart target = doc.WorkbookPart.SharedStringTablePart;
                OpenXmlPartRootElement root = target.RootElement;
                var si = root.FirstChild;
                Assert.Equal(0, si.ExtendedAttributes.Count());

                Assert.Equal(3, si.ChildElements.Count);

                var t = si.FirstChild;
                var attr = t.GetAttribute("a", "http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing");
                Assert.Equal("a", attr.Value);
                attr = t.GetAttribute("b", "http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing");
                Assert.Equal("b", attr.Value);

                Assert.Equal(2, t.ExtendedAttributes.Count());

            }
            System.IO.File.Delete(file);
        }

        /// <summary>
        ///Load ACB
        ///</summary>
        [Fact]
        public void LoadACB()
        {
            string file = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            CopyFileStream(TestFileStreams.mcdoc, file);

            OpenSettings settings = new OpenSettings();
            settings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007);
            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true, settings))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement root = target.RootElement;

                var run = root.FirstChild.FirstChild.FirstChild.NextSibling();
                var secondele = run.FirstChild.NextSibling();

                root.Save();

                Assert.True(secondele is DocumentFormat.OpenXml.Wordprocessing.Picture);

            }
            System.IO.File.Delete(file);
        }

        /// <summary>
        ///Load ACB
        ///</summary>
        [Fact]
        public void LoadACB2()
        {
            string file = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            CopyFileStream(TestFileStreams.mcppt, file);
            OpenSettings settings = new OpenSettings();
            settings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007);
            using(PresentationDocument doc = PresentationDocument.Open(file, true, settings ))
            {
                OpenXmlPart target = doc.PresentationPart.TableStylesPart;
                OpenXmlPartRootElement root = target.RootElement;

                var ele = root.FirstChild;
                Assert.True(ele is DocumentFormat.OpenXml.Drawing.TableStyleEntry);
                var attr = ele.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing");
                Assert.Equal("1", attr.Value);
                Assert.True(ele is DocumentFormat.OpenXml.Drawing.TableStyleEntry);

                ele = ele.NextSibling();
                attr = ele.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing");
                Assert.Equal("2", attr.Value);
                Assert.True(ele is DocumentFormat.OpenXml.Drawing.TableStyleEntry);

                ele = ele.NextSibling();
                attr = ele.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing");
                Assert.Equal("3", attr.Value);
                Assert.True(ele is DocumentFormat.OpenXml.Drawing.TableStyleEntry);

                ele = ele.NextSibling();
                attr = ele.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing");
                Assert.Equal("4", attr.Value);
                Assert.True(ele is DocumentFormat.OpenXml.Drawing.TableStyleEntry);

                ele = ele.NextSibling();
                Assert.Equal(null, ele);

                root.Save();

            }
            System.IO.File.Delete(file);
        }

        /// <summary>
        ///Save other parts
        ///</summary>
        [Fact]
        public void MCSave()
        {
            string file = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            CopyFileStream(TestFileStreams.mcdoc, file);

            //didn't process whole package ,should not process style part
            OpenSettings settings = new OpenSettings();
            settings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007);
            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true,settings ))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement root = target.RootElement;
            }

            //open in full mode, style part still has MC
            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement root = target.RootElement;
                OpenXmlElement p1 = null;    
                p1 = root.FirstChild.FirstChild;
                //should throw exception
                var attrs = p1.GetAttributes();
                Assert.Equal(3, attrs.Count);

                target = testDocument.MainDocumentPart.StyleDefinitionsPart;
                root = target.RootElement;
                var rprDefault = root.FirstChild.FirstChild;
                Assert.Equal(2, rprDefault.GetAttributes().Count);
            }


            //process whole package ,should process style part
            
            settings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007);
            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true, settings))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement root = target.RootElement;
                
            }

            //open in full mode, style part has no MC
            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement root = target.RootElement;

                OpenXmlElement p1 = null;
                p1 = root.FirstChild.FirstChild;
                Assert.Equal(3, p1.GetAttributes().Count);

                target = testDocument.MainDocumentPart.StyleDefinitionsPart;
                root = target.RootElement;
                var rprDefault = root.FirstChild.FirstChild;
                Assert.Equal(1, rprDefault.GetAttributes().Count);
            }
            System.IO.File.Delete(file);
        }

        ///<summary>
        ///MCMustUnderstand.
        ///</summary>
        [Fact]
        public void MCMustUnderstand()
        {
            string file = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            CopyFileStream(TestFileStreams.mcdoc, file);
            OpenSettings settings = new OpenSettings();
            settings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007);
            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true, settings))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement root = target.RootElement;
                root.FirstChild.MCAttributes = new MarkupCompatibilityAttributes();
                root.FirstChild.MCAttributes.MustUnderstand = "w14";
                var run = root.FirstChild.FirstChild.FirstChild.NextSibling();
                var secondele = run.FirstChild.NextSibling();
                Assert.True(secondele is DocumentFormat.OpenXml.Wordprocessing.Picture);
            }

            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true, settings))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                //should throw exception here
                Assert.Throws<NamespaceNotUnderstandException>(() =>
                {
                    OpenXmlPartRootElement root = target.RootElement;
                });
            }
            System.IO.File.Delete(file);
        }

        ///<summary>
        ///ParticalProperty.
        ///</summary>
        [Fact]
        public void ParticalProperty()
        {
            string file = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            CopyFileStream(TestFileStreams.simpleSdt, file);
            OpenSettings settings = new OpenSettings();
            settings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007);
            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true, settings ))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement root = target.RootElement;
                var sdt = root.FirstChild.FirstChild as SdtBlock;
                SdtProperties sdtpr = sdt.SdtProperties;

                var alias = sdt.SdtProperties.FirstChild as SdtAlias;
                Assert.Equal("SDT1", alias.Val.Value);
                alias.Val.Value = "newsdt";
            }

            settings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007);
            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true, settings ))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement root = target.RootElement;
                var sdt = root.FirstChild.FirstChild as SdtBlock;
                SdtProperties sdtpr = sdt.SdtProperties;

                var alias = sdt.SdtProperties.FirstChild as SdtAlias;
                Assert.Equal("newsdt", alias.Val.Value);
            }
            System.IO.File.Delete(file);
        }

        /// <summary>
        ///Write out extra xmlns attribute when the mc defined some prefix bug xmlwriter ignored its declaration
        ///</summary>
        [Fact]
        public void WriteExtraAttr()
        {
            string file = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            CopyFileStream(TestFileStreams.HelloO14, file);

            //open it using the sdk
            using (var doc = WordprocessingDocument.Open(file, true))
            {
                // Touch the font table part.
                var fontTablePart = doc.MainDocumentPart.GetPartsOfType<FontTablePart>().First();
                var root = fontTablePart.Fonts;

                var docNode = doc.MainDocumentPart.Document;
            }


            //open it again, mark sure in font part, the "w14" prefix is still recognized
            using (WordprocessingDocument testDocument = WordprocessingDocument.Open(file, true))
            {
                OpenXmlPart target = testDocument.MainDocumentPart.FontTablePart;
                using (Stream stream = target.GetStream())
                using (System.Xml.XmlReader reader = System.Xml.XmlReader.Create(stream))
                {
                    reader.Read();
                    reader.MoveToContent();

                    var ns = reader.LookupNamespace("w14");
                    Assert.NotEqual(null, ns);
                }
            }
            System.IO.File.Delete(file);
        }

        ///<summary>
        ///Bug718314.
        ///</summary>
        [Fact]
        public void Bug718314()
        {
            string testFile = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            using (WordprocessingDocument doc = WordprocessingDocument.Create(testFile, WordprocessingDocumentType.Document))
            {
                var mpart = doc.AddMainDocumentPart();
                mpart.Document = new Document();
                mpart.Document.Body = new Body();
                mpart.Document.Body.Append(new AlternateContent());
            }

            OpenSettings s = new OpenSettings();
            s.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007);
            using (var doc = WordprocessingDocument.Open(testFile, true, s))
            {
                Assert.Null(doc.MainDocumentPart.Document.Body.FirstChild);
            }
            System.IO.File.Delete(testFile);
        }

        ///<summary>
        ///Bug718316.
        ///</summary>
        [Fact]
        public void Bug718316()
        {
            string testFile = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
            using (WordprocessingDocument doc = WordprocessingDocument.Create(testFile, WordprocessingDocumentType.Document))
            {
                var mpart = doc.AddMainDocumentPart();
                mpart.Document = new Document();
                mpart.Document.Body = new Body();
                var ac = new AlternateContent();
                mpart.Document.Body.Append(ac);
                var c = new AlternateContentChoice();
                c.AddNamespaceDeclaration("w13", "http://w13");
                c.Requires = "w13";
                ac.Append(c);
            }

            OpenSettings s = new OpenSettings();
            s.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007);
            using (var doc = WordprocessingDocument.Open(testFile, true, s))
            {
                Assert.Null(doc.MainDocumentPart.Document.Body.FirstChild);
            }
            System.IO.File.Delete(testFile);
        }
    }
}
