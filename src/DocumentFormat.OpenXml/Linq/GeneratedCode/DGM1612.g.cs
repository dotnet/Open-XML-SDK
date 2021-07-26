// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:dgm1612="http://schemas.microsoft.com/office/drawing/2016/12/diagram" namespace.
    /// </summary>
    public static class DGM1612
    {
        /// <summary>
        /// Defines the XML namespace associated with the dgm1612 prefix.
        /// </summary>
        public static readonly XNamespace dgm1612 = "http://schemas.microsoft.com/office/drawing/2016/12/diagram";

        /// <summary>
        /// Represents the dgm1612:lstStyle XML element.
        /// </summary>
        public static readonly XName lstStyle = dgm1612 + "lstStyle";

        /// <summary>
        /// Represents the dgm1612:spPr XML element.
        /// </summary>
        public static readonly XName spPr = dgm1612 + "spPr";
    }
}
