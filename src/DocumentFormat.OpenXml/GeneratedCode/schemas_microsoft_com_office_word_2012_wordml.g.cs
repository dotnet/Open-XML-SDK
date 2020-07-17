// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
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
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Run Content Theme Color</para>
        /// <para>Represents the following attribute in the schema: w:themeColor</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues> ThemeColor
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Run Content Theme Color Tint</para>
        /// <para>Represents the following attribute in the schema: w:themeTint</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public StringValue ThemeTint
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Run Content Theme Color Shade</para>
        /// <para>Represents the following attribute in the schema: w:themeShade</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public StringValue ThemeShade
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "color");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<Color>()
.AddAttribute(23, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Wordprocessing.AutomaticColorValues>>(EnumValidator.Instance);
union.AddValidator<HexBinaryValue>(new StringValidator() { Length = (3L) });
});
})
.AddAttribute(23, "themeColor", a => a.ThemeColor)
.AddAttribute(23, "themeTint", a => a.ThemeTint, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Pattern = ("[0-9a-fA-F]*"), MinLength = (1L), MaxLength = (2L) });
})
.AddAttribute(23, "themeShade", a => a.ThemeShade, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Pattern = ("[0-9a-fA-F]*"), MinLength = (1L), MaxLength = (2L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Color>(deep);
    }

    /// <summary>
    /// <para>Defines the DataBinding Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:dataBinding.</para>
    /// </summary>
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
        public StringValue PrefixMappings
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>XPath</para>
        /// <para>Represents the following attribute in the schema: w:xpath</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public StringValue XPath
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Custom XML Data Storage ID</para>
        /// <para>Represents the following attribute in the schema: w:storeItemID</para>
        /// </summary>
        /// <remark>
        /// xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public StringValue StoreItemId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "dataBinding");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<DataBinding>()
.AddAttribute(23, "prefixMappings", a => a.PrefixMappings)
.AddAttribute(23, "xpath", a => a.XPath, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(23, "storeItemID", a => a.StoreItemId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataBinding>(deep);
    }

    /// <summary>
    /// <para>Defines the Appearance Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:appearance.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "appearance");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<Appearance>()
.AddAttribute(69, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2013));
});
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "commentsEx");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<CommentEx>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Word.CommentEx), 0, 0, version: FileFormatVersions.Office2013)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "people");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<Person>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Word.Person), 0, 0, version: FileFormatVersions.Office2013)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "repeatingSection");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<SectionTitle>();
            builder.AddChild<DoNotAllowInsertDeleteSection>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Word.SectionTitle), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Word.DoNotAllowInsertDeleteSection), 0, 1, version: FileFormatVersions.Office2013)
            };
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SdtRepeatedSection>(deep);
    }

    /// <summary>
    /// <para>Defines the SdtRepeatedSectionItem Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:repeatingSectionItem.</para>
    /// </summary>
    public partial class SdtRepeatedSectionItem : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SdtRepeatedSectionItem class.
        /// </summary>
        public SdtRepeatedSectionItem() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "repeatingSectionItem");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SdtRepeatedSectionItem>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartTrackingRefBased Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:chartTrackingRefBased.</para>
    /// </summary>
    public partial class ChartTrackingRefBased : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ChartTrackingRefBased class.
        /// </summary>
        public ChartTrackingRefBased() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "chartTrackingRefBased");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartTrackingRefBased>(deep);
    }

    /// <summary>
    /// <para>Defines the DefaultCollapsed Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:collapsed.</para>
    /// </summary>
    public partial class DefaultCollapsed : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the DefaultCollapsed class.
        /// </summary>
        public DefaultCollapsed() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "collapsed");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultCollapsed>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtensionLinked Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:webExtensionLinked.</para>
    /// </summary>
    public partial class WebExtensionLinked : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionLinked class.
        /// </summary>
        public WebExtensionLinked() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "webExtensionLinked");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionLinked>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtensionCreated Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:webExtensionCreated.</para>
    /// </summary>
    public partial class WebExtensionCreated : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionCreated class.
        /// </summary>
        public WebExtensionCreated() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "webExtensionCreated");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionCreated>(deep);
    }

    /// <summary>
    /// <para>Defines the DoNotAllowInsertDeleteSection Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:doNotAllowInsertDeleteSection.</para>
    /// </summary>
    public partial class DoNotAllowInsertDeleteSection : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the DoNotAllowInsertDeleteSection class.
        /// </summary>
        public DoNotAllowInsertDeleteSection() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "doNotAllowInsertDeleteSection");
            builder.Availability = FileFormatVersions.Office2013;
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
        public OnOffValue Val
        {
            get => GetAttribute<OnOffValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OnOffType>()
                           .AddAttribute(23, "val", a => a.Val);
        }
    }

    /// <summary>
    /// <para>Defines the PersistentDocumentId Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:docId.</para>
    /// </summary>
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
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "docId");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PersistentDocumentId>()
.AddAttribute(69, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2013));
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PersistentDocumentId>(deep);
    }

    /// <summary>
    /// <para>Defines the FootnoteColumns Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:footnoteColumns.</para>
    /// </summary>
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
        public Int32Value Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "footnoteColumns");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<FootnoteColumns>()
