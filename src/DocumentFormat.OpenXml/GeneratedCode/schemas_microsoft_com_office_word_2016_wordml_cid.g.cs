// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Word.Cid
{
    /// <summary>
    /// <para>Defines the CommentsIds Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w16cid:commentsIds.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommentId &lt;w16cid:commentId></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(107, "commentsIds")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CommentsIds : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentsIds class.
        /// </summary>
        public CommentsIds() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentsIds class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentsIds(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentsIds class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentsIds(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentsIds class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentsIds(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(107, "commentsIds");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<CommentId>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId), 0, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentsIds>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentId Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w16cid:commentId.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(107, "commentId")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CommentId : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentId class.
        /// </summary>
        public CommentId() : base()
        {
        }

        /// <summary>
        /// <para>paraId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: w16cid:paraId</para>
        /// </summary>
        /// <remark>
        /// xmlns:w16cid=http://schemas.microsoft.com/office/word/2016/wordml/cid
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(107, "paraId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public HexBinaryValue? ParaId
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>durableId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: w16cid:durableId</para>
        /// </summary>
        /// <remark>
        /// xmlns:w16cid=http://schemas.microsoft.com/office/word/2016/wordml/cid
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(107, "durableId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public HexBinaryValue? DurableId
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(107, "commentId");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<CommentId>()
.AddAttribute(107, "paraId", a => a.ParaId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2019));
aBuilder.AddValidator(new StringValidator() { Length = (4L) });
})
.AddAttribute(107, "durableId", a => a.DurableId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2019));
aBuilder.AddValidator(new StringValidator() { Length = (4L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentId>(deep);
    }
}