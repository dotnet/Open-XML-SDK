// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" namespace.
    /// </summary>
    public static class WPG
    {
        /// <summary>
        /// Defines the XML namespace associated with the wpg prefix.
        /// </summary>
        public static readonly XNamespace wpg = "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup";

        /// <summary>
        /// Represents the wpg:cNvFrPr XML element.
        /// </summary>
        public static readonly XName cNvFrPr = wpg + "cNvFrPr";

        /// <summary>
        /// Represents the wpg:cNvGrpSpPr XML element.
        /// </summary>
        public static readonly XName cNvGrpSpPr = wpg + "cNvGrpSpPr";

        /// <summary>
        /// Represents the wpg:cNvPr XML element.
        /// </summary>
        public static readonly XName cNvPr = wpg + "cNvPr";

        /// <summary>
        /// Represents the wpg:extLst XML element.
        /// </summary>
        public static readonly XName extLst = wpg + "extLst";

        /// <summary>
        /// Represents the wpg:graphicFrame XML element.
        /// </summary>
        public static readonly XName graphicFrame = wpg + "graphicFrame";

        /// <summary>
        /// Represents the wpg:grpSp XML element.
        /// </summary>
        public static readonly XName grpSp = wpg + "grpSp";

        /// <summary>
        /// Represents the wpg:grpSpPr XML element.
        /// </summary>
        public static readonly XName grpSpPr = wpg + "grpSpPr";

        /// <summary>
        /// Represents the wpg:wgp XML element.
        /// </summary>
        public static readonly XName wgp = wpg + "wgp";

        /// <summary>
        /// Represents the wpg:xfrm XML element.
        /// </summary>
        public static readonly XName xfrm = wpg + "xfrm";
    }
}
