﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2016.Presentation.Command
{
    /// <summary>
    /// <para>Defines the CommentAuthorMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:cmAuthorMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:cmAuthorMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CommentAuthorMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentAuthorMonikerList class.
        /// </summary>
        public CommentAuthorMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthorMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentAuthorMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthorMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentAuthorMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentAuthorMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentAuthorMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:cmAuthorMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentAuthorMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:cmMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:cmMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CommentMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentMonikerList class.
        /// </summary>
        public CommentMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:cmMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the StringTagMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:tagMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:tagMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StringTagMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StringTagMonikerList class.
        /// </summary>
        public StringTagMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringTagMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringTagMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringTagMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringTagMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringTagMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StringTagMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:tagMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringTagMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomShowMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:custShowMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:custShowMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CustomShowMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomShowMonikerList class.
        /// </summary>
        public CustomShowMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomShowMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomShowMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomShowMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomShowMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomShowMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomShowMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:custShowMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomShowMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the DocumentMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:docMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:docMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DocumentMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DocumentMonikerList class.
        /// </summary>
        public DocumentMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DocumentMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:docMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the SectionMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:sectionMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:sectionMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SectionMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SectionMonikerList class.
        /// </summary>
        public SectionMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SectionMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SectionMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SectionMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:sectionMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideBaseMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:sldBaseMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:sldBaseMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SlideBaseMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideBaseMonikerList class.
        /// </summary>
        public SlideBaseMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideBaseMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideBaseMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideBaseMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideBaseMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideBaseMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideBaseMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:sldBaseMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideBaseMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideLayoutMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:sldLayoutMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:sldLayoutMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SlideLayoutMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideLayoutMonikerList class.
        /// </summary>
        public SlideLayoutMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideLayoutMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideLayoutMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideLayoutMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideLayoutMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:sldLayoutMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideLayoutMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the MainMasterMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:sldMasterMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:sldMasterMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MainMasterMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MainMasterMonikerList class.
        /// </summary>
        public MainMasterMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MainMasterMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MainMasterMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MainMasterMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MainMasterMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MainMasterMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MainMasterMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:sldMasterMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MainMasterMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:sldMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:sldMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SlideMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlideMonikerList class.
        /// </summary>
        public SlideMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:sldMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the SlidePosMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:sldPosMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:sldPosMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SlidePosMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlidePosMonikerList class.
        /// </summary>
        public SlidePosMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlidePosMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlidePosMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlidePosMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlidePosMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlidePosMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlidePosMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:sldPosMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlidePosMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the NotesMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:notesMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:notesMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NotesMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NotesMonikerList class.
        /// </summary>
        public NotesMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:notesMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the NotesTextMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:notesTxtMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:notesTxtMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NotesTextMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NotesTextMonikerList class.
        /// </summary>
        public NotesTextMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesTextMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesTextMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesTextMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesTextMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesTextMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesTextMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:notesTxtMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesTextMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the NotesMasterMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:notesMasterMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:notesMasterMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NotesMasterMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NotesMasterMonikerList class.
        /// </summary>
        public NotesMasterMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMasterMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesMasterMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesMasterMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesMasterMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:notesMasterMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesMasterMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the HandoutMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:handoutMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:handoutMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HandoutMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HandoutMonikerList class.
        /// </summary>
        public HandoutMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HandoutMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HandoutMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HandoutMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HandoutMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:handoutMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HandoutMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the AnimEffectMkLstAnimationEffectMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:animEffectMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:animEffectMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AnimEffectMkLstAnimationEffectMonikerList : OpenXmlAnimationEffectMonikerListElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimEffectMkLstAnimationEffectMonikerList class.
        /// </summary>
        public AnimEffectMkLstAnimationEffectMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimEffectMkLstAnimationEffectMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimEffectMkLstAnimationEffectMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimEffectMkLstAnimationEffectMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimEffectMkLstAnimationEffectMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimEffectMkLstAnimationEffectMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AnimEffectMkLstAnimationEffectMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:animEffectMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimEffectMkLstAnimationEffectMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the AnimEffectParentMkLstAnimationEffectMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:animEffectParentMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:animEffectParentMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AnimEffectParentMkLstAnimationEffectMonikerList : OpenXmlAnimationEffectMonikerListElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimEffectParentMkLstAnimationEffectMonikerList class.
        /// </summary>
        public AnimEffectParentMkLstAnimationEffectMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimEffectParentMkLstAnimationEffectMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimEffectParentMkLstAnimationEffectMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimEffectParentMkLstAnimationEffectMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimEffectParentMkLstAnimationEffectMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimEffectParentMkLstAnimationEffectMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AnimEffectParentMkLstAnimationEffectMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:animEffectParentMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimEffectParentMkLstAnimationEffectMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlAnimationEffectMonikerListElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlAnimationEffectMonikerListElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlAnimationEffectMonikerListElement class.
        /// </summary>
        protected OpenXmlAnimationEffectMonikerListElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlAnimationEffectMonikerListElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlAnimationEffectMonikerListElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlAnimationEffectMonikerListElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlAnimationEffectMonikerListElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlAnimationEffectMonikerListElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OpenXmlAnimationEffectMonikerListElement(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
        }
    }

    /// <summary>
    /// <para>Defines the OsfTaskPaneAppMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:tkAppMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:tkAppMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class OsfTaskPaneAppMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OsfTaskPaneAppMonikerList class.
        /// </summary>
        public OsfTaskPaneAppMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OsfTaskPaneAppMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OsfTaskPaneAppMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OsfTaskPaneAppMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OsfTaskPaneAppMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OsfTaskPaneAppMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OsfTaskPaneAppMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:tkAppMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OsfTaskPaneAppMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the SummaryZoomMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:tocMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:tocMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SummaryZoomMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SummaryZoomMonikerList class.
        /// </summary>
        public SummaryZoomMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SummaryZoomMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SummaryZoomMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SummaryZoomMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SummaryZoomMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SummaryZoomMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SummaryZoomMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:tocMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SummaryZoomMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the SectionLinkObjMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:sectionLnkObjMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:sectionLnkObjMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SectionLinkObjMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SectionLinkObjMonikerList class.
        /// </summary>
        public SectionLinkObjMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionLinkObjMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SectionLinkObjMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionLinkObjMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SectionLinkObjMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionLinkObjMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SectionLinkObjMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:sectionLnkObjMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionLinkObjMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the DesignerTagMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:designTagMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:designTagMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DesignerTagMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DesignerTagMonikerList class.
        /// </summary>
        public DesignerTagMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DesignerTagMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DesignerTagMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DesignerTagMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DesignerTagMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DesignerTagMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DesignerTagMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:designTagMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DesignerTagMonikerList>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomXmlPartMonikerList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pc:cXmlMkLst.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("pc:cXmlMkLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CustomXmlPartMonikerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomXmlPartMonikerList class.
        /// </summary>
        public CustomXmlPartMonikerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXmlPartMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomXmlPartMonikerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXmlPartMonikerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomXmlPartMonikerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomXmlPartMonikerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomXmlPartMonikerList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pc:cXmlMkLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomXmlPartMonikerList>(deep);
    }
}