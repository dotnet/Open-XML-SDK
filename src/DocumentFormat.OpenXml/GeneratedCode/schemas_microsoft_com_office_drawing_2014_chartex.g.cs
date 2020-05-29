// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing
{
    /// <summary>
    /// <para>Defines the ChartSpace Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:chartSpace.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartData &lt;cx:chartData></description></item>
    ///   <item><description>Chart &lt;cx:chart></description></item>
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>TxPrTextBody &lt;cx:txPr></description></item>
    ///   <item><description>ColorMappingType &lt;cx:clrMapOvr></description></item>
    ///   <item><description>PrintSettings &lt;cx:printSettings></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ChartSpace : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartSpace class.
        /// </summary>
        public ChartSpace() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartSpace class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartSpace(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartSpace class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartSpace(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartSpace class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartSpace(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "chartSpace");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<ChartData>();
            builder.AddChild<Chart>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<TxPrTextBody>();
            builder.AddChild<ColorMappingType>();
            builder.AddChild<PrintSettings>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>ChartData.</para>
        /// <para>Represents the following element tag in the schema: cx:chartData.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ChartData ChartData
        {
            get => GetElement<ChartData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart.</para>
        /// <para>Represents the following element tag in the schema: cx:chart.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public Chart Chart
        {
            get => GetElement<Chart>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public TxPrTextBody TxPrTextBody
        {
            get => GetElement<TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColorMappingType.</para>
        /// <para>Represents the following element tag in the schema: cx:clrMapOvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ColorMappingType ColorMappingType
        {
            get => GetElement<ColorMappingType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PrintSettings.</para>
        /// <para>Represents the following element tag in the schema: cx:printSettings.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public PrintSettings PrintSettings
        {
            get => GetElement<PrintSettings>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartSpace>(deep);

        internal ChartSpace(ExtendedChartPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the ExtendedChartPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(ExtendedChartPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the ExtendedChartPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(ExtendedChartPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the ExtendedChartPart associated with this element.
        /// </summary>
        public ExtendedChartPart ExtendedChartPart
        {
            get => OpenXmlPart as ExtendedChartPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the BinCountXsdunsignedInt Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:binCount.</para>
    /// </summary>
    public partial class BinCountXsdunsignedInt : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the BinCountXsdunsignedInt class.
        /// </summary>
        public BinCountXsdunsignedInt() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BinCountXsdunsignedInt class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public BinCountXsdunsignedInt(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new UInt32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<UInt32Value>(NumberValidator.Instance);
            builder.SetSchema(80, "binCount");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BinCountXsdunsignedInt>(deep);
    }

    /// <summary>
    /// <para>Defines the Extension2 Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:ext.</para>
    /// </summary>
    public partial class Extension2 : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Extension2 class.
        /// </summary>
        public Extension2() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Extension2 class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Extension2(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Extension2 class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Extension2(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Extension2 class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Extension2(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>uri, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "ext");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<Extension2>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extension2>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartStringValue Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:pt.</para>
    /// </summary>
    public partial class ChartStringValue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartStringValue class.
        /// </summary>
        public ChartStringValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartStringValue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ChartStringValue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>idx, this property is only available in Office2016</para>
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
            builder.SetSchema(80, "pt");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ChartStringValue>()
.AddAttribute(0, "idx", a => a.Index, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartStringValue>(deep);
    }

    /// <summary>
    /// <para>Defines the NumericValue Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:pt.</para>
    /// </summary>
    public partial class NumericValue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the NumericValue class.
        /// </summary>
        public NumericValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumericValue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public NumericValue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new DoubleValue { InnerText = text };
        }

        /// <summary>
        /// <para>idx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        public UInt32Value Idx
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "pt");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<NumericValue>()
.AddAttribute(0, "idx", a => a.Idx, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumericValue>(deep);
    }

    /// <summary>
    /// <para>Defines the NumericDimension Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:numDim.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Formula &lt;cx:f></description></item>
    ///   <item><description>NumericLevel &lt;cx:lvl></description></item>
    /// </list>
    /// </remark>
    public partial class NumericDimension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NumericDimension class.
        /// </summary>
        public NumericDimension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumericDimension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumericDimension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumericDimension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumericDimension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumericDimension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NumericDimension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Dimension data type, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "numDim");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<Formula>();
            builder.AddChild<NumericLevel>();
            builder.AddElement<NumericDimension>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula), 1, 1, version: FileFormatVersions.Office2016),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel), 0, 0, version: FileFormatVersions.Office2016)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumericDimension>(deep);
    }

    /// <summary>
    /// <para>Defines the StringDimension Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:strDim.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Formula &lt;cx:f></description></item>
    ///   <item><description>StringLevel &lt;cx:lvl></description></item>
    /// </list>
    /// </remark>
    public partial class StringDimension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StringDimension class.
        /// </summary>
        public StringDimension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDimension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringDimension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDimension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringDimension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDimension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StringDimension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Dimension data type, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "strDim");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<Formula>();
            builder.AddChild<StringLevel>();
            builder.AddElement<StringDimension>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula), 1, 1, version: FileFormatVersions.Office2016),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel), 0, 0, version: FileFormatVersions.Office2016)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringDimension>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Extension2 &lt;cx:ext></description></item>
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
            builder.SetSchema(80, "extLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<Extension2>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ExternalData Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:externalData.</para>
    /// </summary>
    public partial class ExternalData : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ExternalData class.
        /// </summary>
        public ExternalData() : base()
        {
        }

        /// <summary>
        /// <para>RelId of the relationship for the external data, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>True if the external link should automatically update, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: cx:autoUpdate</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx=http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public BooleanValue AutoUpdate
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "externalData");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ExternalData>()
.AddAttribute(19, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(80, "autoUpdate", a => a.AutoUpdate, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2016));
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExternalData>(deep);
    }

    /// <summary>
    /// <para>Defines the Data Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:data.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumericDimension &lt;cx:numDim></description></item>
    ///   <item><description>StringDimension &lt;cx:strDim></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Data : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Data class.
        /// </summary>
        public Data() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Data class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Data(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Data class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Data(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Data class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Data(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public UInt32Value Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "data");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<NumericDimension>();
            builder.AddChild<StringDimension>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<Data>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension), 1, 1, version: FileFormatVersions.Office2016),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension), 1, 1, version: FileFormatVersions.Office2016)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Data>(deep);
    }

    /// <summary>
    /// <para>Defines the TextData Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:txData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Formula &lt;cx:f></description></item>
    ///   <item><description>VXsdstring &lt;cx:v></description></item>
    /// </list>
    /// </remark>
    public partial class TextData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextData class.
        /// </summary>
        public TextData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "txData");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<Formula>();
            builder.AddChild<VXsdstring>();
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula), 1, 1, version: FileFormatVersions.Office2016),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.VXsdstring), 0, 1, version: FileFormatVersions.Office2016)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextData>(deep);
    }

    /// <summary>
    /// <para>Defines the RichTextBody Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:rich.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
    /// </list>
    /// </remark>
    public partial class RichTextBody : TextBodyType
    {
        /// <summary>
        /// Initializes a new instance of the RichTextBody class.
        /// </summary>
        public RichTextBody() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichTextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichTextBody(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichTextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichTextBody(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichTextBody class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichTextBody(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "rich");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichTextBody>(deep);
    }

    /// <summary>
    /// <para>Defines the TxPrTextBody Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:txPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
    /// </list>
    /// </remark>
    public partial class TxPrTextBody : TextBodyType
    {
        /// <summary>
        /// Initializes a new instance of the TxPrTextBody class.
        /// </summary>
        public TxPrTextBody() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TxPrTextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TxPrTextBody(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TxPrTextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TxPrTextBody(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TxPrTextBody class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TxPrTextBody(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "txPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TxPrTextBody>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBodyType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
    /// </list>
    /// </remark>
    public abstract partial class TextBodyType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBodyType class.
        /// </summary>
        protected TextBodyType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TextBodyType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TextBodyType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected TextBodyType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
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
    }

    /// <summary>
    /// <para>Defines the Text Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:tx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TextData &lt;cx:txData></description></item>
    ///   <item><description>RichTextBody &lt;cx:rich></description></item>
    /// </list>
    /// </remark>
    public partial class Text : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Text class.
        /// </summary>
        public Text() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Text class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Text(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Text class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Text(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Text class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Text(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "tx");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<TextData>();
            builder.AddChild<RichTextBody>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData), 1, 1, version: FileFormatVersions.Office2016),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody), 1, 1, version: FileFormatVersions.Office2016)
                }
            };
        }

        /// <summary>
        /// <para>TextData.</para>
        /// <para>Represents the following element tag in the schema: cx:txData.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public TextData TextData
        {
            get => GetElement<TextData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RichTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:rich.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public RichTextBody RichTextBody
        {
            get => GetElement<RichTextBody>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Text>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:spPr.</para>
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
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "spPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList>();
            builder.AddElement<ShapeProperties>()
.AddAttribute(0, "bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisUnitsLabel Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:unitsLabel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Text &lt;cx:tx></description></item>
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>TxPrTextBody &lt;cx:txPr></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class AxisUnitsLabel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AxisUnitsLabel class.
        /// </summary>
        public AxisUnitsLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisUnitsLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisUnitsLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisUnitsLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisUnitsLabel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisUnitsLabel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AxisUnitsLabel(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "unitsLabel");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<Text>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<TxPrTextBody>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>Text.</para>
        /// <para>Represents the following element tag in the schema: cx:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public Text Text
        {
            get => GetElement<Text>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public TxPrTextBody TxPrTextBody
        {
            get => GetElement<TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisUnitsLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the CategoryAxisScaling Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:catScaling.</para>
    /// </summary>
    public partial class CategoryAxisScaling : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CategoryAxisScaling class.
        /// </summary>
        public CategoryAxisScaling() : base()
        {
        }

        /// <summary>
        /// <para>gapWidth, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: gapWidth</para>
        /// </summary>
        public StringValue GapWidth
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "catScaling");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<CategoryAxisScaling>()
.AddAttribute(0, "gapWidth", a => a.GapWidth, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<DoubleValue>(new NumberValidator() { MinInclusive = (0L) });
union.AddValidator(StringValidator.Instance);
});
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryAxisScaling>(deep);
    }

    /// <summary>
    /// <para>Defines the ValueAxisScaling Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:valScaling.</para>
    /// </summary>
    public partial class ValueAxisScaling : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ValueAxisScaling class.
        /// </summary>
        public ValueAxisScaling() : base()
        {
        }

        /// <summary>
        /// <para>max, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: max</para>
        /// </summary>
        public StringValue Max
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>min, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: min</para>
        /// </summary>
        public StringValue Min
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>majorUnit, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: majorUnit</para>
        /// </summary>
        public StringValue MajorUnit
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>minorUnit, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: minorUnit</para>
        /// </summary>
        public StringValue MinorUnit
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "valScaling");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ValueAxisScaling>()
.AddAttribute(0, "max", a => a.Max, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<DoubleValue>(NumberValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
})
.AddAttribute(0, "min", a => a.Min, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<DoubleValue>(NumberValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
})
.AddAttribute(0, "majorUnit", a => a.MajorUnit, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<DoubleValue>(new NumberValidator() { MinExclusive = (0L) });
union.AddValidator(StringValidator.Instance);
});
})
.AddAttribute(0, "minorUnit", a => a.MinorUnit, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<DoubleValue>(new NumberValidator() { MinExclusive = (0L) });
union.AddValidator(StringValidator.Instance);
});
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValueAxisScaling>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisTitle Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:title.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Text &lt;cx:tx></description></item>
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>TxPrTextBody &lt;cx:txPr></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class AxisTitle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AxisTitle class.
        /// </summary>
        public AxisTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisTitle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisTitle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisTitle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AxisTitle(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "title");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<Text>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<TxPrTextBody>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>Text.</para>
        /// <para>Represents the following element tag in the schema: cx:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public Text Text
        {
            get => GetElement<Text>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public TxPrTextBody TxPrTextBody
        {
            get => GetElement<TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisUnits Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:units.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AxisUnitsLabel &lt;cx:unitsLabel></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class AxisUnits : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AxisUnits class.
        /// </summary>
        public AxisUnits() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisUnits class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisUnits(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisUnits class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisUnits(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisUnits class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AxisUnits(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>unit, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: unit</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit> Unit
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "units");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<AxisUnitsLabel>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<AxisUnits>()
.AddAttribute(0, "unit", a => a.Unit);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>AxisUnitsLabel.</para>
        /// <para>Represents the following element tag in the schema: cx:unitsLabel.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public AxisUnitsLabel AxisUnitsLabel
        {
            get => GetElement<AxisUnitsLabel>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisUnits>(deep);
    }

    /// <summary>
    /// <para>Defines the MajorGridlinesGridlines Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:majorGridlines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class MajorGridlinesGridlines : OpenXmlGridlinesElement
    {
        /// <summary>
        /// Initializes a new instance of the MajorGridlinesGridlines class.
        /// </summary>
        public MajorGridlinesGridlines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MajorGridlinesGridlines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MajorGridlinesGridlines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MajorGridlinesGridlines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MajorGridlinesGridlines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MajorGridlinesGridlines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MajorGridlinesGridlines(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "majorGridlines");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorGridlinesGridlines>(deep);
    }

    /// <summary>
    /// <para>Defines the MinorGridlinesGridlines Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:minorGridlines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class MinorGridlinesGridlines : OpenXmlGridlinesElement
    {
        /// <summary>
        /// Initializes a new instance of the MinorGridlinesGridlines class.
        /// </summary>
        public MinorGridlinesGridlines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MinorGridlinesGridlines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MinorGridlinesGridlines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MinorGridlinesGridlines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MinorGridlinesGridlines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MinorGridlinesGridlines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MinorGridlinesGridlines(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "minorGridlines");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorGridlinesGridlines>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlGridlinesElement Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public abstract partial class OpenXmlGridlinesElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlGridlinesElement class.
        /// </summary>
        protected OpenXmlGridlinesElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlGridlinesElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlGridlinesElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlGridlinesElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlGridlinesElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlGridlinesElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OpenXmlGridlinesElement(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<ShapeProperties>();
            builder.AddChild<ExtensionList>();
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the MajorTickMarksTickMarks Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:majorTickMarks.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class MajorTickMarksTickMarks : OpenXmlTickMarksElement
    {
        /// <summary>
        /// Initializes a new instance of the MajorTickMarksTickMarks class.
        /// </summary>
        public MajorTickMarksTickMarks() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MajorTickMarksTickMarks class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MajorTickMarksTickMarks(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MajorTickMarksTickMarks class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MajorTickMarksTickMarks(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MajorTickMarksTickMarks class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MajorTickMarksTickMarks(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "majorTickMarks");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorTickMarksTickMarks>(deep);
    }

    /// <summary>
    /// <para>Defines the MinorTickMarksTickMarks Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:minorTickMarks.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class MinorTickMarksTickMarks : OpenXmlTickMarksElement
    {
        /// <summary>
        /// Initializes a new instance of the MinorTickMarksTickMarks class.
        /// </summary>
        public MinorTickMarksTickMarks() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MinorTickMarksTickMarks class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MinorTickMarksTickMarks(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MinorTickMarksTickMarks class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MinorTickMarksTickMarks(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MinorTickMarksTickMarks class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MinorTickMarksTickMarks(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "minorTickMarks");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorTickMarksTickMarks>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlTickMarksElement Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public abstract partial class OpenXmlTickMarksElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlTickMarksElement class.
        /// </summary>
        protected OpenXmlTickMarksElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlTickMarksElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlTickMarksElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlTickMarksElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlTickMarksElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlTickMarksElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OpenXmlTickMarksElement(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>type, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<ExtensionList>();
            builder.AddElement<OpenXmlTickMarksElement>()
.AddAttribute(0, "type", a => a.Type);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the TickLabels Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:tickLabels.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class TickLabels : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TickLabels class.
        /// </summary>
        public TickLabels() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TickLabels class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TickLabels(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TickLabels class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TickLabels(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TickLabels class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TickLabels(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "tickLabels");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TickLabels>(deep);
    }

    /// <summary>
    /// <para>Defines the NumberFormat Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:numFmt.</para>
    /// </summary>
    public partial class NumberFormat : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberFormat class.
        /// </summary>
        public NumberFormat() : base()
        {
        }

        /// <summary>
        /// <para>formatCode, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: formatCode</para>
        /// </summary>
        public StringValue FormatCode
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sourceLinked, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sourceLinked</para>
        /// </summary>
        public BooleanValue SourceLinked
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "numFmt");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<NumberFormat>()
.AddAttribute(0, "formatCode", a => a.FormatCode, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "sourceLinked", a => a.SourceLinked);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the Xsddouble Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:binSize.</para>
    /// </summary>
    public partial class Xsddouble : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Xsddouble class.
        /// </summary>
        public Xsddouble() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Xsddouble class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Xsddouble(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new DoubleValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<DoubleValue>(NumberValidator.Instance);
            builder.SetSchema(80, "binSize");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Xsddouble>(deep);
    }

    /// <summary>
    /// <para>Defines the ParentLabelLayout Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:parentLabelLayout.</para>
    /// </summary>
    public partial class ParentLabelLayout : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ParentLabelLayout class.
        /// </summary>
        public ParentLabelLayout() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal> ParentLabelLayoutVal
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "parentLabelLayout");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ParentLabelLayout>()
.AddAttribute(0, "val", a => a.ParentLabelLayoutVal, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ParentLabelLayout>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesElementVisibilities Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:visibility.</para>
    /// </summary>
    public partial class SeriesElementVisibilities : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SeriesElementVisibilities class.
        /// </summary>
        public SeriesElementVisibilities() : base()
        {
        }

        /// <summary>
        /// <para>connectorLines, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: connectorLines</para>
        /// </summary>
        public BooleanValue ConnectorLines
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>meanLine, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: meanLine</para>
        /// </summary>
        public BooleanValue MeanLine
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>meanMarker, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: meanMarker</para>
        /// </summary>
        public BooleanValue MeanMarker
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>nonoutliers, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: nonoutliers</para>
        /// </summary>
        public BooleanValue Nonoutliers
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>outliers, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: outliers</para>
        /// </summary>
        public BooleanValue Outliers
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "visibility");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<SeriesElementVisibilities>()
.AddAttribute(0, "connectorLines", a => a.ConnectorLines)
.AddAttribute(0, "meanLine", a => a.MeanLine)
.AddAttribute(0, "meanMarker", a => a.MeanMarker)
.AddAttribute(0, "nonoutliers", a => a.Nonoutliers)
.AddAttribute(0, "outliers", a => a.Outliers);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesElementVisibilities>(deep);
    }

    /// <summary>
    /// <para>Defines the Aggregation Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:aggregation.</para>
    /// </summary>
    public partial class Aggregation : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Aggregation class.
        /// </summary>
        public Aggregation() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "aggregation");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Aggregation>(deep);
    }

    /// <summary>
    /// <para>Defines the Binning Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:binning.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Xsddouble &lt;cx:binSize></description></item>
    ///   <item><description>BinCountXsdunsignedInt &lt;cx:binCount></description></item>
    /// </list>
    /// </remark>
    public partial class Binning : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Binning class.
        /// </summary>
        public Binning() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Binning class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Binning(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Binning class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Binning(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Binning class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Binning(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>intervalClosed, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: intervalClosed</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide> IntervalClosed
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>underflow, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: underflow</para>
        /// </summary>
        public StringValue Underflow
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>overflow, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: overflow</para>
        /// </summary>
        public StringValue Overflow
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "binning");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<Xsddouble>();
            builder.AddChild<BinCountXsdunsignedInt>();
            builder.AddElement<Binning>()
.AddAttribute(0, "intervalClosed", a => a.IntervalClosed)
.AddAttribute(0, "underflow", a => a.Underflow, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<DoubleValue>(NumberValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
})
.AddAttribute(0, "overflow", a => a.Overflow, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<DoubleValue>(NumberValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt), 1, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>Xsddouble.</para>
        /// <para>Represents the following element tag in the schema: cx:binSize.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public Xsddouble Xsddouble
        {
            get => GetElement<Xsddouble>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BinCountXsdunsignedInt.</para>
        /// <para>Represents the following element tag in the schema: cx:binCount.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public BinCountXsdunsignedInt BinCountXsdunsignedInt
        {
            get => GetElement<BinCountXsdunsignedInt>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Binning>(deep);
    }

    /// <summary>
    /// <para>Defines the Statistics Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:statistics.</para>
    /// </summary>
    public partial class Statistics : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Statistics class.
        /// </summary>
        public Statistics() : base()
        {
        }

        /// <summary>
        /// <para>quartileMethod, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: quartileMethod</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod> QuartileMethod
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "statistics");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<Statistics>()
.AddAttribute(0, "quartileMethod", a => a.QuartileMethod);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Statistics>(deep);
    }

    /// <summary>
    /// <para>Defines the Subtotals Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:subtotals.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>UnsignedIntegerType &lt;cx:idx></description></item>
    /// </list>
    /// </remark>
    public partial class Subtotals : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Subtotals class.
        /// </summary>
        public Subtotals() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Subtotals class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Subtotals(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Subtotals class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Subtotals(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Subtotals class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Subtotals(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "subtotals");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<UnsignedIntegerType>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Subtotals>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelVisibilities Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:visibility.</para>
    /// </summary>
    public partial class DataLabelVisibilities : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelVisibilities class.
        /// </summary>
        public DataLabelVisibilities() : base()
        {
        }

        /// <summary>
        /// <para>seriesName, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: seriesName</para>
        /// </summary>
        public BooleanValue SeriesName
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>categoryName, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: categoryName</para>
        /// </summary>
        public BooleanValue CategoryName
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>value, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        public BooleanValue Value
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "visibility");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<DataLabelVisibilities>()
.AddAttribute(0, "seriesName", a => a.SeriesName)
.AddAttribute(0, "categoryName", a => a.CategoryName)
.AddAttribute(0, "value", a => a.Value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelVisibilities>(deep);
    }

    /// <summary>
    /// <para>Defines the SeparatorXsdstring Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:separator.</para>
    /// </summary>
    public partial class SeparatorXsdstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SeparatorXsdstring class.
        /// </summary>
        public SeparatorXsdstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeparatorXsdstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SeparatorXsdstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "separator");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeparatorXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the OddHeaderXsdstring Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:oddHeader.</para>
    /// </summary>
    public partial class OddHeaderXsdstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the OddHeaderXsdstring class.
        /// </summary>
        public OddHeaderXsdstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OddHeaderXsdstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public OddHeaderXsdstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "oddHeader");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OddHeaderXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the OddFooterXsdstring Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:oddFooter.</para>
    /// </summary>
    public partial class OddFooterXsdstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the OddFooterXsdstring class.
        /// </summary>
        public OddFooterXsdstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OddFooterXsdstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public OddFooterXsdstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "oddFooter");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OddFooterXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the EvenHeaderXsdstring Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:evenHeader.</para>
    /// </summary>
    public partial class EvenHeaderXsdstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EvenHeaderXsdstring class.
        /// </summary>
        public EvenHeaderXsdstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EvenHeaderXsdstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EvenHeaderXsdstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "evenHeader");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EvenHeaderXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the EvenFooterXsdstring Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:evenFooter.</para>
    /// </summary>
    public partial class EvenFooterXsdstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EvenFooterXsdstring class.
        /// </summary>
        public EvenFooterXsdstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EvenFooterXsdstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EvenFooterXsdstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "evenFooter");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EvenFooterXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the FirstHeaderXsdstring Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:firstHeader.</para>
    /// </summary>
    public partial class FirstHeaderXsdstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FirstHeaderXsdstring class.
        /// </summary>
        public FirstHeaderXsdstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FirstHeaderXsdstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FirstHeaderXsdstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "firstHeader");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstHeaderXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the FirstFooterXsdstring Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:firstFooter.</para>
    /// </summary>
    public partial class FirstFooterXsdstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FirstFooterXsdstring class.
        /// </summary>
        public FirstFooterXsdstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FirstFooterXsdstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FirstFooterXsdstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "firstFooter");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstFooterXsdstring>(deep);
    }

    /// <summary>
    /// <para>Cached text.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:v.</para>
    /// </summary>
    public partial class VXsdstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VXsdstring class.
        /// </summary>
        public VXsdstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VXsdstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VXsdstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "v");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabel Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:dataLabel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumberFormat &lt;cx:numFmt></description></item>
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>TxPrTextBody &lt;cx:txPr></description></item>
    ///   <item><description>DataLabelVisibilities &lt;cx:visibility></description></item>
    ///   <item><description>SeparatorXsdstring &lt;cx:separator></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DataLabel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabel class.
        /// </summary>
        public DataLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabel(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>idx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        public UInt32Value Idx
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pos, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: pos</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos> Pos
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "dataLabel");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<NumberFormat>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<TxPrTextBody>();
            builder.AddChild<DataLabelVisibilities>();
            builder.AddChild<SeparatorXsdstring>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<DataLabel>()
.AddAttribute(0, "idx", a => a.Idx, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "pos", a => a.Pos);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>NumberFormat.</para>
        /// <para>Represents the following element tag in the schema: cx:numFmt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public NumberFormat NumberFormat
        {
            get => GetElement<NumberFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public TxPrTextBody TxPrTextBody
        {
            get => GetElement<TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabelVisibilities.</para>
        /// <para>Represents the following element tag in the schema: cx:visibility.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DataLabelVisibilities DataLabelVisibilities
        {
            get => GetElement<DataLabelVisibilities>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SeparatorXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:separator.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public SeparatorXsdstring SeparatorXsdstring
        {
            get => GetElement<SeparatorXsdstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelHidden Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:dataLabelHidden.</para>
    /// </summary>
    public partial class DataLabelHidden : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelHidden class.
        /// </summary>
        public DataLabelHidden() : base()
        {
        }

        /// <summary>
        /// <para>idx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        public UInt32Value Idx
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "dataLabelHidden");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<DataLabelHidden>()
.AddAttribute(0, "idx", a => a.Idx, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelHidden>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPoint Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:dataPt.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DataPoint : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataPoint class.
        /// </summary>
        public DataPoint() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPoint(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPoint(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataPoint(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>idx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        public UInt32Value Idx
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "dataPt");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<ShapeProperties>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<DataPoint>()
.AddAttribute(0, "idx", a => a.Idx, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPoint>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabels Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:dataLabels.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumberFormat &lt;cx:numFmt></description></item>
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>TxPrTextBody &lt;cx:txPr></description></item>
    ///   <item><description>DataLabelVisibilities &lt;cx:visibility></description></item>
    ///   <item><description>SeparatorXsdstring &lt;cx:separator></description></item>
    ///   <item><description>DataLabel &lt;cx:dataLabel></description></item>
    ///   <item><description>DataLabelHidden &lt;cx:dataLabelHidden></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DataLabels : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabels class.
        /// </summary>
        public DataLabels() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabels class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabels(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabels class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabels(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabels class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabels(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>pos, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: pos</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos> Pos
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "dataLabels");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<NumberFormat>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<TxPrTextBody>();
            builder.AddChild<DataLabelVisibilities>();
            builder.AddChild<SeparatorXsdstring>();
            builder.AddChild<DataLabel>();
            builder.AddChild<DataLabelHidden>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<DataLabels>()
.AddAttribute(0, "pos", a => a.Pos);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>NumberFormat.</para>
        /// <para>Represents the following element tag in the schema: cx:numFmt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public NumberFormat NumberFormat
        {
            get => GetElement<NumberFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public TxPrTextBody TxPrTextBody
        {
            get => GetElement<TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabelVisibilities.</para>
        /// <para>Represents the following element tag in the schema: cx:visibility.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DataLabelVisibilities DataLabelVisibilities
        {
            get => GetElement<DataLabelVisibilities>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SeparatorXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:separator.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public SeparatorXsdstring SeparatorXsdstring
        {
            get => GetElement<SeparatorXsdstring>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabels>(deep);
    }

    /// <summary>
    /// <para>Defines the DataId Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:dataId.</para>
    /// </summary>
    public partial class DataId : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataId class.
        /// </summary>
        public DataId() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt32Value Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "dataId");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<DataId>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataId>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesLayoutProperties Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:layoutPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ParentLabelLayout &lt;cx:parentLabelLayout></description></item>
    ///   <item><description>SeriesElementVisibilities &lt;cx:visibility></description></item>
    ///   <item><description>Aggregation &lt;cx:aggregation></description></item>
    ///   <item><description>Binning &lt;cx:binning></description></item>
    ///   <item><description>Statistics &lt;cx:statistics></description></item>
    ///   <item><description>Subtotals &lt;cx:subtotals></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class SeriesLayoutProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SeriesLayoutProperties class.
        /// </summary>
        public SeriesLayoutProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesLayoutProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesLayoutProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesLayoutProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesLayoutProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesLayoutProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SeriesLayoutProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "layoutPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<ParentLabelLayout>();
            builder.AddChild<SeriesElementVisibilities>();
            builder.AddChild<Aggregation>();
            builder.AddChild<Binning>();
            builder.AddChild<Statistics>();
            builder.AddChild<Subtotals>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities), 0, 1, version: FileFormatVersions.Office2016),
                new CompositeParticle(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Aggregation), 0, 1, version: FileFormatVersions.Office2016),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning), 0, 1, version: FileFormatVersions.Office2016)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>ParentLabelLayout.</para>
        /// <para>Represents the following element tag in the schema: cx:parentLabelLayout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ParentLabelLayout ParentLabelLayout
        {
            get => GetElement<ParentLabelLayout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SeriesElementVisibilities.</para>
        /// <para>Represents the following element tag in the schema: cx:visibility.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public SeriesElementVisibilities SeriesElementVisibilities
        {
            get => GetElement<SeriesElementVisibilities>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesLayoutProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisId Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:axisId.</para>
    /// </summary>
    public partial class AxisId : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the AxisId class.
        /// </summary>
        public AxisId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisId class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public AxisId(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new UInt32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<UInt32Value>(NumberValidator.Instance);
            builder.SetSchema(80, "axisId");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisId>(deep);
    }

    /// <summary>
    /// <para>Defines the PlotSurface Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:plotSurface.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class PlotSurface : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PlotSurface class.
        /// </summary>
        public PlotSurface() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotSurface class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotSurface(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotSurface class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotSurface(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotSurface class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PlotSurface(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "plotSurface");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<ShapeProperties>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotSurface>(deep);
    }

    /// <summary>
    /// <para>Defines the Series Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:series.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Text &lt;cx:tx></description></item>
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>DataPoint &lt;cx:dataPt></description></item>
    ///   <item><description>DataLabels &lt;cx:dataLabels></description></item>
    ///   <item><description>DataId &lt;cx:dataId></description></item>
    ///   <item><description>SeriesLayoutProperties &lt;cx:layoutPr></description></item>
    ///   <item><description>AxisId &lt;cx:axisId></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Series : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Series class.
        /// </summary>
        public Series() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Series class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Series(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Series class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Series(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Series class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Series(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>layoutId, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: layoutId</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout> LayoutId
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        public BooleanValue Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ownerIdx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ownerIdx</para>
        /// </summary>
        public UInt32Value OwnerIdx
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uniqueId, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>
        public StringValue UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>formatIdx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: formatIdx</para>
        /// </summary>
        public UInt32Value FormatIdx
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "series");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<Text>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<DataPoint>();
            builder.AddChild<DataLabels>();
            builder.AddChild<DataId>();
            builder.AddChild<SeriesLayoutProperties>();
            builder.AddChild<AxisId>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<Series>()
.AddAttribute(0, "layoutId", a => a.LayoutId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "hidden", a => a.Hidden)
.AddAttribute(0, "ownerIdx", a => a.OwnerIdx)
.AddAttribute(0, "uniqueId", a => a.UniqueId)
.AddAttribute(0, "formatIdx", a => a.FormatIdx);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>Text.</para>
        /// <para>Represents the following element tag in the schema: cx:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public Text Text
        {
            get => GetElement<Text>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Series>(deep);
    }

    /// <summary>
    /// <para>Defines the PlotAreaRegion Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:plotAreaRegion.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PlotSurface &lt;cx:plotSurface></description></item>
    ///   <item><description>Series &lt;cx:series></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class PlotAreaRegion : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PlotAreaRegion class.
        /// </summary>
        public PlotAreaRegion() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotAreaRegion class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotAreaRegion(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotAreaRegion class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotAreaRegion(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotAreaRegion class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PlotAreaRegion(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "plotAreaRegion");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<PlotSurface>();
            builder.AddChild<Series>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>PlotSurface.</para>
        /// <para>Represents the following element tag in the schema: cx:plotSurface.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public PlotSurface PlotSurface
        {
            get => GetElement<PlotSurface>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotAreaRegion>(deep);
    }

    /// <summary>
    /// <para>Defines the Axis Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:axis.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CategoryAxisScaling &lt;cx:catScaling></description></item>
    ///   <item><description>ValueAxisScaling &lt;cx:valScaling></description></item>
    ///   <item><description>AxisTitle &lt;cx:title></description></item>
    ///   <item><description>AxisUnits &lt;cx:units></description></item>
    ///   <item><description>MajorGridlinesGridlines &lt;cx:majorGridlines></description></item>
    ///   <item><description>MinorGridlinesGridlines &lt;cx:minorGridlines></description></item>
    ///   <item><description>MajorTickMarksTickMarks &lt;cx:majorTickMarks></description></item>
    ///   <item><description>MinorTickMarksTickMarks &lt;cx:minorTickMarks></description></item>
    ///   <item><description>TickLabels &lt;cx:tickLabels></description></item>
    ///   <item><description>NumberFormat &lt;cx:numFmt></description></item>
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>TxPrTextBody &lt;cx:txPr></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Axis : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Axis class.
        /// </summary>
        public Axis() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Axis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Axis(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Axis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Axis(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Axis class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Axis(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public UInt32Value Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        public BooleanValue Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "axis");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<CategoryAxisScaling>();
            builder.AddChild<ValueAxisScaling>();
            builder.AddChild<AxisTitle>();
            builder.AddChild<AxisUnits>();
            builder.AddChild<MajorGridlinesGridlines>();
            builder.AddChild<MinorGridlinesGridlines>();
            builder.AddChild<MajorTickMarksTickMarks>();
            builder.AddChild<MinorTickMarksTickMarks>();
            builder.AddChild<TickLabels>();
            builder.AddChild<NumberFormat>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<TxPrTextBody>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<Axis>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "hidden", a => a.Hidden);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling), 1, 1, version: FileFormatVersions.Office2016),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling), 1, 1, version: FileFormatVersions.Office2016)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Axis>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartTitle Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:title.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Text &lt;cx:tx></description></item>
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>TxPrTextBody &lt;cx:txPr></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ChartTitle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartTitle class.
        /// </summary>
        public ChartTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartTitle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartTitle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartTitle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartTitle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>pos, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: pos</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos> Pos
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>align, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: align</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign> Align
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>overlay, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: overlay</para>
        /// </summary>
        public BooleanValue Overlay
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "title");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<Text>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<TxPrTextBody>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<ChartTitle>()
.AddAttribute(0, "pos", a => a.Pos)
.AddAttribute(0, "align", a => a.Align)
.AddAttribute(0, "overlay", a => a.Overlay);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>Text.</para>
        /// <para>Represents the following element tag in the schema: cx:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public Text Text
        {
            get => GetElement<Text>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public TxPrTextBody TxPrTextBody
        {
            get => GetElement<TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the PlotArea Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:plotArea.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PlotAreaRegion &lt;cx:plotAreaRegion></description></item>
    ///   <item><description>Axis &lt;cx:axis></description></item>
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class PlotArea : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PlotArea class.
        /// </summary>
        public PlotArea() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotArea(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotArea(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PlotArea(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "plotArea");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<PlotAreaRegion>();
            builder.AddChild<Axis>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>PlotAreaRegion.</para>
        /// <para>Represents the following element tag in the schema: cx:plotAreaRegion.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public PlotAreaRegion PlotAreaRegion
        {
            get => GetElement<PlotAreaRegion>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotArea>(deep);
    }

    /// <summary>
    /// <para>Defines the Legend Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:legend.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShapeProperties &lt;cx:spPr></description></item>
    ///   <item><description>TxPrTextBody &lt;cx:txPr></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Legend : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Legend class.
        /// </summary>
        public Legend() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Legend class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Legend(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Legend class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Legend(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Legend class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Legend(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>pos, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: pos</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos> Pos
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>align, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: align</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign> Align
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>overlay, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: overlay</para>
        /// </summary>
        public BooleanValue Overlay
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "legend");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<ShapeProperties>();
            builder.AddChild<TxPrTextBody>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<Legend>()
.AddAttribute(0, "pos", a => a.Pos)
.AddAttribute(0, "align", a => a.Align)
.AddAttribute(0, "overlay", a => a.Overlay);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public TxPrTextBody TxPrTextBody
        {
            get => GetElement<TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Legend>(deep);
    }

    /// <summary>
    /// <para>Defines the HeaderFooter Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:headerFooter.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OddHeaderXsdstring &lt;cx:oddHeader></description></item>
    ///   <item><description>OddFooterXsdstring &lt;cx:oddFooter></description></item>
    ///   <item><description>EvenHeaderXsdstring &lt;cx:evenHeader></description></item>
    ///   <item><description>EvenFooterXsdstring &lt;cx:evenFooter></description></item>
    ///   <item><description>FirstHeaderXsdstring &lt;cx:firstHeader></description></item>
    ///   <item><description>FirstFooterXsdstring &lt;cx:firstFooter></description></item>
    /// </list>
    /// </remark>
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
        /// <para>alignWithMargins, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: alignWithMargins</para>
        /// </summary>
        public BooleanValue AlignWithMargins
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>differentOddEven, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: differentOddEven</para>
        /// </summary>
        public BooleanValue DifferentOddEven
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>differentFirst, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: differentFirst</para>
        /// </summary>
        public BooleanValue DifferentFirst
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "headerFooter");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<OddHeaderXsdstring>();
            builder.AddChild<OddFooterXsdstring>();
            builder.AddChild<EvenHeaderXsdstring>();
            builder.AddChild<EvenFooterXsdstring>();
            builder.AddChild<FirstHeaderXsdstring>();
            builder.AddChild<FirstFooterXsdstring>();
            builder.AddElement<HeaderFooter>()
.AddAttribute(0, "alignWithMargins", a => a.AlignWithMargins)
.AddAttribute(0, "differentOddEven", a => a.DifferentOddEven)
.AddAttribute(0, "differentFirst", a => a.DifferentFirst);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddHeaderXsdstring), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddFooterXsdstring), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenHeaderXsdstring), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenFooterXsdstring), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstHeaderXsdstring), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstFooterXsdstring), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>OddHeaderXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:oddHeader.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public OddHeaderXsdstring OddHeaderXsdstring
        {
            get => GetElement<OddHeaderXsdstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OddFooterXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:oddFooter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public OddFooterXsdstring OddFooterXsdstring
        {
            get => GetElement<OddFooterXsdstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EvenHeaderXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:evenHeader.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public EvenHeaderXsdstring EvenHeaderXsdstring
        {
            get => GetElement<EvenHeaderXsdstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EvenFooterXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:evenFooter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public EvenFooterXsdstring EvenFooterXsdstring
        {
            get => GetElement<EvenFooterXsdstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FirstHeaderXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:firstHeader.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public FirstHeaderXsdstring FirstHeaderXsdstring
        {
            get => GetElement<FirstHeaderXsdstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FirstFooterXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:firstFooter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public FirstFooterXsdstring FirstFooterXsdstring
        {
            get => GetElement<FirstFooterXsdstring>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeaderFooter>(deep);
    }

    /// <summary>
    /// <para>Defines the PageMargins Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:pageMargins.</para>
    /// </summary>
    public partial class PageMargins : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PageMargins class.
        /// </summary>
        public PageMargins() : base()
        {
        }

        /// <summary>
        /// <para>l, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: l</para>
        /// </summary>
        public DoubleValue L
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        public DoubleValue R
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        public DoubleValue T
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>b, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>
        public DoubleValue B
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>header, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: header</para>
        /// </summary>
        public DoubleValue Header
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>footer, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: footer</para>
        /// </summary>
        public DoubleValue Footer
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "pageMargins");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<PageMargins>()
.AddAttribute(0, "l", a => a.L, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "r", a => a.R, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "t", a => a.T, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "b", a => a.B, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "header", a => a.Header, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "footer", a => a.Footer, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PageMargins>(deep);
    }

    /// <summary>
    /// <para>Defines the PageSetup Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:pageSetup.</para>
    /// </summary>
    public partial class PageSetup : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PageSetup class.
        /// </summary>
        public PageSetup() : base()
        {
        }

        /// <summary>
        /// <para>paperSize, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: paperSize</para>
        /// </summary>
        public UInt32Value PaperSize
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>firstPageNumber, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: firstPageNumber</para>
        /// </summary>
        public UInt32Value FirstPageNumber
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>orientation, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: orientation</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation> Orientation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>blackAndWhite, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: blackAndWhite</para>
        /// </summary>
        public BooleanValue BlackAndWhite
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>draft, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: draft</para>
        /// </summary>
        public BooleanValue Draft
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>useFirstPageNumber, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: useFirstPageNumber</para>
        /// </summary>
        public BooleanValue UseFirstPageNumber
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>horizontalDpi, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: horizontalDpi</para>
        /// </summary>
        public Int32Value HorizontalDpi
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>verticalDpi, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: verticalDpi</para>
        /// </summary>
        public Int32Value VerticalDpi
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>copies, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: copies</para>
        /// </summary>
        public UInt32Value Copies
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "pageSetup");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<PageSetup>()
.AddAttribute(0, "paperSize", a => a.PaperSize)
.AddAttribute(0, "firstPageNumber", a => a.FirstPageNumber)
.AddAttribute(0, "orientation", a => a.Orientation)
.AddAttribute(0, "blackAndWhite", a => a.BlackAndWhite)
.AddAttribute(0, "draft", a => a.Draft)
.AddAttribute(0, "useFirstPageNumber", a => a.UseFirstPageNumber)
.AddAttribute(0, "horizontalDpi", a => a.HorizontalDpi)
.AddAttribute(0, "verticalDpi", a => a.VerticalDpi)
.AddAttribute(0, "copies", a => a.Copies);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PageSetup>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartData Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:chartData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExternalData &lt;cx:externalData></description></item>
    ///   <item><description>Data &lt;cx:data></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ChartData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartData class.
        /// </summary>
        public ChartData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "chartData");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<ExternalData>();
            builder.AddChild<Data>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data), 1, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>ExternalData.</para>
        /// <para>Represents the following element tag in the schema: cx:externalData.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExternalData ExternalData
        {
            get => GetElement<ExternalData>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartData>(deep);
    }

    /// <summary>
    /// <para>Defines the Chart Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:chart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartTitle &lt;cx:title></description></item>
    ///   <item><description>PlotArea &lt;cx:plotArea></description></item>
    ///   <item><description>Legend &lt;cx:legend></description></item>
    ///   <item><description>ExtensionList &lt;cx:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Chart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Chart class.
        /// </summary>
        public Chart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Chart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Chart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Chart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Chart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Chart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Chart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "chart");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<ChartTitle>();
            builder.AddChild<PlotArea>();
            builder.AddChild<Legend>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>ChartTitle.</para>
        /// <para>Represents the following element tag in the schema: cx:title.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ChartTitle ChartTitle
        {
            get => GetElement<ChartTitle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PlotArea.</para>
        /// <para>Represents the following element tag in the schema: cx:plotArea.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public PlotArea PlotArea
        {
            get => GetElement<PlotArea>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Legend.</para>
        /// <para>Represents the following element tag in the schema: cx:legend.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public Legend Legend
        {
            get => GetElement<Legend>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Chart>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorMappingType Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:clrMapOvr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ColorMappingType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorMappingType class.
        /// </summary>
        public ColorMappingType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMappingType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorMappingType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMappingType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorMappingType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMappingType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorMappingType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Background 1</para>
        /// <para>Represents the following attribute in the schema: bg1</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Background1
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text 1</para>
        /// <para>Represents the following attribute in the schema: tx1</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Text1
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Background 2</para>
        /// <para>Represents the following attribute in the schema: bg2</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Background2
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text 2</para>
        /// <para>Represents the following attribute in the schema: tx2</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Text2
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 1</para>
        /// <para>Represents the following attribute in the schema: accent1</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent1
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 2</para>
        /// <para>Represents the following attribute in the schema: accent2</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent2
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 3</para>
        /// <para>Represents the following attribute in the schema: accent3</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent3
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 4</para>
        /// <para>Represents the following attribute in the schema: accent4</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent4
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 5</para>
        /// <para>Represents the following attribute in the schema: accent5</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent5
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 6</para>
        /// <para>Represents the following attribute in the schema: accent6</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent6
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink</para>
        /// <para>Represents the following attribute in the schema: hlink</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Hyperlink
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Followed Hyperlink</para>
        /// <para>Represents the following attribute in the schema: folHlink</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> FollowedHyperlink
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "clrMapOvr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<ColorMappingType>()
.AddAttribute(0, "bg1", a => a.Background1, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "tx1", a => a.Text1, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "bg2", a => a.Background2, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "tx2", a => a.Text2, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "accent1", a => a.Accent1, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "accent2", a => a.Accent2, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "accent3", a => a.Accent3, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "accent4", a => a.Accent4, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "accent5", a => a.Accent5, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "accent6", a => a.Accent6, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "hlink", a => a.Hyperlink, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "folHlink", a => a.FollowedHyperlink, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorMappingType>(deep);
    }

    /// <summary>
    /// <para>Defines the PrintSettings Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:printSettings.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>HeaderFooter &lt;cx:headerFooter></description></item>
    ///   <item><description>PageMargins &lt;cx:pageMargins></description></item>
    ///   <item><description>PageSetup &lt;cx:pageSetup></description></item>
    /// </list>
    /// </remark>
    public partial class PrintSettings : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PrintSettings class.
        /// </summary>
        public PrintSettings() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrintSettings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PrintSettings(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrintSettings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PrintSettings(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrintSettings class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PrintSettings(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "printSettings");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<HeaderFooter>();
            builder.AddChild<PageMargins>();
            builder.AddChild<PageSetup>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>HeaderFooter.</para>
        /// <para>Represents the following element tag in the schema: cx:headerFooter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public HeaderFooter HeaderFooter
        {
            get => GetElement<HeaderFooter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PageMargins.</para>
        /// <para>Represents the following element tag in the schema: cx:pageMargins.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public PageMargins PageMargins
        {
            get => GetElement<PageMargins>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PageSetup.</para>
        /// <para>Represents the following element tag in the schema: cx:pageSetup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public PageSetup PageSetup
        {
            get => GetElement<PageSetup>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrintSettings>(deep);
    }

    /// <summary>
    /// <para>Data reference.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:f.</para>
    /// </summary>
    public partial class Formula : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Formula class.
        /// </summary>
        public Formula() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Formula class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Formula(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>dir, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection> Dir
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "f");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<Formula>()
.AddAttribute(0, "dir", a => a.Dir);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);
    }

    /// <summary>
    /// <para>Optional cached data.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:lvl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartStringValue &lt;cx:pt></description></item>
    /// </list>
    /// </remark>
    public partial class StringLevel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StringLevel class.
        /// </summary>
        public StringLevel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringLevel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringLevel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringLevel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringLevel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringLevel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StringLevel(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ptCount, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ptCount</para>
        /// </summary>
        public UInt32Value PtCount
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "lvl");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<ChartStringValue>();
            builder.AddElement<StringLevel>()
.AddAttribute(0, "ptCount", a => a.PtCount, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringLevel>(deep);
    }

    /// <summary>
    /// <para>Optional cached data.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:lvl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumericValue &lt;cx:pt></description></item>
    /// </list>
    /// </remark>
    public partial class NumericLevel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NumericLevel class.
        /// </summary>
        public NumericLevel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumericLevel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumericLevel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumericLevel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumericLevel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumericLevel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NumericLevel(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ptCount, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ptCount</para>
        /// </summary>
        public UInt32Value PtCount
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>formatCode, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: formatCode</para>
        /// </summary>
        public StringValue FormatCode
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "lvl");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<NumericValue>();
            builder.AddElement<NumericLevel>()
.AddAttribute(0, "ptCount", a => a.PtCount, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "formatCode", a => a.FormatCode);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumericLevel>(deep);
    }

    /// <summary>
    /// <para>Index of subtotal data point.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:idx.</para>
    /// </summary>
    public partial class UnsignedIntegerType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsignedIntegerType class.
        /// </summary>
        public UnsignedIntegerType() : base()
        {
        }

        /// <summary>
        /// <para>Integer Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt32Value Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(80, "idx");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<UnsignedIntegerType>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsignedIntegerType>(deep);
    }

    /// <summary>
    /// Defines the FormulaDirection enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum FormulaDirection
    {
        ///<summary>
        ///col.
        ///<para>When the item is serialized out as xml, its value is "col".</para>
        ///</summary>
        [EnumString("col")]
        Col,
        ///<summary>
        ///row.
        ///<para>When the item is serialized out as xml, its value is "row".</para>
        ///</summary>
        [EnumString("row")]
        Row,
    }

    /// <summary>
    /// Defines the StringDimensionType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum StringDimensionType
    {
        ///<summary>
        ///cat.
        ///<para>When the item is serialized out as xml, its value is "cat".</para>
        ///</summary>
        [EnumString("cat")]
        Cat,
    }

    /// <summary>
    /// Defines the NumericDimensionType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum NumericDimensionType
    {
        ///<summary>
        ///val.
        ///<para>When the item is serialized out as xml, its value is "val".</para>
        ///</summary>
        [EnumString("val")]
        Val,
        ///<summary>
        ///x.
        ///<para>When the item is serialized out as xml, its value is "x".</para>
        ///</summary>
        [EnumString("x")]
        X,
        ///<summary>
        ///y.
        ///<para>When the item is serialized out as xml, its value is "y".</para>
        ///</summary>
        [EnumString("y")]
        Y,
        ///<summary>
        ///size.
        ///<para>When the item is serialized out as xml, its value is "size".</para>
        ///</summary>
        [EnumString("size")]
        Size,
    }

    /// <summary>
    /// Defines the SidePos enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum SidePos
    {
        ///<summary>
        ///l.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        L,
        ///<summary>
        ///t.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        T,
        ///<summary>
        ///r.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        R,
        ///<summary>
        ///b.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        B,
    }

    /// <summary>
    /// Defines the PosAlign enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum PosAlign
    {
        ///<summary>
        ///min.
        ///<para>When the item is serialized out as xml, its value is "min".</para>
        ///</summary>
        [EnumString("min")]
        Min,
        ///<summary>
        ///ctr.
        ///<para>When the item is serialized out as xml, its value is "ctr".</para>
        ///</summary>
        [EnumString("ctr")]
        Ctr,
        ///<summary>
        ///max.
        ///<para>When the item is serialized out as xml, its value is "max".</para>
        ///</summary>
        [EnumString("max")]
        Max,
    }

    /// <summary>
    /// Defines the AxisUnit enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum AxisUnit
    {
        ///<summary>
        ///hundreds.
        ///<para>When the item is serialized out as xml, its value is "hundreds".</para>
        ///</summary>
        [EnumString("hundreds")]
        Hundreds,
        ///<summary>
        ///thousands.
        ///<para>When the item is serialized out as xml, its value is "thousands".</para>
        ///</summary>
        [EnumString("thousands")]
        Thousands,
        ///<summary>
        ///tenThousands.
        ///<para>When the item is serialized out as xml, its value is "tenThousands".</para>
        ///</summary>
        [EnumString("tenThousands")]
        TenThousands,
        ///<summary>
        ///hundredThousands.
        ///<para>When the item is serialized out as xml, its value is "hundredThousands".</para>
        ///</summary>
        [EnumString("hundredThousands")]
        HundredThousands,
        ///<summary>
        ///millions.
        ///<para>When the item is serialized out as xml, its value is "millions".</para>
        ///</summary>
        [EnumString("millions")]
        Millions,
        ///<summary>
        ///tenMillions.
        ///<para>When the item is serialized out as xml, its value is "tenMillions".</para>
        ///</summary>
        [EnumString("tenMillions")]
        TenMillions,
        ///<summary>
        ///hundredMillions.
        ///<para>When the item is serialized out as xml, its value is "hundredMillions".</para>
        ///</summary>
        [EnumString("hundredMillions")]
        HundredMillions,
        ///<summary>
        ///billions.
        ///<para>When the item is serialized out as xml, its value is "billions".</para>
        ///</summary>
        [EnumString("billions")]
        Billions,
        ///<summary>
        ///trillions.
        ///<para>When the item is serialized out as xml, its value is "trillions".</para>
        ///</summary>
        [EnumString("trillions")]
        Trillions,
        ///<summary>
        ///percentage.
        ///<para>When the item is serialized out as xml, its value is "percentage".</para>
        ///</summary>
        [EnumString("percentage")]
        Percentage,
    }

    /// <summary>
    /// Defines the TickMarksType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum TickMarksType
    {
        ///<summary>
        ///in.
        ///<para>When the item is serialized out as xml, its value is "in".</para>
        ///</summary>
        [EnumString("in")]
        In,
        ///<summary>
        ///out.
        ///<para>When the item is serialized out as xml, its value is "out".</para>
        ///</summary>
        [EnumString("out")]
        Out,
        ///<summary>
        ///cross.
        ///<para>When the item is serialized out as xml, its value is "cross".</para>
        ///</summary>
        [EnumString("cross")]
        Cross,
        ///<summary>
        ///none.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
    }

    /// <summary>
    /// Defines the SeriesLayout enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum SeriesLayout
    {
        ///<summary>
        ///boxWhisker.
        ///<para>When the item is serialized out as xml, its value is "boxWhisker".</para>
        ///</summary>
        [EnumString("boxWhisker")]
        BoxWhisker,
        ///<summary>
        ///clusteredColumn.
        ///<para>When the item is serialized out as xml, its value is "clusteredColumn".</para>
        ///</summary>
        [EnumString("clusteredColumn")]
        ClusteredColumn,
        ///<summary>
        ///paretoLine.
        ///<para>When the item is serialized out as xml, its value is "paretoLine".</para>
        ///</summary>
        [EnumString("paretoLine")]
        ParetoLine,
        ///<summary>
        ///sunburst.
        ///<para>When the item is serialized out as xml, its value is "sunburst".</para>
        ///</summary>
        [EnumString("sunburst")]
        Sunburst,
        ///<summary>
        ///treemap.
        ///<para>When the item is serialized out as xml, its value is "treemap".</para>
        ///</summary>
        [EnumString("treemap")]
        Treemap,
        ///<summary>
        ///waterfall.
        ///<para>When the item is serialized out as xml, its value is "waterfall".</para>
        ///</summary>
        [EnumString("waterfall")]
        Waterfall,
    }

    /// <summary>
    /// Defines the ParentLabelLayoutVal enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum ParentLabelLayoutVal
    {
        ///<summary>
        ///none.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///banner.
        ///<para>When the item is serialized out as xml, its value is "banner".</para>
        ///</summary>
        [EnumString("banner")]
        Banner,
        ///<summary>
        ///overlapping.
        ///<para>When the item is serialized out as xml, its value is "overlapping".</para>
        ///</summary>
        [EnumString("overlapping")]
        Overlapping,
    }

    /// <summary>
    /// Defines the IntervalClosedSide enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum IntervalClosedSide
    {
        ///<summary>
        ///l.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        L,
        ///<summary>
        ///r.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        R,
    }

    /// <summary>
    /// Defines the QuartileMethod enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum QuartileMethod
    {
        ///<summary>
        ///inclusive.
        ///<para>When the item is serialized out as xml, its value is "inclusive".</para>
        ///</summary>
        [EnumString("inclusive")]
        Inclusive,
        ///<summary>
        ///exclusive.
        ///<para>When the item is serialized out as xml, its value is "exclusive".</para>
        ///</summary>
        [EnumString("exclusive")]
        Exclusive,
    }

    /// <summary>
    /// Defines the DataLabelPos enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum DataLabelPos
    {
        ///<summary>
        ///bestFit.
        ///<para>When the item is serialized out as xml, its value is "bestFit".</para>
        ///</summary>
        [EnumString("bestFit")]
        BestFit,
        ///<summary>
        ///b.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        B,
        ///<summary>
        ///ctr.
        ///<para>When the item is serialized out as xml, its value is "ctr".</para>
        ///</summary>
        [EnumString("ctr")]
        Ctr,
        ///<summary>
        ///inBase.
        ///<para>When the item is serialized out as xml, its value is "inBase".</para>
        ///</summary>
        [EnumString("inBase")]
        InBase,
        ///<summary>
        ///inEnd.
        ///<para>When the item is serialized out as xml, its value is "inEnd".</para>
        ///</summary>
        [EnumString("inEnd")]
        InEnd,
        ///<summary>
        ///l.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        L,
        ///<summary>
        ///outEnd.
        ///<para>When the item is serialized out as xml, its value is "outEnd".</para>
        ///</summary>
        [EnumString("outEnd")]
        OutEnd,
        ///<summary>
        ///r.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        R,
        ///<summary>
        ///t.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        T,
    }

    /// <summary>
    /// Defines the PageOrientation enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum PageOrientation
    {
        ///<summary>
        ///default.
        ///<para>When the item is serialized out as xml, its value is "default".</para>
        ///</summary>
        [EnumString("default")]
        Default,
        ///<summary>
        ///portrait.
        ///<para>When the item is serialized out as xml, its value is "portrait".</para>
        ///</summary>
        [EnumString("portrait")]
        Portrait,
        ///<summary>
        ///landscape.
        ///<para>When the item is serialized out as xml, its value is "landscape".</para>
        ///</summary>
        [EnumString("landscape")]
        Landscape,
    }
}