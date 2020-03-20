﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Office2010.Drawing;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Office2013.PowerPoint;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Presentation
{
    /// <summary>
    /// <para>All Slides.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldAll.</para>
    /// </summary>
    [SchemaAttr(24, "sldAll")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideAll : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the SlideAll class.
        /// </summary>
        public SlideAll() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideAll>(deep);
    }

    /// <summary>
    /// <para>Presenter Slide Show Mode.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:present.</para>
    /// </summary>
    [SchemaAttr(24, "present")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PresenterSlideMode : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the PresenterSlideMode class.
        /// </summary>
        public PresenterSlideMode() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresenterSlideMode>(deep);
    }

    /// <summary>
    /// <para>Stop Sound Action.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:endSnd.</para>
    /// </summary>
    [SchemaAttr(24, "endSnd")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class EndSoundAction : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the EndSoundAction class.
        /// </summary>
        public EndSoundAction() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndSoundAction>(deep);
    }

    /// <summary>
    /// <para>Build As One.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bldAsOne.</para>
    /// </summary>
    [SchemaAttr(24, "bldAsOne")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BuildAsOne : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the BuildAsOne class.
        /// </summary>
        public BuildAsOne() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BuildAsOne>(deep);
    }

    /// <summary>
    /// <para>Slide Target.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldTgt.</para>
    /// </summary>
    [SchemaAttr(24, "sldTgt")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideTarget : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the SlideTarget class.
        /// </summary>
        public SlideTarget() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideTarget>(deep);
    }

    /// <summary>
    /// <para>Background.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bg.</para>
    /// </summary>
    [SchemaAttr(24, "bg")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BackgroundAnimation : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundAnimation class.
        /// </summary>
        public BackgroundAnimation() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundAnimation>(deep);
    }

    /// <summary>
    /// <para>Defines the CircleTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:circle.</para>
    /// </summary>
    [SchemaAttr(24, "circle")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CircleTransition : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the CircleTransition class.
        /// </summary>
        public CircleTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CircleTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the DissolveTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:dissolve.</para>
    /// </summary>
    [SchemaAttr(24, "dissolve")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class DissolveTransition : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the DissolveTransition class.
        /// </summary>
        public DissolveTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DissolveTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the DiamondTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:diamond.</para>
    /// </summary>
    [SchemaAttr(24, "diamond")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class DiamondTransition : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the DiamondTransition class.
        /// </summary>
        public DiamondTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DiamondTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the NewsflashTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:newsflash.</para>
    /// </summary>
    [SchemaAttr(24, "newsflash")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NewsflashTransition : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the NewsflashTransition class.
        /// </summary>
        public NewsflashTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NewsflashTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the PlusTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:plus.</para>
    /// </summary>
    [SchemaAttr(24, "plus")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PlusTransition : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the PlusTransition class.
        /// </summary>
        public PlusTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlusTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the RandomTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:random.</para>
    /// </summary>
    [SchemaAttr(24, "random")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class RandomTransition : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the RandomTransition class.
        /// </summary>
        public RandomTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RandomTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the WedgeTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:wedge.</para>
    /// </summary>
    [SchemaAttr(24, "wedge")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class WedgeTransition : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the WedgeTransition class.
        /// </summary>
        public WedgeTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WedgeTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the EmptyType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
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
    }

    /// <summary>
    /// <para>Slide Range.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldRg.</para>
    /// </summary>
    [SchemaAttr(24, "sldRg")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideRange : IndexRangeType
    {
        /// <summary>
        /// Initializes a new instance of the SlideRange class.
        /// </summary>
        public SlideRange() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideRange>(deep);
    }

    /// <summary>
    /// <para>Character Range.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:charRg.</para>
    /// </summary>
    [SchemaAttr(24, "charRg")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CharRange : IndexRangeType
    {
        /// <summary>
        /// Initializes a new instance of the CharRange class.
        /// </summary>
        public CharRange() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CharRange>(deep);
    }

    /// <summary>
    /// <para>Paragraph Text Range.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:pRg.</para>
    /// </summary>
    [SchemaAttr(24, "pRg")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ParagraphIndexRange : IndexRangeType
    {
        /// <summary>
        /// Initializes a new instance of the ParagraphIndexRange class.
        /// </summary>
        public ParagraphIndexRange() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ParagraphIndexRange>(deep);
    }

    /// <summary>
    /// <para>Defines the IndexRangeType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class IndexRangeType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the IndexRangeType class.
        /// </summary>
        protected IndexRangeType() : base()
        {
        }

        /// <summary>
        /// <para>Start</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "st")]
        [Index(0)]
        public UInt32Value Start { get; set; }

        /// <summary>
        /// <para>End</para>
        /// <para>Represents the following attribute in the schema: end</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "end")]
        [Index(1)]
        public UInt32Value End { get; set; }
    }

    /// <summary>
    /// <para>Custom Show.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:custShow.</para>
    /// </summary>
    [SchemaAttr(24, "custShow")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CustomShowReference : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomShowReference class.
        /// </summary>
        public CustomShowReference() : base()
        {
        }

        /// <summary>
        /// <para>Custom Show Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public UInt32Value Id { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomShowReference>(deep);
    }

    /// <summary>
    /// <para>Extension.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Extension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Extension class.
        /// </summary>
        public Extension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Extension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Extension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Extension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Extension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Extension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Extension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new AnyParticle(1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extension>(deep);
    }

    /// <summary>
    /// <para>Browse Slide Show Mode.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:browse.</para>
    /// </summary>
    [SchemaAttr(24, "browse")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BrowseSlideMode : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BrowseSlideMode class.
        /// </summary>
        public BrowseSlideMode() : base()
        {
        }

        /// <summary>
        /// <para>Show Scroll Bar in Window</para>
        /// <para>Represents the following attribute in the schema: showScrollbar</para>
        /// </summary>
        [SchemaAttr(0, "showScrollbar")]
        [Index(0)]
        public BooleanValue ShowScrollbar { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BrowseSlideMode>(deep);
    }

    /// <summary>
    /// <para>Kiosk Slide Show Mode.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:kiosk.</para>
    /// </summary>
    [SchemaAttr(24, "kiosk")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class KioskSlideMode : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the KioskSlideMode class.
        /// </summary>
        public KioskSlideMode() : base()
        {
        }

        /// <summary>
        /// <para>Restart Show</para>
        /// <para>Represents the following attribute in the schema: restart</para>
        /// </summary>
        [SchemaAttr(0, "restart")]
        [Index(0)]
        public UInt32Value Restart { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<KioskSlideMode>(deep);
    }

    /// <summary>
    /// <para>Color Scheme Map.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:clrMap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
    [SchemaAttr(24, "clrMap")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ColorMap : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorMap class.
        /// </summary>
        public ColorMap() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorMap(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorMap(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMap class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorMap(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Background 1</para>
        /// <para>Represents the following attribute in the schema: bg1</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bg1")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Background1 { get; set; }

        /// <summary>
        /// <para>Text 1</para>
        /// <para>Represents the following attribute in the schema: tx1</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "tx1")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Text1 { get; set; }

        /// <summary>
        /// <para>Background 2</para>
        /// <para>Represents the following attribute in the schema: bg2</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bg2")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Background2 { get; set; }

        /// <summary>
        /// <para>Text 2</para>
        /// <para>Represents the following attribute in the schema: tx2</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "tx2")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Text2 { get; set; }

        /// <summary>
        /// <para>Accent 1</para>
        /// <para>Represents the following attribute in the schema: accent1</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "accent1")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent1 { get; set; }

        /// <summary>
        /// <para>Accent 2</para>
        /// <para>Represents the following attribute in the schema: accent2</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "accent2")]
        [Index(5)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent2 { get; set; }

        /// <summary>
        /// <para>Accent 3</para>
        /// <para>Represents the following attribute in the schema: accent3</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "accent3")]
        [Index(6)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent3 { get; set; }

        /// <summary>
        /// <para>Accent 4</para>
        /// <para>Represents the following attribute in the schema: accent4</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "accent4")]
        [Index(7)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent4 { get; set; }

        /// <summary>
        /// <para>Accent 5</para>
        /// <para>Represents the following attribute in the schema: accent5</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "accent5")]
        [Index(8)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent5 { get; set; }

        /// <summary>
        /// <para>Accent 6</para>
        /// <para>Represents the following attribute in the schema: accent6</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "accent6")]
        [Index(9)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent6 { get; set; }

        /// <summary>
        /// <para>Hyperlink</para>
        /// <para>Represents the following attribute in the schema: hlink</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "hlink")]
        [Index(10)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Hyperlink { get; set; }

        /// <summary>
        /// <para>Followed Hyperlink</para>
        /// <para>Represents the following attribute in the schema: folHlink</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "folHlink")]
        [Index(11)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> FollowedHyperlink { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorMap>(deep);
    }

    /// <summary>
    /// <para>Color Scheme Map Override.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:clrMapOvr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.MasterColorMapping &lt;a:masterClrMapping></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.OverrideColorMapping &lt;a:overrideClrMapping></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.MasterColorMapping))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.OverrideColorMapping))]
    [SchemaAttr(24, "clrMapOvr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ColorMapOverride : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorMapOverride class.
        /// </summary>
        public ColorMapOverride() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMapOverride class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorMapOverride(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMapOverride class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorMapOverride(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMapOverride class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorMapOverride(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Master Color Mapping.</para>
        /// <para>Represents the following element tag in the schema: a:masterClrMapping.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.MasterColorMapping MasterColorMapping
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.MasterColorMapping>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Override Color Mapping.</para>
        /// <para>Represents the following element tag in the schema: a:overrideClrMapping.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.OverrideColorMapping OverrideColorMapping
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.OverrideColorMapping>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.MasterColorMapping), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.OverrideColorMapping), 1, 1)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorMapOverride>(deep);
    }

    /// <summary>
    /// <para>Background Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bgPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "bgPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BackgroundProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundProperties class.
        /// </summary>
        public BackgroundProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackgroundProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Shade to Title</para>
        /// <para>Represents the following attribute in the schema: shadeToTitle</para>
        /// </summary>
        [SchemaAttr(0, "shadeToTitle")]
        [Index(0)]
        public BooleanValue ShadeToTitle { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1)
                }
            },
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundProperties>(deep);
    }

    /// <summary>
    /// <para>Background Style Reference.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bgRef.</para>
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
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HslColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SystemColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetColor))]
    [SchemaAttr(24, "bgRef")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BackgroundStyleReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundStyleReference class.
        /// </summary>
        public BackgroundStyleReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundStyleReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundStyleReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundStyleReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundStyleReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundStyleReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackgroundStyleReference(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Style Matrix Index</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "idx")]
        [Index(0)]
        public UInt32Value Index { get; set; }

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

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 1)
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
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundStyleReference>(deep);
    }

    /// <summary>
    /// <para>List of Comment Authors.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cmAuthorLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommentAuthor &lt;p:cmAuthor></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommentAuthor))]
    [SchemaAttr(24, "cmAuthorLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommentAuthorList : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentAuthorList class.
        /// </summary>
        public CommentAuthorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentAuthorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentAuthorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentAuthorList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommentAuthor), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentAuthorList>(deep);

        internal CommentAuthorList(CommentAuthorsPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the CommentAuthorsPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(CommentAuthorsPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the CommentAuthorsPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(CommentAuthorsPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the CommentAuthorsPart associated with this element.
        /// </summary>
        public CommentAuthorsPart CommentAuthorsPart
        {
            get => OpenXmlPart as CommentAuthorsPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Comment List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cmLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Comment &lt;p:cm></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Comment))]
    [SchemaAttr(24, "cmLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommentList : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentList class.
        /// </summary>
        public CommentList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Comment), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentList>(deep);

        internal CommentList(SlideCommentsPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the SlideCommentsPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(SlideCommentsPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the SlideCommentsPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(SlideCommentsPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the SlideCommentsPart associated with this element.
        /// </summary>
        public SlideCommentsPart SlideCommentsPart
        {
            get => OpenXmlPart as SlideCommentsPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Global Element for OLE Objects and Controls.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:oleObj.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OleObjectEmbed &lt;p:embed></description></item>
    ///   <item><description>OleObjectLink &lt;p:link></description></item>
    ///   <item><description>Picture &lt;p:pic></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OleObjectEmbed))]
    [ChildElementInfo(typeof(OleObjectLink))]
    [ChildElementInfo(typeof(Picture))]
    [SchemaAttr(24, "oleObj")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class OleObject : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OleObject class.
        /// </summary>
        public OleObject() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleObject class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleObject(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleObject class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleObject(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleObject class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OleObject(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>spid</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "spid")]
        [Index(0)]
        public StringValue ShapeId { get; set; }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr(0, "name")]
        [Index(1)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>showAsIcon</para>
        /// <para>Represents the following attribute in the schema: showAsIcon</para>
        /// </summary>
        [SchemaAttr(0, "showAsIcon")]
        [Index(2)]
        public BooleanValue ShowAsIcon { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [SchemaAttr(19, "id")]
        [Index(3)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>imgW</para>
        /// <para>Represents the following attribute in the schema: imgW</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L)]
        [SchemaAttr(0, "imgW")]
        [Index(4)]
        public Int32Value ImageWidth { get; set; }

        /// <summary>
        /// <para>imgH</para>
        /// <para>Represents the following attribute in the schema: imgH</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L)]
        [SchemaAttr(0, "imgH")]
        [Index(5)]
        public Int32Value ImageHeight { get; set; }

        /// <summary>
        /// <para>progId</para>
        /// <para>Represents the following attribute in the schema: progId</para>
        /// </summary>
        [SchemaAttr(0, "progId")]
        [Index(6)]
        public StringValue ProgId { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.OleObjectEmbed), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.OleObjectLink), 1, 1)
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Picture), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OleObject>(deep);
    }

    /// <summary>
    /// <para>Presentation.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:presentation.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlideMasterIdList &lt;p:sldMasterIdLst></description></item>
    ///   <item><description>NotesMasterIdList &lt;p:notesMasterIdLst></description></item>
    ///   <item><description>HandoutMasterIdList &lt;p:handoutMasterIdLst></description></item>
    ///   <item><description>SlideIdList &lt;p:sldIdLst></description></item>
    ///   <item><description>SlideSize &lt;p:sldSz></description></item>
    ///   <item><description>NotesSize &lt;p:notesSz></description></item>
    ///   <item><description>EmbeddedFontList &lt;p:embeddedFontLst></description></item>
    ///   <item><description>CustomShowList &lt;p:custShowLst></description></item>
    ///   <item><description>PhotoAlbum &lt;p:photoAlbum></description></item>
    ///   <item><description>CustomerDataList &lt;p:custDataLst></description></item>
    ///   <item><description>Kinsoku &lt;p:kinsoku></description></item>
    ///   <item><description>DefaultTextStyle &lt;p:defaultTextStyle></description></item>
    ///   <item><description>ModificationVerifier &lt;p:modifyVerifier></description></item>
    ///   <item><description>PresentationExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlideMasterIdList))]
    [ChildElementInfo(typeof(NotesMasterIdList))]
    [ChildElementInfo(typeof(HandoutMasterIdList))]
    [ChildElementInfo(typeof(SlideIdList))]
    [ChildElementInfo(typeof(SlideSize))]
    [ChildElementInfo(typeof(NotesSize))]
    [ChildElementInfo(typeof(EmbeddedFontList))]
    [ChildElementInfo(typeof(CustomShowList))]
    [ChildElementInfo(typeof(PhotoAlbum))]
    [ChildElementInfo(typeof(CustomerDataList))]
    [ChildElementInfo(typeof(Kinsoku))]
    [ChildElementInfo(typeof(DefaultTextStyle))]
    [ChildElementInfo(typeof(ModificationVerifier))]
    [ChildElementInfo(typeof(PresentationExtensionList))]
    [SchemaAttr(24, "presentation")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Presentation : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Presentation class.
        /// </summary>
        public Presentation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Presentation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Presentation(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Presentation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Presentation(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Presentation class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Presentation(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>serverZoom</para>
        /// <para>Represents the following attribute in the schema: serverZoom</para>
        /// </summary>
        [SchemaAttr(0, "serverZoom")]
        [Index(0)]
        public Int32Value ServerZoom { get; set; }

        /// <summary>
        /// <para>firstSlideNum</para>
        /// <para>Represents the following attribute in the schema: firstSlideNum</para>
        /// </summary>
        [SchemaAttr(0, "firstSlideNum")]
        [Index(1)]
        public Int32Value FirstSlideNum { get; set; }

        /// <summary>
        /// <para>showSpecialPlsOnTitleSld</para>
        /// <para>Represents the following attribute in the schema: showSpecialPlsOnTitleSld</para>
        /// </summary>
        [SchemaAttr(0, "showSpecialPlsOnTitleSld")]
        [Index(2)]
        public BooleanValue ShowSpecialPlaceholderOnTitleSlide { get; set; }

        /// <summary>
        /// <para>rtl</para>
        /// <para>Represents the following attribute in the schema: rtl</para>
        /// </summary>
        [SchemaAttr(0, "rtl")]
        [Index(3)]
        public BooleanValue RightToLeft { get; set; }

        /// <summary>
        /// <para>removePersonalInfoOnSave</para>
        /// <para>Represents the following attribute in the schema: removePersonalInfoOnSave</para>
        /// </summary>
        [SchemaAttr(0, "removePersonalInfoOnSave")]
        [Index(4)]
        public BooleanValue RemovePersonalInfoOnSave { get; set; }

        /// <summary>
        /// <para>compatMode</para>
        /// <para>Represents the following attribute in the schema: compatMode</para>
        /// </summary>
        [SchemaAttr(0, "compatMode")]
        [Index(5)]
        public BooleanValue CompatibilityMode { get; set; }

        /// <summary>
        /// <para>strictFirstAndLastChars</para>
        /// <para>Represents the following attribute in the schema: strictFirstAndLastChars</para>
        /// </summary>
        [SchemaAttr(0, "strictFirstAndLastChars")]
        [Index(6)]
        public BooleanValue StrictFirstAndLastChars { get; set; }

        /// <summary>
        /// <para>embedTrueTypeFonts</para>
        /// <para>Represents the following attribute in the schema: embedTrueTypeFonts</para>
        /// </summary>
        [SchemaAttr(0, "embedTrueTypeFonts")]
        [Index(7)]
        public BooleanValue EmbedTrueTypeFonts { get; set; }

        /// <summary>
        /// <para>saveSubsetFonts</para>
        /// <para>Represents the following attribute in the schema: saveSubsetFonts</para>
        /// </summary>
        [SchemaAttr(0, "saveSubsetFonts")]
        [Index(8)]
        public BooleanValue SaveSubsetFonts { get; set; }

        /// <summary>
        /// <para>autoCompressPictures</para>
        /// <para>Represents the following attribute in the schema: autoCompressPictures</para>
        /// </summary>
        [SchemaAttr(0, "autoCompressPictures")]
        [Index(9)]
        public BooleanValue AutoCompressPictures { get; set; }

        /// <summary>
        /// <para>bookmarkIdSeed</para>
        /// <para>Represents the following attribute in the schema: bookmarkIdSeed</para>
        /// </summary>
        [NumberValidator(MaxExclusive = 2147483648L, MinInclusive = 1L)]
        [SchemaAttr(0, "bookmarkIdSeed")]
        [Index(10)]
        public UInt32Value BookmarkIdSeed { get; set; }

        /// <summary>
        /// <para>conformance</para>
        /// <para>Represents the following attribute in the schema: conformance</para>
        /// </summary>
        [SchemaAttr(0, "conformance")]
        [Index(11)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.ConformanceClassValues> Conformance { get; set; }

        /// <summary>
        /// <para>SlideMasterIdList.</para>
        /// <para>Represents the following element tag in the schema: p:sldMasterIdLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SlideMasterIdList SlideMasterIdList
        {
            get => GetElement<SlideMasterIdList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NotesMasterIdList.</para>
        /// <para>Represents the following element tag in the schema: p:notesMasterIdLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NotesMasterIdList NotesMasterIdList
        {
            get => GetElement<NotesMasterIdList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HandoutMasterIdList.</para>
        /// <para>Represents the following element tag in the schema: p:handoutMasterIdLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public HandoutMasterIdList HandoutMasterIdList
        {
            get => GetElement<HandoutMasterIdList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SlideIdList.</para>
        /// <para>Represents the following element tag in the schema: p:sldIdLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SlideIdList SlideIdList
        {
            get => GetElement<SlideIdList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SlideSize.</para>
        /// <para>Represents the following element tag in the schema: p:sldSz.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SlideSize SlideSize
        {
            get => GetElement<SlideSize>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NotesSize.</para>
        /// <para>Represents the following element tag in the schema: p:notesSz.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NotesSize NotesSize
        {
            get => GetElement<NotesSize>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EmbeddedFontList.</para>
        /// <para>Represents the following element tag in the schema: p:embeddedFontLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public EmbeddedFontList EmbeddedFontList
        {
            get => GetElement<EmbeddedFontList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CustomShowList.</para>
        /// <para>Represents the following element tag in the schema: p:custShowLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CustomShowList CustomShowList
        {
            get => GetElement<CustomShowList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PhotoAlbum.</para>
        /// <para>Represents the following element tag in the schema: p:photoAlbum.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public PhotoAlbum PhotoAlbum
        {
            get => GetElement<PhotoAlbum>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CustomerDataList.</para>
        /// <para>Represents the following element tag in the schema: p:custDataLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CustomerDataList CustomerDataList
        {
            get => GetElement<CustomerDataList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Kinsoku.</para>
        /// <para>Represents the following element tag in the schema: p:kinsoku.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Kinsoku Kinsoku
        {
            get => GetElement<Kinsoku>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DefaultTextStyle.</para>
        /// <para>Represents the following element tag in the schema: p:defaultTextStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public DefaultTextStyle DefaultTextStyle
        {
            get => GetElement<DefaultTextStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ModificationVerifier.</para>
        /// <para>Represents the following element tag in the schema: p:modifyVerifier.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ModificationVerifier ModificationVerifier
        {
            get => GetElement<ModificationVerifier>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PresentationExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public PresentationExtensionList PresentationExtensionList
        {
            get => GetElement<PresentationExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideMasterIdList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NotesMasterIdList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.HandoutMasterIdList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideIdList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideSize), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NotesSize), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.EmbeddedFontList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CustomShowList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PhotoAlbum), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CustomerDataList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Kinsoku), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.DefaultTextStyle), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ModificationVerifier), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PresentationExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Presentation>(deep);

        internal Presentation(PresentationPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the PresentationPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(PresentationPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the PresentationPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(PresentationPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the PresentationPart associated with this element.
        /// </summary>
        public PresentationPart PresentationPart
        {
            get => OpenXmlPart as PresentationPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Presentation-wide Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:presentationPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>HtmlPublishProperties &lt;p:htmlPubPr></description></item>
    ///   <item><description>WebProperties &lt;p:webPr></description></item>
    ///   <item><description>PrintingProperties &lt;p:prnPr></description></item>
    ///   <item><description>ShowProperties &lt;p:showPr></description></item>
    ///   <item><description>ColorMostRecentlyUsed &lt;p:clrMru></description></item>
    ///   <item><description>PresentationPropertiesExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(HtmlPublishProperties))]
    [ChildElementInfo(typeof(WebProperties))]
    [ChildElementInfo(typeof(PrintingProperties))]
    [ChildElementInfo(typeof(ShowProperties))]
    [ChildElementInfo(typeof(ColorMostRecentlyUsed))]
    [ChildElementInfo(typeof(PresentationPropertiesExtensionList))]
    [SchemaAttr(24, "presentationPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PresentationProperties : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the PresentationProperties class.
        /// </summary>
        public PresentationProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PresentationProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>HTML Publishing Properties.</para>
        /// <para>Represents the following element tag in the schema: p:htmlPubPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public HtmlPublishProperties HtmlPublishProperties
        {
            get => GetElement<HtmlPublishProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Web Properties.</para>
        /// <para>Represents the following element tag in the schema: p:webPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public WebProperties WebProperties
        {
            get => GetElement<WebProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PrintingProperties.</para>
        /// <para>Represents the following element tag in the schema: p:prnPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public PrintingProperties PrintingProperties
        {
            get => GetElement<PrintingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShowProperties.</para>
        /// <para>Represents the following element tag in the schema: p:showPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ShowProperties ShowProperties
        {
            get => GetElement<ShowProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColorMostRecentlyUsed.</para>
        /// <para>Represents the following element tag in the schema: p:clrMru.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ColorMostRecentlyUsed ColorMostRecentlyUsed
        {
            get => GetElement<ColorMostRecentlyUsed>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PresentationPropertiesExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public PresentationPropertiesExtensionList PresentationPropertiesExtensionList
        {
            get => GetElement<PresentationPropertiesExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.HtmlPublishProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.WebProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PrintingProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ShowProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ColorMostRecentlyUsed), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PresentationPropertiesExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresentationProperties>(deep);

        internal PresentationProperties(PresentationPropertiesPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the PresentationPropertiesPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(PresentationPropertiesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the PresentationPropertiesPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(PresentationPropertiesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the PresentationPropertiesPart associated with this element.
        /// </summary>
        public PresentationPropertiesPart PresentationPropertiesPart
        {
            get => OpenXmlPart as PresentationPropertiesPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Presentation Slide.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sld.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonSlideData &lt;p:cSld></description></item>
    ///   <item><description>ColorMapOverride &lt;p:clrMapOvr></description></item>
    ///   <item><description>Transition &lt;p:transition></description></item>
    ///   <item><description>Timing &lt;p:timing></description></item>
    ///   <item><description>SlideExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonSlideData))]
    [ChildElementInfo(typeof(ColorMapOverride))]
    [ChildElementInfo(typeof(Transition))]
    [ChildElementInfo(typeof(Timing))]
    [ChildElementInfo(typeof(SlideExtensionList))]
    [SchemaAttr(24, "sld")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Slide : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Slide class.
        /// </summary>
        public Slide() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slide class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Slide(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slide class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Slide(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slide class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Slide(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Show Master Shapes</para>
        /// <para>Represents the following attribute in the schema: showMasterSp</para>
        /// </summary>
        [SchemaAttr(0, "showMasterSp")]
        [Index(0)]
        public BooleanValue ShowMasterShapes { get; set; }

        /// <summary>
        /// <para>Show Master Placeholder Animations</para>
        /// <para>Represents the following attribute in the schema: showMasterPhAnim</para>
        /// </summary>
        [SchemaAttr(0, "showMasterPhAnim")]
        [Index(1)]
        public BooleanValue ShowMasterPlaceholderAnimations { get; set; }

        /// <summary>
        /// <para>Show Slide in Slide Show</para>
        /// <para>Represents the following attribute in the schema: show</para>
        /// </summary>
        [SchemaAttr(0, "show")]
        [Index(2)]
        public BooleanValue Show { get; set; }

        /// <summary>
        /// <para>Common slide data for slides.</para>
        /// <para>Represents the following element tag in the schema: p:cSld.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonSlideData CommonSlideData
        {
            get => GetElement<CommonSlideData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Color Scheme Map Override.</para>
        /// <para>Represents the following element tag in the schema: p:clrMapOvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ColorMapOverride ColorMapOverride
        {
            get => GetElement<ColorMapOverride>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Slide Transition.</para>
        /// <para>Represents the following element tag in the schema: p:transition.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Transition Transition
        {
            get => GetElement<Transition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Slide Timing Information for a Slide.</para>
        /// <para>Represents the following element tag in the schema: p:timing.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Timing Timing
        {
            get => GetElement<Timing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SlideExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SlideExtensionList SlideExtensionList
        {
            get => GetElement<SlideExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonSlideData), 1, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ColorMapOverride), 0, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Transition), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Timing), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Slide>(deep);

        internal Slide(SlidePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the SlidePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(SlidePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the SlidePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(SlidePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the SlidePart associated with this element.
        /// </summary>
        public SlidePart SlidePart
        {
            get => OpenXmlPart as SlidePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Slide Layout.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldLayout.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonSlideData &lt;p:cSld></description></item>
    ///   <item><description>ColorMapOverride &lt;p:clrMapOvr></description></item>
    ///   <item><description>Transition &lt;p:transition></description></item>
    ///   <item><description>Timing &lt;p:timing></description></item>
    ///   <item><description>HeaderFooter &lt;p:hf></description></item>
    ///   <item><description>SlideLayoutExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonSlideData))]
    [ChildElementInfo(typeof(ColorMapOverride))]
    [ChildElementInfo(typeof(Transition))]
    [ChildElementInfo(typeof(Timing))]
    [ChildElementInfo(typeof(HeaderFooter))]
    [ChildElementInfo(typeof(SlideLayoutExtensionList))]
    [SchemaAttr(24, "sldLayout")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideLayout : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideLayout class.
        /// </summary>
        public SlideLayout() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideLayout(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideLayout(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayout class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideLayout(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Show Master Shapes</para>
        /// <para>Represents the following attribute in the schema: showMasterSp</para>
        /// </summary>
        [SchemaAttr(0, "showMasterSp")]
        [Index(0)]
        public BooleanValue ShowMasterShapes { get; set; }

        /// <summary>
        /// <para>Show Master Placeholder Animations</para>
        /// <para>Represents the following attribute in the schema: showMasterPhAnim</para>
        /// </summary>
        [SchemaAttr(0, "showMasterPhAnim")]
        [Index(1)]
        public BooleanValue ShowMasterPlaceholderAnimations { get; set; }

        /// <summary>
        /// <para>matchingName</para>
        /// <para>Represents the following attribute in the schema: matchingName</para>
        /// </summary>
        [SchemaAttr(0, "matchingName")]
        [Index(2)]
        public StringValue MatchingName { get; set; }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "type")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.SlideLayoutValues> Type { get; set; }

        /// <summary>
        /// <para>preserve</para>
        /// <para>Represents the following attribute in the schema: preserve</para>
        /// </summary>
        [SchemaAttr(0, "preserve")]
        [Index(4)]
        public BooleanValue Preserve { get; set; }

        /// <summary>
        /// <para>userDrawn</para>
        /// <para>Represents the following attribute in the schema: userDrawn</para>
        /// </summary>
        [SchemaAttr(0, "userDrawn")]
        [Index(5)]
        public BooleanValue UserDrawn { get; set; }

        /// <summary>
        /// <para>CommonSlideData.</para>
        /// <para>Represents the following element tag in the schema: p:cSld.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonSlideData CommonSlideData
        {
            get => GetElement<CommonSlideData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Color Scheme Map Override.</para>
        /// <para>Represents the following element tag in the schema: p:clrMapOvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ColorMapOverride ColorMapOverride
        {
            get => GetElement<ColorMapOverride>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Transition.</para>
        /// <para>Represents the following element tag in the schema: p:transition.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Transition Transition
        {
            get => GetElement<Transition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Timing.</para>
        /// <para>Represents the following element tag in the schema: p:timing.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Timing Timing
        {
            get => GetElement<Timing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HeaderFooter.</para>
        /// <para>Represents the following element tag in the schema: p:hf.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public HeaderFooter HeaderFooter
        {
            get => GetElement<HeaderFooter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SlideLayoutExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SlideLayoutExtensionList SlideLayoutExtensionList
        {
            get => GetElement<SlideLayoutExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonSlideData), 1, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ColorMapOverride), 0, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Transition), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Timing), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.HeaderFooter), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideLayoutExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideLayout>(deep);

        internal SlideLayout(SlideLayoutPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the SlideLayoutPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(SlideLayoutPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the SlideLayoutPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(SlideLayoutPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the SlideLayoutPart associated with this element.
        /// </summary>
        public SlideLayoutPart SlideLayoutPart
        {
            get => OpenXmlPart as SlideLayoutPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Slide Master.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldMaster.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonSlideData &lt;p:cSld></description></item>
    ///   <item><description>ColorMap &lt;p:clrMap></description></item>
    ///   <item><description>SlideLayoutIdList &lt;p:sldLayoutIdLst></description></item>
    ///   <item><description>Transition &lt;p:transition></description></item>
    ///   <item><description>Timing &lt;p:timing></description></item>
    ///   <item><description>HeaderFooter &lt;p:hf></description></item>
    ///   <item><description>TextStyles &lt;p:txStyles></description></item>
    ///   <item><description>SlideMasterExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonSlideData))]
    [ChildElementInfo(typeof(ColorMap))]
    [ChildElementInfo(typeof(SlideLayoutIdList))]
    [ChildElementInfo(typeof(Transition))]
    [ChildElementInfo(typeof(Timing))]
    [ChildElementInfo(typeof(HeaderFooter))]
    [ChildElementInfo(typeof(TextStyles))]
    [ChildElementInfo(typeof(SlideMasterExtensionList))]
    [SchemaAttr(24, "sldMaster")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideMaster : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideMaster class.
        /// </summary>
        public SlideMaster() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMaster class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideMaster(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMaster class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideMaster(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMaster class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideMaster(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>preserve</para>
        /// <para>Represents the following attribute in the schema: preserve</para>
        /// </summary>
        [SchemaAttr(0, "preserve")]
        [Index(0)]
        public BooleanValue Preserve { get; set; }

        /// <summary>
        /// <para>CommonSlideData.</para>
        /// <para>Represents the following element tag in the schema: p:cSld.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonSlideData CommonSlideData
        {
            get => GetElement<CommonSlideData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Color Scheme Map.</para>
        /// <para>Represents the following element tag in the schema: p:clrMap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ColorMap ColorMap
        {
            get => GetElement<ColorMap>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SlideLayoutIdList.</para>
        /// <para>Represents the following element tag in the schema: p:sldLayoutIdLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SlideLayoutIdList SlideLayoutIdList
        {
            get => GetElement<SlideLayoutIdList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Transition.</para>
        /// <para>Represents the following element tag in the schema: p:transition.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Transition Transition
        {
            get => GetElement<Transition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Timing.</para>
        /// <para>Represents the following element tag in the schema: p:timing.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Timing Timing
        {
            get => GetElement<Timing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HeaderFooter.</para>
        /// <para>Represents the following element tag in the schema: p:hf.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public HeaderFooter HeaderFooter
        {
            get => GetElement<HeaderFooter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextStyles.</para>
        /// <para>Represents the following element tag in the schema: p:txStyles.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TextStyles TextStyles
        {
            get => GetElement<TextStyles>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SlideMasterExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SlideMasterExtensionList SlideMasterExtensionList
        {
            get => GetElement<SlideMasterExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonSlideData), 1, 1),
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ColorMap), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideLayoutIdList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Transition), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Timing), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.HeaderFooter), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TextStyles), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideMasterExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideMaster>(deep);

        internal SlideMaster(SlideMasterPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the SlideMasterPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(SlideMasterPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the SlideMasterPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(SlideMasterPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the SlideMasterPart associated with this element.
        /// </summary>
        public SlideMasterPart SlideMasterPart
        {
            get => OpenXmlPart as SlideMasterPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Handout Master.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:handoutMaster.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonSlideData &lt;p:cSld></description></item>
    ///   <item><description>ColorMap &lt;p:clrMap></description></item>
    ///   <item><description>HeaderFooter &lt;p:hf></description></item>
    ///   <item><description>HandoutMasterExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonSlideData))]
    [ChildElementInfo(typeof(ColorMap))]
    [ChildElementInfo(typeof(HeaderFooter))]
    [ChildElementInfo(typeof(HandoutMasterExtensionList))]
    [SchemaAttr(24, "handoutMaster")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class HandoutMaster : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the HandoutMaster class.
        /// </summary>
        public HandoutMaster() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMaster class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HandoutMaster(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMaster class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HandoutMaster(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMaster class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HandoutMaster(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>CommonSlideData.</para>
        /// <para>Represents the following element tag in the schema: p:cSld.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonSlideData CommonSlideData
        {
            get => GetElement<CommonSlideData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Color Scheme Map.</para>
        /// <para>Represents the following element tag in the schema: p:clrMap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ColorMap ColorMap
        {
            get => GetElement<ColorMap>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HeaderFooter.</para>
        /// <para>Represents the following element tag in the schema: p:hf.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public HeaderFooter HeaderFooter
        {
            get => GetElement<HeaderFooter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HandoutMasterExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public HandoutMasterExtensionList HandoutMasterExtensionList
        {
            get => GetElement<HandoutMasterExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonSlideData), 1, 1),
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ColorMap), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.HeaderFooter), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.HandoutMasterExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HandoutMaster>(deep);

        internal HandoutMaster(HandoutMasterPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the HandoutMasterPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(HandoutMasterPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the HandoutMasterPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(HandoutMasterPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the HandoutMasterPart associated with this element.
        /// </summary>
        public HandoutMasterPart HandoutMasterPart
        {
            get => OpenXmlPart as HandoutMasterPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Notes Master.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:notesMaster.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonSlideData &lt;p:cSld></description></item>
    ///   <item><description>ColorMap &lt;p:clrMap></description></item>
    ///   <item><description>HeaderFooter &lt;p:hf></description></item>
    ///   <item><description>NotesStyle &lt;p:notesStyle></description></item>
    ///   <item><description>NotesMasterExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonSlideData))]
    [ChildElementInfo(typeof(ColorMap))]
    [ChildElementInfo(typeof(HeaderFooter))]
    [ChildElementInfo(typeof(NotesStyle))]
    [ChildElementInfo(typeof(NotesMasterExtensionList))]
    [SchemaAttr(24, "notesMaster")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NotesMaster : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the NotesMaster class.
        /// </summary>
        public NotesMaster() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMaster class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMaster(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMaster class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMaster(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMaster class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesMaster(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>CommonSlideData.</para>
        /// <para>Represents the following element tag in the schema: p:cSld.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonSlideData CommonSlideData
        {
            get => GetElement<CommonSlideData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Color Scheme Map.</para>
        /// <para>Represents the following element tag in the schema: p:clrMap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ColorMap ColorMap
        {
            get => GetElement<ColorMap>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HeaderFooter.</para>
        /// <para>Represents the following element tag in the schema: p:hf.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public HeaderFooter HeaderFooter
        {
            get => GetElement<HeaderFooter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NotesStyle.</para>
        /// <para>Represents the following element tag in the schema: p:notesStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NotesStyle NotesStyle
        {
            get => GetElement<NotesStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NotesMasterExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NotesMasterExtensionList NotesMasterExtensionList
        {
            get => GetElement<NotesMasterExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonSlideData), 1, 1),
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ColorMap), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.HeaderFooter), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NotesStyle), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NotesMasterExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesMaster>(deep);

        internal NotesMaster(NotesMasterPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the NotesMasterPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(NotesMasterPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the NotesMasterPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(NotesMasterPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the NotesMasterPart associated with this element.
        /// </summary>
        public NotesMasterPart NotesMasterPart
        {
            get => OpenXmlPart as NotesMasterPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Notes Slide.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:notes.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonSlideData &lt;p:cSld></description></item>
    ///   <item><description>ColorMapOverride &lt;p:clrMapOvr></description></item>
    ///   <item><description>ExtensionListWithModification &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonSlideData))]
    [ChildElementInfo(typeof(ColorMapOverride))]
    [ChildElementInfo(typeof(ExtensionListWithModification))]
    [SchemaAttr(24, "notes")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NotesSlide : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the NotesSlide class.
        /// </summary>
        public NotesSlide() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesSlide class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesSlide(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesSlide class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesSlide(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesSlide class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesSlide(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Show Master Shapes</para>
        /// <para>Represents the following attribute in the schema: showMasterSp</para>
        /// </summary>
        [SchemaAttr(0, "showMasterSp")]
        [Index(0)]
        public BooleanValue ShowMasterShapes { get; set; }

        /// <summary>
        /// <para>Show Master Placeholder Animations</para>
        /// <para>Represents the following attribute in the schema: showMasterPhAnim</para>
        /// </summary>
        [SchemaAttr(0, "showMasterPhAnim")]
        [Index(1)]
        public BooleanValue ShowMasterPlaceholderAnimations { get; set; }

        /// <summary>
        /// <para>Common slide data for notes slides.</para>
        /// <para>Represents the following element tag in the schema: p:cSld.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonSlideData CommonSlideData
        {
            get => GetElement<CommonSlideData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Color Scheme Map Override.</para>
        /// <para>Represents the following element tag in the schema: p:clrMapOvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ColorMapOverride ColorMapOverride
        {
            get => GetElement<ColorMapOverride>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionListWithModification.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionListWithModification ExtensionListWithModification
        {
            get => GetElement<ExtensionListWithModification>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonSlideData), 1, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ColorMapOverride), 0, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionListWithModification), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesSlide>(deep);

        internal NotesSlide(NotesSlidePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the NotesSlidePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(NotesSlidePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the NotesSlidePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(NotesSlidePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the NotesSlidePart associated with this element.
        /// </summary>
        public NotesSlidePart NotesSlidePart
        {
            get => OpenXmlPart as NotesSlidePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Slide Synchronization Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldSyncPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "sldSyncPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideSyncProperties : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideSyncProperties class.
        /// </summary>
        public SlideSyncProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideSyncProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideSyncProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideSyncProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideSyncProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideSyncProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideSyncProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Server's Slide File ID</para>
        /// <para>Represents the following attribute in the schema: serverSldId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "serverSldId")]
        [Index(0)]
        public StringValue ServerSlideId { get; set; }

        /// <summary>
        /// <para>Server's Slide File's modification date/time</para>
        /// <para>Represents the following attribute in the schema: serverSldModifiedTime</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "serverSldModifiedTime")]
        [Index(1)]
        public DateTimeValue ServerSlideModifiedTime { get; set; }

        /// <summary>
        /// <para>Client Slide Insertion date/time</para>
        /// <para>Represents the following attribute in the schema: clientInsertedTime</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "clientInsertedTime")]
        [Index(2)]
        public DateTimeValue ClientInsertedTime { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideSyncProperties>(deep);

        internal SlideSyncProperties(SlideSyncDataPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the SlideSyncDataPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(SlideSyncDataPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the SlideSyncDataPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(SlideSyncDataPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the SlideSyncDataPart associated with this element.
        /// </summary>
        public SlideSyncDataPart SlideSyncDataPart
        {
            get => OpenXmlPart as SlideSyncDataPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Programmable Tab List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:tagLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Tag &lt;p:tag></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Tag))]
    [SchemaAttr(24, "tagLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TagList : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the TagList class.
        /// </summary>
        public TagList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TagList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TagList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TagList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TagList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TagList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TagList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Tag), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TagList>(deep);

        internal TagList(UserDefinedTagsPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the UserDefinedTagsPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(UserDefinedTagsPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the UserDefinedTagsPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(UserDefinedTagsPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the UserDefinedTagsPart associated with this element.
        /// </summary>
        public UserDefinedTagsPart UserDefinedTagsPart
        {
            get => OpenXmlPart as UserDefinedTagsPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Presentation-wide View Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:viewPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NormalViewProperties &lt;p:normalViewPr></description></item>
    ///   <item><description>SlideViewProperties &lt;p:slideViewPr></description></item>
    ///   <item><description>OutlineViewProperties &lt;p:outlineViewPr></description></item>
    ///   <item><description>NotesTextViewProperties &lt;p:notesTextViewPr></description></item>
    ///   <item><description>SorterViewProperties &lt;p:sorterViewPr></description></item>
    ///   <item><description>NotesViewProperties &lt;p:notesViewPr></description></item>
    ///   <item><description>GridSpacing &lt;p:gridSpacing></description></item>
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NormalViewProperties))]
    [ChildElementInfo(typeof(SlideViewProperties))]
    [ChildElementInfo(typeof(OutlineViewProperties))]
    [ChildElementInfo(typeof(NotesTextViewProperties))]
    [ChildElementInfo(typeof(SorterViewProperties))]
    [ChildElementInfo(typeof(NotesViewProperties))]
    [ChildElementInfo(typeof(GridSpacing))]
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "viewPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ViewProperties : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the ViewProperties class.
        /// </summary>
        public ViewProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ViewProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ViewProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ViewProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ViewProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Last View</para>
        /// <para>Represents the following attribute in the schema: lastView</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "lastView")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.ViewValues> LastView { get; set; }

        /// <summary>
        /// <para>Show Comments</para>
        /// <para>Represents the following attribute in the schema: showComments</para>
        /// </summary>
        [SchemaAttr(0, "showComments")]
        [Index(1)]
        public BooleanValue ShowComments { get; set; }

        /// <summary>
        /// <para>Normal View Properties.</para>
        /// <para>Represents the following element tag in the schema: p:normalViewPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NormalViewProperties NormalViewProperties
        {
            get => GetElement<NormalViewProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Slide View Properties.</para>
        /// <para>Represents the following element tag in the schema: p:slideViewPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SlideViewProperties SlideViewProperties
        {
            get => GetElement<SlideViewProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Outline View Properties.</para>
        /// <para>Represents the following element tag in the schema: p:outlineViewPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public OutlineViewProperties OutlineViewProperties
        {
            get => GetElement<OutlineViewProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Notes Text View Properties.</para>
        /// <para>Represents the following element tag in the schema: p:notesTextViewPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NotesTextViewProperties NotesTextViewProperties
        {
            get => GetElement<NotesTextViewProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Slide Sorter View Properties.</para>
        /// <para>Represents the following element tag in the schema: p:sorterViewPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SorterViewProperties SorterViewProperties
        {
            get => GetElement<SorterViewProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Notes View Properties.</para>
        /// <para>Represents the following element tag in the schema: p:notesViewPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NotesViewProperties NotesViewProperties
        {
            get => GetElement<NotesViewProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Grid Spacing.</para>
        /// <para>Represents the following element tag in the schema: p:gridSpacing.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public GridSpacing GridSpacing
        {
            get => GetElement<GridSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 0, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NormalViewProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideViewProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.OutlineViewProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NotesTextViewProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SorterViewProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NotesViewProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.GridSpacing), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ViewProperties>(deep);

        internal ViewProperties(ViewPropertiesPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the ViewPropertiesPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(ViewPropertiesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the ViewPropertiesPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(ViewPropertiesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the ViewPropertiesPart associated with this element.
        /// </summary>
        public ViewPropertiesPart ViewPropertiesPart
        {
            get => OpenXmlPart as ViewPropertiesPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the ContentPart Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:contentPart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualContentPartProperties &lt;p14:nvContentPartPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.Transform2D &lt;p14:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionListModify &lt;p14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualContentPartProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.Transform2D), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionListModify), FileFormatVersions.Office2010)]
    [SchemaAttr(24, "contentPart")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ContentPart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContentPart class.
        /// </summary>
        public ContentPart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentPart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContentPart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentPart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContentPart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentPart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContentPart(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>bwMode, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: p14:bwMode</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14=http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        [SchemaAttr(49, "bwMode")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BwMode { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(1)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>NonVisualContentPartProperties.</para>
        /// <para>Represents the following element tag in the schema: p14:nvContentPartPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualContentPartProperties NonVisualContentPartProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualContentPartProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Transform2D.</para>
        /// <para>Represents the following element tag in the schema: p14:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.Transform2D Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.Transform2D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionListModify.</para>
        /// <para>Represents the following element tag in the schema: p14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionListModify ExtensionListModify
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionListModify>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualContentPartProperties), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.Transform2D), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionListModify), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContentPart>(deep);
    }

    /// <summary>
    /// <para>Sound.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:snd.</para>
    /// </summary>
    [SchemaAttr(24, "snd")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Sound : EmbeddedWavAudioFileType
    {
        /// <summary>
        /// Initializes a new instance of the Sound class.
        /// </summary>
        public Sound() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Sound>(deep);
    }

    /// <summary>
    /// <para>Sound Target.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sndTgt.</para>
    /// </summary>
    [SchemaAttr(24, "sndTgt")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SoundTarget : EmbeddedWavAudioFileType
    {
        /// <summary>
        /// Initializes a new instance of the SoundTarget class.
        /// </summary>
        public SoundTarget() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SoundTarget>(deep);
    }

    /// <summary>
    /// <para>Defines the EmbeddedWavAudioFileType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class EmbeddedWavAudioFileType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the EmbeddedWavAudioFileType class.
        /// </summary>
        protected EmbeddedWavAudioFileType() : base()
        {
        }

        /// <summary>
        /// <para>Embedded Audio File Relationship ID</para>
        /// <para>Represents the following attribute in the schema: r:embed</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "embed")]
        [Index(0)]
        public StringValue Embed { get; set; }

        /// <summary>
        /// <para>Sound Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr(0, "name")]
        [Index(1)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>Recognized Built-In Sound</para>
        /// <para>Represents the following attribute in the schema: builtIn</para>
        /// </summary>
        [SchemaAttr(0, "builtIn")]
        [Index(2)]
        public BooleanValue BuiltIn { get; set; }
    }

    /// <summary>
    /// <para>Start Sound Action.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:stSnd.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Sound &lt;p:snd></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Sound))]
    [SchemaAttr(24, "stSnd")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class StartSoundAction : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StartSoundAction class.
        /// </summary>
        public StartSoundAction() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StartSoundAction class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StartSoundAction(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StartSoundAction class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StartSoundAction(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StartSoundAction class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StartSoundAction(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Loop Sound</para>
        /// <para>Represents the following attribute in the schema: loop</para>
        /// </summary>
        [SchemaAttr(0, "loop")]
        [Index(0)]
        public BooleanValue Loop { get; set; }

        /// <summary>
        /// <para>Sound.</para>
        /// <para>Represents the following element tag in the schema: p:snd.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Sound Sound
        {
            get => GetElement<Sound>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Sound), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StartSoundAction>(deep);
    }

    /// <summary>
    /// <para>Time Absolute.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:tmAbs.</para>
    /// </summary>
    [SchemaAttr(24, "tmAbs")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TimeAbsolute : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeAbsolute class.
        /// </summary>
        public TimeAbsolute() : base()
        {
        }

        /// <summary>
        /// <para>Time</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(SimpleType = typeof(UInt32Value), Version = FileFormatVersions.Office2007, UnionId = 0)]
        [EnumValidator(SimpleType = typeof(EnumValue<DocumentFormat.OpenXml.Presentation.IndefiniteTimeDeclarationValues>), Version = FileFormatVersions.Office2007, UnionId = 0)]
        [StringValidator(InitialVersion = FileFormatVersions.Office2010, UnionId = 1)]
        [EnumValidator(SimpleType = typeof(EnumValue<DocumentFormat.OpenXml.Presentation.IndefiniteTimeDeclarationValues>), InitialVersion = FileFormatVersions.Office2010, UnionId = 1)]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public StringValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimeAbsolute>(deep);
    }

    /// <summary>
    /// <para>Time Percentage.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:tmPct.</para>
    /// </summary>
    [SchemaAttr(24, "tmPct")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TimePercentage : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimePercentage class.
        /// </summary>
        public TimePercentage() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L)]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public Int32Value Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimePercentage>(deep);
    }

    /// <summary>
    /// <para>Target Element Trigger Choice.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:tgtEl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlideTarget &lt;p:sldTgt></description></item>
    ///   <item><description>SoundTarget &lt;p:sndTgt></description></item>
    ///   <item><description>ShapeTarget &lt;p:spTgt></description></item>
    ///   <item><description>InkTarget &lt;p:inkTgt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.BookmarkTarget &lt;p14:bmkTgt></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlideTarget))]
    [ChildElementInfo(typeof(SoundTarget))]
    [ChildElementInfo(typeof(ShapeTarget))]
    [ChildElementInfo(typeof(InkTarget))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.BookmarkTarget), FileFormatVersions.Office2010)]
    [SchemaAttr(24, "tgtEl")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TargetElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TargetElement class.
        /// </summary>
        public TargetElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TargetElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TargetElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TargetElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TargetElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TargetElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TargetElement(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Slide Target.</para>
        /// <para>Represents the following element tag in the schema: p:sldTgt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SlideTarget SlideTarget
        {
            get => GetElement<SlideTarget>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Sound Target.</para>
        /// <para>Represents the following element tag in the schema: p:sndTgt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SoundTarget SoundTarget
        {
            get => GetElement<SoundTarget>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Target.</para>
        /// <para>Represents the following element tag in the schema: p:spTgt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ShapeTarget ShapeTarget
        {
            get => GetElement<ShapeTarget>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Ink Target.</para>
        /// <para>Represents the following element tag in the schema: p:inkTgt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public InkTarget InkTarget
        {
            get => GetElement<InkTarget>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BookmarkTarget.</para>
        /// <para>Represents the following element tag in the schema: p14:bmkTgt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.BookmarkTarget BookmarkTarget
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.BookmarkTarget>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideTarget), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SoundTarget), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ShapeTarget), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.InkTarget), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.BookmarkTarget), 1, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TargetElement>(deep);
    }

    /// <summary>
    /// <para>Time Node.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:tn.</para>
    /// </summary>
    [SchemaAttr(24, "tn")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TimeNode : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeNode class.
        /// </summary>
        public TimeNode() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public UInt32Value Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimeNode>(deep);
    }

    /// <summary>
    /// <para>Runtime Node Trigger Choice.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:rtn.</para>
    /// </summary>
    [SchemaAttr(24, "rtn")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class RuntimeNodeTrigger : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RuntimeNodeTrigger class.
        /// </summary>
        public RuntimeNodeTrigger() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TriggerRuntimeNodeValues> Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RuntimeNodeTrigger>(deep);
    }

    /// <summary>
    /// <para>Condition.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cond.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TargetElement &lt;p:tgtEl></description></item>
    ///   <item><description>TimeNode &lt;p:tn></description></item>
    ///   <item><description>RuntimeNodeTrigger &lt;p:rtn></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "cond")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Condition : TimeListConditionalType
    {
        /// <summary>
        /// Initializes a new instance of the Condition class.
        /// </summary>
        public Condition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Condition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Condition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Condition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Condition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Condition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Condition(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 0, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TargetElement), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TimeNode), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.RuntimeNodeTrigger), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Condition>(deep);
    }

    /// <summary>
    /// <para>Defines the EndSync Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:endSync.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TargetElement &lt;p:tgtEl></description></item>
    ///   <item><description>TimeNode &lt;p:tn></description></item>
    ///   <item><description>RuntimeNodeTrigger &lt;p:rtn></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "endSync")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class EndSync : TimeListConditionalType
    {
        /// <summary>
        /// Initializes a new instance of the EndSync class.
        /// </summary>
        public EndSync() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndSync class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EndSync(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndSync class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EndSync(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndSync class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EndSync(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 0, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TargetElement), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TimeNode), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.RuntimeNodeTrigger), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndSync>(deep);
    }

    /// <summary>
    /// <para>Defines the TimeListConditionalType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TargetElement &lt;p:tgtEl></description></item>
    ///   <item><description>TimeNode &lt;p:tn></description></item>
    ///   <item><description>RuntimeNodeTrigger &lt;p:rtn></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TargetElement))]
    [ChildElementInfo(typeof(TimeNode))]
    [ChildElementInfo(typeof(RuntimeNodeTrigger))]
    public abstract partial class TimeListConditionalType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeListConditionalType class.
        /// </summary>
        protected TimeListConditionalType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeListConditionalType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TimeListConditionalType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeListConditionalType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TimeListConditionalType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeListConditionalType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected TimeListConditionalType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Trigger Event</para>
        /// <para>Represents the following attribute in the schema: evt</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "evt")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TriggerEventValues> Event { get; set; }

        /// <summary>
        /// <para>Trigger Delay</para>
        /// <para>Represents the following attribute in the schema: delay</para>
        /// </summary>
        [NumberValidator(SimpleType = typeof(UInt32Value), Version = FileFormatVersions.Office2007, UnionId = 0)]
        [EnumValidator(SimpleType = typeof(EnumValue<DocumentFormat.OpenXml.Presentation.IndefiniteTimeDeclarationValues>), Version = FileFormatVersions.Office2007, UnionId = 0)]
        [StringValidator(InitialVersion = FileFormatVersions.Office2010, UnionId = 1)]
        [EnumValidator(SimpleType = typeof(EnumValue<DocumentFormat.OpenXml.Presentation.IndefiniteTimeDeclarationValues>), InitialVersion = FileFormatVersions.Office2010, UnionId = 1)]
        [SchemaAttr(0, "delay")]
        [Index(1)]
        public StringValue Delay { get; set; }

        /// <summary>
        /// <para>Target Element Trigger Choice.</para>
        /// <para>Represents the following element tag in the schema: p:tgtEl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TargetElement TargetElement
        {
            get => GetElement<TargetElement>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Time Node.</para>
        /// <para>Represents the following element tag in the schema: p:tn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TimeNode TimeNode
        {
            get => GetElement<TimeNode>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Runtime Node Trigger Choice.</para>
        /// <para>Represents the following element tag in the schema: p:rtn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public RuntimeNodeTrigger RuntimeNodeTrigger
        {
            get => GetElement<RuntimeNodeTrigger>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    }

    /// <summary>
    /// <para>Parallel Time Node.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:par.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonTimeNode &lt;p:cTn></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonTimeNode))]
    [SchemaAttr(24, "par")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ParallelTimeNode : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ParallelTimeNode class.
        /// </summary>
        public ParallelTimeNode() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ParallelTimeNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ParallelTimeNode(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ParallelTimeNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ParallelTimeNode(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ParallelTimeNode class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ParallelTimeNode(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Parallel TimeNode.</para>
        /// <para>Represents the following element tag in the schema: p:cTn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonTimeNode CommonTimeNode
        {
            get => GetElement<CommonTimeNode>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonTimeNode), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ParallelTimeNode>(deep);
    }

    /// <summary>
    /// <para>Sequence Time Node.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:seq.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonTimeNode &lt;p:cTn></description></item>
    ///   <item><description>PreviousConditionList &lt;p:prevCondLst></description></item>
    ///   <item><description>NextConditionList &lt;p:nextCondLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonTimeNode))]
    [ChildElementInfo(typeof(PreviousConditionList))]
    [ChildElementInfo(typeof(NextConditionList))]
    [SchemaAttr(24, "seq")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SequenceTimeNode : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SequenceTimeNode class.
        /// </summary>
        public SequenceTimeNode() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SequenceTimeNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SequenceTimeNode(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SequenceTimeNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SequenceTimeNode(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SequenceTimeNode class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SequenceTimeNode(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Concurrent</para>
        /// <para>Represents the following attribute in the schema: concurrent</para>
        /// </summary>
        [SchemaAttr(0, "concurrent")]
        [Index(0)]
        public BooleanValue Concurrent { get; set; }

        /// <summary>
        /// <para>Previous Action</para>
        /// <para>Represents the following attribute in the schema: prevAc</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "prevAc")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.PreviousActionValues> PreviousAction { get; set; }

        /// <summary>
        /// <para>Next Action</para>
        /// <para>Represents the following attribute in the schema: nextAc</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "nextAc")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.NextActionValues> NextAction { get; set; }

        /// <summary>
        /// <para>Common TimeNode Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cTn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonTimeNode CommonTimeNode
        {
            get => GetElement<CommonTimeNode>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Previous Conditions List.</para>
        /// <para>Represents the following element tag in the schema: p:prevCondLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public PreviousConditionList PreviousConditionList
        {
            get => GetElement<PreviousConditionList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Next Conditions List.</para>
        /// <para>Represents the following element tag in the schema: p:nextCondLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NextConditionList NextConditionList
        {
            get => GetElement<NextConditionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonTimeNode), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PreviousConditionList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NextConditionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SequenceTimeNode>(deep);
    }

    /// <summary>
    /// <para>Exclusive.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:excl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonTimeNode &lt;p:cTn></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonTimeNode))]
    [SchemaAttr(24, "excl")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ExclusiveTimeNode : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExclusiveTimeNode class.
        /// </summary>
        public ExclusiveTimeNode() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExclusiveTimeNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExclusiveTimeNode(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExclusiveTimeNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExclusiveTimeNode(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExclusiveTimeNode class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExclusiveTimeNode(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Common TimeNode Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cTn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonTimeNode CommonTimeNode
        {
            get => GetElement<CommonTimeNode>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonTimeNode), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExclusiveTimeNode>(deep);
    }

    /// <summary>
    /// <para>Animate.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:anim.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonBehavior &lt;p:cBhvr></description></item>
    ///   <item><description>TimeAnimateValueList &lt;p:tavLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonBehavior))]
    [ChildElementInfo(typeof(TimeAnimateValueList))]
    [SchemaAttr(24, "anim")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Animate : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Animate class.
        /// </summary>
        public Animate() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Animate class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Animate(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Animate class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Animate(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Animate class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Animate(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>by</para>
        /// <para>Represents the following attribute in the schema: by</para>
        /// </summary>
        [SchemaAttr(0, "by")]
        [Index(0)]
        public StringValue By { get; set; }

        /// <summary>
        /// <para>from</para>
        /// <para>Represents the following attribute in the schema: from</para>
        /// </summary>
        [SchemaAttr(0, "from")]
        [Index(1)]
        public StringValue From { get; set; }

        /// <summary>
        /// <para>to</para>
        /// <para>Represents the following attribute in the schema: to</para>
        /// </summary>
        [SchemaAttr(0, "to")]
        [Index(2)]
        public StringValue To { get; set; }

        /// <summary>
        /// <para>calcmode</para>
        /// <para>Represents the following attribute in the schema: calcmode</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "calcmode")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.AnimateBehaviorCalculateModeValues> CalculationMode { get; set; }

        /// <summary>
        /// <para>valueType</para>
        /// <para>Represents the following attribute in the schema: valueType</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "valueType")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.AnimateBehaviorValues> ValueType { get; set; }

        /// <summary>
        /// <para>bounceEnd, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: p14:bounceEnd</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14=http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(49, "bounceEnd")]
        [Index(5)]
        public Int32Value BounceEnd { get; set; }

        /// <summary>
        /// <para>CommonBehavior.</para>
        /// <para>Represents the following element tag in the schema: p:cBhvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonBehavior CommonBehavior
        {
            get => GetElement<CommonBehavior>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TimeAnimateValueList.</para>
        /// <para>Represents the following element tag in the schema: p:tavLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TimeAnimateValueList TimeAnimateValueList
        {
            get => GetElement<TimeAnimateValueList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonBehavior), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TimeAnimateValueList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Animate>(deep);
    }

    /// <summary>
    /// <para>Animate Color Behavior.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:animClr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonBehavior &lt;p:cBhvr></description></item>
    ///   <item><description>ByColor &lt;p:by></description></item>
    ///   <item><description>FromColor &lt;p:from></description></item>
    ///   <item><description>ToColor &lt;p:to></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonBehavior))]
    [ChildElementInfo(typeof(ByColor))]
    [ChildElementInfo(typeof(FromColor))]
    [ChildElementInfo(typeof(ToColor))]
    [SchemaAttr(24, "animClr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class AnimateColor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimateColor class.
        /// </summary>
        public AnimateColor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimateColor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimateColor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateColor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AnimateColor(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Color Space</para>
        /// <para>Represents the following attribute in the schema: clrSpc</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "clrSpc")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.AnimateColorSpaceValues> ColorSpace { get; set; }

        /// <summary>
        /// <para>Direction</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "dir")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.AnimateColorDirectionValues> Direction { get; set; }

        /// <summary>
        /// <para>CommonBehavior.</para>
        /// <para>Represents the following element tag in the schema: p:cBhvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonBehavior CommonBehavior
        {
            get => GetElement<CommonBehavior>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>By.</para>
        /// <para>Represents the following element tag in the schema: p:by.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ByColor ByColor
        {
            get => GetElement<ByColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>From.</para>
        /// <para>Represents the following element tag in the schema: p:from.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public FromColor FromColor
        {
            get => GetElement<FromColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>To.</para>
        /// <para>Represents the following element tag in the schema: p:to.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ToColor ToColor
        {
            get => GetElement<ToColor>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonBehavior), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ByColor), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.FromColor), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ToColor), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimateColor>(deep);
    }

    /// <summary>
    /// <para>Animate Effect.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:animEffect.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonBehavior &lt;p:cBhvr></description></item>
    ///   <item><description>Progress &lt;p:progress></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonBehavior))]
    [ChildElementInfo(typeof(Progress))]
    [SchemaAttr(24, "animEffect")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class AnimateEffect : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimateEffect class.
        /// </summary>
        public AnimateEffect() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateEffect class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimateEffect(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateEffect class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimateEffect(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateEffect class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AnimateEffect(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Transition</para>
        /// <para>Represents the following attribute in the schema: transition</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "transition")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.AnimateEffectTransitionValues> Transition { get; set; }

        /// <summary>
        /// <para>Filter</para>
        /// <para>Represents the following attribute in the schema: filter</para>
        /// </summary>
        [SchemaAttr(0, "filter")]
        [Index(1)]
        public StringValue Filter { get; set; }

        /// <summary>
        /// <para>Property List</para>
        /// <para>Represents the following attribute in the schema: prLst</para>
        /// </summary>
        [SchemaAttr(0, "prLst")]
        [Index(2)]
        public StringValue PropertyList { get; set; }

        /// <summary>
        /// <para>CommonBehavior.</para>
        /// <para>Represents the following element tag in the schema: p:cBhvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonBehavior CommonBehavior
        {
            get => GetElement<CommonBehavior>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Progress.</para>
        /// <para>Represents the following element tag in the schema: p:progress.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Progress Progress
        {
            get => GetElement<Progress>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonBehavior), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Progress), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimateEffect>(deep);
    }

    /// <summary>
    /// <para>Animate Motion.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:animMotion.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonBehavior &lt;p:cBhvr></description></item>
    ///   <item><description>ByPosition &lt;p:by></description></item>
    ///   <item><description>FromPosition &lt;p:from></description></item>
    ///   <item><description>ToPosition &lt;p:to></description></item>
    ///   <item><description>RotationCenter &lt;p:rCtr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonBehavior))]
    [ChildElementInfo(typeof(ByPosition))]
    [ChildElementInfo(typeof(FromPosition))]
    [ChildElementInfo(typeof(ToPosition))]
    [ChildElementInfo(typeof(RotationCenter))]
    [SchemaAttr(24, "animMotion")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class AnimateMotion : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimateMotion class.
        /// </summary>
        public AnimateMotion() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateMotion class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimateMotion(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateMotion class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimateMotion(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateMotion class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AnimateMotion(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>origin</para>
        /// <para>Represents the following attribute in the schema: origin</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "origin")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.AnimateMotionBehaviorOriginValues> Origin { get; set; }

        /// <summary>
        /// <para>path</para>
        /// <para>Represents the following attribute in the schema: path</para>
        /// </summary>
        [SchemaAttr(0, "path")]
        [Index(1)]
        public StringValue Path { get; set; }

        /// <summary>
        /// <para>pathEditMode</para>
        /// <para>Represents the following attribute in the schema: pathEditMode</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "pathEditMode")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.AnimateMotionPathEditModeValues> PathEditMode { get; set; }

        /// <summary>
        /// <para>rAng</para>
        /// <para>Represents the following attribute in the schema: rAng</para>
        /// </summary>
        [SchemaAttr(0, "rAng")]
        [Index(3)]
        public Int32Value RelativeAngle { get; set; }

        /// <summary>
        /// <para>ptsTypes</para>
        /// <para>Represents the following attribute in the schema: ptsTypes</para>
        /// </summary>
        [SchemaAttr(0, "ptsTypes")]
        [Index(4)]
        public StringValue PointTypes { get; set; }

        /// <summary>
        /// <para>bounceEnd, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: p14:bounceEnd</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14=http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(49, "bounceEnd")]
        [Index(5)]
        public Int32Value BounceEnd { get; set; }

        /// <summary>
        /// <para>CommonBehavior.</para>
        /// <para>Represents the following element tag in the schema: p:cBhvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonBehavior CommonBehavior
        {
            get => GetElement<CommonBehavior>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ByPosition.</para>
        /// <para>Represents the following element tag in the schema: p:by.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ByPosition ByPosition
        {
            get => GetElement<ByPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FromPosition.</para>
        /// <para>Represents the following element tag in the schema: p:from.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public FromPosition FromPosition
        {
            get => GetElement<FromPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ToPosition.</para>
        /// <para>Represents the following element tag in the schema: p:to.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ToPosition ToPosition
        {
            get => GetElement<ToPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RotationCenter.</para>
        /// <para>Represents the following element tag in the schema: p:rCtr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public RotationCenter RotationCenter
        {
            get => GetElement<RotationCenter>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonBehavior), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ByPosition), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.FromPosition), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ToPosition), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.RotationCenter), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimateMotion>(deep);
    }

    /// <summary>
    /// <para>Animate Rotation.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:animRot.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonBehavior &lt;p:cBhvr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonBehavior))]
    [SchemaAttr(24, "animRot")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class AnimateRotation : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimateRotation class.
        /// </summary>
        public AnimateRotation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateRotation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimateRotation(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateRotation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimateRotation(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateRotation class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AnimateRotation(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>by</para>
        /// <para>Represents the following attribute in the schema: by</para>
        /// </summary>
        [SchemaAttr(0, "by")]
        [Index(0)]
        public Int32Value By { get; set; }

        /// <summary>
        /// <para>from</para>
        /// <para>Represents the following attribute in the schema: from</para>
        /// </summary>
        [SchemaAttr(0, "from")]
        [Index(1)]
        public Int32Value From { get; set; }

        /// <summary>
        /// <para>to</para>
        /// <para>Represents the following attribute in the schema: to</para>
        /// </summary>
        [SchemaAttr(0, "to")]
        [Index(2)]
        public Int32Value To { get; set; }

        /// <summary>
        /// <para>bounceEnd, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: p14:bounceEnd</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14=http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(49, "bounceEnd")]
        [Index(3)]
        public Int32Value BounceEnd { get; set; }

        /// <summary>
        /// <para>CommonBehavior.</para>
        /// <para>Represents the following element tag in the schema: p:cBhvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonBehavior CommonBehavior
        {
            get => GetElement<CommonBehavior>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonBehavior), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimateRotation>(deep);
    }

    /// <summary>
    /// <para>Animate Scale.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:animScale.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonBehavior &lt;p:cBhvr></description></item>
    ///   <item><description>ByPosition &lt;p:by></description></item>
    ///   <item><description>FromPosition &lt;p:from></description></item>
    ///   <item><description>ToPosition &lt;p:to></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonBehavior))]
    [ChildElementInfo(typeof(ByPosition))]
    [ChildElementInfo(typeof(FromPosition))]
    [ChildElementInfo(typeof(ToPosition))]
    [SchemaAttr(24, "animScale")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class AnimateScale : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimateScale class.
        /// </summary>
        public AnimateScale() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateScale class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimateScale(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateScale class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimateScale(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimateScale class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AnimateScale(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>zoomContents</para>
        /// <para>Represents the following attribute in the schema: zoomContents</para>
        /// </summary>
        [SchemaAttr(0, "zoomContents")]
        [Index(0)]
        public BooleanValue ZoomContents { get; set; }

        /// <summary>
        /// <para>bounceEnd, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: p14:bounceEnd</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14=http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(49, "bounceEnd")]
        [Index(1)]
        public Int32Value BounceEnd { get; set; }

        /// <summary>
        /// <para>CommonBehavior.</para>
        /// <para>Represents the following element tag in the schema: p:cBhvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonBehavior CommonBehavior
        {
            get => GetElement<CommonBehavior>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ByPosition.</para>
        /// <para>Represents the following element tag in the schema: p:by.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ByPosition ByPosition
        {
            get => GetElement<ByPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FromPosition.</para>
        /// <para>Represents the following element tag in the schema: p:from.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public FromPosition FromPosition
        {
            get => GetElement<FromPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ToPosition.</para>
        /// <para>Represents the following element tag in the schema: p:to.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ToPosition ToPosition
        {
            get => GetElement<ToPosition>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonBehavior), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ByPosition), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.FromPosition), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ToPosition), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimateScale>(deep);
    }

    /// <summary>
    /// <para>Command.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cmd.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonBehavior &lt;p:cBhvr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonBehavior))]
    [SchemaAttr(24, "cmd")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Command : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Command class.
        /// </summary>
        public Command() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Command class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Command(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Command class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Command(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Command class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Command(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Command Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "type")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.CommandValues> Type { get; set; }

        /// <summary>
        /// <para>Command</para>
        /// <para>Represents the following attribute in the schema: cmd</para>
        /// </summary>
        [SchemaAttr(0, "cmd")]
        [Index(1)]
        public StringValue CommandName { get; set; }

        /// <summary>
        /// <para>CommonBehavior.</para>
        /// <para>Represents the following element tag in the schema: p:cBhvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonBehavior CommonBehavior
        {
            get => GetElement<CommonBehavior>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonBehavior), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Command>(deep);
    }

    /// <summary>
    /// <para>Set Time Node Behavior.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:set.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonBehavior &lt;p:cBhvr></description></item>
    ///   <item><description>ToVariantValue &lt;p:to></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonBehavior))]
    [ChildElementInfo(typeof(ToVariantValue))]
    [SchemaAttr(24, "set")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SetBehavior : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SetBehavior class.
        /// </summary>
        public SetBehavior() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SetBehavior class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SetBehavior(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SetBehavior class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SetBehavior(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SetBehavior class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SetBehavior(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Common Behavior.</para>
        /// <para>Represents the following element tag in the schema: p:cBhvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonBehavior CommonBehavior
        {
            get => GetElement<CommonBehavior>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>To.</para>
        /// <para>Represents the following element tag in the schema: p:to.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ToVariantValue ToVariantValue
        {
            get => GetElement<ToVariantValue>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonBehavior), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ToVariantValue), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SetBehavior>(deep);
    }

    /// <summary>
    /// <para>Audio.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:audio.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonMediaNode &lt;p:cMediaNode></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonMediaNode))]
    [SchemaAttr(24, "audio")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Audio : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Audio class.
        /// </summary>
        public Audio() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Audio class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Audio(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Audio class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Audio(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Audio class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Audio(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Is Narration</para>
        /// <para>Represents the following attribute in the schema: isNarration</para>
        /// </summary>
        [SchemaAttr(0, "isNarration")]
        [Index(0)]
        public BooleanValue IsNarration { get; set; }

        /// <summary>
        /// <para>Common Media Node Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cMediaNode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonMediaNode CommonMediaNode
        {
            get => GetElement<CommonMediaNode>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonMediaNode), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Audio>(deep);
    }

    /// <summary>
    /// <para>Video.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:video.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonMediaNode &lt;p:cMediaNode></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonMediaNode))]
    [SchemaAttr(24, "video")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Video : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Video class.
        /// </summary>
        public Video() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Video class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Video(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Video class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Video(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Video class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Video(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Full Screen</para>
        /// <para>Represents the following attribute in the schema: fullScrn</para>
        /// </summary>
        [SchemaAttr(0, "fullScrn")]
        [Index(0)]
        public BooleanValue FullScreen { get; set; }

        /// <summary>
        /// <para>Common Media Node Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cMediaNode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonMediaNode CommonMediaNode
        {
            get => GetElement<CommonMediaNode>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonMediaNode), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Video>(deep);
    }

    /// <summary>
    /// <para>Parallel TimeNode.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cTn.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StartConditionList &lt;p:stCondLst></description></item>
    ///   <item><description>EndConditionList &lt;p:endCondLst></description></item>
    ///   <item><description>EndSync &lt;p:endSync></description></item>
    ///   <item><description>Iterate &lt;p:iterate></description></item>
    ///   <item><description>ChildTimeNodeList &lt;p:childTnLst></description></item>
    ///   <item><description>SubTimeNodeList &lt;p:subTnLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(StartConditionList))]
    [ChildElementInfo(typeof(EndConditionList))]
    [ChildElementInfo(typeof(EndSync))]
    [ChildElementInfo(typeof(Iterate))]
    [ChildElementInfo(typeof(ChildTimeNodeList))]
    [ChildElementInfo(typeof(SubTimeNodeList))]
    [SchemaAttr(24, "cTn")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommonTimeNode : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommonTimeNode class.
        /// </summary>
        public CommonTimeNode() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonTimeNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonTimeNode(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonTimeNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonTimeNode(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonTimeNode class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommonTimeNode(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr(0, "id")]
        [Index(0)]
        public UInt32Value Id { get; set; }

        /// <summary>
        /// <para>presetID</para>
        /// <para>Represents the following attribute in the schema: presetID</para>
        /// </summary>
        [SchemaAttr(0, "presetID")]
        [Index(1)]
        public Int32Value PresetId { get; set; }

        /// <summary>
        /// <para>presetClass</para>
        /// <para>Represents the following attribute in the schema: presetClass</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "presetClass")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TimeNodePresetClassValues> PresetClass { get; set; }

        /// <summary>
        /// <para>presetSubtype</para>
        /// <para>Represents the following attribute in the schema: presetSubtype</para>
        /// </summary>
        [SchemaAttr(0, "presetSubtype")]
        [Index(3)]
        public Int32Value PresetSubtype { get; set; }

        /// <summary>
        /// <para>dur</para>
        /// <para>Represents the following attribute in the schema: dur</para>
        /// </summary>
        [SchemaAttr(0, "dur")]
        [Index(4)]
        public StringValue Duration { get; set; }

        /// <summary>
        /// <para>repeatCount</para>
        /// <para>Represents the following attribute in the schema: repeatCount</para>
        /// </summary>
        [SchemaAttr(0, "repeatCount")]
        [Index(5)]
        public StringValue RepeatCount { get; set; }

        /// <summary>
        /// <para>repeatDur</para>
        /// <para>Represents the following attribute in the schema: repeatDur</para>
        /// </summary>
        [SchemaAttr(0, "repeatDur")]
        [Index(6)]
        public StringValue RepeatDuration { get; set; }

        /// <summary>
        /// <para>spd</para>
        /// <para>Represents the following attribute in the schema: spd</para>
        /// </summary>
        [SchemaAttr(0, "spd")]
        [Index(7)]
        public Int32Value Speed { get; set; }

        /// <summary>
        /// <para>accel</para>
        /// <para>Represents the following attribute in the schema: accel</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "accel")]
        [Index(8)]
        public Int32Value Acceleration { get; set; }

        /// <summary>
        /// <para>decel</para>
        /// <para>Represents the following attribute in the schema: decel</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "decel")]
        [Index(9)]
        public Int32Value Deceleration { get; set; }

        /// <summary>
        /// <para>autoRev</para>
        /// <para>Represents the following attribute in the schema: autoRev</para>
        /// </summary>
        [SchemaAttr(0, "autoRev")]
        [Index(10)]
        public BooleanValue AutoReverse { get; set; }

        /// <summary>
        /// <para>restart</para>
        /// <para>Represents the following attribute in the schema: restart</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "restart")]
        [Index(11)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TimeNodeRestartValues> Restart { get; set; }

        /// <summary>
        /// <para>fill</para>
        /// <para>Represents the following attribute in the schema: fill</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "fill")]
        [Index(12)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TimeNodeFillValues> Fill { get; set; }

        /// <summary>
        /// <para>syncBehavior</para>
        /// <para>Represents the following attribute in the schema: syncBehavior</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "syncBehavior")]
        [Index(13)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TimeNodeSyncValues> SyncBehavior { get; set; }

        /// <summary>
        /// <para>tmFilter</para>
        /// <para>Represents the following attribute in the schema: tmFilter</para>
        /// </summary>
        [SchemaAttr(0, "tmFilter")]
        [Index(14)]
        public StringValue TimeFilter { get; set; }

        /// <summary>
        /// <para>evtFilter</para>
        /// <para>Represents the following attribute in the schema: evtFilter</para>
        /// </summary>
        [SchemaAttr(0, "evtFilter")]
        [Index(15)]
        public StringValue EventFilter { get; set; }

        /// <summary>
        /// <para>display</para>
        /// <para>Represents the following attribute in the schema: display</para>
        /// </summary>
        [SchemaAttr(0, "display")]
        [Index(16)]
        public BooleanValue Display { get; set; }

        /// <summary>
        /// <para>masterRel</para>
        /// <para>Represents the following attribute in the schema: masterRel</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "masterRel")]
        [Index(17)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TimeNodeMasterRelationValues> MasterRelation { get; set; }

        /// <summary>
        /// <para>bldLvl</para>
        /// <para>Represents the following attribute in the schema: bldLvl</para>
        /// </summary>
        [SchemaAttr(0, "bldLvl")]
        [Index(18)]
        public Int32Value BuildLevel { get; set; }

        /// <summary>
        /// <para>grpId</para>
        /// <para>Represents the following attribute in the schema: grpId</para>
        /// </summary>
        [SchemaAttr(0, "grpId")]
        [Index(19)]
        public UInt32Value GroupId { get; set; }

        /// <summary>
        /// <para>afterEffect</para>
        /// <para>Represents the following attribute in the schema: afterEffect</para>
        /// </summary>
        [SchemaAttr(0, "afterEffect")]
        [Index(20)]
        public BooleanValue AfterEffect { get; set; }

        /// <summary>
        /// <para>nodeType</para>
        /// <para>Represents the following attribute in the schema: nodeType</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "nodeType")]
        [Index(21)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TimeNodeValues> NodeType { get; set; }

        /// <summary>
        /// <para>nodePh</para>
        /// <para>Represents the following attribute in the schema: nodePh</para>
        /// </summary>
        [SchemaAttr(0, "nodePh")]
        [Index(22)]
        public BooleanValue NodePlaceholder { get; set; }

        /// <summary>
        /// <para>presetBounceEnd, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: p14:presetBounceEnd</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14=http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(49, "presetBounceEnd")]
        [Index(23)]
        public Int32Value PresetBounceEnd { get; set; }

        /// <summary>
        /// <para>StartConditionList.</para>
        /// <para>Represents the following element tag in the schema: p:stCondLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public StartConditionList StartConditionList
        {
            get => GetElement<StartConditionList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EndConditionList.</para>
        /// <para>Represents the following element tag in the schema: p:endCondLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public EndConditionList EndConditionList
        {
            get => GetElement<EndConditionList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EndSync.</para>
        /// <para>Represents the following element tag in the schema: p:endSync.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public EndSync EndSync
        {
            get => GetElement<EndSync>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Iterate.</para>
        /// <para>Represents the following element tag in the schema: p:iterate.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Iterate Iterate
        {
            get => GetElement<Iterate>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChildTimeNodeList.</para>
        /// <para>Represents the following element tag in the schema: p:childTnLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ChildTimeNodeList ChildTimeNodeList
        {
            get => GetElement<ChildTimeNodeList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SubTimeNodeList.</para>
        /// <para>Represents the following element tag in the schema: p:subTnLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SubTimeNodeList SubTimeNodeList
        {
            get => GetElement<SubTimeNodeList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.StartConditionList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.EndConditionList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.EndSync), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Iterate), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ChildTimeNodeList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SubTimeNodeList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommonTimeNode>(deep);
    }

    /// <summary>
    /// <para>Previous Conditions List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:prevCondLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Condition &lt;p:cond></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "prevCondLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PreviousConditionList : TimeListTimeConditionalListType
    {
        /// <summary>
        /// Initializes a new instance of the PreviousConditionList class.
        /// </summary>
        public PreviousConditionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreviousConditionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PreviousConditionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreviousConditionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PreviousConditionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreviousConditionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PreviousConditionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Condition), 1, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreviousConditionList>(deep);
    }

    /// <summary>
    /// <para>Next Conditions List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:nextCondLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Condition &lt;p:cond></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "nextCondLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NextConditionList : TimeListTimeConditionalListType
    {
        /// <summary>
        /// Initializes a new instance of the NextConditionList class.
        /// </summary>
        public NextConditionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NextConditionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NextConditionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NextConditionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NextConditionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NextConditionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NextConditionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Condition), 1, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NextConditionList>(deep);
    }

    /// <summary>
    /// <para>Defines the StartConditionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:stCondLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Condition &lt;p:cond></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "stCondLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class StartConditionList : TimeListTimeConditionalListType
    {
        /// <summary>
        /// Initializes a new instance of the StartConditionList class.
        /// </summary>
        public StartConditionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StartConditionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StartConditionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StartConditionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StartConditionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StartConditionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StartConditionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Condition), 1, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StartConditionList>(deep);
    }

    /// <summary>
    /// <para>Defines the EndConditionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:endCondLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Condition &lt;p:cond></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "endCondLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class EndConditionList : TimeListTimeConditionalListType
    {
        /// <summary>
        /// Initializes a new instance of the EndConditionList class.
        /// </summary>
        public EndConditionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndConditionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EndConditionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndConditionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EndConditionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndConditionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EndConditionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Condition), 1, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndConditionList>(deep);
    }

    /// <summary>
    /// <para>Defines the TimeListTimeConditionalListType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Condition &lt;p:cond></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Condition))]
    public abstract partial class TimeListTimeConditionalListType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeListTimeConditionalListType class.
        /// </summary>
        protected TimeListTimeConditionalListType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeListTimeConditionalListType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TimeListTimeConditionalListType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeListTimeConditionalListType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TimeListTimeConditionalListType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeListTimeConditionalListType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected TimeListTimeConditionalListType(string outerXml) : base(outerXml)
        {
        }
    }

    /// <summary>
    /// <para>Attribute Name.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:attrName.</para>
    /// </summary>
    [SchemaAttr(24, "attrName")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class AttributeName : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the AttributeName class.
        /// </summary>
        public AttributeName() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AttributeName class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public AttributeName(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AttributeName>(deep);
    }

    /// <summary>
    /// <para>Defines the Text Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:text.</para>
    /// </summary>
    [SchemaAttr(24, "text")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Text : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Text class.
        /// </summary>
        public Text() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Text class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Text(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Text>(deep);
    }

    /// <summary>
    /// <para>Attribute Name List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:attrNameLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AttributeName &lt;p:attrName></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(AttributeName))]
    [SchemaAttr(24, "attrNameLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class AttributeNameList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AttributeNameList class.
        /// </summary>
        public AttributeNameList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AttributeNameList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AttributeNameList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AttributeNameList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AttributeNameList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AttributeNameList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AttributeNameList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.AttributeName), 1, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AttributeNameList>(deep);
    }

    /// <summary>
    /// <para>Boolean Variant.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:boolVal.</para>
    /// </summary>
    [SchemaAttr(24, "boolVal")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BooleanVariantValue : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BooleanVariantValue class.
        /// </summary>
        public BooleanVariantValue() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public BooleanValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BooleanVariantValue>(deep);
    }

    /// <summary>
    /// <para>Integer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:intVal.</para>
    /// </summary>
    [SchemaAttr(24, "intVal")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class IntegerVariantValue : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the IntegerVariantValue class.
        /// </summary>
        public IntegerVariantValue() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public Int32Value Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IntegerVariantValue>(deep);
    }

    /// <summary>
    /// <para>Float Value.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:fltVal.</para>
    /// </summary>
    [SchemaAttr(24, "fltVal")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class FloatVariantValue : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FloatVariantValue class.
        /// </summary>
        public FloatVariantValue() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public SingleValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FloatVariantValue>(deep);
    }

    /// <summary>
    /// <para>String Value.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:strVal.</para>
    /// </summary>
    [SchemaAttr(24, "strVal")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class StringVariantValue : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the StringVariantValue class.
        /// </summary>
        public StringVariantValue() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public StringValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringVariantValue>(deep);
    }

    /// <summary>
    /// <para>Color Value.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:clrVal.</para>
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
    [SchemaAttr(24, "clrVal")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ColorValue : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the ColorValue class.
        /// </summary>
        public ColorValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorValue class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorValue(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorValue class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorValue(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorValue class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorValue(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorValue>(deep);
    }

    /// <summary>
    /// <para>Pen Color for Slide Show.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:penClr.</para>
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
    [SchemaAttr(24, "penClr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PenColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the PenColor class.
        /// </summary>
        public PenColor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PenColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PenColor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PenColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PenColor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PenColor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PenColor(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PenColor>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
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
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HslColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SystemColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetColor))]
    public abstract partial class ColorType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorType class.
        /// </summary>
        protected ColorType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ColorType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ColorType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected ColorType(string outerXml) : base(outerXml)
        {
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

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    }

    /// <summary>
    /// <para>Time Animate Value.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:tav.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>VariantValue &lt;p:val></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(VariantValue))]
    [SchemaAttr(24, "tav")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TimeAnimateValue : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeAnimateValue class.
        /// </summary>
        public TimeAnimateValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeAnimateValue class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimeAnimateValue(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeAnimateValue class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimeAnimateValue(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeAnimateValue class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimeAnimateValue(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Time</para>
        /// <para>Represents the following attribute in the schema: tm</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L, SimpleType = typeof(Int32Value), UnionId = 0)]
        [EnumValidator(SimpleType = typeof(EnumValue<DocumentFormat.OpenXml.Presentation.IndefiniteTimeDeclarationValues>), UnionId = 0)]
        [SchemaAttr(0, "tm")]
        [Index(0)]
        public StringValue Time { get; set; }

        /// <summary>
        /// <para>Formula</para>
        /// <para>Represents the following attribute in the schema: fmla</para>
        /// </summary>
        [SchemaAttr(0, "fmla")]
        [Index(1)]
        public StringValue Fomula { get; set; }

        /// <summary>
        /// <para>Value.</para>
        /// <para>Represents the following element tag in the schema: p:val.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public VariantValue VariantValue
        {
            get => GetElement<VariantValue>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.VariantValue), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimeAnimateValue>(deep);
    }

    /// <summary>
    /// <para>RGB.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:rgb.</para>
    /// </summary>
    [SchemaAttr(24, "rgb")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class RgbColor : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RgbColor class.
        /// </summary>
        public RgbColor() : base()
        {
        }

        /// <summary>
        /// <para>Red</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = -100000L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "r")]
        [Index(0)]
        public Int32Value Red { get; set; }

        /// <summary>
        /// <para>Green</para>
        /// <para>Represents the following attribute in the schema: g</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = -100000L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "g")]
        [Index(1)]
        public Int32Value Green { get; set; }

        /// <summary>
        /// <para>Blue</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = -100000L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "b")]
        [Index(2)]
        public Int32Value Blue { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RgbColor>(deep);
    }

    /// <summary>
    /// <para>HSL.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:hsl.</para>
    /// </summary>
    [SchemaAttr(24, "hsl")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class HslColor : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the HslColor class.
        /// </summary>
        public HslColor() : base()
        {
        }

        /// <summary>
        /// <para>Hue</para>
        /// <para>Represents the following attribute in the schema: h</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "h")]
        [Index(0)]
        public Int32Value Hue { get; set; }

        /// <summary>
        /// <para>Saturation</para>
        /// <para>Represents the following attribute in the schema: s</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = -100000L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "s")]
        [Index(1)]
        public Int32Value Saturation { get; set; }

        /// <summary>
        /// <para>Lightness</para>
        /// <para>Represents the following attribute in the schema: l</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = -100000L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "l")]
        [Index(2)]
        public Int32Value Lightness { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HslColor>(deep);
    }

    /// <summary>
    /// <para>Defines the CommonBehavior Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cBhvr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonTimeNode &lt;p:cTn></description></item>
    ///   <item><description>TargetElement &lt;p:tgtEl></description></item>
    ///   <item><description>AttributeNameList &lt;p:attrNameLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonTimeNode))]
    [ChildElementInfo(typeof(TargetElement))]
    [ChildElementInfo(typeof(AttributeNameList))]
    [SchemaAttr(24, "cBhvr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommonBehavior : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommonBehavior class.
        /// </summary>
        public CommonBehavior() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonBehavior class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonBehavior(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonBehavior class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonBehavior(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonBehavior class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommonBehavior(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Additive</para>
        /// <para>Represents the following attribute in the schema: additive</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "additive")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.BehaviorAdditiveValues> Additive { get; set; }

        /// <summary>
        /// <para>Accumulate</para>
        /// <para>Represents the following attribute in the schema: accumulate</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "accumulate")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.BehaviorAccumulateValues> Accumulate { get; set; }

        /// <summary>
        /// <para>Transform Type</para>
        /// <para>Represents the following attribute in the schema: xfrmType</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "xfrmType")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.BehaviorTransformValues> TransformType { get; set; }

        /// <summary>
        /// <para>From</para>
        /// <para>Represents the following attribute in the schema: from</para>
        /// </summary>
        [SchemaAttr(0, "from")]
        [Index(3)]
        public StringValue From { get; set; }

        /// <summary>
        /// <para>To</para>
        /// <para>Represents the following attribute in the schema: to</para>
        /// </summary>
        [SchemaAttr(0, "to")]
        [Index(4)]
        public StringValue To { get; set; }

        /// <summary>
        /// <para>By</para>
        /// <para>Represents the following attribute in the schema: by</para>
        /// </summary>
        [SchemaAttr(0, "by")]
        [Index(5)]
        public StringValue By { get; set; }

        /// <summary>
        /// <para>Runtime Context</para>
        /// <para>Represents the following attribute in the schema: rctx</para>
        /// </summary>
        [SchemaAttr(0, "rctx")]
        [Index(6)]
        public StringValue RuntimeContext { get; set; }

        /// <summary>
        /// <para>Override</para>
        /// <para>Represents the following attribute in the schema: override</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "override")]
        [Index(7)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.BehaviorOverrideValues> Override { get; set; }

        /// <summary>
        /// <para>CommonTimeNode.</para>
        /// <para>Represents the following element tag in the schema: p:cTn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonTimeNode CommonTimeNode
        {
            get => GetElement<CommonTimeNode>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Target Element.</para>
        /// <para>Represents the following element tag in the schema: p:tgtEl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TargetElement TargetElement
        {
            get => GetElement<TargetElement>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Attribute Name List.</para>
        /// <para>Represents the following element tag in the schema: p:attrNameLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public AttributeNameList AttributeNameList
        {
            get => GetElement<AttributeNameList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonTimeNode), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TargetElement), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.AttributeNameList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommonBehavior>(deep);
    }

    /// <summary>
    /// <para>Progress.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:progress.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FloatVariantValue &lt;p:fltVal></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(FloatVariantValue))]
    [SchemaAttr(24, "progress")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Progress : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Progress class.
        /// </summary>
        public Progress() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Progress class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Progress(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Progress class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Progress(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Progress class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Progress(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Float Value.</para>
        /// <para>Represents the following element tag in the schema: p:fltVal.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public FloatVariantValue FloatVariantValue
        {
            get => GetElement<FloatVariantValue>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.FloatVariantValue), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Progress>(deep);
    }

    /// <summary>
    /// <para>To.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:to.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BooleanVariantValue &lt;p:boolVal></description></item>
    ///   <item><description>IntegerVariantValue &lt;p:intVal></description></item>
    ///   <item><description>FloatVariantValue &lt;p:fltVal></description></item>
    ///   <item><description>StringVariantValue &lt;p:strVal></description></item>
    ///   <item><description>ColorValue &lt;p:clrVal></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "to")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ToVariantValue : TimeListAnimationVariantType
    {
        /// <summary>
        /// Initializes a new instance of the ToVariantValue class.
        /// </summary>
        public ToVariantValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToVariantValue class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ToVariantValue(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToVariantValue class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ToVariantValue(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToVariantValue class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ToVariantValue(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BooleanVariantValue), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.IntegerVariantValue), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.FloatVariantValue), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.StringVariantValue), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ColorValue), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToVariantValue>(deep);
    }

    /// <summary>
    /// <para>Value.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:val.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BooleanVariantValue &lt;p:boolVal></description></item>
    ///   <item><description>IntegerVariantValue &lt;p:intVal></description></item>
    ///   <item><description>FloatVariantValue &lt;p:fltVal></description></item>
    ///   <item><description>StringVariantValue &lt;p:strVal></description></item>
    ///   <item><description>ColorValue &lt;p:clrVal></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "val")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class VariantValue : TimeListAnimationVariantType
    {
        /// <summary>
        /// Initializes a new instance of the VariantValue class.
        /// </summary>
        public VariantValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VariantValue class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VariantValue(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VariantValue class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VariantValue(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VariantValue class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public VariantValue(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BooleanVariantValue), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.IntegerVariantValue), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.FloatVariantValue), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.StringVariantValue), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ColorValue), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VariantValue>(deep);
    }

    /// <summary>
    /// <para>Defines the TimeListAnimationVariantType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BooleanVariantValue &lt;p:boolVal></description></item>
    ///   <item><description>IntegerVariantValue &lt;p:intVal></description></item>
    ///   <item><description>FloatVariantValue &lt;p:fltVal></description></item>
    ///   <item><description>StringVariantValue &lt;p:strVal></description></item>
    ///   <item><description>ColorValue &lt;p:clrVal></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BooleanVariantValue))]
    [ChildElementInfo(typeof(IntegerVariantValue))]
    [ChildElementInfo(typeof(FloatVariantValue))]
    [ChildElementInfo(typeof(StringVariantValue))]
    [ChildElementInfo(typeof(ColorValue))]
    public abstract partial class TimeListAnimationVariantType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeListAnimationVariantType class.
        /// </summary>
        protected TimeListAnimationVariantType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeListAnimationVariantType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TimeListAnimationVariantType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeListAnimationVariantType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TimeListAnimationVariantType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeListAnimationVariantType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected TimeListAnimationVariantType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Boolean Variant.</para>
        /// <para>Represents the following element tag in the schema: p:boolVal.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public BooleanVariantValue BooleanVariantValue
        {
            get => GetElement<BooleanVariantValue>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Integer.</para>
        /// <para>Represents the following element tag in the schema: p:intVal.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public IntegerVariantValue IntegerVariantValue
        {
            get => GetElement<IntegerVariantValue>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Float Value.</para>
        /// <para>Represents the following element tag in the schema: p:fltVal.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public FloatVariantValue FloatVariantValue
        {
            get => GetElement<FloatVariantValue>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>String Value.</para>
        /// <para>Represents the following element tag in the schema: p:strVal.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public StringVariantValue StringVariantValue
        {
            get => GetElement<StringVariantValue>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Color Value.</para>
        /// <para>Represents the following element tag in the schema: p:clrVal.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ColorValue ColorValue
        {
            get => GetElement<ColorValue>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    }

    /// <summary>
    /// <para>Common Media Node Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cMediaNode.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonTimeNode &lt;p:cTn></description></item>
    ///   <item><description>TargetElement &lt;p:tgtEl></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonTimeNode))]
    [ChildElementInfo(typeof(TargetElement))]
    [SchemaAttr(24, "cMediaNode")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommonMediaNode : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommonMediaNode class.
        /// </summary>
        public CommonMediaNode() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonMediaNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonMediaNode(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonMediaNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonMediaNode(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonMediaNode class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommonMediaNode(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Volume</para>
        /// <para>Represents the following attribute in the schema: vol</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "vol")]
        [Index(0)]
        public Int32Value Volume { get; set; }

        /// <summary>
        /// <para>Mute</para>
        /// <para>Represents the following attribute in the schema: mute</para>
        /// </summary>
        [SchemaAttr(0, "mute")]
        [Index(1)]
        public BooleanValue Mute { get; set; }

        /// <summary>
        /// <para>Number of Slides</para>
        /// <para>Represents the following attribute in the schema: numSld</para>
        /// </summary>
        [SchemaAttr(0, "numSld")]
        [Index(2)]
        public UInt32Value SlideCount { get; set; }

        /// <summary>
        /// <para>Show When Stopped</para>
        /// <para>Represents the following attribute in the schema: showWhenStopped</para>
        /// </summary>
        [SchemaAttr(0, "showWhenStopped")]
        [Index(3)]
        public BooleanValue ShowWhenStopped { get; set; }

        /// <summary>
        /// <para>Common Time Node Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cTn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonTimeNode CommonTimeNode
        {
            get => GetElement<CommonTimeNode>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TargetElement.</para>
        /// <para>Represents the following element tag in the schema: p:tgtEl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TargetElement TargetElement
        {
            get => GetElement<TargetElement>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonTimeNode), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TargetElement), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommonMediaNode>(deep);
    }

    /// <summary>
    /// <para>Time Node List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:tnLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ParallelTimeNode &lt;p:par></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ParallelTimeNode))]
    [SchemaAttr(24, "tnLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TimeNodeList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeNodeList class.
        /// </summary>
        public TimeNodeList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeNodeList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimeNodeList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeNodeList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimeNodeList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeNodeList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimeNodeList(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ParallelTimeNode.</para>
        /// <para>Represents the following element tag in the schema: p:par.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ParallelTimeNode ParallelTimeNode
        {
            get => GetElement<ParallelTimeNode>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ParallelTimeNode), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimeNodeList>(deep);
    }

    /// <summary>
    /// <para>Template Effects.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:tmpl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TimeNodeList &lt;p:tnLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TimeNodeList))]
    [SchemaAttr(24, "tmpl")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Template : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Template class.
        /// </summary>
        public Template() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Template class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Template(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Template class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Template(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Template class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Template(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Level</para>
        /// <para>Represents the following attribute in the schema: lvl</para>
        /// </summary>
        [SchemaAttr(0, "lvl")]
        [Index(0)]
        public UInt32Value Level { get; set; }

        /// <summary>
        /// <para>Time Node List.</para>
        /// <para>Represents the following element tag in the schema: p:tnLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TimeNodeList TimeNodeList
        {
            get => GetElement<TimeNodeList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TimeNodeList), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Template>(deep);
    }

    /// <summary>
    /// <para>Template effects.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:tmplLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Template &lt;p:tmpl></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Template))]
    [SchemaAttr(24, "tmplLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TemplateList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TemplateList class.
        /// </summary>
        public TemplateList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TemplateList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TemplateList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TemplateList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TemplateList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TemplateList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TemplateList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Template), 0, 9)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TemplateList>(deep);
    }

    /// <summary>
    /// <para>Build Sub Elements.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bldSub.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BuildDiagram &lt;a:bldDgm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BuildChart &lt;a:bldChart></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BuildDiagram))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BuildChart))]
    [SchemaAttr(24, "bldSub")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BuildSubElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BuildSubElement class.
        /// </summary>
        public BuildSubElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BuildSubElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BuildSubElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BuildSubElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BuildSubElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BuildSubElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BuildSubElement(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Build Diagram.</para>
        /// <para>Represents the following element tag in the schema: a:bldDgm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BuildDiagram BuildDiagram
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BuildDiagram>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Build Chart.</para>
        /// <para>Represents the following element tag in the schema: a:bldChart.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BuildChart BuildChart
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BuildChart>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BuildDiagram), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BuildChart), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BuildSubElement>(deep);
    }

    /// <summary>
    /// <para>Build Paragraph.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bldP.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TemplateList &lt;p:tmplLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TemplateList))]
    [SchemaAttr(24, "bldP")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BuildParagraph : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BuildParagraph class.
        /// </summary>
        public BuildParagraph() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BuildParagraph class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BuildParagraph(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BuildParagraph class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BuildParagraph(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BuildParagraph class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BuildParagraph(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Shape ID</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(Version = FileFormatVersions.Office2007)]
        [NumberValidator(SimpleType = typeof(UInt32Value), Version = FileFormatVersions.Office2010)]
        [NumberValidator(SimpleType = typeof(UInt32Value), InitialVersion = FileFormatVersions.Office2013)]
        [SchemaAttr(0, "spid")]
        [Index(0)]
        public StringValue ShapeId { get; set; }

        /// <summary>
        /// <para>Group ID</para>
        /// <para>Represents the following attribute in the schema: grpId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "grpId")]
        [Index(1)]
        public UInt32Value GroupId { get; set; }

        /// <summary>
        /// <para>Expand UI</para>
        /// <para>Represents the following attribute in the schema: uiExpand</para>
        /// </summary>
        [SchemaAttr(0, "uiExpand")]
        [Index(2)]
        public BooleanValue UiExpand { get; set; }

        /// <summary>
        /// <para>Build Types</para>
        /// <para>Represents the following attribute in the schema: build</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "build")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.ParagraphBuildValues> Build { get; set; }

        /// <summary>
        /// <para>Build Level</para>
        /// <para>Represents the following attribute in the schema: bldLvl</para>
        /// </summary>
        [SchemaAttr(0, "bldLvl")]
        [Index(4)]
        public UInt32Value BuildLevel { get; set; }

        /// <summary>
        /// <para>Animate Background</para>
        /// <para>Represents the following attribute in the schema: animBg</para>
        /// </summary>
        [SchemaAttr(0, "animBg")]
        [Index(5)]
        public BooleanValue AnimateBackground { get; set; }

        /// <summary>
        /// <para>Auto Update Animation Background</para>
        /// <para>Represents the following attribute in the schema: autoUpdateAnimBg</para>
        /// </summary>
        [SchemaAttr(0, "autoUpdateAnimBg")]
        [Index(6)]
        public BooleanValue AutoAnimateBackground { get; set; }

        /// <summary>
        /// <para>Reverse</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr(0, "rev")]
        [Index(7)]
        public BooleanValue Reverse { get; set; }

        /// <summary>
        /// <para>Auto Advance Time</para>
        /// <para>Represents the following attribute in the schema: advAuto</para>
        /// </summary>
        [NumberValidator(SimpleType = typeof(UInt32Value), Version = FileFormatVersions.Office2007, UnionId = 0)]
        [EnumValidator(SimpleType = typeof(EnumValue<DocumentFormat.OpenXml.Presentation.IndefiniteTimeDeclarationValues>), Version = FileFormatVersions.Office2007, UnionId = 0)]
        [StringValidator(InitialVersion = FileFormatVersions.Office2010, UnionId = 1)]
        [EnumValidator(SimpleType = typeof(EnumValue<DocumentFormat.OpenXml.Presentation.IndefiniteTimeDeclarationValues>), InitialVersion = FileFormatVersions.Office2010, UnionId = 1)]
        [SchemaAttr(0, "advAuto")]
        [Index(8)]
        public StringValue AutoAdvance { get; set; }

        /// <summary>
        /// <para>Template effects.</para>
        /// <para>Represents the following element tag in the schema: p:tmplLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TemplateList TemplateList
        {
            get => GetElement<TemplateList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TemplateList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BuildParagraph>(deep);
    }

    /// <summary>
    /// <para>Build Diagram.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bldDgm.</para>
    /// </summary>
    [SchemaAttr(24, "bldDgm")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BuildDiagram : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BuildDiagram class.
        /// </summary>
        public BuildDiagram() : base()
        {
        }

        /// <summary>
        /// <para>Shape ID</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(Version = FileFormatVersions.Office2007)]
        [NumberValidator(SimpleType = typeof(UInt32Value), Version = FileFormatVersions.Office2010)]
        [NumberValidator(SimpleType = typeof(UInt32Value), InitialVersion = FileFormatVersions.Office2013)]
        [SchemaAttr(0, "spid")]
        [Index(0)]
        public StringValue ShapeId { get; set; }

        /// <summary>
        /// <para>Group ID</para>
        /// <para>Represents the following attribute in the schema: grpId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "grpId")]
        [Index(1)]
        public UInt32Value GroupId { get; set; }

        /// <summary>
        /// <para>Expand UI</para>
        /// <para>Represents the following attribute in the schema: uiExpand</para>
        /// </summary>
        [SchemaAttr(0, "uiExpand")]
        [Index(2)]
        public BooleanValue UiExpand { get; set; }

        /// <summary>
        /// <para>Diagram Build Types</para>
        /// <para>Represents the following attribute in the schema: bld</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bld")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.DiagramBuildValues> Build { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BuildDiagram>(deep);
    }

    /// <summary>
    /// <para>Build OLE Chart.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bldOleChart.</para>
    /// </summary>
    [SchemaAttr(24, "bldOleChart")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BuildOleChart : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BuildOleChart class.
        /// </summary>
        public BuildOleChart() : base()
        {
        }

        /// <summary>
        /// <para>Shape ID</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(Version = FileFormatVersions.Office2007)]
        [NumberValidator(SimpleType = typeof(UInt32Value), Version = FileFormatVersions.Office2010)]
        [NumberValidator(SimpleType = typeof(UInt32Value), InitialVersion = FileFormatVersions.Office2013)]
        [SchemaAttr(0, "spid")]
        [Index(0)]
        public StringValue ShapeId { get; set; }

        /// <summary>
        /// <para>Group ID</para>
        /// <para>Represents the following attribute in the schema: grpId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "grpId")]
        [Index(1)]
        public UInt32Value GroupId { get; set; }

        /// <summary>
        /// <para>Expand UI</para>
        /// <para>Represents the following attribute in the schema: uiExpand</para>
        /// </summary>
        [SchemaAttr(0, "uiExpand")]
        [Index(2)]
        public BooleanValue UiExpand { get; set; }

        /// <summary>
        /// <para>Build</para>
        /// <para>Represents the following attribute in the schema: bld</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bld")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.OleChartBuildValues> Build { get; set; }

        /// <summary>
        /// <para>Animate Background</para>
        /// <para>Represents the following attribute in the schema: animBg</para>
        /// </summary>
        [SchemaAttr(0, "animBg")]
        [Index(4)]
        public BooleanValue AnimateBackground { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BuildOleChart>(deep);
    }

    /// <summary>
    /// <para>Build Graphics.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bldGraphic.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BuildAsOne &lt;p:bldAsOne></description></item>
    ///   <item><description>BuildSubElement &lt;p:bldSub></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BuildAsOne))]
    [ChildElementInfo(typeof(BuildSubElement))]
    [SchemaAttr(24, "bldGraphic")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BuildGraphics : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BuildGraphics class.
        /// </summary>
        public BuildGraphics() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BuildGraphics class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BuildGraphics(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BuildGraphics class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BuildGraphics(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BuildGraphics class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BuildGraphics(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Shape ID</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(Version = FileFormatVersions.Office2007)]
        [NumberValidator(SimpleType = typeof(UInt32Value), Version = FileFormatVersions.Office2010)]
        [NumberValidator(SimpleType = typeof(UInt32Value), InitialVersion = FileFormatVersions.Office2013)]
        [SchemaAttr(0, "spid")]
        [Index(0)]
        public StringValue ShapeId { get; set; }

        /// <summary>
        /// <para>Group ID</para>
        /// <para>Represents the following attribute in the schema: grpId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "grpId")]
        [Index(1)]
        public UInt32Value GroupId { get; set; }

        /// <summary>
        /// <para>Expand UI</para>
        /// <para>Represents the following attribute in the schema: uiExpand</para>
        /// </summary>
        [SchemaAttr(0, "uiExpand")]
        [Index(2)]
        public BooleanValue UiExpand { get; set; }

        /// <summary>
        /// <para>Build As One.</para>
        /// <para>Represents the following element tag in the schema: p:bldAsOne.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public BuildAsOne BuildAsOne
        {
            get => GetElement<BuildAsOne>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Build Sub Elements.</para>
        /// <para>Represents the following element tag in the schema: p:bldSub.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public BuildSubElement BuildSubElement
        {
            get => GetElement<BuildSubElement>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BuildAsOne), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BuildSubElement), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BuildGraphics>(deep);
    }

    /// <summary>
    /// <para>Build List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bldLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BuildParagraph &lt;p:bldP></description></item>
    ///   <item><description>BuildDiagram &lt;p:bldDgm></description></item>
    ///   <item><description>BuildOleChart &lt;p:bldOleChart></description></item>
    ///   <item><description>BuildGraphics &lt;p:bldGraphic></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BuildParagraph))]
    [ChildElementInfo(typeof(BuildDiagram))]
    [ChildElementInfo(typeof(BuildOleChart))]
    [ChildElementInfo(typeof(BuildGraphics))]
    [SchemaAttr(24, "bldLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BuildList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BuildList class.
        /// </summary>
        public BuildList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BuildList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BuildList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BuildList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BuildList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BuildList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BuildList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 0)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BuildParagraph), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BuildDiagram), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BuildOleChart), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BuildGraphics), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BuildList>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionListWithModification Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Extension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Extension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ExtensionListWithModification : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtensionListWithModification class.
        /// </summary>
        public ExtensionListWithModification() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionListWithModification class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionListWithModification(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionListWithModification class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionListWithModification(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionListWithModification class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExtensionListWithModification(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Modify</para>
        /// <para>Represents the following attribute in the schema: mod</para>
        /// </summary>
        [SchemaAttr(0, "mod")]
        [Index(0)]
        public BooleanValue Modify { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Extension), 0, 0)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionListWithModification>(deep);
    }

    /// <summary>
    /// <para>By.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:by.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RgbColor &lt;p:rgb></description></item>
    ///   <item><description>HslColor &lt;p:hsl></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(RgbColor))]
    [ChildElementInfo(typeof(HslColor))]
    [SchemaAttr(24, "by")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ByColor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ByColor class.
        /// </summary>
        public ByColor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ByColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ByColor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ByColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ByColor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ByColor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ByColor(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>RGB.</para>
        /// <para>Represents the following element tag in the schema: p:rgb.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public RgbColor RgbColor
        {
            get => GetElement<RgbColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HSL.</para>
        /// <para>Represents the following element tag in the schema: p:hsl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public HslColor HslColor
        {
            get => GetElement<HslColor>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.RgbColor), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.HslColor), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ByColor>(deep);
    }

    /// <summary>
    /// <para>From.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:from.</para>
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
    [SchemaAttr(24, "from")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class FromColor : Color3Type
    {
        /// <summary>
        /// Initializes a new instance of the FromColor class.
        /// </summary>
        public FromColor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FromColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FromColor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FromColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FromColor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FromColor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FromColor(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FromColor>(deep);
    }

    /// <summary>
    /// <para>To.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:to.</para>
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
    [SchemaAttr(24, "to")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ToColor : Color3Type
    {
        /// <summary>
        /// Initializes a new instance of the ToColor class.
        /// </summary>
        public ToColor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ToColor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ToColor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToColor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ToColor(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToColor>(deep);
    }

    /// <summary>
    /// <para>Defines the Color3Type Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
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
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HslColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), FileFormatVersions.Office2010)]
    public abstract partial class Color3Type : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Color3Type class.
        /// </summary>
        protected Color3Type() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Color3Type class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected Color3Type(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Color3Type class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected Color3Type(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Color3Type class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected Color3Type(string outerXml) : base(outerXml)
        {
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

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    }

    /// <summary>
    /// <para>Presentation Slide.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sld.</para>
    /// </summary>
    [SchemaAttr(24, "sld")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideListEntry : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideListEntry class.
        /// </summary>
        public SlideListEntry() : base()
        {
        }

        /// <summary>
        /// <para>Relationship ID</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideListEntry>(deep);
    }

    /// <summary>
    /// <para>Customer Data.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:custData.</para>
    /// </summary>
    [SchemaAttr(24, "custData")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CustomerData : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomerData class.
        /// </summary>
        public CustomerData() : base()
        {
        }

        /// <summary>
        /// <para>Relationship ID</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomerData>(deep);
    }

    /// <summary>
    /// <para>Customer Data Tags.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:tags.</para>
    /// </summary>
    [SchemaAttr(24, "tags")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CustomerDataTags : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomerDataTags class.
        /// </summary>
        public CustomerDataTags() : base()
        {
        }

        /// <summary>
        /// <para>Relationship ID</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomerDataTags>(deep);
    }

    /// <summary>
    /// <para>Comment Author.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cmAuthor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommentAuthorExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommentAuthorExtensionList))]
    [SchemaAttr(24, "cmAuthor")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommentAuthor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentAuthor class.
        /// </summary>
        public CommentAuthor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentAuthor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentAuthor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentAuthor(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public UInt32Value Id { get; set; }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(1)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>initials</para>
        /// <para>Represents the following attribute in the schema: initials</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "initials")]
        [Index(2)]
        public StringValue Initials { get; set; }

        /// <summary>
        /// <para>lastIdx</para>
        /// <para>Represents the following attribute in the schema: lastIdx</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "lastIdx")]
        [Index(3)]
        public UInt32Value LastIndex { get; set; }

        /// <summary>
        /// <para>clrIdx</para>
        /// <para>Represents the following attribute in the schema: clrIdx</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "clrIdx")]
        [Index(4)]
        public UInt32Value ColorIndex { get; set; }

        /// <summary>
        /// <para>CommentAuthorExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommentAuthorExtensionList CommentAuthorExtensionList
        {
            get => GetElement<CommentAuthorExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommentAuthorExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentAuthor>(deep);
    }

    /// <summary>
    /// <para>Comment.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Position &lt;p:pos></description></item>
    ///   <item><description>Text &lt;p:text></description></item>
    ///   <item><description>CommentExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Position))]
    [ChildElementInfo(typeof(Text))]
    [ChildElementInfo(typeof(CommentExtensionList))]
    [SchemaAttr(24, "cm")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Comment : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Comment class.
        /// </summary>
        public Comment() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comment class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Comment(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comment class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Comment(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comment class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Comment(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>authorId</para>
        /// <para>Represents the following attribute in the schema: authorId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "authorId")]
        [Index(0)]
        public UInt32Value AuthorId { get; set; }

        /// <summary>
        /// <para>dt</para>
        /// <para>Represents the following attribute in the schema: dt</para>
        /// </summary>
        [SchemaAttr(0, "dt")]
        [Index(1)]
        public DateTimeValue DateTime { get; set; }

        /// <summary>
        /// <para>idx</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "idx")]
        [Index(2)]
        public UInt32Value Index { get; set; }

        /// <summary>
        /// <para>Position.</para>
        /// <para>Represents the following element tag in the schema: p:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Position Position
        {
            get => GetElement<Position>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text.</para>
        /// <para>Represents the following element tag in the schema: p:text.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Text Text
        {
            get => GetElement<Text>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CommentExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommentExtensionList CommentExtensionList
        {
            get => GetElement<CommentExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Position), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Text), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommentExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Comment>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Extension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Extension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Extension), 0, 0)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Embedded Control.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:control.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    ///   <item><description>Picture &lt;p:pic></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList))]
    [ChildElementInfo(typeof(Picture))]
    [SchemaAttr(24, "control")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Control : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Control class.
        /// </summary>
        public Control() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Control class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Control(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Control class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Control(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Control class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Control(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>spid</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "spid")]
        [Index(0)]
        public StringValue ShapeId { get; set; }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr(0, "name")]
        [Index(1)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>showAsIcon</para>
        /// <para>Represents the following attribute in the schema: showAsIcon</para>
        /// </summary>
        [SchemaAttr(0, "showAsIcon")]
        [Index(2)]
        public BooleanValue ShowAsIcon { get; set; }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [SchemaAttr(19, "id")]
        [Index(3)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>imgW</para>
        /// <para>Represents the following attribute in the schema: imgW</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L)]
        [SchemaAttr(0, "imgW")]
        [Index(4)]
        public Int32Value ImageWidth { get; set; }

        /// <summary>
        /// <para>imgH</para>
        /// <para>Represents the following attribute in the schema: imgH</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L)]
        [SchemaAttr(0, "imgH")]
        [Index(5)]
        public Int32Value ImageHeight { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Picture.</para>
        /// <para>Represents the following element tag in the schema: p:pic.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Picture Picture
        {
            get => GetElement<Picture>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Picture), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Control>(deep);
    }

    /// <summary>
    /// <para>Slide ID.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldId.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "sldId")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideId : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideId class.
        /// </summary>
        public SlideId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideId class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideId(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideId class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideId(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideId class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideId(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Slide Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MaxExclusive = 2147483648L, MinInclusive = 256L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public UInt32Value Id { get; set; }

        /// <summary>
        /// <para>Relationship Identifier</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(1)]
        public StringValue RelationshipId { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideId>(deep);
    }

    /// <summary>
    /// <para>Slide Master ID.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldMasterId.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "sldMasterId")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideMasterId : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideMasterId class.
        /// </summary>
        public SlideMasterId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMasterId class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideMasterId(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMasterId class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideMasterId(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMasterId class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideMasterId(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Slide Master Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [NumberValidator(MinInclusive = 2147483648L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public UInt32Value Id { get; set; }

        /// <summary>
        /// <para>Relationship Identifier</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(1)]
        public StringValue RelationshipId { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideMasterId>(deep);
    }

    /// <summary>
    /// <para>Notes Master ID.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:notesMasterId.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "notesMasterId")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NotesMasterId : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NotesMasterId class.
        /// </summary>
        public NotesMasterId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterId class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMasterId(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterId class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMasterId(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterId class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesMasterId(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Relationship Identifier</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesMasterId>(deep);
    }

    /// <summary>
    /// <para>Handout Master ID.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:handoutMasterId.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "handoutMasterId")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class HandoutMasterId : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HandoutMasterId class.
        /// </summary>
        public HandoutMasterId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMasterId class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HandoutMasterId(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMasterId class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HandoutMasterId(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMasterId class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HandoutMasterId(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Relationship Identifier</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HandoutMasterId>(deep);
    }

    /// <summary>
    /// <para>Embedded Font Name.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:font.</para>
    /// </summary>
    [SchemaAttr(24, "font")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Font : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Font class.
        /// </summary>
        public Font() : base()
        {
        }

        /// <summary>
        /// <para>Text Typeface</para>
        /// <para>Represents the following attribute in the schema: typeface</para>
        /// </summary>
        [SchemaAttr(0, "typeface")]
        [Index(0)]
        public StringValue Typeface { get; set; }

        /// <summary>
        /// <para>Panose Setting</para>
        /// <para>Represents the following attribute in the schema: panose</para>
        /// </summary>
        [StringValidator(Length = 10L)]
        [SchemaAttr(0, "panose")]
        [Index(1)]
        public HexBinaryValue Panose { get; set; }

        /// <summary>
        /// <para>Similar Font Family</para>
        /// <para>Represents the following attribute in the schema: pitchFamily</para>
        /// </summary>
        [SchemaAttr(0, "pitchFamily")]
        [Index(2)]
        public SByteValue PitchFamily { get; set; }

        /// <summary>
        /// <para>Similar Character Set</para>
        /// <para>Represents the following attribute in the schema: charset</para>
        /// </summary>
        [SchemaAttr(0, "charset")]
        [Index(3)]
        public SByteValue CharacterSet { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Font>(deep);
    }

    /// <summary>
    /// <para>Regular Embedded Font.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:regular.</para>
    /// </summary>
    [SchemaAttr(24, "regular")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class RegularFont : EmbeddedFontDataIdType
    {
        /// <summary>
        /// Initializes a new instance of the RegularFont class.
        /// </summary>
        public RegularFont() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RegularFont>(deep);
    }

    /// <summary>
    /// <para>Bold Embedded Font.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bold.</para>
    /// </summary>
    [SchemaAttr(24, "bold")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BoldFont : EmbeddedFontDataIdType
    {
        /// <summary>
        /// Initializes a new instance of the BoldFont class.
        /// </summary>
        public BoldFont() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BoldFont>(deep);
    }

    /// <summary>
    /// <para>Italic Embedded Font.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:italic.</para>
    /// </summary>
    [SchemaAttr(24, "italic")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ItalicFont : EmbeddedFontDataIdType
    {
        /// <summary>
        /// Initializes a new instance of the ItalicFont class.
        /// </summary>
        public ItalicFont() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ItalicFont>(deep);
    }

    /// <summary>
    /// <para>Bold Italic Embedded Font.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:boldItalic.</para>
    /// </summary>
    [SchemaAttr(24, "boldItalic")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BoldItalicFont : EmbeddedFontDataIdType
    {
        /// <summary>
        /// Initializes a new instance of the BoldItalicFont class.
        /// </summary>
        public BoldItalicFont() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BoldItalicFont>(deep);
    }

    /// <summary>
    /// <para>Defines the EmbeddedFontDataIdType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class EmbeddedFontDataIdType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the EmbeddedFontDataIdType class.
        /// </summary>
        protected EmbeddedFontDataIdType() : base()
        {
        }

        /// <summary>
        /// <para>Relationship Identifier</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(0)]
        public StringValue Id { get; set; }
    }

    /// <summary>
    /// <para>Embedded Font.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:embeddedFont.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Font &lt;p:font></description></item>
    ///   <item><description>RegularFont &lt;p:regular></description></item>
    ///   <item><description>BoldFont &lt;p:bold></description></item>
    ///   <item><description>ItalicFont &lt;p:italic></description></item>
    ///   <item><description>BoldItalicFont &lt;p:boldItalic></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Font))]
    [ChildElementInfo(typeof(RegularFont))]
    [ChildElementInfo(typeof(BoldFont))]
    [ChildElementInfo(typeof(ItalicFont))]
    [ChildElementInfo(typeof(BoldItalicFont))]
    [SchemaAttr(24, "embeddedFont")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class EmbeddedFont : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EmbeddedFont class.
        /// </summary>
        public EmbeddedFont() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedFont class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EmbeddedFont(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedFont class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EmbeddedFont(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedFont class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EmbeddedFont(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Embedded Font Name.</para>
        /// <para>Represents the following element tag in the schema: p:font.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Font Font
        {
            get => GetElement<Font>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Regular Embedded Font.</para>
        /// <para>Represents the following element tag in the schema: p:regular.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public RegularFont RegularFont
        {
            get => GetElement<RegularFont>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bold Embedded Font.</para>
        /// <para>Represents the following element tag in the schema: p:bold.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public BoldFont BoldFont
        {
            get => GetElement<BoldFont>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Italic Embedded Font.</para>
        /// <para>Represents the following element tag in the schema: p:italic.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ItalicFont ItalicFont
        {
            get => GetElement<ItalicFont>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bold Italic Embedded Font.</para>
        /// <para>Represents the following element tag in the schema: p:boldItalic.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public BoldItalicFont BoldItalicFont
        {
            get => GetElement<BoldItalicFont>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Font), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.RegularFont), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BoldFont), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ItalicFont), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BoldItalicFont), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EmbeddedFont>(deep);
    }

    /// <summary>
    /// <para>List of Presentation Slides.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlideListEntry &lt;p:sld></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlideListEntry))]
    [SchemaAttr(24, "sldLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideList class.
        /// </summary>
        public SlideList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideListEntry), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideList>(deep);
    }

    /// <summary>
    /// <para>Custom Show.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:custShow.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlideList &lt;p:sldLst></description></item>
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlideList))]
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "custShow")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CustomShow : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomShow class.
        /// </summary>
        public CustomShow() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomShow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomShow(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomShow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomShow(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomShow class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomShow(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Custom Show Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(0)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>Custom Show ID</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "id")]
        [Index(1)]
        public UInt32Value Id { get; set; }

        /// <summary>
        /// <para>List of Presentation Slides.</para>
        /// <para>Represents the following element tag in the schema: p:sldLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SlideList SlideList
        {
            get => GetElement<SlideList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideList), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomShow>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cNvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnClick &lt;a:hlinkClick></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnHover &lt;a:hlinkHover></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList))]
    [SchemaAttr(24, "cNvPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class.
        /// </summary>
        public NonVisualDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public UInt32Value Id { get; set; }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(1)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>descr</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>
        [SchemaAttr(0, "descr")]
        [Index(2)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>hidden</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        [SchemaAttr(0, "hidden")]
        [Index(3)]
        public BooleanValue Hidden { get; set; }

        /// <summary>
        /// <para>title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr(0, "title")]
        [Index(4)]
        public StringValue Title { get; set; }

        /// <summary>
        /// <para>HyperlinkOnClick.</para>
        /// <para>Represents the following element tag in the schema: a:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick HyperlinkOnClick
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HyperlinkOnHover.</para>
        /// <para>Represents the following element tag in the schema: a:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover HyperlinkOnHover
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualDrawingPropertiesExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList NonVisualDrawingPropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Drawing Properties for a Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cNvSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ShapeLocks &lt;a:spLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ShapeLocks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
    [SchemaAttr(24, "cNvSpPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NonVisualShapeDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class.
        /// </summary>
        public NonVisualShapeDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualShapeDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Text Box</para>
        /// <para>Represents the following attribute in the schema: txBox</para>
        /// </summary>
        [SchemaAttr(0, "txBox")]
        [Index(0)]
        public BooleanValue TextBox { get; set; }

        /// <summary>
        /// <para>Shape Locks.</para>
        /// <para>Represents the following element tag in the schema: a:spLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ShapeLocks ShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapeLocks), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualShapeDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Application Non-Visual Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:nvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PlaceholderShape &lt;p:ph></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AudioFromCD &lt;a:audioCd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.WaveAudioFile &lt;a:wavAudioFile></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AudioFromFile &lt;a:audioFile></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.VideoFromFile &lt;a:videoFile></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.QuickTimeFromFile &lt;a:quickTimeFile></description></item>
    ///   <item><description>CustomerDataList &lt;p:custDataLst></description></item>
    ///   <item><description>ApplicationNonVisualDrawingPropertiesExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PlaceholderShape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AudioFromCD))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.WaveAudioFile))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AudioFromFile))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.VideoFromFile))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.QuickTimeFromFile))]
    [ChildElementInfo(typeof(CustomerDataList))]
    [ChildElementInfo(typeof(ApplicationNonVisualDrawingPropertiesExtensionList))]
    [SchemaAttr(24, "nvPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ApplicationNonVisualDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingProperties class.
        /// </summary>
        public ApplicationNonVisualDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ApplicationNonVisualDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ApplicationNonVisualDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ApplicationNonVisualDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Is a Photo Album</para>
        /// <para>Represents the following attribute in the schema: isPhoto</para>
        /// </summary>
        [SchemaAttr(0, "isPhoto")]
        [Index(0)]
        public BooleanValue IsPhoto { get; set; }

        /// <summary>
        /// <para>Is User Drawn</para>
        /// <para>Represents the following attribute in the schema: userDrawn</para>
        /// </summary>
        [SchemaAttr(0, "userDrawn")]
        [Index(1)]
        public BooleanValue UserDrawn { get; set; }

        /// <summary>
        /// <para>Placeholder Shape.</para>
        /// <para>Represents the following element tag in the schema: p:ph.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public PlaceholderShape PlaceholderShape
        {
            get => GetElement<PlaceholderShape>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PlaceholderShape), 0, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AudioFromCD), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.WaveAudioFile), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AudioFromFile), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.VideoFromFile), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.QuickTimeFromFile), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CustomerDataList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingPropertiesExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplicationNonVisualDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:nvSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;p:cNvPr></description></item>
    ///   <item><description>NonVisualShapeDrawingProperties &lt;p:cNvSpPr></description></item>
    ///   <item><description>ApplicationNonVisualDrawingProperties &lt;p:nvPr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualShapeDrawingProperties))]
    [ChildElementInfo(typeof(ApplicationNonVisualDrawingProperties))]
    [SchemaAttr(24, "nvSpPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NonVisualShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class.
        /// </summary>
        public NonVisualShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Non-Visual Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Drawing Properties for a Shape.</para>
        /// <para>Represents the following element tag in the schema: p:cNvSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualShapeDrawingProperties NonVisualShapeDrawingProperties
        {
            get => GetElement<NonVisualShapeDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Application Non-Visual Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: p:nvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ApplicationNonVisualDrawingProperties ApplicationNonVisualDrawingProperties
        {
            get => GetElement<ApplicationNonVisualDrawingProperties>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualShapeDrawingProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingProperties), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Transform2D &lt;a:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.CustomGeometry &lt;a:custGeom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetGeometry &lt;a:prstGeom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Transform2D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Outline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList))]
    [SchemaAttr(24, "spPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeProperties class.
        /// </summary>
        public ShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bwMode")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }

        /// <summary>
        /// <para>2D Transform for Individual Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                }
            },
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Shape Style.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:style.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LineReference &lt;a:lnRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.FillReference &lt;a:fillRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectReference &lt;a:effectRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.FontReference &lt;a:fontRef></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LineReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.FillReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.FontReference))]
    [SchemaAttr(24, "style")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ShapeStyle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeStyle class.
        /// </summary>
        public ShapeStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeStyle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>LineReference.</para>
        /// <para>Represents the following element tag in the schema: a:lnRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.LineReference LineReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.LineReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillReference.</para>
        /// <para>Represents the following element tag in the schema: a:fillRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FillReference FillReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FillReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectReference.</para>
        /// <para>Represents the following element tag in the schema: a:effectRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EffectReference EffectReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EffectReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Font Reference.</para>
        /// <para>Represents the following element tag in the schema: a:fontRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FontReference FontReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FontReference>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineReference), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FillReference), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectReference), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FontReference), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeStyle>(deep);
    }

    /// <summary>
    /// <para>Shape Text Body.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:txBody.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ListStyle))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Paragraph))]
    [SchemaAttr(24, "txBody")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TextBody : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBody class.
        /// </summary>
        public TextBody() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBody(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Body Properties.</para>
        /// <para>Represents the following element tag in the schema: a:bodyPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BodyProperties BodyProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text List Styles.</para>
        /// <para>Represents the following element tag in the schema: a:lstStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ListStyle ListStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ListStyle>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBody>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Connector Shape Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cNvCxnSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks &lt;a:cxnSpLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.StartConnection &lt;a:stCxn></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EndConnection &lt;a:endCxn></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.StartConnection))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EndConnection))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
    [SchemaAttr(24, "cNvCxnSpPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NonVisualConnectorShapeDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class.
        /// </summary>
        public NonVisualConnectorShapeDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectorShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectorShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualConnectorShapeDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Connection Shape Locks.</para>
        /// <para>Represents the following element tag in the schema: a:cxnSpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks ConnectionShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection Start.</para>
        /// <para>Represents the following element tag in the schema: a:stCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.StartConnection StartConnection
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.StartConnection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection End.</para>
        /// <para>Represents the following element tag in the schema: a:endCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EndConnection EndConnection
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EndConnection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.StartConnection), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EndConnection), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectorShapeDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Connection Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:nvCxnSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;p:cNvPr></description></item>
    ///   <item><description>NonVisualConnectorShapeDrawingProperties &lt;p:cNvCxnSpPr></description></item>
    ///   <item><description>ApplicationNonVisualDrawingProperties &lt;p:nvPr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualConnectorShapeDrawingProperties))]
    [ChildElementInfo(typeof(ApplicationNonVisualDrawingProperties))]
    [SchemaAttr(24, "nvCxnSpPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NonVisualConnectionShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class.
        /// </summary>
        public NonVisualConnectionShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectionShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectionShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualConnectionShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Non-Visual Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Connector Shape Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cNvCxnSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualConnectorShapeDrawingProperties NonVisualConnectorShapeDrawingProperties
        {
            get => GetElement<NonVisualConnectorShapeDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Application Non-Visual Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: p:nvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ApplicationNonVisualDrawingProperties ApplicationNonVisualDrawingProperties
        {
            get => GetElement<ApplicationNonVisualDrawingProperties>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualConnectorShapeDrawingProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingProperties), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectionShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Picture Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cNvPicPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PictureLocks &lt;a:picLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PictureLocks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList))]
    [SchemaAttr(24, "cNvPicPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NonVisualPictureDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class.
        /// </summary>
        public NonVisualPictureDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualPictureDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>preferRelativeResize</para>
        /// <para>Represents the following attribute in the schema: preferRelativeResize</para>
        /// </summary>
        [SchemaAttr(0, "preferRelativeResize")]
        [Index(0)]
        public BooleanValue PreferRelativeResize { get; set; }

        /// <summary>
        /// <para>PictureLocks.</para>
        /// <para>Represents the following element tag in the schema: a:picLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PictureLocks PictureLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PictureLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualPicturePropertiesExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList NonVisualPicturePropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PictureLocks), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualPictureDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Picture.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:nvPicPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;p:cNvPr></description></item>
    ///   <item><description>NonVisualPictureDrawingProperties &lt;p:cNvPicPr></description></item>
    ///   <item><description>ApplicationNonVisualDrawingProperties &lt;p:nvPr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualPictureDrawingProperties))]
    [ChildElementInfo(typeof(ApplicationNonVisualDrawingProperties))]
    [SchemaAttr(24, "nvPicPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NonVisualPictureProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class.
        /// </summary>
        public NonVisualPictureProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualPictureProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>NonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: p:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Picture Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cNvPicPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualPictureDrawingProperties NonVisualPictureDrawingProperties
        {
            get => GetElement<NonVisualPictureDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ApplicationNonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: p:nvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ApplicationNonVisualDrawingProperties ApplicationNonVisualDrawingProperties
        {
            get => GetElement<ApplicationNonVisualDrawingProperties>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualPictureDrawingProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingProperties), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualPictureProperties>(deep);
    }

    /// <summary>
    /// <para>Picture Fill.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:blipFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Blip &lt;a:blip></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SourceRectangle &lt;a:srcRect></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Tile &lt;a:tile></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Stretch &lt;a:stretch></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Blip))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SourceRectangle))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Tile))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Stretch))]
    [SchemaAttr(24, "blipFill")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BlipFill : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BlipFill class.
        /// </summary>
        public BlipFill() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFill(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFill(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BlipFill(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>DPI Setting</para>
        /// <para>Represents the following attribute in the schema: dpi</para>
        /// </summary>
        [SchemaAttr(0, "dpi")]
        [Index(0)]
        public UInt32Value Dpi { get; set; }

        /// <summary>
        /// <para>Rotate With Shape</para>
        /// <para>Represents the following attribute in the schema: rotWithShape</para>
        /// </summary>
        [SchemaAttr(0, "rotWithShape")]
        [Index(1)]
        public BooleanValue RotateWithShape { get; set; }

        /// <summary>
        /// <para>Blip.</para>
        /// <para>Represents the following element tag in the schema: a:blip.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Blip Blip
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Blip>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Source Rectangle.</para>
        /// <para>Represents the following element tag in the schema: a:srcRect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SourceRectangle SourceRectangle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blip), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SourceRectangle), 0, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Tile), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Stretch), 1, 1)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BlipFill>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Graphic Frame Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cNvGraphicFramePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GraphicFrameLocks &lt;a:graphicFrameLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
    [SchemaAttr(24, "cNvGraphicFramePr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NonVisualGraphicFrameDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class.
        /// </summary>
        public NonVisualGraphicFrameDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGraphicFrameDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Graphic Frame Locks.</para>
        /// <para>Represents the following element tag in the schema: a:graphicFrameLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GraphicFrameLocks GraphicFrameLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGraphicFrameDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Graphic Frame.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:nvGraphicFramePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;p:cNvPr></description></item>
    ///   <item><description>NonVisualGraphicFrameDrawingProperties &lt;p:cNvGraphicFramePr></description></item>
    ///   <item><description>ApplicationNonVisualDrawingProperties &lt;p:nvPr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualGraphicFrameDrawingProperties))]
    [ChildElementInfo(typeof(ApplicationNonVisualDrawingProperties))]
    [SchemaAttr(24, "nvGraphicFramePr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NonVisualGraphicFrameProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class.
        /// </summary>
        public NonVisualGraphicFrameProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGraphicFrameProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Non-Visual Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Graphic Frame Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cNvGraphicFramePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualGraphicFrameDrawingProperties NonVisualGraphicFrameDrawingProperties
        {
            get => GetElement<NonVisualGraphicFrameDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Application Non-Visual Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: p:nvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ApplicationNonVisualDrawingProperties ApplicationNonVisualDrawingProperties
        {
            get => GetElement<ApplicationNonVisualDrawingProperties>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualGraphicFrameDrawingProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingProperties), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGraphicFrameProperties>(deep);
    }

    /// <summary>
    /// <para>2D Transform for Graphic Frame.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:xfrm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Offset &lt;a:off></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extents &lt;a:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Offset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extents))]
    [SchemaAttr(24, "xfrm")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Transform : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Transform class.
        /// </summary>
        public Transform() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Transform(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>
        [SchemaAttr(0, "rot")]
        [Index(0)]
        public Int32Value Rotation { get; set; }

        /// <summary>
        /// <para>Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>
        [SchemaAttr(0, "flipH")]
        [Index(1)]
        public BooleanValue HorizontalFlip { get; set; }

        /// <summary>
        /// <para>Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>
        [SchemaAttr(0, "flipV")]
        [Index(2)]
        public BooleanValue VerticalFlip { get; set; }

        /// <summary>
        /// <para>Offset.</para>
        /// <para>Represents the following element tag in the schema: a:off.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Offset Offset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extents.</para>
        /// <para>Represents the following element tag in the schema: a:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Extents Extents
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Offset), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extents), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Group Shape Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cNvGrpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupShapeLocks &lt;a:grpSpLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupShapeLocks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList))]
    [SchemaAttr(24, "cNvGrpSpPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NonVisualGroupShapeDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class.
        /// </summary>
        public NonVisualGroupShapeDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGroupShapeDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>GroupShapeLocks.</para>
        /// <para>Represents the following element tag in the schema: a:grpSpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GroupShapeLocks GroupShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualGroupDrawingShapePropsExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList NonVisualGroupDrawingShapePropsExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupShapeLocks), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupShapeDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Slide Master Title Text Style.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:titleStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties &lt;a:defPPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties &lt;a:lvl1pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties &lt;a:lvl2pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties &lt;a:lvl3pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties &lt;a:lvl4pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties &lt;a:lvl5pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties &lt;a:lvl6pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties &lt;a:lvl7pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties &lt;a:lvl8pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties &lt;a:lvl9pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "titleStyle")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TitleStyle : TextListStyleType
    {
        /// <summary>
        /// Initializes a new instance of the TitleStyle class.
        /// </summary>
        public TitleStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitleStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TitleStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitleStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TitleStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitleStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TitleStyle(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TitleStyle>(deep);
    }

    /// <summary>
    /// <para>Slide Master Body Text Style.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bodyStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties &lt;a:defPPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties &lt;a:lvl1pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties &lt;a:lvl2pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties &lt;a:lvl3pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties &lt;a:lvl4pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties &lt;a:lvl5pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties &lt;a:lvl6pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties &lt;a:lvl7pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties &lt;a:lvl8pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties &lt;a:lvl9pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "bodyStyle")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BodyStyle : TextListStyleType
    {
        /// <summary>
        /// Initializes a new instance of the BodyStyle class.
        /// </summary>
        public BodyStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BodyStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BodyStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BodyStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BodyStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BodyStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BodyStyle(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BodyStyle>(deep);
    }

    /// <summary>
    /// <para>Slide Master Other Text Style.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:otherStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties &lt;a:defPPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties &lt;a:lvl1pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties &lt;a:lvl2pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties &lt;a:lvl3pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties &lt;a:lvl4pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties &lt;a:lvl5pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties &lt;a:lvl6pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties &lt;a:lvl7pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties &lt;a:lvl8pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties &lt;a:lvl9pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "otherStyle")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class OtherStyle : TextListStyleType
    {
        /// <summary>
        /// Initializes a new instance of the OtherStyle class.
        /// </summary>
        public OtherStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OtherStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OtherStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OtherStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OtherStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OtherStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OtherStyle(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OtherStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the DefaultTextStyle Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:defaultTextStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties &lt;a:defPPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties &lt;a:lvl1pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties &lt;a:lvl2pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties &lt;a:lvl3pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties &lt;a:lvl4pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties &lt;a:lvl5pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties &lt;a:lvl6pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties &lt;a:lvl7pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties &lt;a:lvl8pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties &lt;a:lvl9pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "defaultTextStyle")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class DefaultTextStyle : TextListStyleType
    {
        /// <summary>
        /// Initializes a new instance of the DefaultTextStyle class.
        /// </summary>
        public DefaultTextStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DefaultTextStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DefaultTextStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DefaultTextStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DefaultTextStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DefaultTextStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DefaultTextStyle(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultTextStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the NotesStyle Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:notesStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties &lt;a:defPPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties &lt;a:lvl1pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties &lt;a:lvl2pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties &lt;a:lvl3pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties &lt;a:lvl4pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties &lt;a:lvl5pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties &lt;a:lvl6pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties &lt;a:lvl7pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties &lt;a:lvl8pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties &lt;a:lvl9pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "notesStyle")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NotesStyle : TextListStyleType
    {
        /// <summary>
        /// Initializes a new instance of the NotesStyle class.
        /// </summary>
        public NotesStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesStyle(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the TextListStyleType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties &lt;a:defPPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties &lt;a:lvl1pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties &lt;a:lvl2pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties &lt;a:lvl3pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties &lt;a:lvl4pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties &lt;a:lvl5pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties &lt;a:lvl6pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties &lt;a:lvl7pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties &lt;a:lvl8pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties &lt;a:lvl9pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
    public abstract partial class TextListStyleType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextListStyleType class.
        /// </summary>
        protected TextListStyleType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextListStyleType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TextListStyleType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextListStyleType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TextListStyleType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextListStyleType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected TextListStyleType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Default Paragraph Style.</para>
        /// <para>Represents the following element tag in the schema: a:defPPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties DefaultParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 1 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl1pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties Level1ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 2 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl2pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties Level2ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 3 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl3pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties Level3ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 4 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl4pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties Level4ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 5 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl5pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties Level5ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 6 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl6pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties Level6ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 7 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl7pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties Level7ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 8 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl8pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties Level8ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 9 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl9pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties Level9ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    }

    /// <summary>
    /// <para>Slide Layout Id.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldLayoutId.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "sldLayoutId")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideLayoutId : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideLayoutId class.
        /// </summary>
        public SlideLayoutId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutId class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideLayoutId(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutId class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideLayoutId(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutId class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideLayoutId(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ID Tag</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [NumberValidator(MinInclusive = 2147483648L)]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public UInt32Value Id { get; set; }

        /// <summary>
        /// <para>ID Tag</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(1)]
        public StringValue RelationshipId { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideLayoutId>(deep);
    }

    /// <summary>
    /// <para>Common slide data for notes slides.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cSld.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Background &lt;p:bg></description></item>
    ///   <item><description>ShapeTree &lt;p:spTree></description></item>
    ///   <item><description>CustomerDataList &lt;p:custDataLst></description></item>
    ///   <item><description>ControlList &lt;p:controls></description></item>
    ///   <item><description>CommonSlideDataExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Background))]
    [ChildElementInfo(typeof(ShapeTree))]
    [ChildElementInfo(typeof(CustomerDataList))]
    [ChildElementInfo(typeof(ControlList))]
    [ChildElementInfo(typeof(CommonSlideDataExtensionList))]
    [SchemaAttr(24, "cSld")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommonSlideData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommonSlideData class.
        /// </summary>
        public CommonSlideData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonSlideData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonSlideData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonSlideData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonSlideData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonSlideData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommonSlideData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr(0, "name")]
        [Index(0)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>Slide Background.</para>
        /// <para>Represents the following element tag in the schema: p:bg.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Background Background
        {
            get => GetElement<Background>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Tree.</para>
        /// <para>Represents the following element tag in the schema: p:spTree.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ShapeTree ShapeTree
        {
            get => GetElement<ShapeTree>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Customer Data List.</para>
        /// <para>Represents the following element tag in the schema: p:custDataLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CustomerDataList CustomerDataList
        {
            get => GetElement<CustomerDataList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List of controls.</para>
        /// <para>Represents the following element tag in the schema: p:controls.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ControlList ControlList
        {
            get => GetElement<ControlList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CommonSlideDataExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonSlideDataExtensionList CommonSlideDataExtensionList
        {
            get => GetElement<CommonSlideDataExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Background), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ShapeTree), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CustomerDataList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ControlList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonSlideDataExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommonSlideData>(deep);
    }

    /// <summary>
    /// <para>Programmable Extensibility Tag.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:tag.</para>
    /// </summary>
    [SchemaAttr(24, "tag")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Tag : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Tag class.
        /// </summary>
        public Tag() : base()
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(0)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "val")]
        [Index(1)]
        public StringValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tag>(deep);
    }

    /// <summary>
    /// <para>Normal View Restored Left Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:restoredLeft.</para>
    /// </summary>
    [SchemaAttr(24, "restoredLeft")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class RestoredLeft : NormalViewPortionType
    {
        /// <summary>
        /// Initializes a new instance of the RestoredLeft class.
        /// </summary>
        public RestoredLeft() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RestoredLeft>(deep);
    }

    /// <summary>
    /// <para>Normal View Restored Top Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:restoredTop.</para>
    /// </summary>
    [SchemaAttr(24, "restoredTop")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class RestoredTop : NormalViewPortionType
    {
        /// <summary>
        /// Initializes a new instance of the RestoredTop class.
        /// </summary>
        public RestoredTop() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RestoredTop>(deep);
    }

    /// <summary>
    /// <para>Defines the NormalViewPortionType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class NormalViewPortionType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the NormalViewPortionType class.
        /// </summary>
        protected NormalViewPortionType() : base()
        {
        }

        /// <summary>
        /// <para>Normal View Dimension Size</para>
        /// <para>Represents the following attribute in the schema: sz</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "sz")]
        [Index(0)]
        public Int32Value Size { get; set; }

        /// <summary>
        /// <para>Auto Adjust Normal View</para>
        /// <para>Represents the following attribute in the schema: autoAdjust</para>
        /// </summary>
        [SchemaAttr(0, "autoAdjust")]
        [Index(1)]
        public BooleanValue AutoAdjust { get; set; }
    }

    /// <summary>
    /// <para>View Scale.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:scale.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ScaleX &lt;a:sx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ScaleY &lt;a:sy></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ScaleX))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ScaleY))]
    [SchemaAttr(24, "scale")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ScaleFactor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ScaleFactor class.
        /// </summary>
        public ScaleFactor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScaleFactor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScaleFactor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScaleFactor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScaleFactor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScaleFactor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ScaleFactor(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Horizontal Ratio.</para>
        /// <para>Represents the following element tag in the schema: a:sx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ScaleX ScaleX
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ScaleX>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Vertical Ratio.</para>
        /// <para>Represents the following element tag in the schema: a:sy.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ScaleY ScaleY
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ScaleY>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ScaleX), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ScaleY), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScaleFactor>(deep);
    }

    /// <summary>
    /// <para>View Origin.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:origin.</para>
    /// </summary>
    [SchemaAttr(24, "origin")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Origin : Point2DType
    {
        /// <summary>
        /// Initializes a new instance of the Origin class.
        /// </summary>
        public Origin() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Origin>(deep);
    }

    /// <summary>
    /// <para>Defines the Position Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:pos.</para>
    /// </summary>
    [SchemaAttr(24, "pos")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Position : Point2DType
    {
        /// <summary>
        /// Initializes a new instance of the Position class.
        /// </summary>
        public Position() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Position>(deep);
    }

    /// <summary>
    /// <para>Defines the Point2DType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class Point2DType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Point2DType class.
        /// </summary>
        protected Point2DType() : base()
        {
        }

        /// <summary>
        /// <para>X-Axis Coordinate</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = -27273042329600L, MaxInclusive = 27273042316900L)]
        [SchemaAttr(0, "x")]
        [Index(0)]
        public Int64Value X { get; set; }

        /// <summary>
        /// <para>Y-Axis Coordinate</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = -27273042329600L, MaxInclusive = 27273042316900L)]
        [SchemaAttr(0, "y")]
        [Index(1)]
        public Int64Value Y { get; set; }
    }

    /// <summary>
    /// <para>Base properties for Notes View.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cViewPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ScaleFactor &lt;p:scale></description></item>
    ///   <item><description>Origin &lt;p:origin></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ScaleFactor))]
    [ChildElementInfo(typeof(Origin))]
    [SchemaAttr(24, "cViewPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommonViewProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommonViewProperties class.
        /// </summary>
        public CommonViewProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonViewProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonViewProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonViewProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommonViewProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Variable Scale</para>
        /// <para>Represents the following attribute in the schema: varScale</para>
        /// </summary>
        [SchemaAttr(0, "varScale")]
        [Index(0)]
        public BooleanValue VariableScale { get; set; }

        /// <summary>
        /// <para>View Scale.</para>
        /// <para>Represents the following element tag in the schema: p:scale.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ScaleFactor ScaleFactor
        {
            get => GetElement<ScaleFactor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>View Origin.</para>
        /// <para>Represents the following element tag in the schema: p:origin.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Origin Origin
        {
            get => GetElement<Origin>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ScaleFactor), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Origin), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommonViewProperties>(deep);
    }

    /// <summary>
    /// <para>Presentation Slide.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sld.</para>
    /// </summary>
    [SchemaAttr(24, "sld")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class OutlineViewSlideListEntry : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OutlineViewSlideListEntry class.
        /// </summary>
        public OutlineViewSlideListEntry() : base()
        {
        }

        /// <summary>
        /// <para>Relationship Identifier</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>Collapsed</para>
        /// <para>Represents the following attribute in the schema: collapse</para>
        /// </summary>
        [SchemaAttr(0, "collapse")]
        [Index(1)]
        public BooleanValue Collapse { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OutlineViewSlideListEntry>(deep);
    }

    /// <summary>
    /// <para>List of Presentation Slides.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OutlineViewSlideListEntry &lt;p:sld></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OutlineViewSlideListEntry))]
    [SchemaAttr(24, "sldLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class OutlineViewSlideList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OutlineViewSlideList class.
        /// </summary>
        public OutlineViewSlideList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OutlineViewSlideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OutlineViewSlideList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OutlineViewSlideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OutlineViewSlideList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OutlineViewSlideList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OutlineViewSlideList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.OutlineViewSlideListEntry), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OutlineViewSlideList>(deep);
    }

    /// <summary>
    /// <para>A Guide.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:guide.</para>
    /// </summary>
    [SchemaAttr(24, "guide")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Guide : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Guide class.
        /// </summary>
        public Guide() : base()
        {
        }

        /// <summary>
        /// <para>Guide Orientation</para>
        /// <para>Represents the following attribute in the schema: orient</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "orient")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.DirectionValues> Orientation { get; set; }

        /// <summary>
        /// <para>Guide Position</para>
        /// <para>Represents the following attribute in the schema: pos</para>
        /// </summary>
        [SchemaAttr(0, "pos")]
        [Index(1)]
        public Int32Value Position { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Guide>(deep);
    }

    /// <summary>
    /// <para>List of Guides.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:guideLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Guide &lt;p:guide></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Guide))]
    [SchemaAttr(24, "guideLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class GuideList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GuideList class.
        /// </summary>
        public GuideList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GuideList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GuideList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GuideList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GuideList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 0, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Guide), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GuideList>(deep);
    }

    /// <summary>
    /// <para>Defines the CommonSlideViewProperties Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cSldViewPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonViewProperties &lt;p:cViewPr></description></item>
    ///   <item><description>GuideList &lt;p:guideLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonViewProperties))]
    [ChildElementInfo(typeof(GuideList))]
    [SchemaAttr(24, "cSldViewPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommonSlideViewProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommonSlideViewProperties class.
        /// </summary>
        public CommonSlideViewProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonSlideViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonSlideViewProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonSlideViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonSlideViewProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonSlideViewProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommonSlideViewProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Snap Objects to Grid</para>
        /// <para>Represents the following attribute in the schema: snapToGrid</para>
        /// </summary>
        [SchemaAttr(0, "snapToGrid")]
        [Index(0)]
        public BooleanValue SnapToGrid { get; set; }

        /// <summary>
        /// <para>Snap Objects to Objects</para>
        /// <para>Represents the following attribute in the schema: snapToObjects</para>
        /// </summary>
        [SchemaAttr(0, "snapToObjects")]
        [Index(1)]
        public BooleanValue SnapToObjects { get; set; }

        /// <summary>
        /// <para>Show Guides in View</para>
        /// <para>Represents the following attribute in the schema: showGuides</para>
        /// </summary>
        [SchemaAttr(0, "showGuides")]
        [Index(2)]
        public BooleanValue ShowGuides { get; set; }

        /// <summary>
        /// <para>Base properties for Slide View.</para>
        /// <para>Represents the following element tag in the schema: p:cViewPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonViewProperties CommonViewProperties
        {
            get => GetElement<CommonViewProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List of Guides.</para>
        /// <para>Represents the following element tag in the schema: p:guideLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public GuideList GuideList
        {
            get => GetElement<GuideList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonViewProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.GuideList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommonSlideViewProperties>(deep);
    }

    /// <summary>
    /// <para>Normal View Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:normalViewPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RestoredLeft &lt;p:restoredLeft></description></item>
    ///   <item><description>RestoredTop &lt;p:restoredTop></description></item>
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(RestoredLeft))]
    [ChildElementInfo(typeof(RestoredTop))]
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "normalViewPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NormalViewProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NormalViewProperties class.
        /// </summary>
        public NormalViewProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NormalViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NormalViewProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NormalViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NormalViewProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NormalViewProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NormalViewProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Show Outline Icons in Normal View</para>
        /// <para>Represents the following attribute in the schema: showOutlineIcons</para>
        /// </summary>
        [SchemaAttr(0, "showOutlineIcons")]
        [Index(0)]
        public BooleanValue ShowOutlineIcons { get; set; }

        /// <summary>
        /// <para>Snap Vertical Splitter</para>
        /// <para>Represents the following attribute in the schema: snapVertSplitter</para>
        /// </summary>
        [SchemaAttr(0, "snapVertSplitter")]
        [Index(1)]
        public BooleanValue SnapVerticalSplitter { get; set; }

        /// <summary>
        /// <para>State of the Vertical Splitter Bar</para>
        /// <para>Represents the following attribute in the schema: vertBarState</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "vertBarState")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.SplitterBarStateValues> VerticalBarState { get; set; }

        /// <summary>
        /// <para>State of the Horizontal Splitter Bar</para>
        /// <para>Represents the following attribute in the schema: horzBarState</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "horzBarState")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.SplitterBarStateValues> HorizontalBarState { get; set; }

        /// <summary>
        /// <para>Prefer Single View</para>
        /// <para>Represents the following attribute in the schema: preferSingleView</para>
        /// </summary>
        [SchemaAttr(0, "preferSingleView")]
        [Index(4)]
        public BooleanValue PreferSingleView { get; set; }

        /// <summary>
        /// <para>Normal View Restored Left Properties.</para>
        /// <para>Represents the following element tag in the schema: p:restoredLeft.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public RestoredLeft RestoredLeft
        {
            get => GetElement<RestoredLeft>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Normal View Restored Top Properties.</para>
        /// <para>Represents the following element tag in the schema: p:restoredTop.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public RestoredTop RestoredTop
        {
            get => GetElement<RestoredTop>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.RestoredLeft), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.RestoredTop), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NormalViewProperties>(deep);
    }

    /// <summary>
    /// <para>Slide View Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:slideViewPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonSlideViewProperties &lt;p:cSldViewPr></description></item>
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonSlideViewProperties))]
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "slideViewPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideViewProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideViewProperties class.
        /// </summary>
        public SlideViewProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideViewProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideViewProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideViewProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideViewProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>CommonSlideViewProperties.</para>
        /// <para>Represents the following element tag in the schema: p:cSldViewPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonSlideViewProperties CommonSlideViewProperties
        {
            get => GetElement<CommonSlideViewProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonSlideViewProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideViewProperties>(deep);
    }

    /// <summary>
    /// <para>Outline View Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:outlineViewPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonViewProperties &lt;p:cViewPr></description></item>
    ///   <item><description>OutlineViewSlideList &lt;p:sldLst></description></item>
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonViewProperties))]
    [ChildElementInfo(typeof(OutlineViewSlideList))]
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "outlineViewPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class OutlineViewProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OutlineViewProperties class.
        /// </summary>
        public OutlineViewProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OutlineViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OutlineViewProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OutlineViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OutlineViewProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OutlineViewProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OutlineViewProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Common View Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cViewPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonViewProperties CommonViewProperties
        {
            get => GetElement<CommonViewProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List of Presentation Slides.</para>
        /// <para>Represents the following element tag in the schema: p:sldLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public OutlineViewSlideList OutlineViewSlideList
        {
            get => GetElement<OutlineViewSlideList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonViewProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.OutlineViewSlideList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OutlineViewProperties>(deep);
    }

    /// <summary>
    /// <para>Notes Text View Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:notesTextViewPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonViewProperties &lt;p:cViewPr></description></item>
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonViewProperties))]
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "notesTextViewPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NotesTextViewProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NotesTextViewProperties class.
        /// </summary>
        public NotesTextViewProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesTextViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesTextViewProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesTextViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesTextViewProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesTextViewProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesTextViewProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Base properties for Notes View.</para>
        /// <para>Represents the following element tag in the schema: p:cViewPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonViewProperties CommonViewProperties
        {
            get => GetElement<CommonViewProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonViewProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesTextViewProperties>(deep);
    }

    /// <summary>
    /// <para>Slide Sorter View Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sorterViewPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonViewProperties &lt;p:cViewPr></description></item>
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonViewProperties))]
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "sorterViewPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SorterViewProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SorterViewProperties class.
        /// </summary>
        public SorterViewProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SorterViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SorterViewProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SorterViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SorterViewProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SorterViewProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SorterViewProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Show Formatting</para>
        /// <para>Represents the following attribute in the schema: showFormatting</para>
        /// </summary>
        [SchemaAttr(0, "showFormatting")]
        [Index(0)]
        public BooleanValue ShowFormatting { get; set; }

        /// <summary>
        /// <para>Base properties for Slide Sorter View.</para>
        /// <para>Represents the following element tag in the schema: p:cViewPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonViewProperties CommonViewProperties
        {
            get => GetElement<CommonViewProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonViewProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SorterViewProperties>(deep);
    }

    /// <summary>
    /// <para>Notes View Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:notesViewPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonSlideViewProperties &lt;p:cSldViewPr></description></item>
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonSlideViewProperties))]
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "notesViewPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NotesViewProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NotesViewProperties class.
        /// </summary>
        public NotesViewProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesViewProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesViewProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesViewProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesViewProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesViewProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Common Slide View Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cSldViewPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CommonSlideViewProperties CommonSlideViewProperties
        {
            get => GetElement<CommonSlideViewProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonSlideViewProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesViewProperties>(deep);
    }

    /// <summary>
    /// <para>Grid Spacing.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:gridSpacing.</para>
    /// </summary>
    [SchemaAttr(24, "gridSpacing")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class GridSpacing : PositiveSize2DType
    {
        /// <summary>
        /// Initializes a new instance of the GridSpacing class.
        /// </summary>
        public GridSpacing() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GridSpacing>(deep);
    }

    /// <summary>
    /// <para>Defines the NotesSize Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:notesSz.</para>
    /// </summary>
    [SchemaAttr(24, "notesSz")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NotesSize : PositiveSize2DType
    {
        /// <summary>
        /// Initializes a new instance of the NotesSize class.
        /// </summary>
        public NotesSize() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesSize>(deep);
    }

    /// <summary>
    /// <para>Defines the PositiveSize2DType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class PositiveSize2DType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PositiveSize2DType class.
        /// </summary>
        protected PositiveSize2DType() : base()
        {
        }

        /// <summary>
        /// <para>Extent Length</para>
        /// <para>Represents the following attribute in the schema: cx</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 2147483647L)]
        [SchemaAttr(0, "cx")]
        [Index(0)]
        public Int64Value Cx { get; set; }

        /// <summary>
        /// <para>Extent Width</para>
        /// <para>Represents the following attribute in the schema: cy</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 2147483647L)]
        [SchemaAttr(0, "cy")]
        [Index(1)]
        public Int64Value Cy { get; set; }
    }

    /// <summary>
    /// <para>Defines the SlideExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.LaserTraceList &lt;p14:laserTraceLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.ShowEventRecordList &lt;p14:showEvtLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.LaserTraceList), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ShowEventRecordList), FileFormatVersions.Office2010)]
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideExtension class.
        /// </summary>
        public SlideExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.LaserTraceList), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ShowEventRecordList), 1, 1, version: FileFormatVersions.Office2010),
            new AnyParticle(0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the CommonSlideDataExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.CreationId &lt;p14:creationId></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.CreationId), FileFormatVersions.Office2010)]
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommonSlideDataExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommonSlideDataExtension class.
        /// </summary>
        public CommonSlideDataExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonSlideDataExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonSlideDataExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonSlideDataExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonSlideDataExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonSlideDataExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommonSlideDataExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.CreationId), 1, 1, version: FileFormatVersions.Office2010),
            new AnyParticle(0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommonSlideDataExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowPropertiesExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.BrowseMode &lt;p14:browseMode></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.LaserColor &lt;p14:laserClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.ShowMediaControls &lt;p14:showMediaCtrls></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.BrowseMode), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.LaserColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ShowMediaControls), FileFormatVersions.Office2010)]
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ShowPropertiesExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShowPropertiesExtension class.
        /// </summary>
        public ShowPropertiesExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowPropertiesExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShowPropertiesExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowPropertiesExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShowPropertiesExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowPropertiesExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShowPropertiesExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.BrowseMode), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.LaserColor), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ShowMediaControls), 1, 1, version: FileFormatVersions.Office2010),
            new AnyParticle(0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowPropertiesExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the Picture Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:pic.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualPictureProperties &lt;p:nvPicPr></description></item>
    ///   <item><description>BlipFill &lt;p:blipFill></description></item>
    ///   <item><description>ShapeProperties &lt;p:spPr></description></item>
    ///   <item><description>ShapeStyle &lt;p:style></description></item>
    ///   <item><description>ExtensionListWithModification &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NonVisualPictureProperties))]
    [ChildElementInfo(typeof(BlipFill))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(ShapeStyle))]
    [ChildElementInfo(typeof(ExtensionListWithModification))]
    [SchemaAttr(24, "pic")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Picture : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Picture class.
        /// </summary>
        public Picture() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Picture(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Picture(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Picture(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Picture.</para>
        /// <para>Represents the following element tag in the schema: p:nvPicPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualPictureProperties NonVisualPictureProperties
        {
            get => GetElement<NonVisualPictureProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Picture Fill.</para>
        /// <para>Represents the following element tag in the schema: p:blipFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public BlipFill BlipFill
        {
            get => GetElement<BlipFill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: p:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeStyle.</para>
        /// <para>Represents the following element tag in the schema: p:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ShapeStyle ShapeStyle
        {
            get => GetElement<ShapeStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionListWithModification.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionListWithModification ExtensionListWithModification
        {
            get => GetElement<ExtensionListWithModification>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualPictureProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BlipFill), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ShapeProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ShapeStyle), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionListWithModification), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Picture>(deep);
    }

    /// <summary>
    /// <para>Defines the OleObjectEmbed Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:embed.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "embed")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class OleObjectEmbed : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OleObjectEmbed class.
        /// </summary>
        public OleObjectEmbed() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleObjectEmbed class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleObjectEmbed(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleObjectEmbed class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleObjectEmbed(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleObjectEmbed class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OleObjectEmbed(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Color Scheme Properties for OLE Object</para>
        /// <para>Represents the following attribute in the schema: followColorScheme</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "followColorScheme")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.OleObjectFollowColorSchemeValues> FollowColorScheme { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OleObjectEmbed>(deep);
    }

    /// <summary>
    /// <para>Defines the OleObjectLink Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:link.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "link")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class OleObjectLink : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OleObjectLink class.
        /// </summary>
        public OleObjectLink() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleObjectLink class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleObjectLink(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleObjectLink class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleObjectLink(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleObjectLink class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OleObjectLink(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Update Linked OLE Objects Automatically</para>
        /// <para>Represents the following attribute in the schema: updateAutomatic</para>
        /// </summary>
        [SchemaAttr(0, "updateAutomatic")]
        [Index(0)]
        public BooleanValue AutoUpdate { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OleObjectLink>(deep);
    }

    /// <summary>
    /// <para>Slide Transition.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:transition.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BlindsTransition &lt;p:blinds></description></item>
    ///   <item><description>CheckerTransition &lt;p:checker></description></item>
    ///   <item><description>CircleTransition &lt;p:circle></description></item>
    ///   <item><description>DissolveTransition &lt;p:dissolve></description></item>
    ///   <item><description>CombTransition &lt;p:comb></description></item>
    ///   <item><description>CoverTransition &lt;p:cover></description></item>
    ///   <item><description>CutTransition &lt;p:cut></description></item>
    ///   <item><description>DiamondTransition &lt;p:diamond></description></item>
    ///   <item><description>FadeTransition &lt;p:fade></description></item>
    ///   <item><description>NewsflashTransition &lt;p:newsflash></description></item>
    ///   <item><description>PlusTransition &lt;p:plus></description></item>
    ///   <item><description>PullTransition &lt;p:pull></description></item>
    ///   <item><description>PushTransition &lt;p:push></description></item>
    ///   <item><description>RandomTransition &lt;p:random></description></item>
    ///   <item><description>RandomBarTransition &lt;p:randomBar></description></item>
    ///   <item><description>SplitTransition &lt;p:split></description></item>
    ///   <item><description>StripsTransition &lt;p:strips></description></item>
    ///   <item><description>WedgeTransition &lt;p:wedge></description></item>
    ///   <item><description>WheelTransition &lt;p:wheel></description></item>
    ///   <item><description>WipeTransition &lt;p:wipe></description></item>
    ///   <item><description>ZoomTransition &lt;p:zoom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.FlashTransition &lt;p14:flash></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.VortexTransition &lt;p14:vortex></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.SwitchTransition &lt;p14:switch></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.FlipTransition &lt;p14:flip></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.RippleTransition &lt;p14:ripple></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.GlitterTransition &lt;p14:glitter></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.HoneycombTransition &lt;p14:honeycomb></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.PrismTransition &lt;p14:prism></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.DoorsTransition &lt;p14:doors></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.WindowTransition &lt;p14:window></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.ShredTransition &lt;p14:shred></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.FerrisTransition &lt;p14:ferris></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.FlythroughTransition &lt;p14:flythrough></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.WarpTransition &lt;p14:warp></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.GalleryTransition &lt;p14:gallery></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.ConveyorTransition &lt;p14:conveyor></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.PanTransition &lt;p14:pan></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.RevealTransition &lt;p14:reveal></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.WheelReverseTransition &lt;p14:wheelReverse></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.PowerPoint.PresetTransition &lt;p15:prstTrans></description></item>
    ///   <item><description>SoundAction &lt;p:sndAc></description></item>
    ///   <item><description>ExtensionListWithModification &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BlindsTransition))]
    [ChildElementInfo(typeof(CheckerTransition))]
    [ChildElementInfo(typeof(CircleTransition))]
    [ChildElementInfo(typeof(DissolveTransition))]
    [ChildElementInfo(typeof(CombTransition))]
    [ChildElementInfo(typeof(CoverTransition))]
    [ChildElementInfo(typeof(CutTransition))]
    [ChildElementInfo(typeof(DiamondTransition))]
    [ChildElementInfo(typeof(FadeTransition))]
    [ChildElementInfo(typeof(NewsflashTransition))]
    [ChildElementInfo(typeof(PlusTransition))]
    [ChildElementInfo(typeof(PullTransition))]
    [ChildElementInfo(typeof(PushTransition))]
    [ChildElementInfo(typeof(RandomTransition))]
    [ChildElementInfo(typeof(RandomBarTransition))]
    [ChildElementInfo(typeof(SplitTransition))]
    [ChildElementInfo(typeof(StripsTransition))]
    [ChildElementInfo(typeof(WedgeTransition))]
    [ChildElementInfo(typeof(WheelTransition))]
    [ChildElementInfo(typeof(WipeTransition))]
    [ChildElementInfo(typeof(ZoomTransition))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.FlashTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.VortexTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.SwitchTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.FlipTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.RippleTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.GlitterTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.HoneycombTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.PrismTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.DoorsTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.WindowTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ShredTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.FerrisTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.FlythroughTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.WarpTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.GalleryTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ConveyorTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.PanTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.RevealTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.WheelReverseTransition), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.PresetTransition), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(SoundAction))]
    [ChildElementInfo(typeof(ExtensionListWithModification))]
    [SchemaAttr(24, "transition")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Transition : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Transition class.
        /// </summary>
        public Transition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Transition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>spd</para>
        /// <para>Represents the following attribute in the schema: spd</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "spd")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSpeedValues> Speed { get; set; }

        /// <summary>
        /// <para>dur, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: p14:dur</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14=http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        [SchemaAttr(49, "dur")]
        [Index(1)]
        public StringValue Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether a mouse click will advance the slide.</para>
        /// <para>Represents the following attribute in the schema: advClick</para>
        /// </summary>
        [SchemaAttr(0, "advClick")]
        [Index(2)]
        public BooleanValue AdvanceOnClick { get; set; }

        /// <summary>
        /// <para>advTm</para>
        /// <para>Represents the following attribute in the schema: advTm</para>
        /// </summary>
        [NumberValidator(SimpleType = typeof(UInt32Value), Version = FileFormatVersions.Office2007)]
        [StringValidator(Version = FileFormatVersions.Office2010)]
        [StringValidator(InitialVersion = FileFormatVersions.Office2013)]
        [SchemaAttr(0, "advTm")]
        [Index(3)]
        public StringValue AdvanceAfterTime { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BlindsTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CheckerTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CircleTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.DissolveTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CombTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CoverTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CutTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.DiamondTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.FadeTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NewsflashTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PlusTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PullTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PushTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.RandomTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.RandomBarTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SplitTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.StripsTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.WedgeTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.WheelTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.WipeTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ZoomTransition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.FlashTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.VortexTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.SwitchTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.FlipTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.RippleTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.GlitterTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.HoneycombTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.PrismTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.DoorsTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.WindowTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ShredTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.FerrisTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.FlythroughTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.WarpTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.GalleryTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ConveyorTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.PanTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.RevealTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.WheelReverseTransition), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.PresetTransition), 1, 1, version: FileFormatVersions.Office2013)
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SoundAction), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionListWithModification), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transition>(deep);
    }

    /// <summary>
    /// <para>Slide Timing Information for a Slide.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:timing.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TimeNodeList &lt;p:tnLst></description></item>
    ///   <item><description>BuildList &lt;p:bldLst></description></item>
    ///   <item><description>ExtensionListWithModification &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TimeNodeList))]
    [ChildElementInfo(typeof(BuildList))]
    [ChildElementInfo(typeof(ExtensionListWithModification))]
    [SchemaAttr(24, "timing")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Timing : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Timing class.
        /// </summary>
        public Timing() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timing class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Timing(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timing class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Timing(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timing class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Timing(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>TimeNodeList.</para>
        /// <para>Represents the following element tag in the schema: p:tnLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TimeNodeList TimeNodeList
        {
            get => GetElement<TimeNodeList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Build List.</para>
        /// <para>Represents the following element tag in the schema: p:bldLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public BuildList BuildList
        {
            get => GetElement<BuildList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionListWithModification.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionListWithModification ExtensionListWithModification
        {
            get => GetElement<ExtensionListWithModification>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TimeNodeList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BuildList), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionListWithModification), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Timing>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlideExtension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlideExtension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideExtensionList class.
        /// </summary>
        public SlideExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideExtensionList>(deep);
    }

    /// <summary>
    /// <para>Slide Background.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:bg.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackgroundProperties &lt;p:bgPr></description></item>
    ///   <item><description>BackgroundStyleReference &lt;p:bgRef></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackgroundProperties))]
    [ChildElementInfo(typeof(BackgroundStyleReference))]
    [SchemaAttr(24, "bg")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Background : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Background class.
        /// </summary>
        public Background() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Background(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Background(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Background(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bwMode")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }

        /// <summary>
        /// <para>Background Properties.</para>
        /// <para>Represents the following element tag in the schema: p:bgPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public BackgroundProperties BackgroundProperties
        {
            get => GetElement<BackgroundProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Background Style Reference.</para>
        /// <para>Represents the following element tag in the schema: p:bgRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public BackgroundStyleReference BackgroundStyleReference
        {
            get => GetElement<BackgroundStyleReference>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BackgroundProperties), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BackgroundStyleReference), 1, 1)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Background>(deep);
    }

    /// <summary>
    /// <para>Shape Tree.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:spTree.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualGroupShapeProperties &lt;p:nvGrpSpPr></description></item>
    ///   <item><description>GroupShapeProperties &lt;p:grpSpPr></description></item>
    ///   <item><description>Shape &lt;p:sp></description></item>
    ///   <item><description>GroupShape &lt;p:grpSp></description></item>
    ///   <item><description>GraphicFrame &lt;p:graphicFrame></description></item>
    ///   <item><description>ConnectionShape &lt;p:cxnSp></description></item>
    ///   <item><description>Picture &lt;p:pic></description></item>
    ///   <item><description>ContentPart &lt;p:contentPart></description></item>
    ///   <item><description>ExtensionListWithModification &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "spTree")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ShapeTree : GroupShapeType
    {
        /// <summary>
        /// Initializes a new instance of the ShapeTree class.
        /// </summary>
        public ShapeTree() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeTree class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeTree(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeTree class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeTree(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeTree class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeTree(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualGroupShapeProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.GroupShapeProperties), 1, 1),
            new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Shape), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.GroupShape), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.GraphicFrame), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ConnectionShape), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Picture), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionListWithModification), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeTree>(deep);
    }

    /// <summary>
    /// <para>Group Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:grpSp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualGroupShapeProperties &lt;p:nvGrpSpPr></description></item>
    ///   <item><description>GroupShapeProperties &lt;p:grpSpPr></description></item>
    ///   <item><description>Shape &lt;p:sp></description></item>
    ///   <item><description>GroupShape &lt;p:grpSp></description></item>
    ///   <item><description>GraphicFrame &lt;p:graphicFrame></description></item>
    ///   <item><description>ConnectionShape &lt;p:cxnSp></description></item>
    ///   <item><description>Picture &lt;p:pic></description></item>
    ///   <item><description>ContentPart &lt;p:contentPart></description></item>
    ///   <item><description>ExtensionListWithModification &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "grpSp")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class GroupShape : GroupShapeType
    {
        /// <summary>
        /// Initializes a new instance of the GroupShape class.
        /// </summary>
        public GroupShape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShape(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualGroupShapeProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.GroupShapeProperties), 1, 1),
            new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Shape), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.GroupShape), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.GraphicFrame), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ConnectionShape), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Picture), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionListWithModification), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShape>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupShapeType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualGroupShapeProperties &lt;p:nvGrpSpPr></description></item>
    ///   <item><description>GroupShapeProperties &lt;p:grpSpPr></description></item>
    ///   <item><description>Shape &lt;p:sp></description></item>
    ///   <item><description>GroupShape &lt;p:grpSp></description></item>
    ///   <item><description>GraphicFrame &lt;p:graphicFrame></description></item>
    ///   <item><description>ConnectionShape &lt;p:cxnSp></description></item>
    ///   <item><description>Picture &lt;p:pic></description></item>
    ///   <item><description>ContentPart &lt;p:contentPart></description></item>
    ///   <item><description>ExtensionListWithModification &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NonVisualGroupShapeProperties))]
    [ChildElementInfo(typeof(GroupShapeProperties))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(GroupShape))]
    [ChildElementInfo(typeof(GraphicFrame))]
    [ChildElementInfo(typeof(ConnectionShape))]
    [ChildElementInfo(typeof(Picture))]
    [ChildElementInfo(typeof(ContentPart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionListWithModification))]
    public abstract partial class GroupShapeType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeType class.
        /// </summary>
        protected GroupShapeType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected GroupShapeType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected GroupShapeType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected GroupShapeType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Group Shape.</para>
        /// <para>Represents the following element tag in the schema: p:nvGrpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualGroupShapeProperties NonVisualGroupShapeProperties
        {
            get => GetElement<NonVisualGroupShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Group Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: p:grpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public GroupShapeProperties GroupShapeProperties
        {
            get => GetElement<GroupShapeProperties>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    }

    /// <summary>
    /// <para>Customer Data List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:custDataLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CustomerData &lt;p:custData></description></item>
    ///   <item><description>CustomerDataTags &lt;p:tags></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CustomerData))]
    [ChildElementInfo(typeof(CustomerDataTags))]
    [SchemaAttr(24, "custDataLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CustomerDataList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomerDataList class.
        /// </summary>
        public CustomerDataList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomerDataList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomerDataList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomerDataList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomerDataList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomerDataList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomerDataList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 0, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CustomerData), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CustomerDataTags), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomerDataList>(deep);
    }

    /// <summary>
    /// <para>List of controls.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:controls.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Control &lt;p:control></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Control))]
    [SchemaAttr(24, "controls")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ControlList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ControlList class.
        /// </summary>
        public ControlList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ControlList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ControlList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ControlList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ControlList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ControlList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ControlList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Control), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlList>(deep);
    }

    /// <summary>
    /// <para>Defines the CommonSlideDataExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommonSlideDataExtension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommonSlideDataExtension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommonSlideDataExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommonSlideDataExtensionList class.
        /// </summary>
        public CommonSlideDataExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonSlideDataExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonSlideDataExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonSlideDataExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommonSlideDataExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommonSlideDataExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommonSlideDataExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommonSlideDataExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommonSlideDataExtensionList>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Group Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:nvGrpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;p:cNvPr></description></item>
    ///   <item><description>NonVisualGroupShapeDrawingProperties &lt;p:cNvGrpSpPr></description></item>
    ///   <item><description>ApplicationNonVisualDrawingProperties &lt;p:nvPr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualGroupShapeDrawingProperties))]
    [ChildElementInfo(typeof(ApplicationNonVisualDrawingProperties))]
    [SchemaAttr(24, "nvGrpSpPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NonVisualGroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class.
        /// </summary>
        public NonVisualGroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGroupShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Non-visual Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Group Shape Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: p:cNvGrpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualGroupShapeDrawingProperties NonVisualGroupShapeDrawingProperties
        {
            get => GetElement<NonVisualGroupShapeDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: p:nvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ApplicationNonVisualDrawingProperties ApplicationNonVisualDrawingProperties
        {
            get => GetElement<ApplicationNonVisualDrawingProperties>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualGroupShapeDrawingProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingProperties), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Group Shape Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:grpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.TransformGroup &lt;a:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.TransformGroup))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
    [SchemaAttr(24, "grpSpPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class GroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class.
        /// </summary>
        public GroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bwMode")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }

        /// <summary>
        /// <para>2D Transform for Grouped Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.TransformGroup TransformGroup
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TransformGroup), 0, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                }
            },
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualShapeProperties &lt;p:nvSpPr></description></item>
    ///   <item><description>ShapeProperties &lt;p:spPr></description></item>
    ///   <item><description>ShapeStyle &lt;p:style></description></item>
    ///   <item><description>TextBody &lt;p:txBody></description></item>
    ///   <item><description>ExtensionListWithModification &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NonVisualShapeProperties))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(ShapeStyle))]
    [ChildElementInfo(typeof(TextBody))]
    [ChildElementInfo(typeof(ExtensionListWithModification))]
    [SchemaAttr(24, "sp")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Shape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape class.
        /// </summary>
        public Shape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Use Background Fill</para>
        /// <para>Represents the following attribute in the schema: useBgFill</para>
        /// </summary>
        [SchemaAttr(0, "useBgFill")]
        [Index(0)]
        public BooleanValue UseBackgroundFill { get; set; }

        /// <summary>
        /// <para>Non-Visual Properties for a Shape.</para>
        /// <para>Represents the following element tag in the schema: p:nvSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualShapeProperties NonVisualShapeProperties
        {
            get => GetElement<NonVisualShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: p:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Style.</para>
        /// <para>Represents the following element tag in the schema: p:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ShapeStyle ShapeStyle
        {
            get => GetElement<ShapeStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Text Body.</para>
        /// <para>Represents the following element tag in the schema: p:txBody.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TextBody TextBody
        {
            get => GetElement<TextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionListWithModification.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionListWithModification ExtensionListWithModification
        {
            get => GetElement<ExtensionListWithModification>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualShapeProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ShapeProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ShapeStyle), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TextBody), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionListWithModification), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);
    }

    /// <summary>
    /// <para>Graphic Frame.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:graphicFrame.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualGraphicFrameProperties &lt;p:nvGraphicFramePr></description></item>
    ///   <item><description>Transform &lt;p:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Graphic &lt;a:graphic></description></item>
    ///   <item><description>ExtensionListWithModification &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NonVisualGraphicFrameProperties))]
    [ChildElementInfo(typeof(Transform))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Graphic))]
    [ChildElementInfo(typeof(ExtensionListWithModification))]
    [SchemaAttr(24, "graphicFrame")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class GraphicFrame : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GraphicFrame class.
        /// </summary>
        public GraphicFrame() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrame class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrame(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrame class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrame(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrame class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GraphicFrame(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Graphic Frame.</para>
        /// <para>Represents the following element tag in the schema: p:nvGraphicFramePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualGraphicFrameProperties NonVisualGraphicFrameProperties
        {
            get => GetElement<NonVisualGraphicFrameProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>2D Transform for Graphic Frame.</para>
        /// <para>Represents the following element tag in the schema: p:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public Transform Transform
        {
            get => GetElement<Transform>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Graphic.</para>
        /// <para>Represents the following element tag in the schema: a:graphic.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Graphic Graphic
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Graphic>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extension List with Modification Flag.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionListWithModification ExtensionListWithModification
        {
            get => GetElement<ExtensionListWithModification>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualGraphicFrameProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Transform), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Graphic), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionListWithModification), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicFrame>(deep);
    }

    /// <summary>
    /// <para>Connection Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cxnSp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualConnectionShapeProperties &lt;p:nvCxnSpPr></description></item>
    ///   <item><description>ShapeProperties &lt;p:spPr></description></item>
    ///   <item><description>ShapeStyle &lt;p:style></description></item>
    ///   <item><description>ExtensionListWithModification &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NonVisualConnectionShapeProperties))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(ShapeStyle))]
    [ChildElementInfo(typeof(ExtensionListWithModification))]
    [SchemaAttr(24, "cxnSp")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ConnectionShape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionShape class.
        /// </summary>
        public ConnectionShape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectionShape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectionShape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionShape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConnectionShape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Connection Shape.</para>
        /// <para>Represents the following element tag in the schema: p:nvCxnSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NonVisualConnectionShapeProperties NonVisualConnectionShapeProperties
        {
            get => GetElement<NonVisualConnectionShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: p:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connector Shape Style.</para>
        /// <para>Represents the following element tag in the schema: p:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ShapeStyle ShapeStyle
        {
            get => GetElement<ShapeStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionListWithModification.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionListWithModification ExtensionListWithModification
        {
            get => GetElement<ExtensionListWithModification>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NonVisualConnectionShapeProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ShapeProperties), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ShapeStyle), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionListWithModification), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectionShape>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowPropertiesExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShowPropertiesExtension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ShowPropertiesExtension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ShowPropertiesExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShowPropertiesExtensionList class.
        /// </summary>
        public ShowPropertiesExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowPropertiesExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShowPropertiesExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowPropertiesExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShowPropertiesExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowPropertiesExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShowPropertiesExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ShowPropertiesExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowPropertiesExtensionList>(deep);
    }

    /// <summary>
    /// <para>Shape Target.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:spTgt.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackgroundAnimation &lt;p:bg></description></item>
    ///   <item><description>SubShape &lt;p:subSp></description></item>
    ///   <item><description>OleChartElement &lt;p:oleChartEl></description></item>
    ///   <item><description>TextElement &lt;p:txEl></description></item>
    ///   <item><description>GraphicElement &lt;p:graphicEl></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BackgroundAnimation))]
    [ChildElementInfo(typeof(SubShape))]
    [ChildElementInfo(typeof(OleChartElement))]
    [ChildElementInfo(typeof(TextElement))]
    [ChildElementInfo(typeof(GraphicElement))]
    [SchemaAttr(24, "spTgt")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ShapeTarget : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeTarget class.
        /// </summary>
        public ShapeTarget() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeTarget class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeTarget(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeTarget class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeTarget(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeTarget class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeTarget(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Shape ID</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(Version = FileFormatVersions.Office2007)]
        [NumberValidator(SimpleType = typeof(UInt32Value), Version = FileFormatVersions.Office2010)]
        [NumberValidator(SimpleType = typeof(UInt32Value), InitialVersion = FileFormatVersions.Office2013)]
        [SchemaAttr(0, "spid")]
        [Index(0)]
        public StringValue ShapeId { get; set; }

        /// <summary>
        /// <para>Background.</para>
        /// <para>Represents the following element tag in the schema: p:bg.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public BackgroundAnimation BackgroundAnimation
        {
            get => GetElement<BackgroundAnimation>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Subshape.</para>
        /// <para>Represents the following element tag in the schema: p:subSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public SubShape SubShape
        {
            get => GetElement<SubShape>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OLE Chart Element.</para>
        /// <para>Represents the following element tag in the schema: p:oleChartEl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public OleChartElement OleChartElement
        {
            get => GetElement<OleChartElement>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text Element.</para>
        /// <para>Represents the following element tag in the schema: p:txEl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TextElement TextElement
        {
            get => GetElement<TextElement>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Graphic Element.</para>
        /// <para>Represents the following element tag in the schema: p:graphicEl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public GraphicElement GraphicElement
        {
            get => GetElement<GraphicElement>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 0, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BackgroundAnimation), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SubShape), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.OleChartElement), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TextElement), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.GraphicElement), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeTarget>(deep);
    }

    /// <summary>
    /// <para>Ink Target.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:inkTgt.</para>
    /// </summary>
    [SchemaAttr(24, "inkTgt")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class InkTarget : TimeListSubShapeIdType
    {
        /// <summary>
        /// Initializes a new instance of the InkTarget class.
        /// </summary>
        public InkTarget() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InkTarget>(deep);
    }

    /// <summary>
    /// <para>Subshape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:subSp.</para>
    /// </summary>
    [SchemaAttr(24, "subSp")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SubShape : TimeListSubShapeIdType
    {
        /// <summary>
        /// Initializes a new instance of the SubShape class.
        /// </summary>
        public SubShape() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubShape>(deep);
    }

    /// <summary>
    /// <para>Defines the TimeListSubShapeIdType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class TimeListSubShapeIdType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeListSubShapeIdType class.
        /// </summary>
        protected TimeListSubShapeIdType() : base()
        {
        }

        /// <summary>
        /// <para>Shape ID</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "spid")]
        [Index(0)]
        public StringValue ShapeId { get; set; }
    }

    /// <summary>
    /// <para>Defines the CommentAuthorExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.PowerPoint.PresenceInfo &lt;p15:presenceInfo></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.PresenceInfo), FileFormatVersions.Office2013)]
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommentAuthorExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentAuthorExtension class.
        /// </summary>
        public CommentAuthorExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthorExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentAuthorExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthorExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentAuthorExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthorExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentAuthorExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.PresenceInfo), 1, 1, version: FileFormatVersions.Office2013),
            new AnyParticle(0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentAuthorExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.PowerPoint.ThreadingInfo &lt;p15:threadingInfo></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ThreadingInfo), FileFormatVersions.Office2013)]
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommentExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentExtension class.
        /// </summary>
        public CommentExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ThreadingInfo), 1, 1, version: FileFormatVersions.Office2013),
            new AnyParticle(0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideLayoutExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList &lt;p15:sldGuideLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList), FileFormatVersions.Office2013)]
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideLayoutExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideLayoutExtension class.
        /// </summary>
        public SlideLayoutExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideLayoutExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideLayoutExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideLayoutExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList), 1, 1, version: FileFormatVersions.Office2013),
            new AnyParticle(0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideLayoutExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideMasterExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList &lt;p15:sldGuideLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList), FileFormatVersions.Office2013)]
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideMasterExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideMasterExtension class.
        /// </summary>
        public SlideMasterExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMasterExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideMasterExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMasterExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideMasterExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMasterExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideMasterExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList), 1, 1, version: FileFormatVersions.Office2013),
            new AnyParticle(0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideMasterExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the HandoutMasterExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList &lt;p15:sldGuideLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList), FileFormatVersions.Office2013)]
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class HandoutMasterExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HandoutMasterExtension class.
        /// </summary>
        public HandoutMasterExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMasterExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HandoutMasterExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMasterExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HandoutMasterExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMasterExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HandoutMasterExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList), 1, 1, version: FileFormatVersions.Office2013),
            new AnyParticle(0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HandoutMasterExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the NotesMasterExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList &lt;p15:sldGuideLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList), FileFormatVersions.Office2013)]
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NotesMasterExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NotesMasterExtension class.
        /// </summary>
        public NotesMasterExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMasterExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMasterExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesMasterExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList), 1, 1, version: FileFormatVersions.Office2013),
            new AnyParticle(0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesMasterExtension>(deep);
    }

    /// <summary>
    /// <para>Placeholder Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ph.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionListWithModification &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionListWithModification))]
    [SchemaAttr(24, "ph")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PlaceholderShape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PlaceholderShape class.
        /// </summary>
        public PlaceholderShape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlaceholderShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlaceholderShape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlaceholderShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlaceholderShape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlaceholderShape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PlaceholderShape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Placeholder Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "type")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.PlaceholderValues> Type { get; set; }

        /// <summary>
        /// <para>Placeholder Orientation</para>
        /// <para>Represents the following attribute in the schema: orient</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "orient")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.DirectionValues> Orientation { get; set; }

        /// <summary>
        /// <para>Placeholder Size</para>
        /// <para>Represents the following attribute in the schema: sz</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "sz")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.PlaceholderSizeValues> Size { get; set; }

        /// <summary>
        /// <para>Placeholder Index</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [SchemaAttr(0, "idx")]
        [Index(3)]
        public UInt32Value Index { get; set; }

        /// <summary>
        /// <para>Placeholder has custom prompt</para>
        /// <para>Represents the following attribute in the schema: hasCustomPrompt</para>
        /// </summary>
        [SchemaAttr(0, "hasCustomPrompt")]
        [Index(4)]
        public BooleanValue HasCustomPrompt { get; set; }

        /// <summary>
        /// <para>ExtensionListWithModification.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionListWithModification ExtensionListWithModification
        {
            get => GetElement<ExtensionListWithModification>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionListWithModification), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlaceholderShape>(deep);
    }

    /// <summary>
    /// <para>Defines the ApplicationNonVisualDrawingPropertiesExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ApplicationNonVisualDrawingPropertiesExtension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ApplicationNonVisualDrawingPropertiesExtension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ApplicationNonVisualDrawingPropertiesExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingPropertiesExtensionList class.
        /// </summary>
        public ApplicationNonVisualDrawingPropertiesExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingPropertiesExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ApplicationNonVisualDrawingPropertiesExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingPropertiesExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ApplicationNonVisualDrawingPropertiesExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingPropertiesExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ApplicationNonVisualDrawingPropertiesExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingPropertiesExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplicationNonVisualDrawingPropertiesExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ApplicationNonVisualDrawingPropertiesExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.Media &lt;p14:media></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.ModificationId &lt;p14:modId></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.Media), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ModificationId), FileFormatVersions.Office2010)]
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ApplicationNonVisualDrawingPropertiesExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingPropertiesExtension class.
        /// </summary>
        public ApplicationNonVisualDrawingPropertiesExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingPropertiesExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ApplicationNonVisualDrawingPropertiesExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingPropertiesExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ApplicationNonVisualDrawingPropertiesExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingPropertiesExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ApplicationNonVisualDrawingPropertiesExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.Media), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ModificationId), 1, 1, version: FileFormatVersions.Office2010),
            new AnyParticle(0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplicationNonVisualDrawingPropertiesExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the Iterate Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:iterate.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TimeAbsolute &lt;p:tmAbs></description></item>
    ///   <item><description>TimePercentage &lt;p:tmPct></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TimeAbsolute))]
    [ChildElementInfo(typeof(TimePercentage))]
    [SchemaAttr(24, "iterate")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Iterate : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Iterate class.
        /// </summary>
        public Iterate() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Iterate class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Iterate(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Iterate class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Iterate(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Iterate class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Iterate(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Iterate Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "type")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.IterateValues> Type { get; set; }

        /// <summary>
        /// <para>Backwards</para>
        /// <para>Represents the following attribute in the schema: backwards</para>
        /// </summary>
        [SchemaAttr(0, "backwards")]
        [Index(1)]
        public BooleanValue Backwards { get; set; }

        /// <summary>
        /// <para>Time Absolute.</para>
        /// <para>Represents the following element tag in the schema: p:tmAbs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TimeAbsolute TimeAbsolute
        {
            get => GetElement<TimeAbsolute>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Time Percentage.</para>
        /// <para>Represents the following element tag in the schema: p:tmPct.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TimePercentage TimePercentage
        {
            get => GetElement<TimePercentage>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TimeAbsolute), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TimePercentage), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Iterate>(deep);
    }

    /// <summary>
    /// <para>Defines the ChildTimeNodeList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:childTnLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ParallelTimeNode &lt;p:par></description></item>
    ///   <item><description>SequenceTimeNode &lt;p:seq></description></item>
    ///   <item><description>ExclusiveTimeNode &lt;p:excl></description></item>
    ///   <item><description>Animate &lt;p:anim></description></item>
    ///   <item><description>AnimateColor &lt;p:animClr></description></item>
    ///   <item><description>AnimateEffect &lt;p:animEffect></description></item>
    ///   <item><description>AnimateMotion &lt;p:animMotion></description></item>
    ///   <item><description>AnimateRotation &lt;p:animRot></description></item>
    ///   <item><description>AnimateScale &lt;p:animScale></description></item>
    ///   <item><description>Command &lt;p:cmd></description></item>
    ///   <item><description>SetBehavior &lt;p:set></description></item>
    ///   <item><description>Audio &lt;p:audio></description></item>
    ///   <item><description>Video &lt;p:video></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "childTnLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ChildTimeNodeList : TimeTypeListType
    {
        /// <summary>
        /// Initializes a new instance of the ChildTimeNodeList class.
        /// </summary>
        public ChildTimeNodeList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChildTimeNodeList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChildTimeNodeList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChildTimeNodeList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChildTimeNodeList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChildTimeNodeList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChildTimeNodeList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 0)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ParallelTimeNode), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SequenceTimeNode), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExclusiveTimeNode), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Animate), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.AnimateColor), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.AnimateEffect), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.AnimateMotion), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.AnimateRotation), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.AnimateScale), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Command), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SetBehavior), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Audio), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Video), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChildTimeNodeList>(deep);
    }

    /// <summary>
    /// <para>Defines the SubTimeNodeList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:subTnLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ParallelTimeNode &lt;p:par></description></item>
    ///   <item><description>SequenceTimeNode &lt;p:seq></description></item>
    ///   <item><description>ExclusiveTimeNode &lt;p:excl></description></item>
    ///   <item><description>Animate &lt;p:anim></description></item>
    ///   <item><description>AnimateColor &lt;p:animClr></description></item>
    ///   <item><description>AnimateEffect &lt;p:animEffect></description></item>
    ///   <item><description>AnimateMotion &lt;p:animMotion></description></item>
    ///   <item><description>AnimateRotation &lt;p:animRot></description></item>
    ///   <item><description>AnimateScale &lt;p:animScale></description></item>
    ///   <item><description>Command &lt;p:cmd></description></item>
    ///   <item><description>SetBehavior &lt;p:set></description></item>
    ///   <item><description>Audio &lt;p:audio></description></item>
    ///   <item><description>Video &lt;p:video></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(24, "subTnLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SubTimeNodeList : TimeTypeListType
    {
        /// <summary>
        /// Initializes a new instance of the SubTimeNodeList class.
        /// </summary>
        public SubTimeNodeList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubTimeNodeList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubTimeNodeList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubTimeNodeList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubTimeNodeList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubTimeNodeList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SubTimeNodeList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 0)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ParallelTimeNode), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SequenceTimeNode), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExclusiveTimeNode), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Animate), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.AnimateColor), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.AnimateEffect), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.AnimateMotion), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.AnimateRotation), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.AnimateScale), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Command), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SetBehavior), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Audio), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Video), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubTimeNodeList>(deep);
    }

    /// <summary>
    /// <para>Defines the TimeTypeListType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ParallelTimeNode &lt;p:par></description></item>
    ///   <item><description>SequenceTimeNode &lt;p:seq></description></item>
    ///   <item><description>ExclusiveTimeNode &lt;p:excl></description></item>
    ///   <item><description>Animate &lt;p:anim></description></item>
    ///   <item><description>AnimateColor &lt;p:animClr></description></item>
    ///   <item><description>AnimateEffect &lt;p:animEffect></description></item>
    ///   <item><description>AnimateMotion &lt;p:animMotion></description></item>
    ///   <item><description>AnimateRotation &lt;p:animRot></description></item>
    ///   <item><description>AnimateScale &lt;p:animScale></description></item>
    ///   <item><description>Command &lt;p:cmd></description></item>
    ///   <item><description>SetBehavior &lt;p:set></description></item>
    ///   <item><description>Audio &lt;p:audio></description></item>
    ///   <item><description>Video &lt;p:video></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ParallelTimeNode))]
    [ChildElementInfo(typeof(SequenceTimeNode))]
    [ChildElementInfo(typeof(ExclusiveTimeNode))]
    [ChildElementInfo(typeof(Animate))]
    [ChildElementInfo(typeof(AnimateColor))]
    [ChildElementInfo(typeof(AnimateEffect))]
    [ChildElementInfo(typeof(AnimateMotion))]
    [ChildElementInfo(typeof(AnimateRotation))]
    [ChildElementInfo(typeof(AnimateScale))]
    [ChildElementInfo(typeof(Command))]
    [ChildElementInfo(typeof(SetBehavior))]
    [ChildElementInfo(typeof(Audio))]
    [ChildElementInfo(typeof(Video))]
    public abstract partial class TimeTypeListType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeTypeListType class.
        /// </summary>
        protected TimeTypeListType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeTypeListType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TimeTypeListType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeTypeListType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TimeTypeListType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeTypeListType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected TimeTypeListType(string outerXml) : base(outerXml)
        {
        }
    }

    /// <summary>
    /// <para>Defines the TimeAnimateValueList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:tavLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TimeAnimateValue &lt;p:tav></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TimeAnimateValue))]
    [SchemaAttr(24, "tavLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TimeAnimateValueList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeAnimateValueList class.
        /// </summary>
        public TimeAnimateValueList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeAnimateValueList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimeAnimateValueList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeAnimateValueList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimeAnimateValueList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimeAnimateValueList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimeAnimateValueList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TimeAnimateValue), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimeAnimateValueList>(deep);
    }

    /// <summary>
    /// <para>Defines the ByPosition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:by.</para>
    /// </summary>
    [SchemaAttr(24, "by")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ByPosition : TimeListType
    {
        /// <summary>
        /// Initializes a new instance of the ByPosition class.
        /// </summary>
        public ByPosition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ByPosition>(deep);
    }

    /// <summary>
    /// <para>Defines the FromPosition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:from.</para>
    /// </summary>
    [SchemaAttr(24, "from")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class FromPosition : TimeListType
    {
        /// <summary>
        /// Initializes a new instance of the FromPosition class.
        /// </summary>
        public FromPosition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FromPosition>(deep);
    }

    /// <summary>
    /// <para>Defines the ToPosition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:to.</para>
    /// </summary>
    [SchemaAttr(24, "to")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ToPosition : TimeListType
    {
        /// <summary>
        /// Initializes a new instance of the ToPosition class.
        /// </summary>
        public ToPosition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToPosition>(deep);
    }

    /// <summary>
    /// <para>Defines the RotationCenter Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:rCtr.</para>
    /// </summary>
    [SchemaAttr(24, "rCtr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class RotationCenter : TimeListType
    {
        /// <summary>
        /// Initializes a new instance of the RotationCenter class.
        /// </summary>
        public RotationCenter() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RotationCenter>(deep);
    }

    /// <summary>
    /// <para>Defines the TimeListType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class TimeListType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeListType class.
        /// </summary>
        protected TimeListType() : base()
        {
        }

        /// <summary>
        /// <para>X coordinate</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "x")]
        [Index(0)]
        public Int32Value X { get; set; }

        /// <summary>
        /// <para>Y coordinate</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "y")]
        [Index(1)]
        public Int32Value Y { get; set; }
    }

    /// <summary>
    /// <para>Defines the CommentAuthorExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommentAuthorExtension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommentAuthorExtension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommentAuthorExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentAuthorExtensionList class.
        /// </summary>
        public CommentAuthorExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthorExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentAuthorExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthorExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentAuthorExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthorExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentAuthorExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommentAuthorExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentAuthorExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommentExtension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommentExtension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CommentExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentExtensionList class.
        /// </summary>
        public CommentExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CommentExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideMasterIdList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldMasterIdLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlideMasterId &lt;p:sldMasterId></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlideMasterId))]
    [SchemaAttr(24, "sldMasterIdLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideMasterIdList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideMasterIdList class.
        /// </summary>
        public SlideMasterIdList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMasterIdList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideMasterIdList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMasterIdList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideMasterIdList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMasterIdList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideMasterIdList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideMasterId), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideMasterIdList>(deep);
    }

    /// <summary>
    /// <para>Defines the NotesMasterIdList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:notesMasterIdLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NotesMasterId &lt;p:notesMasterId></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NotesMasterId))]
    [SchemaAttr(24, "notesMasterIdLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NotesMasterIdList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NotesMasterIdList class.
        /// </summary>
        public NotesMasterIdList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterIdList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMasterIdList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterIdList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMasterIdList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterIdList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesMasterIdList(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Notes Master ID.</para>
        /// <para>Represents the following element tag in the schema: p:notesMasterId.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public NotesMasterId NotesMasterId
        {
            get => GetElement<NotesMasterId>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NotesMasterId), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesMasterIdList>(deep);
    }

    /// <summary>
    /// <para>Defines the HandoutMasterIdList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:handoutMasterIdLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>HandoutMasterId &lt;p:handoutMasterId></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(HandoutMasterId))]
    [SchemaAttr(24, "handoutMasterIdLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class HandoutMasterIdList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HandoutMasterIdList class.
        /// </summary>
        public HandoutMasterIdList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMasterIdList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HandoutMasterIdList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMasterIdList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HandoutMasterIdList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMasterIdList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HandoutMasterIdList(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Handout Master ID.</para>
        /// <para>Represents the following element tag in the schema: p:handoutMasterId.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public HandoutMasterId HandoutMasterId
        {
            get => GetElement<HandoutMasterId>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.HandoutMasterId), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HandoutMasterIdList>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideIdList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldIdLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlideId &lt;p:sldId></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlideId))]
    [SchemaAttr(24, "sldIdLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideIdList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideIdList class.
        /// </summary>
        public SlideIdList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideIdList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideIdList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideIdList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideIdList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideIdList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideIdList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideId), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideIdList>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideSize Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldSz.</para>
    /// </summary>
    [SchemaAttr(24, "sldSz")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideSize : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideSize class.
        /// </summary>
        public SlideSize() : base()
        {
        }

        /// <summary>
        /// <para>Extent Length</para>
        /// <para>Represents the following attribute in the schema: cx</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 914400L, MaxInclusive = 51206400L)]
        [SchemaAttr(0, "cx")]
        [Index(0)]
        public Int32Value Cx { get; set; }

        /// <summary>
        /// <para>Extent Width</para>
        /// <para>Represents the following attribute in the schema: cy</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 914400L, MaxInclusive = 51206400L)]
        [SchemaAttr(0, "cy")]
        [Index(1)]
        public Int32Value Cy { get; set; }

        /// <summary>
        /// <para>Type of Size</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "type")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.SlideSizeValues> Type { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideSize>(deep);
    }

    /// <summary>
    /// <para>Defines the EmbeddedFontList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:embeddedFontLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>EmbeddedFont &lt;p:embeddedFont></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(EmbeddedFont))]
    [SchemaAttr(24, "embeddedFontLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class EmbeddedFontList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EmbeddedFontList class.
        /// </summary>
        public EmbeddedFontList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedFontList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EmbeddedFontList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedFontList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EmbeddedFontList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedFontList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EmbeddedFontList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.EmbeddedFont), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EmbeddedFontList>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomShowList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:custShowLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CustomShow &lt;p:custShow></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CustomShow))]
    [SchemaAttr(24, "custShowLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CustomShowList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomShowList class.
        /// </summary>
        public CustomShowList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomShowList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomShowList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomShowList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomShowList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomShowList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomShowList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CustomShow), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomShowList>(deep);
    }

    /// <summary>
    /// <para>Defines the PhotoAlbum Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:photoAlbum.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "photoAlbum")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PhotoAlbum : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PhotoAlbum class.
        /// </summary>
        public PhotoAlbum() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PhotoAlbum class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PhotoAlbum(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PhotoAlbum class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PhotoAlbum(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PhotoAlbum class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PhotoAlbum(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White</para>
        /// <para>Represents the following attribute in the schema: bw</para>
        /// </summary>
        [SchemaAttr(0, "bw")]
        [Index(0)]
        public BooleanValue BlackWhite { get; set; }

        /// <summary>
        /// <para>Show/Hide Captions</para>
        /// <para>Represents the following attribute in the schema: showCaptions</para>
        /// </summary>
        [SchemaAttr(0, "showCaptions")]
        [Index(1)]
        public BooleanValue ShowCaptions { get; set; }

        /// <summary>
        /// <para>Photo Album Layout</para>
        /// <para>Represents the following attribute in the schema: layout</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "layout")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.PhotoAlbumLayoutValues> Layout { get; set; }

        /// <summary>
        /// <para>Frame Type</para>
        /// <para>Represents the following attribute in the schema: frame</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "frame")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.PhotoAlbumFrameShapeValues> Frame { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PhotoAlbum>(deep);
    }

    /// <summary>
    /// <para>Defines the Kinsoku Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:kinsoku.</para>
    /// </summary>
    [SchemaAttr(24, "kinsoku")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Kinsoku : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Kinsoku class.
        /// </summary>
        public Kinsoku() : base()
        {
        }

        /// <summary>
        /// <para>Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>
        [SchemaAttr(0, "lang")]
        [Index(0)]
        public StringValue Language { get; set; }

        /// <summary>
        /// <para>Invalid Kinsoku Start Characters</para>
        /// <para>Represents the following attribute in the schema: invalStChars</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "invalStChars")]
        [Index(1)]
        public StringValue InvalidStartChars { get; set; }

        /// <summary>
        /// <para>Invalid Kinsoku End Characters</para>
        /// <para>Represents the following attribute in the schema: invalEndChars</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "invalEndChars")]
        [Index(2)]
        public StringValue InvalidEndChars { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Kinsoku>(deep);
    }

    /// <summary>
    /// <para>Defines the ModificationVerifier Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:modifyVerifier.</para>
    /// </summary>
    [SchemaAttr(24, "modifyVerifier")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ModificationVerifier : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModificationVerifier class.
        /// </summary>
        public ModificationVerifier() : base()
        {
        }

        /// <summary>
        /// <para>Cryptographic Provider Type</para>
        /// <para>Represents the following attribute in the schema: cryptProviderType</para>
        /// </summary>
        [RequiredValidator(Version = FileFormatVersions.Office2007)]
        [RequiredValidator(IsRequired = false, InitialVersion = FileFormatVersions.Office2010)]
        [SchemaAttr(0, "cryptProviderType")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.CryptProviderValues> CryptographicProviderType { get; set; }

        /// <summary>
        /// <para>Cryptographic Algorithm Class</para>
        /// <para>Represents the following attribute in the schema: cryptAlgorithmClass</para>
        /// </summary>
        [RequiredValidator(Version = FileFormatVersions.Office2007)]
        [RequiredValidator(IsRequired = false, InitialVersion = FileFormatVersions.Office2010)]
        [SchemaAttr(0, "cryptAlgorithmClass")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.CryptAlgorithmClassValues> CryptographicAlgorithmClass { get; set; }

        /// <summary>
        /// <para>Cryptographic Algorithm Type</para>
        /// <para>Represents the following attribute in the schema: cryptAlgorithmType</para>
        /// </summary>
        [RequiredValidator(Version = FileFormatVersions.Office2007)]
        [RequiredValidator(IsRequired = false, InitialVersion = FileFormatVersions.Office2010)]
        [SchemaAttr(0, "cryptAlgorithmType")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.CryptAlgorithmValues> CryptographicAlgorithmType { get; set; }

        /// <summary>
        /// <para>Cryptographic Hashing Algorithm</para>
        /// <para>Represents the following attribute in the schema: cryptAlgorithmSid</para>
        /// </summary>
        [RequiredValidator(Version = FileFormatVersions.Office2007)]
        [RequiredValidator(IsRequired = false, InitialVersion = FileFormatVersions.Office2010)]
        [SchemaAttr(0, "cryptAlgorithmSid")]
        [Index(3)]
        public UInt32Value CryptographicAlgorithmSid { get; set; }

        /// <summary>
        /// <para>Iterations to Run Hashing Algorithm</para>
        /// <para>Represents the following attribute in the schema: spinCount</para>
        /// </summary>
        [RequiredValidator(Version = FileFormatVersions.Office2007)]
        [RequiredValidator(IsRequired = false, InitialVersion = FileFormatVersions.Office2010)]
        [SchemaAttr(0, "spinCount")]
        [Index(4)]
        public UInt32Value SpinCount { get; set; }

        /// <summary>
        /// <para>Salt for Password Verifier</para>
        /// <para>Represents the following attribute in the schema: saltData</para>
        /// </summary>
        [RequiredValidator(Version = FileFormatVersions.Office2007)]
        [RequiredValidator(IsRequired = false, InitialVersion = FileFormatVersions.Office2010)]
        [SchemaAttr(0, "saltData")]
        [Index(5)]
        public Base64BinaryValue SaltData { get; set; }

        /// <summary>
        /// <para>Password Hash</para>
        /// <para>Represents the following attribute in the schema: hashData</para>
        /// </summary>
        [RequiredValidator(Version = FileFormatVersions.Office2007)]
        [RequiredValidator(IsRequired = false, InitialVersion = FileFormatVersions.Office2010)]
        [SchemaAttr(0, "hashData")]
        [Index(6)]
        public StringValue HashData { get; set; }

        /// <summary>
        /// <para>Cryptographic Provider</para>
        /// <para>Represents the following attribute in the schema: cryptProvider</para>
        /// </summary>
        [SchemaAttr(0, "cryptProvider")]
        [Index(7)]
        public StringValue CryptographicProvider { get; set; }

        /// <summary>
        /// <para>Cryptographic Algorithm Extensibility</para>
        /// <para>Represents the following attribute in the schema: algIdExt</para>
        /// </summary>
        [SchemaAttr(0, "algIdExt")]
        [Index(8)]
        public UInt32Value ExtendedCryptographicAlgorithm { get; set; }

        /// <summary>
        /// <para>Algorithm Extensibility Source</para>
        /// <para>Represents the following attribute in the schema: algIdExtSource</para>
        /// </summary>
        [SchemaAttr(0, "algIdExtSource")]
        [Index(9)]
        public StringValue ExtendedCryptographicAlgorithmSource { get; set; }

        /// <summary>
        /// <para>Cryptographic Provider Type Extensibility</para>
        /// <para>Represents the following attribute in the schema: cryptProviderTypeExt</para>
        /// </summary>
        [SchemaAttr(0, "cryptProviderTypeExt")]
        [Index(10)]
        public UInt32Value CryptographicProviderTypeExtensibility { get; set; }

        /// <summary>
        /// <para>Provider Type Extensibility Source</para>
        /// <para>Represents the following attribute in the schema: cryptProviderTypeExtSource</para>
        /// </summary>
        [SchemaAttr(0, "cryptProviderTypeExtSource")]
        [Index(11)]
        public StringValue CryptographicProviderTypeExtensibilitySource { get; set; }

        /// <summary>
        /// <para>algorithmName, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: algorithmName</para>
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        [SchemaAttr(0, "algorithmName")]
        [Index(12)]
        public StringValue AlgorithmName { get; set; }

        /// <summary>
        /// <para>hashValue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hashValue</para>
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        [SchemaAttr(0, "hashValue")]
        [Index(13)]
        public Base64BinaryValue HashValue { get; set; }

        /// <summary>
        /// <para>saltValue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: saltValue</para>
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        [SchemaAttr(0, "saltValue")]
        [Index(14)]
        public Base64BinaryValue SaltValue { get; set; }

        /// <summary>
        /// <para>spinValue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: spinValue</para>
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        [SchemaAttr(0, "spinValue")]
        [Index(15)]
        public UInt32Value SpinValue { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModificationVerifier>(deep);
    }

    /// <summary>
    /// <para>Defines the PresentationExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PresentationExtension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PresentationExtension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PresentationExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PresentationExtensionList class.
        /// </summary>
        public PresentationExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PresentationExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PresentationExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresentationExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the PresentationExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.SectionProperties &lt;p14:sectionPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.SectionList &lt;p14:sectionLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList &lt;p15:sldGuideLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.PowerPoint.NotesGuideList &lt;p15:notesGuideLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.SectionProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.SectionList), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.NotesGuideList), FileFormatVersions.Office2013)]
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PresentationExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PresentationExtension class.
        /// </summary>
        public PresentationExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PresentationExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.SectionProperties), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.SectionList), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.NotesGuideList), 1, 1, version: FileFormatVersions.Office2013),
            new AnyParticle(0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresentationExtension>(deep);
    }

    /// <summary>
    /// <para>HTML Publishing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:htmlPubPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlideAll &lt;p:sldAll></description></item>
    ///   <item><description>SlideRange &lt;p:sldRg></description></item>
    ///   <item><description>CustomShowReference &lt;p:custShow></description></item>
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlideAll))]
    [ChildElementInfo(typeof(SlideRange))]
    [ChildElementInfo(typeof(CustomShowReference))]
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "htmlPubPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class HtmlPublishProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HtmlPublishProperties class.
        /// </summary>
        public HtmlPublishProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HtmlPublishProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HtmlPublishProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HtmlPublishProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HtmlPublishProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HtmlPublishProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HtmlPublishProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Show Speaker Notes</para>
        /// <para>Represents the following attribute in the schema: showSpeakerNotes</para>
        /// </summary>
        [SchemaAttr(0, "showSpeakerNotes")]
        [Index(0)]
        public BooleanValue ShowSpeakerNotes { get; set; }

        /// <summary>
        /// <para>Browser Support Target</para>
        /// <para>Represents the following attribute in the schema: pubBrowser</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "pubBrowser")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.HtmlPublishWebBrowserSupportValues> TargetBrowser { get; set; }

        /// <summary>
        /// <para>Publish Path</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(2)]
        public StringValue Id { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideAll), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideRange), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CustomShowReference), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HtmlPublishProperties>(deep);
    }

    /// <summary>
    /// <para>Web Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:webPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "webPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class WebProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WebProperties class.
        /// </summary>
        public WebProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Show animation in HTML output</para>
        /// <para>Represents the following attribute in the schema: showAnimation</para>
        /// </summary>
        [SchemaAttr(0, "showAnimation")]
        [Index(0)]
        public BooleanValue ShowAnimation { get; set; }

        /// <summary>
        /// <para>Resize graphics in HTML output</para>
        /// <para>Represents the following attribute in the schema: resizeGraphics</para>
        /// </summary>
        [SchemaAttr(0, "resizeGraphics")]
        [Index(1)]
        public BooleanValue ResizeGraphics { get; set; }

        /// <summary>
        /// <para>Allow PNG in HTML output</para>
        /// <para>Represents the following attribute in the schema: allowPng</para>
        /// </summary>
        [SchemaAttr(0, "allowPng")]
        [Index(2)]
        public BooleanValue AllowPng { get; set; }

        /// <summary>
        /// <para>Rely on VML for HTML output</para>
        /// <para>Represents the following attribute in the schema: relyOnVml</para>
        /// </summary>
        [SchemaAttr(0, "relyOnVml")]
        [Index(3)]
        public BooleanValue RelyOnVml { get; set; }

        /// <summary>
        /// <para>Organize HTML output in folders</para>
        /// <para>Represents the following attribute in the schema: organizeInFolders</para>
        /// </summary>
        [SchemaAttr(0, "organizeInFolders")]
        [Index(4)]
        public BooleanValue OrganizeInFolders { get; set; }

        /// <summary>
        /// <para>Use long file names in HTML output</para>
        /// <para>Represents the following attribute in the schema: useLongFilenames</para>
        /// </summary>
        [SchemaAttr(0, "useLongFilenames")]
        [Index(5)]
        public BooleanValue UseLongFilenames { get; set; }

        /// <summary>
        /// <para>Image size for HTML output</para>
        /// <para>Represents the following attribute in the schema: imgSz</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "imgSz")]
        [Index(6)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.WebScreenSizeValues> ImageSize { get; set; }

        /// <summary>
        /// <para>Encoding for HTML output</para>
        /// <para>Represents the following attribute in the schema: encoding</para>
        /// </summary>
        [SchemaAttr(0, "encoding")]
        [Index(7)]
        public StringValue Encoding { get; set; }

        /// <summary>
        /// <para>Slide Navigation Colors for HTML output</para>
        /// <para>Represents the following attribute in the schema: clr</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "clr")]
        [Index(8)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.WebColorValues> Color { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the PrintingProperties Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:prnPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "prnPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PrintingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PrintingProperties class.
        /// </summary>
        public PrintingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrintingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PrintingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrintingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PrintingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrintingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PrintingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Print Output</para>
        /// <para>Represents the following attribute in the schema: prnWhat</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "prnWhat")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.PrintOutputValues> PrintWhat { get; set; }

        /// <summary>
        /// <para>Print Color Mode</para>
        /// <para>Represents the following attribute in the schema: clrMode</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "clrMode")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.PrintColorModeValues> ColorMode { get; set; }

        /// <summary>
        /// <para>Print Hidden Slides</para>
        /// <para>Represents the following attribute in the schema: hiddenSlides</para>
        /// </summary>
        [SchemaAttr(0, "hiddenSlides")]
        [Index(2)]
        public BooleanValue HiddenSlides { get; set; }

        /// <summary>
        /// <para>Scale to Fit Paper when printing</para>
        /// <para>Represents the following attribute in the schema: scaleToFitPaper</para>
        /// </summary>
        [SchemaAttr(0, "scaleToFitPaper")]
        [Index(3)]
        public BooleanValue ScaleToFitPaper { get; set; }

        /// <summary>
        /// <para>Frame slides when printing</para>
        /// <para>Represents the following attribute in the schema: frameSlides</para>
        /// </summary>
        [SchemaAttr(0, "frameSlides")]
        [Index(4)]
        public BooleanValue FrameSlides { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrintingProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowProperties Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:showPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PresenterSlideMode &lt;p:present></description></item>
    ///   <item><description>BrowseSlideMode &lt;p:browse></description></item>
    ///   <item><description>KioskSlideMode &lt;p:kiosk></description></item>
    ///   <item><description>SlideAll &lt;p:sldAll></description></item>
    ///   <item><description>SlideRange &lt;p:sldRg></description></item>
    ///   <item><description>CustomShowReference &lt;p:custShow></description></item>
    ///   <item><description>PenColor &lt;p:penClr></description></item>
    ///   <item><description>ShowPropertiesExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PresenterSlideMode))]
    [ChildElementInfo(typeof(BrowseSlideMode))]
    [ChildElementInfo(typeof(KioskSlideMode))]
    [ChildElementInfo(typeof(SlideAll))]
    [ChildElementInfo(typeof(SlideRange))]
    [ChildElementInfo(typeof(CustomShowReference))]
    [ChildElementInfo(typeof(PenColor))]
    [ChildElementInfo(typeof(ShowPropertiesExtensionList))]
    [SchemaAttr(24, "showPr")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ShowProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShowProperties class.
        /// </summary>
        public ShowProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShowProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShowProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShowProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Loop Slide Show</para>
        /// <para>Represents the following attribute in the schema: loop</para>
        /// </summary>
        [SchemaAttr(0, "loop")]
        [Index(0)]
        public BooleanValue Loop { get; set; }

        /// <summary>
        /// <para>Show Narration in Slide Show</para>
        /// <para>Represents the following attribute in the schema: showNarration</para>
        /// </summary>
        [SchemaAttr(0, "showNarration")]
        [Index(1)]
        public BooleanValue ShowNarration { get; set; }

        /// <summary>
        /// <para>Show Animation in Slide Show</para>
        /// <para>Represents the following attribute in the schema: showAnimation</para>
        /// </summary>
        [SchemaAttr(0, "showAnimation")]
        [Index(2)]
        public BooleanValue ShowAnimation { get; set; }

        /// <summary>
        /// <para>Use Timings in Slide Show</para>
        /// <para>Represents the following attribute in the schema: useTimings</para>
        /// </summary>
        [SchemaAttr(0, "useTimings")]
        [Index(3)]
        public BooleanValue UseTimings { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 0, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PresenterSlideMode), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BrowseSlideMode), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.KioskSlideMode), 1, 1)
                }
            },
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideAll), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideRange), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CustomShowReference), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PenColor), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ShowPropertiesExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorMostRecentlyUsed Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:clrMru.</para>
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
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HslColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SystemColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetColor))]
    [SchemaAttr(24, "clrMru")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ColorMostRecentlyUsed : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorMostRecentlyUsed class.
        /// </summary>
        public ColorMostRecentlyUsed() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMostRecentlyUsed class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorMostRecentlyUsed(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMostRecentlyUsed class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorMostRecentlyUsed(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMostRecentlyUsed class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorMostRecentlyUsed(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1, requireFilter: true)
        {
            new CompositeParticle(ParticleType.Group, 0, 10, version: FileFormatVersions.Office2007)
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
            },
            new CompositeParticle(ParticleType.Group, 0, 0, version: FileFormatVersions.Office2010)
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
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorMostRecentlyUsed>(deep);
    }

    /// <summary>
    /// <para>Defines the PresentationPropertiesExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PresentationPropertiesExtension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PresentationPropertiesExtension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PresentationPropertiesExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PresentationPropertiesExtensionList class.
        /// </summary>
        public PresentationPropertiesExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationPropertiesExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationPropertiesExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationPropertiesExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationPropertiesExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationPropertiesExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PresentationPropertiesExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PresentationPropertiesExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresentationPropertiesExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the PresentationPropertiesExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.DiscardImageEditData &lt;p14:discardImageEditData></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.PowerPoint.DefaultImageDpi &lt;p14:defaultImageDpi></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Drawing.TextMath &lt;a14:m></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.PowerPoint.ChartTrackingReferenceBased &lt;p15:chartTrackingRefBased></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.DiscardImageEditData), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.DefaultImageDpi), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.TextMath), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ChartTrackingReferenceBased), FileFormatVersions.Office2010)]
    [SchemaAttr(24, "ext")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PresentationPropertiesExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PresentationPropertiesExtension class.
        /// </summary>
        public PresentationPropertiesExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationPropertiesExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationPropertiesExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationPropertiesExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationPropertiesExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationPropertiesExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PresentationPropertiesExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.DiscardImageEditData), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.DefaultImageDpi), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.TextMath), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ChartTrackingReferenceBased), 1, 1, version: FileFormatVersions.Office2010),
            new AnyParticle(0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresentationPropertiesExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the HeaderFooter Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:hf.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionListWithModification &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionListWithModification))]
    [SchemaAttr(24, "hf")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class HeaderFooter : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HeaderFooter class.
        /// </summary>
        public HeaderFooter() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HeaderFooter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HeaderFooter(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HeaderFooter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HeaderFooter(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HeaderFooter class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HeaderFooter(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Slide Number Placeholder</para>
        /// <para>Represents the following attribute in the schema: sldNum</para>
        /// </summary>
        [SchemaAttr(0, "sldNum")]
        [Index(0)]
        public BooleanValue SlideNumber { get; set; }

        /// <summary>
        /// <para>Header Placeholder</para>
        /// <para>Represents the following attribute in the schema: hdr</para>
        /// </summary>
        [SchemaAttr(0, "hdr")]
        [Index(1)]
        public BooleanValue Header { get; set; }

        /// <summary>
        /// <para>Footer Placeholder</para>
        /// <para>Represents the following attribute in the schema: ftr</para>
        /// </summary>
        [SchemaAttr(0, "ftr")]
        [Index(2)]
        public BooleanValue Footer { get; set; }

        /// <summary>
        /// <para>Date/Time Placeholder</para>
        /// <para>Represents the following attribute in the schema: dt</para>
        /// </summary>
        [SchemaAttr(0, "dt")]
        [Index(3)]
        public BooleanValue DateTime { get; set; }

        /// <summary>
        /// <para>ExtensionListWithModification.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionListWithModification ExtensionListWithModification
        {
            get => GetElement<ExtensionListWithModification>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionListWithModification), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeaderFooter>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideLayoutExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlideLayoutExtension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlideLayoutExtension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideLayoutExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideLayoutExtensionList class.
        /// </summary>
        public SlideLayoutExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideLayoutExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideLayoutExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideLayoutExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideLayoutExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideLayoutExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideLayoutIdList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sldLayoutIdLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlideLayoutId &lt;p:sldLayoutId></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlideLayoutId))]
    [SchemaAttr(24, "sldLayoutIdLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideLayoutIdList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideLayoutIdList class.
        /// </summary>
        public SlideLayoutIdList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutIdList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideLayoutIdList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutIdList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideLayoutIdList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutIdList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideLayoutIdList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideLayoutId), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideLayoutIdList>(deep);
    }

    /// <summary>
    /// <para>Defines the TextStyles Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:txStyles.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TitleStyle &lt;p:titleStyle></description></item>
    ///   <item><description>BodyStyle &lt;p:bodyStyle></description></item>
    ///   <item><description>OtherStyle &lt;p:otherStyle></description></item>
    ///   <item><description>ExtensionList &lt;p:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TitleStyle))]
    [ChildElementInfo(typeof(BodyStyle))]
    [ChildElementInfo(typeof(OtherStyle))]
    [ChildElementInfo(typeof(ExtensionList))]
    [SchemaAttr(24, "txStyles")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TextStyles : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextStyles class.
        /// </summary>
        public TextStyles() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextStyles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextStyles(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextStyles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextStyles(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextStyles class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextStyles(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Slide Master Title Text Style.</para>
        /// <para>Represents the following element tag in the schema: p:titleStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public TitleStyle TitleStyle
        {
            get => GetElement<TitleStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Slide Master Body Text Style.</para>
        /// <para>Represents the following element tag in the schema: p:bodyStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public BodyStyle BodyStyle
        {
            get => GetElement<BodyStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Slide Master Other Text Style.</para>
        /// <para>Represents the following element tag in the schema: p:otherStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public OtherStyle OtherStyle
        {
            get => GetElement<OtherStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.TitleStyle), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.BodyStyle), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.OtherStyle), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextStyles>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideMasterExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlideMasterExtension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlideMasterExtension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SlideMasterExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideMasterExtensionList class.
        /// </summary>
        public SlideMasterExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMasterExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideMasterExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMasterExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideMasterExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMasterExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideMasterExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.SlideMasterExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideMasterExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the HandoutMasterExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>HandoutMasterExtension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(HandoutMasterExtension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class HandoutMasterExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HandoutMasterExtensionList class.
        /// </summary>
        public HandoutMasterExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMasterExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HandoutMasterExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMasterExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HandoutMasterExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMasterExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HandoutMasterExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.HandoutMasterExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HandoutMasterExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the NotesMasterExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NotesMasterExtension &lt;p:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NotesMasterExtension))]
    [SchemaAttr(24, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class NotesMasterExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NotesMasterExtensionList class.
        /// </summary>
        public NotesMasterExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMasterExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMasterExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesMasterExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.NotesMasterExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesMasterExtensionList>(deep);
    }

    /// <summary>
    /// <para>OLE Chart Element.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:oleChartEl.</para>
    /// </summary>
    [SchemaAttr(24, "oleChartEl")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class OleChartElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OleChartElement class.
        /// </summary>
        public OleChartElement() : base()
        {
        }

        /// <summary>
        /// <para>Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "type")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.ChartSubElementValues> Type { get; set; }

        /// <summary>
        /// <para>Level</para>
        /// <para>Represents the following attribute in the schema: lvl</para>
        /// </summary>
        [SchemaAttr(0, "lvl")]
        [Index(1)]
        public UInt32Value Level { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OleChartElement>(deep);
    }

    /// <summary>
    /// <para>Text Element.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:txEl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CharRange &lt;p:charRg></description></item>
    ///   <item><description>ParagraphIndexRange &lt;p:pRg></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CharRange))]
    [ChildElementInfo(typeof(ParagraphIndexRange))]
    [SchemaAttr(24, "txEl")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class TextElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextElement class.
        /// </summary>
        public TextElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextElement(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Character Range.</para>
        /// <para>Represents the following element tag in the schema: p:charRg.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public CharRange CharRange
        {
            get => GetElement<CharRange>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Paragraph Text Range.</para>
        /// <para>Represents the following element tag in the schema: p:pRg.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public ParagraphIndexRange ParagraphIndexRange
        {
            get => GetElement<ParagraphIndexRange>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 0, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CharRange), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ParagraphIndexRange), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextElement>(deep);
    }

    /// <summary>
    /// <para>Graphic Element.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:graphicEl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Diagram &lt;a:dgm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Chart &lt;a:chart></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Diagram))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Chart))]
    [SchemaAttr(24, "graphicEl")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class GraphicElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GraphicElement class.
        /// </summary>
        public GraphicElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GraphicElement(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Diagram to Animate.</para>
        /// <para>Represents the following element tag in the schema: a:dgm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagram Diagram
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagram>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart to Animate.</para>
        /// <para>Represents the following element tag in the schema: a:chart.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Chart Chart
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Chart>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagram), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Chart), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicElement>(deep);
    }

    /// <summary>
    /// <para>Defines the BlindsTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:blinds.</para>
    /// </summary>
    [SchemaAttr(24, "blinds")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class BlindsTransition : OrientationTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the BlindsTransition class.
        /// </summary>
        public BlindsTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BlindsTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the CheckerTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:checker.</para>
    /// </summary>
    [SchemaAttr(24, "checker")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CheckerTransition : OrientationTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the CheckerTransition class.
        /// </summary>
        public CheckerTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CheckerTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the CombTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:comb.</para>
    /// </summary>
    [SchemaAttr(24, "comb")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CombTransition : OrientationTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the CombTransition class.
        /// </summary>
        public CombTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CombTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the RandomBarTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:randomBar.</para>
    /// </summary>
    [SchemaAttr(24, "randomBar")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class RandomBarTransition : OrientationTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the RandomBarTransition class.
        /// </summary>
        public RandomBarTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RandomBarTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the OrientationTransitionType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OrientationTransitionType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OrientationTransitionType class.
        /// </summary>
        protected OrientationTransitionType() : base()
        {
        }

        /// <summary>
        /// <para>Transition Direction</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "dir")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.DirectionValues> Direction { get; set; }
    }

    /// <summary>
    /// <para>Defines the CoverTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cover.</para>
    /// </summary>
    [SchemaAttr(24, "cover")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CoverTransition : EightDirectionTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the CoverTransition class.
        /// </summary>
        public CoverTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CoverTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the PullTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:pull.</para>
    /// </summary>
    [SchemaAttr(24, "pull")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PullTransition : EightDirectionTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the PullTransition class.
        /// </summary>
        public PullTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PullTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the EightDirectionTransitionType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class EightDirectionTransitionType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the EightDirectionTransitionType class.
        /// </summary>
        protected EightDirectionTransitionType() : base()
        {
        }

        /// <summary>
        /// <para>Direction</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [EnumValidator(SimpleType = typeof(EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSlideDirectionValues>), UnionId = 0)]
        [EnumValidator(SimpleType = typeof(EnumValue<DocumentFormat.OpenXml.Presentation.TransitionCornerDirectionValues>), UnionId = 0)]
        [SchemaAttr(0, "dir")]
        [Index(0)]
        public StringValue Direction { get; set; }
    }

    /// <summary>
    /// <para>Defines the CutTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:cut.</para>
    /// </summary>
    [SchemaAttr(24, "cut")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CutTransition : OptionalBlackTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the CutTransition class.
        /// </summary>
        public CutTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CutTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the FadeTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:fade.</para>
    /// </summary>
    [SchemaAttr(24, "fade")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class FadeTransition : OptionalBlackTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the FadeTransition class.
        /// </summary>
        public FadeTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FadeTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the OptionalBlackTransitionType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OptionalBlackTransitionType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OptionalBlackTransitionType class.
        /// </summary>
        protected OptionalBlackTransitionType() : base()
        {
        }

        /// <summary>
        /// <para>Transition Through Black</para>
        /// <para>Represents the following attribute in the schema: thruBlk</para>
        /// </summary>
        [SchemaAttr(0, "thruBlk")]
        [Index(0)]
        public BooleanValue ThroughBlack { get; set; }
    }

    /// <summary>
    /// <para>Defines the PushTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:push.</para>
    /// </summary>
    [SchemaAttr(24, "push")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PushTransition : SideDirectionTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the PushTransition class.
        /// </summary>
        public PushTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PushTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the WipeTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:wipe.</para>
    /// </summary>
    [SchemaAttr(24, "wipe")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class WipeTransition : SideDirectionTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the WipeTransition class.
        /// </summary>
        public WipeTransition() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WipeTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the SideDirectionTransitionType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class SideDirectionTransitionType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SideDirectionTransitionType class.
        /// </summary>
        protected SideDirectionTransitionType() : base()
        {
        }

        /// <summary>
        /// <para>Direction</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "dir")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSlideDirectionValues> Direction { get; set; }
    }

    /// <summary>
    /// <para>Defines the SplitTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:split.</para>
    /// </summary>
    [SchemaAttr(24, "split")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SplitTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SplitTransition class.
        /// </summary>
        public SplitTransition() : base()
        {
        }

        /// <summary>
        /// <para>Orientation</para>
        /// <para>Represents the following attribute in the schema: orient</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "orient")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.DirectionValues> Orientation { get; set; }

        /// <summary>
        /// <para>Direction</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "dir")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionInOutDirectionValues> Direction { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the StripsTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:strips.</para>
    /// </summary>
    [SchemaAttr(24, "strips")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class StripsTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the StripsTransition class.
        /// </summary>
        public StripsTransition() : base()
        {
        }

        /// <summary>
        /// <para>Direction</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "dir")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionCornerDirectionValues> Direction { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StripsTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the WheelTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:wheel.</para>
    /// </summary>
    [SchemaAttr(24, "wheel")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class WheelTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the WheelTransition class.
        /// </summary>
        public WheelTransition() : base()
        {
        }

        /// <summary>
        /// <para>Spokes</para>
        /// <para>Represents the following attribute in the schema: spokes</para>
        /// </summary>
        [SchemaAttr(0, "spokes")]
        [Index(0)]
        public UInt32Value Spokes { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WheelTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the ZoomTransition Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:zoom.</para>
    /// </summary>
    [SchemaAttr(24, "zoom")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ZoomTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ZoomTransition class.
        /// </summary>
        public ZoomTransition() : base()
        {
        }

        /// <summary>
        /// <para>Direction</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "dir")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionInOutDirectionValues> Direction { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ZoomTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the SoundAction Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p:sndAc.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StartSoundAction &lt;p:stSnd></description></item>
    ///   <item><description>EndSoundAction &lt;p:endSnd></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(StartSoundAction))]
    [ChildElementInfo(typeof(EndSoundAction))]
    [SchemaAttr(24, "sndAc")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SoundAction : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SoundAction class.
        /// </summary>
        public SoundAction() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SoundAction class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SoundAction(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SoundAction class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SoundAction(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SoundAction class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SoundAction(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Start Sound Action.</para>
        /// <para>Represents the following element tag in the schema: p:stSnd.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public StartSoundAction StartSoundAction
        {
            get => GetElement<StartSoundAction>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Stop Sound Action.</para>
        /// <para>Represents the following element tag in the schema: p:endSnd.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public EndSoundAction EndSoundAction
        {
            get => GetElement<EndSoundAction>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.StartSoundAction), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.EndSoundAction), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SoundAction>(deep);
    }

    /// <summary>
    /// Transition Slide Direction Type
    /// </summary>
    public enum TransitionSlideDirectionValues
    {
        ///<summary>
        ///Transition Slide Direction Enum ( Left ).
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        Left,
        ///<summary>
        ///Transition Slide Direction Enum ( Up ).
        ///<para>When the item is serialized out as xml, its value is "u".</para>
        ///</summary>
        [EnumString("u")]
        Up,
        ///<summary>
        ///Transition Slide Direction ( Right ).
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        Right,
        ///<summary>
        ///Transition Slide Direction Enum ( Down ).
        ///<para>When the item is serialized out as xml, its value is "d".</para>
        ///</summary>
        [EnumString("d")]
        Down,
    }

    /// <summary>
    /// Transition Corner Direction Type
    /// </summary>
    public enum TransitionCornerDirectionValues
    {
        ///<summary>
        ///Transition Corner Direction Enum ( Left-Up ).
        ///<para>When the item is serialized out as xml, its value is "lu".</para>
        ///</summary>
        [EnumString("lu")]
        LeftUp,
        ///<summary>
        ///Transition Corner Direction Enum ( Right-Up ).
        ///<para>When the item is serialized out as xml, its value is "ru".</para>
        ///</summary>
        [EnumString("ru")]
        RightUp,
        ///<summary>
        ///Transition Corner Direction Enum ( Left-Down ).
        ///<para>When the item is serialized out as xml, its value is "ld".</para>
        ///</summary>
        [EnumString("ld")]
        LeftDown,
        ///<summary>
        ///Transition Corner Direction Enum ( Right-Down ).
        ///<para>When the item is serialized out as xml, its value is "rd".</para>
        ///</summary>
        [EnumString("rd")]
        RightDown,
    }

    /// <summary>
    /// Transition In/Out Direction Type
    /// </summary>
    public enum TransitionInOutDirectionValues
    {
        ///<summary>
        ///Transition In/Out Direction Enum ( Out ).
        ///<para>When the item is serialized out as xml, its value is "out".</para>
        ///</summary>
        [EnumString("out")]
        Out,
        ///<summary>
        ///Transition In/Out Direction Enum ( In ).
        ///<para>When the item is serialized out as xml, its value is "in".</para>
        ///</summary>
        [EnumString("in")]
        In,
    }

    /// <summary>
    /// Transition Speed
    /// </summary>
    public enum TransitionSpeedValues
    {
        ///<summary>
        ///low.
        ///<para>When the item is serialized out as xml, its value is "slow".</para>
        ///</summary>
        [EnumString("slow")]
        Slow,
        ///<summary>
        ///Medium.
        ///<para>When the item is serialized out as xml, its value is "med".</para>
        ///</summary>
        [EnumString("med")]
        Medium,
        ///<summary>
        ///Fast.
        ///<para>When the item is serialized out as xml, its value is "fast".</para>
        ///</summary>
        [EnumString("fast")]
        Fast,
    }

    /// <summary>
    /// Indefinite Time Declaration
    /// </summary>
    public enum IndefiniteTimeDeclarationValues
    {
        ///<summary>
        ///Indefinite Type Enum.
        ///<para>When the item is serialized out as xml, its value is "indefinite".</para>
        ///</summary>
        [EnumString("indefinite")]
        Indefinite,
    }

    /// <summary>
    /// Iterate Type
    /// </summary>
    public enum IterateValues
    {
        ///<summary>
        ///Element.
        ///<para>When the item is serialized out as xml, its value is "el".</para>
        ///</summary>
        [EnumString("el")]
        Element,
        ///<summary>
        ///Word.
        ///<para>When the item is serialized out as xml, its value is "wd".</para>
        ///</summary>
        [EnumString("wd")]
        Word,
        ///<summary>
        ///Letter.
        ///<para>When the item is serialized out as xml, its value is "lt".</para>
        ///</summary>
        [EnumString("lt")]
        Letter,
    }

    /// <summary>
    /// Chart Subelement Type
    /// </summary>
    public enum ChartSubElementValues
    {
        ///<summary>
        ///Chart Build Element Type Enum ( Grid Legend ).
        ///<para>When the item is serialized out as xml, its value is "gridLegend".</para>
        ///</summary>
        [EnumString("gridLegend")]
        GridLegend,
        ///<summary>
        ///Chart Build Element Type Enum ( Series ).
        ///<para>When the item is serialized out as xml, its value is "series".</para>
        ///</summary>
        [EnumString("series")]
        Series,
        ///<summary>
        ///Chart Build Element Type Enum ( Category ).
        ///<para>When the item is serialized out as xml, its value is "category".</para>
        ///</summary>
        [EnumString("category")]
        Category,
        ///<summary>
        ///Chart Build Element Type Enum ( Point in Series ).
        ///<para>When the item is serialized out as xml, its value is "ptInSeries".</para>
        ///</summary>
        [EnumString("ptInSeries")]
        PointInSeries,
        ///<summary>
        ///Chart Build Element Type Enum ( Point in Cat ).
        ///<para>When the item is serialized out as xml, its value is "ptInCategory".</para>
        ///</summary>
        [EnumString("ptInCategory")]
        PointInCategory,
    }

    /// <summary>
    /// Trigger RunTime Node
    /// </summary>
    public enum TriggerRuntimeNodeValues
    {
        ///<summary>
        ///Trigger RunTime Node ( First ).
        ///<para>When the item is serialized out as xml, its value is "first".</para>
        ///</summary>
        [EnumString("first")]
        First,
        ///<summary>
        ///Trigger RunTime Node ( Last ).
        ///<para>When the item is serialized out as xml, its value is "last".</para>
        ///</summary>
        [EnumString("last")]
        Last,
        ///<summary>
        ///Trigger RunTime Node Enum ( All ).
        ///<para>When the item is serialized out as xml, its value is "all".</para>
        ///</summary>
        [EnumString("all")]
        All,
    }

    /// <summary>
    /// Time Node Preset Class Type
    /// </summary>
    public enum TimeNodePresetClassValues
    {
        ///<summary>
        ///Preset Type Enum ( Entrance ).
        ///<para>When the item is serialized out as xml, its value is "entr".</para>
        ///</summary>
        [EnumString("entr")]
        Entrance,
        ///<summary>
        ///Exit.
        ///<para>When the item is serialized out as xml, its value is "exit".</para>
        ///</summary>
        [EnumString("exit")]
        Exit,
        ///<summary>
        ///Preset Type Enum ( Emphasis ).
        ///<para>When the item is serialized out as xml, its value is "emph".</para>
        ///</summary>
        [EnumString("emph")]
        Emphasis,
        ///<summary>
        ///Preset Type Enum ( Path ).
        ///<para>When the item is serialized out as xml, its value is "path".</para>
        ///</summary>
        [EnumString("path")]
        Path,
        ///<summary>
        ///Preset Type Enum ( Verb ).
        ///<para>When the item is serialized out as xml, its value is "verb".</para>
        ///</summary>
        [EnumString("verb")]
        Verb,
        ///<summary>
        ///Preset Type Enum ( Media Call ).
        ///<para>When the item is serialized out as xml, its value is "mediacall".</para>
        ///</summary>
        [EnumString("mediacall")]
        MediaCall,
    }

    /// <summary>
    /// Time Node Restart Type
    /// </summary>
    public enum TimeNodeRestartValues
    {
        ///<summary>
        ///Restart Enum ( Always ).
        ///<para>When the item is serialized out as xml, its value is "always".</para>
        ///</summary>
        [EnumString("always")]
        Always,
        ///<summary>
        ///Restart Enum ( When Not Active ).
        ///<para>When the item is serialized out as xml, its value is "whenNotActive".</para>
        ///</summary>
        [EnumString("whenNotActive")]
        WhenNotActive,
        ///<summary>
        ///Restart Enum ( Never ).
        ///<para>When the item is serialized out as xml, its value is "never".</para>
        ///</summary>
        [EnumString("never")]
        Never,
    }

    /// <summary>
    /// Time Node Fill Type
    /// </summary>
    public enum TimeNodeFillValues
    {
        ///<summary>
        ///Remove.
        ///<para>When the item is serialized out as xml, its value is "remove".</para>
        ///</summary>
        [EnumString("remove")]
        Remove,
        ///<summary>
        ///Freeze.
        ///<para>When the item is serialized out as xml, its value is "freeze".</para>
        ///</summary>
        [EnumString("freeze")]
        Freeze,
        ///<summary>
        ///TimeNode Fill Type Enum ( Hold ).
        ///<para>When the item is serialized out as xml, its value is "hold".</para>
        ///</summary>
        [EnumString("hold")]
        Hold,
        ///<summary>
        ///Transition.
        ///<para>When the item is serialized out as xml, its value is "transition".</para>
        ///</summary>
        [EnumString("transition")]
        Transition,
    }

    /// <summary>
    /// Time Node Type
    /// </summary>
    public enum TimeNodeValues
    {
        ///<summary>
        ///Node Type Enum ( Click Effect ).
        ///<para>When the item is serialized out as xml, its value is "clickEffect".</para>
        ///</summary>
        [EnumString("clickEffect")]
        ClickEffect,
        ///<summary>
        ///Node Type Enum ( With Effect ).
        ///<para>When the item is serialized out as xml, its value is "withEffect".</para>
        ///</summary>
        [EnumString("withEffect")]
        WithEffect,
        ///<summary>
        ///Node Type Enum ( After Effect ).
        ///<para>When the item is serialized out as xml, its value is "afterEffect".</para>
        ///</summary>
        [EnumString("afterEffect")]
        AfterEffect,
        ///<summary>
        ///Node Type Enum ( Main Sequence ).
        ///<para>When the item is serialized out as xml, its value is "mainSeq".</para>
        ///</summary>
        [EnumString("mainSeq")]
        MainSequence,
        ///<summary>
        ///Node Type Enum ( Interactive Sequence ).
        ///<para>When the item is serialized out as xml, its value is "interactiveSeq".</para>
        ///</summary>
        [EnumString("interactiveSeq")]
        InteractiveSequence,
        ///<summary>
        ///Node Type Enum ( Click Paragraph ).
        ///<para>When the item is serialized out as xml, its value is "clickPar".</para>
        ///</summary>
        [EnumString("clickPar")]
        ClickParagraph,
        ///<summary>
        ///Node Type Enum ( With Group ).
        ///<para>When the item is serialized out as xml, its value is "withGroup".</para>
        ///</summary>
        [EnumString("withGroup")]
        WithGroup,
        ///<summary>
        ///Node Type Enum ( After Group ).
        ///<para>When the item is serialized out as xml, its value is "afterGroup".</para>
        ///</summary>
        [EnumString("afterGroup")]
        AfterGroup,
        ///<summary>
        ///Node Type Enum ( Timing Root ).
        ///<para>When the item is serialized out as xml, its value is "tmRoot".</para>
        ///</summary>
        [EnumString("tmRoot")]
        TmingRoot,
    }

    /// <summary>
    /// Next Action Type
    /// </summary>
    public enum NextActionValues
    {
        ///<summary>
        ///Next Action Type Enum ( None ).
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Next Action Type Enum ( Seek ).
        ///<para>When the item is serialized out as xml, its value is "seek".</para>
        ///</summary>
        [EnumString("seek")]
        Seek,
    }

    /// <summary>
    /// Previous Action Type
    /// </summary>
    public enum PreviousActionValues
    {
        ///<summary>
        ///Previous Action Type Enum ( None ).
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Previous Action Type Enum ( Skip Timed ).
        ///<para>When the item is serialized out as xml, its value is "skipTimed".</para>
        ///</summary>
        [EnumString("skipTimed")]
        SkipTimed,
    }

    /// <summary>
    /// Behavior Additive Type
    /// </summary>
    public enum BehaviorAdditiveValues
    {
        ///<summary>
        ///Additive Enum ( Base ).
        ///<para>When the item is serialized out as xml, its value is "base".</para>
        ///</summary>
        [EnumString("base")]
        Base,
        ///<summary>
        ///Additive Enum ( Sum ).
        ///<para>When the item is serialized out as xml, its value is "sum".</para>
        ///</summary>
        [EnumString("sum")]
        Sum,
        ///<summary>
        ///Additive Enum ( Replace ).
        ///<para>When the item is serialized out as xml, its value is "repl".</para>
        ///</summary>
        [EnumString("repl")]
        Replace,
        ///<summary>
        ///Additive Enum ( Multiply ).
        ///<para>When the item is serialized out as xml, its value is "mult".</para>
        ///</summary>
        [EnumString("mult")]
        Multiply,
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
    }

    /// <summary>
    /// Behavior Accumulate Type
    /// </summary>
    public enum BehaviorAccumulateValues
    {
        ///<summary>
        ///Accumulate Enum ( None ).
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Accumulate Enum ( Always ).
        ///<para>When the item is serialized out as xml, its value is "always".</para>
        ///</summary>
        [EnumString("always")]
        Always,
    }

    /// <summary>
    /// Behavior Transform Type
    /// </summary>
    public enum BehaviorTransformValues
    {
        ///<summary>
        ///Point.
        ///<para>When the item is serialized out as xml, its value is "pt".</para>
        ///</summary>
        [EnumString("pt")]
        Point,
        ///<summary>
        ///Image.
        ///<para>When the item is serialized out as xml, its value is "img".</para>
        ///</summary>
        [EnumString("img")]
        Image,
    }

    /// <summary>
    /// Behavior Override Type
    /// </summary>
    public enum BehaviorOverrideValues
    {
        ///<summary>
        ///Override Enum ( Normal ).
        ///<para>When the item is serialized out as xml, its value is "normal".</para>
        ///</summary>
        [EnumString("normal")]
        Normal,
        ///<summary>
        ///Override Enum ( Child Style ).
        ///<para>When the item is serialized out as xml, its value is "childStyle".</para>
        ///</summary>
        [EnumString("childStyle")]
        ChildStyle,
    }

    /// <summary>
    /// Time List Animate Behavior Calculate Mode
    /// </summary>
    public enum AnimateBehaviorCalculateModeValues
    {
        ///<summary>
        ///Calc Mode Enum ( Discrete ).
        ///<para>When the item is serialized out as xml, its value is "discrete".</para>
        ///</summary>
        [EnumString("discrete")]
        Discrete,
        ///<summary>
        ///Calc Mode Enum ( Linear ).
        ///<para>When the item is serialized out as xml, its value is "lin".</para>
        ///</summary>
        [EnumString("lin")]
        Linear,
        ///<summary>
        ///Calc Mode Enum ( Formula ).
        ///<para>When the item is serialized out as xml, its value is "fmla".</para>
        ///</summary>
        [EnumString("fmla")]
        Formula,
    }

    /// <summary>
    /// Time List Animate Behavior Value Types
    /// </summary>
    public enum AnimateBehaviorValues
    {
        ///<summary>
        ///Value Type Enum ( String ).
        ///<para>When the item is serialized out as xml, its value is "str".</para>
        ///</summary>
        [EnumString("str")]
        String,
        ///<summary>
        ///Value Type Enum ( Number ).
        ///<para>When the item is serialized out as xml, its value is "num".</para>
        ///</summary>
        [EnumString("num")]
        Number,
        ///<summary>
        ///Value Type Enum ( Color ).
        ///<para>When the item is serialized out as xml, its value is "clr".</para>
        ///</summary>
        [EnumString("clr")]
        Color,
    }

    /// <summary>
    /// Time List Animate Color Space
    /// </summary>
    public enum AnimateColorSpaceValues
    {
        ///<summary>
        ///Color Space Enum ( RGB ).
        ///<para>When the item is serialized out as xml, its value is "rgb".</para>
        ///</summary>
        [EnumString("rgb")]
        Rgb,
        ///<summary>
        ///Color Space Enum ( HSL ).
        ///<para>When the item is serialized out as xml, its value is "hsl".</para>
        ///</summary>
        [EnumString("hsl")]
        Hsl,
    }

    /// <summary>
    /// Time List Animate Color Direction
    /// </summary>
    public enum AnimateColorDirectionValues
    {
        ///<summary>
        ///Direction Enum ( Clockwise ).
        ///<para>When the item is serialized out as xml, its value is "cw".</para>
        ///</summary>
        [EnumString("cw")]
        Clockwise,
        ///<summary>
        ///Counter-Clockwise.
        ///<para>When the item is serialized out as xml, its value is "ccw".</para>
        ///</summary>
        [EnumString("ccw")]
        CounterClockwise,
    }

    /// <summary>
    /// Time List Animate Effect Transition
    /// </summary>
    public enum AnimateEffectTransitionValues
    {
        ///<summary>
        ///Transition Enum ( In ).
        ///<para>When the item is serialized out as xml, its value is "in".</para>
        ///</summary>
        [EnumString("in")]
        In,
        ///<summary>
        ///Transition Enum ( Out ).
        ///<para>When the item is serialized out as xml, its value is "out".</para>
        ///</summary>
        [EnumString("out")]
        Out,
        ///<summary>
        ///Transition Enum ( None ).
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
    }

    /// <summary>
    /// Time List Animate Motion Behavior Origin
    /// </summary>
    public enum AnimateMotionBehaviorOriginValues
    {
        ///<summary>
        ///Origin Enum ( Parent ).
        ///<para>When the item is serialized out as xml, its value is "parent".</para>
        ///</summary>
        [EnumString("parent")]
        Parent,
        ///<summary>
        ///Origin Enum ( Layout ).
        ///<para>When the item is serialized out as xml, its value is "layout".</para>
        ///</summary>
        [EnumString("layout")]
        Layout,
    }

    /// <summary>
    /// Time List Animate Motion Path Edit Mode
    /// </summary>
    public enum AnimateMotionPathEditModeValues
    {
        ///<summary>
        ///Path Edit Mode Enum ( Relative ).
        ///<para>When the item is serialized out as xml, its value is "relative".</para>
        ///</summary>
        [EnumString("relative")]
        Relative,
        ///<summary>
        ///Path Edit Mode Enum ( Fixed ).
        ///<para>When the item is serialized out as xml, its value is "fixed".</para>
        ///</summary>
        [EnumString("fixed")]
        Fixed,
    }

    /// <summary>
    /// Command Type
    /// </summary>
    public enum CommandValues
    {
        ///<summary>
        ///Command Type Enum ( Event ).
        ///<para>When the item is serialized out as xml, its value is "evt".</para>
        ///</summary>
        [EnumString("evt")]
        Event,
        ///<summary>
        ///Command Type Enum ( Call ).
        ///<para>When the item is serialized out as xml, its value is "call".</para>
        ///</summary>
        [EnumString("call")]
        Call,
        ///<summary>
        ///Command Type Enum ( Verb ).
        ///<para>When the item is serialized out as xml, its value is "verb".</para>
        ///</summary>
        [EnumString("verb")]
        Verb,
    }

    /// <summary>
    /// Paragraph Build Type
    /// </summary>
    public enum ParagraphBuildValues
    {
        ///<summary>
        ///All At Once.
        ///<para>When the item is serialized out as xml, its value is "allAtOnce".</para>
        ///</summary>
        [EnumString("allAtOnce")]
        AllAtOnce,
        ///<summary>
        ///Paragraph.
        ///<para>When the item is serialized out as xml, its value is "p".</para>
        ///</summary>
        [EnumString("p")]
        Paragraph,
        ///<summary>
        ///Custom.
        ///<para>When the item is serialized out as xml, its value is "cust".</para>
        ///</summary>
        [EnumString("cust")]
        Custom,
        ///<summary>
        ///Whole.
        ///<para>When the item is serialized out as xml, its value is "whole".</para>
        ///</summary>
        [EnumString("whole")]
        Whole,
    }

    /// <summary>
    /// Diagram Build Types
    /// </summary>
    public enum DiagramBuildValues
    {
        ///<summary>
        ///Diagram Build Type Enum ( Whole ).
        ///<para>When the item is serialized out as xml, its value is "whole".</para>
        ///</summary>
        [EnumString("whole")]
        Whole,
        ///<summary>
        ///Diagram Build Type Enum ( Depth By Node ).
        ///<para>When the item is serialized out as xml, its value is "depthByNode".</para>
        ///</summary>
        [EnumString("depthByNode")]
        DepthByNode,
        ///<summary>
        ///Diagram Build Type Enum ( Depth By Branch ).
        ///<para>When the item is serialized out as xml, its value is "depthByBranch".</para>
        ///</summary>
        [EnumString("depthByBranch")]
        DepthByBranch,
        ///<summary>
        ///Diagram Build Type Enum ( Breadth By Node ).
        ///<para>When the item is serialized out as xml, its value is "breadthByNode".</para>
        ///</summary>
        [EnumString("breadthByNode")]
        BreadthByNode,
        ///<summary>
        ///Diagram Build Type Enum ( Breadth By Level ).
        ///<para>When the item is serialized out as xml, its value is "breadthByLvl".</para>
        ///</summary>
        [EnumString("breadthByLvl")]
        BreadthByLevel,
        ///<summary>
        ///Diagram Build Type Enum ( Clockwise ).
        ///<para>When the item is serialized out as xml, its value is "cw".</para>
        ///</summary>
        [EnumString("cw")]
        Clockwise,
        ///<summary>
        ///Diagram Build Type Enum ( Clockwise-In ).
        ///<para>When the item is serialized out as xml, its value is "cwIn".</para>
        ///</summary>
        [EnumString("cwIn")]
        ClockwiseIn,
        ///<summary>
        ///Diagram Build Type Enum ( Clockwise-Out ).
        ///<para>When the item is serialized out as xml, its value is "cwOut".</para>
        ///</summary>
        [EnumString("cwOut")]
        ClockwiseOut,
        ///<summary>
        ///Diagram Build Type Enum ( Counter-Clockwise ).
        ///<para>When the item is serialized out as xml, its value is "ccw".</para>
        ///</summary>
        [EnumString("ccw")]
        CounterClockwise,
        ///<summary>
        ///Diagram Build Type Enum ( Counter-Clockwise-In ).
        ///<para>When the item is serialized out as xml, its value is "ccwIn".</para>
        ///</summary>
        [EnumString("ccwIn")]
        CounterClockwiseIn,
        ///<summary>
        ///Diagram Build Type Enum ( Counter-Clockwise-Out ).
        ///<para>When the item is serialized out as xml, its value is "ccwOut".</para>
        ///</summary>
        [EnumString("ccwOut")]
        CounterClockwiseOut,
        ///<summary>
        ///Diagram Build Type Enum ( In-By-Ring ).
        ///<para>When the item is serialized out as xml, its value is "inByRing".</para>
        ///</summary>
        [EnumString("inByRing")]
        InByRing,
        ///<summary>
        ///Diagram Build Type Enum ( Out-By-Ring ).
        ///<para>When the item is serialized out as xml, its value is "outByRing".</para>
        ///</summary>
        [EnumString("outByRing")]
        OutByRing,
        ///<summary>
        ///Diagram Build Type Enum ( Up ).
        ///<para>When the item is serialized out as xml, its value is "up".</para>
        ///</summary>
        [EnumString("up")]
        Up,
        ///<summary>
        ///Diagram Build Type Enum ( Down ).
        ///<para>When the item is serialized out as xml, its value is "down".</para>
        ///</summary>
        [EnumString("down")]
        Down,
        ///<summary>
        ///Diagram Build Type Enum ( All At Once ).
        ///<para>When the item is serialized out as xml, its value is "allAtOnce".</para>
        ///</summary>
        [EnumString("allAtOnce")]
        AllAtOnce,
        ///<summary>
        ///Diagram Build Type Enum ( Custom ).
        ///<para>When the item is serialized out as xml, its value is "cust".</para>
        ///</summary>
        [EnumString("cust")]
        Custom,
    }

    /// <summary>
    /// OLE Chart Build Type
    /// </summary>
    public enum OleChartBuildValues
    {
        ///<summary>
        ///Chart Build Type Enum ( All At Once ).
        ///<para>When the item is serialized out as xml, its value is "allAtOnce".</para>
        ///</summary>
        [EnumString("allAtOnce")]
        AllAtOnce,
        ///<summary>
        ///Chart Build Type Enum ( Series ).
        ///<para>When the item is serialized out as xml, its value is "series".</para>
        ///</summary>
        [EnumString("series")]
        Series,
        ///<summary>
        ///Chart Build Type Enum ( Category ).
        ///<para>When the item is serialized out as xml, its value is "category".</para>
        ///</summary>
        [EnumString("category")]
        Category,
        ///<summary>
        ///Chart Build Type Enum ( Series Element ).
        ///<para>When the item is serialized out as xml, its value is "seriesEl".</para>
        ///</summary>
        [EnumString("seriesEl")]
        SeriesElement,
        ///<summary>
        ///Chart Build Type Enum ( Category Element ).
        ///<para>When the item is serialized out as xml, its value is "categoryEl".</para>
        ///</summary>
        [EnumString("categoryEl")]
        CategoryElement,
    }

    /// <summary>
    /// Time Node Master Relation
    /// </summary>
    public enum TimeNodeMasterRelationValues
    {
        ///<summary>
        ///TimeNode Master Relation Enum ( Same Click ).
        ///<para>When the item is serialized out as xml, its value is "sameClick".</para>
        ///</summary>
        [EnumString("sameClick")]
        SameClick,
        ///<summary>
        ///TimeNode Master Relation Enum ( Next Click ).
        ///<para>When the item is serialized out as xml, its value is "nextClick".</para>
        ///</summary>
        [EnumString("nextClick")]
        NextClick,
    }

    /// <summary>
    /// Time Node Sync Type
    /// </summary>
    public enum TimeNodeSyncValues
    {
        ///<summary>
        ///none.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///TimeNode Sync Enum ( Can Slip ).
        ///<para>When the item is serialized out as xml, its value is "canSlip".</para>
        ///</summary>
        [EnumString("canSlip")]
        CanSlip,
        ///<summary>
        ///TimeNode Sync Enum ( Locked ).
        ///<para>When the item is serialized out as xml, its value is "locked".</para>
        ///</summary>
        [EnumString("locked")]
        Locked,
    }

    /// <summary>
    /// Direction
    /// </summary>
    public enum DirectionValues
    {
        ///<summary>
        ///Horizontal.
        ///<para>When the item is serialized out as xml, its value is "horz".</para>
        ///</summary>
        [EnumString("horz")]
        Horizontal,
        ///<summary>
        ///Vertical.
        ///<para>When the item is serialized out as xml, its value is "vert".</para>
        ///</summary>
        [EnumString("vert")]
        Vertical,
    }

    /// <summary>
    /// OLE Object to Follow Color Scheme
    /// </summary>
    public enum OleObjectFollowColorSchemeValues
    {
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Full.
        ///<para>When the item is serialized out as xml, its value is "full".</para>
        ///</summary>
        [EnumString("full")]
        Full,
        ///<summary>
        ///Text and Background.
        ///<para>When the item is serialized out as xml, its value is "textAndBackground".</para>
        ///</summary>
        [EnumString("textAndBackground")]
        TextAndBackground,
    }

    /// <summary>
    /// Photo Album Layout Definition
    /// </summary>
    public enum PhotoAlbumLayoutValues
    {
        ///<summary>
        ///Fit Photos to Slide.
        ///<para>When the item is serialized out as xml, its value is "fitToSlide".</para>
        ///</summary>
        [EnumString("fitToSlide")]
        FitToSlide,
        ///<summary>
        ///1 Photo per Slide.
        ///<para>When the item is serialized out as xml, its value is "1pic".</para>
        ///</summary>
        [EnumString("1pic")]
        OnePic,
        ///<summary>
        ///2 Photos per Slide.
        ///<para>When the item is serialized out as xml, its value is "2pic".</para>
        ///</summary>
        [EnumString("2pic")]
        TwoPic,
        ///<summary>
        ///4 Photos per Slide.
        ///<para>When the item is serialized out as xml, its value is "4pic".</para>
        ///</summary>
        [EnumString("4pic")]
        FourPic,
        ///<summary>
        ///1 Photo per Slide with Titles.
        ///<para>When the item is serialized out as xml, its value is "1picTitle".</para>
        ///</summary>
        [EnumString("1picTitle")]
        OnePicWithTitle,
        ///<summary>
        ///2 Photos per Slide with Titles.
        ///<para>When the item is serialized out as xml, its value is "2picTitle".</para>
        ///</summary>
        [EnumString("2picTitle")]
        TwoPicWithTitle,
        ///<summary>
        ///4 Photos per Slide with Titles.
        ///<para>When the item is serialized out as xml, its value is "4picTitle".</para>
        ///</summary>
        [EnumString("4picTitle")]
        FourPicWithTitle,
    }

    /// <summary>
    /// Photo Album Shape for Photo Mask
    /// </summary>
    public enum PhotoAlbumFrameShapeValues
    {
        ///<summary>
        ///Rectangle Photo Frame.
        ///<para>When the item is serialized out as xml, its value is "frameStyle1".</para>
        ///</summary>
        [EnumString("frameStyle1")]
        FrameStyle1,
        ///<summary>
        ///Rounded Rectangle Photo Frame.
        ///<para>When the item is serialized out as xml, its value is "frameStyle2".</para>
        ///</summary>
        [EnumString("frameStyle2")]
        FrameStyle2,
        ///<summary>
        ///Simple White Photo Frame.
        ///<para>When the item is serialized out as xml, its value is "frameStyle3".</para>
        ///</summary>
        [EnumString("frameStyle3")]
        FrameStyle3,
        ///<summary>
        ///Simple Black Photo Frame.
        ///<para>When the item is serialized out as xml, its value is "frameStyle4".</para>
        ///</summary>
        [EnumString("frameStyle4")]
        FrameStyle4,
        ///<summary>
        ///Compound Black Photo Frame.
        ///<para>When the item is serialized out as xml, its value is "frameStyle5".</para>
        ///</summary>
        [EnumString("frameStyle5")]
        FrameStyle5,
        ///<summary>
        ///Center Shadow Photo Frame.
        ///<para>When the item is serialized out as xml, its value is "frameStyle6".</para>
        ///</summary>
        [EnumString("frameStyle6")]
        FrameStyle6,
        ///<summary>
        ///Soft Edge Photo Frame.
        ///<para>When the item is serialized out as xml, its value is "frameStyle7".</para>
        ///</summary>
        [EnumString("frameStyle7")]
        FrameStyle7,
    }

    /// <summary>
    /// Slide Size Type
    /// </summary>
    public enum SlideSizeValues
    {
        ///<summary>
        ///Screen 4x3.
        ///<para>When the item is serialized out as xml, its value is "screen4x3".</para>
        ///</summary>
        [EnumString("screen4x3")]
        Screen4x3,
        ///<summary>
        ///Letter.
        ///<para>When the item is serialized out as xml, its value is "letter".</para>
        ///</summary>
        [EnumString("letter")]
        Letter,
        ///<summary>
        ///A4.
        ///<para>When the item is serialized out as xml, its value is "A4".</para>
        ///</summary>
        [EnumString("A4")]
        A4,
        ///<summary>
        ///35mm Film.
        ///<para>When the item is serialized out as xml, its value is "35mm".</para>
        ///</summary>
        [EnumString("35mm")]
        Film35mm,
        ///<summary>
        ///Overhead.
        ///<para>When the item is serialized out as xml, its value is "overhead".</para>
        ///</summary>
        [EnumString("overhead")]
        Overhead,
        ///<summary>
        ///Banner.
        ///<para>When the item is serialized out as xml, its value is "banner".</para>
        ///</summary>
        [EnumString("banner")]
        Banner,
        ///<summary>
        ///Custom.
        ///<para>When the item is serialized out as xml, its value is "custom".</para>
        ///</summary>
        [EnumString("custom")]
        Custom,
        ///<summary>
        ///Ledger.
        ///<para>When the item is serialized out as xml, its value is "ledger".</para>
        ///</summary>
        [EnumString("ledger")]
        Ledger,
        ///<summary>
        ///A3.
        ///<para>When the item is serialized out as xml, its value is "A3".</para>
        ///</summary>
        [EnumString("A3")]
        A3,
        ///<summary>
        ///B4ISO.
        ///<para>When the item is serialized out as xml, its value is "B4ISO".</para>
        ///</summary>
        [EnumString("B4ISO")]
        B4ISO,
        ///<summary>
        ///B5ISO.
        ///<para>When the item is serialized out as xml, its value is "B5ISO".</para>
        ///</summary>
        [EnumString("B5ISO")]
        B5ISO,
        ///<summary>
        ///B4JIS.
        ///<para>When the item is serialized out as xml, its value is "B4JIS".</para>
        ///</summary>
        [EnumString("B4JIS")]
        B4JIS,
        ///<summary>
        ///B5JIS.
        ///<para>When the item is serialized out as xml, its value is "B5JIS".</para>
        ///</summary>
        [EnumString("B5JIS")]
        B5JIS,
        ///<summary>
        ///Hagaki Card.
        ///<para>When the item is serialized out as xml, its value is "hagakiCard".</para>
        ///</summary>
        [EnumString("hagakiCard")]
        HagakiCard,
        ///<summary>
        ///Screen 16x9.
        ///<para>When the item is serialized out as xml, its value is "screen16x9".</para>
        ///</summary>
        [EnumString("screen16x9")]
        Screen16x9,
        ///<summary>
        ///Screen 16x10.
        ///<para>When the item is serialized out as xml, its value is "screen16x10".</para>
        ///</summary>
        [EnumString("screen16x10")]
        Screen16x10,
    }

    /// <summary>
    /// Cryptographic Provider Type
    /// </summary>
    public enum CryptProviderValues
    {
        ///<summary>
        ///RSA AES Encryption Scheme.
        ///<para>When the item is serialized out as xml, its value is "rsaAES".</para>
        ///</summary>
        [EnumString("rsaAES")]
        RsaAES,
        ///<summary>
        ///RSA Full Encryption Scheme.
        ///<para>When the item is serialized out as xml, its value is "rsaFull".</para>
        ///</summary>
        [EnumString("rsaFull")]
        RsaFull,
        ///<summary>
        ///Invalid Encryption Scheme.
        ///<para>When the item is serialized out as xml, its value is "invalid".</para>
        ///</summary>
        [EnumString("invalid")]
        Invalid,
    }

    /// <summary>
    /// Cryptographic Algorithm Classes
    /// </summary>
    public enum CryptAlgorithmClassValues
    {
        ///<summary>
        ///Hash Algorithm Class.
        ///<para>When the item is serialized out as xml, its value is "hash".</para>
        ///</summary>
        [EnumString("hash")]
        Hash,
        ///<summary>
        ///Invalid Algorithm Class.
        ///<para>When the item is serialized out as xml, its value is "invalid".</para>
        ///</summary>
        [EnumString("invalid")]
        Invalid,
    }

    /// <summary>
    /// Cryptographic Algorithm Type
    /// </summary>
    public enum CryptAlgorithmValues
    {
        ///<summary>
        ///Any Algorithm Type.
        ///<para>When the item is serialized out as xml, its value is "typeAny".</para>
        ///</summary>
        [EnumString("typeAny")]
        TypeAny,
        ///<summary>
        ///Invalid Algorithm Type.
        ///<para>When the item is serialized out as xml, its value is "invalid".</para>
        ///</summary>
        [EnumString("invalid")]
        Invalid,
    }

    /// <summary>
    /// Web browsers supported for HTML output
    /// </summary>
    public enum HtmlPublishWebBrowserSupportValues
    {
        ///<summary>
        ///Browser v4.
        ///<para>When the item is serialized out as xml, its value is "v4".</para>
        ///</summary>
        [EnumString("v4")]
        V4,
        ///<summary>
        ///Browser v3.
        ///<para>When the item is serialized out as xml, its value is "v3".</para>
        ///</summary>
        [EnumString("v3")]
        V3,
        ///<summary>
        ///Browser v3v4.
        ///<para>When the item is serialized out as xml, its value is "v3v4".</para>
        ///</summary>
        [EnumString("v3v4")]
        V3v4,
    }

    /// <summary>
    /// HTML Slide Navigation Control Colors
    /// </summary>
    public enum WebColorValues
    {
        ///<summary>
        ///Non-specific Colors.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Browser Colors.
        ///<para>When the item is serialized out as xml, its value is "browser".</para>
        ///</summary>
        [EnumString("browser")]
        Browser,
        ///<summary>
        ///Presentation Text Colors.
        ///<para>When the item is serialized out as xml, its value is "presentationText".</para>
        ///</summary>
        [EnumString("presentationText")]
        PresentationText,
        ///<summary>
        ///Presentation Accent Colors.
        ///<para>When the item is serialized out as xml, its value is "presentationAccent".</para>
        ///</summary>
        [EnumString("presentationAccent")]
        PresentationAccent,
        ///<summary>
        ///White Text on Black Colors.
        ///<para>When the item is serialized out as xml, its value is "whiteTextOnBlack".</para>
        ///</summary>
        [EnumString("whiteTextOnBlack")]
        WhiteTextOnBlack,
        ///<summary>
        ///Black Text on White Colors.
        ///<para>When the item is serialized out as xml, its value is "blackTextOnWhite".</para>
        ///</summary>
        [EnumString("blackTextOnWhite")]
        BlackTextOnWhite,
    }

    /// <summary>
    /// HTML/Web Screen Size Target
    /// </summary>
    public enum WebScreenSizeValues
    {
        ///<summary>
        ///HTML/Web Size Enumeration 544x376.
        ///<para>When the item is serialized out as xml, its value is "544x376".</para>
        ///</summary>
        [EnumString("544x376")]
        Sz544x376,
        ///<summary>
        ///HTML/Web Size Enumeration 640x480.
        ///<para>When the item is serialized out as xml, its value is "640x480".</para>
        ///</summary>
        [EnumString("640x480")]
        Sz640x480,
        ///<summary>
        ///HTML/Web Size Enumeration 720x515.
        ///<para>When the item is serialized out as xml, its value is "720x512".</para>
        ///</summary>
        [EnumString("720x512")]
        Sz720x512,
        ///<summary>
        ///HTML/Web Size Enumeration 800x600.
        ///<para>When the item is serialized out as xml, its value is "800x600".</para>
        ///</summary>
        [EnumString("800x600")]
        Sz800x600,
        ///<summary>
        ///HTML/Web Size Enumeration 1024x768.
        ///<para>When the item is serialized out as xml, its value is "1024x768".</para>
        ///</summary>
        [EnumString("1024x768")]
        Sz1024x768,
        ///<summary>
        ///HTML/Web Size Enumeration 1152x882.
        ///<para>When the item is serialized out as xml, its value is "1152x882".</para>
        ///</summary>
        [EnumString("1152x882")]
        Sz1152x882,
        ///<summary>
        ///HTML/Web Size Enumeration 1152x900.
        ///<para>When the item is serialized out as xml, its value is "1152x900".</para>
        ///</summary>
        [EnumString("1152x900")]
        Sz1152x900,
        ///<summary>
        ///HTML/Web Size Enumeration 1280x1024.
        ///<para>When the item is serialized out as xml, its value is "1280x1024".</para>
        ///</summary>
        [EnumString("1280x1024")]
        Sz1280x1024,
        ///<summary>
        ///HTML/Web Size Enumeration 1600x1200.
        ///<para>When the item is serialized out as xml, its value is "1600x1200".</para>
        ///</summary>
        [EnumString("1600x1200")]
        Sz1600x1200,
        ///<summary>
        ///HTML/Web Size Enumeration 1800x1400.
        ///<para>When the item is serialized out as xml, its value is "1800x1400".</para>
        ///</summary>
        [EnumString("1800x1400")]
        Sz1800x1400,
        ///<summary>
        ///HTML/Web Size Enumeration 1920x1200.
        ///<para>When the item is serialized out as xml, its value is "1920x1200".</para>
        ///</summary>
        [EnumString("1920x1200")]
        Sz1920x1200,
    }

    /// <summary>
    /// Default print output
    /// </summary>
    public enum PrintOutputValues
    {
        ///<summary>
        ///Slides.
        ///<para>When the item is serialized out as xml, its value is "slides".</para>
        ///</summary>
        [EnumString("slides")]
        Slides,
        ///<summary>
        ///1 Slide / Handout Page.
        ///<para>When the item is serialized out as xml, its value is "handouts1".</para>
        ///</summary>
        [EnumString("handouts1")]
        Handouts1,
        ///<summary>
        ///2 Slides / Handout Page.
        ///<para>When the item is serialized out as xml, its value is "handouts2".</para>
        ///</summary>
        [EnumString("handouts2")]
        Handouts2,
        ///<summary>
        ///3 Slides / Handout Page.
        ///<para>When the item is serialized out as xml, its value is "handouts3".</para>
        ///</summary>
        [EnumString("handouts3")]
        Handouts3,
        ///<summary>
        ///4 Slides / Handout Page.
        ///<para>When the item is serialized out as xml, its value is "handouts4".</para>
        ///</summary>
        [EnumString("handouts4")]
        Handouts4,
        ///<summary>
        ///6 Slides / Handout Page.
        ///<para>When the item is serialized out as xml, its value is "handouts6".</para>
        ///</summary>
        [EnumString("handouts6")]
        Handouts6,
        ///<summary>
        ///9 Slides / Handout Page.
        ///<para>When the item is serialized out as xml, its value is "handouts9".</para>
        ///</summary>
        [EnumString("handouts9")]
        Handouts9,
        ///<summary>
        ///Notes.
        ///<para>When the item is serialized out as xml, its value is "notes".</para>
        ///</summary>
        [EnumString("notes")]
        Notes,
        ///<summary>
        ///Outline.
        ///<para>When the item is serialized out as xml, its value is "outline".</para>
        ///</summary>
        [EnumString("outline")]
        Outline,
    }

    /// <summary>
    /// Print Color Mode
    /// </summary>
    public enum PrintColorModeValues
    {
        ///<summary>
        ///Black and White Mode.
        ///<para>When the item is serialized out as xml, its value is "bw".</para>
        ///</summary>
        [EnumString("bw")]
        BlackWhite,
        ///<summary>
        ///Grayscale Mode.
        ///<para>When the item is serialized out as xml, its value is "gray".</para>
        ///</summary>
        [EnumString("gray")]
        Gray,
        ///<summary>
        ///Color Mode.
        ///<para>When the item is serialized out as xml, its value is "clr".</para>
        ///</summary>
        [EnumString("clr")]
        Color,
    }

    /// <summary>
    /// Placeholder IDs
    /// </summary>
    public enum PlaceholderValues
    {
        ///<summary>
        ///Title.
        ///<para>When the item is serialized out as xml, its value is "title".</para>
        ///</summary>
        [EnumString("title")]
        Title,
        ///<summary>
        ///Body.
        ///<para>When the item is serialized out as xml, its value is "body".</para>
        ///</summary>
        [EnumString("body")]
        Body,
        ///<summary>
        ///Centered Title.
        ///<para>When the item is serialized out as xml, its value is "ctrTitle".</para>
        ///</summary>
        [EnumString("ctrTitle")]
        CenteredTitle,
        ///<summary>
        ///Subtitle.
        ///<para>When the item is serialized out as xml, its value is "subTitle".</para>
        ///</summary>
        [EnumString("subTitle")]
        SubTitle,
        ///<summary>
        ///Date and Time.
        ///<para>When the item is serialized out as xml, its value is "dt".</para>
        ///</summary>
        [EnumString("dt")]
        DateAndTime,
        ///<summary>
        ///Slide Number.
        ///<para>When the item is serialized out as xml, its value is "sldNum".</para>
        ///</summary>
        [EnumString("sldNum")]
        SlideNumber,
        ///<summary>
        ///Footer.
        ///<para>When the item is serialized out as xml, its value is "ftr".</para>
        ///</summary>
        [EnumString("ftr")]
        Footer,
        ///<summary>
        ///Header.
        ///<para>When the item is serialized out as xml, its value is "hdr".</para>
        ///</summary>
        [EnumString("hdr")]
        Header,
        ///<summary>
        ///Object.
        ///<para>When the item is serialized out as xml, its value is "obj".</para>
        ///</summary>
        [EnumString("obj")]
        Object,
        ///<summary>
        ///Chart.
        ///<para>When the item is serialized out as xml, its value is "chart".</para>
        ///</summary>
        [EnumString("chart")]
        Chart,
        ///<summary>
        ///Table.
        ///<para>When the item is serialized out as xml, its value is "tbl".</para>
        ///</summary>
        [EnumString("tbl")]
        Table,
        ///<summary>
        ///Clip Art.
        ///<para>When the item is serialized out as xml, its value is "clipArt".</para>
        ///</summary>
        [EnumString("clipArt")]
        ClipArt,
        ///<summary>
        ///Diagram.
        ///<para>When the item is serialized out as xml, its value is "dgm".</para>
        ///</summary>
        [EnumString("dgm")]
        Diagram,
        ///<summary>
        ///Media.
        ///<para>When the item is serialized out as xml, its value is "media".</para>
        ///</summary>
        [EnumString("media")]
        Media,
        ///<summary>
        ///Slide Image.
        ///<para>When the item is serialized out as xml, its value is "sldImg".</para>
        ///</summary>
        [EnumString("sldImg")]
        SlideImage,
        ///<summary>
        ///Picture.
        ///<para>When the item is serialized out as xml, its value is "pic".</para>
        ///</summary>
        [EnumString("pic")]
        Picture,
    }

    /// <summary>
    /// Placeholder Size
    /// </summary>
    public enum PlaceholderSizeValues
    {
        ///<summary>
        ///Full.
        ///<para>When the item is serialized out as xml, its value is "full".</para>
        ///</summary>
        [EnumString("full")]
        Full,
        ///<summary>
        ///Half.
        ///<para>When the item is serialized out as xml, its value is "half".</para>
        ///</summary>
        [EnumString("half")]
        Half,
        ///<summary>
        ///Quarter.
        ///<para>When the item is serialized out as xml, its value is "quarter".</para>
        ///</summary>
        [EnumString("quarter")]
        Quarter,
    }

    /// <summary>
    /// Slide Layout Type
    /// </summary>
    public enum SlideLayoutValues
    {
        ///<summary>
        ///Slide Layout Type Enumeration ( Title ).
        ///<para>When the item is serialized out as xml, its value is "title".</para>
        ///</summary>
        [EnumString("title")]
        Title,
        ///<summary>
        ///Slide Layout Type Enumeration ( Text ).
        ///<para>When the item is serialized out as xml, its value is "tx".</para>
        ///</summary>
        [EnumString("tx")]
        Text,
        ///<summary>
        ///Slide Layout Type Enumeration ( Two Column Text ).
        ///<para>When the item is serialized out as xml, its value is "twoColTx".</para>
        ///</summary>
        [EnumString("twoColTx")]
        TwoColumnText,
        ///<summary>
        ///Slide Layout Type Enumeration ( Table ).
        ///<para>When the item is serialized out as xml, its value is "tbl".</para>
        ///</summary>
        [EnumString("tbl")]
        Table,
        ///<summary>
        ///Slide Layout Type Enumeration ( Text and Chart ).
        ///<para>When the item is serialized out as xml, its value is "txAndChart".</para>
        ///</summary>
        [EnumString("txAndChart")]
        TextAndChart,
        ///<summary>
        ///Slide Layout Type Enumeration ( Chart and Text ).
        ///<para>When the item is serialized out as xml, its value is "chartAndTx".</para>
        ///</summary>
        [EnumString("chartAndTx")]
        ChartAndText,
        ///<summary>
        ///Slide Layout Type Enumeration ( Diagram ).
        ///<para>When the item is serialized out as xml, its value is "dgm".</para>
        ///</summary>
        [EnumString("dgm")]
        Diagram,
        ///<summary>
        ///Chart.
        ///<para>When the item is serialized out as xml, its value is "chart".</para>
        ///</summary>
        [EnumString("chart")]
        Chart,
        ///<summary>
        ///Text and Clip Art.
        ///<para>When the item is serialized out as xml, its value is "txAndClipArt".</para>
        ///</summary>
        [EnumString("txAndClipArt")]
        TextAndClipArt,
        ///<summary>
        ///Clip Art and Text.
        ///<para>When the item is serialized out as xml, its value is "clipArtAndTx".</para>
        ///</summary>
        [EnumString("clipArtAndTx")]
        ClipArtAndText,
        ///<summary>
        ///Slide Layout Type Enumeration ( Title Only ).
        ///<para>When the item is serialized out as xml, its value is "titleOnly".</para>
        ///</summary>
        [EnumString("titleOnly")]
        TitleOnly,
        ///<summary>
        ///Slide Layout Type Enumeration ( Blank ).
        ///<para>When the item is serialized out as xml, its value is "blank".</para>
        ///</summary>
        [EnumString("blank")]
        Blank,
        ///<summary>
        ///Slide Layout Type Enumeration ( Text and Object ).
        ///<para>When the item is serialized out as xml, its value is "txAndObj".</para>
        ///</summary>
        [EnumString("txAndObj")]
        TextAndObject,
        ///<summary>
        ///Slide Layout Type Enumeration ( Object and Text ).
        ///<para>When the item is serialized out as xml, its value is "objAndTx".</para>
        ///</summary>
        [EnumString("objAndTx")]
        ObjectAndText,
        ///<summary>
        ///Object.
        ///<para>When the item is serialized out as xml, its value is "objOnly".</para>
        ///</summary>
        [EnumString("objOnly")]
        ObjectOnly,
        ///<summary>
        ///Title and Object.
        ///<para>When the item is serialized out as xml, its value is "obj".</para>
        ///</summary>
        [EnumString("obj")]
        Object,
        ///<summary>
        ///Slide Layout Type Enumeration ( Text and Media ).
        ///<para>When the item is serialized out as xml, its value is "txAndMedia".</para>
        ///</summary>
        [EnumString("txAndMedia")]
        TextAndMedia,
        ///<summary>
        ///Slide Layout Type Enumeration ( Media and Text ).
        ///<para>When the item is serialized out as xml, its value is "mediaAndTx".</para>
        ///</summary>
        [EnumString("mediaAndTx")]
        MidiaAndText,
        ///<summary>
        ///Slide Layout Type Enumeration ( Object over Text).
        ///<para>When the item is serialized out as xml, its value is "objOverTx".</para>
        ///</summary>
        [EnumString("objOverTx")]
        ObjectOverText,
        ///<summary>
        ///Slide Layout Type Enumeration ( Text over Object).
        ///<para>When the item is serialized out as xml, its value is "txOverObj".</para>
        ///</summary>
        [EnumString("txOverObj")]
        TextOverObject,
        ///<summary>
        ///Text and Two Objects.
        ///<para>When the item is serialized out as xml, its value is "txAndTwoObj".</para>
        ///</summary>
        [EnumString("txAndTwoObj")]
        TextAndTwoObjects,
        ///<summary>
        ///Two Objects and Text.
        ///<para>When the item is serialized out as xml, its value is "twoObjAndTx".</para>
        ///</summary>
        [EnumString("twoObjAndTx")]
        TwoObjectsAndText,
        ///<summary>
        ///Two Objects over Text.
        ///<para>When the item is serialized out as xml, its value is "twoObjOverTx".</para>
        ///</summary>
        [EnumString("twoObjOverTx")]
        TwoObjectsOverText,
        ///<summary>
        ///Four Objects.
        ///<para>When the item is serialized out as xml, its value is "fourObj".</para>
        ///</summary>
        [EnumString("fourObj")]
        FourObjects,
        ///<summary>
        ///Vertical Text.
        ///<para>When the item is serialized out as xml, its value is "vertTx".</para>
        ///</summary>
        [EnumString("vertTx")]
        VerticalText,
        ///<summary>
        ///Clip Art and Vertical Text.
        ///<para>When the item is serialized out as xml, its value is "clipArtAndVertTx".</para>
        ///</summary>
        [EnumString("clipArtAndVertTx")]
        ClipArtAndVerticalText,
        ///<summary>
        ///Vertical Title and Text.
        ///<para>When the item is serialized out as xml, its value is "vertTitleAndTx".</para>
        ///</summary>
        [EnumString("vertTitleAndTx")]
        VerticalTitleAndText,
        ///<summary>
        ///Vertical Title and Text Over Chart.
        ///<para>When the item is serialized out as xml, its value is "vertTitleAndTxOverChart".</para>
        ///</summary>
        [EnumString("vertTitleAndTxOverChart")]
        VerticalTitleAndTextOverChart,
        ///<summary>
        ///Two Objects.
        ///<para>When the item is serialized out as xml, its value is "twoObj".</para>
        ///</summary>
        [EnumString("twoObj")]
        TwoObjects,
        ///<summary>
        ///Object and Two Object.
        ///<para>When the item is serialized out as xml, its value is "objAndTwoObj".</para>
        ///</summary>
        [EnumString("objAndTwoObj")]
        ObjectAndTwoObjects,
        ///<summary>
        ///Two Objects and Object.
        ///<para>When the item is serialized out as xml, its value is "twoObjAndObj".</para>
        ///</summary>
        [EnumString("twoObjAndObj")]
        TwoObjectsAndObject,
        ///<summary>
        ///Slide Layout Type Enumeration ( Custom ).
        ///<para>When the item is serialized out as xml, its value is "cust".</para>
        ///</summary>
        [EnumString("cust")]
        Custom,
        ///<summary>
        ///Section Header.
        ///<para>When the item is serialized out as xml, its value is "secHead".</para>
        ///</summary>
        [EnumString("secHead")]
        SectionHeader,
        ///<summary>
        ///Two Text and Two Objects.
        ///<para>When the item is serialized out as xml, its value is "twoTxTwoObj".</para>
        ///</summary>
        [EnumString("twoTxTwoObj")]
        TwoTextAndTwoObjects,
        ///<summary>
        ///Title, Object, and Caption.
        ///<para>When the item is serialized out as xml, its value is "objTx".</para>
        ///</summary>
        [EnumString("objTx")]
        ObjectText,
        ///<summary>
        ///Picture and Caption.
        ///<para>When the item is serialized out as xml, its value is "picTx".</para>
        ///</summary>
        [EnumString("picTx")]
        PictureText,
    }

    /// <summary>
    /// Splitter Bar State
    /// </summary>
    public enum SplitterBarStateValues
    {
        ///<summary>
        ///Min.
        ///<para>When the item is serialized out as xml, its value is "minimized".</para>
        ///</summary>
        [EnumString("minimized")]
        Minimized,
        ///<summary>
        ///Restored.
        ///<para>When the item is serialized out as xml, its value is "restored".</para>
        ///</summary>
        [EnumString("restored")]
        Restored,
        ///<summary>
        ///Max.
        ///<para>When the item is serialized out as xml, its value is "maximized".</para>
        ///</summary>
        [EnumString("maximized")]
        Maximized,
    }

    /// <summary>
    /// List of View Types
    /// </summary>
    public enum ViewValues
    {
        ///<summary>
        ///Normal Slide View.
        ///<para>When the item is serialized out as xml, its value is "sldView".</para>
        ///</summary>
        [EnumString("sldView")]
        SlideView,
        ///<summary>
        ///Slide Master View.
        ///<para>When the item is serialized out as xml, its value is "sldMasterView".</para>
        ///</summary>
        [EnumString("sldMasterView")]
        SlideMasterView,
        ///<summary>
        ///Notes View.
        ///<para>When the item is serialized out as xml, its value is "notesView".</para>
        ///</summary>
        [EnumString("notesView")]
        NotesView,
        ///<summary>
        ///Handout View.
        ///<para>When the item is serialized out as xml, its value is "handoutView".</para>
        ///</summary>
        [EnumString("handoutView")]
        HandoutView,
        ///<summary>
        ///Notes Master View.
        ///<para>When the item is serialized out as xml, its value is "notesMasterView".</para>
        ///</summary>
        [EnumString("notesMasterView")]
        NotesMasterView,
        ///<summary>
        ///Outline View.
        ///<para>When the item is serialized out as xml, its value is "outlineView".</para>
        ///</summary>
        [EnumString("outlineView")]
        OutlineView,
        ///<summary>
        ///Slide Sorter View.
        ///<para>When the item is serialized out as xml, its value is "sldSorterView".</para>
        ///</summary>
        [EnumString("sldSorterView")]
        SlideSorterView,
        ///<summary>
        ///Slide Thumbnail View.
        ///<para>When the item is serialized out as xml, its value is "sldThumbnailView".</para>
        ///</summary>
        [EnumString("sldThumbnailView")]
        SlideThumbnailView,
    }

    /// <summary>
    /// Trigger Event
    /// </summary>
    public enum TriggerEventValues
    {
        ///<summary>
        ///none.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Trigger Event Enum ( On Begin ).
        ///<para>When the item is serialized out as xml, its value is "onBegin".</para>
        ///</summary>
        [EnumString("onBegin")]
        OnBegin,
        ///<summary>
        ///Trigger Event Enum ( On End ).
        ///<para>When the item is serialized out as xml, its value is "onEnd".</para>
        ///</summary>
        [EnumString("onEnd")]
        OnEnd,
        ///<summary>
        ///Trigger Event Enum ( Begin ).
        ///<para>When the item is serialized out as xml, its value is "begin".</para>
        ///</summary>
        [EnumString("begin")]
        Begin,
        ///<summary>
        ///Trigger Event Enum ( End ).
        ///<para>When the item is serialized out as xml, its value is "end".</para>
        ///</summary>
        [EnumString("end")]
        End,
        ///<summary>
        ///Trigger Event Enum ( On Click ).
        ///<para>When the item is serialized out as xml, its value is "onClick".</para>
        ///</summary>
        [EnumString("onClick")]
        OnClick,
        ///<summary>
        ///Trigger Event Enum ( On Double Click ).
        ///<para>When the item is serialized out as xml, its value is "onDblClick".</para>
        ///</summary>
        [EnumString("onDblClick")]
        OnDoubleClick,
        ///<summary>
        ///Trigger Event Enum ( On Mouse Over ).
        ///<para>When the item is serialized out as xml, its value is "onMouseOver".</para>
        ///</summary>
        [EnumString("onMouseOver")]
        OnMouseOver,
        ///<summary>
        ///Trigger Event Enum ( On Mouse Out ).
        ///<para>When the item is serialized out as xml, its value is "onMouseOut".</para>
        ///</summary>
        [EnumString("onMouseOut")]
        OnMouseOut,
        ///<summary>
        ///Trigger Event Enum ( On Next ).
        ///<para>When the item is serialized out as xml, its value is "onNext".</para>
        ///</summary>
        [EnumString("onNext")]
        OnNext,
        ///<summary>
        ///Trigger Event Enum ( On Previous ).
        ///<para>When the item is serialized out as xml, its value is "onPrev".</para>
        ///</summary>
        [EnumString("onPrev")]
        OnPrevious,
        ///<summary>
        ///Trigger Event Enum ( On Stop Audio ).
        ///<para>When the item is serialized out as xml, its value is "onStopAudio".</para>
        ///</summary>
        [EnumString("onStopAudio")]
        OnStopAudio,
        ///<summary>
        ///onMediaBookmark.
        ///<para>When the item is serialized out as xml, its value is "onMediaBookmark".</para>
        ///</summary>
        [EnumString("onMediaBookmark")]
        OnMediaBookmark,
    }

    /// <summary>
    /// Defines the ConformanceClassValues enumeration.
    /// </summary>
    public enum ConformanceClassValues
    {
        ///<summary>
        ///strict.
        ///<para>When the item is serialized out as xml, its value is "strict".</para>
        ///</summary>
        [EnumString("strict")]
        Strict,
        ///<summary>
        ///transitional.
        ///<para>When the item is serialized out as xml, its value is "transitional".</para>
        ///</summary>
        [EnumString("transitional")]
        Transitional,
    }
}