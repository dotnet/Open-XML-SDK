// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:p188="http://schemas.microsoft.com/office/powerpoint/2018/8/main" namespace.
    /// </summary>
    public static class P188
    {
        /// <summary>
        /// Defines the XML namespace associated with the p188 prefix.
        /// </summary>
        public static readonly XNamespace p188 = "http://schemas.microsoft.com/office/powerpoint/2018/8/main";

        /// <summary>
        /// Represents the p188:author XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="authorLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.initials" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.providerId" />, <see cref="NoNamespace.userId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Author.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName author = p188 + "author";

        /// <summary>
        /// Represents the p188:authorLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="author" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AuthorList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName authorLst = p188 + "authorLst";

        /// <summary>
        /// Represents the p188:cm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cmLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="OAC.deMkLst" />, <see cref="OAC.gridColMkLst" />, <see cref="OAC.tcMkLst" />, <see cref="OAC.trMkLst" />, <see cref="OAC.txBodyMkLst" />, <see cref="OAC.txMkLst" />, <see cref="extLst" />, <see cref="pos" />, <see cref="replyLst" />, <see cref="txBody" />, <see cref="unknownAnchor" />, <see cref="PC.sldLayoutMkLst" />, <see cref="PC.sldMasterMkLst" />, <see cref="PC.sldMkLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.assignedTo" />, <see cref="NoNamespace.authorId" />, <see cref="NoNamespace.complete" />, <see cref="NoNamespace.created" />, <see cref="NoNamespace.dueDate" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.likes" />, <see cref="NoNamespace.priority" />, <see cref="NoNamespace.startDate" />, <see cref="NoNamespace.status" />, <see cref="NoNamespace.tags" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Comment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cm = p188 + "cm";

        /// <summary>
        /// Represents the p188:cmLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cmLst = p188 + "cmLst";

        /// <summary>
        /// Represents the p188:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="author" />, <see cref="cm" />, <see cref="reply" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="P.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = p188 + "extLst";

        /// <summary>
        /// Represents the p188:pos XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />, <see cref="NoNamespace.y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Point2DType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pos = p188 + "pos";

        /// <summary>
        /// Represents the p188:reply XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="replyLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="txBody" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.authorId" />, <see cref="NoNamespace.created" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.likes" />, <see cref="NoNamespace.status" />, <see cref="NoNamespace.tags" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentReply.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName reply = p188 + "reply";

        /// <summary>
        /// Represents the p188:replyLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cm" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="reply" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentReplyList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName replyLst = p188 + "replyLst";

        /// <summary>
        /// Represents the p188:txBody XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cm" />, <see cref="reply" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.bodyPr" />, <see cref="A.lstStyle" />, <see cref="A.p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBodyType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txBody = p188 + "txBody";

        /// <summary>
        /// Represents the p188:unknownAnchor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentUnknownAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName unknownAnchor = p188 + "unknownAnchor";
    }
}
