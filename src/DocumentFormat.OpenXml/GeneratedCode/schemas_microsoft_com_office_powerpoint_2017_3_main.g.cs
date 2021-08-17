// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Presentation
{
    /// <summary>
    /// <para>Defines the TracksInfo Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p173:tracksInfo.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TrackList &lt;p173:trackLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "tracksInfo")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TracksInfo : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TracksInfo class.
        /// </summary>
        public TracksInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TracksInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TracksInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TracksInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TracksInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TracksInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TracksInfo(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>displayLoc, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: displayLoc</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "displayLoc")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2019.Presentation.DisplayLocation>? DisplayLoc
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Presentation.DisplayLocation>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "tracksInfo");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<TrackList>();
            builder.AddElement<TracksInfo>()
.AddAttribute(0, "displayLoc", a => a.DisplayLoc, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Presentation.TrackList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>TrackList.</para>
        /// <para>Represents the following element tag in the schema: p173:trackLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p173 = http://schemas.microsoft.com/office/powerpoint/2017/3/main
        /// </remark>
        public TrackList? TrackList
        {
            get => GetElement<TrackList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TracksInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the Track Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p173:track.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "track")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Track : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Track class.
        /// </summary>
        public Track() : base()
        {
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
        /// <para>label, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "label")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lang, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "lang")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Lang
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Picture Reference</para>
        /// <para>Represents the following attribute in the schema: r:embed</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(19, "embed")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Embed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Linked Picture Reference</para>
        /// <para>Represents the following attribute in the schema: r:link</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(19, "link")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Link
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "track");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<Track>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "lang", a => a.Lang)
.AddAttribute(19, "embed", a => a.Embed)
.AddAttribute(19, "link", a => a.Link);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Track>(deep);
    }

    /// <summary>
    /// <para>Defines the TrackList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p173:trackLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Track &lt;p173:track></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(87, "trackLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TrackList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TrackList class.
        /// </summary>
        public TrackList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrackList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TrackList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrackList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TrackList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrackList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TrackList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "trackLst");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<Track>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Presentation.Track), 0, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrackList>(deep);
    }

    /// <summary>
    /// Defines the DisplayLocation enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    public enum DisplayLocation
    {
        ///<summary>
        ///media.
        ///<para>When the item is serialized out as xml, its value is "media".</para>
        ///</summary>
        [EnumString("media")]
        Media,
        ///<summary>
        ///slide.
        ///<para>When the item is serialized out as xml, its value is "slide".</para>
        ///</summary>
        [EnumString("slide")]
        Slide,
    }
}