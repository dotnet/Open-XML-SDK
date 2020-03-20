﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
    /// <summary>
    /// <para>Defines the PivotSource Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:pivotSource.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.PivotTableName &lt;c:name></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.FormatId &lt;c:fmtId></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PivotTableName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.FormatId))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]
    [SchemaAttr(64, "pivotSource")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class PivotSource : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotSource class.
        /// </summary>
        public PivotSource() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotSource class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotSource(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotSource class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotSource(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotSource class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotSource(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Pivot Name.</para>
        /// <para>Represents the following element tag in the schema: c:name.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PivotTableName PivotTableName
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PivotTableName>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Format ID.</para>
        /// <para>Represents the following element tag in the schema: c:fmtId.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.FormatId FormatId
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.FormatId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PivotTableName), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.FormatId), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotSource>(deep);
    }

    /// <summary>
    /// <para>Defines the NumberingFormat Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:numFmt.</para>
    /// </summary>
    [SchemaAttr(64, "numFmt")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class NumberingFormat : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberingFormat class.
        /// </summary>
        public NumberingFormat() : base()
        {
        }

        /// <summary>
        /// <para>Number Format Code</para>
        /// <para>Represents the following attribute in the schema: formatCode</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "formatCode")]
        [Index(0)]
        public StringValue FormatCode { get; set; }

        /// <summary>
        /// <para>Linked to Source</para>
        /// <para>Represents the following attribute in the schema: sourceLinked</para>
        /// </summary>
        [SchemaAttr(0, "sourceLinked")]
        [Index(1)]
        public BooleanValue SourceLinked { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberingFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:spPr.</para>
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
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Transform2D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Outline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList))]
    [SchemaAttr(64, "spPr")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
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
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bwMode")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }

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

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the Layout Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:layout.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ManualLayout &lt;c:manualLayout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]
    [SchemaAttr(64, "layout")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class Layout : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Layout class.
        /// </summary>
        public Layout() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Layout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Layout(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Layout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Layout(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Layout class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Layout(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Manual Layout.</para>
        /// <para>Represents the following element tag in the schema: c:manualLayout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ManualLayout ManualLayout
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Layout>(deep);
    }

    /// <summary>
    /// <para>Defines the FullReference Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:fullRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SequenceOfReferences &lt;c15:sqref></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SequenceOfReferences), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "fullRef")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FullReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FullReference class.
        /// </summary>
        public FullReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FullReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FullReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FullReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FullReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FullReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FullReference(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>SequenceOfReferences.</para>
        /// <para>Represents the following element tag in the schema: c15:sqref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public SequenceOfReferences SequenceOfReferences
        {
            get => GetElement<SequenceOfReferences>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FullReference>(deep);
    }

    /// <summary>
    /// <para>Defines the LevelReference Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:levelRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SequenceOfReferences &lt;c15:sqref></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SequenceOfReferences), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "levelRef")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class LevelReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LevelReference class.
        /// </summary>
        public LevelReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LevelReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LevelReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LevelReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LevelReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LevelReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LevelReference(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>SequenceOfReferences.</para>
        /// <para>Represents the following element tag in the schema: c15:sqref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public SequenceOfReferences SequenceOfReferences
        {
            get => GetElement<SequenceOfReferences>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LevelReference>(deep);
    }

    /// <summary>
    /// <para>Defines the FormulaReference Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:formulaRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SequenceOfReferences &lt;c15:sqref></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SequenceOfReferences), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "formulaRef")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FormulaReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FormulaReference class.
        /// </summary>
        public FormulaReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FormulaReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FormulaReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FormulaReference(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>SequenceOfReferences.</para>
        /// <para>Represents the following element tag in the schema: c15:sqref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public SequenceOfReferences SequenceOfReferences
        {
            get => GetElement<SequenceOfReferences>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaReference>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredSeriesTitle Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredSeriesTitle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartText &lt;c15:tx></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ChartText), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "filteredSeriesTitle")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FilteredSeriesTitle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredSeriesTitle class.
        /// </summary>
        public FilteredSeriesTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredSeriesTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredSeriesTitle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredSeriesTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredSeriesTitle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredSeriesTitle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredSeriesTitle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ChartText.</para>
        /// <para>Represents the following element tag in the schema: c15:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public ChartText ChartText
        {
            get => GetElement<ChartText>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredSeriesTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredCategoryTitle Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredCategoryTitle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AxisDataSourceType &lt;c15:cat></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(AxisDataSourceType), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "filteredCategoryTitle")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FilteredCategoryTitle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredCategoryTitle class.
        /// </summary>
        public FilteredCategoryTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredCategoryTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredCategoryTitle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredCategoryTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredCategoryTitle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredCategoryTitle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredCategoryTitle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>AxisDataSourceType.</para>
        /// <para>Represents the following element tag in the schema: c15:cat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public AxisDataSourceType AxisDataSourceType
        {
            get => GetElement<AxisDataSourceType>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredCategoryTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredAreaSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredAreaSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AreaChartSeries &lt;c15:ser></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(AreaChartSeries), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "filteredAreaSeries")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FilteredAreaSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredAreaSeries class.
        /// </summary>
        public FilteredAreaSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredAreaSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredAreaSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredAreaSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredAreaSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredAreaSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredAreaSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>AreaChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public AreaChartSeries AreaChartSeries
        {
            get => GetElement<AreaChartSeries>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.AreaChartSeries), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredAreaSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredBarSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredBarSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BarChartSeries &lt;c15:ser></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BarChartSeries), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "filteredBarSeries")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FilteredBarSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredBarSeries class.
        /// </summary>
        public FilteredBarSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredBarSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredBarSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredBarSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredBarSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredBarSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredBarSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>BarChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public BarChartSeries BarChartSeries
        {
            get => GetElement<BarChartSeries>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.BarChartSeries), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredBarSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredBubbleSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredBubbleSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BubbleChartSeries &lt;c15:ser></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(BubbleChartSeries), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "filteredBubbleSeries")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FilteredBubbleSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredBubbleSeries class.
        /// </summary>
        public FilteredBubbleSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredBubbleSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredBubbleSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredBubbleSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredBubbleSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredBubbleSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredBubbleSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>BubbleChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public BubbleChartSeries BubbleChartSeries
        {
            get => GetElement<BubbleChartSeries>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredBubbleSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredLineSeriesExtension Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredLineSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineChartSeries &lt;c15:ser></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(LineChartSeries), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "filteredLineSeries")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FilteredLineSeriesExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredLineSeriesExtension class.
        /// </summary>
        public FilteredLineSeriesExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredLineSeriesExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredLineSeriesExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredLineSeriesExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredLineSeriesExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredLineSeriesExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredLineSeriesExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>LineChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public LineChartSeries LineChartSeries
        {
            get => GetElement<LineChartSeries>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LineChartSeries), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredLineSeriesExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredPieSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredPieSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PieChartSeries &lt;c15:ser></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PieChartSeries), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "filteredPieSeries")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FilteredPieSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredPieSeries class.
        /// </summary>
        public FilteredPieSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredPieSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredPieSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredPieSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredPieSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredPieSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredPieSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>PieChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public PieChartSeries PieChartSeries
        {
            get => GetElement<PieChartSeries>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredPieSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredRadarSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredRadarSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RadarChartSeries &lt;c15:ser></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(RadarChartSeries), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "filteredRadarSeries")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FilteredRadarSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredRadarSeries class.
        /// </summary>
        public FilteredRadarSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredRadarSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredRadarSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredRadarSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredRadarSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredRadarSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredRadarSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>RadarChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public RadarChartSeries RadarChartSeries
        {
            get => GetElement<RadarChartSeries>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.RadarChartSeries), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredRadarSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredScatterSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredScatterSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ScatterChartSeries &lt;c15:ser></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ScatterChartSeries), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "filteredScatterSeries")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FilteredScatterSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredScatterSeries class.
        /// </summary>
        public FilteredScatterSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredScatterSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredScatterSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredScatterSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredScatterSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredScatterSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredScatterSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ScatterChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public ScatterChartSeries ScatterChartSeries
        {
            get => GetElement<ScatterChartSeries>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredScatterSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredSurfaceSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredSurfaceSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SurfaceChartSeries &lt;c15:ser></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SurfaceChartSeries), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "filteredSurfaceSeries")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FilteredSurfaceSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredSurfaceSeries class.
        /// </summary>
        public FilteredSurfaceSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredSurfaceSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredSurfaceSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredSurfaceSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredSurfaceSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredSurfaceSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredSurfaceSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>SurfaceChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public SurfaceChartSeries SurfaceChartSeries
        {
            get => GetElement<SurfaceChartSeries>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries), 1, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredSurfaceSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelsRange Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:datalabelsRange.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Formula &lt;c15:f></description></item>
    ///   <item><description>DataLabelsRangeChache &lt;c15:dlblRangeCache></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Formula), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataLabelsRangeChache), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "datalabelsRange")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataLabelsRange : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelsRange class.
        /// </summary>
        public DataLabelsRange() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelsRange class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelsRange(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelsRange class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelsRange(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelsRange class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabelsRange(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: c15:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public Formula Formula
        {
            get => GetElement<Formula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabelsRangeChache.</para>
        /// <para>Represents the following element tag in the schema: c15:dlblRangeCache.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DataLabelsRangeChache DataLabelsRangeChache
        {
            get => GetElement<DataLabelsRangeChache>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelsRange>(deep);
    }

    /// <summary>
    /// <para>Defines the CategoryFilterExceptions Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:categoryFilterExceptions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CategoryFilterException &lt;c15:categoryFilterException></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CategoryFilterException), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "categoryFilterExceptions")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class CategoryFilterExceptions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CategoryFilterExceptions class.
        /// </summary>
        public CategoryFilterExceptions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryFilterExceptions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryFilterExceptions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterExceptions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CategoryFilterExceptions(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException), 1, 0, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryFilterExceptions>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelFieldTable Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:dlblFieldTable.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DataLabelFieldTableEntry &lt;c15:dlblFTEntry></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DataLabelFieldTableEntry), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "dlblFieldTable")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataLabelFieldTable : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTable class.
        /// </summary>
        public DataLabelFieldTable() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTable class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelFieldTable(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTable class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelFieldTable(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTable class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabelFieldTable(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry), 0, 0, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelFieldTable>(deep);
    }

    /// <summary>
    /// <para>Defines the ExceptionForSave Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:xForSave.</para>
    /// </summary>
    [SchemaAttr(64, "xForSave")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ExceptionForSave : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ExceptionForSave class.
        /// </summary>
        public ExceptionForSave() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExceptionForSave>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowDataLabelsRange Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:showDataLabelsRange.</para>
    /// </summary>
    [SchemaAttr(64, "showDataLabelsRange")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ShowDataLabelsRange : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowDataLabelsRange class.
        /// </summary>
        public ShowDataLabelsRange() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowDataLabelsRange>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowLeaderLines Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:showLeaderLines.</para>
    /// </summary>
    [SchemaAttr(64, "showLeaderLines")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ShowLeaderLines : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowLeaderLines class.
        /// </summary>
        public ShowLeaderLines() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowLeaderLines>(deep);
    }

    /// <summary>
    /// <para>Defines the AutoGeneneratedCategories Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:autoCat.</para>
    /// </summary>
    [SchemaAttr(64, "autoCat")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class AutoGeneneratedCategories : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the AutoGeneneratedCategories class.
        /// </summary>
        public AutoGeneneratedCategories() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoGeneneratedCategories>(deep);
    }

    /// <summary>
    /// <para>Defines the InvertIfNegativeBoolean Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:invertIfNegative.</para>
    /// </summary>
    [SchemaAttr(64, "invertIfNegative")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class InvertIfNegativeBoolean : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the InvertIfNegativeBoolean class.
        /// </summary>
        public InvertIfNegativeBoolean() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InvertIfNegativeBoolean>(deep);
    }

    /// <summary>
    /// <para>Defines the Bubble3D Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:bubble3D.</para>
    /// </summary>
    [SchemaAttr(64, "bubble3D")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class Bubble3D : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the Bubble3D class.
        /// </summary>
        public Bubble3D() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bubble3D>(deep);
    }

    /// <summary>
    /// <para>Defines the BooleanType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class BooleanType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BooleanType class.
        /// </summary>
        protected BooleanType() : base()
        {
        }

        /// <summary>
        /// <para>Boolean Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr(0, "val")]
        [Index(0)]
        public BooleanValue Val { get; set; }
    }

    /// <summary>
    /// <para>Defines the ChartText Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:tx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.StringReference &lt;c:strRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.RichText &lt;c:rich></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.StringLiteral &lt;c:strLit></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.RichText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral))]
    [SchemaAttr(64, "tx")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ChartText : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartText class.
        /// </summary>
        public ChartText() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartText class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartText(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartText class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartText(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartText class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartText(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>String Reference.</para>
        /// <para>Represents the following element tag in the schema: c:strRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.StringReference StringReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Rich Text.</para>
        /// <para>Represents the following element tag in the schema: c:rich.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.RichText RichText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.RichText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>String Literal.</para>
        /// <para>Represents the following element tag in the schema: c:strLit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.StringLiteral StringLiteral
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RichText), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral), 1, 1)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartText>(deep);
    }

    /// <summary>
    /// <para>Defines the LeaderLines Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:leaderLines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [SchemaAttr(64, "leaderLines")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class LeaderLines : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LeaderLines class.
        /// </summary>
        public LeaderLines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LeaderLines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LeaderLines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LeaderLines(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeaderLines>(deep);
    }

    /// <summary>
    /// <para>Defines the SequenceOfReferences Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:sqref.</para>
    /// </summary>
    [SchemaAttr(64, "sqref")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class SequenceOfReferences : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SequenceOfReferences class.
        /// </summary>
        public SequenceOfReferences() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SequenceOfReferences class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SequenceOfReferences(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SequenceOfReferences>(deep);
    }

    /// <summary>
    /// <para>Defines the Formula Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:f.</para>
    /// </summary>
    [SchemaAttr(64, "f")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);
    }

    /// <summary>
    /// <para>Defines the TextFieldGuid Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:txfldGUID.</para>
    /// </summary>
    [SchemaAttr(64, "txfldGUID")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class TextFieldGuid : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the TextFieldGuid class.
        /// </summary>
        public TextFieldGuid() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextFieldGuid class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public TextFieldGuid(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextFieldGuid>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisDataSourceType Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:cat.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference &lt;c:multiLvlStrRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.NumberReference &lt;c:numRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral &lt;c:numLit></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.StringReference &lt;c:strRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.StringLiteral &lt;c:strLit></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral))]
    [SchemaAttr(64, "cat")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class AxisDataSourceType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AxisDataSourceType class.
        /// </summary>
        public AxisDataSourceType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisDataSourceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisDataSourceType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisDataSourceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisDataSourceType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisDataSourceType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AxisDataSourceType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Multi Level String Reference.</para>
        /// <para>Represents the following element tag in the schema: c:multiLvlStrRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference MultiLevelStringReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Reference.</para>
        /// <para>Represents the following element tag in the schema: c:numRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.NumberReference NumberReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Literal.</para>
        /// <para>Represents the following element tag in the schema: c:numLit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral NumberLiteral
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>StringReference.</para>
        /// <para>Represents the following element tag in the schema: c:strRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.StringReference StringReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>String Literal.</para>
        /// <para>Represents the following element tag in the schema: c:strLit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.StringLiteral StringLiteral
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral), 1, 1)
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisDataSourceType>(deep);
    }

    /// <summary>
    /// <para>Defines the BarChartSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative &lt;c:invertIfNegative></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Shape &lt;c:shape></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Shape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList))]
    [SchemaAttr(64, "ser")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class BarChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BarChartSeries class.
        /// </summary>
        public BarChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BarChartSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>InvertIfNegative.</para>
        /// <para>Represents the following element tag in the schema: c:invertIfNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative InvertIfNegative
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Shape), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the LineChartSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Marker &lt;c:marker></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Smooth &lt;c:smooth></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList))]
    [SchemaAttr(64, "ser")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class LineChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LineChartSeries class.
        /// </summary>
        public LineChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineChartSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Marker Marker
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the ScatterChartSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Marker &lt;c:marker></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.XValues &lt;c:xVal></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.YValues &lt;c:yVal></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Smooth &lt;c:smooth></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.XValues))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.YValues))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList))]
    [SchemaAttr(64, "ser")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ScatterChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ScatterChartSeries class.
        /// </summary>
        public ScatterChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ScatterChartSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Marker Marker
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 2),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.XValues), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.YValues), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the AreaChartSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList))]
    [SchemaAttr(64, "ser")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class AreaChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AreaChartSeries class.
        /// </summary>
        public AreaChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AreaChartSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 2),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the PieChartSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Explosion &lt;c:explosion></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Explosion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList))]
    [SchemaAttr(64, "ser")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class PieChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PieChartSeries class.
        /// </summary>
        public PieChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PieChartSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Explosion.</para>
        /// <para>Represents the following element tag in the schema: c:explosion.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Explosion Explosion
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Explosion>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Explosion), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the BubbleChartSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative &lt;c:invertIfNegative></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.XValues &lt;c:xVal></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.YValues &lt;c:yVal></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.BubbleSize &lt;c:bubbleSize></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Bubble3D &lt;c:bubble3D></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.XValues))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.YValues))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList))]
    [SchemaAttr(64, "ser")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class BubbleChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BubbleChartSeries class.
        /// </summary>
        public BubbleChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BubbleChartSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>InvertIfNegative.</para>
        /// <para>Represents the following element tag in the schema: c:invertIfNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative InvertIfNegative
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 2),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.XValues), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.YValues), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the RadarChartSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Marker &lt;c:marker></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList))]
    [SchemaAttr(64, "ser")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class RadarChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RadarChartSeries class.
        /// </summary>
        public RadarChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RadarChartSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Marker Marker
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the SurfaceChartSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Bubble3D &lt;c:bubble3D></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList))]
    [SchemaAttr(64, "ser")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class SurfaceChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurfaceChartSeries class.
        /// </summary>
        public SurfaceChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurfaceChartSeries(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CategoryAxisData.</para>
        /// <para>Represents the following element tag in the schema: c:cat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData CategoryAxisData
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Values.</para>
        /// <para>Represents the following element tag in the schema: c:val.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Values Values
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Values>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bubble3D.</para>
        /// <para>Represents the following element tag in the schema: c:bubble3D.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Bubble3D Bubble3D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SurfaceSerExtensionList.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList SurfaceSerExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelsRangeChache Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:dlblRangeCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.StringPoint &lt;c:pt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(64, "dlblRangeCache")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataLabelsRangeChache : StringDataType
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelsRangeChache class.
        /// </summary>
        public DataLabelsRangeChache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelsRangeChache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelsRangeChache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelsRangeChache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelsRangeChache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelsRangeChache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabelsRangeChache(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelsRangeChache>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelFieldTableCache Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:dlblFieldTableCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.StringPoint &lt;c:pt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(64, "dlblFieldTableCache")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataLabelFieldTableCache : StringDataType
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableCache class.
        /// </summary>
        public DataLabelFieldTableCache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelFieldTableCache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelFieldTableCache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableCache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabelFieldTableCache(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint), 0, 0),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelFieldTableCache>(deep);
    }

    /// <summary>
    /// <para>Defines the StringDataType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.StringPoint &lt;c:pt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList))]
    public abstract partial class StringDataType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StringDataType class.
        /// </summary>
        protected StringDataType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StringDataType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StringDataType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDataType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected StringDataType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>PointCount.</para>
        /// <para>Represents the following element tag in the schema: c:ptCount.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PointCount PointCount
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    }

    /// <summary>
    /// <para>Defines the Explosion Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:explosion.</para>
    /// </summary>
    [SchemaAttr(64, "explosion")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class Explosion : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Explosion class.
        /// </summary>
        public Explosion() : base()
        {
        }

        /// <summary>
        /// <para>Integer Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public UInt32Value Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Explosion>(deep);
    }

    /// <summary>
    /// <para>Defines the Marker Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:marker.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Symbol &lt;c:symbol></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Size &lt;c:size></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Symbol))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Size))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]
    [SchemaAttr(64, "marker")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class Marker : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Marker class.
        /// </summary>
        public Marker() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Marker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Marker(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Marker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Marker(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Marker class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Marker(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Symbol.</para>
        /// <para>Represents the following element tag in the schema: c:symbol.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Symbol Symbol
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Symbol>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Size.</para>
        /// <para>Represents the following element tag in the schema: c:size.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Size Size
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Size>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Symbol), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Size), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Marker>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabel Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:dLbl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Delete &lt;c:delete></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Layout &lt;c:layout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartText &lt;c:tx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat &lt;c:numFmt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.TextProperties &lt;c:txPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition &lt;c:dLblPos></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey &lt;c:showLegendKey></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowValue &lt;c:showVal></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName &lt;c:showCatName></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName &lt;c:showSerName></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowPercent &lt;c:showPercent></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize &lt;c:showBubbleSize></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.Separator &lt;c:separator></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowValue))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowPercent))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Separator))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList))]
    [SchemaAttr(64, "dLbl")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
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
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
            new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete), 1, 1),
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartText), 0, 1),
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Sequence, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat), 0, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition), 0, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey), 0, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowValue), 0, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName), 0, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName), 0, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowPercent), 0, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize), 0, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Separator), 0, 1)
                            }
                        }
                    }
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the CategoryFilterException Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:categoryFilterException.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SequenceOfReferences &lt;c15:sqref></description></item>
    ///   <item><description>ShapeProperties &lt;c15:spPr></description></item>
    ///   <item><description>Explosion &lt;c15:explosion></description></item>
    ///   <item><description>InvertIfNegativeBoolean &lt;c15:invertIfNegative></description></item>
    ///   <item><description>Bubble3D &lt;c15:bubble3D></description></item>
    ///   <item><description>Marker &lt;c15:marker></description></item>
    ///   <item><description>DataLabel &lt;c15:dLbl></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SequenceOfReferences), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(Explosion), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(InvertIfNegativeBoolean), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(Bubble3D), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(Marker), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataLabel), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "categoryFilterException")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class CategoryFilterException : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CategoryFilterException class.
        /// </summary>
        public CategoryFilterException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterException class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryFilterException(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterException class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryFilterException(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterException class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CategoryFilterException(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>SequenceOfReferences.</para>
        /// <para>Represents the following element tag in the schema: c15:sqref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public SequenceOfReferences SequenceOfReferences
        {
            get => GetElement<SequenceOfReferences>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c15:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Explosion.</para>
        /// <para>Represents the following element tag in the schema: c15:explosion.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public Explosion Explosion
        {
            get => GetElement<Explosion>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>InvertIfNegativeBoolean.</para>
        /// <para>Represents the following element tag in the schema: c15:invertIfNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public InvertIfNegativeBoolean InvertIfNegativeBoolean
        {
            get => GetElement<InvertIfNegativeBoolean>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bubble3D.</para>
        /// <para>Represents the following element tag in the schema: c15:bubble3D.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public Bubble3D Bubble3D
        {
            get => GetElement<Bubble3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c15:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public Marker Marker
        {
            get => GetElement<Marker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabel.</para>
        /// <para>Represents the following element tag in the schema: c15:dLbl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DataLabel DataLabel
        {
            get => GetElement<DataLabel>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Explosion), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.InvertIfNegativeBoolean), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Bubble3D), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryFilterException>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelFieldTableEntry Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:dlblFTEntry.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TextFieldGuid &lt;c15:txfldGUID></description></item>
    ///   <item><description>Formula &lt;c15:f></description></item>
    ///   <item><description>DataLabelFieldTableCache &lt;c15:dlblFieldTableCache></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TextFieldGuid), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(Formula), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataLabelFieldTableCache), FileFormatVersions.Office2013)]
    [SchemaAttr(64, "dlblFTEntry")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataLabelFieldTableEntry : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableEntry class.
        /// </summary>
        public DataLabelFieldTableEntry() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelFieldTableEntry(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelFieldTableEntry(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableEntry class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabelFieldTableEntry(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>TextFieldGuid.</para>
        /// <para>Represents the following element tag in the schema: c15:txfldGUID.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public TextFieldGuid TextFieldGuid
        {
            get => GetElement<TextFieldGuid>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: c15:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public Formula Formula
        {
            get => GetElement<Formula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabelFieldTableCache.</para>
        /// <para>Represents the following element tag in the schema: c15:dlblFieldTableCache.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DataLabelFieldTableCache DataLabelFieldTableCache
        {
            get => GetElement<DataLabelFieldTableCache>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.TextFieldGuid), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelFieldTableEntry>(deep);
    }
}