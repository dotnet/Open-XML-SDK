// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:p15="http://schemas.microsoft.com/office/powerpoint/2012/main" namespace.
    /// </summary>
    public static class P15
    {
        /// <summary>
        /// Defines the XML namespace associated with the p15 prefix.
        /// </summary>
        public static readonly XNamespace p15 = "http://schemas.microsoft.com/office/powerpoint/2012/main";

        /// <summary>
        /// Represents the p15:chartTrackingRefBased XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartTrackingReferenceBased.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chartTrackingRefBased = p15 + "chartTrackingRefBased";

        /// <summary>
        /// Represents the p15:clr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="guide" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clr = p15 + "clr";

        /// <summary>
        /// Represents the p15:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="guide" />, <see cref="notesGuideLst" />, <see cref="sldGuideLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="P.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = p15 + "extLst";

        /// <summary>
        /// Represents the p15:guide XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="notesGuideLst" />, <see cref="sldGuideLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="clr" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.orient" />, <see cref="NoNamespace.pos" />, <see cref="NoNamespace.userDrawn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtendedGuide.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName guide = p15 + "guide";

        /// <summary>
        /// Represents the p15:notesGuideLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="guide" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotesGuideList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notesGuideLst = p15 + "notesGuideLst";

        /// <summary>
        /// Represents the p15:parentCm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="threadingInfo" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.authorId" />, <see cref="NoNamespace.idx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ParentCommentIdentifier.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName parentCm = p15 + "parentCm";

        /// <summary>
        /// Represents the p15:presenceInfo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.providerId" />, <see cref="NoNamespace.userId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PresenceInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName presenceInfo = p15 + "presenceInfo";

        /// <summary>
        /// Represents the p15:prstTrans XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.invX_" />, <see cref="NoNamespace.invY_" />, <see cref="NoNamespace.prst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PresetTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName prstTrans = p15 + "prstTrans";

        /// <summary>
        /// Represents the p15:sldGuideLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="guide" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideGuideList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldGuideLst = p15 + "sldGuideLst";

        /// <summary>
        /// Represents the p15:threadingInfo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="parentCm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.timeZoneBias" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ThreadingInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName threadingInfo = p15 + "threadingInfo";
    }
}
