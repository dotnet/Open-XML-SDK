// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    internal class XmlDOMTextWriter : XmlWriter
    {
        private readonly XmlWriter _writer;

        public XmlDOMTextWriter(TextWriter w)
        {
            var xwSettings = new XmlWriterSettings
            {
                Encoding = w.Encoding,
                OmitXmlDeclaration = true,
                ConformanceLevel = ConformanceLevel.Fragment,
            };

            _writer = Create(w, xwSettings);
        }

        public override WriteState WriteState => _writer.WriteState;

        public override void Flush() => _writer.Flush();

        public override string LookupPrefix(string ns) => _writer.LookupPrefix(ns);

        public override void WriteBase64(byte[] buffer, int index, int count) => _writer.WriteBase64(buffer, index, count);

        public override void WriteCData(string text) => _writer.WriteCData(text);

        public override void WriteCharEntity(char ch) => _writer.WriteCharEntity(ch);

        public override void WriteChars(char[] buffer, int index, int count) => _writer.WriteChars(buffer, index, count);

        public override void WriteComment(string text) => _writer.WriteComment(text);

        public override void WriteDocType(string name, string pubid, string sysid, string subset) => _writer.WriteDocType(name, pubid, sysid, subset);

        public override void WriteEndAttribute() => _writer.WriteEndAttribute();

        public override void WriteEndDocument() => _writer.WriteEndDocument();

        public override void WriteEndElement() => _writer.WriteEndElement();

        public override void WriteEntityRef(string name) => _writer.WriteEntityRef(name);

        public override void WriteFullEndElement() => _writer.WriteFullEndElement();

        public override void WriteProcessingInstruction(string name, string text) => _writer.WriteProcessingInstruction(name, text);

        public override void WriteRaw(string data) => _writer.WriteRaw(data);

        public override void WriteRaw(char[] buffer, int index, int count) => _writer.WriteRaw(buffer, index, count);

        public override void WriteStartAttribute(string prefix, string localName, string ns)
        {
            if (string.IsNullOrEmpty(localName))
            {
                throw new ArgumentNullException(nameof(localName));
            }

            if (prefix == null)
                prefix = string.Empty;

            if (ns == null)
                ns = string.Empty;

            if ((ns.Length == 0) && (prefix.Length != 0))
            {
                prefix = string.Empty;
            }

            _writer.WriteStartAttribute(prefix, localName, ns);
        }

        public override void WriteStartDocument() => _writer.WriteStartDocument();

        public override void WriteStartDocument(bool standalone) => _writer.WriteStartDocument(standalone);

        public override void WriteStartElement(string prefix, string localName, string ns)
        {
            if (string.IsNullOrEmpty(localName))
            {
                throw new ArgumentNullException(nameof(localName));
            }

            if (prefix == null)
                prefix = string.Empty;

            if (ns == null)
                ns = string.Empty;

            if ((ns.Length == 0) && (prefix.Length != 0))
            {
                prefix = string.Empty;
            }

            _writer.WriteStartElement(prefix, localName, ns);
        }

        public override void WriteString(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                _writer.WriteString(text);
            }
        }

        public override void WriteSurrogateCharEntity(char lowChar, char highChar) => _writer.WriteSurrogateCharEntity(lowChar, highChar);

        public override void WriteWhitespace(string ws) => _writer.WriteWhitespace(ws);

        public override XmlWriterSettings Settings => _writer.Settings;

        public override string XmlLang => _writer.XmlLang;

        public override XmlSpace XmlSpace => _writer.XmlSpace;

#if FEATURE_ABSTRACT_XML_CLOSE
        public override void Close() => _writer.Close();
#endif

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

#if !FEATURE_XML_DISPOSE_PROTECTED
            if (disposing)
            {
                _writer.Dispose();
            }
#endif
        }
    }
}
