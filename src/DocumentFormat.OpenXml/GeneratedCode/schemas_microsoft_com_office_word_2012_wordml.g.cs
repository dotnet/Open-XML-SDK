﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.Word
{
    /// <summary>
    /// <para>Defines the Color Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:color.</para>
    /// </summary>
    [SchemaAttr(69, "color")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class Color : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Color class.
        /// </summary>
        public Color() : base()
        {
        }

        /// <summary>
        /// <para>Run Content Color</para>
        /// <para>Represents the following attribute in the schema: w:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        [RequiredValidator()]
        [EnumValidator(SimpleType = typeof(EnumValue<DocumentFormat.OpenXml.Wordprocessing.AutomaticColorValues>), UnionId = 0)]
        [StringValidator(SimpleType = typeof(HexBinaryValue), Length = 3L, UnionId = 0)]
        [SchemaAttr(23, "val")]
        [Index(0)]
        public StringValue Val { get; set; }

        /// <summary>
        /// <para>Run Content Theme Color</para>
        /// <para>Represents the following attribute in the schema: w:themeColor</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        [SchemaAttr(23, "themeColor")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues> ThemeColor { get; set; }

        /// <summary>
        /// <para>Run Content Theme Color Tint</para>
        /// <para>Represents the following attribute in the schema: w:themeTint</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        [StringValidator(Pattern = "[0-9a-fA-F]*", MinLength = 1L, MaxLength = 2L)]
        [SchemaAttr(23, "themeTint")]
        [Index(2)]
        public StringValue ThemeTint { get; set; }

        /// <summary>
        /// <para>Run Content Theme Color Shade</para>
        /// <para>Represents the following attribute in the schema: w:themeShade</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        [StringValidator(Pattern = "[0-9a-fA-F]*", MinLength = 1L, MaxLength = 2L)]
        [SchemaAttr(23, "themeShade")]
        [Index(3)]
        public StringValue ThemeShade { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Color>(deep);
    }

    /// <summary>
    /// <para>Defines the DataBinding Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:dataBinding.</para>
    /// </summary>
    [SchemaAttr(69, "dataBinding")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataBinding : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataBinding class.
        /// </summary>
        public DataBinding() : base()
        {
        }

        /// <summary>
        /// <para>XML Namespace Prefix Mappings</para>
        /// <para>Represents the following attribute in the schema: w:prefixMappings</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        [SchemaAttr(23, "prefixMappings")]
        [Index(0)]
        public StringValue PrefixMappings { get; set; }

        /// <summary>
        /// <para>XPath</para>
        /// <para>Represents the following attribute in the schema: w:xpath</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(23, "xpath")]
        [Index(1)]
        public StringValue XPath { get; set; }

        /// <summary>
        /// <para>Custom XML Data Storage ID</para>
        /// <para>Represents the following attribute in the schema: w:storeItemID</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(23, "storeItemID")]
        [Index(2)]
        public StringValue StoreItemId { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataBinding>(deep);
    }

    /// <summary>
    /// <para>Defines the Appearance Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:appearance.</para>
    /// </summary>
    [SchemaAttr(69, "appearance")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class Appearance : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Appearance class.
        /// </summary>
        public Appearance() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        [OfficeAvailability(FileFormatVersions.Office2013)]
        [SchemaAttr(69, "val")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance> Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Appearance>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentsEx Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:commentsEx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CommentEx &lt;w15:commentEx></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CommentEx), FileFormatVersions.Office2013)]
    [SchemaAttr(69, "commentsEx")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class CommentsEx : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentsEx class.
        /// </summary>
        public CommentsEx() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentsEx class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentsEx(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentsEx class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentsEx(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentsEx class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentsEx(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Word.CommentEx), 0, 0, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentsEx>(deep);

        internal CommentsEx(WordprocessingCommentsExPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the WordprocessingCommentsExPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(WordprocessingCommentsExPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the WordprocessingCommentsExPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(WordprocessingCommentsExPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the WordprocessingCommentsExPart associated with this element.
        /// </summary>
        public WordprocessingCommentsExPart WordprocessingCommentsExPart
        {
            get => OpenXmlPart as WordprocessingCommentsExPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the People Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:people.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Person &lt;w15:person></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Person), FileFormatVersions.Office2013)]
    [SchemaAttr(69, "people")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class People : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the People class.
        /// </summary>
        public People() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the People class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public People(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the People class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public People(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the People class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public People(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Word.Person), 0, 0, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<People>(deep);

        internal People(WordprocessingPeoplePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the WordprocessingPeoplePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(WordprocessingPeoplePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the WordprocessingPeoplePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(WordprocessingPeoplePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the WordprocessingPeoplePart associated with this element.
        /// </summary>
        public WordprocessingPeoplePart WordprocessingPeoplePart
        {
            get => OpenXmlPart as WordprocessingPeoplePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the SdtRepeatedSection Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:repeatingSection.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SectionTitle &lt;w15:sectionTitle></description></item>
    ///   <item><description>DoNotAllowInsertDeleteSection &lt;w15:doNotAllowInsertDeleteSection></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SectionTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DoNotAllowInsertDeleteSection), FileFormatVersions.Office2013)]
    [SchemaAttr(69, "repeatingSection")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class SdtRepeatedSection : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SdtRepeatedSection class.
        /// </summary>
        public SdtRepeatedSection() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SdtRepeatedSection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SdtRepeatedSection(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SdtRepeatedSection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SdtRepeatedSection(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SdtRepeatedSection class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SdtRepeatedSection(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>SectionTitle.</para>
        /// <para>Represents the following element tag in the schema: w15:sectionTitle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15 = http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        public SectionTitle SectionTitle
        {
            get => GetElement<SectionTitle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DoNotAllowInsertDeleteSection.</para>
        /// <para>Represents the following element tag in the schema: w15:doNotAllowInsertDeleteSection.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15 = http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        public DoNotAllowInsertDeleteSection DoNotAllowInsertDeleteSection
        {
            get => GetElement<DoNotAllowInsertDeleteSection>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Word.SectionTitle), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Word.DoNotAllowInsertDeleteSection), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SdtRepeatedSection>(deep);
    }

    /// <summary>
    /// <para>Defines the SdtRepeatedSectionItem Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:repeatingSectionItem.</para>
    /// </summary>
    [SchemaAttr(69, "repeatingSectionItem")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class SdtRepeatedSectionItem : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SdtRepeatedSectionItem class.
        /// </summary>
        public SdtRepeatedSectionItem() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SdtRepeatedSectionItem>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartTrackingRefBased Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:chartTrackingRefBased.</para>
    /// </summary>
    [SchemaAttr(69, "chartTrackingRefBased")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ChartTrackingRefBased : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ChartTrackingRefBased class.
        /// </summary>
        public ChartTrackingRefBased() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartTrackingRefBased>(deep);
    }

    /// <summary>
    /// <para>Defines the DefaultCollapsed Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:collapsed.</para>
    /// </summary>
    [SchemaAttr(69, "collapsed")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DefaultCollapsed : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the DefaultCollapsed class.
        /// </summary>
        public DefaultCollapsed() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultCollapsed>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtensionLinked Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:webExtensionLinked.</para>
    /// </summary>
    [SchemaAttr(69, "webExtensionLinked")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class WebExtensionLinked : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionLinked class.
        /// </summary>
        public WebExtensionLinked() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionLinked>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtensionCreated Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:webExtensionCreated.</para>
    /// </summary>
    [SchemaAttr(69, "webExtensionCreated")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class WebExtensionCreated : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionCreated class.
        /// </summary>
        public WebExtensionCreated() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionCreated>(deep);
    }

    /// <summary>
    /// <para>Defines the DoNotAllowInsertDeleteSection Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:doNotAllowInsertDeleteSection.</para>
    /// </summary>
    [SchemaAttr(69, "doNotAllowInsertDeleteSection")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DoNotAllowInsertDeleteSection : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the DoNotAllowInsertDeleteSection class.
        /// </summary>
        public DoNotAllowInsertDeleteSection() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DoNotAllowInsertDeleteSection>(deep);
    }

    /// <summary>
    /// <para>Defines the OnOffType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OnOffType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OnOffType class.
        /// </summary>
        protected OnOffType() : base()
        {
        }

        /// <summary>
        /// <para>On/Off Value</para>
        /// <para>Represents the following attribute in the schema: w:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        [SchemaAttr(23, "val")]
        [Index(0)]
        public OnOffValue Val { get; set; }
    }

    /// <summary>
    /// <para>Defines the PersistentDocumentId Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:docId.</para>
    /// </summary>
    [SchemaAttr(69, "docId")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class PersistentDocumentId : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PersistentDocumentId class.
        /// </summary>
        public PersistentDocumentId() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        [OfficeAvailability(FileFormatVersions.Office2013)]
        [StringValidator(IsToken = true, Pattern = "\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}")]
        [SchemaAttr(69, "val")]
        [Index(0)]
        public StringValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PersistentDocumentId>(deep);
    }

    /// <summary>
    /// <para>Defines the FootnoteColumns Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:footnoteColumns.</para>
    /// </summary>
    [SchemaAttr(69, "footnoteColumns")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FootnoteColumns : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FootnoteColumns class.
        /// </summary>
        public FootnoteColumns() : base()
        {
        }

        /// <summary>
        /// <para>Decimal Number Value</para>
        /// <para>Represents the following attribute in the schema: w:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(23, "val")]
        [Index(0)]
        public Int32Value Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FootnoteColumns>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentEx Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:commentEx.</para>
    /// </summary>
    [SchemaAttr(69, "commentEx")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class CommentEx : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentEx class.
        /// </summary>
        public CommentEx() : base()
        {
        }

        /// <summary>
        /// <para>paraId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:paraId</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        [RequiredValidator()]
        [OfficeAvailability(FileFormatVersions.Office2013)]
        [StringValidator(Length = 4L)]
        [SchemaAttr(69, "paraId")]
        [Index(0)]
        public HexBinaryValue ParaId { get; set; }

        /// <summary>
        /// <para>paraIdParent, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:paraIdParent</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        [OfficeAvailability(FileFormatVersions.Office2013)]
        [StringValidator(Length = 4L)]
        [SchemaAttr(69, "paraIdParent")]
        [Index(1)]
        public HexBinaryValue ParaIdParent { get; set; }

        /// <summary>
        /// <para>done, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:done</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        [OfficeAvailability(FileFormatVersions.Office2013)]
        [SchemaAttr(69, "done")]
        [Index(2)]
        public OnOffValue Done { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentEx>(deep);
    }

    /// <summary>
    /// <para>Defines the Person Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:person.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PresenceInfo &lt;w15:presenceInfo></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PresenceInfo), FileFormatVersions.Office2013)]
    [SchemaAttr(69, "person")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
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
        /// <para>author, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:author</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        [RequiredValidator()]
        [OfficeAvailability(FileFormatVersions.Office2013)]
        [SchemaAttr(69, "author")]
        [Index(0)]
        public StringValue Author { get; set; }

        /// <summary>
        /// <para>contact, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:contact</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        [RequiredValidator()]
        [OfficeAvailability(FileFormatVersions.Office2013)]
        [SchemaAttr(69, "contact")]
        [Index(1)]
        public StringValue Contact { get; set; }

        /// <summary>
        /// <para>PresenceInfo.</para>
        /// <para>Represents the following element tag in the schema: w15:presenceInfo.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15 = http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        public PresenceInfo PresenceInfo
        {
            get => GetElement<PresenceInfo>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Word.PresenceInfo), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Person>(deep);
    }

    /// <summary>
    /// <para>Defines the PresenceInfo Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:presenceInfo.</para>
    /// </summary>
    [SchemaAttr(69, "presenceInfo")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class PresenceInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PresenceInfo class.
        /// </summary>
        public PresenceInfo() : base()
        {
        }

        /// <summary>
        /// <para>providerId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:providerId</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        [RequiredValidator()]
        [OfficeAvailability(FileFormatVersions.Office2013)]
        [SchemaAttr(69, "providerId")]
        [Index(0)]
        public StringValue ProviderId { get; set; }

        /// <summary>
        /// <para>userId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:userId</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        [RequiredValidator()]
        [OfficeAvailability(FileFormatVersions.Office2013)]
        [SchemaAttr(69, "userId")]
        [Index(1)]
        public StringValue UserId { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresenceInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the SectionTitle Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:sectionTitle.</para>
    /// </summary>
    [SchemaAttr(69, "sectionTitle")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class SectionTitle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SectionTitle class.
        /// </summary>
        public SectionTitle() : base()
        {
        }

        /// <summary>
        /// <para>String Value</para>
        /// <para>Represents the following attribute in the schema: w:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(23, "val")]
        [Index(0)]
        public StringValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionTitle>(deep);
    }

    /// <summary>
    /// Defines the SdtAppearance enumeration.
    /// </summary>
    public enum SdtAppearance
    {
        ///<summary>
        ///boundingBox.
        ///<para>When the item is serialized out as xml, its value is "boundingBox".</para>
        ///</summary>
        [EnumString("boundingBox")]
        BoundingBox,
        ///<summary>
        ///tags.
        ///<para>When the item is serialized out as xml, its value is "tags".</para>
        ///</summary>
        [EnumString("tags")]
        Tags,
        ///<summary>
        ///hidden.
        ///<para>When the item is serialized out as xml, its value is "hidden".</para>
        ///</summary>
        [EnumString("hidden")]
        Hidden,
    }
}