// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Excel.RichData2
{
    /// <summary>
    /// <para>Defines the RichFilterColumn Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:filterColumn.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichFilters &lt;xlrd2:filters></description></item>
    ///   <item><description>RichTop10 &lt;xlrd2:top10></description></item>
    ///   <item><description>CustomRichFilters &lt;xlrd2:customFilters></description></item>
    ///   <item><description>DynamicRichFilter &lt;xlrd2:dynamicFilter></description></item>
    ///   <item><description>ExtensionList &lt;xlrd2:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "filterColumn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichFilterColumn : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichFilterColumn class.
        /// </summary>
        public RichFilterColumn() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFilterColumn class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichFilterColumn(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFilterColumn class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichFilterColumn(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFilterColumn class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichFilterColumn(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "filterColumn");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichFilters>();
            builder.AddChild<RichTop10>();
            builder.AddChild<CustomRichFilters>();
            builder.AddChild<DynamicRichFilter>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFilters), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichTop10), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.CustomRichFilters), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.DynamicRichFilter), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 1, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>RichFilters.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:filters.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public RichFilters? RichFilters
        {
            get => GetElement<RichFilters>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RichTop10.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:top10.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public RichTop10? RichTop10
        {
            get => GetElement<RichTop10>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CustomRichFilters.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:customFilters.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public CustomRichFilters? CustomRichFilters
        {
            get => GetElement<CustomRichFilters>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DynamicRichFilter.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:dynamicFilter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DynamicRichFilter? DynamicRichFilter
        {
            get => GetElement<DynamicRichFilter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public ExtensionList? ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichFilterColumn>(deep);
    }

    /// <summary>
    /// <para>Defines the RichSortCondition Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:richSortCondition.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "richSortCondition")]
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
            builder.SetSchema(97, "richSortCondition");
            builder.Availability = FileFormatVersions.Office2019;
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

    /// <summary>
    /// <para>Defines the SupportingPropertyBags Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:supportingPropertyBags.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SupportingPropertyBagArrayData &lt;xlrd2:spbArrays></description></item>
    ///   <item><description>SupportingPropertyBagData &lt;xlrd2:spbData></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "supportingPropertyBags")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SupportingPropertyBags : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBags class.
        /// </summary>
        public SupportingPropertyBags() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBags class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBags(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBags class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBags(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBags class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBags(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "supportingPropertyBags");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<SupportingPropertyBagArrayData>();
            builder.AddChild<SupportingPropertyBagData>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayData), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagData), 1, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>SupportingPropertyBagArrayData.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:spbArrays.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public SupportingPropertyBagArrayData? SupportingPropertyBagArrayData
        {
            get => GetElement<SupportingPropertyBagArrayData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SupportingPropertyBagData.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:spbData.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public SupportingPropertyBagData? SupportingPropertyBagData
        {
            get => GetElement<SupportingPropertyBagData>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBags>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagStructures Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:spbStructures.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SupportingPropertyBagStructure &lt;xlrd2:s></description></item>
    ///   <item><description>ExtensionList &lt;xlrd2:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "spbStructures")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SupportingPropertyBagStructures : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructures class.
        /// </summary>
        public SupportingPropertyBagStructures() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructures class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagStructures(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructures class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagStructures(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructures class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBagStructures(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "count")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "spbStructures");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<SupportingPropertyBagStructure>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<SupportingPropertyBagStructures>()
.AddAttribute(0, "count", a => a.Count, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagStructure), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagStructures>(deep);
    }

    /// <summary>
    /// <para>Defines the ArrayData Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:arrayData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Array &lt;xlrd2:a></description></item>
    ///   <item><description>ExtensionList &lt;xlrd2:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "arrayData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArrayData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ArrayData class.
        /// </summary>
        public ArrayData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArrayData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ArrayData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArrayData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ArrayData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArrayData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ArrayData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "count")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "arrayData");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<Array>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<ArrayData>()
.AddAttribute(0, "count", a => a.Count, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.Array), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArrayData>(deep);
    }

    /// <summary>
    /// <para>Defines the RichStylesheet Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:richStyleSheet.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Dxfs &lt;xlrd2:dxfs></description></item>
    ///   <item><description>RichFormatProperties &lt;xlrd2:richProperties></description></item>
    ///   <item><description>RichStyles &lt;xlrd2:richStyles></description></item>
    ///   <item><description>ExtensionList &lt;xlrd2:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "richStyleSheet")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichStylesheet : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichStylesheet class.
        /// </summary>
        public RichStylesheet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStylesheet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichStylesheet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStylesheet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichStylesheet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStylesheet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichStylesheet(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "richStyleSheet");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<Dxfs>();
            builder.AddChild<RichFormatProperties>();
            builder.AddChild<RichStyles>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.Dxfs), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatProperties), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStyles), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>Dxfs.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:dxfs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public Dxfs? Dxfs
        {
            get => GetElement<Dxfs>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RichFormatProperties.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:richProperties.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public RichFormatProperties? RichFormatProperties
        {
            get => GetElement<RichFormatProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RichStyles.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:richStyles.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public RichStyles? RichStyles
        {
            get => GetElement<RichStyles>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public ExtensionList? ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichStylesheet>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueTypesInfo Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:rvTypesInfo.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichValueGlobalType &lt;xlrd2:global></description></item>
    ///   <item><description>RichValueTypes &lt;xlrd2:types></description></item>
    ///   <item><description>ExtensionList &lt;xlrd2:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "rvTypesInfo")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValueTypesInfo : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueTypesInfo class.
        /// </summary>
        public RichValueTypesInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypesInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypesInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypesInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypesInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypesInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueTypesInfo(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "rvTypesInfo");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichValueGlobalType>();
            builder.AddChild<RichValueTypes>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueGlobalType), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypes), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>RichValueGlobalType.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:global.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public RichValueGlobalType? RichValueGlobalType
        {
            get => GetElement<RichValueGlobalType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RichValueTypes.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:types.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public RichValueTypes? RichValueTypes
        {
            get => GetElement<RichValueTypes>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public ExtensionList? ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueTypesInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the RichFilters Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:filters.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichFilter &lt;xlrd2:filter></description></item>
    ///   <item><description>RichDateGroupItem &lt;xlrd2:dateGroupItem></description></item>
    ///   <item><description>ExtensionList &lt;xlrd2:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "filters")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichFilters : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichFilters class.
        /// </summary>
        public RichFilters() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFilters class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichFilters(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFilters class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichFilters(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFilters class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichFilters(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "filters");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichFilter>();
            builder.AddChild<RichDateGroupItem>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFilter), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichDateGroupItem), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichFilters>(deep);
    }

    /// <summary>
    /// <para>Defines the RichTop10 Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:top10.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "top10")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichTop10 : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichTop10 class.
        /// </summary>
        public RichTop10() : base()
        {
        }

        /// <summary>
        /// <para>key, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: key</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "key")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Key
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Top</para>
        /// <para>Represents the following attribute in the schema: top</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "top")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Top
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Filter by Percent</para>
        /// <para>Represents the following attribute in the schema: percent</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "percent")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Percent
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Top or Bottom Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DoubleValue? Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Filter Value</para>
        /// <para>Represents the following attribute in the schema: filterVal</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "filterVal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DoubleValue? FilterValue
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "top10");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichTop10>()
.AddAttribute(0, "key", a => a.Key)
.AddAttribute(0, "top", a => a.Top)
.AddAttribute(0, "percent", a => a.Percent)
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "filterVal", a => a.FilterValue);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichTop10>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomRichFilters Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:customFilters.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CustomRichFilter &lt;xlrd2:customFilter></description></item>
    ///   <item><description>ExtensionList &lt;xlrd2:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "customFilters")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CustomRichFilters : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomRichFilters class.
        /// </summary>
        public CustomRichFilters() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomRichFilters class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomRichFilters(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomRichFilters class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomRichFilters(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomRichFilters class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomRichFilters(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>and, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: and</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "and")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? And
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "customFilters");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<CustomRichFilter>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<CustomRichFilters>()
.AddAttribute(0, "and", a => a.And);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 2)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.CustomRichFilter), 0, 1, version: FileFormatVersions.Office2019),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomRichFilters>(deep);
    }

    /// <summary>
    /// <para>Defines the DynamicRichFilter Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:dynamicFilter.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "dynamicFilter")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DynamicRichFilter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DynamicRichFilter class.
        /// </summary>
        public DynamicRichFilter() : base()
        {
        }

        /// <summary>
        /// <para>key, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: key</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "key")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Key
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Dynamic filter type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DynamicFilterValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DynamicFilterValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DoubleValue? Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Max Value</para>
        /// <para>Represents the following attribute in the schema: maxVal</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "maxVal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DoubleValue? MaxVal
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>valIso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: valIso</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "valIso")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DateTimeValue? ValIso
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxValIso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: maxValIso</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "maxValIso")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DateTimeValue? MaxValIso
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "dynamicFilter");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<DynamicRichFilter>()
.AddAttribute(0, "key", a => a.Key)
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "val", a => a.Val)
.AddAttribute(0, "maxVal", a => a.MaxVal)
.AddAttribute(0, "valIso", a => a.ValIso, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
})
.AddAttribute(0, "maxValIso", a => a.MaxValIso, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DynamicRichFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the RichExtensionList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:richExtLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;xlrd2:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "richExtLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichExtensionList class.
        /// </summary>
        public RichExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "richExtLst");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 1, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public ExtensionList? ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Extension &lt;x:ext></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "extLst")]
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
            builder.SetSchema(97, "extLst");
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
    /// <para>Defines the RichFilter Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:filter.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "filter")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichFilter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichFilter class.
        /// </summary>
        public RichFilter() : base()
        {
        }

        /// <summary>
        /// <para>key, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: key</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "key")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Key
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>blank, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: blank</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "blank")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Blank
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>nodata, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: nodata</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "nodata")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Nodata
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "filter");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichFilter>()
.AddAttribute(0, "key", a => a.Key)
.AddAttribute(0, "val", a => a.Val)
.AddAttribute(0, "blank", a => a.Blank)
.AddAttribute(0, "nodata", a => a.Nodata);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the RichDateGroupItem Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:dateGroupItem.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "dateGroupItem")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichDateGroupItem : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichDateGroupItem class.
        /// </summary>
        public RichDateGroupItem() : base()
        {
        }

        /// <summary>
        /// <para>key, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: key</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "key")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Key
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Year</para>
        /// <para>Represents the following attribute in the schema: year</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "year")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt16Value? Year
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Month</para>
        /// <para>Represents the following attribute in the schema: month</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "month")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt16Value? Month
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Day</para>
        /// <para>Represents the following attribute in the schema: day</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "day")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt16Value? Day
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hour</para>
        /// <para>Represents the following attribute in the schema: hour</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "hour")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt16Value? Hour
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minute</para>
        /// <para>Represents the following attribute in the schema: minute</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "minute")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt16Value? Minute
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Second</para>
        /// <para>Represents the following attribute in the schema: second</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "second")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt16Value? Second
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Date Time Grouping</para>
        /// <para>Represents the following attribute in the schema: dateTimeGrouping</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dateTimeGrouping")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DateTimeGroupingValues>? DateTimeGrouping
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DateTimeGroupingValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "dateGroupItem");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichDateGroupItem>()
.AddAttribute(0, "key", a => a.Key)
.AddAttribute(0, "year", a => a.Year, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "month", a => a.Month)
.AddAttribute(0, "day", a => a.Day)
.AddAttribute(0, "hour", a => a.Hour)
.AddAttribute(0, "minute", a => a.Minute)
.AddAttribute(0, "second", a => a.Second)
.AddAttribute(0, "dateTimeGrouping", a => a.DateTimeGrouping, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichDateGroupItem>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomRichFilter Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:customFilter.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "customFilter")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CustomRichFilter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomRichFilter class.
        /// </summary>
        public CustomRichFilter() : base()
        {
        }

        /// <summary>
        /// <para>key, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: key</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "key")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Key
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Filter Comparison Operator</para>
        /// <para>Represents the following attribute in the schema: operator</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "operator")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.FilterOperatorValues>? Operator
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.FilterOperatorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Top or Bottom Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "customFilter");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<CustomRichFilter>()
.AddAttribute(0, "key", a => a.Key)
.AddAttribute(0, "operator", a => a.Operator)
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomRichFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagArrayData Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:spbArrays.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SupportingPropertyBagArray &lt;xlrd2:a></description></item>
    ///   <item><description>ExtensionList &lt;xlrd2:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "spbArrays")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SupportingPropertyBagArrayData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArrayData class.
        /// </summary>
        public SupportingPropertyBagArrayData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArrayData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagArrayData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArrayData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagArrayData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArrayData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBagArrayData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "count")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "spbArrays");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<SupportingPropertyBagArray>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<SupportingPropertyBagArrayData>()
