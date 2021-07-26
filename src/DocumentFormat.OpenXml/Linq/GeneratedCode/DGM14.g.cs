// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:dgm14="http://schemas.microsoft.com/office/drawing/2010/diagram" namespace.
    /// </summary>
    public static class DGM14
    {
        /// <summary>
        /// Defines the XML namespace associated with the dgm14 prefix.
        /// </summary>
        public static readonly XNamespace dgm14 = "http://schemas.microsoft.com/office/drawing/2010/diagram";

        /// <summary>
        /// Represents the dgm14:cNvPr XML element.
        /// </summary>
        public static readonly XName cNvPr = dgm14 + "cNvPr";

        /// <summary>
        /// Represents the dgm14:recolorImg XML element.
        /// </summary>
        public static readonly XName recolorImg = dgm14 + "recolorImg";
    }
}
