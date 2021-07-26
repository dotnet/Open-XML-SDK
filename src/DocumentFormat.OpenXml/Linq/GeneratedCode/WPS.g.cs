// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape" namespace.
    /// </summary>
    public static class WPS
    {
        /// <summary>
        /// Defines the XML namespace associated with the wps prefix.
        /// </summary>
        public static readonly XNamespace wps = "http://schemas.microsoft.com/office/word/2010/wordprocessingShape";

        /// <summary>
        /// Represents the wps:bodyPr XML element.
        /// </summary>
        public static readonly XName bodyPr = wps + "bodyPr";

        /// <summary>
        /// Represents the wps:cNvCnPr XML element.
        /// </summary>
        public static readonly XName cNvCnPr = wps + "cNvCnPr";

        /// <summary>
        /// Represents the wps:cNvPr XML element.
        /// </summary>
        public static readonly XName cNvPr = wps + "cNvPr";

        /// <summary>
        /// Represents the wps:cNvSpPr XML element.
        /// </summary>
        public static readonly XName cNvSpPr = wps + "cNvSpPr";

        /// <summary>
        /// Represents the wps:extLst XML element.
        /// </summary>
        public static readonly XName extLst = wps + "extLst";

        /// <summary>
        /// Represents the wps:linkedTxbx XML element.
        /// </summary>
        public static readonly XName linkedTxbx = wps + "linkedTxbx";

        /// <summary>
        /// Represents the wps:spPr XML element.
        /// </summary>
        public static readonly XName spPr = wps + "spPr";

        /// <summary>
        /// Represents the wps:style XML element.
        /// </summary>
        public static readonly XName style = wps + "style";

        /// <summary>
        /// Represents the wps:txbx XML element.
        /// </summary>
        public static readonly XName txbx = wps + "txbx";

        /// <summary>
        /// Represents the wps:wsp XML element.
        /// </summary>
        public static readonly XName wsp = wps + "wsp";
    }
}