.AddAttribute(0, "count", a => a.Count, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArray), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagArrayData>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagData Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:spbData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SupportingPropertyBag &lt;xlrd2:spb></description></item>
    ///   <item><description>ExtensionList &lt;xlrd2:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "spbData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SupportingPropertyBagData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagData class.
        /// </summary>
        public SupportingPropertyBagData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBagData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "count")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "spbData");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<SupportingPropertyBag>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<SupportingPropertyBagData>()
.AddAttribute(0, "count", a => a.Count, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBag), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagData>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBag Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:spb.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SupportingPropertyBagValue &lt;xlrd2:v></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "spb")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SupportingPropertyBag : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBag class.
        /// </summary>
        public SupportingPropertyBag() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBag class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBag(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBag class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBag(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBag class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBag(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>s, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: s</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "s")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? S
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "spb");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<SupportingPropertyBagValue>();
            builder.AddElement<SupportingPropertyBag>()
.AddAttribute(0, "s", a => a.S, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagValue), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBag>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagValue Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:v.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "v")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SupportingPropertyBagValue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagValue class.
        /// </summary>
        public SupportingPropertyBagValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagValue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SupportingPropertyBagValue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "v");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagValue>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagStructure Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:s.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SupportingPropertyBagKey &lt;xlrd2:k></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "s")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SupportingPropertyBagStructure : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructure class.
        /// </summary>
        public SupportingPropertyBagStructure() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructure class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagStructure(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructure class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagStructure(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructure class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBagStructure(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "s");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<SupportingPropertyBagKey>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagKey), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagStructure>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagKey Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:k.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "k")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SupportingPropertyBagKey : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagKey class.
        /// </summary>
        public SupportingPropertyBagKey() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "n")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagValueType>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagValueType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "k");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<SupportingPropertyBagKey>()
