// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wpc="http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" namespace.
    /// </summary>
    public static class WPC
    {
        /// <summary>
        /// Defines the XML namespace associated with the wpc prefix.
        /// </summary>
        public static readonly XNamespace wpc = "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas";

        /// <summary>
        /// Represents the wpc:bg XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wpc_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.solidFill" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackgroundFormatting.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bg = wpc + "bg";

        /// <summary>
        /// Represents the wpc:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wpc_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = wpc + "extLst";

        /// <summary>
        /// Represents the wpc:graphicFrame XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wpc_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.graphic" />, <see cref="WPG.cNvFrPr" />, <see cref="WPG.cNvPr" />, <see cref="WPG.extLst" />, <see cref="WPG.xfrm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GraphicFrameType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName graphicFrame = wpc + "graphicFrame";

        /// <summary>
        /// Represents the wpc:whole XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wpc_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.ln" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WholeFormatting.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName whole = wpc + "whole";

        /// <summary>
        /// Represents the wpc:wpc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="PIC.pic_" />, <see cref="W14.contentPart" />, <see cref="bg" />, <see cref="extLst" />, <see cref="graphicFrame" />, <see cref="whole" />, <see cref="WPG.wgp" />, <see cref="WPS.wsp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WordprocessingCanvas.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wpc_ = wpc + "wpc";
    }
}
