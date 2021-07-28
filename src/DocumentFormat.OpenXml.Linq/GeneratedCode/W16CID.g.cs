// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:w16cid="http://schemas.microsoft.com/office/word/2016/wordml/cid" namespace.
    /// </summary>
    public static class W16CID
    {
        /// <summary>
        /// Defines the XML namespace associated with the w16cid prefix.
        /// </summary>
        public static readonly XNamespace w16cid = "http://schemas.microsoft.com/office/word/2016/wordml/cid";

        /// <summary>
        /// Represents the w16cid:commentId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="commentsIds" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="durableId" />, <see cref="paraId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commentId = w16cid + "commentId";

        /// <summary>
        /// Represents the w16cid:commentsIds XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="commentId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentsIds.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commentsIds = w16cid + "commentsIds";

        /// <summary>
        /// Represents the w16cid:durableId XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="commentId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CommentId.DurableId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName durableId = w16cid + "durableId";

        /// <summary>
        /// Represents the w16cid:paraId XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="commentId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CommentId.ParaId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName paraId = w16cid + "paraId";
    }
}
