// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:cdr14="http://schemas.microsoft.com/office/drawing/2010/chartDrawing" namespace.
    /// </summary>
    public static class CDR14
    {
        /// <summary>
        /// Defines the XML namespace associated with the cdr14 prefix.
        /// </summary>
        public static readonly XNamespace cdr14 = "http://schemas.microsoft.com/office/drawing/2010/chartDrawing";

        /// <summary>
        /// Represents the cdr14:cNvContentPartPr XML element.
        /// </summary>
        public static readonly XName cNvContentPartPr = cdr14 + "cNvContentPartPr";

        /// <summary>
        /// Represents the cdr14:cNvPr XML element.
        /// </summary>
        public static readonly XName cNvPr = cdr14 + "cNvPr";

        /// <summary>
        /// Represents the cdr14:contentPart XML element.
        /// </summary>
        public static readonly XName contentPart = cdr14 + "contentPart";

        /// <summary>
        /// Represents the cdr14:extLst XML element.
        /// </summary>
        public static readonly XName extLst = cdr14 + "extLst";

        /// <summary>
        /// Represents the cdr14:nvContentPartPr XML element.
        /// </summary>
        public static readonly XName nvContentPartPr = cdr14 + "nvContentPartPr";

        /// <summary>
        /// Represents the cdr14:nvPr XML element.
        /// </summary>
        public static readonly XName nvPr = cdr14 + "nvPr";

        /// <summary>
        /// Represents the cdr14:xfrm XML element.
        /// </summary>
        public static readonly XName xfrm = cdr14 + "xfrm";
    }
}
