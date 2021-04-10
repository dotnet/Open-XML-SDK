// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments
{
    /// <summary>
    /// <para>Defines the PersonList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:personList.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Person &lt;xltc:person></description></item>
    ///   <item><description>ExtensionList &lt;xltc:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(102, "personList")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PersonList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PersonList class.
        /// </summary>
        public PersonList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PersonList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PersonList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PersonList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PersonList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PersonList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PersonList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(102, "personList");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<Person>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.Person), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PersonList>(deep);
    }

    /// <summary>
    /// <para>Defines the ThreadedComments Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:ThreadedComments.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ThreadedComment &lt;xltc:threadedComment></description></item>
    ///   <item><description>ExtensionList &lt;xltc:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(102, "ThreadedComments")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ThreadedComments : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ThreadedComments class.
        /// </summary>
        public ThreadedComments() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedComments class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadedComments(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedComments class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadedComments(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedComments class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ThreadedComments(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(102, "ThreadedComments");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<ThreadedComment>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedComment), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThreadedComments>(deep);
    }

    /// <summary>
    /// <para>Defines the Person Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:person.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;xltc:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(102, "person")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Person : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Person class.
        /// </summary>
        public Person() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Person class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Person(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Person class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Person(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Person class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Person(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>displayName, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: displayName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "displayName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? DisplayName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2019 and later.</para>
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

        /// <summary>
        /// <para>userId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: userId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "userId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? UserId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>providerId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: providerId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "providerId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ProviderId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(102, "person");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<ExtensionList>();
            builder.AddElement<Person>()
.AddAttribute(0, "displayName", a => a.DisplayName, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "userId", a => a.UserId)
.AddAttribute(0, "providerId", a => a.ProviderId);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xltc:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xltc = http://schemas.microsoft.com/office/spreadsheetml/2018/threadedcomments
        /// </remark>
        public ExtensionList? ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Person>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Extension &lt;x:ext></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(102, "extLst")]
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
            builder.SetSchema(102, "extLst");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ThreadedComment Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:threadedComment.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ThreadedCommentText &lt;xltc:text></description></item>
    ///   <item><description>ThreadedCommentMentions &lt;xltc:mentions></description></item>
    ///   <item><description>ExtensionList &lt;xltc:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(102, "threadedComment")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ThreadedComment : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ThreadedComment class.
        /// </summary>
        public ThreadedComment() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedComment class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadedComment(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedComment class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadedComment(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedComment class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ThreadedComment(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ref, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "ref")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Ref
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dT, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: dT</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dT")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DateTimeValue? DT
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>personId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: personId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "personId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? PersonId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2019 and later.</para>
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

        /// <summary>
        /// <para>parentId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: parentId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "parentId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ParentId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>done, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: done</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "done")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Done
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(102, "threadedComment");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<ThreadedCommentText>();
            builder.AddChild<ThreadedCommentMentions>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<ThreadedComment>()
.AddAttribute(0, "ref", a => a.Ref)
.AddAttribute(0, "dT", a => a.DT)
.AddAttribute(0, "personId", a => a.PersonId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "parentId", a => a.ParentId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "done", a => a.Done);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedCommentText), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedCommentMentions), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ThreadedCommentText.</para>
        /// <para>Represents the following element tag in the schema: xltc:text.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xltc = http://schemas.microsoft.com/office/spreadsheetml/2018/threadedcomments
        /// </remark>
        public ThreadedCommentText? ThreadedCommentText
        {
            get => GetElement<ThreadedCommentText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ThreadedCommentMentions.</para>
        /// <para>Represents the following element tag in the schema: xltc:mentions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xltc = http://schemas.microsoft.com/office/spreadsheetml/2018/threadedcomments
        /// </remark>
        public ThreadedCommentMentions? ThreadedCommentMentions
        {
            get => GetElement<ThreadedCommentMentions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xltc:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xltc = http://schemas.microsoft.com/office/spreadsheetml/2018/threadedcomments
        /// </remark>
        public ExtensionList? ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThreadedComment>(deep);
    }

    /// <summary>
    /// <para>Defines the ThreadedCommentText Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:text.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(102, "text")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ThreadedCommentText : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ThreadedCommentText class.
        /// </summary>
        public ThreadedCommentText() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedCommentText class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ThreadedCommentText(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(102, "text");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThreadedCommentText>(deep);
    }

    /// <summary>
    /// <para>Defines the ThreadedCommentMentions Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:mentions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Mention &lt;xltc:mention></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(102, "mentions")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ThreadedCommentMentions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ThreadedCommentMentions class.
        /// </summary>
        public ThreadedCommentMentions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedCommentMentions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadedCommentMentions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedCommentMentions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadedCommentMentions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedCommentMentions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ThreadedCommentMentions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(102, "mentions");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<Mention>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.Mention), 0, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThreadedCommentMentions>(deep);
    }

    /// <summary>
    /// <para>Defines the Mention Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:mention.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(102, "mention")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Mention : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Mention class.
        /// </summary>
        public Mention() : base()
        {
        }

        /// <summary>
        /// <para>mentionpersonId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: mentionpersonId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "mentionpersonId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? MentionpersonId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mentionId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: mentionId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "mentionId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? MentionId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>startIndex, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: startIndex</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "startIndex")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? StartIndex
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>length, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: length</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "length")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Length
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(102, "mention");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<Mention>()
.AddAttribute(0, "mentionpersonId", a => a.MentionpersonId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "mentionId", a => a.MentionId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "startIndex", a => a.StartIndex, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "length", a => a.Length, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Mention>(deep);
    }
}