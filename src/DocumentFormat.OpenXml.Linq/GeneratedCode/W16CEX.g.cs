// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:w16cex="http://schemas.microsoft.com/office/word/2018/wordml/cex" namespace.
    /// </summary>
    public static class W16CEX
    {
        /// <summary>
        /// Defines the XML namespace associated with the w16cex prefix.
        /// </summary>
        public static readonly XNamespace w16cex = "http://schemas.microsoft.com/office/word/2018/wordml/cex";

        /// <summary>
        /// Represents the w16cex:commentExtensible XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="commentsExtensible" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="dateUtc" />, <see cref="durableId" />, <see cref="intelligentPlaceholder" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentExtensible.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commentExtensible = w16cex + "commentExtensible";

        /// <summary>
        /// Represents the w16cex:commentsExtensible XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="commentExtensible" />, <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentsExtensible.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commentsExtensible = w16cex + "commentsExtensible";

        /// <summary>
        /// Represents the w16cex:dateUtc XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="commentExtensible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CommentExtensible.DateUtc.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dateUtc = w16cex + "dateUtc";

        /// <summary>
        /// Represents the w16cex:durableId XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="commentExtensible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CommentExtensible.DurableId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName durableId = w16cex + "durableId";

        /// <summary>
        /// Represents the w16cex:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="commentExtensible" />, <see cref="commentsExtensible" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="W16CUR.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = w16cex + "extLst";

        /// <summary>
        /// Represents the w16cex:intelligentPlaceholder XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="commentExtensible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CommentExtensible.IntelligentPlaceholder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName intelligentPlaceholder = w16cex + "intelligentPlaceholder";
    }
}
