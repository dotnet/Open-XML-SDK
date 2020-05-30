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

namespace DocumentFormat.OpenXml.Office2010.Ink
{
    /// <summary>
    /// <para>Defines the ContextNode Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is msink:context.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ContextNodeProperty &lt;msink:property></description></item>
    ///   <item><description>SourceLink &lt;msink:sourceLink></description></item>
    ///   <item><description>DestinationLink &lt;msink:destinationLink></description></item>
    /// </list>
    /// </remark>
    public partial class ContextNode : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextNode class.
        /// </summary>
        public ContextNode() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextNode(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextNode(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextNode class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContextNode(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public StringValue Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rotatedBoundingBox</para>
        /// <para>Represents the following attribute in the schema: rotatedBoundingBox</para>
        /// </summary>
        public ListValue<StringValue> RotatedBoundingBox
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignmentLevel</para>
        /// <para>Represents the following attribute in the schema: alignmentLevel</para>
        /// </summary>
        public Int32Value AlignmentLevel
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contentType</para>
        /// <para>Represents the following attribute in the schema: contentType</para>
        /// </summary>
        public Int32Value ContentType
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ascender</para>
        /// <para>Represents the following attribute in the schema: ascender</para>
        /// </summary>
        public StringValue Ascender
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>descender</para>
        /// <para>Represents the following attribute in the schema: descender</para>
        /// </summary>
        public StringValue Descender
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>baseline</para>
        /// <para>Represents the following attribute in the schema: baseline</para>
        /// </summary>
        public StringValue Baseline
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>midline</para>
        /// <para>Represents the following attribute in the schema: midline</para>
        /// </summary>
        public StringValue Midline
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>customRecognizerId</para>
        /// <para>Represents the following attribute in the schema: customRecognizerId</para>
        /// </summary>
        public StringValue CustomRecognizerId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mathML</para>
        /// <para>Represents the following attribute in the schema: mathML</para>
        /// </summary>
        public StringValue MathML
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mathStruct</para>
        /// <para>Represents the following attribute in the schema: mathStruct</para>
        /// </summary>
        public StringValue MathStruct
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mathSymbol</para>
        /// <para>Represents the following attribute in the schema: mathSymbol</para>
        /// </summary>
        public StringValue MathSymbol
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>beginModifierType</para>
        /// <para>Represents the following attribute in the schema: beginModifierType</para>
        /// </summary>
        public StringValue BeginModifierType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endModifierType</para>
        /// <para>Represents the following attribute in the schema: endModifierType</para>
        /// </summary>
        public StringValue EndModifierType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rotationAngle</para>
        /// <para>Represents the following attribute in the schema: rotationAngle</para>
        /// </summary>
        public Int32Value RotationAngle
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hotPoints</para>
        /// <para>Represents the following attribute in the schema: hotPoints</para>
        /// </summary>
        public ListValue<StringValue> HotPoints
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>centroid</para>
        /// <para>Represents the following attribute in the schema: centroid</para>
        /// </summary>
        public StringValue Centroid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>semanticType</para>
        /// <para>Represents the following attribute in the schema: semanticType</para>
        /// </summary>
        public StringValue SemanticType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>shapeName</para>
        /// <para>Represents the following attribute in the schema: shapeName</para>
        /// </summary>
        public StringValue ShapeName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>shapeGeometry</para>
        /// <para>Represents the following attribute in the schema: shapeGeometry</para>
        /// </summary>
        public ListValue<StringValue> ShapeGeometry
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(45, "context");
            builder.AddChild<ContextNodeProperty>();
            builder.AddChild<SourceLink>();
            builder.AddChild<DestinationLink>();
            builder.AddElement<ContextNode>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Office2010.Ink.KnownContextNodeTypeValues>>(EnumValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute(0, "rotatedBoundingBox", a => a.RotatedBoundingBox, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Pattern = ("-?[0-9]+,-?[0-9]+") });
})
.AddAttribute(0, "alignmentLevel", a => a.AlignmentLevel)
.AddAttribute(0, "contentType", a => a.ContentType)
.AddAttribute(0, "ascender", a => a.Ascender, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<ListValue<StringValue>>(NumberValidator.Instance);
union.AddValidator<Int32Value>(NumberValidator.Instance);
});
})
.AddAttribute(0, "descender", a => a.Descender, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<ListValue<StringValue>>(NumberValidator.Instance);
union.AddValidator<Int32Value>(NumberValidator.Instance);
});
})
.AddAttribute(0, "baseline", a => a.Baseline, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<ListValue<StringValue>>(NumberValidator.Instance);
union.AddValidator<Int32Value>(NumberValidator.Instance);
});
})
.AddAttribute(0, "midline", a => a.Midline, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<ListValue<StringValue>>(NumberValidator.Instance);
union.AddValidator<Int32Value>(NumberValidator.Instance);
});
})
.AddAttribute(0, "customRecognizerId", a => a.CustomRecognizerId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "mathML", a => a.MathML)
.AddAttribute(0, "mathStruct", a => a.MathStruct)
.AddAttribute(0, "mathSymbol", a => a.MathSymbol)
.AddAttribute(0, "beginModifierType", a => a.BeginModifierType)
.AddAttribute(0, "endModifierType", a => a.EndModifierType)
.AddAttribute(0, "rotationAngle", a => a.RotationAngle)
.AddAttribute(0, "hotPoints", a => a.HotPoints, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Pattern = ("-?[0-9]+,-?[0-9]+") });
})
.AddAttribute(0, "centroid", a => a.Centroid, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Pattern = ("-?[0-9]+,-?[0-9]+") });
})
.AddAttribute(0, "semanticType", a => a.SemanticType, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Office2010.Ink.KnownSemanticTypeValues>>(EnumValidator.Instance);
union.AddValidator<UInt32Value>(NumberValidator.Instance);
});
})
.AddAttribute(0, "shapeName", a => a.ShapeName)
.AddAttribute(0, "shapeGeometry", a => a.ShapeGeometry, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Pattern = ("-?[0-9]+,-?[0-9]+") });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Ink.ContextNodeProperty), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Ink.SourceLink), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Ink.DestinationLink), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextNode>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextNodeProperty Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is msink:property.</para>
    /// </summary>
    public partial class ContextNodeProperty : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextNodeProperty class.
        /// </summary>
        public ContextNodeProperty() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextNodeProperty class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ContextNodeProperty(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new HexBinaryValue { InnerText = text };
        }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public StringValue Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(45, "property");
            builder.AddElement<ContextNodeProperty>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextNodeProperty>(deep);
    }

    /// <summary>
    /// <para>Defines the SourceLink Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is msink:sourceLink.</para>
    /// </summary>
    public partial class SourceLink : ContextLinkType
    {
        /// <summary>
        /// Initializes a new instance of the SourceLink class.
        /// </summary>
        public SourceLink() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(45, "sourceLink");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SourceLink>(deep);
    }

    /// <summary>
    /// <para>Defines the DestinationLink Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is msink:destinationLink.</para>
    /// </summary>
    public partial class DestinationLink : ContextLinkType
    {
        /// <summary>
        /// Initializes a new instance of the DestinationLink class.
        /// </summary>
        public DestinationLink() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(45, "destinationLink");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DestinationLink>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextLinkType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class ContextLinkType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextLinkType class.
        /// </summary>
        protected ContextLinkType() : base()
        {
        }

        /// <summary>
        /// <para>direction</para>
        /// <para>Represents the following attribute in the schema: direction</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Ink.LinkDirectionValues> Direction
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Ink.LinkDirectionValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        public StringValue Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<ContextLinkType>()
                           .AddAttribute(0, "direction", a => a.Direction)
                           .AddAttribute(0, "ref", a => a.Reference, aBuilder =>
                           {
                               aBuilder.AddUnion(union =>
                               {
                                   union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                                   union.AddValidator<UInt32Value>(NumberValidator.Instance);
                               });
                           });
        }
    }

    /// <summary>
    /// Defines the KnownContextNodeTypeValues enumeration.
    /// </summary>
    public enum KnownContextNodeTypeValues
    {
        ///<summary>
        ///root.
        ///<para>When the item is serialized out as xml, its value is "root".</para>
        ///</summary>
        [EnumString("root")]
        Root,
        ///<summary>
        ///unclassifiedInk.
        ///<para>When the item is serialized out as xml, its value is "unclassifiedInk".</para>
        ///</summary>
        [EnumString("unclassifiedInk")]
        UnclassifiedInk,
        ///<summary>
        ///writingRegion.
        ///<para>When the item is serialized out as xml, its value is "writingRegion".</para>
        ///</summary>
        [EnumString("writingRegion")]
        WritingRegion,
        ///<summary>
        ///analysisHint.
        ///<para>When the item is serialized out as xml, its value is "analysisHint".</para>
        ///</summary>
        [EnumString("analysisHint")]
        AnalysisHint,
        ///<summary>
        ///object.
        ///<para>When the item is serialized out as xml, its value is "object".</para>
        ///</summary>
        [EnumString("object")]
        Object,
        ///<summary>
        ///inkDrawing.
        ///<para>When the item is serialized out as xml, its value is "inkDrawing".</para>
        ///</summary>
        [EnumString("inkDrawing")]
        InkDrawing,
        ///<summary>
        ///image.
        ///<para>When the item is serialized out as xml, its value is "image".</para>
        ///</summary>
        [EnumString("image")]
        Image,
        ///<summary>
        ///paragraph.
        ///<para>When the item is serialized out as xml, its value is "paragraph".</para>
        ///</summary>
        [EnumString("paragraph")]
        Paragraph,
        ///<summary>
        ///line.
        ///<para>When the item is serialized out as xml, its value is "line".</para>
        ///</summary>
        [EnumString("line")]
        Line,
        ///<summary>
        ///inkBullet.
        ///<para>When the item is serialized out as xml, its value is "inkBullet".</para>
        ///</summary>
        [EnumString("inkBullet")]
        InkBullet,
        ///<summary>
        ///inkWord.
        ///<para>When the item is serialized out as xml, its value is "inkWord".</para>
        ///</summary>
        [EnumString("inkWord")]
        InkWord,
        ///<summary>
        ///textWord.
        ///<para>When the item is serialized out as xml, its value is "textWord".</para>
        ///</summary>
        [EnumString("textWord")]
        TextWord,
        ///<summary>
        ///customRecognizer.
        ///<para>When the item is serialized out as xml, its value is "customRecognizer".</para>
        ///</summary>
        [EnumString("customRecognizer")]
        CustomRecognizer,
        ///<summary>
        ///mathRegion.
        ///<para>When the item is serialized out as xml, its value is "mathRegion".</para>
        ///</summary>
        [EnumString("mathRegion")]
        MathRegion,
        ///<summary>
        ///mathEquation.
        ///<para>When the item is serialized out as xml, its value is "mathEquation".</para>
        ///</summary>
        [EnumString("mathEquation")]
        MathEquation,
        ///<summary>
        ///mathStruct.
        ///<para>When the item is serialized out as xml, its value is "mathStruct".</para>
        ///</summary>
        [EnumString("mathStruct")]
        MathStruct,
        ///<summary>
        ///mathSymbol.
        ///<para>When the item is serialized out as xml, its value is "mathSymbol".</para>
        ///</summary>
        [EnumString("mathSymbol")]
        MathSymbol,
        ///<summary>
        ///mathIdentifier.
        ///<para>When the item is serialized out as xml, its value is "mathIdentifier".</para>
        ///</summary>
        [EnumString("mathIdentifier")]
        MathIdentifier,
        ///<summary>
        ///mathOperator.
        ///<para>When the item is serialized out as xml, its value is "mathOperator".</para>
        ///</summary>
        [EnumString("mathOperator")]
        MathOperator,
        ///<summary>
        ///mathNumber.
        ///<para>When the item is serialized out as xml, its value is "mathNumber".</para>
        ///</summary>
        [EnumString("mathNumber")]
        MathNumber,
        ///<summary>
        ///nonInkDrawing.
        ///<para>When the item is serialized out as xml, its value is "nonInkDrawing".</para>
        ///</summary>
        [EnumString("nonInkDrawing")]
        NonInkDrawing,
        ///<summary>
        ///groupNode.
        ///<para>When the item is serialized out as xml, its value is "groupNode".</para>
        ///</summary>
        [EnumString("groupNode")]
        GroupNode,
        ///<summary>
        ///mixedDrawing.
        ///<para>When the item is serialized out as xml, its value is "mixedDrawing".</para>
        ///</summary>
        [EnumString("mixedDrawing")]
        MixedDrawing,
    }

    /// <summary>
    /// Defines the LinkDirectionValues enumeration.
    /// </summary>
    public enum LinkDirectionValues
    {
        ///<summary>
        ///to.
        ///<para>When the item is serialized out as xml, its value is "to".</para>
        ///</summary>
        [EnumString("to")]
        To,
        ///<summary>
        ///from.
        ///<para>When the item is serialized out as xml, its value is "from".</para>
        ///</summary>
        [EnumString("from")]
        From,
        ///<summary>
        ///with.
        ///<para>When the item is serialized out as xml, its value is "with".</para>
        ///</summary>
        [EnumString("with")]
        With,
    }

    /// <summary>
    /// Defines the KnownSemanticTypeValues enumeration.
    /// </summary>
    public enum KnownSemanticTypeValues
    {
        ///<summary>
        ///none.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///underline.
        ///<para>When the item is serialized out as xml, its value is "underline".</para>
        ///</summary>
        [EnumString("underline")]
        Underline,
        ///<summary>
        ///strikethrough.
        ///<para>When the item is serialized out as xml, its value is "strikethrough".</para>
        ///</summary>
        [EnumString("strikethrough")]
        Strikethrough,
        ///<summary>
        ///highlight.
        ///<para>When the item is serialized out as xml, its value is "highlight".</para>
        ///</summary>
        [EnumString("highlight")]
        Highlight,
        ///<summary>
        ///scratchOut.
        ///<para>When the item is serialized out as xml, its value is "scratchOut".</para>
        ///</summary>
        [EnumString("scratchOut")]
        ScratchOut,
        ///<summary>
        ///verticalRange.
        ///<para>When the item is serialized out as xml, its value is "verticalRange".</para>
        ///</summary>
        [EnumString("verticalRange")]
        VerticalRange,
        ///<summary>
        ///callout.
        ///<para>When the item is serialized out as xml, its value is "callout".</para>
        ///</summary>
        [EnumString("callout")]
        Callout,
        ///<summary>
        ///enclosure.
        ///<para>When the item is serialized out as xml, its value is "enclosure".</para>
        ///</summary>
        [EnumString("enclosure")]
        Enclosure,
        ///<summary>
        ///comment.
        ///<para>When the item is serialized out as xml, its value is "comment".</para>
        ///</summary>
        [EnumString("comment")]
        Comment,
        ///<summary>
        ///container.
        ///<para>When the item is serialized out as xml, its value is "container".</para>
        ///</summary>
        [EnumString("container")]
        Container,
        ///<summary>
        ///connector.
        ///<para>When the item is serialized out as xml, its value is "connector".</para>
        ///</summary>
        [EnumString("connector")]
        Connector,
    }
}