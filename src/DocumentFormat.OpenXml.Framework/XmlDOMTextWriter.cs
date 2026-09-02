// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    internal class XmlDOMTextWriter : ForwardingXmlWriter
    {
        public XmlDOMTextWriter(Stream stream)
            : base(Create(stream))
        {
        }

        public XmlDOMTextWriter(Stream stream, XmlWriterSettings settings)
            : base(Create(stream, settings))
        {
        }

        public XmlDOMTextWriter(TextWriter w)
            : base(Create(w, new XmlWriterSettings
            {
                Encoding = w.Encoding,
                OmitXmlDeclaration = true,
                ConformanceLevel = ConformanceLevel.Fragment,
            }))
        {
        }

        public override void WriteStartAttribute(string? prefix, string localName, string? ns)
        {
            if (string.IsNullOrEmpty(localName))
            {
                throw new ArgumentNullException(nameof(localName));
            }

            if (prefix is null)
            {
                prefix = string.Empty;
            }

            if (ns is null)
            {
                ns = string.Empty;
            }

            if ((ns.Length == 0) && (prefix.Length != 0))
            {
                prefix = string.Empty;
            }

            Inner.WriteStartAttribute(prefix, localName, ns);
        }

        public override void WriteStartElement(string? prefix, string localName, string? ns)
        {
            if (string.IsNullOrEmpty(localName))
            {
                throw new ArgumentNullException(nameof(localName));
            }

            if (prefix is null)
            {
                prefix = string.Empty;
            }

            if (ns is null)
            {
                ns = string.Empty;
            }

            if ((ns.Length == 0) && (prefix.Length != 0))
            {
                prefix = string.Empty;
            }

            Inner.WriteStartElement(prefix, localName, ns);
        }

        public override void WriteString(string? text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                Inner.WriteString(text);
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
#if NET35 || NET40
                ((IDisposable)Inner).Dispose();
#else
                Inner.Dispose();
#endif
            }
        }
    }
}
