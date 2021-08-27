// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xdr14="http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing" namespace.
    /// </summary>
    public static class XDR14
    {
        /// <summary>
        /// Defines the XML namespace associated with the xdr14 prefix.
        /// </summary>
        public static readonly XNamespace xdr14 = "http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing";

        /// <summary>
        /// Represents the xdr14:cNvContentPartPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvContentPartPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A14.cpLocks" />, <see cref="A14.extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.isComment" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualInkContentPartProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvContentPartPr = xdr14 + "cNvContentPartPr";

        /// <summary>
        /// Represents the xdr14:cNvPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvContentPartPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.hlinkClick" />, <see cref="A.hlinkHover" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.descr" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvPr = xdr14 + "cNvPr";

        /// <summary>
        /// Represents the xdr14:contentPart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="XDR.grpSp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="nvContentPartPr" />, <see cref="nvPr" />, <see cref="xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />, <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContentPart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName contentPart = xdr14 + "contentPart";

        /// <summary>
        /// Represents the xdr14:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="XDR.contentPart" />, <see cref="contentPart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = xdr14 + "extLst";

        /// <summary>
        /// Represents the xdr14:nvContentPartPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="XDR.contentPart" />, <see cref="contentPart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvContentPartPr" />, <see cref="cNvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExcelNonVisualContentPartShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvContentPartPr = xdr14 + "nvContentPartPr";

        /// <summary>
        /// Represents the xdr14:nvPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="XDR.contentPart" />, <see cref="contentPart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fPublished" />, <see cref="NoNamespace.macro" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ApplicationNonVisualDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvPr = xdr14 + "nvPr";

        /// <summary>
        /// Represents the xdr14:xfrm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="XDR.contentPart" />, <see cref="contentPart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />, <see cref="A.off" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.flipH" />, <see cref="NoNamespace.flipV" />, <see cref="NoNamespace.rot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Transform2D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xfrm = xdr14 + "xfrm";
    }
}