.AddAttribute(23, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FootnoteColumns>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentEx Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:commentEx.</para>
    /// </summary>
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
        public HexBinaryValue ParaId
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>paraIdParent, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:paraIdParent</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        public HexBinaryValue ParaIdParent
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>done, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:done</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        public OnOffValue Done
        {
            get => GetAttribute<OnOffValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "commentEx");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<CommentEx>()
.AddAttribute(69, "paraId", a => a.ParaId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2013));
aBuilder.AddValidator(new StringValidator() { Length = (4L) });
})
.AddAttribute(69, "paraIdParent", a => a.ParaIdParent, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2013));
aBuilder.AddValidator(new StringValidator() { Length = (4L) });
})
.AddAttribute(69, "done", a => a.Done, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2013));
});
            builder.AddConstraint(new AttributeValuePatternConstraint(0 /*w15:paraId*/, @"[0-9a-fA-F]{8}") { Application = ApplicationType.Word, Version = FileFormatVersions.Office2013 });
            builder.AddConstraint(new AttributeValueLengthConstraint(2 /*w15:done*/, 1, int.MaxValue) { Application = ApplicationType.Word, Version = FileFormatVersions.Office2013 });
        }

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
        public StringValue Author
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contact, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:contact</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        public StringValue Contact
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "person");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<PresenceInfo>();
            builder.AddElement<Person>()
.AddAttribute(69, "author", a => a.Author, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2013));
})
.AddAttribute(69, "contact", a => a.Contact, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2013));
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Word.PresenceInfo), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Person>(deep);
    }

    /// <summary>
    /// <para>Defines the PresenceInfo Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:presenceInfo.</para>
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
        /// <para>providerId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:providerId</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        public StringValue ProviderId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>userId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w15:userId</para>
        /// </summary>
        /// <remark>
        /// xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
        /// </remark>
        public StringValue UserId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "presenceInfo");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PresenceInfo>()
.AddAttribute(69, "providerId", a => a.ProviderId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2013));
})
.AddAttribute(69, "userId", a => a.UserId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2013));
});
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*w15:providerId*/, 1, 100) { Application = ApplicationType.Word, Version = FileFormatVersions.Office2013 });
            builder.AddConstraint(new AttributeValueLengthConstraint(1 /*w15:userId*/, 1, 300) { Application = ApplicationType.Word, Version = FileFormatVersions.Office2013 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresenceInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the SectionTitle Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w15:sectionTitle.</para>
    /// </summary>
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
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(69, "sectionTitle");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<SectionTitle>()
.AddAttribute(23, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionTitle>(deep);
    }

    /// <summary>
    /// Defines the SdtAppearance enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
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