.AddAttribute(0, "n", a => a.N, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "t", a => a.T);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagKey>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagArray Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:a.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SupportingPropertyBagArrayValue &lt;xlrd2:v></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "a")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SupportingPropertyBagArray : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArray class.
        /// </summary>
        public SupportingPropertyBagArray() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArray class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagArray(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArray class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagArray(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArray class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBagArray(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "count")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "a");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<SupportingPropertyBagArrayValue>();
            builder.AddElement<SupportingPropertyBagArray>()
.AddAttribute(0, "count", a => a.Count, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayValue), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagArray>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagArrayValue Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:v.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "v")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SupportingPropertyBagArrayValue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArrayValue class.
        /// </summary>
        public SupportingPropertyBagArrayValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArrayValue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SupportingPropertyBagArrayValue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayValueType>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayValueType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "v");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<SupportingPropertyBagArrayValue>()
.AddAttribute(0, "t", a => a.T);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagArrayValue>(deep);
    }

    /// <summary>
    /// <para>Defines the Array Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:a.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArrayValue &lt;xlrd2:v></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "a")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Array : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Array class.
        /// </summary>
        public Array() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Array class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Array(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Array class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Array(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Array class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Array(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>r, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "r")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? R
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>c, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: c</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "c")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? C
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "a");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<ArrayValue>();
            builder.AddElement<Array>()
