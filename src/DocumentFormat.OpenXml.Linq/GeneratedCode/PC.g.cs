// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:pc="http://schemas.microsoft.com/office/powerpoint/2013/main/command" namespace.
    /// </summary>
    public static class PC
    {
        /// <summary>
        /// Defines the XML namespace associated with the pc prefix.
        /// </summary>
        public static readonly XNamespace pc = "http://schemas.microsoft.com/office/powerpoint/2013/main/command";

        /// <summary>
        /// Represents the pc:animEffectMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AnimEffectMkLstAnimationEffectMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName animEffectMkLst = pc + "animEffectMkLst";

        /// <summary>
        /// Represents the pc:animEffectParentMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AnimEffectParentMkLstAnimationEffectMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName animEffectParentMkLst = pc + "animEffectParentMkLst";

        /// <summary>
        /// Represents the pc:cmAuthorMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentAuthorMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cmAuthorMkLst = pc + "cmAuthorMkLst";

        /// <summary>
        /// Represents the pc:cmMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cmMkLst = pc + "cmMkLst";

        /// <summary>
        /// Represents the pc:custShowMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomShowMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName custShowMkLst = pc + "custShowMkLst";

        /// <summary>
        /// Represents the pc:cXmlMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlPartMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cXmlMkLst = pc + "cXmlMkLst";

        /// <summary>
        /// Represents the pc:designTagMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DesignerTagMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName designTagMkLst = pc + "designTagMkLst";

        /// <summary>
        /// Represents the pc:docMk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sldMkLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocumentMoniker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docMk = pc + "docMk";

        /// <summary>
        /// Represents the pc:docMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocumentMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docMkLst = pc + "docMkLst";

        /// <summary>
        /// Represents the pc:handoutMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HandoutMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName handoutMkLst = pc + "handoutMkLst";

        /// <summary>
        /// Represents the pc:notesMasterMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotesMasterMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notesMasterMkLst = pc + "notesMasterMkLst";

        /// <summary>
        /// Represents the pc:notesMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotesMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notesMkLst = pc + "notesMkLst";

        /// <summary>
        /// Represents the pc:notesTxtMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotesTextMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notesTxtMkLst = pc + "notesTxtMkLst";

        /// <summary>
        /// Represents the pc:sectionLnkObjMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SectionLinkObjMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sectionLnkObjMkLst = pc + "sectionLnkObjMkLst";

        /// <summary>
        /// Represents the pc:sectionMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SectionMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sectionMkLst = pc + "sectionMkLst";

        /// <summary>
        /// Represents the pc:sldBaseMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideBaseMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldBaseMkLst = pc + "sldBaseMkLst";

        /// <summary>
        /// Represents the pc:sldLayoutMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideLayoutMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldLayoutMkLst = pc + "sldLayoutMkLst";

        /// <summary>
        /// Represents the pc:sldMasterMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MainMasterMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldMasterMkLst = pc + "sldMasterMkLst";

        /// <summary>
        /// Represents the pc:sldMk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sldMkLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cId" />, <see cref="NoNamespace.sldId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideMoniker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldMk = pc + "sldMk";

        /// <summary>
        /// Represents the pc:sldMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P188.cm" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="docMk" />, <see cref="sldMk" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldMkLst = pc + "sldMkLst";

        /// <summary>
        /// Represents the pc:sldPosMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlidePosMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldPosMkLst = pc + "sldPosMkLst";

        /// <summary>
        /// Represents the pc:tagMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StringTagMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tagMkLst = pc + "tagMkLst";

        /// <summary>
        /// Represents the pc:tkAppMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OsfTaskPaneAppMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tkAppMkLst = pc + "tkAppMkLst";

        /// <summary>
        /// Represents the pc:tocMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SummaryZoomMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tocMkLst = pc + "tocMkLst";
    }
}
