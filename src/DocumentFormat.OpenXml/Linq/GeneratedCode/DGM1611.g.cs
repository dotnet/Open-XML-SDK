// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:dgm1611="http://schemas.microsoft.com/office/drawing/2016/11/diagram" namespace.
    /// </summary>
    public static class DGM1611
    {
        /// <summary>
        /// Defines the XML namespace associated with the dgm1611 prefix.
        /// </summary>
        public static readonly XNamespace dgm1611 = "http://schemas.microsoft.com/office/drawing/2016/11/diagram";

        /// <summary>
        /// Represents the dgm1611:autoBuNodeInfo XML element.
        /// </summary>
        public static readonly XName autoBuNodeInfo = dgm1611 + "autoBuNodeInfo";

        /// <summary>
        /// Represents the dgm1611:autoBuNodeInfoLst XML element.
        /// </summary>
        public static readonly XName autoBuNodeInfoLst = dgm1611 + "autoBuNodeInfoLst";

        /// <summary>
        /// Represents the dgm1611:buPr XML element.
        /// </summary>
        public static readonly XName buPr = dgm1611 + "buPr";
    }
}