.AddAttribute(0, "r", a => a.R, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "c", a => a.C);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ArrayValue), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Array>(deep);
    }

    /// <summary>
    /// <para>Defines the ArrayValue Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:v.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "v")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArrayValue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ArrayValue class.
        /// </summary>
        public ArrayValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArrayValue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ArrayValue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ArrayValueType>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ArrayValueType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "v");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<ArrayValue>()
.AddAttribute(0, "t", a => a.T);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArrayValue>(deep);
    }

    /// <summary>
    /// <para>Defines the Dxfs Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:dxfs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat &lt;x:dxf></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "dxfs")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Dxfs : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Dxfs class.
        /// </summary>
        public Dxfs() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Dxfs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Dxfs(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Dxfs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Dxfs(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Dxfs class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Dxfs(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Format Count</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "count")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "dxfs");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat>();
            builder.AddElement<Dxfs>()
.AddAttribute(0, "count", a => a.Count);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Dxfs>(deep);
    }

    /// <summary>
    /// <para>Defines the RichFormatProperties Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:richProperties.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichFormatProperty &lt;xlrd2:rPr></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "richProperties")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichFormatProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichFormatProperties class.
        /// </summary>
        public RichFormatProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFormatProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichFormatProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFormatProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichFormatProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFormatProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichFormatProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "richProperties");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichFormatProperty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatProperty), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichFormatProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the RichStyles Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:richStyles.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichStyle &lt;xlrd2:rSty></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "richStyles")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichStyles : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichStyles class.
        /// </summary>
        public RichStyles() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStyles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichStyles(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStyles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichStyles(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStyles class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichStyles(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "richStyles");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichStyle>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStyle), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichStyles>(deep);
    }

    /// <summary>
    /// <para>Defines the RichFormatProperty Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:rPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "rPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichFormatProperty : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichFormatProperty class.
        /// </summary>
        public RichFormatProperty() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "n")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatPropertyType>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatPropertyType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "rPr");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichFormatProperty>()
