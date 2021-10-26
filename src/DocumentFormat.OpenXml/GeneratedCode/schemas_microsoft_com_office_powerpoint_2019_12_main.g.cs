// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2021.PowerPoint.Comment;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks
{
    /// <summary>
    /// <para>Defines the TaskHistoryDetails Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:taskHistoryDetails.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TaskHistory &lt;ppt1912SchemaUri:history></description></item>
    ///   <item><description>ExtensionList &lt;ppt1912SchemaUri:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "taskHistoryDetails")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TaskHistoryDetails : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskHistoryDetails class.
        /// </summary>
        public TaskHistoryDetails() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistoryDetails class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskHistoryDetails(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistoryDetails class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskHistoryDetails(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistoryDetails class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskHistoryDetails(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "taskHistoryDetails");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<TaskHistory>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<TaskHistoryDetails>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.TaskHistory), 1, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>TaskHistory.</para>
        /// <para>Represents the following element tag in the schema: ppt1912SchemaUri:history.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ppt1912SchemaUri = http://schemas.microsoft.com/office/powerpoint/2019/12/main
        /// </remark>
        public TaskHistory? TaskHistory
        {
            get => GetElement<TaskHistory>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: ppt1912SchemaUri:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ppt1912SchemaUri = http://schemas.microsoft.com/office/powerpoint/2019/12/main
        /// </remark>
        public ExtensionList? ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskHistoryDetails>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentAnchor Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:comment.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "comment")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CommentAnchor : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentAnchor class.
        /// </summary>
        public CommentAnchor() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "comment");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<CommentAnchor>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentAnchor>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Presentation.Extension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "extLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtensionList class.
        /// </summary>
        public ExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "extLst");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Presentation.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the AtrbtnTaskAssignUnassignUser Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:atrbtn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "atrbtn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AtrbtnTaskAssignUnassignUser : OpenXmlTaskAssignUnassignUserElement
    {
        /// <summary>
        /// Initializes a new instance of the AtrbtnTaskAssignUnassignUser class.
        /// </summary>
        public AtrbtnTaskAssignUnassignUser() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "atrbtn");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AtrbtnTaskAssignUnassignUser>(deep);
    }

    /// <summary>
    /// <para>Defines the AsgnTaskAssignUnassignUser Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:asgn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "asgn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AsgnTaskAssignUnassignUser : OpenXmlTaskAssignUnassignUserElement
    {
        /// <summary>
        /// Initializes a new instance of the AsgnTaskAssignUnassignUser class.
        /// </summary>
        public AsgnTaskAssignUnassignUser() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "asgn");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AsgnTaskAssignUnassignUser>(deep);
    }

    /// <summary>
    /// <para>Defines the UnAsgnTaskAssignUnassignUser Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:unAsgn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "unAsgn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class UnAsgnTaskAssignUnassignUser : OpenXmlTaskAssignUnassignUserElement
    {
        /// <summary>
        /// Initializes a new instance of the UnAsgnTaskAssignUnassignUser class.
        /// </summary>
        public UnAsgnTaskAssignUnassignUser() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "unAsgn");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnAsgnTaskAssignUnassignUser>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlTaskAssignUnassignUserElement Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlTaskAssignUnassignUserElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlTaskAssignUnassignUserElement class.
        /// </summary>
        protected OpenXmlTaskAssignUnassignUserElement() : base()
        {
        }

        /// <summary>
        /// <para>authorId, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: authorId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "authorId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? AuthorId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OpenXmlTaskAssignUnassignUserElement>()
                           .AddAttribute(0, "authorId", a => a.AuthorId, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the TaskAnchor Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:anchr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommentAnchor &lt;ppt1912SchemaUri:comment></description></item>
    ///   <item><description>ExtensionList &lt;ppt1912SchemaUri:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "anchr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TaskAnchor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskAnchor class.
        /// </summary>
        public TaskAnchor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskAnchor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskAnchor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskAnchor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskAnchor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "anchr");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<CommentAnchor>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.CommentAnchor), 1, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>CommentAnchor.</para>
        /// <para>Represents the following element tag in the schema: ppt1912SchemaUri:comment.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ppt1912SchemaUri = http://schemas.microsoft.com/office/powerpoint/2019/12/main
        /// </remark>
        public CommentAnchor? CommentAnchor
        {
            get => GetElement<CommentAnchor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: ppt1912SchemaUri:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ppt1912SchemaUri = http://schemas.microsoft.com/office/powerpoint/2019/12/main
        /// </remark>
        public ExtensionList? ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskAnchor>(deep);
    }

    /// <summary>
    /// <para>Defines the AddEmpty Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:add.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "add")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AddEmpty : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the AddEmpty class.
        /// </summary>
        public AddEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "add");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AddEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the UnasgnAllEmpty Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:unasgnAll.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "unasgnAll")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class UnasgnAllEmpty : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the UnasgnAllEmpty class.
        /// </summary>
        public UnasgnAllEmpty() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "unasgnAll");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnasgnAllEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the EmptyType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class EmptyType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the EmptyType class.
        /// </summary>
        protected EmptyType() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
        }
    }

    /// <summary>
    /// <para>Defines the TaskTitleEventInfo Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:title.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "title")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TaskTitleEventInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskTitleEventInfo class.
        /// </summary>
        public TaskTitleEventInfo() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "title");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<TaskTitleEventInfo>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskTitleEventInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskScheduleEventInfo Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:date.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "date")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TaskScheduleEventInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskScheduleEventInfo class.
        /// </summary>
        public TaskScheduleEventInfo() : base()
        {
        }

        /// <summary>
        /// <para>stDt, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: stDt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "stDt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DateTimeValue? StDt
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endDt, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: endDt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "endDt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DateTimeValue? EndDt
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "date");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<TaskScheduleEventInfo>()
.AddAttribute(0, "stDt", a => a.StDt)
.AddAttribute(0, "endDt", a => a.EndDt);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskScheduleEventInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskProgressEventInfo Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:pcntCmplt.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "pcntCmplt")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TaskProgressEventInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskProgressEventInfo class.
        /// </summary>
        public TaskProgressEventInfo() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "pcntCmplt");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<TaskProgressEventInfo>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskProgressEventInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskPriorityRecord Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:pri.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "pri")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TaskPriorityRecord : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskPriorityRecord class.
        /// </summary>
        public TaskPriorityRecord() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "pri");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<TaskPriorityRecord>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskPriorityRecord>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskUndo Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:undo.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "undo")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TaskUndo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskUndo class.
        /// </summary>
        public TaskUndo() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "undo");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<TaskUndo>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskUndo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskUnknownRecord Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:unknown.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "unknown")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TaskUnknownRecord : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskUnknownRecord class.
        /// </summary>
        public TaskUnknownRecord() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "unknown");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskUnknownRecord>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskHistoryEvent Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:event.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AtrbtnTaskAssignUnassignUser &lt;ppt1912SchemaUri:atrbtn></description></item>
    ///   <item><description>TaskAnchor &lt;ppt1912SchemaUri:anchr></description></item>
    ///   <item><description>AsgnTaskAssignUnassignUser &lt;ppt1912SchemaUri:asgn></description></item>
    ///   <item><description>UnAsgnTaskAssignUnassignUser &lt;ppt1912SchemaUri:unAsgn></description></item>
    ///   <item><description>AddEmpty &lt;ppt1912SchemaUri:add></description></item>
    ///   <item><description>TaskTitleEventInfo &lt;ppt1912SchemaUri:title></description></item>
    ///   <item><description>TaskScheduleEventInfo &lt;ppt1912SchemaUri:date></description></item>
    ///   <item><description>TaskProgressEventInfo &lt;ppt1912SchemaUri:pcntCmplt></description></item>
    ///   <item><description>TaskPriorityRecord &lt;ppt1912SchemaUri:pri></description></item>
    ///   <item><description>UnasgnAllEmpty &lt;ppt1912SchemaUri:unasgnAll></description></item>
    ///   <item><description>TaskUndo &lt;ppt1912SchemaUri:undo></description></item>
    ///   <item><description>TaskUnknownRecord &lt;ppt1912SchemaUri:unknown></description></item>
    ///   <item><description>ExtensionList &lt;ppt1912SchemaUri:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "event")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TaskHistoryEvent : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskHistoryEvent class.
        /// </summary>
        public TaskHistoryEvent() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistoryEvent class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskHistoryEvent(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistoryEvent class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskHistoryEvent(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistoryEvent class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskHistoryEvent(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>time, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: time</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "time")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DateTimeValue? Time
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "event");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<AtrbtnTaskAssignUnassignUser>();
            builder.AddChild<TaskAnchor>();
            builder.AddChild<AsgnTaskAssignUnassignUser>();
            builder.AddChild<UnAsgnTaskAssignUnassignUser>();
            builder.AddChild<AddEmpty>();
            builder.AddChild<TaskTitleEventInfo>();
            builder.AddChild<TaskScheduleEventInfo>();
            builder.AddChild<TaskProgressEventInfo>();
            builder.AddChild<TaskPriorityRecord>();
            builder.AddChild<UnasgnAllEmpty>();
            builder.AddChild<TaskUndo>();
            builder.AddChild<TaskUnknownRecord>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<TaskHistoryEvent>()
.AddAttribute(0, "time", a => a.Time, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.AtrbtnTaskAssignUnassignUser), 1, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.TaskAnchor), 0, 1, version: FileFormatVersions.Office2021),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.AsgnTaskAssignUnassignUser), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.UnAsgnTaskAssignUnassignUser), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.AddEmpty), 0, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.TaskTitleEventInfo), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.TaskScheduleEventInfo), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.TaskProgressEventInfo), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.TaskPriorityRecord), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.UnasgnAllEmpty), 0, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.TaskUndo), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.TaskUnknownRecord), 1, 1, version: FileFormatVersions.Office2021)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>AtrbtnTaskAssignUnassignUser.</para>
        /// <para>Represents the following element tag in the schema: ppt1912SchemaUri:atrbtn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ppt1912SchemaUri = http://schemas.microsoft.com/office/powerpoint/2019/12/main
        /// </remark>
        public AtrbtnTaskAssignUnassignUser? AtrbtnTaskAssignUnassignUser
        {
            get => GetElement<AtrbtnTaskAssignUnassignUser>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TaskAnchor.</para>
        /// <para>Represents the following element tag in the schema: ppt1912SchemaUri:anchr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ppt1912SchemaUri = http://schemas.microsoft.com/office/powerpoint/2019/12/main
        /// </remark>
        public TaskAnchor? TaskAnchor
        {
            get => GetElement<TaskAnchor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskHistoryEvent>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskHistory Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ppt1912SchemaUri:history.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TaskHistoryEvent &lt;ppt1912SchemaUri:event></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(136, "history")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TaskHistory : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskHistory class.
        /// </summary>
        public TaskHistory() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistory class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskHistory(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistory class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskHistory(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistory class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskHistory(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(136, "history");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<TaskHistoryEvent>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks.TaskHistoryEvent), 0, 0, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskHistory>(deep);
    }
}