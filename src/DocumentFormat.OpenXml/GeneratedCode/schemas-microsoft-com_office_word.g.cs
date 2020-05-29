// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Vml.Wordprocessing
{
    /// <summary>
    /// <para>Top Border.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w10:bordertop.</para>
    /// </summary>
    public partial class TopBorder : BorderType
    {
        /// <summary>
        /// Initializes a new instance of the TopBorder class.
        /// </summary>
        public TopBorder() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(28, "bordertop");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TopBorder>(deep);
    }

    /// <summary>
    /// <para>Left Border.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w10:borderleft.</para>
    /// </summary>
    public partial class LeftBorder : BorderType
    {
        /// <summary>
        /// Initializes a new instance of the LeftBorder class.
        /// </summary>
        public LeftBorder() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(28, "borderleft");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeftBorder>(deep);
    }

    /// <summary>
    /// <para>Right Border.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w10:borderright.</para>
    /// </summary>
    public partial class RightBorder : BorderType
    {
        /// <summary>
        /// Initializes a new instance of the RightBorder class.
        /// </summary>
        public RightBorder() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(28, "borderright");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RightBorder>(deep);
    }

    /// <summary>
    /// <para>Bottom Border.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w10:borderbottom.</para>
    /// </summary>
    public partial class BottomBorder : BorderType
    {
        /// <summary>
        /// Initializes a new instance of the BottomBorder class.
        /// </summary>
        public BottomBorder() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(28, "borderbottom");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BottomBorder>(deep);
    }

    /// <summary>
    /// <para>Defines the BorderType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class BorderType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BorderType class.
        /// </summary>
        protected BorderType() : base()
        {
        }

        /// <summary>
        /// <para>Border Style</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Width</para>
        /// <para>Represents the following attribute in the schema: width</para>
        /// </summary>
        public IntegerValue Width
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border shadow</para>
        /// <para>Represents the following attribute in the schema: shadow</para>
        /// </summary>
        public TrueFalseValue Shadow
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<BorderType>()
                           .AddAttribute(0, "type", a => a.Type)
                           .AddAttribute(0, "width", a => a.Width, aBuilder =>
                           {
                               aBuilder.AddValidator(new NumberValidator() { IsPositive = (true) });
                           })
                           .AddAttribute(0, "shadow", a => a.Shadow);
        }
    }

    /// <summary>
    /// <para>Text Wrapping.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w10:wrap.</para>
    /// </summary>
    public partial class TextWrap : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TextWrap class.
        /// </summary>
        public TextWrap() : base()
        {
        }

        /// <summary>
        /// <para>Wrapping type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Wrapping side</para>
        /// <para>Represents the following attribute in the schema: side</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues> Side
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Positioning Base</para>
        /// <para>Represents the following attribute in the schema: anchorx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues> AnchorX
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Positioning Base</para>
        /// <para>Represents the following attribute in the schema: anchory</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues> AnchorY
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(28, "wrap");
            builder.AddElement<TextWrap>()
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "side", a => a.Side)
.AddAttribute(0, "anchorx", a => a.AnchorX)
.AddAttribute(0, "anchory", a => a.AnchorY);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextWrap>(deep);
    }

    /// <summary>
    /// <para>Anchor Location Is Locked.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w10:anchorlock.</para>
    /// </summary>
    public partial class AnchorLock : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AnchorLock class.
        /// </summary>
        public AnchorLock() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(28, "anchorlock");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnchorLock>(deep);
    }

    /// <summary>
    /// Border Type
    /// </summary>
    public enum BorderValues
    {
        ///<summary>
        ///No Border.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Single Line Border.
        ///<para>When the item is serialized out as xml, its value is "single".</para>
        ///</summary>
        [EnumString("single")]
        Single,
        ///<summary>
        ///Thick Line Border.
        ///<para>When the item is serialized out as xml, its value is "thick".</para>
        ///</summary>
        [EnumString("thick")]
        Thick,
        ///<summary>
        ///Double Line Border.
        ///<para>When the item is serialized out as xml, its value is "double".</para>
        ///</summary>
        [EnumString("double")]
        Double,
        ///<summary>
        ///Hairline Border.
        ///<para>When the item is serialized out as xml, its value is "hairline".</para>
        ///</summary>
        [EnumString("hairline")]
        Hairline,
        ///<summary>
        ///Dotted Border.
        ///<para>When the item is serialized out as xml, its value is "dot".</para>
        ///</summary>
        [EnumString("dot")]
        Dot,
        ///<summary>
        ///pecifies a line border consisting of a dashed line around the parent object..
        ///<para>When the item is serialized out as xml, its value is "dash".</para>
        ///</summary>
        [EnumString("dash")]
        Dash,
        ///<summary>
        ///Dot Dash Border.
        ///<para>When the item is serialized out as xml, its value is "dotDash".</para>
        ///</summary>
        [EnumString("dotDash")]
        DotDash,
        ///<summary>
        ///Dash Dot Dot Border.
        ///<para>When the item is serialized out as xml, its value is "dashDotDot".</para>
        ///</summary>
        [EnumString("dashDotDot")]
        DashDotDot,
        ///<summary>
        ///Triple Line Border.
        ///<para>When the item is serialized out as xml, its value is "triple".</para>
        ///</summary>
        [EnumString("triple")]
        Triple,
        ///<summary>
        ///Thin Thick Small Gap Border.
        ///<para>When the item is serialized out as xml, its value is "thinThickSmall".</para>
        ///</summary>
        [EnumString("thinThickSmall")]
        ThinThickSmall,
        ///<summary>
        ///Small thick-thin lines border.
        ///<para>When the item is serialized out as xml, its value is "thickThinSmall".</para>
        ///</summary>
        [EnumString("thickThinSmall")]
        ThickThinSmall,
        ///<summary>
        ///Small thin-thick-thin Lines Border.
        ///<para>When the item is serialized out as xml, its value is "thickBetweenThinSmall".</para>
        ///</summary>
        [EnumString("thickBetweenThinSmall")]
        ThickBetweenThinSmall,
        ///<summary>
        ///Thin Thick Line Border.
        ///<para>When the item is serialized out as xml, its value is "thinThick".</para>
        ///</summary>
        [EnumString("thinThick")]
        ThinThick,
        ///<summary>
        ///Thick Thin Line Border.
        ///<para>When the item is serialized out as xml, its value is "thickThin".</para>
        ///</summary>
        [EnumString("thickThin")]
        ThickThin,
        ///<summary>
        ///Thin-thick-thin Border.
        ///<para>When the item is serialized out as xml, its value is "thickBetweenThin".</para>
        ///</summary>
        [EnumString("thickBetweenThin")]
        ThickBetweenThin,
        ///<summary>
        ///Thin Thick Large Gap Border.
        ///<para>When the item is serialized out as xml, its value is "thinThickLarge".</para>
        ///</summary>
        [EnumString("thinThickLarge")]
        ThinThickLarge,
        ///<summary>
        ///Thick Thin Large Gap Border.
        ///<para>When the item is serialized out as xml, its value is "thickThinLarge".</para>
        ///</summary>
        [EnumString("thickThinLarge")]
        ThickThinLarge,
        ///<summary>
        ///Large thin-thick-thin Border.
        ///<para>When the item is serialized out as xml, its value is "thickBetweenThinLarge".</para>
        ///</summary>
        [EnumString("thickBetweenThinLarge")]
        ThickBetweenThinLarge,
        ///<summary>
        ///Wavy Border.
        ///<para>When the item is serialized out as xml, its value is "wave".</para>
        ///</summary>
        [EnumString("wave")]
        Wave,
        ///<summary>
        ///Double Wavy Lines Border.
        ///<para>When the item is serialized out as xml, its value is "doubleWave".</para>
        ///</summary>
        [EnumString("doubleWave")]
        DoubleWave,
        ///<summary>
        ///Small Dash Border.
        ///<para>When the item is serialized out as xml, its value is "dashedSmall".</para>
        ///</summary>
        [EnumString("dashedSmall")]
        DashedSmall,
        ///<summary>
        ///Stroked Dash Dot Border.
        ///<para>When the item is serialized out as xml, its value is "dashDotStroked".</para>
        ///</summary>
        [EnumString("dashDotStroked")]
        DashDotStroked,
        ///<summary>
        ///3D Embossed Border.
        ///<para>When the item is serialized out as xml, its value is "threeDEmboss".</para>
        ///</summary>
        [EnumString("threeDEmboss")]
        ThreeDEmboss,
        ///<summary>
        ///3D Engraved Border.
        ///<para>When the item is serialized out as xml, its value is "threeDEngrave".</para>
        ///</summary>
        [EnumString("threeDEngrave")]
        ThreeDEngrave,
        ///<summary>
        ///Outset Border.
        ///<para>When the item is serialized out as xml, its value is "HTMLOutset".</para>
        ///</summary>
        [EnumString("HTMLOutset")]
        HTMLOutset,
        ///<summary>
        ///Inset Border.
        ///<para>When the item is serialized out as xml, its value is "HTMLInset".</para>
        ///</summary>
        [EnumString("HTMLInset")]
        HTMLInset,
    }

    /// <summary>
    /// Text Wrapping Type
    /// </summary>
    public enum WrapValues
    {
        ///<summary>
        ///Top and bottom wrapping.
        ///<para>When the item is serialized out as xml, its value is "topAndBottom".</para>
        ///</summary>
        [EnumString("topAndBottom")]
        TopAndBottom,
        ///<summary>
        ///Square wrapping.
        ///<para>When the item is serialized out as xml, its value is "square".</para>
        ///</summary>
        [EnumString("square")]
        Square,
        ///<summary>
        ///No wrapping.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Tight wrapping.
        ///<para>When the item is serialized out as xml, its value is "tight".</para>
        ///</summary>
        [EnumString("tight")]
        Tight,
        ///<summary>
        ///Through wrapping.
        ///<para>When the item is serialized out as xml, its value is "through".</para>
        ///</summary>
        [EnumString("through")]
        Through,
    }

    /// <summary>
    /// Text Wrapping Side
    /// </summary>
    public enum WrapSideValues
    {
        ///<summary>
        ///Both sides.
        ///<para>When the item is serialized out as xml, its value is "both".</para>
        ///</summary>
        [EnumString("both")]
        Both,
        ///<summary>
        ///Left side.
        ///<para>When the item is serialized out as xml, its value is "left".</para>
        ///</summary>
        [EnumString("left")]
        Left,
        ///<summary>
        ///Right side.
        ///<para>When the item is serialized out as xml, its value is "right".</para>
        ///</summary>
        [EnumString("right")]
        Right,
        ///<summary>
        ///Largest side.
        ///<para>When the item is serialized out as xml, its value is "largest".</para>
        ///</summary>
        [EnumString("largest")]
        Largest,
    }

    /// <summary>
    /// Horizontal Anchor Type
    /// </summary>
    public enum HorizontalAnchorValues
    {
        ///<summary>
        ///Margin.
        ///<para>When the item is serialized out as xml, its value is "margin".</para>
        ///</summary>
        [EnumString("margin")]
        Margin,
        ///<summary>
        ///Page.
        ///<para>When the item is serialized out as xml, its value is "page".</para>
        ///</summary>
        [EnumString("page")]
        Page,
        ///<summary>
        ///Text.
        ///<para>When the item is serialized out as xml, its value is "text".</para>
        ///</summary>
        [EnumString("text")]
        Text,
    }

    /// <summary>
    /// Vertical Anchor Type
    /// </summary>
    public enum VerticalAnchorValues
    {
        ///<summary>
        ///Margin.
        ///<para>When the item is serialized out as xml, its value is "margin".</para>
        ///</summary>
        [EnumString("margin")]
        Margin,
        ///<summary>
        ///Page.
        ///<para>When the item is serialized out as xml, its value is "page".</para>
        ///</summary>
        [EnumString("page")]
        Page,
        ///<summary>
        ///Text.
        ///<para>When the item is serialized out as xml, its value is "text".</para>
        ///</summary>
        [EnumString("text")]
        Text,
    }
}