.AddAttribute(0, "n", a => a.N, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "t", a => a.T, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichFormatProperty>(deep);
    }

    /// <summary>
    /// <para>Defines the RichStyle Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:rSty.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichStylePropertyValue &lt;xlrd2:rpv></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "rSty")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichStyle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichStyle class.
        /// </summary>
        public RichStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichStyle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>dxfid, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: dxfid</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dxfid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Dxfid
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "rSty");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichStylePropertyValue>();
            builder.AddElement<RichStyle>()
.AddAttribute(0, "dxfid", a => a.Dxfid);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStylePropertyValue), 0, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the RichStylePropertyValue Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:rpv.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "rpv")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichStylePropertyValue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the RichStylePropertyValue class.
        /// </summary>
        public RichStylePropertyValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStylePropertyValue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public RichStylePropertyValue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>i, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: i</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "i")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? I
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "rpv");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichStylePropertyValue>()
.AddAttribute(0, "i", a => a.I, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichStylePropertyValue>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueGlobalType Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:global.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichValueTypeKeyFlags &lt;xlrd2:keyFlags></description></item>
    ///   <item><description>ExtensionList &lt;xlrd2:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "global")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValueGlobalType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueGlobalType class.
        /// </summary>
        public RichValueGlobalType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueGlobalType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueGlobalType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueGlobalType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueGlobalType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueGlobalType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueGlobalType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "global");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichValueTypeKeyFlags>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeKeyFlags), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>RichValueTypeKeyFlags.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:keyFlags.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public RichValueTypeKeyFlags? RichValueTypeKeyFlags
        {
            get => GetElement<RichValueTypeKeyFlags>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public ExtensionList? ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueGlobalType>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueTypes Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:types.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichValueType &lt;xlrd2:type></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "types")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValueTypes : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueTypes class.
        /// </summary>
        public RichValueTypes() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypes class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypes(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypes class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypes(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypes class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueTypes(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "types");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichValueType>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueType), 0, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueTypes>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueType Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:type.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichValueTypeKeyFlags &lt;xlrd2:keyFlags></description></item>
    ///   <item><description>ExtensionList &lt;xlrd2:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "type")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValueType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueType class.
        /// </summary>
        public RichValueType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2019 and later.</para>
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "type");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichValueTypeKeyFlags>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<RichValueType>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeKeyFlags), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>RichValueTypeKeyFlags.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:keyFlags.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public RichValueTypeKeyFlags? RichValueTypeKeyFlags
        {
            get => GetElement<RichValueTypeKeyFlags>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public ExtensionList? ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueType>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueTypeKeyFlags Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:keyFlags.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichValueTypeReservedKey &lt;xlrd2:key></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "keyFlags")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValueTypeKeyFlags : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueTypeKeyFlags class.
        /// </summary>
        public RichValueTypeKeyFlags() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypeKeyFlags class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypeKeyFlags(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypeKeyFlags class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypeKeyFlags(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypeKeyFlags class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueTypeKeyFlags(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "keyFlags");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichValueTypeReservedKey>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeReservedKey), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueTypeKeyFlags>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueTypeReservedKey Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:key.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichValueTypeReservedKeyFlag &lt;xlrd2:flag></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "key")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValueTypeReservedKey : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueTypeReservedKey class.
        /// </summary>
        public RichValueTypeReservedKey() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypeReservedKey class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypeReservedKey(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypeReservedKey class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypeReservedKey(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypeReservedKey class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueTypeReservedKey(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2019 and later.</para>
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "key");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichValueTypeReservedKeyFlag>();
            builder.AddElement<RichValueTypeReservedKey>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeReservedKeyFlag), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueTypeReservedKey>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueTypeReservedKeyFlag Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:flag.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(97, "flag")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValueTypeReservedKeyFlag : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueTypeReservedKeyFlag class.
        /// </summary>
        public RichValueTypeReservedKeyFlag() : base()
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2019 and later.</para>
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
        /// <para>value, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "value")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Value
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(97, "flag");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichValueTypeReservedKeyFlag>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "value", a => a.Value, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueTypeReservedKeyFlag>(deep);
    }

    /// <summary>
    /// Defines the SupportingPropertyBagValueType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    public enum SupportingPropertyBagValueType
    {
        ///<summary>
        ///d.
        ///<para>When the item is serialized out as xml, its value is "d".</para>
        ///</summary>
        [EnumString("d")]
        D,
        ///<summary>
        ///i.
        ///<para>When the item is serialized out as xml, its value is "i".</para>
        ///</summary>
        [EnumString("i")]
        I,
        ///<summary>
        ///b.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        B,
        ///<summary>
        ///s.
        ///<para>When the item is serialized out as xml, its value is "s".</para>
        ///</summary>
        [EnumString("s")]
        S,
        ///<summary>
        ///spb.
        ///<para>When the item is serialized out as xml, its value is "spb".</para>
        ///</summary>
        [EnumString("spb")]
        Spb,
        ///<summary>
        ///spba.
        ///<para>When the item is serialized out as xml, its value is "spba".</para>
        ///</summary>
        [EnumString("spba")]
        Spba,
    }

    /// <summary>
    /// Defines the SupportingPropertyBagArrayValueType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    public enum SupportingPropertyBagArrayValueType
    {
        ///<summary>
        ///d.
        ///<para>When the item is serialized out as xml, its value is "d".</para>
        ///</summary>
        [EnumString("d")]
        D,
        ///<summary>
        ///i.
        ///<para>When the item is serialized out as xml, its value is "i".</para>
        ///</summary>
        [EnumString("i")]
        I,
        ///<summary>
        ///b.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        B,
        ///<summary>
        ///s.
        ///<para>When the item is serialized out as xml, its value is "s".</para>
        ///</summary>
        [EnumString("s")]
        S,
        ///<summary>
        ///spb.
        ///<para>When the item is serialized out as xml, its value is "spb".</para>
        ///</summary>
        [EnumString("spb")]
        Spb,
    }

    /// <summary>
    /// Defines the ArrayValueType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    public enum ArrayValueType
    {
        ///<summary>
        ///d.
        ///<para>When the item is serialized out as xml, its value is "d".</para>
        ///</summary>
        [EnumString("d")]
        D,
        ///<summary>
        ///i.
        ///<para>When the item is serialized out as xml, its value is "i".</para>
        ///</summary>
        [EnumString("i")]
        I,
        ///<summary>
        ///b.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        B,
        ///<summary>
        ///e.
        ///<para>When the item is serialized out as xml, its value is "e".</para>
        ///</summary>
        [EnumString("e")]
        E,
        ///<summary>
        ///s.
        ///<para>When the item is serialized out as xml, its value is "s".</para>
        ///</summary>
        [EnumString("s")]
        S,
        ///<summary>
        ///r.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        R,
        ///<summary>
        ///a.
        ///<para>When the item is serialized out as xml, its value is "a".</para>
        ///</summary>
        [EnumString("a")]
        A,
    }

    /// <summary>
    /// Defines the RichFormatPropertyType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    public enum RichFormatPropertyType
    {
        ///<summary>
        ///b.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        B,
        ///<summary>
        ///n.
        ///<para>When the item is serialized out as xml, its value is "n".</para>
        ///</summary>
        [EnumString("n")]
        N,
        ///<summary>
        ///i.
        ///<para>When the item is serialized out as xml, its value is "i".</para>
        ///</summary>
        [EnumString("i")]
        I,
        ///<summary>
        ///s.
        ///<para>When the item is serialized out as xml, its value is "s".</para>
        ///</summary>
        [EnumString("s")]
        S,
    }
}