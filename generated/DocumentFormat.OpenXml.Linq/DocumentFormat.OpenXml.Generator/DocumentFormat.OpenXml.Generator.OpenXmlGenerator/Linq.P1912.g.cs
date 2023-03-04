// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:p1912="http://schemas.microsoft.com/office/powerpoint/2019/12/main" namespace.
    /// </summary>
    public static class P1912
    {
        /// <summary>
        /// Defines the XML namespace associated with the p1912 prefix.
        /// </summary>
        public static readonly XNamespace p1912 = "http://schemas.microsoft.com/office/powerpoint/2019/12/main";

        /// <summary>
        /// Represents the p1912:add XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AddEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName add = p1912 + "add";

        /// <summary>
        /// Represents the p1912:anchr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="comment" />, <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName anchr = p1912 + "anchr";

        /// <summary>
        /// Represents the p1912:asgn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AsgnTaskAssignUnassignUser.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName asgn = p1912 + "asgn";

        /// <summary>
        /// Represents the p1912:atrbtn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AtrbtnTaskAssignUnassignUser.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName atrbtn = p1912 + "atrbtn";

        /// <summary>
        /// Represents the p1912:comment XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName comment = p1912 + "comment";

        /// <summary>
        /// Represents the p1912:date XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.endDt" />, <see cref="NoNamespace.stDt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskScheduleEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName date = p1912 + "date";

        /// <summary>
        /// Represents the p1912:event XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="history" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="add" />, <see cref="anchr" />, <see cref="asgn" />, <see cref="atrbtn" />, <see cref="date" />, <see cref="extLst" />, <see cref="pcntCmplt" />, <see cref="pri" />, <see cref="title" />, <see cref="unAsgn" />, <see cref="unasgnAll" />, <see cref="undo" />, <see cref="unknown" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.time" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskHistoryEvent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @event = p1912 + "event";

        /// <summary>
        /// Represents the p1912:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchr" />, <see cref="@event" />, <see cref="taskHistoryDetails" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="P.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = p1912 + "extLst";

        /// <summary>
        /// Represents the p1912:history XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="taskHistoryDetails" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskHistory.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName history = p1912 + "history";

        /// <summary>
        /// Represents the p1912:pcntCmplt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskProgressEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pcntCmplt = p1912 + "pcntCmplt";

        /// <summary>
        /// Represents the p1912:pri XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskPriorityRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pri = p1912 + "pri";

        /// <summary>
        /// Represents the p1912:taskHistoryDetails XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="history" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskHistoryDetails.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName taskHistoryDetails = p1912 + "taskHistoryDetails";

        /// <summary>
        /// Represents the p1912:title XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskTitleEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName title = p1912 + "title";

        /// <summary>
        /// Represents the p1912:unAsgn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UnAsgnTaskAssignUnassignUser.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName unAsgn = p1912 + "unAsgn";

        /// <summary>
        /// Represents the p1912:unasgnAll XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UnasgnAllEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName unasgnAll = p1912 + "unasgnAll";

        /// <summary>
        /// Represents the p1912:undo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskUndo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName undo = p1912 + "undo";

        /// <summary>
        /// Represents the p1912:unknown XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskUnknownRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName unknown = p1912 + "unknown";
    }
}
