// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:w15="http://schemas.microsoft.com/office/word/2012/wordml" namespace.
    /// </summary>
    public static class W15
    {
        /// <summary>
        /// Defines the XML namespace associated with the w15 prefix.
        /// </summary>
        public static readonly XNamespace w15 = "http://schemas.microsoft.com/office/word/2012/wordml";

        /// <summary>
        /// Represents the w15:appearance XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Appearance.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName appearance = w15 + "appearance";

        /// <summary>
        /// Represents the w15:author XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="person" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Person.Author.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName author = w15 + "author";

        /// <summary>
        /// Represents the w15:chartTrackingRefBased XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartTrackingRefBased.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chartTrackingRefBased = w15 + "chartTrackingRefBased";

        /// <summary>
        /// Represents the w15:collapsed XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefaultCollapsed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName collapsed = w15 + "collapsed";

        /// <summary>
        /// Represents the w15:color XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.themeColor" />, <see cref="W.themeShade" />, <see cref="W.themeTint" />, <see cref="W.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Color.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName color = w15 + "color";

        /// <summary>
        /// Represents the w15:commentEx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="commentsEx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="done" />, <see cref="paraId" />, <see cref="paraIdParent" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentEx.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commentEx = w15 + "commentEx";

        /// <summary>
        /// Represents the w15:commentsEx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="commentEx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentsEx.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commentsEx = w15 + "commentsEx";

        /// <summary>
        /// Represents the w15:dataBinding XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.prefixMappings" />, <see cref="W.storeItemID" />, <see cref="W.xpath" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataBinding.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataBinding = w15 + "dataBinding";

        /// <summary>
        /// Represents the w15:docId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PersistentDocumentId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docId = w15 + "docId";

        /// <summary>
        /// Represents the w15:done XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="commentEx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CommentEx.Done.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName done = w15 + "done";

        /// <summary>
        /// Represents the w15:doNotAllowInsertDeleteSection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="repeatingSection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotAllowInsertDeleteSection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotAllowInsertDeleteSection = w15 + "doNotAllowInsertDeleteSection";

        /// <summary>
        /// Represents the w15:footnoteColumns XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FootnoteColumns.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName footnoteColumns = w15 + "footnoteColumns";

        /// <summary>
        /// Represents the w15:paraId XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="commentEx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CommentEx.ParaId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName paraId = w15 + "paraId";

        /// <summary>
        /// Represents the w15:paraIdParent XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="commentEx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CommentEx.ParaIdParent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName paraIdParent = w15 + "paraIdParent";

        /// <summary>
        /// Represents the w15:people XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="person" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: People.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName people = w15 + "people";

        /// <summary>
        /// Represents the w15:person XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="people" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="presenceInfo" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Person.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName person = w15 + "person";

        /// <summary>
        /// Represents the w15:presenceInfo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="person" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="providerId" />, <see cref="userId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PresenceInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName presenceInfo = w15 + "presenceInfo";

        /// <summary>
        /// Represents the w15:providerId XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="presenceInfo" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PresenceInfo.ProviderId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName providerId = w15 + "providerId";

        /// <summary>
        /// Represents the w15:repeatingSection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.sdtPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="doNotAllowInsertDeleteSection" />, <see cref="sectionTitle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtRepeatedSection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName repeatingSection = w15 + "repeatingSection";

        /// <summary>
        /// Represents the w15:repeatingSectionItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.sdtPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtRepeatedSectionItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName repeatingSectionItem = w15 + "repeatingSectionItem";

        /// <summary>
        /// Represents the w15:sectionTitle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="repeatingSection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SectionTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sectionTitle = w15 + "sectionTitle";

        /// <summary>
        /// Represents the w15:userId XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="presenceInfo" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PresenceInfo.UserId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName userId = w15 + "userId";

        /// <summary>
        /// Represents the w15:val XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="appearance" />, <see cref="docId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Appearance.Val, PersistentDocumentId.Val.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName val = w15 + "val";

        /// <summary>
        /// Represents the w15:webExtensionCreated XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtensionCreated.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webExtensionCreated = w15 + "webExtensionCreated";

        /// <summary>
        /// Represents the w15:webExtensionLinked XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtensionLinked.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webExtensionLinked = w15 + "webExtensionLinked";
    }
}
