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
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="DGM.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.defPPr" />, <see cref="A.extLst" />, <see cref="A.lvl1pPr" />, <see cref="A.lvl2pPr" />, <see cref="A.lvl3pPr" />, <see cref="A.lvl4pPr" />, <see cref="A.lvl5pPr" />, <see cref="A.lvl6pPr" />, <see cref="A.lvl7pPr" />, <see cref="A.lvl8pPr" />, <see cref="A.lvl9pPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextListStyleType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lstStyle = dgm1612 + "lstStyle";

        /// <summary>
        /// Represents the dgm1612:spPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.custGeom" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.prstGeom" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.sp3d" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spPr = dgm1612 + "spPr";
    }
}
