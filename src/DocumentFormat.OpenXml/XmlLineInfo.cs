// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System.Xml;

namespace DocumentFormat.OpenXml
{
    internal class XmlLineInfo : IXmlLineInfo
    {
        public static IXmlLineInfo Empty { get; } = new XmlLineInfo();

        private XmlLineInfo()
        {
        }

        public static IXmlLineInfo Get(object obj) => (obj as IXmlLineInfo) ?? Empty;

        public int LineNumber => 0;

        public int LinePosition => 0;

        public bool HasLineInfo() => false;
    }
}
