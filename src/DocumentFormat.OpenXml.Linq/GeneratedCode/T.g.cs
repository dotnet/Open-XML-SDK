// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:t="http://schemas.microsoft.com/office/tasks/2019/documenttasks" namespace.
    /// </summary>
    public static class T
    {
        /// <summary>
        /// Defines the XML namespace associated with the t prefix.
        /// </summary>
        public static readonly XNamespace t = "http://schemas.microsoft.com/office/tasks/2019/documenttasks";

        /// <summary>
        /// Represents the t:Anchor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />, <see cref="Task" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="Comment" />, <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Anchor = t + "Anchor";

        /// <summary>
        /// Represents the t:Assign XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.userId" />, <see cref="NoNamespace.userName" />, <see cref="NoNamespace.userProvider" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AssignTaskUser.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Assign = t + "Assign";

        /// <summary>
        /// Represents the t:Attribution XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.userId" />, <see cref="NoNamespace.userName" />, <see cref="NoNamespace.userProvider" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AttributionTaskUser.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Attribution = t + "Attribution";

        /// <summary>
        /// Represents the t:Comment XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Anchor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Comment = t + "Comment";

        /// <summary>
        /// Represents the t:Create XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskCreateEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Create = t + "Create";

        /// <summary>
        /// Represents the t:Delete XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskDeleteEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Delete = t + "Delete";

        /// <summary>
        /// Represents the t:Event XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="History" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="Anchor" />, <see cref="Assign" />, <see cref="Attribution" />, <see cref="Create" />, <see cref="Delete" />, <see cref="extLst" />, <see cref="Priority" />, <see cref="Progress" />, <see cref="Schedule" />, <see cref="SetTitle" />, <see cref="Unassign" />, <see cref="UnassignAll" />, <see cref="Undelete" />, <see cref="Undo" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.time" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskHistoryEvent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Event = t + "Event";

        /// <summary>
        /// Represents the t:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Anchor" />, <see cref="Event" />, <see cref="Task" />, <see cref="Tasks" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="OEL.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = t + "extLst";

        /// <summary>
        /// Represents the t:History XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Task" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="Event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskHistory.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName History = t + "History";

        /// <summary>
        /// Represents the t:Priority XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.value" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskPriorityEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Priority = t + "Priority";

        /// <summary>
        /// Represents the t:Progress XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.percentComplete" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskProgressEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Progress = t + "Progress";

        /// <summary>
        /// Represents the t:Schedule XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dueDate" />, <see cref="NoNamespace.startDate" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskScheduleEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Schedule = t + "Schedule";

        /// <summary>
        /// Represents the t:SetTitle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskTitleEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName SetTitle = t + "SetTitle";

        /// <summary>
        /// Represents the t:Task XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Tasks" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="Anchor" />, <see cref="extLst" />, <see cref="History" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Task.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Task = t + "Task";

        /// <summary>
        /// Represents the t:Tasks XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="Task" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Tasks.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Tasks = t + "Tasks";

        /// <summary>
        /// Represents the t:Unassign XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.userId" />, <see cref="NoNamespace.userName" />, <see cref="NoNamespace.userProvider" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UnassignTaskUser.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Unassign = t + "Unassign";

        /// <summary>
        /// Represents the t:UnassignAll XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskUnassignAll.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName UnassignAll = t + "UnassignAll";

        /// <summary>
        /// Represents the t:Undelete XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskUndeleteEventInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Undelete = t + "Undelete";

        /// <summary>
        /// Represents the t:Undo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Event" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskUndo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Undo = t + "Undo";
    }
}
