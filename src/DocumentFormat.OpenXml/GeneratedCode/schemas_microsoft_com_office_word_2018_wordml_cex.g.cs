// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2021.Word.ExtensionList;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2021.Word.CommentsExt
{
    /// <summary>
    /// <para>Defines the CommentsExtensible Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w16cex:commentsExtensible.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommentExtensible &lt;w16cex:commentExtensible></description></item>
    ///   <item><description>ExtensionList &lt;w16cex:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(127, "commentsExtensible")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CommentsExtensible : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentsExtensible class.
        /// </summary>
        public CommentsExtensible() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentsExtensible class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentsExtensible(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentsExtensible class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentsExtensible(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentsExtensible class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentsExtensible(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(127, "commentsExtensible");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<CommentExtensible>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible), 0, 0, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentsExtensible>(deep);

        internal CommentsExtensible(WordCommentsExtensiblePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the WordCommentsExtensiblePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(WordCommentsExtensiblePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the WordCommentsExtensiblePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(WordCommentsExtensiblePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the WordCommentsExtensiblePart associated with this element.
        /// </summary>
        public WordCommentsExtensiblePart? WordCommentsExtensiblePart
        {
            get => OpenXmlPart as WordCommentsExtensiblePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the CommentExtensible Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w16cex:commentExtensible.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;w16cex:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(127, "commentExtensible")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CommentExtensible : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentExtensible class.
        /// </summary>
        public CommentExtensible() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentExtensible class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentExtensible(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentExtensible class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentExtensible(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentExtensible class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentExtensible(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>durableId, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: w16cex:durableId</para>
        /// </summary>
        /// <remark>
        /// xmlns:w16cex=http://schemas.microsoft.com/office/word/2018/wordml/cex
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(127, "durableId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public HexBinaryValue? DurableId
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dateUtc, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: w16cex:dateUtc</para>
        /// </summary>
        /// <remark>
        /// xmlns:w16cex=http://schemas.microsoft.com/office/word/2018/wordml/cex
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(127, "dateUtc")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DateTimeValue? DateUtc
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>intelligentPlaceholder, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: w16cex:intelligentPlaceholder</para>
        /// </summary>
        /// <remark>
        /// xmlns:w16cex=http://schemas.microsoft.com/office/word/2018/wordml/cex
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(127, "intelligentPlaceholder")]
#pragma warning restore CS0618 // Type or member is obsolete

        public OnOffValue? IntelligentPlaceholder
        {
            get => GetAttribute<OnOffValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(127, "commentExtensible");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<ExtensionList>();
            builder.AddElement<CommentExtensible>()
.AddAttribute(127, "durableId", a => a.DurableId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2021));
aBuilder.AddValidator(new StringValidator() { Length = (4L) });
})
.AddAttribute(127, "dateUtc", a => a.DateUtc, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2021));
})
.AddAttribute(127, "intelligentPlaceholder", a => a.IntelligentPlaceholder, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2021));
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: w16cex:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w16cex = http://schemas.microsoft.com/office/word/2018/wordml/cex
        /// </remark>
        public ExtensionList? ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentExtensible>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w16cex:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension &lt;w16cur:ext></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(127, "extLst")]
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
            builder.SetSchema(127, "extLst");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension), 0, 0, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }
}