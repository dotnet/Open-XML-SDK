// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Excel.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
    /// <summary>
    /// <para>Two Cell Anchor Shape Size.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:twoCellAnchor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FromMarker &lt;xdr:from></description></item>
    ///   <item><description>ToMarker &lt;xdr:to></description></item>
    ///   <item><description>Shape &lt;xdr:sp></description></item>
    ///   <item><description>GroupShape &lt;xdr:grpSp></description></item>
    ///   <item><description>GraphicFrame &lt;xdr:graphicFrame></description></item>
    ///   <item><description>ConnectionShape &lt;xdr:cxnSp></description></item>
    ///   <item><description>Picture &lt;xdr:pic></description></item>
    ///   <item><description>ContentPart &lt;xdr:contentPart></description></item>
    ///   <item><description>ClientData &lt;xdr:clientData></description></item>
    /// </list>
    /// </remark>
    public partial class TwoCellAnchor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TwoCellAnchor class.
        /// </summary>
        public TwoCellAnchor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TwoCellAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TwoCellAnchor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TwoCellAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TwoCellAnchor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TwoCellAnchor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TwoCellAnchor(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Positioning and Resizing Behaviors</para>
        /// <para>Represents the following attribute in the schema: editAs</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Spreadsheet.EditAsValues> EditAs
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Spreadsheet.EditAsValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "twoCellAnchor");
            builder.AddChild<FromMarker>();
            builder.AddChild<ToMarker>();
            builder.AddChild<Shape>();
            builder.AddChild<GroupShape>();
            builder.AddChild<GraphicFrame>();
            builder.AddChild<ConnectionShape>();
            builder.AddChild<Picture>();
            builder.AddChild<ContentPart>();
            builder.AddChild<ClientData>();
            builder.AddElement<TwoCellAnchor>()
