// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:p228="http://schemas.microsoft.com/office/powerpoint/2022/08/main" namespace.
    /// </summary>
    public static partial class P228
    {
        /// <summary>
        /// Defines the XML namespace associated with the p228 prefix.
        /// </summary>
        public static readonly XNamespace p228 = "http://schemas.microsoft.com/office/powerpoint/2022/08/main";

        /// <summary>
        /// Represents the p228:add XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AddEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName add = p228 + "add";

        /// <summary>
        /// Represents the p228:anchr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="comment" />, <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName anchr = p228 + "anchr";

        /// <summary>
        /// Represents the p228:asgn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AsgnTaskAssignUnassignUser.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName asgn = p228 + "asgn";

        /// <summary>
        /// Represents the p228:atrbtn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AtrbtnTaskAssignUnassignUser.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName atrbtn = p228 + "atrbtn";

        /// <summary>
        /// Represents the p228:comment XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName comment = p228 + "comment";

        /// <summary>
        /// Represents the p228:date XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.endDt" />, <see cref="NoNamespace.stDt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskScheduleEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName date = p228 + "date";

        /// <summary>
        /// Represents the p228:event XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="history" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="add" />, <see cref="anchr" />, <see cref="asgn" />, <see cref="atrbtn" />, <see cref="date" />, <see cref="extLst" />, <see cref="pcntCmplt" />, <see cref="title" />, <see cref="unasgnAll" />, <see cref="undo" />, <see cref="unknown" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.time" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskHistoryEvent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @event = p228 + "event";

        /// <summary>
        /// Represents the p228:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchr" />, <see cref="@event" />, <see cref="taskDetails" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="P.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = p228 + "extLst";

        /// <summary>
        /// Represents the p228:history XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="taskDetails" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskHistory.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName history = p228 + "history";

        /// <summary>
        /// Represents the p228:pcntCmplt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskProgressEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pcntCmplt = p228 + "pcntCmplt";

        /// <summary>
        /// Represents the p228:taskDetails XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P188.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="history" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.deleted" />, <see cref="NoNamespace.inactive" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskDetails.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName taskDetails = p228 + "taskDetails";

        /// <summary>
        /// Represents the p228:title XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskTitleEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName title = p228 + "title";

        /// <summary>
        /// Represents the p228:unasgnAll XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UnasgnAllEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName unasgnAll = p228 + "unasgnAll";

        /// <summary>
        /// Represents the p228:undo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskUndo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName undo = p228 + "undo";

        /// <summary>
        /// Represents the p228:unknown XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskUnknownRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName unknown = p228 + "unknown";
    }
}
