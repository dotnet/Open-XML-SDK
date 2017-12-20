// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using OxTest;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    public class MCSupport
    {
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
            using (var stream = GetStream(TestFiles.mcdoc, true))
            {
                using (var testDocument = WordprocessingDocument.Open(stream, true))
                {
                    OpenXmlPart target = testDocument.MainDocumentPart;
                    OpenXmlPartRootElement actual;
                    actual = target.RootElement;

                    Assert.NotNull(actual.MCAttributes.Ignorable);

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

                using (var testDocument = WordprocessingDocument.Open(stream, true))
                {
                    OpenXmlPart target = testDocument.MainDocumentPart;
                    OpenXmlPartRootElement actual;
                    actual = target.RootElement;

                    Assert.Null(actual.MCAttributes);

                    Assert.NotNull(actual.FirstChild.MCAttributes.PreserveAttributes);

                    Assert.True(actual.FirstChild.HasChildren);
                    //get attribute, no exception thrown
                    OpenXmlAttribute attr = actual.FirstChild.GetAttribute("PreserveAttributes", AlternateContent.MarkupCompatibilityNamespace);
                    Assert.Equal("w14:editId", attr.Value);

                    var list = actual.FirstChild.GetAttributes();
                    Assert.True(list.Contains(attr));
                }
            }
        }

        /// <summary>
        ///Load Ignorable attribute
        ///set attributes
        ///</summary>
        [Fact]
        public void LoadIgnorable()
        {
            var settings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007)
            };

            using (var stream = GetStream(TestFiles.mcdoc))
            using (var testDocument = WordprocessingDocument.Open(stream, false, settings))
            {
                var target = testDocument.MainDocumentPart;
                var root = target.RootElement;
                var p1 = root.FirstChild.FirstChild;

                Assert.Throws<KeyNotFoundException>(() =>
                {
                    p1.GetAttribute("editId", "http://schemas.microsoft.com/office/word/2008/9/12/wordml");
                });
            }
        }

        /// <summary>
        ///Load Preserve attribute
        ///set attributes
        ///</summary>
        [Fact]
        public void LoadPreserveAttr()
        {
            var settings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007)
            };

            using (var stream = GetStream(TestFiles.mcdoc))
            using (var testDocument = WordprocessingDocument.Open(stream, false, settings))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement root = target.RootElement;
                var ppr = root.FirstChild.FirstChild.FirstChild;

                var attr = ppr.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/12/wordml");
                Assert.Equal("myattr", attr.Value);

                var space = ppr.FirstChild;
                attr = space.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/12/wordml");
                Assert.Equal("myattr", attr.Value);

                Assert.Single(space.ExtendedAttributes);

                var r = ppr.NextSibling();
                attr = r.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/12/wordml");
                Assert.Equal("myattr", attr.Value);
                Assert.Single(r.ExtendedAttributes);

                var rpr = r.FirstChild;
                attr = rpr.GetAttribute("myanotherAttr", "http://schemas.microsoft.com/office/word/2008/9/12/wordml");
                Assert.Equal("anotherattr", attr.Value);
                Assert.Single(r.ExtendedAttributes);
            }
        }

        /// <summary>
        ///Load ProcessContent
        ///</summary>
        [Fact]
        public void LoadProcessContent()
        {
            var settings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007)
            };

            using (var stream = GetStream(TestFiles.MCExecl))
            using (var doc = SpreadsheetDocument.Open(stream, false, settings))
            {
                OpenXmlPart target = doc.WorkbookPart.SharedStringTablePart;
                OpenXmlPartRootElement root = target.RootElement;
                var si = root.FirstChild;
                Assert.Empty(si.ExtendedAttributes);

                Assert.Equal(3, si.ChildElements.Count);

                var t = si.FirstChild;
                var attr = t.GetAttribute("a", "http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing");
                Assert.Equal("a", attr.Value);
                attr = t.GetAttribute("b", "http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing");
                Assert.Equal("b", attr.Value);

                Assert.Equal(2, t.ExtendedAttributes.Count());
            }
        }

        /// <summary>
        ///Load ACB
        ///</summary>
        [Fact]
        public void LoadACB()
        {
            var settings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007)
            };

            using (var stream = GetStream(TestFiles.mcdoc, true))
            using (var testDocument = WordprocessingDocument.Open(stream, true, settings))
            {
                OpenXmlPart target = testDocument.MainDocumentPart;
                OpenXmlPartRootElement root = target.RootElement;

                var run = root.FirstChild.FirstChild.FirstChild.NextSibling();
                var secondele = run.FirstChild.NextSibling();

                root.Save();

                Assert.IsType<Picture>(secondele);
            }
        }

        /// <summary>
        ///Load ACB
        ///</summary>
        [Fact]
        public void LoadACB2()
        {
            var settings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007)
            };

            using (var stream = GetStream(TestFiles.mcppt))
            using (var doc = PresentationDocument.Open(stream, false, settings))
            {
                OpenXmlPart target = doc.PresentationPart.TableStylesPart;
                OpenXmlPartRootElement root = target.RootElement;

                var ele = root.FirstChild;
                Assert.IsType<Drawing.TableStyleEntry>(ele);
                var attr = ele.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing");
                Assert.Equal("1", attr.Value);
                Assert.IsType<Drawing.TableStyleEntry>(ele);

                ele = ele.NextSibling();
                attr = ele.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing");
                Assert.Equal("2", attr.Value);
                Assert.IsType<Drawing.TableStyleEntry>(ele);

                ele = ele.NextSibling();
                attr = ele.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing");
                Assert.Equal("3", attr.Value);
                Assert.IsType<Drawing.TableStyleEntry>(ele);

                ele = ele.NextSibling();
                attr = ele.GetAttribute("myattr", "http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing");
                Assert.Equal("4", attr.Value);
                Assert.IsType<Drawing.TableStyleEntry>(ele);

                ele = ele.NextSibling();
                Assert.Null(ele);
            }
        }

        /// <summary>
        ///Save other parts
        ///</summary>
        [Fact]
        public void MCSave()
        {
            // Didn't process whole package, should not process style part
            var settings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007)
            };

            using (var stream = GetStream(TestFiles.mcdoc, true))
            {
                using (var testDocument = WordprocessingDocument.Open(stream, true, settings))
                {
                    OpenXmlPart target = testDocument.MainDocumentPart;
                    OpenXmlPartRootElement root = target.RootElement;
                }

                stream.Position = 0;

                // Open in full mode, style part still has MC
                using (var testDocument = WordprocessingDocument.Open(stream, true))
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

                stream.Position = 0;

                // Process whole package, should process style part
                settings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007);
                using (var testDocument = WordprocessingDocument.Open(stream, true, settings))
                {
                    OpenXmlPart target = testDocument.MainDocumentPart;
                    OpenXmlPartRootElement root = target.RootElement;
                }

                stream.Position = 0;

                // Open in full mode, style part has no MC
                using (var testDocument = WordprocessingDocument.Open(stream, true))
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
            }
        }

        ///<summary>
        ///MCMustUnderstand.
        ///</summary>
        [Fact]
        public void MCMustUnderstand()
        {
            var settings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007)
            };

            using (var stream = GetStream(TestFiles.mcdoc, true))
            {
                using (var testDocument = WordprocessingDocument.Open(stream, true, settings))
                {
                    var target = testDocument.MainDocumentPart;
                    var root = target.RootElement;
                    root.FirstChild.MCAttributes = new MarkupCompatibilityAttributes
                    {
                        MustUnderstand = "w14"
                    };

                    var run = root.FirstChild.FirstChild.FirstChild.NextSibling();
                    var secondele = run.FirstChild.NextSibling();

                    Assert.True(secondele is Picture);
                }

                stream.Position = 0;

                using (var testDocument = WordprocessingDocument.Open(stream, true, settings))
                {
                    OpenXmlPart target = testDocument.MainDocumentPart;
                    //should throw exception here
                    Assert.Throws<NamespaceNotUnderstandException>(() =>
                    {
                        OpenXmlPartRootElement root = target.RootElement;
                    });
                }
            }
        }

        ///<summary>
        ///ParticalProperty.
        ///</summary>
        [Fact]
        public void ParticalProperty()
        {
            var settings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, FileFormatVersions.Office2007)
            };

            using (var stream = GetStream(TestFiles.simpleSdt, true))
            {
                using (var testDocument = WordprocessingDocument.Open(stream, true, settings))
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
                stream.Position = 0;

                using (var testDocument = WordprocessingDocument.Open(stream, true, settings))
                {
                    OpenXmlPart target = testDocument.MainDocumentPart;
                    OpenXmlPartRootElement root = target.RootElement;
                    var sdt = root.FirstChild.FirstChild as SdtBlock;
                    SdtProperties sdtpr = sdt.SdtProperties;

                    var alias = sdt.SdtProperties.FirstChild as SdtAlias;
                    Assert.Equal("newsdt", alias.Val.Value);
                }
            }
        }

        /// <summary>
        ///Write out extra xmlns attribute when the mc defined some prefix bug xmlwriter ignored its declaration
        ///</summary>
        [Fact]
        public void WriteExtraAttr()
        {
            using (var testStream = GetStream(TestFiles.HelloO14, true))
            {
                using (var doc = WordprocessingDocument.Open(testStream, true))
                {
                    // Touch the font table part.
                    var fontTablePart = doc.MainDocumentPart.GetPartsOfType<FontTablePart>().First();
                    var root = fontTablePart.Fonts;

                    var docNode = doc.MainDocumentPart.Document;
                }

                testStream.Position = 0;

                // Open it again, mark sure in font part, the "w14" prefix is still recognized
                using (var testDocument = WordprocessingDocument.Open(testStream, true))
                {
                    OpenXmlPart target = testDocument.MainDocumentPart.FontTablePart;

                    using (var stream = target.GetStream())
                    using (var reader = System.Xml.XmlReader.Create(stream))
                    {
                        reader.Read();
                        reader.MoveToContent();

                        var ns = reader.LookupNamespace("w14");
                        Assert.NotNull(ns);
                    }
                }
            }
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