.AddAttribute(0, "editAs", a => a.EditAs, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.FromMarker), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ToMarker), 1, 1),
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ClientData), 1, 1)
            };
        }

        /// <summary>
        /// <para>Starting Anchor Point.</para>
        /// <para>Represents the following element tag in the schema: xdr:from.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public FromMarker FromMarker
        {
            get => GetElement<FromMarker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Ending Anchor Point.</para>
        /// <para>Represents the following element tag in the schema: xdr:to.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public ToMarker ToMarker
        {
            get => GetElement<ToMarker>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TwoCellAnchor>(deep);
    }

    /// <summary>
    /// <para>One Cell Anchor Shape Size.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:oneCellAnchor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FromMarker &lt;xdr:from></description></item>
    ///   <item><description>Extent &lt;xdr:ext></description></item>
    ///   <item><description>Shape &lt;xdr:sp></description></item>
    ///   <item><description>GroupShape &lt;xdr:grpSp></description></item>
    ///   <item><description>GraphicFrame &lt;xdr:graphicFrame></description></item>
    ///   <item><description>ConnectionShape &lt;xdr:cxnSp></description></item>
    ///   <item><description>Picture &lt;xdr:pic></description></item>
    ///   <item><description>ContentPart &lt;xdr:contentPart></description></item>
    ///   <item><description>ClientData &lt;xdr:clientData></description></item>
    /// </list>
    /// </remark>
    public partial class OneCellAnchor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OneCellAnchor class.
        /// </summary>
        public OneCellAnchor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OneCellAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OneCellAnchor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OneCellAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OneCellAnchor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OneCellAnchor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OneCellAnchor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "oneCellAnchor");
            builder.AddChild<FromMarker>();
            builder.AddChild<Extent>();
            builder.AddChild<Shape>();
            builder.AddChild<GroupShape>();
            builder.AddChild<GraphicFrame>();
            builder.AddChild<ConnectionShape>();
            builder.AddChild<Picture>();
            builder.AddChild<ContentPart>();
            builder.AddChild<ClientData>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.FromMarker), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Extent), 1, 1),
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ClientData), 1, 1)
            };
        }

        /// <summary>
        /// <para>FromMarker.</para>
        /// <para>Represents the following element tag in the schema: xdr:from.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public FromMarker FromMarker
        {
            get => GetElement<FromMarker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extent.</para>
        /// <para>Represents the following element tag in the schema: xdr:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public Extent Extent
        {
            get => GetElement<Extent>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OneCellAnchor>(deep);
    }

    /// <summary>
    /// <para>Absolute Anchor Shape Size.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:absoluteAnchor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Position &lt;xdr:pos></description></item>
    ///   <item><description>Extent &lt;xdr:ext></description></item>
    ///   <item><description>Shape &lt;xdr:sp></description></item>
    ///   <item><description>GroupShape &lt;xdr:grpSp></description></item>
    ///   <item><description>GraphicFrame &lt;xdr:graphicFrame></description></item>
    ///   <item><description>ConnectionShape &lt;xdr:cxnSp></description></item>
    ///   <item><description>Picture &lt;xdr:pic></description></item>
    ///   <item><description>ContentPart &lt;xdr:contentPart></description></item>
    ///   <item><description>ClientData &lt;xdr:clientData></description></item>
    /// </list>
    /// </remark>
    public partial class AbsoluteAnchor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AbsoluteAnchor class.
        /// </summary>
        public AbsoluteAnchor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AbsoluteAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AbsoluteAnchor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AbsoluteAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AbsoluteAnchor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AbsoluteAnchor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AbsoluteAnchor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "absoluteAnchor");
            builder.AddChild<Position>();
            builder.AddChild<Extent>();
            builder.AddChild<Shape>();
            builder.AddChild<GroupShape>();
            builder.AddChild<GraphicFrame>();
            builder.AddChild<ConnectionShape>();
            builder.AddChild<Picture>();
            builder.AddChild<ContentPart>();
            builder.AddChild<ClientData>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Position), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Extent), 1, 1),
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ClientData), 1, 1)
            };
        }

        /// <summary>
        /// <para>Position.</para>
        /// <para>Represents the following element tag in the schema: xdr:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public Position Position
        {
            get => GetElement<Position>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Extent.</para>
        /// <para>Represents the following element tag in the schema: xdr:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public Extent Extent
        {
            get => GetElement<Extent>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AbsoluteAnchor>(deep);
    }

    /// <summary>
    /// <para>Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:sp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualShapeProperties &lt;xdr:nvSpPr></description></item>
    ///   <item><description>ShapeProperties &lt;xdr:spPr></description></item>
    ///   <item><description>ShapeStyle &lt;xdr:style></description></item>
    ///   <item><description>TextBody &lt;xdr:txBody></description></item>
    /// </list>
    /// </remark>
    public partial class Shape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape class.
        /// </summary>
        public Shape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference to Custom Function</para>
        /// <para>Represents the following attribute in the schema: macro</para>
        /// </summary>
        public StringValue Macro
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Link</para>
        /// <para>Represents the following attribute in the schema: textlink</para>
        /// </summary>
        public StringValue TextLink
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Lock Text Flag</para>
        /// <para>Represents the following attribute in the schema: fLocksText</para>
        /// </summary>
        public BooleanValue LockText
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Publish to Server Flag</para>
        /// <para>Represents the following attribute in the schema: fPublished</para>
        /// </summary>
        public BooleanValue Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "sp");
            builder.AddChild<NonVisualShapeProperties>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<ShapeStyle>();
            builder.AddChild<TextBody>();
            builder.AddElement<Shape>()
