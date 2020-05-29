// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.Word.Drawing
{
    /// <summary>
    /// <para>Defines the PercentagePositionHeightOffset Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp14:pctPosHOffset.</para>
    /// </summary>
    public partial class PercentagePositionHeightOffset : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PercentagePositionHeightOffset class.
        /// </summary>
        public PercentagePositionHeightOffset() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PercentagePositionHeightOffset class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PercentagePositionHeightOffset(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(51, "pctPosHOffset");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PercentagePositionHeightOffset>(deep);
    }

    /// <summary>
    /// <para>Defines the PercentagePositionVerticalOffset Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp14:pctPosVOffset.</para>
    /// </summary>
    public partial class PercentagePositionVerticalOffset : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PercentagePositionVerticalOffset class.
        /// </summary>
        public PercentagePositionVerticalOffset() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PercentagePositionVerticalOffset class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PercentagePositionVerticalOffset(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(51, "pctPosVOffset");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PercentagePositionVerticalOffset>(deep);
    }

    /// <summary>
    /// <para>Defines the RelativeWidth Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp14:sizeRelH.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PercentageWidth &lt;wp14:pctWidth></description></item>
    /// </list>
    /// </remark>
    public partial class RelativeWidth : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RelativeWidth class.
        /// </summary>
        public RelativeWidth() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelativeWidth class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RelativeWidth(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelativeWidth class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RelativeWidth(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelativeWidth class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RelativeWidth(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>relativeFrom, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: relativeFrom</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues> ObjectId
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(51, "sizeRelH");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<PercentageWidth>();
            builder.AddElement<RelativeWidth>()
.AddAttribute(0, "relativeFrom", a => a.ObjectId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageWidth), 1, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>PercentageWidth.</para>
        /// <para>Represents the following element tag in the schema: wp14:pctWidth.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp14 = http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
        /// </remark>
        public PercentageWidth PercentageWidth
        {
            get => GetElement<PercentageWidth>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RelativeWidth>(deep);
    }

    /// <summary>
    /// <para>Defines the RelativeHeight Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp14:sizeRelV.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PercentageHeight &lt;wp14:pctHeight></description></item>
    /// </list>
    /// </remark>
    public partial class RelativeHeight : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RelativeHeight class.
        /// </summary>
        public RelativeHeight() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelativeHeight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RelativeHeight(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelativeHeight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RelativeHeight(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelativeHeight class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RelativeHeight(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>relativeFrom, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: relativeFrom</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues> RelativeFrom
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(51, "sizeRelV");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<PercentageHeight>();
            builder.AddElement<RelativeHeight>()
.AddAttribute(0, "relativeFrom", a => a.RelativeFrom, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentageHeight), 1, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>PercentageHeight.</para>
        /// <para>Represents the following element tag in the schema: wp14:pctHeight.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp14 = http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
        /// </remark>
        public PercentageHeight PercentageHeight
        {
            get => GetElement<PercentageHeight>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RelativeHeight>(deep);
    }

    /// <summary>
    /// <para>Defines the PercentageWidth Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp14:pctWidth.</para>
    /// </summary>
    public partial class PercentageWidth : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PercentageWidth class.
        /// </summary>
        public PercentageWidth() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PercentageWidth class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PercentageWidth(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(new NumberValidator() { MinInclusive = (0L) });
            builder.SetSchema(51, "pctWidth");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PercentageWidth>(deep);
    }

    /// <summary>
    /// <para>Defines the PercentageHeight Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp14:pctHeight.</para>
    /// </summary>
    public partial class PercentageHeight : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PercentageHeight class.
        /// </summary>
        public PercentageHeight() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PercentageHeight class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PercentageHeight(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(new NumberValidator() { MinInclusive = (0L) });
            builder.SetSchema(51, "pctHeight");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PercentageHeight>(deep);
    }

    /// <summary>
    /// Defines the SizeRelativeHorizontallyValues enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public enum SizeRelativeHorizontallyValues
    {
        ///<summary>
        ///margin.
        ///<para>When the item is serialized out as xml, its value is "margin".</para>
        ///</summary>
        [EnumString("margin")]
        Margin,
        ///<summary>
        ///page.
        ///<para>When the item is serialized out as xml, its value is "page".</para>
        ///</summary>
        [EnumString("page")]
        Page,
        ///<summary>
        ///leftMargin.
        ///<para>When the item is serialized out as xml, its value is "leftMargin".</para>
        ///</summary>
        [EnumString("leftMargin")]
        LeftMargin,
        ///<summary>
        ///rightMargin.
        ///<para>When the item is serialized out as xml, its value is "rightMargin".</para>
        ///</summary>
        [EnumString("rightMargin")]
        RightMargin,
        ///<summary>
        ///insideMargin.
        ///<para>When the item is serialized out as xml, its value is "insideMargin".</para>
        ///</summary>
        [EnumString("insideMargin")]
        InsideMargin,
        ///<summary>
        ///outsideMargin.
        ///<para>When the item is serialized out as xml, its value is "outsideMargin".</para>
        ///</summary>
        [EnumString("outsideMargin")]
        OutsideMargin,
    }

    /// <summary>
    /// Defines the SizeRelativeVerticallyValues enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public enum SizeRelativeVerticallyValues
    {
        ///<summary>
        ///margin.
        ///<para>When the item is serialized out as xml, its value is "margin".</para>
        ///</summary>
        [EnumString("margin")]
        Margin,
        ///<summary>
        ///page.
        ///<para>When the item is serialized out as xml, its value is "page".</para>
        ///</summary>
        [EnumString("page")]
        Page,
        ///<summary>
        ///topMargin.
        ///<para>When the item is serialized out as xml, its value is "topMargin".</para>
        ///</summary>
        [EnumString("topMargin")]
        TopMargin,
        ///<summary>
        ///bottomMargin.
        ///<para>When the item is serialized out as xml, its value is "bottomMargin".</para>
        ///</summary>
        [EnumString("bottomMargin")]
        BottomMargin,
        ///<summary>
        ///insideMargin.
        ///<para>When the item is serialized out as xml, its value is "insideMargin".</para>
        ///</summary>
        [EnumString("insideMargin")]
        InsideMargin,
        ///<summary>
        ///outsideMargin.
        ///<para>When the item is serialized out as xml, its value is "outsideMargin".</para>
        ///</summary>
        [EnumString("outsideMargin")]
        OutsideMargin,
    }
}