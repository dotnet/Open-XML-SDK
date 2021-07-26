// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xne="http://schemas.microsoft.com/office/excel/2006/main" namespace.
    /// </summary>
    public static class XNE
    {
        /// <summary>
        /// Defines the XML namespace associated with the xne prefix.
        /// </summary>
        public static readonly XNamespace xne = "http://schemas.microsoft.com/office/excel/2006/main";

        /// <summary>
        /// Represents the xne:col XML element.
        /// </summary>
        public static readonly XName col = xne + "col";

        /// <summary>
        /// Represents the xne:colSortMap XML element.
        /// </summary>
        public static readonly XName colSortMap = xne + "colSortMap";

        /// <summary>
        /// Represents the xne:f XML element.
        /// </summary>
        public static readonly XName f = xne + "f";

        /// <summary>
        /// Represents the xne:macrosheet XML element.
        /// </summary>
        public static readonly XName macrosheet = xne + "macrosheet";

        /// <summary>
        /// Represents the xne:row XML element.
        /// </summary>
        public static readonly XName row = xne + "row";

        /// <summary>
        /// Represents the xne:rowSortMap XML element.
        /// </summary>
        public static readonly XName rowSortMap = xne + "rowSortMap";

        /// <summary>
        /// Represents the xne:sqref XML element.
        /// </summary>
        public static readonly XName sqref = xne + "sqref";

        /// <summary>
        /// Represents the xne:worksheetSortMap XML element.
        /// </summary>
        public static readonly XName worksheetSortMap = xne + "worksheetSortMap";
    }
}