.AddAttribute(0, "macro", a => a.Macro)
.AddAttribute(0, "textlink", a => a.TextLink)
.AddAttribute(0, "fLocksText", a => a.LockText)
.AddAttribute(0, "fPublished", a => a.Published);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.TextBody), 0, 1)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:macro*/, 0, 256));
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Shape.</para>
        /// <para>Represents the following element tag in the schema: xdr:nvSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualShapeProperties NonVisualShapeProperties
        {
            get => GetElement<NonVisualShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeStyle.</para>
        /// <para>Represents the following element tag in the schema: xdr:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public ShapeStyle ShapeStyle
        {
            get => GetElement<ShapeStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Text Body.</para>
        /// <para>Represents the following element tag in the schema: xdr:txBody.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public TextBody TextBody
        {
            get => GetElement<TextBody>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);
    }

    /// <summary>
    /// <para>Group Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:grpSp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualGroupShapeProperties &lt;xdr:nvGrpSpPr></description></item>
    ///   <item><description>GroupShapeProperties &lt;xdr:grpSpPr></description></item>
    ///   <item><description>Shape &lt;xdr:sp></description></item>
    ///   <item><description>GroupShape &lt;xdr:grpSp></description></item>
    ///   <item><description>GraphicFrame &lt;xdr:graphicFrame></description></item>
    ///   <item><description>ConnectionShape &lt;xdr:cxnSp></description></item>
    ///   <item><description>Picture &lt;xdr:pic></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.Drawing.ContentPart &lt;xdr14:contentPart></description></item>
    /// </list>
    /// </remark>
    public partial class GroupShape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShape class.
        /// </summary>
        public GroupShape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShape(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "grpSp");
            builder.AddChild<NonVisualGroupShapeProperties>();
            builder.AddChild<GroupShapeProperties>();
            builder.AddChild<Shape>();
            builder.AddChild<GroupShape>();
            builder.AddChild<GraphicFrame>();
            builder.AddChild<ConnectionShape>();
            builder.AddChild<Picture>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.Drawing.ContentPart>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGroupShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShapeProperties), 1, 1),
                new CompositeParticle(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Group Shape.</para>
        /// <para>Represents the following element tag in the schema: xdr:nvGrpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualGroupShapeProperties NonVisualGroupShapeProperties
        {
            get => GetElement<NonVisualGroupShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Group Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:grpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public GroupShapeProperties GroupShapeProperties
        {
            get => GetElement<GroupShapeProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShape>(deep);
    }

    /// <summary>
    /// <para>Graphic Frame.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:graphicFrame.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualGraphicFrameProperties &lt;xdr:nvGraphicFramePr></description></item>
    ///   <item><description>Transform &lt;xdr:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Graphic &lt;a:graphic></description></item>
    /// </list>
    /// </remark>
    public partial class GraphicFrame : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GraphicFrame class.
        /// </summary>
        public GraphicFrame() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrame class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrame(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrame class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrame(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrame class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GraphicFrame(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference To Custom Function</para>
        /// <para>Represents the following attribute in the schema: macro</para>
        /// </summary>
        public StringValue Macro
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Publish to Server Flag</para>
        /// <para>Represents the following attribute in the schema: fPublished</para>
        /// </summary>
        public BooleanValue Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "graphicFrame");
            builder.AddChild<NonVisualGraphicFrameProperties>();
            builder.AddChild<Transform>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Graphic>();
            builder.AddElement<GraphicFrame>()
.AddAttribute(0, "macro", a => a.Macro)
.AddAttribute(0, "fPublished", a => a.Published);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGraphicFrameProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Transform), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Graphic), 1, 1)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:macro*/, 0, 256));
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Graphic Frame.</para>
        /// <para>Represents the following element tag in the schema: xdr:nvGraphicFramePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualGraphicFrameProperties NonVisualGraphicFrameProperties
        {
            get => GetElement<NonVisualGraphicFrameProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>2D Transform for Graphic Frames.</para>
        /// <para>Represents the following element tag in the schema: xdr:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public Transform Transform
        {
            get => GetElement<Transform>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Graphic.</para>
        /// <para>Represents the following element tag in the schema: a:graphic.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Graphic Graphic
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Graphic>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicFrame>(deep);
    }

    /// <summary>
    /// <para>Connection Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cxnSp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualConnectionShapeProperties &lt;xdr:nvCxnSpPr></description></item>
    ///   <item><description>ShapeProperties &lt;xdr:spPr></description></item>
    ///   <item><description>ShapeStyle &lt;xdr:style></description></item>
    /// </list>
    /// </remark>
    public partial class ConnectionShape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionShape class.
        /// </summary>
        public ConnectionShape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectionShape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectionShape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionShape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConnectionShape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference to Custom Function</para>
        /// <para>Represents the following attribute in the schema: macro</para>
        /// </summary>
        public StringValue Macro
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Publish to Server Flag</para>
        /// <para>Represents the following attribute in the schema: fPublished</para>
        /// </summary>
        public BooleanValue Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "cxnSp");
            builder.AddChild<NonVisualConnectionShapeProperties>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<ShapeStyle>();
            builder.AddElement<ConnectionShape>()
