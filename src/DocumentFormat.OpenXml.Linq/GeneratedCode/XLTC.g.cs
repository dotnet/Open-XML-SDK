// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xltc="http://schemas.microsoft.com/office/spreadsheetml/2018/threadedcomments" namespace.
    /// </summary>
    public static class XLTC
    {
        /// <summary>
        /// Defines the XML namespace associated with the xltc prefix.
        /// </summary>
        public static readonly XNamespace xltc = "http://schemas.microsoft.com/office/spreadsheetml/2018/threadedcomments";

        /// <summary>
        /// Represents the xltc:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="person" />, <see cref="personList" />, <see cref="threadedComment" />, <see cref="ThreadedComments" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = xltc + "extLst";

        /// <summary>
        /// Represents the xltc:mention XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mentions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.length" />, <see cref="NoNamespace.mentionId" />, <see cref="NoNamespace.mentionpersonId" />, <see cref="NoNamespace.startIndex" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Mention.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mention = xltc + "mention";

        /// <summary>
        /// Represents the xltc:mentions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="threadedComment" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="mention" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ThreadedCommentMentions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mentions = xltc + "mentions";

        /// <summary>
        /// Represents the xltc:person XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="personList" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.displayName" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.providerId" />, <see cref="NoNamespace.userId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Person.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName person = xltc + "person";

        /// <summary>
        /// Represents the xltc:personList XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="person" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PersonList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName personList = xltc + "personList";

        /// <summary>
        /// Represents the xltc:text XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="threadedComment" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ThreadedCommentText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName text = xltc + "text";

        /// <summary>
        /// Represents the xltc:threadedComment XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ThreadedComments" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="mentions" />, <see cref="text" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.done" />, <see cref="NoNamespace.dT_" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.parentId" />, <see cref="NoNamespace.personId" />, <see cref="NoNamespace.@ref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ThreadedComment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName threadedComment = xltc + "threadedComment";

        /// <summary>
        /// Represents the xltc:ThreadedComments XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="threadedComment" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ThreadedComments.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ThreadedComments = xltc + "ThreadedComments";
    }
}
