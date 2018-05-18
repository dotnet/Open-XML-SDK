﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Xunit;
using Xunit.Abstractions;

#pragma warning disable 162

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Summary description for OpenXmlReaderWriterTest
    /// </summary>
    public class OpenXmlReaderWriterTest : OpenXmlDomTestBase
    {
        public OpenXmlReaderWriterTest(ITestOutputHelper output)
            : base(output)
        {
        }

        /// <summary>
        /// Switch for the IgnoreWhitespace fix O15#3024890
        /// </summary>
        private const bool IGNORE_WHITESPACE_SETTING = true;

        #region Reader Test ...

        #region ReaderConstruction ...

        private ConstrReader PartConstrWithNoMisc = (WordprocessingDocument x, out OpenXmlReader y, out XmlReader z) =>
        {
            y = OpenXmlReader.Create(x.MainDocumentPart);
            z = XmlReader.Create(x.MainDocumentPart.GetStream());
        };

        private ConstrReader PartConstrWithMisc = (WordprocessingDocument x, out OpenXmlReader y, out XmlReader z) =>
        {
            y = OpenXmlReader.Create(x.MainDocumentPart.GetStream(), true);
            z = XmlReader.Create(x.MainDocumentPart.GetStream());
        };

        private ConstrReader DomConstrWithNoMisc = (WordprocessingDocument x, out OpenXmlReader y, out XmlReader z) =>
        {
            OpenXmlElement firstChild = x.MainDocumentPart.Document.FirstChild;
            y = OpenXmlDomReader.Create(firstChild);

            XElement XfirstChild = ConvertToXElement(x.MainDocumentPart, firstChild);
            z = XmlReader.Create(new StringReader(firstChild.OuterXml));
        };

        private ConstrReader DomConstrWithMisc = (WordprocessingDocument x, out OpenXmlReader y, out XmlReader z) =>
        {
            OpenXmlElement firstChild = x.MainDocumentPart.Document.FirstChild;
            y = new OpenXmlDomReader(firstChild, true);

            XElement XfirstChild = ConvertToXElement(x.MainDocumentPart, firstChild);
            z = XmlReader.Create(new StringReader(firstChild.OuterXml));
        };

        private PreRead initialReader = (OpenXmlReader x, XmlReader y, out string standalone) =>
        {
            Read(x);
            Read(y);

            standalone = string.Empty;
            if (y.NodeType == XmlNodeType.XmlDeclaration)
            {
                standalone = y.GetAttribute("standalone");
                if (!x.ReadMiscNodes)
                    while (Read(y) && IsMisc(y))
                    {
                    }
                else
                    Read(y);
            }
        };

        #endregion

        #endregion

        #region Writer Test ...

        [Fact]
        public void WriteStartDocumentTest()
        {
            TestWriteStartDocument(WConstrWithPart, WriteStartD, null);
        }

        [Fact]
        public void WriteStartDocumentWithStandalone()
        {
            TestWriteStartDocument(WConstrWithPartEnc, WriteStartD, true);
        }

        [Fact]
        public void WriteStartDocumentMultiple()
        {
            using (var stream = new MemoryStream())
            using (var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                var part = newDoc.AddMainDocumentPart();

                using (var writer = PWCosntrWithPart(part))
                {
                    writer.WriteStartDocument();
                    Assert.Throws<InvalidOperationException>(() => writer.WriteStartDocument());
                }
            }
        }

        [Fact]
        public void WriteStartDocumentOtherPlace()
        {
            using (var stream = new MemoryStream())
            using (var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                var part = newDoc.AddMainDocumentPart();
                var p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };

                using (var writer = PWCosntrWithPart(part))
                {
                    writer.WriteElement(p);
                    Assert.Throws<InvalidOperationException>(() => writer.WriteStartDocument());
                }
            }
        }

        [Fact]
        public void WriteStartElementWithOpenXmlReaderAttr()
        {
            Paragraph p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };
            OpenXmlReader reader = OpenXmlReader.Create(p);
            reader.Read();

            TestWriteStartElement(WConstrWithStream, WriteStartE, reader, GetTestAttributes(), null);
        }

        [Fact]
        public void WriteStartElementWithOpenXmlReader()
        {
            Paragraph p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };
            OpenXmlReader reader = OpenXmlReader.Create(p);
            reader.Read();

            TestWriteStartElement(WConstrWithStream, WriteStartE, reader, null, null);
        }

        [Fact]
        public void WriteStartElementWithEndElementReader()
        {
            Paragraph p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };
            OpenXmlReader reader = OpenXmlReader.Create(p);
            reader.Read();
            reader.LoadCurrentElement();

            try
            {
                TestWriteStartElement(WConstrWithStream, WriteStartE, reader, null, null);
                Log.VerifyShouldNotReachHere("expected ArgumentOutOfRangeException is not thrown");
            }
            catch (ArgumentOutOfRangeException)
            {
                Log.Pass("Expected ArgumentOutOfRangeException is thrown");
            }
        }

        [Fact]
        public void WriteStartElementWithOpenXmlElementAttr()
        {
            Paragraph p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };

            TestWriteStartElement(WConstrWithStream, WriteStartE, p, GetTestAttributes(), null);
        }

        [Fact]
        public void WriteStartElementWithOpenXmlElement()
        {
            Paragraph p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };

            TestWriteStartElement(WConstrWithStream, WriteStartE, p, null, null);
        }

        [Fact]
        public void WriteStringAndEndElement()
        {
            using (var stream = new MemoryStream())
            using (var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                var t = new Text();
                var part = newDoc.AddMainDocumentPart();

                using (var writer = WConstrWithPart(part))
                {
                    writer.WriteStartElement(t);
                    writer.WriteString("test");
                    writer.WriteEndElement();
                }

                using (var reader = XmlReader.Create(part.GetStream()))
                {
                    Assert.True(reader.Read());
                    Assert.True(reader.Read());
                    Assert.True(reader.Read());
                    Assert.Equal("test", reader.Value);

                    Assert.True(reader.Read());
                    Assert.Equal(XmlNodeType.EndElement, reader.NodeType);
                    Assert.Equal(t.LocalName, reader.LocalName);
                }
            }
        }

        [Fact]
        public void WriteEndElementWithoutStart()
        {
            using (var stream = new MemoryStream())
            using (var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                var t = new Text();
                var part = newDoc.AddMainDocumentPart();

                using (var writer = WConstrWithPart(part))
                {
                    Assert.Throws<InvalidOperationException>(() => writer.WriteEndElement());
                }
            }
        }

        // Comment out as the result of bug 2352836
        [Fact]
        public void WriteStringWithNonLeafText()
        {
            using (var stream = new MemoryStream())
            using (var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                var p = new Paragraph() { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };
                var part = newDoc.AddMainDocumentPart();

                using (OpenXmlWriter writer = WConstrWithPart(part))
                {
                    writer.WriteStartElement(p);
                    Assert.Throws<InvalidOperationException>(() => writer.WriteString("test"));
                }
            }
        }

        [Fact]
        public void WriteElement()
        {
            using (var stream = new MemoryStream())
            using (var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                Paragraph p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };
                MainDocumentPart part = newDoc.AddMainDocumentPart();
                OpenXmlWriter writer = WConstrWithPart(part);

                writer.WriteElement(p);
                writer.Close();

                XElement XEle = null;
                using (Stream partStream = part.GetStream())
                using (XmlReader reader = XmlReader.Create(partStream))
                {
                    XEle = XElement.Load(reader);
                }

                VerifyEqual(XEle, p, part);
            }
        }

        [Fact]
        public void WriteStartElementWithMisc()
        {
            var node = new OpenXmlMiscNode(XmlNodeType.Comment);
            using (var miscReader = OpenXmlReader.Create(node, true))
            {
                Assert.True(miscReader.Read());
                Assert.Throws<ArgumentOutOfRangeException>(() => TestWriteStartElement(WConstrWithStream, WriteStartE, miscReader, null, null));
            }
        }

        private void TestWriteStartDocument(ConstrWriter writerConstr, WriteStartDoc write, bool? standalone)
        {
            using (var stream = new MemoryStream())
            using (var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                var part = newDoc.AddMainDocumentPart();

                using (var writer = writerConstr(part))
                {
                    write(writer, standalone);
                }

                VerifyDocumentStart(part, standalone);
            }
        }

        private void VerifyDocumentStart(OpenXmlPart part, bool? standalone)
        {
            XmlReader reader = XmlReader.Create(part.GetStream());
            reader.Read();

            Log.Comment("verify the part contains XmlDeclaration");
            Log.VerifyTrue(reader.NodeType == XmlNodeType.XmlDeclaration, "expected: XmlDeclaration <> actual: {0}", reader.NodeType);
            Log.Comment("verify the version is 1.0");
            Log.VerifyTrue(reader.GetAttribute("version") == "1.0", "expected: 1.0 <> actual:{0}", reader.GetAttribute("version"));

            string standaloneValue = reader.GetAttribute("standalone");

            if (standalone.HasValue)
            {
                Log.Comment("verify if the standalone is set correctly");
                Log.VerifyTrue(standaloneValue.Equals(standalone.Value == true ? "yes" : "no", StringComparison.OrdinalIgnoreCase),
                    "expected: {0} <> actual: {1}", standalone.Value == true ? "yes" : "no", standaloneValue);
            }
            else
            {
                Log.Comment("verify the standalone is not presented");
                Log.VerifyTrue(standaloneValue == null, "expected: null <> actual: {0}", standaloneValue);
            }
        }

        private void WriteStartD(OpenXmlWriter writer, bool? standalone)
        {
            if (standalone.HasValue)
                writer.WriteStartDocument(standalone.Value);
            else
                writer.WriteStartDocument();
        }

        private void WriteStartE(OpenXmlWriter writer, object writeSource, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
        {
            if (writeSource is OpenXmlReader && attributes == null)
            {
                writer.WriteStartElement(writeSource as OpenXmlReader);
            }
            else if (writeSource is OpenXmlReader && attributes != null && namespaceDeclarations == null)
            {
                writer.WriteStartElement(writeSource as OpenXmlReader, attributes);
            }
            else if (writeSource is OpenXmlReader && attributes != null && namespaceDeclarations != null)
            {
                writer.WriteStartElement(writeSource as OpenXmlReader, attributes, namespaceDeclarations);
            }
            else if (writeSource is OpenXmlElement && attributes == null)
            {
                writer.WriteStartElement(writeSource as OpenXmlElement);
            }
            else if (writeSource is OpenXmlElement && attributes != null && namespaceDeclarations == null)
            {
                writer.WriteStartElement(writeSource as OpenXmlElement, attributes);
            }
            else if (writeSource is OpenXmlElement && attributes != null && namespaceDeclarations != null)
            {
                writer.WriteStartElement(writeSource as OpenXmlElement, attributes);
            }
        }

        private void TestWriteStartElement(ConstrWriter writerConstr, WriteStartEle write, object writeSource, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
        {
            using (var ms = new MemoryStream())
            using (WordprocessingDocument newDoc = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document))
            {
                MainDocumentPart part = newDoc.AddMainDocumentPart();

                using (Stream stream = part.GetStream())
                using (OpenXmlWriter writer = OpenXmlWriter.Create(stream))
                {
                    write(writer, writeSource, attributes, namespaceDeclarations);
                }

                VerifyStartElement(part, writeSource, attributes, namespaceDeclarations);
            }
        }

        private IEnumerable<OpenXmlAttribute> GetTestAttributes()
        {
            for (int i = 0; i < 5; i++)
            {
                yield return new OpenXmlAttribute("c", "test" + i, string.Empty, i.ToString());
            }
        }

        private void VerifyStartElement(OpenXmlPart part, object writeSource, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
        {
            using (Stream stream = part.GetStream())
            using (XmlReader xmlReader = XmlReader.Create(stream))
            {
                xmlReader.Read();
                xmlReader.Read();

                Log.Comment("the element written out is a start element");
                Log.VerifyTrue(xmlReader.IsStartElement(), "Expected: True <> Actual: False");

                if (writeSource is OpenXmlReader)
                {
                    OpenXmlReader oReader = writeSource as OpenXmlReader;
                    Log.VerifyTrue(xmlReader.LocalName == oReader.LocalName, "expected: {0} <> actual: {1}", oReader.LocalName, xmlReader.LocalName);

                    if (attributes != null)
                    {
                        foreach (OpenXmlAttribute attr in attributes)
                        {
                            Log.VerifyTrue(attr.Value == xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri), "expected: {0} <> actual: {1}", attr.Value, xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri));
                        }
                    }
                    else
                    {
                        foreach (OpenXmlAttribute attr in oReader.Attributes)
                        {
                            Log.VerifyTrue(attr.Value == xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri), "expected: {0} <> actual: {1}", attr.Value, xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri));
                        }
                    }

                    if (namespaceDeclarations != null)
                    {
                        foreach (var ns in namespaceDeclarations)
                        {
                            Log.VerifyTrue(ns.Value == xmlReader.GetAttribute(string.Format("{0}:{1}", "xmlns", ns.Key)), "expected: {0} <> actual: {1}", ns.Value, xmlReader.GetAttribute(string.Format("{0}:{1}", "xmlns", ns.Key)));
                        }
                    }
                    else
                    {
                        foreach (var ns in oReader.NamespaceDeclarations)
                        {
                            Log.VerifyTrue(ns.Value == xmlReader.GetAttribute(string.Format("{0}:{1}", "xmlns", ns.Key)), "expected: {0} <> actual: {1}", ns.Value, xmlReader.GetAttribute(string.Format("{0}:{1}", "xmlns", ns.Key)));
                        }
                    }
                }
                else if (writeSource is OpenXmlElement)
                {
                    OpenXmlElement element = writeSource as OpenXmlElement;

                    Log.VerifyTrue(xmlReader.LocalName == element.LocalName, "expected: {0} <> actual: {1}", element.LocalName, xmlReader.LocalName);

                    if (attributes != null)
                    {
                        foreach (OpenXmlAttribute attr in attributes)
                        {
                            Log.VerifyTrue(attr.Value == xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri), "expected: {0} <> actual: {1}", attr.Value, xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri));
                        }
                    }
                    else
                    {
                        foreach (OpenXmlAttribute attr in element.GetAttributes())
                        {
                            Log.VerifyTrue(attr.Value == xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri), "expected: {0} <> actual: {1}", attr.Value, xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri));
                        }
                    }

                    if (namespaceDeclarations != null)
                    {
                        foreach (var ns in namespaceDeclarations)
                        {
                            Log.VerifyTrue(ns.Value == xmlReader.GetAttribute(string.Format("{0}:{1}", "xmlns", ns.Key)), "expected: {0} <> actual: {1}", ns.Value, xmlReader.GetAttribute(string.Format("{0}:{1}", "xmlns", ns.Key)));
                        }
                    }
                    else
                    {
                        foreach (var ns in element.NamespaceDeclarations)
                        {
                            Log.VerifyTrue(ns.Value == xmlReader.GetAttribute(string.Format("{0}:{1}", "xmlns", ns.Key)), "expected: {0} <> actual: {1}", ns.Value, xmlReader.GetAttribute(string.Format("{0}:{1}", "xmlns", ns.Key)));
                        }
                    }
                }
            }
        }

        #region Writer Construction ...

        private ConstrWriter WConstrWithPart = x => OpenXmlWriter.Create(x);

        private ConstrWriter WConstrWithPartEnc = x => OpenXmlWriter.Create(x, Encoding.UTF8);

        private ConstrWriter WConstrWithStream = x => OpenXmlWriter.Create(x.GetStream());

        private ConstrWriter WConstrWithStreamEnc = x => OpenXmlWriter.Create(x.GetStream(), Encoding.UTF8);

        private ConstrWriter PWCosntrWithPart = x => new OpenXmlPartWriter(x);

        private ConstrWriter PWConstrWithPartEnc = x => new OpenXmlPartWriter(x, Encoding.UTF8);

        private ConstrWriter PWConstrWithStream = x => new OpenXmlPartWriter(x.GetStream());

        private ConstrWriter PWConstrWithStreamEnc = x => new OpenXmlPartWriter(x.GetStream(), Encoding.UTF8);

        #endregion

        #endregion

        #region Help Methods ...

        private delegate bool Reading(OpenXmlReader Oreader, XmlReader Xreader);

        private delegate void PreRead(OpenXmlReader Oreader, XmlReader Xreader, out string standalone);

        private delegate void ConstrReader(WordprocessingDocument doc, out OpenXmlReader Oreader, out XmlReader Treader);

        private delegate OpenXmlWriter ConstrWriter(OpenXmlPart part);

        private delegate void WriteStartDoc(OpenXmlWriter writer, bool? standalone);

        private delegate void WriteStartEle(OpenXmlWriter writer, object writeSource, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations);

        /// <summary>
        /// Call OpenXmlReader LoadCurrentElement() method, and move the corresponding XmlReader to
        /// the match point as the OpenXmlReader according to the Read algorithm.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="Xreader"></param>
        /// <returns></returns>
        private bool LoadCurrentElement(OpenXmlReader reader, XmlReader Xreader)
        {
            Log.Comment("LoadCurrentElement()");
            if (reader.IsEndElement || Xreader.EOF)
            {
                try
                {
                    Log.Comment("Load current element from an EndElement or EOF, expect InvalidOperationException");
                    OpenXmlElement element = reader.LoadCurrentElement();
                    Log.VerifyShouldNotReachHere("Expect InvalidOperationException");
                }
                catch (InvalidOperationException)
                {
                    Log.Pass("Expected InvalidOperationException is thrown");
                    Read(reader, Xreader);
                }
            }
            else if (reader.IsStartElement)
            {
                bool IsStart = reader.IsStartElement;
                OpenXmlElement element = reader.LoadCurrentElement();
                bool skip = (IsStart == true) && (reader.IsStartElement == false);

                Log.Comment("check if the load is successful");
                Log.VerifyNotNull(element, "Fail to load OpenXmlElement from OpenXmlReader");
                Log.VerifyTrue(element.LocalName.Equals(Xreader.Name.Replace(Xreader.Prefix + ":", string.Empty),
                    StringComparison.OrdinalIgnoreCase), "LocalName test FAIL. Expected: {0} <> Actual: {1}",
                    Xreader.Name.Replace(Xreader.Prefix + ":", string.Empty), element.LocalName);
                if (!(reader is OpenXmlDomReader))
                {
                    Log.VerifyTrue(element.HasAttributes == Xreader.HasAttributes, "HasAttributes test FAIL. Expected: {0} <> Actual: {1}",
                              Xreader.HasAttributes, element.HasAttributes);
                    Log.VerifyTrue(element.GetAttributes().Count() == Xreader.AttributeCount, "Attribute Count test FAIL.  Expected: {0} <> Actual: {1}",
                        Xreader.AttributeCount, element.GetAttributes().Count());
                }

                if (reader.ReadMiscNodes)
                {
                    if (IsMisc(Xreader))
                        Read(Xreader);
                    else
                    {
                        if (!(Xreader.IsEmptyElement && reader.IsEndElement && skip))
                        {
                            int oldDepth = Xreader.Depth;
                            while (Read(Xreader) && !(Xreader.NodeType == XmlNodeType.EndElement && Xreader.Depth <= oldDepth))
                            {
                            }
                        }
                    }
                }
                else
                {
                    if (!(Xreader.IsEmptyElement && reader.IsEndElement && skip))
                    {
                        int oldDepth = Xreader.Depth;
                        while (Read(Xreader) && !(Xreader.NodeType == XmlNodeType.EndElement && Xreader.Depth <= oldDepth))
                        {
                        }
                    }
                }
            }
            else if (reader.ReadMiscNodes && IsMisc(Xreader))
            {
                OpenXmlElement loaded = reader.LoadCurrentElement();
                Log.Comment("check if the current element is a misc element");
                Log.VerifyTrue(loaded is OpenXmlMiscNode, "expect OpenXmlMiscNode, Actual{0}", loaded.GetType().Name);

                Read(Xreader);
            }

            return true;
        }

        /// <summary>
        /// Test each Property of OpenXmlReader Class
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="XTreader">the corresponding XmlReader used to verify results</param>
        private void ReaderPropertiesTest(OpenXmlReader reader, XmlReader XTreader, string standalone)
        {
            TestStandaloneXml(reader, XTreader, standalone);
            TestHasAttributes(reader, XTreader);
            TestElementType(reader, XTreader);
            TestIsMiscNode(reader, XTreader);
            TestIsStartElement(reader, XTreader);
            TestIsEndElement(reader, XTreader);
            TestEOF(reader, XTreader);

            TestNameSpaceURI(reader, XTreader);
            TestPrefix(reader, XTreader);
            TestDepth(reader, XTreader);

            TestLocalName(reader, XTreader);
        }

        /// <summary>
        /// Test StandaloneXml of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="XTreader">the corresponding XmlReader</param>
        private void TestStandaloneXml(OpenXmlReader reader, XmlReader XTreader, string standalone)
        {
            Log.Comment("Test Standalone");
            if (!string.IsNullOrEmpty(standalone) && reader.StandaloneXml.HasValue == true)
            {
                Log.VerifyTrue(standalone.Equals(reader.StandaloneXml.Value ? "yes" : "no", StringComparison.OrdinalIgnoreCase), "expect: {0}  actual: {1}", standalone, reader.StandaloneXml);
            }
            else if (string.IsNullOrEmpty(standalone) && reader.StandaloneXml.HasValue == false)
                Log.Pass(" PASS! expect: NULL == actual: NULL");
            else
                Log.Fail("Expect: {0} <> actual: {1}", string.IsNullOrEmpty(standalone) ? "Null" : "Not Null", reader.StandaloneXml.HasValue ? "Not Null" : "Null");
        }

        /// <summary>
        /// test HasAttributes of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="XTreader">the corresponding XmlReader</param>
        private void TestHasAttributes(OpenXmlReader reader, XmlReader XTreader)
        {
            if (reader.Depth > 0)
            {
                Log.Comment("Test HasAttributes");
                Log.VerifyTrue(reader.HasAttributes == XTreader.HasAttributes,
                    "Expect: {0} ({2}) <> actual: {1} ({3})",
                    XTreader.HasAttributes, reader.HasAttributes,
                    XTreader.LocalName, reader.LocalName);
            }
        }

        /// <summary>
        /// test ElementType of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="XTreader">the corresponding XmlReader</param>
        private void TestElementType(OpenXmlReader reader, XmlReader XTreader)
        {
            Log.Comment("Test ElementType");
            Type type = reader.ElementType;

            if (IsMisc(XTreader) || type == typeof(OpenXmlUnknownElement) || type == typeof(OpenXmlMiscNode))
            {
                Log.VerifyTrue(
                    type == typeof(OpenXmlMiscNode) || type == typeof(OpenXmlUnknownElement),
                    "Expect: OpenXmlMiscNode ({0})  actual: {1}",
                    XTreader.NodeType, reader.ElementType);
            }
            else
            {
                Log.VerifyTrue((Activator.CreateInstance(type) as OpenXmlElement).LocalName.Equals(XTreader.LocalName.Replace(XTreader.Prefix + ":", string.Empty), StringComparison.OrdinalIgnoreCase),
                    "Expect: {0} <> actual: {1}", XTreader.LocalName, reader.LocalName);
            }
        }

        /// <summary>
        /// test IsMiscNode of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="XTreader">the corresponding XmlReader</param>
        private void TestIsMiscNode(OpenXmlReader reader, XmlReader XTreader)
        {
            //TODO: What is MiscNode? What is the definition?
            Log.Comment("Test IsMiscNode");
            Log.VerifyTrue(reader.IsMiscNode == IsMisc(XTreader),
                "Expect:{0} ({2}) <> actual: {1} ({3})",
                IsMisc(XTreader), reader.IsMiscNode,
                XTreader.LocalName, reader.LocalName);
        }

        /// <summary>
        /// test IsStartElement of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="XTreader">the corresponding XmlReader</param>
        private void TestIsStartElement(OpenXmlReader reader, XmlReader XTreader)
        {
            Log.Comment("Test IsStartElement");
            if (IsMisc(XTreader))
            {
                Log.VerifyTrue(reader.IsStartElement == false,
                    "Expect: FALSE <> actual: {0}", reader.IsStartElement);
            }
            else
            {
                Log.VerifyTrue(reader.IsStartElement == XTreader.IsStartElement(),
                    "Expect: {0} <> actual: {1}", XTreader.IsStartElement(), reader.IsStartElement);
            }
        }

        /// <summary>
        /// test IsEndElement of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="XTreader">the corresponding XmlReader</param>
        private void TestIsEndElement(OpenXmlReader reader, XmlReader XTreader)
        {
            Log.Comment("Test IsEndElement");
            if (IsMisc(XTreader))
            {
                Log.VerifyTrue(reader.IsEndElement == false,
                    "Expect: FALSE <> actual: {0}", reader.IsStartElement);
            }
            else
            {
                var isEndElement = reader.IsEndElement;
                var xtReaderIsEndElement = XTreader.NodeType == XmlNodeType.EndElement;

                //if (isEndElement != xtReaderIsEndElement)
                //    Console.WriteLine();
                Log.VerifyTrue(isEndElement == xtReaderIsEndElement,
                    "Expect: {0} <> actual: {1}", XTreader.NodeType == XmlNodeType.EndElement, reader.IsEndElement);
            }
        }

        /// <summary>
        /// test EOF of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="XTreader">the corresponding XmlReader</param>
        private void TestEOF(OpenXmlReader reader, XmlReader XTreader)
        {
            Log.Comment("Test EOF");
            Log.VerifyTrue(reader.EOF == XTreader.EOF, "Expect: {0} <> actual: {1}", XTreader.EOF, reader.EOF);
        }

        /// <summary>
        /// test LocalName of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="XTreader">the corresponding XmlReader</param>
        private void TestLocalName(OpenXmlReader reader, XmlReader XTreader)
        {
            string localName = XTreader.LocalName;
            if (IsMisc(XTreader))
            {
                switch (XTreader.NodeType)
                {
                    case XmlNodeType.CDATA:
                        localName = "#cdata-section";
                        break;
                    case XmlNodeType.Comment:
                        localName = "#comment";
                        break;
                    case XmlNodeType.Document:
                        localName = "#document";
                        break;
                    case XmlNodeType.DocumentFragment:
                        localName = "#document-fragment";
                        break;
                    case XmlNodeType.Text:
                        localName = "#text";
                        break;
                    case XmlNodeType.Whitespace:
                        localName = "#whitespace";
                        break;
                    case XmlNodeType.SignificantWhitespace:
                        localName = "#significant-whitespace";
                        break;
                    case XmlNodeType.XmlDeclaration:
                        localName = "#xml-declaration";
                        break;
                    default:
                        break;
                }
            }

            Log.Comment("Test LocalName");
            Log.VerifyTrue(localName.Equals(reader.LocalName, StringComparison.OrdinalIgnoreCase),
                "Expect: {0} <> actual: {1}", localName, reader.LocalName);
        }

        /// <summary>
        /// test NameSpaceURI of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="XTreader">the corresponding XmlReader</param>
        private void TestNameSpaceURI(OpenXmlReader reader, XmlReader XTreader)
        {
            Log.Comment("Test NameSpaceURI");
            Log.VerifyTrue(XTreader.NamespaceURI.Equals(reader.NamespaceUri, StringComparison.OrdinalIgnoreCase),
                "Expect: {0} <> actual: {1}", XTreader.NamespaceURI, reader.NamespaceUri);
        }

        /// <summary>
        /// test Prefix of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="XTreader">the corresponding XmlReader</param>
        private void TestPrefix(OpenXmlReader reader, XmlReader XTreader)
        {
            Log.Comment("Test Prefix");
            Log.VerifyTrue(reader.Prefix.Equals(XTreader.Prefix, StringComparison.OrdinalIgnoreCase),
                "Expect: {0} <> actual: {1}", XTreader.Prefix, reader.Prefix);
        }

        /// <summary>
        /// test Depth of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="XTreader">the corresponding XmlReader</param>
        private void TestDepth(OpenXmlReader reader, XmlReader XTreader)
        {
            Log.Comment("Test Depth");
            Log.VerifyTrue(reader.Depth == XTreader.Depth, "Expect: {0} <> actual: {1}", XTreader.Depth, reader.Depth);
        }

        /// <summary>
        /// Test OpenXmlReader GetText() method, and verify the result with XmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader that will be tested</param>
        /// <param name="XTreader">the corresponding XmlReader used to verify the result</param>
        private void TestGetText(OpenXmlReader reader, XmlReader Xreader)
        {
            Log.Comment("Test GetText()");

            if (!reader.EOF &&
                reader.ElementType != typeof(OpenXmlMiscNode) &&
                reader.ElementType != typeof(OpenXmlUnknownElement) &&
                Activator.CreateInstance(reader.ElementType) is OpenXmlLeafTextElement)
            {
                string Text = reader.GetText();
                Log.VerifyTrue(Xreader.ReadContentAsString() == Text, "expected: '{0}' <> actual: '{1}'", Xreader.Value, Text);

                Read(reader);
            }
            else
            {
                string Text = reader.GetText();
                Assert.Equal(string.Empty, Text);
            }
        }

        /// <summary>
        /// Check if the pass-in XmlReader is pointing to a Misc Node
        /// </summary>
        /// <param name="XTreader">the XmlReader to be tested</param>
        /// <returns>TRUE, if the current node is a misc node. FALSE, if not</returns>
        private static bool IsMisc(XmlReader XTreader)
        {
            //what? End element is not element.
            return XTreader.NodeType != XmlNodeType.Element &&
                XTreader.NodeType != XmlNodeType.Attribute &&
                XTreader.NodeType != XmlNodeType.EndElement &&
                XTreader.NodeType != XmlNodeType.Text;
        }

        /// <summary>
        /// Call OpenXmlReader Read() method, and move the corresponding XmlReader to
        /// the match point as the OpenXmlReader according to the Read algorithm
        /// </summary>
        /// <param name="Oreader">Oreader to be called</param>
        /// <param name="Treader">XmlReader that keeps synchronous with Oreader</param>
        /// <returns>TRUE, if the Read success. FALSE, if not</returns>
        private bool Read(OpenXmlReader Oreader, XmlReader Treader)
        {
            // TODO:EndElement logic. Misc catch logic.
            bool IscontinueRead = true;
            Log.Comment("Read(OpenXmlReader, XmlReader)");

            bool beforeIsStartElement = Oreader.IsStartElement;
            bool IsOreadSuccessful = Read(Oreader);
            bool afterIsEndElement = false;

            if (!IsOreadSuccessful)
            {
                Log.Comment("check if the pointer is on the end root element, or EOF");
                Log.VerifyTrue(Treader.EOF || Treader.NodeType == XmlNodeType.EndElement, "It's not either on EOF, nor end root element");
                return false;
            }
            else if (Oreader.EOF == false)
            {
                afterIsEndElement = Oreader.IsEndElement;
            }
            else
            {
                return false;
            }

            if (Treader.IsEmptyElement == false || !(beforeIsStartElement == true && afterIsEndElement == true))
            {
                while (IscontinueRead && Read(Treader))
                {
                    switch (Treader.NodeType)
                    {
                        case XmlNodeType.Attribute:
                        //case XmlNodeType.Document:
                        case XmlNodeType.Text:
                        case XmlNodeType.Element:
                        case XmlNodeType.EndElement:
                            IscontinueRead = false;
                            break;
                        case XmlNodeType.SignificantWhitespace:
                        case XmlNodeType.Whitespace:
                            IscontinueRead = true;
                            break;
                        default:
                            if (Oreader.ReadMiscNodes)
                                IscontinueRead = false;
                            else
                                IscontinueRead = true;
                            break;
                    }
                }

                if (!IsOreadSuccessful)
                {
                    Log.Comment("check if the Read returns correctly");
                    Log.VerifyTrue(Oreader.EOF, "Expect: TRUE <> Actual: False");
                    Log.Comment("check if the OpenXmlRead matchs XmlReader");
                    Log.VerifyTrue(Treader.EOF, "Expect: TRUE <> Actual: False");
                }
            }

            TestGetText(Oreader, Treader);

            return IsOreadSuccessful;
        }

        /// <summary>
        /// Call OpenXmlReader ReadFirstChild() method, and move the corresponding XmlReader to
        /// the match point as the OpenXmlReader according to the Read algorithm. If ReadFirstChild
        /// return false, the next element will be read instead.
        /// </summary>
        /// <param name="Oreader">Oreader to be called</param>
        /// <param name="Treader">XmlReader that keeps synchronous with Oreader</param>
        /// <returns>TRUE, if the ReadFirstChild success. FALSE, if not</returns>
        private bool ReadFirstChildOrMoveToNext(OpenXmlReader Oreader, XmlReader Treader)
        {
            Log.Comment("ReadFirstChild()");

            if (Treader.EOF || IsMisc(Treader) || Treader.NodeType == XmlNodeType.EndElement || Oreader.IsEndElement)
            {
                Log.VerifyFalse(Oreader.ReadFirstChild(), "ReadFirstChild on EOF, expect: False Actual: True");
                Read(Oreader, Treader);
                return false;
            }
            else if (Treader.IsStartElement())
            {
                bool IsStart = Oreader.IsStartElement;
                bool IsOreadSuccessful = Oreader.ReadFirstChild();
                bool skip = (IsStart == true) && (Oreader.IsStartElement == false);

                if (IsOreadSuccessful)
                {
                    if (Oreader.ReadMiscNodes)
                    {
                        Read(Treader);
                    }
                    else
                    {
                        while (Read(Treader) && IsMisc(Treader))
                        {
                        }
                    }

                    return true;
                }
                else
                {
                    if (!(Treader.IsEmptyElement && Oreader.IsEndElement && skip))
                    {
                        while (Read(Treader) && Treader.NodeType != XmlNodeType.EndElement)
                        {
                        }
                    }

                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Call OpenXmlReader ReadNextSibling() method, and move the corresponding XmlReader to
        /// the match point as the OpenXmlReader according to the Read algorithm.
        /// </summary>
        /// <param name="Oreader">Oreader to be called</param>
        /// <param name="Treader">XmlReader that keeps synchronous with Oreader</param>
        /// <returns>TRUE, if the ReadFirstChild success. FALSE, if not</returns>
        private bool ReadNextSibling(OpenXmlReader Oreader, XmlReader Treader)
        {
            Log.Comment("ReadNextSibling()");
            bool OfoundNextSibling = Oreader.ReadNextSibling();

            bool foundNextSibling = false;
            int oldDepth = Treader.Depth;

            if (Treader.EOF)
            {
                foundNextSibling = false;
            }
            else if (Treader.Depth == 0)
            {
                while (!Treader.EOF && Read(Treader))
                {
                }

                foundNextSibling = false;
            }
            else if (Oreader.ReadMiscNodes && IsMisc(Treader))
            {
                Read(Treader);
                if (Treader.NodeType != XmlNodeType.EndElement)
                    foundNextSibling = true;
                else
                    foundNextSibling = false;
            }
            else if (Treader.NodeType == XmlNodeType.EndElement)
            {
                if (Oreader.ReadMiscNodes)
                    Read(Treader);
                else
                {
                    while (Read(Treader) && (IsMisc(Treader) || Treader.Depth > oldDepth))
                    {
                    }
                }

                if (Treader.Depth == oldDepth && Treader.NodeType != XmlNodeType.EndElement)
                    foundNextSibling = true;
                else
                    foundNextSibling = false;
            }
            else if (Treader.IsStartElement())
            {
                while (!(Treader.NodeType == XmlNodeType.EndElement && Treader.Depth == oldDepth))
                    Read(Treader);

                Read(Treader);

                if (!Oreader.ReadMiscNodes)
                {
                    if (IsMisc(Treader))
                        while (IsMisc(Treader))
                            Read(Treader);
                }

                if (Treader.Depth == oldDepth && (Treader.NodeType != XmlNodeType.EndElement))
                    foundNextSibling = true;
                else if ((Treader.Depth == oldDepth + 1 && Treader.NodeType == XmlNodeType.EndElement) || Treader.EOF)
                    foundNextSibling = false;
            }

            Log.Comment("check if the ReadNextSibling() results matches with XmlReader");
            Log.VerifyTrue(OfoundNextSibling == foundNextSibling, "OpenXmlReader and XmlReader don't match");

            return OfoundNextSibling;
        }

        /// <summary>
        /// Call OpenXmlReader Skip() method, and move the corresponding XmlReader to
        /// the match point as the OpenXmlReader according to the Read algorithm.
        /// </summary>
        /// <param name="Oreader">Oreader to be called<</param>
        /// <param name="Treader">XmlReader that keeps synchronous with Oreader</param>
        /// <returns>Always return TRUE</returns>
        private bool Skip(OpenXmlReader Oreader, XmlReader Treader)
        {
            Log.Comment("Skip()");
            Skip(Oreader);
            Skip(Treader);
            if (!Oreader.ReadMiscNodes)
            {
                while (IsMisc(Treader) && !Treader.EOF)
                    Read(Treader);
            }

            return true;
        }

        private static bool Read(OpenXmlReader reader)
        {
            bool result = false;

            if (reader != null && reader.EOF == false)
            {
                result = reader.Read();

                if (IGNORE_WHITESPACE_SETTING == false)
                {
                    result = SkipWhitespace(reader);
                }

                if (reader != null && reader.EOF == false)
                {
                    System.Diagnostics.Debug.WriteLine("O: [{0}] {1}", reader.ElementType, reader.LocalName);
                }
            }

            return result;
        }

        private static bool Read(XmlReader reader)
        {
            bool result = false;

            if (reader != null && reader.EOF == false)
            {
                result = reader.Read();

                if (IGNORE_WHITESPACE_SETTING == false)
                    result = SkipWhitespace(reader);

                if (reader != null && reader.EOF == false)
                    System.Diagnostics.Debug.WriteLine("X: [{0}] {1}", reader.NodeType, reader.LocalName);
            }

            return result;
        }

        private static bool Skip(OpenXmlReader reader)
        {
            bool result = true;

            if (reader != null && reader.EOF == false)
            {
                reader.Skip();

                if (IGNORE_WHITESPACE_SETTING == false)
                    result = SkipWhitespace(reader);
            }

            return result;
        }

        private static bool Skip(XmlReader reader)
        {
            bool result = true;

            if (reader != null && reader.EOF == false)
            {
                reader.Skip();

                if (IGNORE_WHITESPACE_SETTING == false)
                    result = SkipWhitespace(reader);
            }

            return result;
        }

        private static bool SkipWhitespace(OpenXmlReader reader)
        {
            bool result = true;

            while (result == true &&
                reader != null && reader.EOF == false &&
                reader.LocalName == "#whitespace")
            {
                result = reader.Read();
            }

            return result;
        }

        private static bool SkipWhitespace(XmlReader reader)
        {
            bool result = true;

            while (result == true &&
                reader != null && reader.EOF == false &&
                reader.NodeType == XmlNodeType.Whitespace)
            {
                result = reader.Read();
            }

            return result;
        }
        #endregion

        [Fact]
        public void bug247883()
        {
            using (var stream0 = TestAssets.GetStream(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd, true))
            using (var stream1 = TestAssets.GetStream(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AutoSpaceDE, true))
            using (var word0 = WordprocessingDocument.Open(stream0, true))
            using (var word1 = WordprocessingDocument.Open(stream1, true))
            {
                var doc = word0.MainDocumentPart.Document;
                doc.Load(word1.MainDocumentPart);
                doc.Save();
            }
        }

        [Fact]
        public void ReadMiscNode()
        {
            Body body = new Body(new Paragraph(new ParagraphProperties(), new Run(new Text("test"))));
            body.PrependChild(new OpenXmlMiscNode(XmlNodeType.Comment, "<!-- start body -->"));

            using (var reader = OpenXmlReader.Create(body, true))
            {
                Assert.True(reader.Read());
                Assert.True(reader.Read());
                Assert.True(reader.IsMiscNode);
            }
        }

        [Fact]
        public void ObjectDisposedThrowsOnReaderDispose()
        {
            var partreader = OpenXmlReader.Create(new Document(), false);
            partreader.Dispose();
            Assert.Throws<ObjectDisposedException>(() => partreader.ReadMiscNodes);
        }

        [Fact]
        public void Bug253893_Write2Declaration()
        {
            using (var stream = new MemoryStream())
            using (WordprocessingDocument doc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainpart = doc.AddMainDocumentPart();

                OpenXmlWriter writer = OpenXmlWriter.Create(mainpart);

                OpenXmlMiscNode miscnode = new OpenXmlMiscNode(XmlNodeType.XmlDeclaration, "<?xml version=\"1.0\" encoding=\"utf-8\"?>");

                writer.WriteStartDocument();

                writer.WriteElement(miscnode);

                writer.Close();
            }
        }
    }
}
