// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// An <see cref="XmlWriter"/> that forwards every call to an inner writer, so that a decorator
    /// only has to override the calls it intercepts.
    /// </summary>
    internal abstract class ForwardingXmlWriter : XmlWriter
    {
        protected ForwardingXmlWriter(XmlWriter inner)
        {
            Inner = inner;
        }

        /// <summary>
        /// Gets the writer that calls are forwarded to.
        /// </summary>
        protected XmlWriter Inner { get; }

        public override WriteState WriteState => Inner.WriteState;

        public override XmlWriterSettings? Settings => Inner.Settings;

        public override string? XmlLang => Inner.XmlLang;

        public override XmlSpace XmlSpace => Inner.XmlSpace;

        public override void Flush() => Inner.Flush();

        public override string? LookupPrefix(string ns) => Inner.LookupPrefix(ns);

        public override void WriteBase64(byte[] buffer, int index, int count) => Inner.WriteBase64(buffer, index, count);

        public override void WriteCData(string? text) => Inner.WriteCData(text);

        public override void WriteCharEntity(char ch) => Inner.WriteCharEntity(ch);

        public override void WriteChars(char[] buffer, int index, int count) => Inner.WriteChars(buffer, index, count);

        public override void WriteComment(string? text) => Inner.WriteComment(text);

        public override void WriteDocType(string name, string? pubid, string? sysid, string? subset) => Inner.WriteDocType(name, pubid, sysid, subset);

        public override void WriteEndAttribute() => Inner.WriteEndAttribute();

        public override void WriteEndDocument() => Inner.WriteEndDocument();

        public override void WriteEndElement() => Inner.WriteEndElement();

        public override void WriteEntityRef(string name) => Inner.WriteEntityRef(name);

        public override void WriteFullEndElement() => Inner.WriteFullEndElement();

        public override void WriteProcessingInstruction(string name, string? text) => Inner.WriteProcessingInstruction(name, text);

        public override void WriteRaw(string data) => Inner.WriteRaw(data);

        public override void WriteRaw(char[] buffer, int index, int count) => Inner.WriteRaw(buffer, index, count);

        public override void WriteStartAttribute(string? prefix, string localName, string? ns) => Inner.WriteStartAttribute(prefix, localName, ns);

        public override void WriteStartDocument() => Inner.WriteStartDocument();

        public override void WriteStartDocument(bool standalone) => Inner.WriteStartDocument(standalone);

        public override void WriteStartElement(string? prefix, string localName, string? ns) => Inner.WriteStartElement(prefix, localName, ns);

        public override void WriteString(string? text) => Inner.WriteString(text);

        public override void WriteSurrogateCharEntity(char lowChar, char highChar) => Inner.WriteSurrogateCharEntity(lowChar, highChar);

        public override void WriteWhitespace(string? ws) => Inner.WriteWhitespace(ws);

        public override void Close() => Inner.Close();
    }
}
