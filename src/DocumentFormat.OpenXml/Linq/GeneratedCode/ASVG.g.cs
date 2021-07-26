// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:asvg="http://schemas.microsoft.com/office/drawing/2016/SVG/main" namespace.
    /// </summary>
    public static class ASVG
    {
        /// <summary>
        /// Defines the XML namespace associated with the asvg prefix.
        /// </summary>
        public static readonly XNamespace asvg = "http://schemas.microsoft.com/office/drawing/2016/SVG/main";

        /// <summary>
        /// Represents the asvg:svgBlip XML element.
        /// </summary>
        public static readonly XName svgBlip = asvg + "svgBlip";
    }
}
