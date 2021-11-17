﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2019.Excel.RichData2;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews
{
    /// <summary>
    /// <para>Defines the NamedSheetViews Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xnsv:namedSheetViews.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList" /> <c>&lt;xnsv:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.NamedSheetView" /> <c>&lt;xnsv:namedSheetView></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(129, "namedSheetViews")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NamedSheetViews : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the NamedSheetViews class.
        /// </summary>
        public NamedSheetViews() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NamedSheetViews class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NamedSheetViews(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NamedSheetViews class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NamedSheetViews(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NamedSheetViews class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NamedSheetViews(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(129, "namedSheetViews");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.NamedSheetView>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.NamedSheetView), 0, 0, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NamedSheetViews>(deep);

        internal NamedSheetViews(NamedSheetViewsPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the NamedSheetViewsPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(NamedSheetViewsPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the NamedSheetViewsPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(NamedSheetViewsPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the NamedSheetViewsPart associated with this element.
        /// </summary>
        public NamedSheetViewsPart? NamedSheetViewsPart
        {
            get => OpenXmlPart as NamedSheetViewsPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the NamedSheetView Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xnsv:namedSheetView.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList" /> <c>&lt;xnsv:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.NsvFilter" /> <c>&lt;xnsv:nsvFilter></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(129, "namedSheetView")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NamedSheetView : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NamedSheetView class.
        /// </summary>
        public NamedSheetView() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NamedSheetView class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NamedSheetView(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NamedSheetView class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NamedSheetView(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NamedSheetView class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NamedSheetView(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(129, "namedSheetView");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.NsvFilter>();
            builder.AddElement<NamedSheetView>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.NsvFilter), 0, 0, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NamedSheetView>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xnsv:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Extension" /> <c>&lt;x:ext></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(129, "extLst")]
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
            builder.SetSchema(129, "extLst");
            builder.Availability = FileFormatVersions.Office2021;
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
    /// <para>Defines the NsvFilter Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xnsv:nsvFilter.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList" /> <c>&lt;xnsv:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ColumnFilter" /> <c>&lt;xnsv:columnFilter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.SortRules" /> <c>&lt;xnsv:sortRules></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(129, "nsvFilter")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NsvFilter : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NsvFilter class.
        /// </summary>
        public NsvFilter() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NsvFilter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NsvFilter(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NsvFilter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NsvFilter(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NsvFilter class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NsvFilter(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>filterId, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: filterId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "filterId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FilterId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref, this property is only available in Office 2021 and later.</para>
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
        /// <para>tableId, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: tableId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "tableId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? TableId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(129, "nsvFilter");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ColumnFilter>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.SortRules>();
            builder.AddElement<NsvFilter>()
.AddAttribute(0, "filterId", a => a.FilterId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ref", a => a.Ref)
.AddAttribute(0, "tableId", a => a.TableId);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ColumnFilter), 0, 0, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.SortRules), 0, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NsvFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the ColumnFilter Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xnsv:columnFilter.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.DifferentialFormatType" /> <c>&lt;xnsv:dxf></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList" /> <c>&lt;xnsv:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.FilterColumn" /> <c>&lt;xnsv:filter></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(129, "columnFilter")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColumnFilter : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColumnFilter class.
        /// </summary>
        public ColumnFilter() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnFilter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColumnFilter(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnFilter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColumnFilter(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnFilter class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColumnFilter(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>colId, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: colId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "colId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? ColId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(129, "columnFilter");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.DifferentialFormatType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.FilterColumn>();
            builder.AddElement<ColumnFilter>()
.AddAttribute(0, "colId", a => a.ColId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.DifferentialFormatType), 0, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.FilterColumn), 0, 0, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>DifferentialFormatType.</para>
        /// <para>Represents the following element tag in the schema: xnsv:dxf.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xnsv = http://schemas.microsoft.com/office/spreadsheetml/2019/namedsheetviews
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.DifferentialFormatType? DifferentialFormatType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.DifferentialFormatType>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the SortRules Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xnsv:sortRules.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList" /> <c>&lt;xnsv:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.SortRule" /> <c>&lt;xnsv:sortRule></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(129, "sortRules")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SortRules : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SortRules class.
        /// </summary>
        public SortRules() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SortRules class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SortRules(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SortRules class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SortRules(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SortRules class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SortRules(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>sortMethod, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: sortMethod</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "sortMethod")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortMethodValues>? SortMethod
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortMethodValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>caseSensitive, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: caseSensitive</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "caseSensitive")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? CaseSensitive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(129, "sortRules");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.SortRule>();
            builder.AddElement<SortRules>()
.AddAttribute(0, "sortMethod", a => a.SortMethod)
.AddAttribute(0, "caseSensitive", a => a.CaseSensitive);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.SortRule), 0, 64, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SortRules>(deep);
    }

    /// <summary>
    /// <para>Defines the DifferentialFormatType Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xnsv:dxf.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Border" /> <c>&lt;x:border></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Alignment" /> <c>&lt;x:alignment></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Protection" /> <c>&lt;x:protection></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ExtensionList" /> <c>&lt;x:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Fill" /> <c>&lt;x:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Font" /> <c>&lt;x:font></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.NumberingFormat" /> <c>&lt;x:numFmt></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(129, "dxf")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DifferentialFormatType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DifferentialFormatType class.
        /// </summary>
        public DifferentialFormatType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormatType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DifferentialFormatType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormatType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DifferentialFormatType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormatType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DifferentialFormatType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(129, "dxf");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Border>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Alignment>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Protection>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Font>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.NumberingFormat>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Font), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.NumberingFormat), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Fill), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Alignment), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Border), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Protection), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Font Properties.</para>
        /// <para>Represents the following element tag in the schema: x:font.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Font? Font
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Font>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Format.</para>
        /// <para>Represents the following element tag in the schema: x:numFmt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.NumberingFormat? NumberingFormat
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.NumberingFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Fill.</para>
        /// <para>Represents the following element tag in the schema: x:fill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Fill? Fill
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Fill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Alignment.</para>
        /// <para>Represents the following element tag in the schema: x:alignment.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Alignment? Alignment
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Alignment>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Border Properties.</para>
        /// <para>Represents the following element tag in the schema: x:border.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Border? Border
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Border>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Protection Properties.</para>
        /// <para>Represents the following element tag in the schema: x:protection.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Protection? Protection
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Protection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Future Feature Data Storage Area.</para>
        /// <para>Represents the following element tag in the schema: x:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DifferentialFormatType>(deep);
    }

    /// <summary>
    /// <para>Defines the FilterColumn Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xnsv:filter.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ColorFilter" /> <c>&lt;x:colorFilter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.CustomFilters" /> <c>&lt;x:customFilters></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.DynamicFilter" /> <c>&lt;x:dynamicFilter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ExtensionList" /> <c>&lt;x:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Filters" /> <c>&lt;x:filters></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.IconFilter" /> <c>&lt;x:iconFilter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Top10" /> <c>&lt;x:top10></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.CustomFilters" /> <c>&lt;x14:customFilters></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.IconFilter" /> <c>&lt;x14:iconFilter></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(129, "filter")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FilterColumn : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilterColumn class.
        /// </summary>
        public FilterColumn() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilterColumn class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilterColumn(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilterColumn class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilterColumn(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilterColumn class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilterColumn(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Filter Column Data</para>
        /// <para>Represents the following attribute in the schema: colId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "colId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? ColumnId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hidden AutoFilter Button</para>
        /// <para>Represents the following attribute in the schema: hiddenButton</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "hiddenButton")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? HiddenButton
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Show Filter Button</para>
        /// <para>Represents the following attribute in the schema: showButton</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "showButton")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? ShowButton
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(129, "filter");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ColorFilter>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.CustomFilters>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.DynamicFilter>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Filters>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.IconFilter>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Top10>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.CustomFilters>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.IconFilter>();
            builder.AddElement<FilterColumn>()
.AddAttribute(0, "colId", a => a.ColumnId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "hiddenButton", a => a.HiddenButton)
.AddAttribute(0, "showButton", a => a.ShowButton);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Filters), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Top10), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.CustomFilters), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.CustomFilters), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DynamicFilter), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ColorFilter), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.IconFilter), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.IconFilter), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Filter Criteria.</para>
        /// <para>Represents the following element tag in the schema: x:filters.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Filters? Filters
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Filters>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Top 10.</para>
        /// <para>Represents the following element tag in the schema: x:top10.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Top10? Top10
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Top10>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CustomFilters14.</para>
        /// <para>Represents the following element tag in the schema: x14:customFilters.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.CustomFilters? CustomFilters14
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.CustomFilters>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Custom Filters.</para>
        /// <para>Represents the following element tag in the schema: x:customFilters.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.CustomFilters? CustomFilters
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.CustomFilters>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Dynamic Filter.</para>
        /// <para>Represents the following element tag in the schema: x:dynamicFilter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.DynamicFilter? DynamicFilter
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.DynamicFilter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Color Filter Criteria.</para>
        /// <para>Represents the following element tag in the schema: x:colorFilter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ColorFilter? ColorFilter
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ColorFilter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>IconFilter14.</para>
        /// <para>Represents the following element tag in the schema: x14:iconFilter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.IconFilter? IconFilter14
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.IconFilter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Icon Filter.</para>
        /// <para>Represents the following element tag in the schema: x:iconFilter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.IconFilter? IconFilter
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.IconFilter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilterColumn>(deep);
    }

    /// <summary>
    /// <para>Defines the SortRule Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xnsv:sortRule.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.DifferentialFormatType" /> <c>&lt;xnsv:dxf></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.SortCondition" /> <c>&lt;xnsv:sortCondition></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.RichSortCondition" /> <c>&lt;xnsv:richSortCondition></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(129, "sortRule")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SortRule : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SortRule class.
        /// </summary>
        public SortRule() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SortRule class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SortRule(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SortRule class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SortRule(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SortRule class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SortRule(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>colId, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: colId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "colId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? ColId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(129, "sortRule");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.DifferentialFormatType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.SortCondition>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.RichSortCondition>();
            builder.AddElement<SortRule>()
.AddAttribute(0, "colId", a => a.ColId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.DifferentialFormatType), 0, 1, version: FileFormatVersions.Office2021),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.SortCondition), 0, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.RichSortCondition), 0, 1, version: FileFormatVersions.Office2021)
                }
            };
        }

        /// <summary>
        /// <para>DifferentialFormatType.</para>
        /// <para>Represents the following element tag in the schema: xnsv:dxf.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xnsv = http://schemas.microsoft.com/office/spreadsheetml/2019/namedsheetviews
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.DifferentialFormatType? DifferentialFormatType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.DifferentialFormatType>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SortRule>(deep);
    }

    /// <summary>
    /// <para>Defines the SortCondition Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xnsv:sortCondition.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(129, "sortCondition")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SortCondition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SortCondition class.
        /// </summary>
        public SortCondition() : base()
        {
        }

        /// <summary>
        /// <para>descending, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: descending</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "descending")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Descending
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sortBy, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sortBy</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "sortBy")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortByValues>? SortBy
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortByValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "ref")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>customList, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: customList</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "customList")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CustomList
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dxfId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: dxfId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dxfId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? FormatId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>iconSet, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: iconSet</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "iconSet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>? IconSet
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>iconId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: iconId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "iconId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? IconId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(129, "sortCondition");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<SortCondition>()
.AddAttribute(0, "descending", a => a.Descending)
.AddAttribute(0, "sortBy", a => a.SortBy)
.AddAttribute(0, "ref", a => a.Reference, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "customList", a => a.CustomList)
.AddAttribute(0, "dxfId", a => a.FormatId)
.AddAttribute(0, "iconSet", a => a.IconSet)
.AddAttribute(0, "iconId", a => a.IconId);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SortCondition>(deep);
    }

    /// <summary>
    /// <para>Defines the RichSortCondition Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xnsv:richSortCondition.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(129, "richSortCondition")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichSortCondition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichSortCondition class.
        /// </summary>
        public RichSortCondition() : base()
        {
        }

        /// <summary>
        /// <para>richSortKey, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: richSortKey</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "richSortKey")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? RichSortKey
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>descending, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: descending</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "descending")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Descending
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sortBy, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sortBy</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "sortBy")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortByValues>? SortBy
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortByValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "ref")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>customList, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: customList</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "customList")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CustomList
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dxfId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: dxfId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dxfId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? FormatId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>iconSet, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: iconSet</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "iconSet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>? IconSet
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>iconId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: iconId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "iconId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? IconId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(129, "richSortCondition");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<RichSortCondition>()
.AddAttribute(0, "richSortKey", a => a.RichSortKey)
.AddAttribute(0, "descending", a => a.Descending)
.AddAttribute(0, "sortBy", a => a.SortBy)
.AddAttribute(0, "ref", a => a.Reference, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "customList", a => a.CustomList)
.AddAttribute(0, "dxfId", a => a.FormatId)
.AddAttribute(0, "iconSet", a => a.IconSet)
.AddAttribute(0, "iconId", a => a.IconId);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichSortCondition>(deep);
    }
}