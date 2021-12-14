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

namespace DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks
{
    /// <summary>
    /// <para>Defines the TaskHistoryDetails Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:taskHistoryDetails.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList" /> <c>&lt;p216:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskHistory" /> <c>&lt;p216:history></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:taskHistoryDetails")]
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
        /// <para>id, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p216:taskHistoryDetails");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskHistory>();
            builder.AddElement<TaskHistoryDetails>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskHistory), 1, 1, version: FileFormatVersions.Microsoft365),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList), 0, 1, version: FileFormatVersions.Microsoft365)
            };
        }

        /// <summary>
        /// <para>TaskHistory.</para>
        /// <para>Represents the following element tag in the schema: p216:history.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p216 = http://schemas.microsoft.com/office/powerpoint/2021/06/main
        /// </remark>
        public DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskHistory? TaskHistory
        {
            get => GetElement<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskHistory>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p216:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p216 = http://schemas.microsoft.com/office/powerpoint/2021/06/main
        /// </remark>
        public DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskHistoryDetails>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentAnchor Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:comment.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:comment")]
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
        /// <para>id, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p216:comment");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddElement<CommentAnchor>()
.AddAttribute("id", a => a.Id, aBuilder =>
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
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Presentation.Extension" /> <c>&lt;p:ext></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:extLst")]
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
            builder.SetSchema("p216:extLst");
            builder.Availability = FileFormatVersions.Microsoft365;
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
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:atrbtn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:atrbtn")]
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
            builder.SetSchema("p216:atrbtn");
            builder.Availability = FileFormatVersions.Microsoft365;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AtrbtnTaskAssignUnassignUser>(deep);
    }

    /// <summary>
    /// <para>Defines the AsgnTaskAssignUnassignUser Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:asgn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:asgn")]
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
            builder.SetSchema("p216:asgn");
            builder.Availability = FileFormatVersions.Microsoft365;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AsgnTaskAssignUnassignUser>(deep);
    }

    /// <summary>
    /// <para>Defines the UnAsgnTaskAssignUnassignUser Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:unAsgn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:unAsgn")]
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
            builder.SetSchema("p216:unAsgn");
            builder.Availability = FileFormatVersions.Microsoft365;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnAsgnTaskAssignUnassignUser>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlTaskAssignUnassignUserElement Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
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

        [SchemaAttr("authorId")]
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
                           .AddAttribute("authorId", a => a.AuthorId, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the TaskAnchor Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:anchr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList" /> <c>&lt;p216:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.CommentAnchor" /> <c>&lt;p216:comment></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:anchr")]
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
            builder.SetSchema("p216:anchr");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.CommentAnchor>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.CommentAnchor), 1, 1, version: FileFormatVersions.Microsoft365),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList), 0, 1, version: FileFormatVersions.Microsoft365)
            };
        }

        /// <summary>
        /// <para>CommentAnchor.</para>
        /// <para>Represents the following element tag in the schema: p216:comment.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p216 = http://schemas.microsoft.com/office/powerpoint/2021/06/main
        /// </remark>
        public DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.CommentAnchor? CommentAnchor
        {
            get => GetElement<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.CommentAnchor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p216:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p216 = http://schemas.microsoft.com/office/powerpoint/2021/06/main
        /// </remark>
        public DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskAnchor>(deep);
    }

    /// <summary>
    /// <para>Defines the AddEmpty Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:add.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:add")]
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
            builder.SetSchema("p216:add");
            builder.Availability = FileFormatVersions.Microsoft365;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AddEmpty>(deep);
    }

    /// <summary>
    /// <para>Defines the UnasgnAllEmpty Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:unasgnAll.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:unasgnAll")]
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
            builder.SetSchema("p216:unasgnAll");
            builder.Availability = FileFormatVersions.Microsoft365;
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
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:title.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:title")]
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
        /// <para>val, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p216:title");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddElement<TaskTitleEventInfo>()
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskTitleEventInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskScheduleEventInfo Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:date.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:date")]
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
        /// <para>stDt, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: stDt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("stDt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DateTimeValue? StDt
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endDt, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: endDt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("endDt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DateTimeValue? EndDt
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p216:date");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddElement<TaskScheduleEventInfo>()
.AddAttribute("stDt", a => a.StDt)
.AddAttribute("endDt", a => a.EndDt);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskScheduleEventInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskProgressEventInfo Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:pcntCmplt.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:pcntCmplt")]
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
        /// <para>val, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p216:pcntCmplt");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddElement<TaskProgressEventInfo>()
.AddAttribute("val", a => a.Val, aBuilder =>
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
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:pri.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:pri")]
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
        /// <para>val, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p216:pri");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddElement<TaskPriorityRecord>()
.AddAttribute("val", a => a.Val, aBuilder =>
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
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:undo.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:undo")]
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
        /// <para>id, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p216:undo");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddElement<TaskUndo>()
.AddAttribute("id", a => a.Id, aBuilder =>
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
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:unknown.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:unknown")]
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
            builder.SetSchema("p216:unknown");
            builder.Availability = FileFormatVersions.Microsoft365;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskUnknownRecord>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskHistoryEvent Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:event.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.AddEmpty" /> <c>&lt;p216:add></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.UnasgnAllEmpty" /> <c>&lt;p216:unasgnAll></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList" /> <c>&lt;p216:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskAnchor" /> <c>&lt;p216:anchr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.AtrbtnTaskAssignUnassignUser" /> <c>&lt;p216:atrbtn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.AsgnTaskAssignUnassignUser" /> <c>&lt;p216:asgn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.UnAsgnTaskAssignUnassignUser" /> <c>&lt;p216:unAsgn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskPriorityRecord" /> <c>&lt;p216:pri></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskProgressEventInfo" /> <c>&lt;p216:pcntCmplt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskScheduleEventInfo" /> <c>&lt;p216:date></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskTitleEventInfo" /> <c>&lt;p216:title></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskUndo" /> <c>&lt;p216:undo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskUnknownRecord" /> <c>&lt;p216:unknown></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:event")]
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
        /// <para>time, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: time</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("time")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DateTimeValue? Time
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p216:event");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.AddEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.UnasgnAllEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskAnchor>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.AtrbtnTaskAssignUnassignUser>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.AsgnTaskAssignUnassignUser>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.UnAsgnTaskAssignUnassignUser>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskPriorityRecord>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskProgressEventInfo>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskScheduleEventInfo>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskTitleEventInfo>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskUndo>();
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskUnknownRecord>();
            builder.AddElement<TaskHistoryEvent>()
.AddAttribute("time", a => a.Time, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.AtrbtnTaskAssignUnassignUser), 1, 1, version: FileFormatVersions.Microsoft365),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskAnchor), 0, 1, version: FileFormatVersions.Microsoft365),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.AsgnTaskAssignUnassignUser), 1, 1, version: FileFormatVersions.Microsoft365),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.UnAsgnTaskAssignUnassignUser), 1, 1, version: FileFormatVersions.Microsoft365),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.AddEmpty), 0, 1, version: FileFormatVersions.Microsoft365),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskTitleEventInfo), 1, 1, version: FileFormatVersions.Microsoft365),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskScheduleEventInfo), 1, 1, version: FileFormatVersions.Microsoft365),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskProgressEventInfo), 1, 1, version: FileFormatVersions.Microsoft365),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskPriorityRecord), 1, 1, version: FileFormatVersions.Microsoft365),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.UnasgnAllEmpty), 0, 1, version: FileFormatVersions.Microsoft365),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskUndo), 1, 1, version: FileFormatVersions.Microsoft365),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskUnknownRecord), 1, 1, version: FileFormatVersions.Microsoft365)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.ExtensionList), 0, 1, version: FileFormatVersions.Microsoft365)
            };
        }

        /// <summary>
        /// <para>AtrbtnTaskAssignUnassignUser.</para>
        /// <para>Represents the following element tag in the schema: p216:atrbtn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p216 = http://schemas.microsoft.com/office/powerpoint/2021/06/main
        /// </remark>
        public DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.AtrbtnTaskAssignUnassignUser? AtrbtnTaskAssignUnassignUser
        {
            get => GetElement<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.AtrbtnTaskAssignUnassignUser>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TaskAnchor.</para>
        /// <para>Represents the following element tag in the schema: p216:anchr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p216 = http://schemas.microsoft.com/office/powerpoint/2021/06/main
        /// </remark>
        public DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskAnchor? TaskAnchor
        {
            get => GetElement<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskAnchor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskHistoryEvent>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskHistory Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p216:history.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskHistoryEvent" /> <c>&lt;p216:event></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("p216:history")]
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
            builder.SetSchema("p216:history");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddChild<DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskHistoryEvent>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Microsoft365.PowerPoint.Tasks.TaskHistoryEvent), 0, 0, version: FileFormatVersions.Microsoft365)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskHistory>(deep);
    }
}