.AddAttribute(0, "macro", a => a.Macro)
.AddAttribute(0, "fPublished", a => a.Published);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualConnectionShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle), 0, 1)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:macro*/, 0, 256));
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Connection Shape.</para>
        /// <para>Represents the following element tag in the schema: xdr:nvCxnSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualConnectionShapeProperties NonVisualConnectionShapeProperties
        {
            get => GetElement<NonVisualConnectionShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connector Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeStyle.</para>
        /// <para>Represents the following element tag in the schema: xdr:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public ShapeStyle ShapeStyle
        {
            get => GetElement<ShapeStyle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectionShape>(deep);
    }

    /// <summary>
    /// <para>Defines the Picture Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:pic.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualPictureProperties &lt;xdr:nvPicPr></description></item>
    ///   <item><description>BlipFill &lt;xdr:blipFill></description></item>
    ///   <item><description>ShapeProperties &lt;xdr:spPr></description></item>
    ///   <item><description>ShapeStyle &lt;xdr:style></description></item>
    /// </list>
    /// </remark>
    public partial class Picture : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Picture class.
        /// </summary>
        public Picture() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Picture(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Picture(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Picture(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference To Custom Function</para>
        /// <para>Represents the following attribute in the schema: macro</para>
        /// </summary>
        public StringValue Macro
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Publish to Server Flag</para>
        /// <para>Represents the following attribute in the schema: fPublished</para>
        /// </summary>
        public BooleanValue Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "pic");
            builder.AddChild<NonVisualPictureProperties>();
            builder.AddChild<BlipFill>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<ShapeStyle>();
            builder.AddElement<Picture>()
.AddAttribute(0, "macro", a => a.Macro)
.AddAttribute(0, "fPublished", a => a.Published);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.BlipFill), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle), 0, 1)
            };
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Picture.</para>
        /// <para>Represents the following element tag in the schema: xdr:nvPicPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualPictureProperties NonVisualPictureProperties
        {
            get => GetElement<NonVisualPictureProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Picture Fill.</para>
        /// <para>Represents the following element tag in the schema: xdr:blipFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public BlipFill BlipFill
        {
            get => GetElement<BlipFill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: xdr:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Style.</para>
        /// <para>Represents the following element tag in the schema: xdr:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public ShapeStyle ShapeStyle
        {
            get => GetElement<ShapeStyle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Picture>(deep);
    }

    /// <summary>
    /// <para>Defines the ContentPart Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:contentPart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties &lt;xdr14:nvContentPartPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties &lt;xdr14:nvPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D &lt;xdr14:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList &lt;xdr14:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ContentPart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContentPart class.
        /// </summary>
        public ContentPart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentPart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContentPart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentPart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContentPart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentPart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContentPart(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue RelationshipId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bwMode, this property is only available in Office2010, Office2013, Office2016</para>
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
            builder.SetSchema(18, "contentPart");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList>();
            builder.AddElement<ContentPart>()
.AddAttribute(19, "id", a => a.RelationshipId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>ExcelNonVisualContentPartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: xdr14:nvContentPartPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties ExcelNonVisualContentPartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ApplicationNonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: xdr14:nvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties ApplicationNonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Transform2D.</para>
        /// <para>Represents the following element tag in the schema: xdr14:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xdr14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContentPart>(deep);
    }

    /// <summary>
    /// <para>Worksheet Drawing.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:wsDr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TwoCellAnchor &lt;xdr:twoCellAnchor></description></item>
    ///   <item><description>OneCellAnchor &lt;xdr:oneCellAnchor></description></item>
    ///   <item><description>AbsoluteAnchor &lt;xdr:absoluteAnchor></description></item>
    /// </list>
    /// </remark>
    public partial class WorksheetDrawing : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the WorksheetDrawing class.
        /// </summary>
        public WorksheetDrawing() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorksheetDrawing class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WorksheetDrawing(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorksheetDrawing class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WorksheetDrawing(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorksheetDrawing class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WorksheetDrawing(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "wsDr");
            builder.AddChild<TwoCellAnchor>();
            builder.AddChild<OneCellAnchor>();
            builder.AddChild<AbsoluteAnchor>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.TwoCellAnchor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.OneCellAnchor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.AbsoluteAnchor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WorksheetDrawing>(deep);

        internal WorksheetDrawing(DrawingsPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the DrawingsPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(DrawingsPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the DrawingsPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(DrawingsPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the DrawingsPart associated with this element.
        /// </summary>
        public DrawingsPart DrawingsPart
        {
            get => OpenXmlPart as DrawingsPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:nvSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;xdr:cNvPr></description></item>
    ///   <item><description>NonVisualShapeDrawingProperties &lt;xdr:cNvSpPr></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class.
        /// </summary>
        public NonVisualShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "nvSpPr");
            builder.AddChild<NonVisualDrawingProperties>();
            builder.AddChild<NonVisualShapeDrawingProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualShapeDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Non-Visual Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection Non-Visual Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualShapeDrawingProperties NonVisualShapeDrawingProperties
        {
            get => GetElement<NonVisualShapeDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Shape Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:spPr.</para>
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
            builder.SetSchema(18, "spPr");
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
    /// <para>Defines the ShapeStyle Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:style.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LineReference &lt;a:lnRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.FillReference &lt;a:fillRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectReference &lt;a:effectRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.FontReference &lt;a:fontRef></description></item>
    /// </list>
    /// </remark>
    public partial class ShapeStyle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeStyle class.
        /// </summary>
        public ShapeStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeStyle(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "style");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LineReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FillReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FontReference>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FillReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FontReference), 1, 1)
            };
        }

        /// <summary>
        /// <para>LineReference.</para>
        /// <para>Represents the following element tag in the schema: a:lnRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.LineReference LineReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.LineReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillReference.</para>
        /// <para>Represents the following element tag in the schema: a:fillRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FillReference FillReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FillReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectReference.</para>
        /// <para>Represents the following element tag in the schema: a:effectRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EffectReference EffectReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EffectReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Font Reference.</para>
        /// <para>Represents the following element tag in the schema: a:fontRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FontReference FontReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FontReference>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeStyle>(deep);
    }

    /// <summary>
    /// <para>Shape Text Body.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:txBody.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
    /// </list>
    /// </remark>
    public partial class TextBody : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBody class.
        /// </summary>
        public TextBody() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBody(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "txBody");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
            };
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBody>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Connection Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:nvCxnSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;xdr:cNvPr></description></item>
    ///   <item><description>NonVisualConnectorShapeDrawingProperties &lt;xdr:cNvCxnSpPr></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualConnectionShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class.
        /// </summary>
        public NonVisualConnectionShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectionShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectionShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualConnectionShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "nvCxnSpPr");
            builder.AddChild<NonVisualDrawingProperties>();
            builder.AddChild<NonVisualConnectorShapeDrawingProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualConnectorShapeDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Connection Non-Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Connector Shape Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvCxnSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualConnectorShapeDrawingProperties NonVisualConnectorShapeDrawingProperties
        {
            get => GetElement<NonVisualConnectorShapeDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectionShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Picture.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:nvPicPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;xdr:cNvPr></description></item>
    ///   <item><description>NonVisualPictureDrawingProperties &lt;xdr:cNvPicPr></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualPictureProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class.
        /// </summary>
        public NonVisualPictureProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualPictureProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "nvPicPr");
            builder.AddChild<NonVisualDrawingProperties>();
            builder.AddChild<NonVisualPictureDrawingProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>NonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Picture Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvPicPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualPictureDrawingProperties NonVisualPictureDrawingProperties
        {
            get => GetElement<NonVisualPictureDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualPictureProperties>(deep);
    }

    /// <summary>
    /// <para>Picture Fill.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:blipFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Blip &lt;a:blip></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SourceRectangle &lt;a:srcRect></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Tile &lt;a:tile></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Stretch &lt;a:stretch></description></item>
    /// </list>
    /// </remark>
    public partial class BlipFill : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BlipFill class.
        /// </summary>
        public BlipFill() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFill(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFill(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BlipFill(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotate With Shape</para>
        /// <para>Represents the following attribute in the schema: rotWithShape</para>
        /// </summary>
        public BooleanValue RotateWithShape
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "blipFill");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Blip>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Tile>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Stretch>();
            builder.AddElement<BlipFill>()
.AddAttribute(0, "rotWithShape", a => a.RotateWithShape);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blip), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SourceRectangle), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Tile), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Stretch), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>Blip.</para>
        /// <para>Represents the following element tag in the schema: a:blip.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Blip Blip
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Blip>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Source Rectangle.</para>
        /// <para>Represents the following element tag in the schema: a:srcRect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SourceRectangle SourceRectangle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BlipFill>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Graphic Frame.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:nvGraphicFramePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;xdr:cNvPr></description></item>
    ///   <item><description>NonVisualGraphicFrameDrawingProperties &lt;xdr:cNvGraphicFramePr></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualGraphicFrameProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class.
        /// </summary>
        public NonVisualGraphicFrameProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGraphicFrameProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "nvGraphicFramePr");
            builder.AddChild<NonVisualDrawingProperties>();
            builder.AddChild<NonVisualGraphicFrameDrawingProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGraphicFrameDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Connection Non-Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Graphic Frame Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvGraphicFramePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualGraphicFrameDrawingProperties NonVisualGraphicFrameDrawingProperties
        {
            get => GetElement<NonVisualGraphicFrameDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGraphicFrameProperties>(deep);
    }

    /// <summary>
    /// <para>2D Transform for Graphic Frames.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:xfrm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Offset &lt;a:off></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extents &lt;a:ext></description></item>
    /// </list>
    /// </remark>
    public partial class Transform : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Transform class.
        /// </summary>
        public Transform() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Transform(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>
        public Int32Value Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>
        public BooleanValue HorizontalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>
        public BooleanValue VerticalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "xfrm");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Offset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extents>();
            builder.AddElement<Transform>()
