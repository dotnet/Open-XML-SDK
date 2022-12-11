// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
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
        private const bool IgnoreWhitespaceSetting = true;

        #region Reader Test ...

        #region ReaderConstruction ...

        private ConstrReader partConstrWithNoMisc = (WordprocessingDocument x, out OpenXmlReader y, out XmlReader z) =>
        {
            y = OpenXmlReader.Create(x.MainDocumentPart);
            z = XmlReader.Create(x.MainDocumentPart.GetStream());
        };

        private ConstrReader partConstrWithMisc = (WordprocessingDocument x, out OpenXmlReader y, out XmlReader z) =>
        {
            y = OpenXmlReader.Create(x.MainDocumentPart, true);
            z = XmlReader.Create(x.MainDocumentPart.GetStream());
        };

        private ConstrReader domConstrWithNoMisc = (WordprocessingDocument x, out OpenXmlReader y, out XmlReader z) =>
        {
            var firstChild = x.MainDocumentPart.Document.FirstChild;
            y = OpenXmlDomReader.Create(firstChild);

            var xfirstChild = ConvertToXElement(x.MainDocumentPart, firstChild);
            z = XmlReader.Create(new StringReader(firstChild.OuterXml));
        };

        private ConstrReader domConstrWithMisc = (WordprocessingDocument x, out OpenXmlReader y, out XmlReader z) =>
        {
            var firstChild = x.MainDocumentPart.Document.FirstChild;
            y = new OpenXmlDomReader(firstChild, true);

            var xfirstChild = ConvertToXElement(x.MainDocumentPart, firstChild);
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
                {
                    while (Read(y) && IsMisc(y))
                    {
                    }
                }
                else
                {
                    Read(y);
                }
            }
        };

        #endregion

        #endregion

        #region Writer Test ...

        [Fact]
        public void WriteStartDocumentTest()
        {
            TestWriteStartDocument(wConstrWithPart, WriteStartD, null);
        }

        [Fact]
        public void WriteStartDocumentWithStandalone()
        {
            TestWriteStartDocument(wConstrWithPartEnc, WriteStartD, true);
        }

        [Fact]
        public void WriteStartDocumentMultiple()
        {
            using var stream = new MemoryStream();
            using var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            var part = newDoc.AddMainDocumentPart();

            using var writer = pWCosntrWithPart(part);
            writer.WriteStartDocument();
            Assert.Throws<InvalidOperationException>(() => writer.WriteStartDocument());
        }

        [Fact]
        public void WriteStartDocumentOtherPlace()
        {
            using var stream = new MemoryStream();
            using var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            var part = newDoc.AddMainDocumentPart();
            var p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };

            using var writer = pWCosntrWithPart(part);
            writer.WriteElement(p);
            Assert.Throws<InvalidOperationException>(() => writer.WriteStartDocument());
        }

        [Fact]
        public void WriteStartElementWithOpenXmlReaderAttr()
        {
            var p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };

            using var reader = OpenXmlReader.Create(p);
            reader.Read();

            TestWriteStartElement(wConstrWithStream, WriteStartE, reader, GetTestAttributes(), null);
        }

        [Fact]
        public void WriteStartElementWithOpenXmlReader()
        {
            var p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };

            using var reader = OpenXmlReader.Create(p);
            reader.Read();

            TestWriteStartElement(wConstrWithStream, WriteStartE, reader, null, null);
        }

        [Fact]
        public void WriteStartElementWithEndElementReader()
        {
            var p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };

            using var reader = OpenXmlReader.Create(p);
            reader.Read();
            reader.LoadCurrentElement();

            Assert.Throws<ArgumentOutOfRangeException>(() => TestWriteStartElement(wConstrWithStream, WriteStartE, reader, null, null));
        }

        [Fact]
        public void WriteStartElementWithOpenXmlElementAttr()
        {
            var p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };

            TestWriteStartElement(wConstrWithStream, WriteStartE, p, GetTestAttributes(), null);
        }

        [Fact]
        public void WriteStartElementWithOpenXmlElement()
        {
            var p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };

            TestWriteStartElement(wConstrWithStream, WriteStartE, p, null, null);
        }

        [Fact]
        public void WriteStringAndEndElement()
        {
            using var stream = new MemoryStream();
            using var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            var t = new Text();
            var part = newDoc.AddMainDocumentPart();

            using (var writer = wConstrWithPart(part))
            {
                writer.WriteStartElement(t);
                writer.WriteString("test");
                writer.WriteEndElement();
            }

            using var reader = XmlReader.Create(part.GetStream());
            Assert.True(reader.Read());
            Assert.True(reader.Read());
            Assert.True(reader.Read());
            Assert.Equal("test", reader.Value);

            Assert.True(reader.Read());
            Assert.Equal(XmlNodeType.EndElement, reader.NodeType);
            Assert.Equal(t.LocalName, reader.LocalName);
        }

        [Fact]
        public void WriteEndElementWithoutStart()
        {
            using var stream = new MemoryStream();
            using var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            var t = new Text();
            var part = newDoc.AddMainDocumentPart();

            using var writer = wConstrWithPart(part);
            Assert.Throws<InvalidOperationException>(() => writer.WriteEndElement());
        }

        // Comment out as the result of bug 2352836
        [Fact]
        public void WriteStringWithNonLeafText()
        {
            using var stream = new MemoryStream();
            using var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            var p = new Paragraph() { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };
            var part = newDoc.AddMainDocumentPart();

            using var writer = wConstrWithPart(part);
            writer.WriteStartElement(p);
            Assert.Throws<InvalidOperationException>(() => writer.WriteString("test"));
        }

        [Fact]
        public void WriteElement()
        {
            using var stream = new MemoryStream();
            using var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            var p = new Paragraph(new Run(new Text("test"))) { RsidParagraphAddition = "00000000", RsidRunAdditionDefault = "00B27B3B" };
            var part = newDoc.AddMainDocumentPart();
            var writer = wConstrWithPart(part);

            writer.WriteElement(p);
            writer.Close();

            XElement xEle = null;
            using (var partStream = part.GetStream())
            using (var reader = XmlReader.Create(partStream))
            {
                xEle = XElement.Load(reader);
            }

            VerifyEqual(xEle, p, part);
        }

        [Fact]
        public void WriteStartElementWithMisc()
        {
            var node = new OpenXmlMiscNode(XmlNodeType.Comment);
            using var miscReader = OpenXmlReader.Create(node, true);
            Assert.True(miscReader.Read());
            Assert.Throws<ArgumentOutOfRangeException>(() => TestWriteStartElement(wConstrWithStream, WriteStartE, miscReader, null, null));
        }

        private void TestWriteStartDocument(ConstrWriter writerConstr, WriteStartDoc write, bool? standalone)
        {
            using var stream = new MemoryStream();
            using var newDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            var part = newDoc.AddMainDocumentPart();

            using (var writer = writerConstr(part))
            {
                write(writer, standalone);
            }

            VerifyDocumentStart(part, standalone);
        }

        private void VerifyDocumentStart(OpenXmlPart part, bool? standalone)
        {
            var reader = XmlReader.Create(part.GetStream());
            reader.Read();

            Log.Comment("verify the part contains XmlDeclaration");
            Log.VerifyTrue(reader.NodeType == XmlNodeType.XmlDeclaration, "expected: XmlDeclaration <> actual: {0}", reader.NodeType);
            Log.Comment("verify the version is 1.0");
            Log.VerifyTrue(reader.GetAttribute("version") == "1.0", "expected: 1.0 <> actual:{0}", reader.GetAttribute("version"));

            var standaloneValue = reader.GetAttribute("standalone");

            if (standalone.HasValue)
            {
                Log.Comment("verify if the standalone is set correctly");
                Log.VerifyTrue(
                    standaloneValue.Equals(standalone.Value == true ? "yes" : "no", StringComparison.OrdinalIgnoreCase),
                    "expected: {0} <> actual: {1}", standalone.Value == true ? "yes" : "no", standaloneValue);
            }
            else
            {
                Log.Comment("verify the standalone is not presented");
                Log.VerifyTrue(standaloneValue is null, "expected: null <> actual: {0}", standaloneValue);
            }
        }

        private void WriteStartD(OpenXmlWriter writer, bool? standalone)
        {
            if (standalone.HasValue)
            {
                writer.WriteStartDocument(standalone.Value);
            }
            else
            {
                writer.WriteStartDocument();
            }
        }

        private void WriteStartE(OpenXmlWriter writer, object writeSource, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
        {
            if (writeSource is OpenXmlReader && attributes is null)
            {
                writer.WriteStartElement(writeSource as OpenXmlReader);
            }
            else if (writeSource is OpenXmlReader && attributes is not null && namespaceDeclarations is null)
            {
                writer.WriteStartElement(writeSource as OpenXmlReader, attributes);
            }
            else if (writeSource is OpenXmlReader && attributes is not null && namespaceDeclarations is not null)
            {
                writer.WriteStartElement(writeSource as OpenXmlReader, attributes, namespaceDeclarations);
            }
            else if (writeSource is OpenXmlElement && attributes is null)
            {
                writer.WriteStartElement(writeSource as OpenXmlElement);
            }
            else if (writeSource is OpenXmlElement && attributes is not null && namespaceDeclarations is null)
            {
                writer.WriteStartElement(writeSource as OpenXmlElement, attributes);
            }
            else if (writeSource is OpenXmlElement && attributes is not null && namespaceDeclarations is not null)
            {
                writer.WriteStartElement(writeSource as OpenXmlElement, attributes);
            }
        }

        private void TestWriteStartElement(ConstrWriter writerConstr, WriteStartEle write, object writeSource, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
        {
            using var ms = new MemoryStream();
            using var newDoc = WordprocessingDocument.Create(ms, WordprocessingDocumentType.Document);
            var part = newDoc.AddMainDocumentPart();

            using (var stream = part.GetStream())
            using (var writer = OpenXmlWriter.Create(stream))
            {
                write(writer, writeSource, attributes, namespaceDeclarations);
            }

            VerifyStartElement(part, writeSource, attributes, namespaceDeclarations);
        }

        private IEnumerable<OpenXmlAttribute> GetTestAttributes()
        {
            for (var i = 0; i < 5; i++)
            {
                yield return new OpenXmlAttribute("c", "test" + i, string.Empty, i.ToString());
            }
        }

        private void VerifyStartElement(OpenXmlPart part, object writeSource, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
        {
            using var stream = part.GetStream();
            using var xmlReader = XmlReader.Create(stream);
            xmlReader.Read();
            xmlReader.Read();

            Log.Comment("the element written out is a start element");
            Log.VerifyTrue(xmlReader.IsStartElement(), "Expected: True <> Actual: False");

            if (writeSource is OpenXmlReader)
            {
                var oReader = writeSource as OpenXmlReader;
                Log.VerifyTrue(xmlReader.LocalName == oReader.LocalName, "expected: {0} <> actual: {1}", oReader.LocalName, xmlReader.LocalName);

                if (attributes is not null)
                {
                    foreach (var attr in attributes)
                    {
                        Log.VerifyTrue(attr.Value == xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri), "expected: {0} <> actual: {1}", attr.Value, xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri));
                    }
                }
                else
                {
                    foreach (var attr in oReader.Attributes)
                    {
                        Log.VerifyTrue(attr.Value == xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri), "expected: {0} <> actual: {1}", attr.Value, xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri));
                    }
                }

                if (namespaceDeclarations is not null)
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
                var element = writeSource as OpenXmlElement;

                Log.VerifyTrue(xmlReader.LocalName == element.LocalName, "expected: {0} <> actual: {1}", element.LocalName, xmlReader.LocalName);

                if (attributes is not null)
                {
                    foreach (var attr in attributes)
                    {
                        Log.VerifyTrue(attr.Value == xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri), "expected: {0} <> actual: {1}", attr.Value, xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri));
                    }
                }
                else
                {
                    foreach (var attr in element.GetAttributes())
                    {
                        Log.VerifyTrue(attr.Value == xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri), "expected: {0} <> actual: {1}", attr.Value, xmlReader.GetAttribute(attr.LocalName, attr.NamespaceUri));
                    }
                }

                if (namespaceDeclarations is not null)
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

        #region Writer Construction ...

        private ConstrWriter wConstrWithPart = x => OpenXmlWriter.Create(x);

        private ConstrWriter wConstrWithPartEnc = x => OpenXmlWriter.Create(x, Encoding.UTF8);

        private ConstrWriter wConstrWithStream = x => OpenXmlWriter.Create(x.GetStream());

        private ConstrWriter wConstrWithStreamEnc = x => OpenXmlWriter.Create(x.GetStream(), Encoding.UTF8);

        private ConstrWriter pWCosntrWithPart = x => new OpenXmlPartWriter(x);

        private ConstrWriter pWConstrWithPartEnc = x => new OpenXmlPartWriter(x, Encoding.UTF8);

        private ConstrWriter pWConstrWithStream = x => new OpenXmlPartWriter(x.GetStream());

        private ConstrWriter pWConstrWithStreamEnc = x => new OpenXmlPartWriter(x.GetStream(), Encoding.UTF8);

        #endregion

        #endregion

        #region Help Methods ...

        private delegate bool Reading(OpenXmlReader oreader, XmlReader xreader);

        private delegate void PreRead(OpenXmlReader oreader, XmlReader xreader, out string standalone);

        private delegate void ConstrReader(WordprocessingDocument doc, out OpenXmlReader oreader, out XmlReader treader);

        private delegate OpenXmlWriter ConstrWriter(OpenXmlPart part);

        private delegate void WriteStartDoc(OpenXmlWriter writer, bool? standalone);

        private delegate void WriteStartEle(OpenXmlWriter writer, object writeSource, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations);

        /// <summary>
        /// Call OpenXmlReader LoadCurrentElement() method, and move the corresponding XmlReader to
        /// the match point as the OpenXmlReader according to the Read algorithm.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="xreader"></param>
        /// <returns></returns>
        private bool LoadCurrentElement(OpenXmlReader reader, XmlReader xreader)
        {
            Log.Comment("LoadCurrentElement()");
            if (reader.IsEndElement || xreader.EOF)
            {
                try
                {
                    Log.Comment("Load current element from an EndElement or EOF, expect InvalidOperationException");
                    var element = reader.LoadCurrentElement();
                    Log.VerifyShouldNotReachHere("Expect InvalidOperationException");
                }
                catch (InvalidOperationException)
                {
                    Log.Pass("Expected InvalidOperationException is thrown");
                    Read(reader, xreader);
                }
            }
            else if (reader.IsStartElement)
            {
                var isStart = reader.IsStartElement;
                var element = reader.LoadCurrentElement();
                var skip = (isStart == true) && (reader.IsStartElement == false);

                Log.Comment("check if the load is successful");
                Log.VerifyNotNull(element, "Fail to load OpenXmlElement from OpenXmlReader");
                Log.VerifyTrue(
                    element.LocalName.Equals(
                    xreader.Name.Replace(xreader.Prefix + ":", string.Empty),
                    StringComparison.OrdinalIgnoreCase), "LocalName test FAIL. Expected: {0} <> Actual: {1}",
                    xreader.Name.Replace(xreader.Prefix + ":", string.Empty), element.LocalName);
                if (!(reader is OpenXmlDomReader))
                {
                    Log.VerifyTrue(element.HasAttributes == xreader.HasAttributes, "HasAttributes test FAIL. Expected: {0} <> Actual: {1}",
                              xreader.HasAttributes, element.HasAttributes);
                    Log.VerifyTrue(element.GetAttributes().Count == xreader.AttributeCount, "Attribute Count test FAIL.  Expected: {0} <> Actual: {1}",
                        xreader.AttributeCount, element.GetAttributes().Count);
                }

                if (reader.ReadMiscNodes)
                {
                    if (IsMisc(xreader))
                    {
                        Read(xreader);
                    }
                    else
                    {
                        if (!(xreader.IsEmptyElement && reader.IsEndElement && skip))
                        {
                            var oldDepth = xreader.Depth;
                            while (Read(xreader) && !(xreader.NodeType == XmlNodeType.EndElement && xreader.Depth <= oldDepth))
                            {
                            }
                        }
                    }
                }
                else
                {
                    if (!(xreader.IsEmptyElement && reader.IsEndElement && skip))
                    {
                        var oldDepth = xreader.Depth;
                        while (Read(xreader) && !(xreader.NodeType == XmlNodeType.EndElement && xreader.Depth <= oldDepth))
                        {
                        }
                    }
                }
            }
            else if (reader.ReadMiscNodes && IsMisc(xreader))
            {
                var loaded = reader.LoadCurrentElement();
                Log.Comment("check if the current element is a misc element");
                Log.VerifyTrue(loaded is OpenXmlMiscNode, "expect OpenXmlMiscNode, Actual{0}", loaded.GetType().Name);

                Read(xreader);
            }

            return true;
        }

        /// <summary>
        /// Test each Property of OpenXmlReader Class
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="xTreader">the corresponding XmlReader used to verify results</param>
        private void ReaderPropertiesTest(OpenXmlReader reader, XmlReader xTreader, string standalone)
        {
            TestStandaloneXml(reader, xTreader, standalone);
            TestHasAttributes(reader, xTreader);
            TestElementType(reader, xTreader);
            TestIsMiscNode(reader, xTreader);
            TestIsStartElement(reader, xTreader);
            TestIsEndElement(reader, xTreader);
            TestEOF(reader, xTreader);

            TestNameSpaceURI(reader, xTreader);
            TestPrefix(reader, xTreader);
            TestDepth(reader, xTreader);

            TestLocalName(reader, xTreader);
        }

        /// <summary>
        /// Test StandaloneXml of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="xTreader">the corresponding XmlReader</param>
        private void TestStandaloneXml(OpenXmlReader reader, XmlReader xTreader, string standalone)
        {
            Log.Comment("Test Standalone");
            if (!string.IsNullOrEmpty(standalone) && reader.StandaloneXml.HasValue == true)
            {
                Log.VerifyTrue(standalone.Equals(reader.StandaloneXml.Value ? "yes" : "no", StringComparison.OrdinalIgnoreCase), "expect: {0}  actual: {1}", standalone, reader.StandaloneXml);
            }
            else if (string.IsNullOrEmpty(standalone) && reader.StandaloneXml.HasValue == false)
            {
                Log.Pass(" PASS! expect: NULL == actual: NULL");
            }
            else
            {
                Log.Fail("Expect: {0} <> actual: {1}", string.IsNullOrEmpty(standalone) ? "Null" : "Not Null", reader.StandaloneXml.HasValue ? "Not Null" : "Null");
            }
        }

        /// <summary>
        /// test HasAttributes of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="xTreader">the corresponding XmlReader</param>
        private void TestHasAttributes(OpenXmlReader reader, XmlReader xTreader)
        {
            if (reader.Depth > 0)
            {
                Log.Comment("Test HasAttributes");
                Log.VerifyTrue(
                    reader.HasAttributes == xTreader.HasAttributes,
                    "Expect: {0} ({2}) <> actual: {1} ({3})",
                    xTreader.HasAttributes, reader.HasAttributes,
                    xTreader.LocalName, reader.LocalName);
            }
        }

        /// <summary>
        /// test ElementType of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="xTreader">the corresponding XmlReader</param>
        private void TestElementType(OpenXmlReader reader, XmlReader xTreader)
        {
            Log.Comment("Test ElementType");
            var type = reader.ElementType;

            if (IsMisc(xTreader) || type == typeof(OpenXmlUnknownElement) || type == typeof(OpenXmlMiscNode))
            {
                Log.VerifyTrue(
                    type == typeof(OpenXmlMiscNode) || type == typeof(OpenXmlUnknownElement),
                    "Expect: OpenXmlMiscNode ({0})  actual: {1}",
                    xTreader.NodeType, reader.ElementType);
            }
            else
            {
                Log.VerifyTrue(
                    (Activator.CreateInstance(type) as OpenXmlElement).LocalName.Equals(xTreader.LocalName.Replace(xTreader.Prefix + ":", string.Empty), StringComparison.OrdinalIgnoreCase),
                    "Expect: {0} <> actual: {1}", xTreader.LocalName, reader.LocalName);
            }
        }

        /// <summary>
        /// test IsMiscNode of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="xTreader">the corresponding XmlReader</param>
        private void TestIsMiscNode(OpenXmlReader reader, XmlReader xTreader)
        {
            // TODO: What is MiscNode? What is the definition?
            Log.Comment("Test IsMiscNode");
            Log.VerifyTrue(
                reader.IsMiscNode == IsMisc(xTreader),
                "Expect:{0} ({2}) <> actual: {1} ({3})",
                IsMisc(xTreader), reader.IsMiscNode,
                xTreader.LocalName, reader.LocalName);
        }

        /// <summary>
        /// test IsStartElement of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="xTreader">the corresponding XmlReader</param>
        private void TestIsStartElement(OpenXmlReader reader, XmlReader xTreader)
        {
            Log.Comment("Test IsStartElement");
            if (IsMisc(xTreader))
            {
                Log.VerifyTrue(
                    reader.IsStartElement == false,
                    "Expect: FALSE <> actual: {0}", reader.IsStartElement);
            }
            else
            {
                Log.VerifyTrue(
                    reader.IsStartElement == xTreader.IsStartElement(),
                    "Expect: {0} <> actual: {1}", xTreader.IsStartElement(), reader.IsStartElement);
            }
        }

        /// <summary>
        /// test IsEndElement of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="xTreader">the corresponding XmlReader</param>
        private void TestIsEndElement(OpenXmlReader reader, XmlReader xTreader)
        {
            Log.Comment("Test IsEndElement");
            if (IsMisc(xTreader))
            {
                Log.VerifyTrue(
                    reader.IsEndElement == false,
                    "Expect: FALSE <> actual: {0}", reader.IsStartElement);
            }
            else
            {
                var isEndElement = reader.IsEndElement;
                var xtReaderIsEndElement = xTreader.NodeType == XmlNodeType.EndElement;

                // if (isEndElement != xtReaderIsEndElement)
                //    Console.WriteLine();
                Log.VerifyTrue(
                    isEndElement == xtReaderIsEndElement,
                    "Expect: {0} <> actual: {1}", xTreader.NodeType == XmlNodeType.EndElement, reader.IsEndElement);
            }
        }

        /// <summary>
        /// test EOF of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="xTreader">the corresponding XmlReader</param>
        private void TestEOF(OpenXmlReader reader, XmlReader xTreader)
        {
            Log.Comment("Test EOF");
            Log.VerifyTrue(reader.EOF == xTreader.EOF, "Expect: {0} <> actual: {1}", xTreader.EOF, reader.EOF);
        }

        /// <summary>
        /// test LocalName of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="xTreader">the corresponding XmlReader</param>
        private void TestLocalName(OpenXmlReader reader, XmlReader xTreader)
        {
            var localName = xTreader.LocalName;
            if (IsMisc(xTreader))
            {
                switch (xTreader.NodeType)
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
            Log.VerifyTrue(
                localName.Equals(reader.LocalName, StringComparison.OrdinalIgnoreCase),
                "Expect: {0} <> actual: {1}", localName, reader.LocalName);
        }

        /// <summary>
        /// test NameSpaceURI of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="xTreader">the corresponding XmlReader</param>
        private void TestNameSpaceURI(OpenXmlReader reader, XmlReader xTreader)
        {
            Log.Comment("Test NameSpaceURI");
            Log.VerifyTrue(
                xTreader.NamespaceURI.Equals(reader.NamespaceUri, StringComparison.OrdinalIgnoreCase),
                "Expect: {0} <> actual: {1}", xTreader.NamespaceURI, reader.NamespaceUri);
        }

        /// <summary>
        /// test Prefix of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="xTreader">the corresponding XmlReader</param>
        private void TestPrefix(OpenXmlReader reader, XmlReader xTreader)
        {
            Log.Comment("Test Prefix");
            Log.VerifyTrue(
                reader.Prefix.Equals(xTreader.Prefix, StringComparison.OrdinalIgnoreCase),
                "Expect: {0} <> actual: {1}", xTreader.Prefix, reader.Prefix);
        }

        /// <summary>
        /// test Depth of the OpenXmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader to be tested</param>
        /// <param name="xTreader">the corresponding XmlReader</param>
        private void TestDepth(OpenXmlReader reader, XmlReader xTreader)
        {
            Log.Comment("Test Depth");
            Log.VerifyTrue(reader.Depth == xTreader.Depth, "Expect: {0} <> actual: {1}", xTreader.Depth, reader.Depth);
        }

        /// <summary>
        /// Test OpenXmlReader GetText() method, and verify the result with XmlReader
        /// </summary>
        /// <param name="reader">the OpenXmlReader that will be tested</param>
        /// <param name="XTreader">the corresponding XmlReader used to verify the result</param>
        private void TestGetText(OpenXmlReader reader, XmlReader xreader)
        {
            Log.Comment("Test GetText()");

            if (!reader.EOF &&
                reader.ElementType != typeof(OpenXmlMiscNode) &&
                reader.ElementType != typeof(OpenXmlUnknownElement) &&
                Activator.CreateInstance(reader.ElementType) is OpenXmlLeafTextElement)
            {
                var text = reader.GetText();
                Log.VerifyTrue(xreader.ReadContentAsString() == text, "expected: '{0}' <> actual: '{1}'", xreader.Value, text);

                Read(reader);
            }
            else
            {
                var text = reader.GetText();
                Assert.Equal(string.Empty, text);
            }
        }

        /// <summary>
        /// Check if the pass-in XmlReader is pointing to a Misc Node
        /// </summary>
        /// <param name="xTreader">the XmlReader to be tested</param>
        /// <returns>TRUE, if the current node is a misc node. FALSE, if not</returns>
        private static bool IsMisc(XmlReader xTreader)
        {
            // what? End element is not element.
            return xTreader.NodeType != XmlNodeType.Element &&
                xTreader.NodeType != XmlNodeType.Attribute &&
                xTreader.NodeType != XmlNodeType.EndElement &&
                xTreader.NodeType != XmlNodeType.Text;
        }

        /// <summary>
        /// Call OpenXmlReader Read() method, and move the corresponding XmlReader to
        /// the match point as the OpenXmlReader according to the Read algorithm
        /// </summary>
        /// <param name="oreader">Oreader to be called</param>
        /// <param name="treader">XmlReader that keeps synchronous with Oreader</param>
        /// <returns>TRUE, if the Read success. FALSE, if not</returns>
        private bool Read(OpenXmlReader oreader, XmlReader treader)
        {
            // TODO:EndElement logic. Misc catch logic.
            var iscontinueRead = true;
            Log.Comment("Read(OpenXmlReader, XmlReader)");

            var beforeIsStartElement = oreader.IsStartElement;
            var isOreadSuccessful = Read(oreader);
            var afterIsEndElement = false;

            if (!isOreadSuccessful)
            {
                Log.Comment("check if the pointer is on the end root element, or EOF");
                Log.VerifyTrue(treader.EOF || treader.NodeType == XmlNodeType.EndElement, "It's not either on EOF, nor end root element");
                return false;
            }
            else if (oreader.EOF == false)
            {
                afterIsEndElement = oreader.IsEndElement;
            }
            else
            {
                return false;
            }

            if (treader.IsEmptyElement == false || !(beforeIsStartElement == true && afterIsEndElement == true))
            {
                while (iscontinueRead && Read(treader))
                {
                    switch (treader.NodeType)
                    {
                        case XmlNodeType.Attribute:
                        // case XmlNodeType.Document:
                        case XmlNodeType.Text:
                        case XmlNodeType.Element:
                        case XmlNodeType.EndElement:
                            iscontinueRead = false;
                            break;
                        case XmlNodeType.SignificantWhitespace:
                        case XmlNodeType.Whitespace:
                            iscontinueRead = true;
                            break;
                        default:
                            if (oreader.ReadMiscNodes)
                            {
                                iscontinueRead = false;
                            }
                            else
                            {
                                iscontinueRead = true;
                            }

                            break;
                    }
                }

                if (!isOreadSuccessful)
                {
                    Log.Comment("check if the Read returns correctly");
                    Log.VerifyTrue(oreader.EOF, "Expect: TRUE <> Actual: False");
                    Log.Comment("check if the OpenXmlRead matchs XmlReader");
                    Log.VerifyTrue(treader.EOF, "Expect: TRUE <> Actual: False");
                }
            }

            TestGetText(oreader, treader);

            return isOreadSuccessful;
        }

        /// <summary>
        /// Call OpenXmlReader ReadFirstChild() method, and move the corresponding XmlReader to
        /// the match point as the OpenXmlReader according to the Read algorithm. If ReadFirstChild
        /// return false, the next element will be read instead.
        /// </summary>
        /// <param name="oreader">Oreader to be called</param>
        /// <param name="treader">XmlReader that keeps synchronous with Oreader</param>
        /// <returns>TRUE, if the ReadFirstChild success. FALSE, if not</returns>
        private bool ReadFirstChildOrMoveToNext(OpenXmlReader oreader, XmlReader treader)
        {
            Log.Comment("ReadFirstChild()");

            if (treader.EOF || IsMisc(treader) || treader.NodeType == XmlNodeType.EndElement || oreader.IsEndElement)
            {
                Log.VerifyFalse(oreader.ReadFirstChild(), "ReadFirstChild on EOF, expect: False Actual: True");
                Read(oreader, treader);
                return false;
            }
            else if (treader.IsStartElement())
            {
                var isStart = oreader.IsStartElement;
                var isOreadSuccessful = oreader.ReadFirstChild();
                var skip = (isStart == true) && (oreader.IsStartElement == false);

                if (isOreadSuccessful)
                {
                    if (oreader.ReadMiscNodes)
                    {
                        Read(treader);
                    }
                    else
                    {
                        while (Read(treader) && IsMisc(treader))
                        {
                        }
                    }

                    return true;
                }
                else
                {
                    if (!(treader.IsEmptyElement && oreader.IsEndElement && skip))
                    {
                        while (Read(treader) && treader.NodeType != XmlNodeType.EndElement)
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
        /// <param name="oreader">Oreader to be called</param>
        /// <param name="treader">XmlReader that keeps synchronous with Oreader</param>
        /// <returns>TRUE, if the ReadFirstChild success. FALSE, if not</returns>
        private bool ReadNextSibling(OpenXmlReader oreader, XmlReader treader)
        {
            Log.Comment("ReadNextSibling()");
            var ofoundNextSibling = oreader.ReadNextSibling();

            var foundNextSibling = false;
            var oldDepth = treader.Depth;

            if (treader.EOF)
            {
                foundNextSibling = false;
            }
            else if (treader.Depth == 0)
            {
                while (!treader.EOF && Read(treader))
                {
                }

                foundNextSibling = false;
            }
            else if (oreader.ReadMiscNodes && IsMisc(treader))
            {
                Read(treader);
                if (treader.NodeType != XmlNodeType.EndElement)
                {
                    foundNextSibling = true;
                }
                else
                {
                    foundNextSibling = false;
                }
            }
            else if (treader.NodeType == XmlNodeType.EndElement)
            {
                if (oreader.ReadMiscNodes)
                {
                    Read(treader);
                }
                else
                {
                    while (Read(treader) && (IsMisc(treader) || treader.Depth > oldDepth))
                    {
                    }
                }

                if (treader.Depth == oldDepth && treader.NodeType != XmlNodeType.EndElement)
                {
                    foundNextSibling = true;
                }
                else
                {
                    foundNextSibling = false;
                }
            }
            else if (treader.IsStartElement())
            {
                while (!(treader.NodeType == XmlNodeType.EndElement && treader.Depth == oldDepth))
                {
                    Read(treader);
                }

                Read(treader);

                if (!oreader.ReadMiscNodes)
                {
                    if (IsMisc(treader))
                    {
                        while (IsMisc(treader))
                        {
                            Read(treader);
                        }
                    }
                }

                if (treader.Depth == oldDepth && (treader.NodeType != XmlNodeType.EndElement))
                {
                    foundNextSibling = true;
                }
                else if ((treader.Depth == oldDepth + 1 && treader.NodeType == XmlNodeType.EndElement) || treader.EOF)
                {
                    foundNextSibling = false;
                }
            }

            Log.Comment("check if the ReadNextSibling() results matches with XmlReader");
            Log.VerifyTrue(ofoundNextSibling == foundNextSibling, "OpenXmlReader and XmlReader don't match");

            return ofoundNextSibling;
        }

        /// <summary>
        /// Call OpenXmlReader Skip() method, and move the corresponding XmlReader to
        /// the match point as the OpenXmlReader according to the Read algorithm.
        /// </summary>
        /// <param name="oreader">Oreader to be called<</param>
        /// <param name="treader">XmlReader that keeps synchronous with Oreader</param>
        /// <returns>Always return TRUE</returns>
        private bool Skip(OpenXmlReader oreader, XmlReader treader)
        {
            Log.Comment("Skip()");
            Skip(oreader);
            Skip(treader);
            if (!oreader.ReadMiscNodes)
            {
                while (IsMisc(treader) && !treader.EOF)
                {
                    Read(treader);
                }
            }

            return true;
        }

        private static bool Read(OpenXmlReader reader)
        {
            var result = false;

            if (reader is not null && reader.EOF == false)
            {
                result = reader.Read();

                if (IgnoreWhitespaceSetting == false)
                {
                    result = SkipWhitespace(reader);
                }

                if (reader is not null && reader.EOF == false)
                {
                    System.Diagnostics.Debug.WriteLine("O: [{0}] {1}", reader.ElementType, reader.LocalName);
                }
            }

            return result;
        }

        private static bool Read(XmlReader reader)
        {
            var result = false;

            if (reader is not null && reader.EOF == false)
            {
                result = reader.Read();

                if (IgnoreWhitespaceSetting == false)
                {
                    result = SkipWhitespace(reader);
                }

                if (reader is not null && reader.EOF == false)
                {
                    System.Diagnostics.Debug.WriteLine("X: [{0}] {1}", reader.NodeType, reader.LocalName);
                }
            }

            return result;
        }

        private static bool Skip(OpenXmlReader reader)
        {
            var result = true;

            if (reader is not null && reader.EOF == false)
            {
                reader.Skip();

                if (IgnoreWhitespaceSetting == false)
                {
                    result = SkipWhitespace(reader);
                }
            }

            return result;
        }

        private static bool Skip(XmlReader reader)
        {
            var result = true;

            if (reader is not null && reader.EOF == false)
            {
                reader.Skip();

                if (IgnoreWhitespaceSetting == false)
                {
                    result = SkipWhitespace(reader);
                }
            }

            return result;
        }

        private static bool SkipWhitespace(OpenXmlReader reader)
        {
            var result = true;

            while (result == true &&
                reader is not null && reader.EOF == false &&
                reader.LocalName == "#whitespace")
            {
                result = reader.Read();
            }

            return result;
        }

        private static bool SkipWhitespace(XmlReader reader)
        {
            var result = true;

            while (result == true &&
                reader is not null && reader.EOF == false &&
                reader.NodeType == XmlNodeType.Whitespace)
            {
                result = reader.Read();
            }

            return result;
        }
        #endregion

        [Fact]
        public void Bug247883()
        {
            using var stream0 = TestAssets.GetStream(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AdjustRightInd, true);
            using var stream1 = TestAssets.GetStream(TestAssets.TestDataStorage.V2FxTestFiles.Wordprocessing.Paragraph.AutoSpaceDE, true);
            using var word0 = WordprocessingDocument.Open(stream0, true);
            using var word1 = WordprocessingDocument.Open(stream1, true);
            var doc = word0.MainDocumentPart.Document;
            doc.Load(word1.MainDocumentPart);
            doc.Save();
        }

        [Fact]
        public void ReadMiscNode()
        {
            var body = new Body(new Paragraph(new ParagraphProperties(), new Run(new Text("test"))));
            body.PrependChild(new OpenXmlMiscNode(XmlNodeType.Comment, "<!-- start body -->"));

            using var reader = OpenXmlReader.Create(body, true);
            Assert.True(reader.Read());
            Assert.True(reader.Read());
            Assert.True(reader.IsMiscNode);
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
            using var stream = new MemoryStream();
            using var doc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            var mainpart = doc.AddMainDocumentPart();

            var writer = OpenXmlWriter.Create(mainpart);

            var miscnode = new OpenXmlMiscNode(XmlNodeType.XmlDeclaration, "<?xml version=\"1.0\" encoding=\"utf-8\"?>");

            writer.WriteStartDocument();

            writer.WriteElement(miscnode);

            writer.Close();
        }
    }
}
