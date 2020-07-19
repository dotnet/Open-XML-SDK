// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.PowerPoint
{
    /// <summary>
    /// <para>Defines the PresetTransition Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:prstTrans.</para>
    /// </summary>
    public partial class PresetTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PresetTransition class.
        /// </summary>
        public PresetTransition() : base()
        {
        }

        /// <summary>
        /// <para>prst, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: prst</para>
        /// </summary>
        public StringValue Preset
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invX, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: invX</para>
        /// </summary>
        public BooleanValue InvX
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invY, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: invY</para>
        /// </summary>
        public BooleanValue InvY
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(68, "prstTrans");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PresetTransition>()
.AddAttribute(0, "prst", a => a.Preset)
.AddAttribute(0, "invX", a => a.InvX)
.AddAttribute(0, "invY", a => a.InvY);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresetTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the PresenceInfo Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:presenceInfo.</para>
    /// </summary>
    public partial class PresenceInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PresenceInfo class.
        /// </summary>
        public PresenceInfo() : base()
        {
        }

        /// <summary>
        /// <para>userId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: userId</para>
        /// </summary>
        public StringValue UserId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>providerId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: providerId</para>
        /// </summary>
        public StringValue ProviderId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(68, "presenceInfo");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PresenceInfo>()
.AddAttribute(0, "userId", a => a.UserId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "providerId", a => a.ProviderId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.AddConstraint(new AttributeValueLengthConstraint(1 /*:providerId*/, 1, 100) { Application = ApplicationType.PowerPoint, Version = FileFormatVersions.Office2013 });
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:userId*/, 1, 300) { Application = ApplicationType.PowerPoint, Version = FileFormatVersions.Office2013 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresenceInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the ThreadingInfo Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:threadingInfo.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ParentCommentIdentifier &lt;p15:parentCm></description></item>
    /// </list>
    /// </remark>
    public partial class ThreadingInfo : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ThreadingInfo class.
        /// </summary>
        public ThreadingInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadingInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadingInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadingInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadingInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadingInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ThreadingInfo(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>timeZoneBias, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: timeZoneBias</para>
        /// </summary>
        public Int32Value TimeZoneBias
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(68, "threadingInfo");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<ParentCommentIdentifier>();
            builder.AddElement<ThreadingInfo>()
.AddAttribute(0, "timeZoneBias", a => a.TimeZoneBias);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ParentCommentIdentifier), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>ParentCommentIdentifier.</para>
        /// <para>Represents the following element tag in the schema: p15:parentCm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p15 = http://schemas.microsoft.com/office/powerpoint/2012/main
        /// </remark>
        public ParentCommentIdentifier ParentCommentIdentifier
        {
            get => GetElement<ParentCommentIdentifier>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThreadingInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideGuideList Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:sldGuideLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtendedGuide &lt;p15:guide></description></item>
    ///   <item><description>ExtensionList &lt;p15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class SlideGuideList : ExtendedGuideList
    {
        /// <summary>
        /// Initializes a new instance of the SlideGuideList class.
        /// </summary>
        public SlideGuideList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideGuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideGuideList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideGuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideGuideList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideGuideList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideGuideList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(68, "sldGuideLst");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ExtendedGuide), 0, 0, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideGuideList>(deep);
    }

    /// <summary>
    /// <para>Defines the NotesGuideList Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:notesGuideLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtendedGuide &lt;p15:guide></description></item>
    ///   <item><description>ExtensionList &lt;p15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NotesGuideList : ExtendedGuideList
    {
        /// <summary>
        /// Initializes a new instance of the NotesGuideList class.
        /// </summary>
        public NotesGuideList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesGuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesGuideList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesGuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesGuideList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesGuideList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesGuideList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(68, "notesGuideLst");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ExtendedGuide), 0, 0, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesGuideList>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtendedGuideList Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtendedGuide &lt;p15:guide></description></item>
    ///   <item><description>ExtensionList &lt;p15:extLst></description></item>
    /// </list>
    /// </remark>
    public abstract partial class ExtendedGuideList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedGuideList class.
        /// </summary>
        protected ExtendedGuideList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedGuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ExtendedGuideList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedGuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ExtendedGuideList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedGuideList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected ExtendedGuideList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<ExtendedGuide>();
            builder.AddChild<ExtensionList>();
        }
    }

    /// <summary>
    /// <para>Defines the ChartTrackingReferenceBased Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:chartTrackingRefBased.</para>
    /// </summary>
    public partial class ChartTrackingReferenceBased : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartTrackingReferenceBased class.
        /// </summary>
        public ChartTrackingReferenceBased() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public BooleanValue Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(68, "chartTrackingRefBased");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ChartTrackingReferenceBased>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartTrackingReferenceBased>(deep);
    }

    /// <summary>
    /// <para>Defines the ParentCommentIdentifier Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:parentCm.</para>
    /// </summary>
    public partial class ParentCommentIdentifier : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ParentCommentIdentifier class.
        /// </summary>
        public ParentCommentIdentifier() : base()
        {
        }

        /// <summary>
        /// <para>authorId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: authorId</para>
        /// </summary>
        public UInt32Value AuthorId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idx, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        public UInt32Value Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(68, "parentCm");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ParentCommentIdentifier>()
