// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
