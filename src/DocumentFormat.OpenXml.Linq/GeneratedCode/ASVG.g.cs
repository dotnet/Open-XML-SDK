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
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.embed" />, <see cref="R.link" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SVGBlip.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName svgBlip = asvg + "svgBlip";
    }
}
