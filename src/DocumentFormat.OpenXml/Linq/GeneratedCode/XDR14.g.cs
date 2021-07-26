// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xdr14="http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing" namespace.
    /// </summary>
    public static class XDR14
    {
        /// <summary>
        /// Defines the XML namespace associated with the xdr14 prefix.
        /// </summary>
        public static readonly XNamespace xdr14 = "http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing";

        /// <summary>
        /// Represents the xdr14:cNvContentPartPr XML element.
        /// </summary>
        public static readonly XName cNvContentPartPr = xdr14 + "cNvContentPartPr";

        /// <summary>
        /// Represents the xdr14:cNvPr XML element.
        /// </summary>
        public static readonly XName cNvPr = xdr14 + "cNvPr";

        /// <summary>
        /// Represents the xdr14:contentPart XML element.
        /// </summary>
        public static readonly XName contentPart = xdr14 + "contentPart";

        /// <summary>
        /// Represents the xdr14:extLst XML element.
        /// </summary>
        public static readonly XName extLst = xdr14 + "extLst";

        /// <summary>
        /// Represents the xdr14:nvContentPartPr XML element.
        /// </summary>
        public static readonly XName nvContentPartPr = xdr14 + "nvContentPartPr";

        /// <summary>
        /// Represents the xdr14:nvPr XML element.
        /// </summary>
        public static readonly XName nvPr = xdr14 + "nvPr";

        /// <summary>
        /// Represents the xdr14:xfrm XML element.
        /// </summary>
        public static readonly XName xfrm = xdr14 + "xfrm";
    }
}
