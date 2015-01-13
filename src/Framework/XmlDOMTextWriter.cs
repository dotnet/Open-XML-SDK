// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    internal class XmlDOMTextWriter : XmlTextWriter
    {
        // Methods
        public XmlDOMTextWriter(TextWriter w)
            : base(w)
        {
        }

        public XmlDOMTextWriter(Stream w, Encoding encoding)
            : base(w, encoding)
        {
        }

        public XmlDOMTextWriter(string filename, Encoding encoding)
            : base(filename, encoding)
        {
        }

        public override void WriteStartAttribute(string prefix, string localName, string ns)
        {
            if (String.IsNullOrEmpty(localName))
            {
                throw new ArgumentNullException("localName");
            }

            if (prefix == null)
                prefix = string.Empty;

            if (ns == null)
                ns = string.Empty;

            if ((ns.Length == 0) && (prefix.Length != 0))
            {
                prefix = string.Empty;
            }

            base.WriteStartAttribute(prefix, localName, ns);
        }

        public override void WriteStartElement(string prefix, string localName, string ns)
        {
            if (String.IsNullOrEmpty(localName))
            {
                throw new ArgumentNullException("localName");
            }

            if (prefix == null)
                prefix = string.Empty;

            if (ns == null)
                ns = string.Empty;

            if ((ns.Length == 0) && (prefix.Length != 0))
            {
                prefix = string.Empty;
            }
            base.WriteStartElement(prefix, localName, ns);
        }
    }
}
