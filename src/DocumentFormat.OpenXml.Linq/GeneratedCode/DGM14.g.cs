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
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.hlinkClick" />, <see cref="A.hlinkHover" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.descr" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvPr = dgm14 + "cNvPr";

        /// <summary>
        /// Represents the dgm14:recolorImg XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RecolorImages.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName recolorImg = dgm14 + "recolorImg";
    }
}