.AddAttribute(0, "authorId", a => a.AuthorId)
.AddAttribute(0, "idx", a => a.Index);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ParentCommentIdentifier>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorType Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:clr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
    public partial class ColorType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorType class.
        /// </summary>
        public ColorType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(68, "clr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>RGB Color Model - Percentage Variant.</para>
        /// <para>Represents the following element tag in the schema: a:scrgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage RgbColorModelPercentage
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RGB Color Model - Hex Variant.</para>
        /// <para>Represents the following element tag in the schema: a:srgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelHex RgbColorModelHex
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hue, Saturation, Luminance Color Model.</para>
        /// <para>Represents the following element tag in the schema: a:hslClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HslColor HslColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HslColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>System Color.</para>
        /// <para>Represents the following element tag in the schema: a:sysClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SystemColor SystemColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SystemColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scheme Color.</para>
        /// <para>Represents the following element tag in the schema: a:schemeClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SchemeColor SchemeColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Preset Color.</para>
        /// <para>Represents the following element tag in the schema: a:prstClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PresetColor PresetColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PresetColor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorType>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Presentation.Extension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
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
            builder.SetSchema(68, "extLst");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Presentation.Extension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
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
    /// <para>Defines the ExtendedGuide Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:guide.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColorType &lt;p15:clr></description></item>
    ///   <item><description>ExtensionList &lt;p15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ExtendedGuide : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedGuide class.
        /// </summary>
        public ExtendedGuide() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedGuide class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtendedGuide(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedGuide class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtendedGuide(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedGuide class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExtendedGuide(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public UInt32Value Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>orient, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: orient</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Presentation.DirectionValues> Orientation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Presentation.DirectionValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pos, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pos</para>
        /// </summary>
        public Int32Value Position
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>userDrawn, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: userDrawn</para>
        /// </summary>
        public BooleanValue IsUserDrawn
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(68, "guide");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<ColorType>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<ExtendedGuide>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "name", a => a.Name)
.AddAttribute(0, "orient", a => a.Orientation, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "pos", a => a.Position)
.AddAttribute(0, "userDrawn", a => a.IsUserDrawn);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ColorType), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>ColorType.</para>
        /// <para>Represents the following element tag in the schema: p15:clr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p15 = http://schemas.microsoft.com/office/powerpoint/2012/main
        /// </remark>
        public ColorType ColorType
        {
            get => GetElement<ColorType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p15 = http://schemas.microsoft.com/office/powerpoint/2012/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtendedGuide>(deep);
    }
}