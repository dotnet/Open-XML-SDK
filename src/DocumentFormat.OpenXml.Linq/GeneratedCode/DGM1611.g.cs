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
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="autoBuNodeInfoLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="buPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.lvl" />, <see cref="NoNamespace.ptType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberDiagramInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoBuNodeInfo = dgm1611 + "autoBuNodeInfo";

        /// <summary>
        /// Represents the dgm1611:autoBuNodeInfoLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="DGM.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="autoBuNodeInfo" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberDiagramInfoList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoBuNodeInfoLst = dgm1611 + "autoBuNodeInfoLst";

        /// <summary>
        /// Represents the dgm1611:buPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="autoBuNodeInfo" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.buAutoNum" />, <see cref="A.buBlip" />, <see cref="A.buChar" />, <see cref="A.buNone" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.leadZeros" />, <see cref="NoNamespace.prefix" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DiagramAutoBullet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName buPr = dgm1611 + "buPr";
    }
}
