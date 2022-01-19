// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

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
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:chartSpace.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType" /> <c>&lt;cx:clrMapOvr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody" /> <c>&lt;cx:txPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart" /> <c>&lt;cx:chart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData" /> <c>&lt;cx:chartData></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings" /> <c>&lt;cx:printSettings></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:chartSpace")]
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
            builder.SetSchema("cx:chartSpace");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData? ChartData
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart.</para>
        /// <para>Represents the following element tag in the schema: cx:chart.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart? Chart
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody? TxPrTextBody
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColorMappingType.</para>
        /// <para>Represents the following element tag in the schema: cx:clrMapOvr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType? ColorMappingType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PrintSettings.</para>
        /// <para>Represents the following element tag in the schema: cx:printSettings.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings? PrintSettings
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
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
        public ExtendedChartPart? ExtendedChartPart
        {
            get => OpenXmlPart as ExtendedChartPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the BinCountXsdunsignedInt Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:binCount.</para>
    /// </summary>
    [SchemaAttr("cx:binCount")]
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
            builder.SetSchema("cx:binCount");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BinCountXsdunsignedInt>(deep);
    }

    /// <summary>
    /// <para>Defines the Extension2 Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:ext.</para>
    /// </summary>
    [SchemaAttr("cx:ext")]
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
        /// <para>uri, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [SchemaAttr("uri")]
        public StringValue? Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:ext");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<Extension2>()
                .AddAttribute("uri", a => a.Uri, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extension2>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartStringValue Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:pt.</para>
    /// </summary>
    [SchemaAttr("cx:pt")]
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
        /// <para>idx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [SchemaAttr("idx")]
        public UInt32Value? Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:pt");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ChartStringValue>()
                .AddAttribute("idx", a => a.Index, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartStringValue>(deep);
    }

    /// <summary>
    /// <para>Defines the NumericValue Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:pt.</para>
    /// </summary>
    [SchemaAttr("cx:pt")]
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
        /// <para>idx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [SchemaAttr("idx")]
        public UInt32Value? Idx
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:pt");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<NumericValue>()
                .AddAttribute("idx", a => a.Idx, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumericValue>(deep);
    }

    /// <summary>
    /// <para>Defines the NumericDimension Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:numDim.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula" /> <c>&lt;cx:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel" /> <c>&lt;cx:lvl></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:numDim")]
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
        /// <para>Dimension data type, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:numDim");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>();
            builder.AddElement<NumericDimension>()
                .AddAttribute("type", a => a.Type, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:strDim.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula" /> <c>&lt;cx:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel" /> <c>&lt;cx:lvl></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:strDim")]
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
        /// <para>Dimension data type, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:strDim");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>();
            builder.AddElement<StringDimension>()
                .AddAttribute("type", a => a.Type, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2" /> <c>&lt;cx:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:extLst")]
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
            builder.SetSchema("cx:extLst");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ExternalData Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:externalData.</para>
    /// </summary>
    [SchemaAttr("cx:externalData")]
    public partial class ExternalData : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ExternalData class.
        /// </summary>
        public ExternalData() : base()
        {
        }

        /// <summary>
        /// <para>RelId of the relationship for the external data, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [SchemaAttr("r:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>True if the external link should automatically update, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: cx:autoUpdate</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx=http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        [SchemaAttr("cx:autoUpdate")]
        public BooleanValue? AutoUpdate
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:externalData");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ExternalData>()
                .AddAttribute("r:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("cx:autoUpdate", a => a.AutoUpdate, aBuilder =>
                {
                    aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2016));
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExternalData>(deep);
    }

    /// <summary>
    /// <para>Defines the Data Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:data.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension" /> <c>&lt;cx:numDim></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension" /> <c>&lt;cx:strDim></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:data")]
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
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:data");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension>();
            builder.AddElement<Data>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 0)
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
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:txData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula" /> <c>&lt;cx:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.VXsdstring" /> <c>&lt;cx:v></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:txData")]
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
            builder.SetSchema("cx:txData");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.VXsdstring>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:rich.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BodyProperties" /> <c>&lt;a:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ListStyle" /> <c>&lt;a:lstStyle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Paragraph" /> <c>&lt;a:p></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:rich")]
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
            builder.SetSchema("cx:rich");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:txPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BodyProperties" /> <c>&lt;a:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ListStyle" /> <c>&lt;a:lstStyle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Paragraph" /> <c>&lt;a:p></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:txPr")]
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
            builder.SetSchema("cx:txPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BodyProperties" /> <c>&lt;a:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ListStyle" /> <c>&lt;a:lstStyle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Paragraph" /> <c>&lt;a:p></c></description></item>
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
        public DocumentFormat.OpenXml.Drawing.BodyProperties? BodyProperties
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
        public DocumentFormat.OpenXml.Drawing.ListStyle? ListStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ListStyle>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the Text Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:tx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody" /> <c>&lt;cx:rich></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData" /> <c>&lt;cx:txData></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:tx")]
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
            builder.SetSchema("cx:tx");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData? TextData
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RichTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:rich.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody? RichTextBody
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RichTextBody>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Text>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.CustomGeometry" /> <c>&lt;a:custGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Outline" /> <c>&lt;a:ln></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetGeometry" /> <c>&lt;a:prstGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Shape3DType" /> <c>&lt;a:sp3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Transform2D" /> <c>&lt;a:xfrm></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:spPr")]
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
        [SchemaAttr("bwMode")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:spPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
            builder.AddElement<ShapeProperties>()
                .AddAttribute("bwMode", a => a.BlackWhiteMode, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
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
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
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
        public DocumentFormat.OpenXml.Drawing.Transform2D? Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisUnitsLabel Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:unitsLabel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody" /> <c>&lt;cx:txPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text" /> <c>&lt;cx:tx></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:unitsLabel")]
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
            builder.SetSchema("cx:unitsLabel");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text? Text
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody? TxPrTextBody
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisUnitsLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the CategoryAxisScaling Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:catScaling.</para>
    /// </summary>
    [SchemaAttr("cx:catScaling")]
    public partial class CategoryAxisScaling : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CategoryAxisScaling class.
        /// </summary>
        public CategoryAxisScaling() : base()
        {
        }

        /// <summary>
        /// <para>gapWidth, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: gapWidth</para>
        /// </summary>
        [SchemaAttr("gapWidth")]
        public StringValue? GapWidth
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:catScaling");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<CategoryAxisScaling>()
                .AddAttribute("gapWidth", a => a.GapWidth, aBuilder =>
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
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:valScaling.</para>
    /// </summary>
    [SchemaAttr("cx:valScaling")]
    public partial class ValueAxisScaling : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ValueAxisScaling class.
        /// </summary>
        public ValueAxisScaling() : base()
        {
        }

        /// <summary>
        /// <para>max, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: max</para>
        /// </summary>
        [SchemaAttr("max")]
        public StringValue? Max
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>min, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: min</para>
        /// </summary>
        [SchemaAttr("min")]
        public StringValue? Min
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>majorUnit, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: majorUnit</para>
        /// </summary>
        [SchemaAttr("majorUnit")]
        public StringValue? MajorUnit
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>minorUnit, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: minorUnit</para>
        /// </summary>
        [SchemaAttr("minorUnit")]
        public StringValue? MinorUnit
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:valScaling");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ValueAxisScaling>()
                .AddAttribute("max", a => a.Max, aBuilder =>
                {
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<DoubleValue>(NumberValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                })
                .AddAttribute("min", a => a.Min, aBuilder =>
                {
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<DoubleValue>(NumberValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                })
                .AddAttribute("majorUnit", a => a.MajorUnit, aBuilder =>
                {
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<DoubleValue>(new NumberValidator() { MinExclusive = (0L) });
                        union.AddValidator(StringValidator.Instance);
                    });
                })
                .AddAttribute("minorUnit", a => a.MinorUnit, aBuilder =>
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
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:title.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody" /> <c>&lt;cx:txPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text" /> <c>&lt;cx:tx></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:title")]
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
            builder.SetSchema("cx:title");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text? Text
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody? TxPrTextBody
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisUnits Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:units.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel" /> <c>&lt;cx:unitsLabel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:units")]
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
        /// <para>unit, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: unit</para>
        /// </summary>
        [SchemaAttr("unit")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit>? Unit
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:units");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddElement<AxisUnits>()
                .AddAttribute("unit", a => a.Unit);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel? AxisUnitsLabel
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisUnits>(deep);
    }

    /// <summary>
    /// <para>Defines the MajorGridlinesGridlines Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:majorGridlines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:majorGridlines")]
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
            builder.SetSchema("cx:majorGridlines");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:minorGridlines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:minorGridlines")]
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
            builder.SetSchema("cx:minorGridlines");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
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
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the MajorTickMarksTickMarks Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:majorTickMarks.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:majorTickMarks")]
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
            builder.SetSchema("cx:majorTickMarks");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorTickMarksTickMarks>(deep);
    }

    /// <summary>
    /// <para>Defines the MinorTickMarksTickMarks Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:minorTickMarks.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:minorTickMarks")]
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
            builder.SetSchema("cx:minorTickMarks");
            builder.Availability = FileFormatVersions.Office2016;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorTickMarksTickMarks>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlTickMarksElement Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
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
        /// <para>type, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddElement<OpenXmlTickMarksElement>()
                .AddAttribute("type", a => a.Type);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the TickLabels Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:tickLabels.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:tickLabels")]
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
            builder.SetSchema("cx:tickLabels");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TickLabels>(deep);
    }

    /// <summary>
    /// <para>Defines the NumberFormat Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:numFmt.</para>
    /// </summary>
    [SchemaAttr("cx:numFmt")]
    public partial class NumberFormat : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberFormat class.
        /// </summary>
        public NumberFormat() : base()
        {
        }

        /// <summary>
        /// <para>formatCode, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: formatCode</para>
        /// </summary>
        [SchemaAttr("formatCode")]
        public StringValue? FormatCode
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sourceLinked, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sourceLinked</para>
        /// </summary>
        [SchemaAttr("sourceLinked")]
        public BooleanValue? SourceLinked
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:numFmt");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<NumberFormat>()
                .AddAttribute("formatCode", a => a.FormatCode, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("sourceLinked", a => a.SourceLinked);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the Xsddouble Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:binSize.</para>
    /// </summary>
    [SchemaAttr("cx:binSize")]
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
            builder.SetSchema("cx:binSize");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Xsddouble>(deep);
    }

    /// <summary>
    /// <para>Defines the ParentLabelLayout Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:parentLabelLayout.</para>
    /// </summary>
    [SchemaAttr("cx:parentLabelLayout")]
    public partial class ParentLabelLayout : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ParentLabelLayout class.
        /// </summary>
        public ParentLabelLayout() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal>? ParentLabelLayoutVal
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:parentLabelLayout");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ParentLabelLayout>()
                .AddAttribute("val", a => a.ParentLabelLayoutVal, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ParentLabelLayout>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesElementVisibilities Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:visibility.</para>
    /// </summary>
    [SchemaAttr("cx:visibility")]
    public partial class SeriesElementVisibilities : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SeriesElementVisibilities class.
        /// </summary>
        public SeriesElementVisibilities() : base()
        {
        }

        /// <summary>
        /// <para>connectorLines, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: connectorLines</para>
        /// </summary>
        [SchemaAttr("connectorLines")]
        public BooleanValue? ConnectorLines
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>meanLine, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: meanLine</para>
        /// </summary>
        [SchemaAttr("meanLine")]
        public BooleanValue? MeanLine
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>meanMarker, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: meanMarker</para>
        /// </summary>
        [SchemaAttr("meanMarker")]
        public BooleanValue? MeanMarker
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>nonoutliers, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: nonoutliers</para>
        /// </summary>
        [SchemaAttr("nonoutliers")]
        public BooleanValue? Nonoutliers
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>outliers, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: outliers</para>
        /// </summary>
        [SchemaAttr("outliers")]
        public BooleanValue? Outliers
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:visibility");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<SeriesElementVisibilities>()
                .AddAttribute("connectorLines", a => a.ConnectorLines)
                .AddAttribute("meanLine", a => a.MeanLine)
                .AddAttribute("meanMarker", a => a.MeanMarker)
                .AddAttribute("nonoutliers", a => a.Nonoutliers)
                .AddAttribute("outliers", a => a.Outliers);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesElementVisibilities>(deep);
    }

    /// <summary>
    /// <para>Defines the Aggregation Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:aggregation.</para>
    /// </summary>
    [SchemaAttr("cx:aggregation")]
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
            builder.SetSchema("cx:aggregation");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Aggregation>(deep);
    }

    /// <summary>
    /// <para>Defines the Binning Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:binning.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble" /> <c>&lt;cx:binSize></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt" /> <c>&lt;cx:binCount></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:binning")]
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
        /// <para>intervalClosed, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: intervalClosed</para>
        /// </summary>
        [SchemaAttr("intervalClosed")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide>? IntervalClosed
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>underflow, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: underflow</para>
        /// </summary>
        [SchemaAttr("underflow")]
        public StringValue? Underflow
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>overflow, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: overflow</para>
        /// </summary>
        [SchemaAttr("overflow")]
        public StringValue? Overflow
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:binning");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt>();
            builder.AddElement<Binning>()
                .AddAttribute("intervalClosed", a => a.IntervalClosed)
                .AddAttribute("underflow", a => a.Underflow, aBuilder =>
                {
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<DoubleValue>(NumberValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                })
                .AddAttribute("overflow", a => a.Overflow, aBuilder =>
                {
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<DoubleValue>(NumberValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble? Xsddouble
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsddouble>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BinCountXsdunsignedInt.</para>
        /// <para>Represents the following element tag in the schema: cx:binCount.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt? BinCountXsdunsignedInt
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.BinCountXsdunsignedInt>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Binning>(deep);
    }

    /// <summary>
    /// <para>Defines the Statistics Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:statistics.</para>
    /// </summary>
    [SchemaAttr("cx:statistics")]
    public partial class Statistics : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Statistics class.
        /// </summary>
        public Statistics() : base()
        {
        }

        /// <summary>
        /// <para>quartileMethod, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: quartileMethod</para>
        /// </summary>
        [SchemaAttr("quartileMethod")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod>? QuartileMethod
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:statistics");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<Statistics>()
                .AddAttribute("quartileMethod", a => a.QuartileMethod);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Statistics>(deep);
    }

    /// <summary>
    /// <para>Defines the Subtotals Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:subtotals.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType" /> <c>&lt;cx:idx></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:subtotals")]
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
            builder.SetSchema("cx:subtotals");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Subtotals>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelVisibilities Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:visibility.</para>
    /// </summary>
    [SchemaAttr("cx:visibility")]
    public partial class DataLabelVisibilities : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelVisibilities class.
        /// </summary>
        public DataLabelVisibilities() : base()
        {
        }

        /// <summary>
        /// <para>seriesName, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: seriesName</para>
        /// </summary>
        [SchemaAttr("seriesName")]
        public BooleanValue? SeriesName
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>categoryName, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: categoryName</para>
        /// </summary>
        [SchemaAttr("categoryName")]
        public BooleanValue? CategoryName
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>value, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        [SchemaAttr("value")]
        public BooleanValue? Value
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:visibility");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<DataLabelVisibilities>()
                .AddAttribute("seriesName", a => a.SeriesName)
                .AddAttribute("categoryName", a => a.CategoryName)
                .AddAttribute("value", a => a.Value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelVisibilities>(deep);
    }

    /// <summary>
    /// <para>Defines the SeparatorXsdstring Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:separator.</para>
    /// </summary>
    [SchemaAttr("cx:separator")]
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
            builder.SetSchema("cx:separator");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeparatorXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the OddHeaderXsdstring Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:oddHeader.</para>
    /// </summary>
    [SchemaAttr("cx:oddHeader")]
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
            builder.SetSchema("cx:oddHeader");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OddHeaderXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the OddFooterXsdstring Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:oddFooter.</para>
    /// </summary>
    [SchemaAttr("cx:oddFooter")]
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
            builder.SetSchema("cx:oddFooter");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OddFooterXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the EvenHeaderXsdstring Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:evenHeader.</para>
    /// </summary>
    [SchemaAttr("cx:evenHeader")]
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
            builder.SetSchema("cx:evenHeader");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EvenHeaderXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the EvenFooterXsdstring Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:evenFooter.</para>
    /// </summary>
    [SchemaAttr("cx:evenFooter")]
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
            builder.SetSchema("cx:evenFooter");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EvenFooterXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the FirstHeaderXsdstring Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:firstHeader.</para>
    /// </summary>
    [SchemaAttr("cx:firstHeader")]
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
            builder.SetSchema("cx:firstHeader");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstHeaderXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the FirstFooterXsdstring Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:firstFooter.</para>
    /// </summary>
    [SchemaAttr("cx:firstFooter")]
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
            builder.SetSchema("cx:firstFooter");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstFooterXsdstring>(deep);
    }

    /// <summary>
    /// <para>Cached text.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:v.</para>
    /// </summary>
    [SchemaAttr("cx:v")]
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
            builder.SetSchema("cx:v");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VXsdstring>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabel Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:dataLabel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody" /> <c>&lt;cx:txPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities" /> <c>&lt;cx:visibility></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat" /> <c>&lt;cx:numFmt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring" /> <c>&lt;cx:separator></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:dataLabel")]
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
        /// <para>idx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [SchemaAttr("idx")]
        public UInt32Value? Idx
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pos, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: pos</para>
        /// </summary>
        [SchemaAttr("pos")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos>? Pos
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:dataLabel");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring>();
            builder.AddElement<DataLabel>()
                .AddAttribute("idx", a => a.Idx, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("pos", a => a.Pos);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat? NumberFormat
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody? TxPrTextBody
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabelVisibilities.</para>
        /// <para>Represents the following element tag in the schema: cx:visibility.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities? DataLabelVisibilities
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SeparatorXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:separator.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring? SeparatorXsdstring
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelHidden Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:dataLabelHidden.</para>
    /// </summary>
    [SchemaAttr("cx:dataLabelHidden")]
    public partial class DataLabelHidden : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelHidden class.
        /// </summary>
        public DataLabelHidden() : base()
        {
        }

        /// <summary>
        /// <para>idx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [SchemaAttr("idx")]
        public UInt32Value? Idx
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:dataLabelHidden");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<DataLabelHidden>()
                .AddAttribute("idx", a => a.Idx, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelHidden>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPoint Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:dataPt.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:dataPt")]
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
        /// <para>idx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [SchemaAttr("idx")]
        public UInt32Value? Idx
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:dataPt");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddElement<DataPoint>()
                .AddAttribute("idx", a => a.Idx, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPoint>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabels Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:dataLabels.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody" /> <c>&lt;cx:txPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel" /> <c>&lt;cx:dataLabel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden" /> <c>&lt;cx:dataLabelHidden></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities" /> <c>&lt;cx:visibility></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat" /> <c>&lt;cx:numFmt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring" /> <c>&lt;cx:separator></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:dataLabels")]
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
        /// <para>pos, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: pos</para>
        /// </summary>
        [SchemaAttr("pos")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos>? Pos
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:dataLabels");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring>();
            builder.AddElement<DataLabels>()
                .AddAttribute("pos", a => a.Pos);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat? NumberFormat
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody? TxPrTextBody
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabelVisibilities.</para>
        /// <para>Represents the following element tag in the schema: cx:visibility.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities? DataLabelVisibilities
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SeparatorXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:separator.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring? SeparatorXsdstring
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabels>(deep);
    }

    /// <summary>
    /// <para>Defines the DataId Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:dataId.</para>
    /// </summary>
    [SchemaAttr("cx:dataId")]
    public partial class DataId : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataId class.
        /// </summary>
        public DataId() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public UInt32Value? Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:dataId");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<DataId>()
                .AddAttribute("val", a => a.Val, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataId>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesLayoutProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:layoutPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Aggregation" /> <c>&lt;cx:aggregation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning" /> <c>&lt;cx:binning></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout" /> <c>&lt;cx:parentLabelLayout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities" /> <c>&lt;cx:visibility></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics" /> <c>&lt;cx:statistics></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals" /> <c>&lt;cx:subtotals></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:layoutPr")]
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
            builder.SetSchema("cx:layoutPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Aggregation>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities), 0, 1, version: FileFormatVersions.Office2016),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout? ParentLabelLayout
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SeriesElementVisibilities.</para>
        /// <para>Represents the following element tag in the schema: cx:visibility.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities? SeriesElementVisibilities
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesLayoutProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisId Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:axisId.</para>
    /// </summary>
    [SchemaAttr("cx:axisId")]
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
            builder.SetSchema("cx:axisId");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisId>(deep);
    }

    /// <summary>
    /// <para>Defines the PlotSurface Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:plotSurface.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:plotSurface")]
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
            builder.SetSchema("cx:plotSurface");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotSurface>(deep);
    }

    /// <summary>
    /// <para>Defines the Series Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:series.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId" /> <c>&lt;cx:dataId></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels" /> <c>&lt;cx:dataLabels></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint" /> <c>&lt;cx:dataPt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties" /> <c>&lt;cx:layoutPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text" /> <c>&lt;cx:tx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId" /> <c>&lt;cx:axisId></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:series")]
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
        /// <para>layoutId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: layoutId</para>
        /// </summary>
        [SchemaAttr("layoutId")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout>? LayoutId
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        [SchemaAttr("hidden")]
        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ownerIdx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ownerIdx</para>
        /// </summary>
        [SchemaAttr("ownerIdx")]
        public UInt32Value? OwnerIdx
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uniqueId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>
        [SchemaAttr("uniqueId")]
        public StringValue? UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>formatIdx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: formatIdx</para>
        /// </summary>
        [SchemaAttr("formatIdx")]
        public UInt32Value? FormatIdx
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:series");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId>();
            builder.AddElement<Series>()
                .AddAttribute("layoutId", a => a.LayoutId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("hidden", a => a.Hidden)
                .AddAttribute("ownerIdx", a => a.OwnerIdx)
                .AddAttribute("uniqueId", a => a.UniqueId)
                .AddAttribute("formatIdx", a => a.FormatIdx);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text? Text
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Series>(deep);
    }

    /// <summary>
    /// <para>Defines the PlotAreaRegion Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:plotAreaRegion.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface" /> <c>&lt;cx:plotSurface></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series" /> <c>&lt;cx:series></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:plotAreaRegion")]
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
            builder.SetSchema("cx:plotAreaRegion");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface? PlotSurface
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotAreaRegion>(deep);
    }

    /// <summary>
    /// <para>Defines the Axis Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:axis.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody" /> <c>&lt;cx:txPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle" /> <c>&lt;cx:title></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits" /> <c>&lt;cx:units></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling" /> <c>&lt;cx:catScaling></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines" /> <c>&lt;cx:majorGridlines></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines" /> <c>&lt;cx:minorGridlines></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat" /> <c>&lt;cx:numFmt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels" /> <c>&lt;cx:tickLabels></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks" /> <c>&lt;cx:majorTickMarks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks" /> <c>&lt;cx:minorTickMarks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling" /> <c>&lt;cx:valScaling></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:axis")]
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
        /// <para>id, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        [SchemaAttr("hidden")]
        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:axis");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling>();
            builder.AddElement<Axis>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("hidden", a => a.Hidden);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
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
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:title.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody" /> <c>&lt;cx:txPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text" /> <c>&lt;cx:tx></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:title")]
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
        /// <para>pos, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: pos</para>
        /// </summary>
        [SchemaAttr("pos")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos>? Pos
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>align, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: align</para>
        /// </summary>
        [SchemaAttr("align")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign>? Align
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>overlay, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: overlay</para>
        /// </summary>
        [SchemaAttr("overlay")]
        public BooleanValue? Overlay
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:title");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
            builder.AddElement<ChartTitle>()
                .AddAttribute("pos", a => a.Pos)
                .AddAttribute("align", a => a.Align)
                .AddAttribute("overlay", a => a.Overlay);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text? Text
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cx:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody? TxPrTextBody
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the PlotArea Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:plotArea.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis" /> <c>&lt;cx:axis></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion" /> <c>&lt;cx:plotAreaRegion></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:plotArea")]
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
            builder.SetSchema("cx:plotArea");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Axis>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion? PlotAreaRegion
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotArea>(deep);
    }

    /// <summary>
    /// <para>Defines the Legend Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:legend.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cx:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody" /> <c>&lt;cx:txPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:legend")]
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
        /// <para>pos, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: pos</para>
        /// </summary>
        [SchemaAttr("pos")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos>? Pos
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>align, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: align</para>
        /// </summary>
        [SchemaAttr("align")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign>? Align
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>overlay, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: overlay</para>
        /// </summary>
        [SchemaAttr("overlay")]
        public BooleanValue? Overlay
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:legend");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddElement<Legend>()
                .AddAttribute("pos", a => a.Pos)
                .AddAttribute("align", a => a.Align)
                .AddAttribute("overlay", a => a.Overlay);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TxPrTextBody.</para>
        /// <para>Represents the following element tag in the schema: cx:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody? TxPrTextBody
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Legend>(deep);
    }

    /// <summary>
    /// <para>Defines the HeaderFooter Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:headerFooter.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddHeaderXsdstring" /> <c>&lt;cx:oddHeader></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddFooterXsdstring" /> <c>&lt;cx:oddFooter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenHeaderXsdstring" /> <c>&lt;cx:evenHeader></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenFooterXsdstring" /> <c>&lt;cx:evenFooter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstHeaderXsdstring" /> <c>&lt;cx:firstHeader></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstFooterXsdstring" /> <c>&lt;cx:firstFooter></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:headerFooter")]
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
        /// <para>alignWithMargins, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: alignWithMargins</para>
        /// </summary>
        [SchemaAttr("alignWithMargins")]
        public BooleanValue? AlignWithMargins
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>differentOddEven, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: differentOddEven</para>
        /// </summary>
        [SchemaAttr("differentOddEven")]
        public BooleanValue? DifferentOddEven
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>differentFirst, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: differentFirst</para>
        /// </summary>
        [SchemaAttr("differentFirst")]
        public BooleanValue? DifferentFirst
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:headerFooter");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddHeaderXsdstring>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddFooterXsdstring>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenHeaderXsdstring>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenFooterXsdstring>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstHeaderXsdstring>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstFooterXsdstring>();
            builder.AddElement<HeaderFooter>()
                .AddAttribute("alignWithMargins", a => a.AlignWithMargins)
                .AddAttribute("differentOddEven", a => a.DifferentOddEven)
                .AddAttribute("differentFirst", a => a.DifferentFirst);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddHeaderXsdstring? OddHeaderXsdstring
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddHeaderXsdstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OddFooterXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:oddFooter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddFooterXsdstring? OddFooterXsdstring
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OddFooterXsdstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EvenHeaderXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:evenHeader.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenHeaderXsdstring? EvenHeaderXsdstring
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenHeaderXsdstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EvenFooterXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:evenFooter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenFooterXsdstring? EvenFooterXsdstring
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EvenFooterXsdstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FirstHeaderXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:firstHeader.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstHeaderXsdstring? FirstHeaderXsdstring
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstHeaderXsdstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FirstFooterXsdstring.</para>
        /// <para>Represents the following element tag in the schema: cx:firstFooter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstFooterXsdstring? FirstFooterXsdstring
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FirstFooterXsdstring>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeaderFooter>(deep);
    }

    /// <summary>
    /// <para>Defines the PageMargins Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:pageMargins.</para>
    /// </summary>
    [SchemaAttr("cx:pageMargins")]
    public partial class PageMargins : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PageMargins class.
        /// </summary>
        public PageMargins() : base()
        {
        }

        /// <summary>
        /// <para>l, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: l</para>
        /// </summary>
        [SchemaAttr("l")]
        public DoubleValue? L
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        [SchemaAttr("r")]
        public DoubleValue? R
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        [SchemaAttr("t")]
        public DoubleValue? T
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>b, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>
        [SchemaAttr("b")]
        public DoubleValue? B
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>header, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: header</para>
        /// </summary>
        [SchemaAttr("header")]
        public DoubleValue? Header
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>footer, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: footer</para>
        /// </summary>
        [SchemaAttr("footer")]
        public DoubleValue? Footer
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:pageMargins");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<PageMargins>()
                .AddAttribute("l", a => a.L, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("r", a => a.R, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("t", a => a.T, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("b", a => a.B, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("header", a => a.Header, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("footer", a => a.Footer, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PageMargins>(deep);
    }

    /// <summary>
    /// <para>Defines the PageSetup Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:pageSetup.</para>
    /// </summary>
    [SchemaAttr("cx:pageSetup")]
    public partial class PageSetup : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PageSetup class.
        /// </summary>
        public PageSetup() : base()
        {
        }

        /// <summary>
        /// <para>paperSize, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: paperSize</para>
        /// </summary>
        [SchemaAttr("paperSize")]
        public UInt32Value? PaperSize
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>firstPageNumber, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: firstPageNumber</para>
        /// </summary>
        [SchemaAttr("firstPageNumber")]
        public UInt32Value? FirstPageNumber
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>orientation, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: orientation</para>
        /// </summary>
        [SchemaAttr("orientation")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation>? Orientation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>blackAndWhite, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: blackAndWhite</para>
        /// </summary>
        [SchemaAttr("blackAndWhite")]
        public BooleanValue? BlackAndWhite
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>draft, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: draft</para>
        /// </summary>
        [SchemaAttr("draft")]
        public BooleanValue? Draft
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>useFirstPageNumber, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: useFirstPageNumber</para>
        /// </summary>
        [SchemaAttr("useFirstPageNumber")]
        public BooleanValue? UseFirstPageNumber
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>horizontalDpi, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: horizontalDpi</para>
        /// </summary>
        [SchemaAttr("horizontalDpi")]
        public Int32Value? HorizontalDpi
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>verticalDpi, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: verticalDpi</para>
        /// </summary>
        [SchemaAttr("verticalDpi")]
        public Int32Value? VerticalDpi
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>copies, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: copies</para>
        /// </summary>
        [SchemaAttr("copies")]
        public UInt32Value? Copies
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:pageSetup");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<PageSetup>()
                .AddAttribute("paperSize", a => a.PaperSize)
                .AddAttribute("firstPageNumber", a => a.FirstPageNumber)
                .AddAttribute("orientation", a => a.Orientation)
                .AddAttribute("blackAndWhite", a => a.BlackAndWhite)
                .AddAttribute("draft", a => a.Draft)
                .AddAttribute("useFirstPageNumber", a => a.UseFirstPageNumber)
                .AddAttribute("horizontalDpi", a => a.HorizontalDpi)
                .AddAttribute("verticalDpi", a => a.VerticalDpi)
                .AddAttribute("copies", a => a.Copies);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PageSetup>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartData Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:chartData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data" /> <c>&lt;cx:data></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData" /> <c>&lt;cx:externalData></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:chartData")]
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
            builder.SetSchema("cx:chartData");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData? ExternalData
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartData>(deep);
    }

    /// <summary>
    /// <para>Defines the Chart Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:chart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle" /> <c>&lt;cx:title></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList" /> <c>&lt;cx:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend" /> <c>&lt;cx:legend></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea" /> <c>&lt;cx:plotArea></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:chart")]
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
            builder.SetSchema("cx:chart");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle? ChartTitle
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartTitle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PlotArea.</para>
        /// <para>Represents the following element tag in the schema: cx:plotArea.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea? PlotArea
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Legend.</para>
        /// <para>Represents the following element tag in the schema: cx:legend.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend? Legend
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cx:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Chart>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorMappingType Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:clrMapOvr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:clrMapOvr")]
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
        [SchemaAttr("bg1")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>? Background1
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text 1</para>
        /// <para>Represents the following attribute in the schema: tx1</para>
        /// </summary>
        [SchemaAttr("tx1")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>? Text1
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Background 2</para>
        /// <para>Represents the following attribute in the schema: bg2</para>
        /// </summary>
        [SchemaAttr("bg2")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>? Background2
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text 2</para>
        /// <para>Represents the following attribute in the schema: tx2</para>
        /// </summary>
        [SchemaAttr("tx2")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>? Text2
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 1</para>
        /// <para>Represents the following attribute in the schema: accent1</para>
        /// </summary>
        [SchemaAttr("accent1")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>? Accent1
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 2</para>
        /// <para>Represents the following attribute in the schema: accent2</para>
        /// </summary>
        [SchemaAttr("accent2")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>? Accent2
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 3</para>
        /// <para>Represents the following attribute in the schema: accent3</para>
        /// </summary>
        [SchemaAttr("accent3")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>? Accent3
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 4</para>
        /// <para>Represents the following attribute in the schema: accent4</para>
        /// </summary>
        [SchemaAttr("accent4")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>? Accent4
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 5</para>
        /// <para>Represents the following attribute in the schema: accent5</para>
        /// </summary>
        [SchemaAttr("accent5")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>? Accent5
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 6</para>
        /// <para>Represents the following attribute in the schema: accent6</para>
        /// </summary>
        [SchemaAttr("accent6")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>? Accent6
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink</para>
        /// <para>Represents the following attribute in the schema: hlink</para>
        /// </summary>
        [SchemaAttr("hlink")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>? Hyperlink
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Followed Hyperlink</para>
        /// <para>Represents the following attribute in the schema: folHlink</para>
        /// </summary>
        [SchemaAttr("folHlink")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>? FollowedHyperlink
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:clrMapOvr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<ColorMappingType>()
                .AddAttribute("bg1", a => a.Background1, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("tx1", a => a.Text1, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("bg2", a => a.Background2, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("tx2", a => a.Text2, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("accent1", a => a.Accent1, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("accent2", a => a.Accent2, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("accent3", a => a.Accent3, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("accent4", a => a.Accent4, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("accent5", a => a.Accent5, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("accent6", a => a.Accent6, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("hlink", a => a.Hyperlink, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("folHlink", a => a.FollowedHyperlink, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Drawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorMappingType>(deep);
    }

    /// <summary>
    /// <para>Defines the PrintSettings Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:printSettings.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter" /> <c>&lt;cx:headerFooter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins" /> <c>&lt;cx:pageMargins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup" /> <c>&lt;cx:pageSetup></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:printSettings")]
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
            builder.SetSchema("cx:printSettings");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter? HeaderFooter
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.HeaderFooter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PageMargins.</para>
        /// <para>Represents the following element tag in the schema: cx:pageMargins.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins? PageMargins
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageMargins>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PageSetup.</para>
        /// <para>Represents the following element tag in the schema: cx:pageSetup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? PageSetup
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrintSettings>(deep);
    }

    /// <summary>
    /// <para>Data reference.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:f.</para>
    /// </summary>
    [SchemaAttr("cx:f")]
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
        /// <para>dir, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [SchemaAttr("dir")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection>? Dir
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:f");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<Formula>()
                .AddAttribute("dir", a => a.Dir);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);
    }

    /// <summary>
    /// <para>Optional cached data.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:lvl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue" /> <c>&lt;cx:pt></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:lvl")]
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
        /// <para>ptCount, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ptCount</para>
        /// </summary>
        [SchemaAttr("ptCount")]
        public UInt32Value? PtCount
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:lvl");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue>();
            builder.AddElement<StringLevel>()
                .AddAttribute("ptCount", a => a.PtCount, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringLevel>(deep);
    }

    /// <summary>
    /// <para>Optional cached data.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:lvl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue" /> <c>&lt;cx:pt></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cx:lvl")]
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
        /// <para>ptCount, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ptCount</para>
        /// </summary>
        [SchemaAttr("ptCount")]
        public UInt32Value? PtCount
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>formatCode, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: formatCode</para>
        /// </summary>
        [SchemaAttr("formatCode")]
        public StringValue? FormatCode
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:lvl");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue>();
            builder.AddElement<NumericLevel>()
                .AddAttribute("ptCount", a => a.PtCount, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("formatCode", a => a.FormatCode);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumericLevel>(deep);
    }

    /// <summary>
    /// <para>Index of subtotal data point.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cx:idx.</para>
    /// </summary>
    [SchemaAttr("cx:idx")]
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
        [SchemaAttr("val")]
        public UInt32Value? Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cx:idx");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<UnsignedIntegerType>()
                .AddAttribute("val", a => a.Val, aBuilder =>
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
    public enum FormulaDirection
    {
        /// <summary>
        /// col.
        /// <para>When the item is serialized out as xml, its value is "col".</para>
        /// </summary>
        [EnumString("col")]
        Col,
        /// <summary>
        /// row.
        /// <para>When the item is serialized out as xml, its value is "row".</para>
        /// </summary>
        [EnumString("row")]
        Row
    }

    /// <summary>
    /// Defines the StringDimensionType enumeration.
    /// </summary>
    public enum StringDimensionType
    {
        /// <summary>
        /// cat.
        /// <para>When the item is serialized out as xml, its value is "cat".</para>
        /// </summary>
        [EnumString("cat")]
        Cat
    }

    /// <summary>
    /// Defines the NumericDimensionType enumeration.
    /// </summary>
    public enum NumericDimensionType
    {
        /// <summary>
        /// val.
        /// <para>When the item is serialized out as xml, its value is "val".</para>
        /// </summary>
        [EnumString("val")]
        Val,
        /// <summary>
        /// x.
        /// <para>When the item is serialized out as xml, its value is "x".</para>
        /// </summary>
        [EnumString("x")]
        X,
        /// <summary>
        /// y.
        /// <para>When the item is serialized out as xml, its value is "y".</para>
        /// </summary>
        [EnumString("y")]
        Y,
        /// <summary>
        /// size.
        /// <para>When the item is serialized out as xml, its value is "size".</para>
        /// </summary>
        [EnumString("size")]
        Size
    }

    /// <summary>
    /// Defines the SidePos enumeration.
    /// </summary>
    public enum SidePos
    {
        /// <summary>
        /// l.
        /// <para>When the item is serialized out as xml, its value is "l".</para>
        /// </summary>
        [EnumString("l")]
        L,
        /// <summary>
        /// t.
        /// <para>When the item is serialized out as xml, its value is "t".</para>
        /// </summary>
        [EnumString("t")]
        T,
        /// <summary>
        /// r.
        /// <para>When the item is serialized out as xml, its value is "r".</para>
        /// </summary>
        [EnumString("r")]
        R,
        /// <summary>
        /// b.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        B
    }

    /// <summary>
    /// Defines the PosAlign enumeration.
    /// </summary>
    public enum PosAlign
    {
        /// <summary>
        /// min.
        /// <para>When the item is serialized out as xml, its value is "min".</para>
        /// </summary>
        [EnumString("min")]
        Min,
        /// <summary>
        /// ctr.
        /// <para>When the item is serialized out as xml, its value is "ctr".</para>
        /// </summary>
        [EnumString("ctr")]
        Ctr,
        /// <summary>
        /// max.
        /// <para>When the item is serialized out as xml, its value is "max".</para>
        /// </summary>
        [EnumString("max")]
        Max
    }

    /// <summary>
    /// Defines the AxisUnit enumeration.
    /// </summary>
    public enum AxisUnit
    {
        /// <summary>
        /// hundreds.
        /// <para>When the item is serialized out as xml, its value is "hundreds".</para>
        /// </summary>
        [EnumString("hundreds")]
        Hundreds,
        /// <summary>
        /// thousands.
        /// <para>When the item is serialized out as xml, its value is "thousands".</para>
        /// </summary>
        [EnumString("thousands")]
        Thousands,
        /// <summary>
        /// tenThousands.
        /// <para>When the item is serialized out as xml, its value is "tenThousands".</para>
        /// </summary>
        [EnumString("tenThousands")]
        TenThousands,
        /// <summary>
        /// hundredThousands.
        /// <para>When the item is serialized out as xml, its value is "hundredThousands".</para>
        /// </summary>
        [EnumString("hundredThousands")]
        HundredThousands,
        /// <summary>
        /// millions.
        /// <para>When the item is serialized out as xml, its value is "millions".</para>
        /// </summary>
        [EnumString("millions")]
        Millions,
        /// <summary>
        /// tenMillions.
        /// <para>When the item is serialized out as xml, its value is "tenMillions".</para>
        /// </summary>
        [EnumString("tenMillions")]
        TenMillions,
        /// <summary>
        /// hundredMillions.
        /// <para>When the item is serialized out as xml, its value is "hundredMillions".</para>
        /// </summary>
        [EnumString("hundredMillions")]
        HundredMillions,
        /// <summary>
        /// billions.
        /// <para>When the item is serialized out as xml, its value is "billions".</para>
        /// </summary>
        [EnumString("billions")]
        Billions,
        /// <summary>
        /// trillions.
        /// <para>When the item is serialized out as xml, its value is "trillions".</para>
        /// </summary>
        [EnumString("trillions")]
        Trillions,
        /// <summary>
        /// percentage.
        /// <para>When the item is serialized out as xml, its value is "percentage".</para>
        /// </summary>
        [EnumString("percentage")]
        Percentage
    }

    /// <summary>
    /// Defines the TickMarksType enumeration.
    /// </summary>
    public enum TickMarksType
    {
        /// <summary>
        /// in.
        /// <para>When the item is serialized out as xml, its value is "in".</para>
        /// </summary>
        [EnumString("in")]
        In,
        /// <summary>
        /// out.
        /// <para>When the item is serialized out as xml, its value is "out".</para>
        /// </summary>
        [EnumString("out")]
        Out,
        /// <summary>
        /// cross.
        /// <para>When the item is serialized out as xml, its value is "cross".</para>
        /// </summary>
        [EnumString("cross")]
        Cross,
        /// <summary>
        /// none.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None
    }

    /// <summary>
    /// Defines the SeriesLayout enumeration.
    /// </summary>
    public enum SeriesLayout
    {
        /// <summary>
        /// boxWhisker.
        /// <para>When the item is serialized out as xml, its value is "boxWhisker".</para>
        /// </summary>
        [EnumString("boxWhisker")]
        BoxWhisker,
        /// <summary>
        /// clusteredColumn.
        /// <para>When the item is serialized out as xml, its value is "clusteredColumn".</para>
        /// </summary>
        [EnumString("clusteredColumn")]
        ClusteredColumn,
        /// <summary>
        /// paretoLine.
        /// <para>When the item is serialized out as xml, its value is "paretoLine".</para>
        /// </summary>
        [EnumString("paretoLine")]
        ParetoLine,
        /// <summary>
        /// sunburst.
        /// <para>When the item is serialized out as xml, its value is "sunburst".</para>
        /// </summary>
        [EnumString("sunburst")]
        Sunburst,
        /// <summary>
        /// treemap.
        /// <para>When the item is serialized out as xml, its value is "treemap".</para>
        /// </summary>
        [EnumString("treemap")]
        Treemap,
        /// <summary>
        /// waterfall.
        /// <para>When the item is serialized out as xml, its value is "waterfall".</para>
        /// </summary>
        [EnumString("waterfall")]
        Waterfall
    }

    /// <summary>
    /// Defines the ParentLabelLayoutVal enumeration.
    /// </summary>
    public enum ParentLabelLayoutVal
    {
        /// <summary>
        /// none.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// banner.
        /// <para>When the item is serialized out as xml, its value is "banner".</para>
        /// </summary>
        [EnumString("banner")]
        Banner,
        /// <summary>
        /// overlapping.
        /// <para>When the item is serialized out as xml, its value is "overlapping".</para>
        /// </summary>
        [EnumString("overlapping")]
        Overlapping
    }

    /// <summary>
    /// Defines the IntervalClosedSide enumeration.
    /// </summary>
    public enum IntervalClosedSide
    {
        /// <summary>
        /// l.
        /// <para>When the item is serialized out as xml, its value is "l".</para>
        /// </summary>
        [EnumString("l")]
        L,
        /// <summary>
        /// r.
        /// <para>When the item is serialized out as xml, its value is "r".</para>
        /// </summary>
        [EnumString("r")]
        R
    }

    /// <summary>
    /// Defines the QuartileMethod enumeration.
    /// </summary>
    public enum QuartileMethod
    {
        /// <summary>
        /// inclusive.
        /// <para>When the item is serialized out as xml, its value is "inclusive".</para>
        /// </summary>
        [EnumString("inclusive")]
        Inclusive,
        /// <summary>
        /// exclusive.
        /// <para>When the item is serialized out as xml, its value is "exclusive".</para>
        /// </summary>
        [EnumString("exclusive")]
        Exclusive
    }

    /// <summary>
    /// Defines the DataLabelPos enumeration.
    /// </summary>
    public enum DataLabelPos
    {
        /// <summary>
        /// bestFit.
        /// <para>When the item is serialized out as xml, its value is "bestFit".</para>
        /// </summary>
        [EnumString("bestFit")]
        BestFit,
        /// <summary>
        /// b.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        B,
        /// <summary>
        /// ctr.
        /// <para>When the item is serialized out as xml, its value is "ctr".</para>
        /// </summary>
        [EnumString("ctr")]
        Ctr,
        /// <summary>
        /// inBase.
        /// <para>When the item is serialized out as xml, its value is "inBase".</para>
        /// </summary>
        [EnumString("inBase")]
        InBase,
        /// <summary>
        /// inEnd.
        /// <para>When the item is serialized out as xml, its value is "inEnd".</para>
        /// </summary>
        [EnumString("inEnd")]
        InEnd,
        /// <summary>
        /// l.
        /// <para>When the item is serialized out as xml, its value is "l".</para>
        /// </summary>
        [EnumString("l")]
        L,
        /// <summary>
        /// outEnd.
        /// <para>When the item is serialized out as xml, its value is "outEnd".</para>
        /// </summary>
        [EnumString("outEnd")]
        OutEnd,
        /// <summary>
        /// r.
        /// <para>When the item is serialized out as xml, its value is "r".</para>
        /// </summary>
        [EnumString("r")]
        R,
        /// <summary>
        /// t.
        /// <para>When the item is serialized out as xml, its value is "t".</para>
        /// </summary>
        [EnumString("t")]
        T
    }

    /// <summary>
    /// Defines the PageOrientation enumeration.
    /// </summary>
    public enum PageOrientation
    {
        /// <summary>
        /// default.
        /// <para>When the item is serialized out as xml, its value is "default".</para>
        /// </summary>
        [EnumString("default")]
        Default,
        /// <summary>
        /// portrait.
        /// <para>When the item is serialized out as xml, its value is "portrait".</para>
        /// </summary>
        [EnumString("portrait")]
        Portrait,
        /// <summary>
        /// landscape.
        /// <para>When the item is serialized out as xml, its value is "landscape".</para>
        /// </summary>
        [EnumString("landscape")]
        Landscape
    }
}