.AddAttribute(0, "rot", a => a.Rotation)
.AddAttribute(0, "flipH", a => a.HorizontalFlip)
.AddAttribute(0, "flipV", a => a.VerticalFlip);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Offset), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extents), 0, 1)
            };
        }

        /// <summary>
        /// <para>Offset.</para>
        /// <para>Represents the following element tag in the schema: a:off.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Offset Offset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extents.</para>
        /// <para>Represents the following element tag in the schema: a:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Extents Extents
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform>(deep);
    }

    /// <summary>
    /// <para>Column).</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:col.</para>
    /// </summary>
    public partial class ColumnId : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ColumnId class.
        /// </summary>
        public ColumnId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnId class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ColumnId(string text) : base(text)
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
            builder.SetSchema(18, "col");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnId>(deep);
    }

    /// <summary>
    /// <para>Column Offset.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:colOff.</para>
    /// </summary>
    public partial class ColumnOffset : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ColumnOffset class.
        /// </summary>
        public ColumnOffset() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnOffset class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ColumnOffset(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int64Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int64Value>(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
            builder.SetSchema(18, "colOff");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnOffset>(deep);
    }

    /// <summary>
    /// <para>Row Offset.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:rowOff.</para>
    /// </summary>
    public partial class RowOffset : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the RowOffset class.
        /// </summary>
        public RowOffset() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RowOffset class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public RowOffset(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int64Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int64Value>(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
            builder.SetSchema(18, "rowOff");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowOffset>(deep);
    }

    /// <summary>
    /// <para>Row.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:row.</para>
    /// </summary>
    public partial class RowId : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the RowId class.
        /// </summary>
        public RowId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RowId class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public RowId(string text) : base(text)
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
            builder.SetSchema(18, "row");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowId>(deep);
    }

    /// <summary>
    /// <para>Starting Anchor Point.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:from.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColumnId &lt;xdr:col></description></item>
    ///   <item><description>ColumnOffset &lt;xdr:colOff></description></item>
    ///   <item><description>RowId &lt;xdr:row></description></item>
    ///   <item><description>RowOffset &lt;xdr:rowOff></description></item>
    /// </list>
    /// </remark>
    public partial class FromMarker : MarkerType
    {
        /// <summary>
        /// Initializes a new instance of the FromMarker class.
        /// </summary>
        public FromMarker() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FromMarker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FromMarker(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FromMarker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FromMarker(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FromMarker class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FromMarker(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "from");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnId), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnOffset), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.RowId), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.RowOffset), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FromMarker>(deep);
    }

    /// <summary>
    /// <para>Ending Anchor Point.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:to.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColumnId &lt;xdr:col></description></item>
    ///   <item><description>ColumnOffset &lt;xdr:colOff></description></item>
    ///   <item><description>RowId &lt;xdr:row></description></item>
    ///   <item><description>RowOffset &lt;xdr:rowOff></description></item>
    /// </list>
    /// </remark>
    public partial class ToMarker : MarkerType
    {
        /// <summary>
        /// Initializes a new instance of the ToMarker class.
        /// </summary>
        public ToMarker() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToMarker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ToMarker(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToMarker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ToMarker(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToMarker class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ToMarker(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "to");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnId), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnOffset), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.RowId), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.RowOffset), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToMarker>(deep);
    }

    /// <summary>
    /// <para>Defines the MarkerType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColumnId &lt;xdr:col></description></item>
    ///   <item><description>ColumnOffset &lt;xdr:colOff></description></item>
    ///   <item><description>RowId &lt;xdr:row></description></item>
    ///   <item><description>RowOffset &lt;xdr:rowOff></description></item>
    /// </list>
    /// </remark>
    public abstract partial class MarkerType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MarkerType class.
        /// </summary>
        protected MarkerType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MarkerType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected MarkerType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MarkerType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected MarkerType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MarkerType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected MarkerType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<ColumnId>();
            builder.AddChild<ColumnOffset>();
            builder.AddChild<RowId>();
            builder.AddChild<RowOffset>();
        }

        /// <summary>
        /// <para>Column).</para>
        /// <para>Represents the following element tag in the schema: xdr:col.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public ColumnId ColumnId
        {
            get => GetElement<ColumnId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Column Offset.</para>
        /// <para>Represents the following element tag in the schema: xdr:colOff.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public ColumnOffset ColumnOffset
        {
            get => GetElement<ColumnOffset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Row.</para>
        /// <para>Represents the following element tag in the schema: xdr:row.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public RowId RowId
        {
            get => GetElement<RowId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Row Offset.</para>
        /// <para>Represents the following element tag in the schema: xdr:rowOff.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public RowOffset RowOffset
        {
            get => GetElement<RowOffset>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Client Data.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:clientData.</para>
    /// </summary>
    public partial class ClientData : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ClientData class.
        /// </summary>
        public ClientData() : base()
        {
        }

        /// <summary>
        /// <para>Locks With Sheet Flag</para>
        /// <para>Represents the following attribute in the schema: fLocksWithSheet</para>
        /// </summary>
        public BooleanValue LockWithSheet
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Prints With Sheet Flag</para>
        /// <para>Represents the following attribute in the schema: fPrintsWithSheet</para>
        /// </summary>
        public BooleanValue PrintWithSheet
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "clientData");
            builder.AddElement<ClientData>()
.AddAttribute(0, "fLocksWithSheet", a => a.LockWithSheet)
.AddAttribute(0, "fPrintsWithSheet", a => a.PrintWithSheet);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClientData>(deep);
    }

    /// <summary>
    /// <para>Defines the Extent Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:ext.</para>
    /// </summary>
    public partial class Extent : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Extent class.
        /// </summary>
        public Extent() : base()
        {
        }

        /// <summary>
        /// <para>Extent Length</para>
        /// <para>Represents the following attribute in the schema: cx</para>
        /// </summary>
        public Int64Value Cx
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extent Width</para>
        /// <para>Represents the following attribute in the schema: cy</para>
        /// </summary>
        public Int64Value Cy
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "ext");
            builder.AddElement<Extent>()
.AddAttribute(0, "cx", a => a.Cx, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
   aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(0, "cy", a => a.Cy, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
   aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extent>(deep);
    }

    /// <summary>
    /// <para>Position.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:pos.</para>
    /// </summary>
    public partial class Position : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Position class.
        /// </summary>
        public Position() : base()
        {
        }

        /// <summary>
        /// <para>X-Axis Coordinate</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        public Int64Value X
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Y-Axis Coordinate</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>
        public Int64Value Y
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "pos");
            builder.AddElement<Position>()
.AddAttribute(0, "x", a => a.X, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
   aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "y", a => a.Y, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
   aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Position>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cNvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnClick &lt;a:hlinkClick></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnHover &lt;a:hlinkHover></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class.
        /// </summary>
        public NonVisualDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public UInt32Value Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>descr</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        public BooleanValue Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "cNvPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            builder.AddElement<NonVisualDrawingProperties>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "descr", a => a.Description)
.AddAttribute(0, "hidden", a => a.Hidden)
.AddAttribute(0, "title", a => a.Title);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
        }

        /// <summary>
        /// <para>HyperlinkOnClick.</para>
        /// <para>Represents the following element tag in the schema: a:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick HyperlinkOnClick
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HyperlinkOnHover.</para>
        /// <para>Represents the following element tag in the schema: a:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover HyperlinkOnHover
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualDrawingPropertiesExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList NonVisualDrawingPropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Connection Non-Visual Shape Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cNvSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ShapeLocks &lt;a:spLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualShapeDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class.
        /// </summary>
        public NonVisualShapeDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualShapeDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Text Box</para>
        /// <para>Represents the following attribute in the schema: txBox</para>
        /// </summary>
        public BooleanValue TextBox
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "cNvSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<NonVisualShapeDrawingProperties>()
.AddAttribute(0, "txBox", a => a.TextBox);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Shape Locks.</para>
        /// <para>Represents the following element tag in the schema: a:spLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ShapeLocks ShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
            set => SetElement(value);
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualShapeDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Connector Shape Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cNvCxnSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks &lt;a:cxnSpLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.StartConnection &lt;a:stCxn></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EndConnection &lt;a:endCxn></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualConnectorShapeDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class.
        /// </summary>
        public NonVisualConnectorShapeDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectorShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectorShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualConnectorShapeDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "cNvCxnSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.StartConnection>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EndConnection>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.StartConnection), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EndConnection), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Connection Shape Locks.</para>
        /// <para>Represents the following element tag in the schema: a:cxnSpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks ConnectionShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection Start.</para>
        /// <para>Represents the following element tag in the schema: a:stCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.StartConnection StartConnection
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.StartConnection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection End.</para>
        /// <para>Represents the following element tag in the schema: a:endCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EndConnection EndConnection
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EndConnection>();
            set => SetElement(value);
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectorShapeDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Picture Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cNvPicPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PictureLocks &lt;a:picLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualPictureDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class.
        /// </summary>
        public NonVisualPictureDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualPictureDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>preferRelativeResize</para>
        /// <para>Represents the following attribute in the schema: preferRelativeResize</para>
        /// </summary>
        public BooleanValue PreferRelativeResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "cNvPicPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PictureLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
            builder.AddElement<NonVisualPictureDrawingProperties>()
.AddAttribute(0, "preferRelativeResize", a => a.PreferRelativeResize);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PictureLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>PictureLocks.</para>
        /// <para>Represents the following element tag in the schema: a:picLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PictureLocks PictureLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PictureLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualPicturePropertiesExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList NonVisualPicturePropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualPictureDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Graphic Frame Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cNvGraphicFramePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GraphicFrameLocks &lt;a:graphicFrameLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualGraphicFrameDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class.
        /// </summary>
        public NonVisualGraphicFrameDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGraphicFrameDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "cNvGraphicFramePr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Graphic Frame Locks.</para>
        /// <para>Represents the following element tag in the schema: a:graphicFrameLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GraphicFrameLocks GraphicFrameLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
            set => SetElement(value);
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGraphicFrameDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Group Shape Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cNvGrpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupShapeLocks &lt;a:grpSpLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualGroupShapeDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class.
        /// </summary>
        public NonVisualGroupShapeDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGroupShapeDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "cNvGrpSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>GroupShapeLocks.</para>
        /// <para>Represents the following element tag in the schema: a:grpSpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GroupShapeLocks GroupShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualGroupDrawingShapePropsExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList NonVisualGroupDrawingShapePropsExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupShapeDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Group Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:nvGrpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;xdr:cNvPr></description></item>
    ///   <item><description>NonVisualGroupShapeDrawingProperties &lt;xdr:cNvGrpSpPr></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualGroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class.
        /// </summary>
        public NonVisualGroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGroupShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(18, "nvGrpSpPr");
            builder.AddChild<NonVisualDrawingProperties>();
            builder.AddChild<NonVisualGroupShapeDrawingProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGroupShapeDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Connection Non-Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Group Shape Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvGrpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public NonVisualGroupShapeDrawingProperties NonVisualGroupShapeDrawingProperties
        {
            get => GetElement<NonVisualGroupShapeDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Group Shape Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:grpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.TransformGroup &lt;a:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class GroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class.
        /// </summary>
        public GroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShapeProperties(string outerXml) : base(outerXml)
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
            builder.SetSchema(18, "grpSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<GroupShapeProperties>()
.AddAttribute(0, "bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TransformGroup), 0, 1),
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
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Grouped Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.TransformGroup TransformGroup
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeProperties>(deep);
    }

    /// <summary>
    /// Resizing Behaviors
    /// </summary>
    public enum EditAsValues
    {
        ///<summary>
        ///Move and Resize With Anchor Cells.
        ///<para>When the item is serialized out as xml, its value is "twoCell".</para>
        ///</summary>
        [EnumString("twoCell")]
        TwoCell,
        ///<summary>
        ///Move With Cells but Do Not Resize.
        ///<para>When the item is serialized out as xml, its value is "oneCell".</para>
        ///</summary>
        [EnumString("oneCell")]
        OneCell,
        ///<summary>
        ///Do Not Move or Resize With Underlying Rows/Columns.
        ///<para>When the item is serialized out as xml, its value is "absolute".</para>
        ///</summary>
        [EnumString("absolute")]
        Absolute,
    }
}