﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Office.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
    /// <summary>
    /// <para>Defines the ConditionalFormattings Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:conditionalFormattings.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ConditionalFormatting &lt;x14:conditionalFormatting></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ConditionalFormatting), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "conditionalFormattings")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ConditionalFormattings : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConditionalFormattings class.
        /// </summary>
        public ConditionalFormattings() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormattings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConditionalFormattings(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormattings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConditionalFormattings(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormattings class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConditionalFormattings(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormatting), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormattings>(deep);
    }

    /// <summary>
    /// <para>Defines the DataValidations Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:dataValidations.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DataValidation &lt;x14:dataValidation></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DataValidation), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "dataValidations")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DataValidations : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataValidations class.
        /// </summary>
        public DataValidations() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidations class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataValidations(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidations class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataValidations(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidations class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataValidations(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>disablePrompts, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: disablePrompts</para>
        /// </summary>
        [SchemaAttr(0, "disablePrompts")]
        [Index(0)]
        public BooleanValue DisablePrompts { get; set; }

        /// <summary>
        /// <para>xWindow, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: xWindow</para>
        /// </summary>
        [SchemaAttr(0, "xWindow")]
        [Index(1)]
        public UInt32Value XWindow { get; set; }

        /// <summary>
        /// <para>yWindow, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: yWindow</para>
        /// </summary>
        [SchemaAttr(0, "yWindow")]
        [Index(2)]
        public UInt32Value YWindow { get; set; }

        /// <summary>
        /// <para>count, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr(0, "count")]
        [Index(3)]
        public UInt32Value Count { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DataValidation), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataValidations>(deep);
    }

    /// <summary>
    /// <para>Defines the SparklineGroups Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:sparklineGroups.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SparklineGroup &lt;x14:sparklineGroup></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SparklineGroup), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "sparklineGroups")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SparklineGroups : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SparklineGroups class.
        /// </summary>
        public SparklineGroups() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SparklineGroups class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SparklineGroups(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SparklineGroups class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SparklineGroups(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SparklineGroups class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SparklineGroups(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SparklineGroup), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SparklineGroups>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerList Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicerList.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlicerRef &lt;x14:slicer></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlicerRef), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "slicerList")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerList class.
        /// </summary>
        public SlicerList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerRef), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerList>(deep);
    }

    /// <summary>
    /// <para>Defines the ProtectedRanges Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:protectedRanges.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ProtectedRange &lt;x14:protectedRange></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ProtectedRange), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "protectedRanges")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ProtectedRanges : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ProtectedRanges class.
        /// </summary>
        public ProtectedRanges() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ProtectedRanges class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ProtectedRanges(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ProtectedRanges class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ProtectedRanges(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ProtectedRanges class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ProtectedRanges(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ProtectedRange), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ProtectedRanges>(deep);
    }

    /// <summary>
    /// <para>Defines the IgnoredErrors Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:ignoredErrors.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>IgnoredError &lt;x14:ignoredError></description></item>
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(IgnoredError), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "ignoredErrors")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class IgnoredErrors : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the IgnoredErrors class.
        /// </summary>
        public IgnoredErrors() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the IgnoredErrors class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public IgnoredErrors(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IgnoredErrors class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public IgnoredErrors(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IgnoredErrors class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public IgnoredErrors(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.IgnoredError), 0, 0, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IgnoredErrors>(deep);
    }

    /// <summary>
    /// <para>Defines the DefinedNames Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:definedNames.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DefinedName &lt;x14:definedName></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DefinedName), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "definedNames")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DefinedNames : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DefinedNames class.
        /// </summary>
        public DefinedNames() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DefinedNames class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DefinedNames(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DefinedNames class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DefinedNames(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DefinedNames class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DefinedNames(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DefinedName), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefinedNames>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotCaches Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotCaches.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PivotCache &lt;x:pivotCache></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotCache))]
    [SchemaAttr(53, "pivotCaches")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotCaches : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotCaches class.
        /// </summary>
        public PivotCaches() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotCaches class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotCaches(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotCaches class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotCaches(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotCaches class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotCaches(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotCache), 1, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCaches>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCaches Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicerCaches.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlicerCache &lt;x14:slicerCache></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlicerCache), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "slicerCaches")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerCaches : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCaches class.
        /// </summary>
        public SlicerCaches() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCaches class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCaches(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCaches class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCaches(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCaches class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerCaches(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCache), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCaches>(deep);
    }

    /// <summary>
    /// <para>Defines the WorkbookProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:workbookPr.</para>
    /// </summary>
    [SchemaAttr(53, "workbookPr")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class WorkbookProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the WorkbookProperties class.
        /// </summary>
        public WorkbookProperties() : base()
        {
        }

        /// <summary>
        /// <para>defaultImageDpi, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: defaultImageDpi</para>
        /// </summary>
        [SchemaAttr(0, "defaultImageDpi")]
        [Index(0)]
        public UInt32Value DefaultImageDpi { get; set; }

        /// <summary>
        /// <para>discardImageEditData, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: discardImageEditData</para>
        /// </summary>
        [SchemaAttr(0, "discardImageEditData")]
        [Index(1)]
        public BooleanValue DiscardImageEditData { get; set; }

        /// <summary>
        /// <para>accuracyVersion, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: accuracyVersion</para>
        /// </summary>
        [SchemaAttr(0, "accuracyVersion")]
        [Index(2)]
        public UInt32Value AccuracyVersion { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WorkbookProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the CalculatedMember Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:calculatedMember.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TupleSet &lt;x14:tupleSet></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TupleSet), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "calculatedMember")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class CalculatedMember : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CalculatedMember class.
        /// </summary>
        public CalculatedMember() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CalculatedMember class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CalculatedMember(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CalculatedMember class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CalculatedMember(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CalculatedMember class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CalculatedMember(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>displayFolder, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: displayFolder</para>
        /// </summary>
        [SchemaAttr(0, "displayFolder")]
        [Index(0)]
        public StringValue DisplayFolder { get; set; }

        /// <summary>
        /// <para>flattenHierarchies, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: flattenHierarchies</para>
        /// </summary>
        [SchemaAttr(0, "flattenHierarchies")]
        [Index(1)]
        public BooleanValue FlattenHierarchies { get; set; }

        /// <summary>
        /// <para>dynamicSet, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dynamicSet</para>
        /// </summary>
        [SchemaAttr(0, "dynamicSet")]
        [Index(2)]
        public BooleanValue DynamicSet { get; set; }

        /// <summary>
        /// <para>hierarchizeDistinct, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hierarchizeDistinct</para>
        /// </summary>
        [SchemaAttr(0, "hierarchizeDistinct")]
        [Index(3)]
        public BooleanValue HierarchizeDistinct { get; set; }

        /// <summary>
        /// <para>mdxLong, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: mdxLong</para>
        /// </summary>
        [SchemaAttr(0, "mdxLong")]
        [Index(4)]
        public StringValue MdxLong { get; set; }

        /// <summary>
        /// <para>TupleSet.</para>
        /// <para>Represents the following element tag in the schema: x14:tupleSet.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public TupleSet TupleSet
        {
            get => GetElement<TupleSet>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleSet), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CalculatedMember>(deep);
    }

    /// <summary>
    /// <para>Defines the CacheHierarchy Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:cacheHierarchy.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SetLevels &lt;x14:setLevels></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SetLevels), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "cacheHierarchy")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class CacheHierarchy : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CacheHierarchy class.
        /// </summary>
        public CacheHierarchy() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CacheHierarchy class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CacheHierarchy(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CacheHierarchy class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CacheHierarchy(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CacheHierarchy class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CacheHierarchy(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>flattenHierarchies, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: flattenHierarchies</para>
        /// </summary>
        [SchemaAttr(0, "flattenHierarchies")]
        [Index(0)]
        public BooleanValue FlattenHierarchies { get; set; }

        /// <summary>
        /// <para>measuresSet, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: measuresSet</para>
        /// </summary>
        [SchemaAttr(0, "measuresSet")]
        [Index(1)]
        public BooleanValue MeasuresSet { get; set; }

        /// <summary>
        /// <para>hierarchizeDistinct, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hierarchizeDistinct</para>
        /// </summary>
        [SchemaAttr(0, "hierarchizeDistinct")]
        [Index(2)]
        public BooleanValue HierarchizeDistinct { get; set; }

        /// <summary>
        /// <para>ignore, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: ignore</para>
        /// </summary>
        [SchemaAttr(0, "ignore")]
        [Index(3)]
        public BooleanValue Ignore { get; set; }

        /// <summary>
        /// <para>SetLevels.</para>
        /// <para>Represents the following element tag in the schema: x14:setLevels.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public SetLevels SetLevels
        {
            get => GetElement<SetLevels>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SetLevels), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CacheHierarchy>(deep);
    }

    /// <summary>
    /// <para>Defines the DataField Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:dataField.</para>
    /// </summary>
    [SchemaAttr(53, "dataField")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DataField : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataField class.
        /// </summary>
        public DataField() : base()
        {
        }

        /// <summary>
        /// <para>pivotShowAs, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pivotShowAs</para>
        /// </summary>
        [SchemaAttr(0, "pivotShowAs")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.PivotShowAsValues> PivotShowAs { get; set; }

        /// <summary>
        /// <para>sourceField, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sourceField</para>
        /// </summary>
        [SchemaAttr(0, "sourceField")]
        [Index(1)]
        public UInt32Value SourceField { get; set; }

        /// <summary>
        /// <para>uniqueName, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: uniqueName</para>
        /// </summary>
        [SchemaAttr(0, "uniqueName")]
        [Index(2)]
        public StringValue UniqueName { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataField>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotField Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotField.</para>
    /// </summary>
    [SchemaAttr(53, "pivotField")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotField : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotField class.
        /// </summary>
        public PivotField() : base()
        {
        }

        /// <summary>
        /// <para>fillDownLabels, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fillDownLabels</para>
        /// </summary>
        [SchemaAttr(0, "fillDownLabels")]
        [Index(0)]
        public BooleanValue FillDownLabels { get; set; }

        /// <summary>
        /// <para>ignore, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: ignore</para>
        /// </summary>
        [SchemaAttr(0, "ignore")]
        [Index(1)]
        public BooleanValue Ignore { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotField>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotTableDefinition Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotTableDefinition.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PivotEdits &lt;x14:pivotEdits></description></item>
    ///   <item><description>PivotChanges &lt;x14:pivotChanges></description></item>
    ///   <item><description>ConditionalFormats &lt;x14:conditionalFormats></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PivotEdits), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(PivotChanges), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ConditionalFormats), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "pivotTableDefinition")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotTableDefinition : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableDefinition class.
        /// </summary>
        public PivotTableDefinition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableDefinition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableDefinition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableDefinition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotTableDefinition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>fillDownLabelsDefault, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fillDownLabelsDefault</para>
        /// </summary>
        [SchemaAttr(0, "fillDownLabelsDefault")]
        [Index(0)]
        public BooleanValue FillDownLabelsDefault { get; set; }

        /// <summary>
        /// <para>visualTotalsForSets, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visualTotalsForSets</para>
        /// </summary>
        [SchemaAttr(0, "visualTotalsForSets")]
        [Index(1)]
        public BooleanValue VisualTotalsForSets { get; set; }

        /// <summary>
        /// <para>calculatedMembersInFilters, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: calculatedMembersInFilters</para>
        /// </summary>
        [SchemaAttr(0, "calculatedMembersInFilters")]
        [Index(2)]
        public BooleanValue CalculatedMembersInFilters { get; set; }

        /// <summary>
        /// <para>altText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: altText</para>
        /// </summary>
        [SchemaAttr(0, "altText")]
        [Index(3)]
        public StringValue AltText { get; set; }

        /// <summary>
        /// <para>altTextSummary, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: altTextSummary</para>
        /// </summary>
        [SchemaAttr(0, "altTextSummary")]
        [Index(4)]
        public StringValue AltTextSummary { get; set; }

        /// <summary>
        /// <para>enableEdit, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enableEdit</para>
        /// </summary>
        [SchemaAttr(0, "enableEdit")]
        [Index(5)]
        public BooleanValue EnableEdit { get; set; }

        /// <summary>
        /// <para>autoApply, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: autoApply</para>
        /// </summary>
        [SchemaAttr(0, "autoApply")]
        [Index(6)]
        public BooleanValue AutoApply { get; set; }

        /// <summary>
        /// <para>allocationMethod, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: allocationMethod</para>
        /// </summary>
        [SchemaAttr(0, "allocationMethod")]
        [Index(7)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.AllocationMethodValues> AllocationMethod { get; set; }

        /// <summary>
        /// <para>weightExpression, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: weightExpression</para>
        /// </summary>
        [SchemaAttr(0, "weightExpression")]
        [Index(8)]
        public StringValue WeightExpression { get; set; }

        /// <summary>
        /// <para>hideValuesRow, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hideValuesRow</para>
        /// </summary>
        [SchemaAttr(0, "hideValuesRow")]
        [Index(9)]
        public BooleanValue HideValuesRow { get; set; }

        /// <summary>
        /// <para>PivotEdits.</para>
        /// <para>Represents the following element tag in the schema: x14:pivotEdits.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public PivotEdits PivotEdits
        {
            get => GetElement<PivotEdits>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotChanges.</para>
        /// <para>Represents the following element tag in the schema: x14:pivotChanges.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public PivotChanges PivotChanges
        {
            get => GetElement<PivotChanges>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ConditionalFormats.</para>
        /// <para>Represents the following element tag in the schema: x14:conditionalFormats.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public ConditionalFormats ConditionalFormats
        {
            get => GetElement<ConditionalFormats>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotEdits), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotChanges), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormats), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableDefinition>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotCacheDefinition Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotCacheDefinition.</para>
    /// </summary>
    [SchemaAttr(53, "pivotCacheDefinition")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotCacheDefinition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotCacheDefinition class.
        /// </summary>
        public PivotCacheDefinition() : base()
        {
        }

        /// <summary>
        /// <para>slicerData, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: slicerData</para>
        /// </summary>
        [SchemaAttr(0, "slicerData")]
        [Index(0)]
        public BooleanValue SlicerData { get; set; }

        /// <summary>
        /// <para>pivotCacheId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pivotCacheId</para>
        /// </summary>
        [SchemaAttr(0, "pivotCacheId")]
        [Index(1)]
        public UInt32Value PivotCacheId { get; set; }

        /// <summary>
        /// <para>supportSubqueryNonVisual, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supportSubqueryNonVisual</para>
        /// </summary>
        [SchemaAttr(0, "supportSubqueryNonVisual")]
        [Index(2)]
        public BooleanValue SupportSubqueryNonVisual { get; set; }

        /// <summary>
        /// <para>supportSubqueryCalcMem, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supportSubqueryCalcMem</para>
        /// </summary>
        [SchemaAttr(0, "supportSubqueryCalcMem")]
        [Index(3)]
        public BooleanValue SupportSubqueryCalcMem { get; set; }

        /// <summary>
        /// <para>supportAddCalcMems, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supportAddCalcMems</para>
        /// </summary>
        [SchemaAttr(0, "supportAddCalcMems")]
        [Index(4)]
        public BooleanValue SupportAddCalcMems { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCacheDefinition>(deep);
    }

    /// <summary>
    /// <para>Defines the Connection Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:connection.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CalculatedMembers &lt;x14:calculatedMembers></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CalculatedMembers), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "connection")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Connection : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Connection class.
        /// </summary>
        public Connection() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Connection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Connection(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Connection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Connection(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Connection class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Connection(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>culture, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: culture</para>
        /// </summary>
        [SchemaAttr(0, "culture")]
        [Index(0)]
        public StringValue Culture { get; set; }

        /// <summary>
        /// <para>embeddedDataId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: embeddedDataId</para>
        /// </summary>
        [SchemaAttr(0, "embeddedDataId")]
        [Index(1)]
        public StringValue EmbeddedDataId { get; set; }

        /// <summary>
        /// <para>CalculatedMembers.</para>
        /// <para>Represents the following element tag in the schema: x14:calculatedMembers.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public CalculatedMembers CalculatedMembers
        {
            get => GetElement<CalculatedMembers>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.CalculatedMembers), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Connection>(deep);
    }

    /// <summary>
    /// <para>Defines the Table Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:table.</para>
    /// </summary>
    [SchemaAttr(53, "table")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Table : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table() : base()
        {
        }

        /// <summary>
        /// <para>altText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: altText</para>
        /// </summary>
        [SchemaAttr(0, "altText")]
        [Index(0)]
        public StringValue AltText { get; set; }

        /// <summary>
        /// <para>altTextSummary, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: altTextSummary</para>
        /// </summary>
        [SchemaAttr(0, "altTextSummary")]
        [Index(1)]
        public StringValue AltTextSummary { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Table>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerStyles Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicerStyles.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlicerStyle &lt;x14:slicerStyle></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlicerStyle), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "slicerStyles")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerStyles : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerStyles class.
        /// </summary>
        public SlicerStyles() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerStyles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerStyles(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerStyles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerStyles(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerStyles class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerStyles(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>defaultSlicerStyle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: defaultSlicerStyle</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "defaultSlicerStyle")]
        [Index(0)]
        public StringValue DefaultSlicerStyle { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerStyle), 0, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerStyles>(deep);
    }

    /// <summary>
    /// <para>Defines the DifferentialFormats Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:dxfs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat &lt;x:dxf></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat))]
    [SchemaAttr(53, "dxfs")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DifferentialFormats : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DifferentialFormats class.
        /// </summary>
        public DifferentialFormats() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DifferentialFormats(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DifferentialFormats(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormats class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DifferentialFormats(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Format Count</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr(0, "count")]
        [Index(0)]
        public UInt32Value Count { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DifferentialFormats>(deep);
    }

    /// <summary>
    /// <para>Defines the OleItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:oleItem.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DdeValues &lt;x14:values></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DdeValues), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "oleItem")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class OleItem : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OleItem class.
        /// </summary>
        public OleItem() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleItem class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleItem(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleItem class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleItem(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleItem class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OleItem(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(0)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>icon, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: icon</para>
        /// </summary>
        [SchemaAttr(0, "icon")]
        [Index(1)]
        public BooleanValue Icon { get; set; }

        /// <summary>
        /// <para>advise, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: advise</para>
        /// </summary>
        [SchemaAttr(0, "advise")]
        [Index(2)]
        public BooleanValue Advise { get; set; }

        /// <summary>
        /// <para>preferPic, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: preferPic</para>
        /// </summary>
        [SchemaAttr(0, "preferPic")]
        [Index(3)]
        public BooleanValue PreferPicture { get; set; }

        /// <summary>
        /// <para>DdeValues.</para>
        /// <para>Represents the following element tag in the schema: x14:values.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DdeValues DdeValues
        {
            get => GetElement<DdeValues>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DdeValues), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OleItem>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotHierarchy Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotHierarchy.</para>
    /// </summary>
    [SchemaAttr(53, "pivotHierarchy")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotHierarchy : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotHierarchy class.
        /// </summary>
        public PivotHierarchy() : base()
        {
        }

        /// <summary>
        /// <para>ignore, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: ignore</para>
        /// </summary>
        [SchemaAttr(0, "ignore")]
        [Index(0)]
        public BooleanValue Ignore { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotHierarchy>(deep);
    }

    /// <summary>
    /// <para>Defines the CacheField Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:cacheField.</para>
    /// </summary>
    [SchemaAttr(53, "cacheField")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class CacheField : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CacheField class.
        /// </summary>
        public CacheField() : base()
        {
        }

        /// <summary>
        /// <para>ignore, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: ignore</para>
        /// </summary>
        [SchemaAttr(0, "ignore")]
        [Index(0)]
        public BooleanValue Ignore { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CacheField>(deep);
    }

    /// <summary>
    /// <para>Defines the Id Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:id.</para>
    /// </summary>
    [StringValidator(IsToken = true, Pattern = "\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}")]
    [SchemaAttr(53, "id")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Id : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Id class.
        /// </summary>
        public Id() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Id class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Id(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Id>(deep);
    }

    /// <summary>
    /// <para>Defines the IconFilter Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:iconFilter.</para>
    /// </summary>
    [SchemaAttr(53, "iconFilter")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class IconFilter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the IconFilter class.
        /// </summary>
        public IconFilter() : base()
        {
        }

        /// <summary>
        /// <para>iconSet, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: iconSet</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "iconSet")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues> IconSet { get; set; }

        /// <summary>
        /// <para>iconId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: iconId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "iconId")]
        [Index(1)]
        public UInt32Value IconId { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IconFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the Filter Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:filter.</para>
    /// </summary>
    [SchemaAttr(53, "filter")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Filter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Filter class.
        /// </summary>
        public Filter() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr(0, "val")]
        [Index(0)]
        public StringValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Filter>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomFilters Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:customFilters.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CustomFilter &lt;x14:customFilter></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(CustomFilter), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "customFilters")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class CustomFilters : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomFilters class.
        /// </summary>
        public CustomFilters() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomFilters class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomFilters(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomFilters class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomFilters(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomFilters class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomFilters(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>and, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: and</para>
        /// </summary>
        [SchemaAttr(0, "and")]
        [Index(0)]
        public BooleanValue And { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.CustomFilter), 1, 2, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomFilters>(deep);
    }

    /// <summary>
    /// <para>Defines the SortCondition Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:sortCondition.</para>
    /// </summary>
    [SchemaAttr(53, "sortCondition")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SortCondition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SortCondition class.
        /// </summary>
        public SortCondition() : base()
        {
        }

        /// <summary>
        /// <para>descending, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: descending</para>
        /// </summary>
        [SchemaAttr(0, "descending")]
        [Index(0)]
        public BooleanValue Descending { get; set; }

        /// <summary>
        /// <para>sortBy, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sortBy</para>
        /// </summary>
        [SchemaAttr(0, "sortBy")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortByValues> SortBy { get; set; }

        /// <summary>
        /// <para>ref, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "ref")]
        [Index(2)]
        public StringValue Reference { get; set; }

        /// <summary>
        /// <para>customList, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: customList</para>
        /// </summary>
        [SchemaAttr(0, "customList")]
        [Index(3)]
        public StringValue CustomList { get; set; }

        /// <summary>
        /// <para>dxfId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dxfId</para>
        /// </summary>
        [SchemaAttr(0, "dxfId")]
        [Index(4)]
        public UInt32Value FormatId { get; set; }

        /// <summary>
        /// <para>iconSet, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: iconSet</para>
        /// </summary>
        [SchemaAttr(0, "iconSet")]
        [Index(5)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues> IconSet { get; set; }

        /// <summary>
        /// <para>iconId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: iconId</para>
        /// </summary>
        [SchemaAttr(0, "iconId")]
        [Index(6)]
        public UInt32Value IconId { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SortCondition>(deep);
    }

    /// <summary>
    /// <para>Defines the SourceConnection Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:sourceConnection.</para>
    /// </summary>
    [SchemaAttr(53, "sourceConnection")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SourceConnection : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SourceConnection class.
        /// </summary>
        public SourceConnection() : base()
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(0)]
        public StringValue Name { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SourceConnection>(deep);
    }

    /// <summary>
    /// <para>Defines the DatastoreItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:datastoreItem.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "datastoreItem")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DatastoreItem : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the DatastoreItem class.
        /// </summary>
        public DatastoreItem() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DatastoreItem class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DatastoreItem(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DatastoreItem class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DatastoreItem(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DatastoreItem class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DatastoreItem(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DatastoreItem>(deep);

        internal DatastoreItem(CustomDataPropertiesPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the CustomDataPropertiesPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(CustomDataPropertiesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the CustomDataPropertiesPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(CustomDataPropertiesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the CustomDataPropertiesPart associated with this element.
        /// </summary>
        public CustomDataPropertiesPart CustomDataPropertiesPart
        {
            get => OpenXmlPart as CustomDataPropertiesPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the FormControlProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:formControlPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ListItems &lt;x14:itemLst></description></item>
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ListItems), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "formControlPr")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class FormControlProperties : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the FormControlProperties class.
        /// </summary>
        public FormControlProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormControlProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FormControlProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormControlProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FormControlProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormControlProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FormControlProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>objectType, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: objectType</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "objectType")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.ObjectTypeValues> ObjectType { get; set; }

        /// <summary>
        /// <para>checked, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: checked</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "checked")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.CheckedValues> Checked { get; set; }

        /// <summary>
        /// <para>colored, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: colored</para>
        /// </summary>
        [SchemaAttr(0, "colored")]
        [Index(2)]
        public BooleanValue Colored { get; set; }

        /// <summary>
        /// <para>dropLines, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dropLines</para>
        /// </summary>
        [SchemaAttr(0, "dropLines")]
        [Index(3)]
        public UInt32Value DropLines { get; set; }

        /// <summary>
        /// <para>dropStyle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dropStyle</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "dropStyle")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DropStyleValues> DropStyle { get; set; }

        /// <summary>
        /// <para>dx, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dx</para>
        /// </summary>
        [SchemaAttr(0, "dx")]
        [Index(5)]
        public UInt32Value ScrollBarWidth { get; set; }

        /// <summary>
        /// <para>firstButton, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: firstButton</para>
        /// </summary>
        [SchemaAttr(0, "firstButton")]
        [Index(6)]
        public BooleanValue FirstButton { get; set; }

        /// <summary>
        /// <para>fmlaGroup, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fmlaGroup</para>
        /// </summary>
        [SchemaAttr(0, "fmlaGroup")]
        [Index(7)]
        public StringValue FmlaGroup { get; set; }

        /// <summary>
        /// <para>fmlaLink, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fmlaLink</para>
        /// </summary>
        [SchemaAttr(0, "fmlaLink")]
        [Index(8)]
        public StringValue FmlaLink { get; set; }

        /// <summary>
        /// <para>fmlaRange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fmlaRange</para>
        /// </summary>
        [SchemaAttr(0, "fmlaRange")]
        [Index(9)]
        public StringValue FmlaRange { get; set; }

        /// <summary>
        /// <para>fmlaTxbx, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fmlaTxbx</para>
        /// </summary>
        [SchemaAttr(0, "fmlaTxbx")]
        [Index(10)]
        public StringValue FmlaTextbox { get; set; }

        /// <summary>
        /// <para>horiz, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: horiz</para>
        /// </summary>
        [SchemaAttr(0, "horiz")]
        [Index(11)]
        public BooleanValue Horizontal { get; set; }

        /// <summary>
        /// <para>inc, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: inc</para>
        /// </summary>
        [SchemaAttr(0, "inc")]
        [Index(12)]
        public UInt32Value Incremental { get; set; }

        /// <summary>
        /// <para>justLastX, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: justLastX</para>
        /// </summary>
        [SchemaAttr(0, "justLastX")]
        [Index(13)]
        public BooleanValue JustLastX { get; set; }

        /// <summary>
        /// <para>lockText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: lockText</para>
        /// </summary>
        [SchemaAttr(0, "lockText")]
        [Index(14)]
        public BooleanValue LockText { get; set; }

        /// <summary>
        /// <para>max, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: max</para>
        /// </summary>
        [SchemaAttr(0, "max")]
        [Index(15)]
        public UInt32Value Max { get; set; }

        /// <summary>
        /// <para>min, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: min</para>
        /// </summary>
        [SchemaAttr(0, "min")]
        [Index(16)]
        public UInt32Value Min { get; set; }

        /// <summary>
        /// <para>multiSel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: multiSel</para>
        /// </summary>
        [SchemaAttr(0, "multiSel")]
        [Index(17)]
        public StringValue MultipleSelection { get; set; }

        /// <summary>
        /// <para>noThreeD, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: noThreeD</para>
        /// </summary>
        [SchemaAttr(0, "noThreeD")]
        [Index(18)]
        public BooleanValue NoThreeD { get; set; }

        /// <summary>
        /// <para>noThreeD2, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: noThreeD2</para>
        /// </summary>
        [SchemaAttr(0, "noThreeD2")]
        [Index(19)]
        public BooleanValue NoThreeD2 { get; set; }

        /// <summary>
        /// <para>page, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: page</para>
        /// </summary>
        [SchemaAttr(0, "page")]
        [Index(20)]
        public UInt32Value Page { get; set; }

        /// <summary>
        /// <para>sel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sel</para>
        /// </summary>
        [SchemaAttr(0, "sel")]
        [Index(21)]
        public UInt32Value Selected { get; set; }

        /// <summary>
        /// <para>seltype, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: seltype</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "seltype")]
        [Index(22)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SelectionTypeValues> SelectionType { get; set; }

        /// <summary>
        /// <para>textHAlign, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: textHAlign</para>
        /// </summary>
        [SchemaAttr(0, "textHAlign")]
        [Index(23)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TextHorizontalAlignmentValues> TextHorizontalAlign { get; set; }

        /// <summary>
        /// <para>textVAlign, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: textVAlign</para>
        /// </summary>
        [SchemaAttr(0, "textVAlign")]
        [Index(24)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TextVerticalAlignmentValues> TextVerticalAlign { get; set; }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr(0, "val")]
        [Index(25)]
        public UInt32Value Val { get; set; }

        /// <summary>
        /// <para>widthMin, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: widthMin</para>
        /// </summary>
        [SchemaAttr(0, "widthMin")]
        [Index(26)]
        public UInt32Value MinimumWidth { get; set; }

        /// <summary>
        /// <para>editVal, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: editVal</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "editVal")]
        [Index(27)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.EditValidationValues> EditVal { get; set; }

        /// <summary>
        /// <para>multiLine, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: multiLine</para>
        /// </summary>
        [SchemaAttr(0, "multiLine")]
        [Index(28)]
        public BooleanValue MultipleLines { get; set; }

        /// <summary>
        /// <para>verticalBar, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: verticalBar</para>
        /// </summary>
        [SchemaAttr(0, "verticalBar")]
        [Index(29)]
        public BooleanValue VerticalBar { get; set; }

        /// <summary>
        /// <para>passwordEdit, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: passwordEdit</para>
        /// </summary>
        [SchemaAttr(0, "passwordEdit")]
        [Index(30)]
        public BooleanValue PasswordEdit { get; set; }

        /// <summary>
        /// <para>ListItems.</para>
        /// <para>Represents the following element tag in the schema: x14:itemLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public ListItems ListItems
        {
            get => GetElement<ListItems>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ListItems), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormControlProperties>(deep);

        internal FormControlProperties(ControlPropertiesPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the ControlPropertiesPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(ControlPropertiesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the ControlPropertiesPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(ControlPropertiesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the ControlPropertiesPart associated with this element.
        /// </summary>
        public ControlPropertiesPart ControlPropertiesPart
        {
            get => OpenXmlPart as ControlPropertiesPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the Slicers Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicers.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Slicer &lt;x14:slicer></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Slicer), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "slicers")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Slicers : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Slicers class.
        /// </summary>
        public Slicers() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slicers class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Slicers(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slicers class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Slicers(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slicers class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Slicers(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Slicer), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Slicers>(deep);

        internal Slicers(SlicersPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the SlicersPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(SlicersPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the SlicersPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(SlicersPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the SlicersPart associated with this element.
        /// </summary>
        public SlicersPart SlicersPart
        {
            get => OpenXmlPart as SlicersPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the SlicerCacheDefinition Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicerCacheDefinition.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlicerCachePivotTables &lt;x14:pivotTables></description></item>
    ///   <item><description>SlicerCacheData &lt;x14:data></description></item>
    ///   <item><description>SlicerCacheDefinitionExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlicerCachePivotTables), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SlicerCacheData), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SlicerCacheDefinitionExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "slicerCacheDefinition")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerCacheDefinition : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCacheDefinition class.
        /// </summary>
        public SlicerCacheDefinition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCacheDefinition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCacheDefinition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheDefinition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerCacheDefinition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(0)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>sourceName, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sourceName</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "sourceName")]
        [Index(1)]
        public StringValue SourceName { get; set; }

        /// <summary>
        /// <para>SlicerCachePivotTables.</para>
        /// <para>Represents the following element tag in the schema: x14:pivotTables.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public SlicerCachePivotTables SlicerCachePivotTables
        {
            get => GetElement<SlicerCachePivotTables>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SlicerCacheData.</para>
        /// <para>Represents the following element tag in the schema: x14:data.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public SlicerCacheData SlicerCacheData
        {
            get => GetElement<SlicerCacheData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SlicerCacheDefinitionExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public SlicerCacheDefinitionExtensionList SlicerCacheDefinitionExtensionList
        {
            get => GetElement<SlicerCacheDefinitionExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTables), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheData), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheDefinitionExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheDefinition>(deep);

        internal SlicerCacheDefinition(SlicerCachePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the SlicerCachePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(SlicerCachePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the SlicerCachePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(SlicerCachePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the SlicerCachePart associated with this element.
        /// </summary>
        public SlicerCachePart SlicerCachePart
        {
            get => OpenXmlPart as SlicerCachePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the ConditionalFormatting Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:conditionalFormatting.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ConditionalFormattingRule &lt;x14:cfRule></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.ReferenceSequence &lt;xne:sqref></description></item>
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ConditionalFormattingRule), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence))]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "conditionalFormatting")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ConditionalFormatting : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConditionalFormatting class.
        /// </summary>
        public ConditionalFormatting() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormatting class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConditionalFormatting(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormatting class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConditionalFormatting(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormatting class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConditionalFormatting(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>pivot, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pivot</para>
        /// </summary>
        [SchemaAttr(0, "pivot")]
        [Index(0)]
        public BooleanValue Pivot { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingRule), 0, 0, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormatting>(deep);
    }

    /// <summary>
    /// <para>Defines the ConditionalFormattingRule Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:cfRule.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
    ///   <item><description>ColorScale &lt;x14:colorScale></description></item>
    ///   <item><description>DataBar &lt;x14:dataBar></description></item>
    ///   <item><description>IconSet &lt;x14:iconSet></description></item>
    ///   <item><description>DifferentialType &lt;x14:dxf></description></item>
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    [ChildElementInfo(typeof(ColorScale), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DataBar), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(IconSet), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DifferentialType), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "cfRule")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ConditionalFormattingRule : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConditionalFormattingRule class.
        /// </summary>
        public ConditionalFormattingRule() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormattingRule class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConditionalFormattingRule(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormattingRule class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConditionalFormattingRule(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormattingRule class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConditionalFormattingRule(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>type, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr(0, "type")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatValues> Type { get; set; }

        /// <summary>
        /// <para>priority, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: priority</para>
        /// </summary>
        [SchemaAttr(0, "priority")]
        [Index(1)]
        public Int32Value Priority { get; set; }

        /// <summary>
        /// <para>stopIfTrue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: stopIfTrue</para>
        /// </summary>
        [SchemaAttr(0, "stopIfTrue")]
        [Index(2)]
        public BooleanValue StopIfTrue { get; set; }

        /// <summary>
        /// <para>aboveAverage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: aboveAverage</para>
        /// </summary>
        [SchemaAttr(0, "aboveAverage")]
        [Index(3)]
        public BooleanValue AboveAverage { get; set; }

        /// <summary>
        /// <para>percent, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: percent</para>
        /// </summary>
        [SchemaAttr(0, "percent")]
        [Index(4)]
        public BooleanValue Percent { get; set; }

        /// <summary>
        /// <para>bottom, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: bottom</para>
        /// </summary>
        [SchemaAttr(0, "bottom")]
        [Index(5)]
        public BooleanValue Bottom { get; set; }

        /// <summary>
        /// <para>operator, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: operator</para>
        /// </summary>
        [SchemaAttr(0, "operator")]
        [Index(6)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormattingOperatorValues> Operator { get; set; }

        /// <summary>
        /// <para>text, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: text</para>
        /// </summary>
        [SchemaAttr(0, "text")]
        [Index(7)]
        public StringValue Text { get; set; }

        /// <summary>
        /// <para>timePeriod, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: timePeriod</para>
        /// </summary>
        [SchemaAttr(0, "timePeriod")]
        [Index(8)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.TimePeriodValues> TimePeriod { get; set; }

        /// <summary>
        /// <para>rank, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rank</para>
        /// </summary>
        [SchemaAttr(0, "rank")]
        [Index(9)]
        public UInt32Value Rank { get; set; }

        /// <summary>
        /// <para>stdDev, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: stdDev</para>
        /// </summary>
        [SchemaAttr(0, "stdDev")]
        [Index(10)]
        public Int32Value StandardDeviation { get; set; }

        /// <summary>
        /// <para>equalAverage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: equalAverage</para>
        /// </summary>
        [SchemaAttr(0, "equalAverage")]
        [Index(11)]
        public BooleanValue EqualAverage { get; set; }

        /// <summary>
        /// <para>activePresent, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: activePresent</para>
        /// </summary>
        [SchemaAttr(0, "activePresent")]
        [Index(12)]
        public BooleanValue ActivePresent { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsToken = true, Pattern = "\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}")]
        [SchemaAttr(0, "id")]
        [Index(13)]
        public StringValue Id { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 0, 3),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ColorScale), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DataBar), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.IconSet), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DifferentialType), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormattingRule>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Extension &lt;x:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Extension))]
    [SchemaAttr(53, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
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

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Extension), 0, 0)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the DataValidation Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:dataValidation.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DataValidationForumla1 &lt;x14:formula1></description></item>
    ///   <item><description>DataValidationForumla2 &lt;x14:formula2></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.ReferenceSequence &lt;xne:sqref></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DataValidationForumla1), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DataValidationForumla2), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence))]
    [SchemaAttr(53, "dataValidation")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DataValidation : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataValidation class.
        /// </summary>
        public DataValidation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataValidation(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataValidation(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidation class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataValidation(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>type, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr(0, "type")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues> Type { get; set; }

        /// <summary>
        /// <para>errorStyle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: errorStyle</para>
        /// </summary>
        [SchemaAttr(0, "errorStyle")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues> ErrorStyle { get; set; }

        /// <summary>
        /// <para>imeMode, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imeMode</para>
        /// </summary>
        [SchemaAttr(0, "imeMode")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues> ImeMode { get; set; }

        /// <summary>
        /// <para>operator, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: operator</para>
        /// </summary>
        [SchemaAttr(0, "operator")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues> Operator { get; set; }

        /// <summary>
        /// <para>allowBlank, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: allowBlank</para>
        /// </summary>
        [SchemaAttr(0, "allowBlank")]
        [Index(4)]
        public BooleanValue AllowBlank { get; set; }

        /// <summary>
        /// <para>showDropDown, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showDropDown</para>
        /// </summary>
        [SchemaAttr(0, "showDropDown")]
        [Index(5)]
        public BooleanValue ShowDropDown { get; set; }

        /// <summary>
        /// <para>showInputMessage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showInputMessage</para>
        /// </summary>
        [SchemaAttr(0, "showInputMessage")]
        [Index(6)]
        public BooleanValue ShowInputMessage { get; set; }

        /// <summary>
        /// <para>showErrorMessage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showErrorMessage</para>
        /// </summary>
        [SchemaAttr(0, "showErrorMessage")]
        [Index(7)]
        public BooleanValue ShowErrorMessage { get; set; }

        /// <summary>
        /// <para>errorTitle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: errorTitle</para>
        /// </summary>
        [SchemaAttr(0, "errorTitle")]
        [Index(8)]
        public StringValue ErrorTitle { get; set; }

        /// <summary>
        /// <para>error, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: error</para>
        /// </summary>
        [SchemaAttr(0, "error")]
        [Index(9)]
        public StringValue Error { get; set; }

        /// <summary>
        /// <para>promptTitle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: promptTitle</para>
        /// </summary>
        [SchemaAttr(0, "promptTitle")]
        [Index(10)]
        public StringValue PromptTitle { get; set; }

        /// <summary>
        /// <para>prompt, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: prompt</para>
        /// </summary>
        [SchemaAttr(0, "prompt")]
        [Index(11)]
        public StringValue Prompt { get; set; }

        /// <summary>
        /// <para>DataValidationForumla1.</para>
        /// <para>Represents the following element tag in the schema: x14:formula1.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DataValidationForumla1 DataValidationForumla1
        {
            get => GetElement<DataValidationForumla1>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataValidationForumla2.</para>
        /// <para>Represents the following element tag in the schema: x14:formula2.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DataValidationForumla2 DataValidationForumla2
        {
            get => GetElement<DataValidationForumla2>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ReferenceSequence.</para>
        /// <para>Represents the following element tag in the schema: xne:sqref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Office.Excel.ReferenceSequence ReferenceSequence
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DataValidationForumla1), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DataValidationForumla2), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataValidation>(deep);
    }

    /// <summary>
    /// <para>Defines the DataValidationForumla1 Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:formula1.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(53, "formula1")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DataValidationForumla1 : DataValidationFormulaType
    {
        /// <summary>
        /// Initializes a new instance of the DataValidationForumla1 class.
        /// </summary>
        public DataValidationForumla1() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidationForumla1 class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataValidationForumla1(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidationForumla1 class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataValidationForumla1(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidationForumla1 class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataValidationForumla1(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataValidationForumla1>(deep);
    }

    /// <summary>
    /// <para>Defines the DataValidationForumla2 Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:formula2.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(53, "formula2")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DataValidationForumla2 : DataValidationFormulaType
    {
        /// <summary>
        /// Initializes a new instance of the DataValidationForumla2 class.
        /// </summary>
        public DataValidationForumla2() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidationForumla2 class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataValidationForumla2(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidationForumla2 class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataValidationForumla2(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidationForumla2 class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataValidationForumla2(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataValidationForumla2>(deep);
    }

    /// <summary>
    /// <para>Defines the DataValidationFormulaType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    public abstract partial class DataValidationFormulaType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataValidationFormulaType class.
        /// </summary>
        protected DataValidationFormulaType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidationFormulaType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected DataValidationFormulaType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidationFormulaType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected DataValidationFormulaType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidationFormulaType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected DataValidationFormulaType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: xne:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Office.Excel.Formula Formula
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    }

    /// <summary>
    /// <para>Defines the SparklineGroup Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:sparklineGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SeriesColor &lt;x14:colorSeries></description></item>
    ///   <item><description>NegativeColor &lt;x14:colorNegative></description></item>
    ///   <item><description>AxisColor &lt;x14:colorAxis></description></item>
    ///   <item><description>MarkersColor &lt;x14:colorMarkers></description></item>
    ///   <item><description>FirstMarkerColor &lt;x14:colorFirst></description></item>
    ///   <item><description>LastMarkerColor &lt;x14:colorLast></description></item>
    ///   <item><description>HighMarkerColor &lt;x14:colorHigh></description></item>
    ///   <item><description>LowMarkerColor &lt;x14:colorLow></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
    ///   <item><description>Sparklines &lt;x14:sparklines></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SeriesColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(NegativeColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(AxisColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MarkersColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(FirstMarkerColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LastMarkerColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(HighMarkerColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LowMarkerColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    [ChildElementInfo(typeof(Sparklines), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "sparklineGroup")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SparklineGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SparklineGroup class.
        /// </summary>
        public SparklineGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SparklineGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SparklineGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SparklineGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SparklineGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SparklineGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SparklineGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>manualMax, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: manualMax</para>
        /// </summary>
        [SchemaAttr(0, "manualMax")]
        [Index(0)]
        public DoubleValue ManualMax { get; set; }

        /// <summary>
        /// <para>manualMin, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: manualMin</para>
        /// </summary>
        [SchemaAttr(0, "manualMin")]
        [Index(1)]
        public DoubleValue ManualMin { get; set; }

        /// <summary>
        /// <para>lineWeight, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: lineWeight</para>
        /// </summary>
        [SchemaAttr(0, "lineWeight")]
        [Index(2)]
        public DoubleValue LineWeight { get; set; }

        /// <summary>
        /// <para>type, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr(0, "type")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues> Type { get; set; }

        /// <summary>
        /// <para>dateAxis, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dateAxis</para>
        /// </summary>
        [SchemaAttr(0, "dateAxis")]
        [Index(4)]
        public BooleanValue DateAxis { get; set; }

        /// <summary>
        /// <para>displayEmptyCellsAs, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: displayEmptyCellsAs</para>
        /// </summary>
        [SchemaAttr(0, "displayEmptyCellsAs")]
        [Index(5)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues> DisplayEmptyCellsAs { get; set; }

        /// <summary>
        /// <para>markers, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: markers</para>
        /// </summary>
        [SchemaAttr(0, "markers")]
        [Index(6)]
        public BooleanValue Markers { get; set; }

        /// <summary>
        /// <para>high, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: high</para>
        /// </summary>
        [SchemaAttr(0, "high")]
        [Index(7)]
        public BooleanValue High { get; set; }

        /// <summary>
        /// <para>low, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: low</para>
        /// </summary>
        [SchemaAttr(0, "low")]
        [Index(8)]
        public BooleanValue Low { get; set; }

        /// <summary>
        /// <para>first, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: first</para>
        /// </summary>
        [SchemaAttr(0, "first")]
        [Index(9)]
        public BooleanValue First { get; set; }

        /// <summary>
        /// <para>last, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: last</para>
        /// </summary>
        [SchemaAttr(0, "last")]
        [Index(10)]
        public BooleanValue Last { get; set; }

        /// <summary>
        /// <para>negative, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: negative</para>
        /// </summary>
        [SchemaAttr(0, "negative")]
        [Index(11)]
        public BooleanValue Negative { get; set; }

        /// <summary>
        /// <para>displayXAxis, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: displayXAxis</para>
        /// </summary>
        [SchemaAttr(0, "displayXAxis")]
        [Index(12)]
        public BooleanValue DisplayXAxis { get; set; }

        /// <summary>
        /// <para>displayHidden, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: displayHidden</para>
        /// </summary>
        [SchemaAttr(0, "displayHidden")]
        [Index(13)]
        public BooleanValue DisplayHidden { get; set; }

        /// <summary>
        /// <para>minAxisType, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: minAxisType</para>
        /// </summary>
        [SchemaAttr(0, "minAxisType")]
        [Index(14)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues> MinAxisType { get; set; }

        /// <summary>
        /// <para>maxAxisType, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: maxAxisType</para>
        /// </summary>
        [SchemaAttr(0, "maxAxisType")]
        [Index(15)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues> MaxAxisType { get; set; }

        /// <summary>
        /// <para>rightToLeft, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rightToLeft</para>
        /// </summary>
        [SchemaAttr(0, "rightToLeft")]
        [Index(16)]
        public BooleanValue RightToLeft { get; set; }

        /// <summary>
        /// <para>SeriesColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorSeries.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public SeriesColor SeriesColor
        {
            get => GetElement<SeriesColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NegativeColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public NegativeColor NegativeColor
        {
            get => GetElement<NegativeColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>AxisColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorAxis.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public AxisColor AxisColor
        {
            get => GetElement<AxisColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MarkersColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorMarkers.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public MarkersColor MarkersColor
        {
            get => GetElement<MarkersColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FirstMarkerColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorFirst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public FirstMarkerColor FirstMarkerColor
        {
            get => GetElement<FirstMarkerColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LastMarkerColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorLast.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public LastMarkerColor LastMarkerColor
        {
            get => GetElement<LastMarkerColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HighMarkerColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorHigh.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public HighMarkerColor HighMarkerColor
        {
            get => GetElement<HighMarkerColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LowMarkerColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorLow.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public LowMarkerColor LowMarkerColor
        {
            get => GetElement<LowMarkerColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: xne:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Office.Excel.Formula Formula
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Sparklines.</para>
        /// <para>Represents the following element tag in the schema: x14:sparklines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public Sparklines Sparklines
        {
            get => GetElement<Sparklines>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SeriesColor), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.NegativeColor), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.AxisColor), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.MarkersColor), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Sparklines), 1, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SparklineGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorSeries.</para>
    /// </summary>
    [SchemaAttr(53, "colorSeries")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SeriesColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the SeriesColor class.
        /// </summary>
        public SeriesColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesColor>(deep);
    }

    /// <summary>
    /// <para>Defines the NegativeColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorNegative.</para>
    /// </summary>
    [SchemaAttr(53, "colorNegative")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class NegativeColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the NegativeColor class.
        /// </summary>
        public NegativeColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NegativeColor>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorAxis.</para>
    /// </summary>
    [SchemaAttr(53, "colorAxis")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class AxisColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the AxisColor class.
        /// </summary>
        public AxisColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisColor>(deep);
    }

    /// <summary>
    /// <para>Defines the MarkersColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorMarkers.</para>
    /// </summary>
    [SchemaAttr(53, "colorMarkers")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class MarkersColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the MarkersColor class.
        /// </summary>
        public MarkersColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MarkersColor>(deep);
    }

    /// <summary>
    /// <para>Defines the FirstMarkerColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorFirst.</para>
    /// </summary>
    [SchemaAttr(53, "colorFirst")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class FirstMarkerColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the FirstMarkerColor class.
        /// </summary>
        public FirstMarkerColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstMarkerColor>(deep);
    }

    /// <summary>
    /// <para>Defines the LastMarkerColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorLast.</para>
    /// </summary>
    [SchemaAttr(53, "colorLast")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class LastMarkerColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the LastMarkerColor class.
        /// </summary>
        public LastMarkerColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LastMarkerColor>(deep);
    }

    /// <summary>
    /// <para>Defines the HighMarkerColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorHigh.</para>
    /// </summary>
    [SchemaAttr(53, "colorHigh")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class HighMarkerColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the HighMarkerColor class.
        /// </summary>
        public HighMarkerColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HighMarkerColor>(deep);
    }

    /// <summary>
    /// <para>Defines the LowMarkerColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorLow.</para>
    /// </summary>
    [SchemaAttr(53, "colorLow")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class LowMarkerColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the LowMarkerColor class.
        /// </summary>
        public LowMarkerColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LowMarkerColor>(deep);
    }

    /// <summary>
    /// <para>Defines the Color Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:color.</para>
    /// </summary>
    [SchemaAttr(53, "color")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Color : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the Color class.
        /// </summary>
        public Color() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Color>(deep);
    }

    /// <summary>
    /// <para>Defines the FillColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:fillColor.</para>
    /// </summary>
    [SchemaAttr(53, "fillColor")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class FillColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the FillColor class.
        /// </summary>
        public FillColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillColor>(deep);
    }

    /// <summary>
    /// <para>Defines the BorderColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:borderColor.</para>
    /// </summary>
    [SchemaAttr(53, "borderColor")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BorderColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the BorderColor class.
        /// </summary>
        public BorderColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BorderColor>(deep);
    }

    /// <summary>
    /// <para>Defines the NegativeFillColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:negativeFillColor.</para>
    /// </summary>
    [SchemaAttr(53, "negativeFillColor")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class NegativeFillColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the NegativeFillColor class.
        /// </summary>
        public NegativeFillColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NegativeFillColor>(deep);
    }

    /// <summary>
    /// <para>Defines the NegativeBorderColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:negativeBorderColor.</para>
    /// </summary>
    [SchemaAttr(53, "negativeBorderColor")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class NegativeBorderColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the NegativeBorderColor class.
        /// </summary>
        public NegativeBorderColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NegativeBorderColor>(deep);
    }

    /// <summary>
    /// <para>Defines the BarAxisColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:axisColor.</para>
    /// </summary>
    [SchemaAttr(53, "axisColor")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BarAxisColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the BarAxisColor class.
        /// </summary>
        public BarAxisColor() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarAxisColor>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class ColorType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorType class.
        /// </summary>
        protected ColorType() : base()
        {
        }

        /// <summary>
        /// <para>Automatic</para>
        /// <para>Represents the following attribute in the schema: auto</para>
        /// </summary>
        [SchemaAttr(0, "auto")]
        [Index(0)]
        public BooleanValue Auto { get; set; }

        /// <summary>
        /// <para>Index</para>
        /// <para>Represents the following attribute in the schema: indexed</para>
        /// </summary>
        [SchemaAttr(0, "indexed")]
        [Index(1)]
        public UInt32Value Indexed { get; set; }

        /// <summary>
        /// <para>Alpha Red Green Blue Color Value</para>
        /// <para>Represents the following attribute in the schema: rgb</para>
        /// </summary>
        [StringValidator(Length = 4L)]
        [SchemaAttr(0, "rgb")]
        [Index(2)]
        public HexBinaryValue Rgb { get; set; }

        /// <summary>
        /// <para>Theme Color</para>
        /// <para>Represents the following attribute in the schema: theme</para>
        /// </summary>
        [SchemaAttr(0, "theme")]
        [Index(3)]
        public UInt32Value Theme { get; set; }

        /// <summary>
        /// <para>Tint</para>
        /// <para>Represents the following attribute in the schema: tint</para>
        /// </summary>
        [SchemaAttr(0, "tint")]
        [Index(4)]
        public DoubleValue Tint { get; set; }
    }

    /// <summary>
    /// <para>Defines the Sparklines Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:sparklines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Sparkline &lt;x14:sparkline></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Sparkline), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "sparklines")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Sparklines : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Sparklines class.
        /// </summary>
        public Sparklines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sparklines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Sparklines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sparklines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Sparklines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sparklines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Sparklines(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Sparkline), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Sparklines>(deep);
    }

    /// <summary>
    /// <para>Defines the Sparkline Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:sparkline.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.ReferenceSequence &lt;xne:sqref></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence))]
    [SchemaAttr(53, "sparkline")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Sparkline : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Sparkline class.
        /// </summary>
        public Sparkline() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sparkline class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Sparkline(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sparkline class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Sparkline(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sparkline class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Sparkline(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: xne:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Office.Excel.Formula Formula
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ReferenceSequence.</para>
        /// <para>Represents the following element tag in the schema: xne:sqref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Office.Excel.ReferenceSequence ReferenceSequence
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Sparkline>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerRef Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicer.</para>
    /// </summary>
    [SchemaAttr(53, "slicer")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerRef : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerRef class.
        /// </summary>
        public SlicerRef() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerRef>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCache Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicerCache.</para>
    /// </summary>
    [SchemaAttr(53, "slicerCache")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerCache : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCache class.
        /// </summary>
        public SlicerCache() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCache>(deep);
    }

    /// <summary>
    /// <para>Defines the DefinedName Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:definedName.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArgumentDescriptions &lt;x14:argumentDescriptions></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ArgumentDescriptions), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "definedName")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DefinedName : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DefinedName class.
        /// </summary>
        public DefinedName() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DefinedName class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DefinedName(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DefinedName class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DefinedName(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DefinedName class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DefinedName(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(0)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>ArgumentDescriptions.</para>
        /// <para>Represents the following element tag in the schema: x14:argumentDescriptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public ArgumentDescriptions ArgumentDescriptions
        {
            get => GetElement<ArgumentDescriptions>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ArgumentDescriptions), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefinedName>(deep);
    }

    /// <summary>
    /// <para>Defines the ArgumentDescriptions Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:argumentDescriptions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArgumentDescription &lt;x14:argumentDescription></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ArgumentDescription), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "argumentDescriptions")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArgumentDescriptions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ArgumentDescriptions class.
        /// </summary>
        public ArgumentDescriptions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArgumentDescriptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ArgumentDescriptions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArgumentDescriptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ArgumentDescriptions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArgumentDescriptions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ArgumentDescriptions(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr(0, "count")]
        [Index(0)]
        public UInt32Value Count { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ArgumentDescription), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArgumentDescriptions>(deep);
    }

    /// <summary>
    /// <para>Defines the ArgumentDescription Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:argumentDescription.</para>
    /// </summary>
    [SchemaAttr(53, "argumentDescription")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArgumentDescription : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ArgumentDescription class.
        /// </summary>
        public ArgumentDescription() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArgumentDescription class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ArgumentDescription(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>index, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: index</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "index")]
        [Index(0)]
        public UInt32Value Index { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArgumentDescription>(deep);
    }

    /// <summary>
    /// <para>Defines the TupleSet Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:tupleSet.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TupleSetHeaders &lt;x14:headers></description></item>
    ///   <item><description>TupleSetRows &lt;x14:rows></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TupleSetHeaders), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TupleSetRows), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "tupleSet")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TupleSet : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TupleSet class.
        /// </summary>
        public TupleSet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleSet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TupleSet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleSet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TupleSet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleSet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TupleSet(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rowCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rowCount</para>
        /// </summary>
        [SchemaAttr(0, "rowCount")]
        [Index(0)]
        public UInt32Value RowCount { get; set; }

        /// <summary>
        /// <para>columnCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: columnCount</para>
        /// </summary>
        [SchemaAttr(0, "columnCount")]
        [Index(1)]
        public UInt32Value ColumnCount { get; set; }

        /// <summary>
        /// <para>TupleSetHeaders.</para>
        /// <para>Represents the following element tag in the schema: x14:headers.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public TupleSetHeaders TupleSetHeaders
        {
            get => GetElement<TupleSetHeaders>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TupleSetRows.</para>
        /// <para>Represents the following element tag in the schema: x14:rows.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public TupleSetRows TupleSetRows
        {
            get => GetElement<TupleSetRows>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleSetHeaders), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleSetRows), 1, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSet>(deep);
    }

    /// <summary>
    /// <para>Defines the TupleSetHeaders Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:headers.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TupleSetHeader &lt;x14:header></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TupleSetHeader), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "headers")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TupleSetHeaders : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TupleSetHeaders class.
        /// </summary>
        public TupleSetHeaders() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleSetHeaders class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TupleSetHeaders(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleSetHeaders class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TupleSetHeaders(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleSetHeaders class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TupleSetHeaders(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleSetHeader), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetHeaders>(deep);
    }

    /// <summary>
    /// <para>Defines the TupleSetRows Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:rows.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TupleSetRow &lt;x14:row></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TupleSetRow), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "rows")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TupleSetRows : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TupleSetRows class.
        /// </summary>
        public TupleSetRows() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleSetRows class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TupleSetRows(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleSetRows class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TupleSetRows(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleSetRows class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TupleSetRows(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleSetRow), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetRows>(deep);
    }

    /// <summary>
    /// <para>Defines the TupleSetHeader Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:header.</para>
    /// </summary>
    [SchemaAttr(53, "header")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TupleSetHeader : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TupleSetHeader class.
        /// </summary>
        public TupleSetHeader() : base()
        {
        }

        /// <summary>
        /// <para>uniqueName, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: uniqueName</para>
        /// </summary>
        [SchemaAttr(0, "uniqueName")]
        [Index(0)]
        public StringValue UniqueName { get; set; }

        /// <summary>
        /// <para>hierarchyName, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hierarchyName</para>
        /// </summary>
        [SchemaAttr(0, "hierarchyName")]
        [Index(1)]
        public StringValue HierarchyName { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetHeader>(deep);
    }

    /// <summary>
    /// <para>Defines the TupleSetRow Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:row.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TupleSetRowItem &lt;x14:rowItem></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TupleSetRowItem), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "row")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TupleSetRow : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TupleSetRow class.
        /// </summary>
        public TupleSetRow() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleSetRow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TupleSetRow(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleSetRow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TupleSetRow(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleSetRow class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TupleSetRow(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleSetRowItem), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetRow>(deep);
    }

    /// <summary>
    /// <para>Defines the TupleSetRowItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:rowItem.</para>
    /// </summary>
    [SchemaAttr(53, "rowItem")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TupleSetRowItem : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TupleSetRowItem class.
        /// </summary>
        public TupleSetRowItem() : base()
        {
        }

        /// <summary>
        /// <para>u, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: u</para>
        /// </summary>
        [SchemaAttr(0, "u")]
        [Index(0)]
        public StringValue UniqueName { get; set; }

        /// <summary>
        /// <para>d, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: d</para>
        /// </summary>
        [SchemaAttr(0, "d")]
        [Index(1)]
        public StringValue DisplayName { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetRowItem>(deep);
    }

    /// <summary>
    /// <para>Defines the SetLevel Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:setLevel.</para>
    /// </summary>
    [SchemaAttr(53, "setLevel")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SetLevel : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SetLevel class.
        /// </summary>
        public SetLevel() : base()
        {
        }

        /// <summary>
        /// <para>hierarchy, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hierarchy</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "hierarchy")]
        [Index(0)]
        public Int32Value Hierarchy { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SetLevel>(deep);
    }

    /// <summary>
    /// <para>Defines the SetLevels Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:setLevels.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SetLevel &lt;x14:setLevel></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SetLevel), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "setLevels")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SetLevels : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SetLevels class.
        /// </summary>
        public SetLevels() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SetLevels class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SetLevels(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SetLevels class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SetLevels(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SetLevels class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SetLevels(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr(0, "count")]
        [Index(0)]
        public UInt32Value Count { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SetLevel), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SetLevels>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorScale Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorScale.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ConditionalFormattingValueObject &lt;x14:cfvo></description></item>
    ///   <item><description>Color &lt;x14:color></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ConditionalFormattingValueObject), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Color), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "colorScale")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ColorScale : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorScale class.
        /// </summary>
        public ColorScale() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorScale class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorScale(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorScale class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorScale(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorScale class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorScale(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingValueObject), 2, 0, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Color), 2, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorScale>(deep);
    }

    /// <summary>
    /// <para>Defines the DataBar Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:dataBar.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ConditionalFormattingValueObject &lt;x14:cfvo></description></item>
    ///   <item><description>FillColor &lt;x14:fillColor></description></item>
    ///   <item><description>BorderColor &lt;x14:borderColor></description></item>
    ///   <item><description>NegativeFillColor &lt;x14:negativeFillColor></description></item>
    ///   <item><description>NegativeBorderColor &lt;x14:negativeBorderColor></description></item>
    ///   <item><description>BarAxisColor &lt;x14:axisColor></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ConditionalFormattingValueObject), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(FillColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BorderColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(NegativeFillColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(NegativeBorderColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BarAxisColor), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "dataBar")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DataBar : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataBar class.
        /// </summary>
        public DataBar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataBar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataBar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataBar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataBar(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataBar class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataBar(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>minLength, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: minLength</para>
        /// </summary>
        [SchemaAttr(0, "minLength")]
        [Index(0)]
        public UInt32Value MinLength { get; set; }

        /// <summary>
        /// <para>maxLength, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        [SchemaAttr(0, "maxLength")]
        [Index(1)]
        public UInt32Value MaxLength { get; set; }

        /// <summary>
        /// <para>showValue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showValue</para>
        /// </summary>
        [SchemaAttr(0, "showValue")]
        [Index(2)]
        public BooleanValue ShowValue { get; set; }

        /// <summary>
        /// <para>border, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: border</para>
        /// </summary>
        [SchemaAttr(0, "border")]
        [Index(3)]
        public BooleanValue Border { get; set; }

        /// <summary>
        /// <para>gradient, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: gradient</para>
        /// </summary>
        [SchemaAttr(0, "gradient")]
        [Index(4)]
        public BooleanValue Gradient { get; set; }

        /// <summary>
        /// <para>direction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: direction</para>
        /// </summary>
        [SchemaAttr(0, "direction")]
        [Index(5)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DataBarDirectionValues> Direction { get; set; }

        /// <summary>
        /// <para>negativeBarColorSameAsPositive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: negativeBarColorSameAsPositive</para>
        /// </summary>
        [SchemaAttr(0, "negativeBarColorSameAsPositive")]
        [Index(6)]
        public BooleanValue NegativeBarColorSameAsPositive { get; set; }

        /// <summary>
        /// <para>negativeBarBorderColorSameAsPositive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: negativeBarBorderColorSameAsPositive</para>
        /// </summary>
        [SchemaAttr(0, "negativeBarBorderColorSameAsPositive")]
        [Index(7)]
        public BooleanValue NegativeBarBorderColorSameAsPositive { get; set; }

        /// <summary>
        /// <para>axisPosition, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: axisPosition</para>
        /// </summary>
        [SchemaAttr(0, "axisPosition")]
        [Index(8)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DataBarAxisPositionValues> AxisPosition { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingValueObject), 2, 2, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.FillColor), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.BorderColor), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.NegativeFillColor), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.NegativeBorderColor), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.BarAxisColor), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataBar>(deep);
    }

    /// <summary>
    /// <para>Defines the IconSet Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:iconSet.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ConditionalFormattingValueObject &lt;x14:cfvo></description></item>
    ///   <item><description>ConditionalFormattingIcon &lt;x14:cfIcon></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ConditionalFormattingValueObject), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ConditionalFormattingIcon), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "iconSet")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class IconSet : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the IconSet class.
        /// </summary>
        public IconSet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the IconSet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public IconSet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IconSet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public IconSet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IconSet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public IconSet(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>iconSet, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: iconSet</para>
        /// </summary>
        [SchemaAttr(0, "iconSet")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues> IconSetTypes { get; set; }

        /// <summary>
        /// <para>showValue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showValue</para>
        /// </summary>
        [SchemaAttr(0, "showValue")]
        [Index(1)]
        public BooleanValue ShowValue { get; set; }

        /// <summary>
        /// <para>percent, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: percent</para>
        /// </summary>
        [SchemaAttr(0, "percent")]
        [Index(2)]
        public BooleanValue Percent { get; set; }

        /// <summary>
        /// <para>reverse, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: reverse</para>
        /// </summary>
        [SchemaAttr(0, "reverse")]
        [Index(3)]
        public BooleanValue Reverse { get; set; }

        /// <summary>
        /// <para>custom, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: custom</para>
        /// </summary>
        [SchemaAttr(0, "custom")]
        [Index(4)]
        public BooleanValue Custom { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingValueObject), 2, 0, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingIcon), 0, 5, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IconSet>(deep);
    }

    /// <summary>
    /// <para>Defines the DifferentialType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:dxf.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Font &lt;x:font></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.NumberingFormat &lt;x:numFmt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Fill &lt;x:fill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Alignment &lt;x:alignment></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Border &lt;x:border></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Protection &lt;x:protection></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.ExtensionList &lt;x:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Font))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.NumberingFormat))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Fill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Alignment))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Border))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Protection))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]
    [SchemaAttr(53, "dxf")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DifferentialType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DifferentialType class.
        /// </summary>
        public DifferentialType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DifferentialType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DifferentialType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DifferentialType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Font Properties.</para>
        /// <para>Represents the following element tag in the schema: x:font.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Font Font
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
        public DocumentFormat.OpenXml.Spreadsheet.NumberingFormat NumberingFormat
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
        public DocumentFormat.OpenXml.Spreadsheet.Fill Fill
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
        public DocumentFormat.OpenXml.Spreadsheet.Alignment Alignment
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
        public DocumentFormat.OpenXml.Spreadsheet.Border Border
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
        public DocumentFormat.OpenXml.Spreadsheet.Protection Protection
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
        public DocumentFormat.OpenXml.Spreadsheet.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Font), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.NumberingFormat), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Fill), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Alignment), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Border), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Protection), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DifferentialType>(deep);
    }

    /// <summary>
    /// <para>Defines the ConditionalFormattingValueObject Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:cfvo.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "cfvo")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ConditionalFormattingValueObject : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConditionalFormattingValueObject class.
        /// </summary>
        public ConditionalFormattingValueObject() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormattingValueObject class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConditionalFormattingValueObject(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormattingValueObject class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConditionalFormattingValueObject(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormattingValueObject class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConditionalFormattingValueObject(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>type, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "type")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingValueObjectTypeValues> Type { get; set; }

        /// <summary>
        /// <para>gte, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: gte</para>
        /// </summary>
        [SchemaAttr(0, "gte")]
        [Index(1)]
        public BooleanValue GreaterThanOrEqual { get; set; }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: xne:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Office.Excel.Formula Formula
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormattingValueObject>(deep);
    }

    /// <summary>
    /// <para>Defines the ConditionalFormattingIcon Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:cfIcon.</para>
    /// </summary>
    [SchemaAttr(53, "cfIcon")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ConditionalFormattingIcon : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ConditionalFormattingIcon class.
        /// </summary>
        public ConditionalFormattingIcon() : base()
        {
        }

        /// <summary>
        /// <para>iconSet, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: iconSet</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "iconSet")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues> IconSet { get; set; }

        /// <summary>
        /// <para>iconId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: iconId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "iconId")]
        [Index(1)]
        public UInt32Value IconId { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormattingIcon>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotEdits Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotEdits.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PivotEdit &lt;x14:pivotEdit></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PivotEdit), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "pivotEdits")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotEdits : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotEdits class.
        /// </summary>
        public PivotEdits() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotEdits class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotEdits(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotEdits class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotEdits(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotEdits class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotEdits(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotEdit), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotEdits>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotChanges Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotChanges.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PivotChange &lt;x14:pivotChange></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PivotChange), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "pivotChanges")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotChanges : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotChanges class.
        /// </summary>
        public PivotChanges() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotChanges class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotChanges(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotChanges class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotChanges(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotChanges class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotChanges(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotChange), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotChanges>(deep);
    }

    /// <summary>
    /// <para>Defines the ConditionalFormats Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:conditionalFormats.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ConditionalFormat &lt;x14:conditionalFormat></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ConditionalFormat), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "conditionalFormats")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ConditionalFormats : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConditionalFormats class.
        /// </summary>
        public ConditionalFormats() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConditionalFormats(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConditionalFormats(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormats class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConditionalFormats(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr(0, "count")]
        [Index(0)]
        public UInt32Value Count { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormat), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormats>(deep);
    }

    /// <summary>
    /// <para>Defines the CalculatedMembers Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:calculatedMembers.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.CalculatedMember &lt;x:calculatedMember></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.CalculatedMember))]
    [SchemaAttr(53, "calculatedMembers")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class CalculatedMembers : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CalculatedMembers class.
        /// </summary>
        public CalculatedMembers() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CalculatedMembers class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CalculatedMembers(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CalculatedMembers class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CalculatedMembers(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CalculatedMembers class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CalculatedMembers(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Calculated Members Count</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr(0, "count")]
        [Index(0)]
        public UInt32Value Count { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.CalculatedMember), 1, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CalculatedMembers>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotEdit Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotEdit.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PivotUserEdit &lt;x14:userEdit></description></item>
    ///   <item><description>TupleItems &lt;x14:tupleItems></description></item>
    ///   <item><description>PivotArea &lt;x14:pivotArea></description></item>
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PivotUserEdit), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TupleItems), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(PivotArea), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "pivotEdit")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotEdit : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotEdit class.
        /// </summary>
        public PivotEdit() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotEdit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotEdit(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotEdit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotEdit(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotEdit class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotEdit(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>PivotUserEdit.</para>
        /// <para>Represents the following element tag in the schema: x14:userEdit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public PivotUserEdit PivotUserEdit
        {
            get => GetElement<PivotUserEdit>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TupleItems.</para>
        /// <para>Represents the following element tag in the schema: x14:tupleItems.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public TupleItems TupleItems
        {
            get => GetElement<TupleItems>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotArea.</para>
        /// <para>Represents the following element tag in the schema: x14:pivotArea.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public PivotArea PivotArea
        {
            get => GetElement<PivotArea>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotUserEdit), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleItems), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotArea), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotEdit>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotUserEdit Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:userEdit.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
    ///   <item><description>PivotEditValue &lt;x14:editValue></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    [ChildElementInfo(typeof(PivotEditValue), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "userEdit")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotUserEdit : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotUserEdit class.
        /// </summary>
        public PivotUserEdit() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotUserEdit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotUserEdit(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotUserEdit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotUserEdit(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotUserEdit class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotUserEdit(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: xne:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Office.Excel.Formula Formula
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotEditValue.</para>
        /// <para>Represents the following element tag in the schema: x14:editValue.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public PivotEditValue PivotEditValue
        {
            get => GetElement<PivotEditValue>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotEditValue), 1, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotUserEdit>(deep);
    }

    /// <summary>
    /// <para>Defines the TupleItems Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:tupleItems.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Xstring &lt;x14:tupleItem></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Xstring), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "tupleItems")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TupleItems : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TupleItems class.
        /// </summary>
        public TupleItems() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TupleItems(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TupleItems(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TupleItems class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TupleItems(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Xstring), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleItems>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotArea Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotArea.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PivotAreaReferences &lt;x:references></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.ExtensionList &lt;x:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotAreaReferences))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]
    [SchemaAttr(53, "pivotArea")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotArea : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotArea class.
        /// </summary>
        public PivotArea() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotArea class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotArea(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotArea class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotArea(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotArea class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotArea(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Field Index</para>
        /// <para>Represents the following attribute in the schema: field</para>
        /// </summary>
        [SchemaAttr(0, "field")]
        [Index(0)]
        public Int32Value Field { get; set; }

        /// <summary>
        /// <para>Rule Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr(0, "type")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotAreaValues> Type { get; set; }

        /// <summary>
        /// <para>Data Only</para>
        /// <para>Represents the following attribute in the schema: dataOnly</para>
        /// </summary>
        [SchemaAttr(0, "dataOnly")]
        [Index(2)]
        public BooleanValue DataOnly { get; set; }

        /// <summary>
        /// <para>Labels Only</para>
        /// <para>Represents the following attribute in the schema: labelOnly</para>
        /// </summary>
        [SchemaAttr(0, "labelOnly")]
        [Index(3)]
        public BooleanValue LabelOnly { get; set; }

        /// <summary>
        /// <para>Include Row Grand Total</para>
        /// <para>Represents the following attribute in the schema: grandRow</para>
        /// </summary>
        [SchemaAttr(0, "grandRow")]
        [Index(4)]
        public BooleanValue GrandRow { get; set; }

        /// <summary>
        /// <para>Include Column Grand Total</para>
        /// <para>Represents the following attribute in the schema: grandCol</para>
        /// </summary>
        [SchemaAttr(0, "grandCol")]
        [Index(5)]
        public BooleanValue GrandColumn { get; set; }

        /// <summary>
        /// <para>Cache Index</para>
        /// <para>Represents the following attribute in the schema: cacheIndex</para>
        /// </summary>
        [SchemaAttr(0, "cacheIndex")]
        [Index(6)]
        public BooleanValue CacheIndex { get; set; }

        /// <summary>
        /// <para>Outline</para>
        /// <para>Represents the following attribute in the schema: outline</para>
        /// </summary>
        [SchemaAttr(0, "outline")]
        [Index(7)]
        public BooleanValue Outline { get; set; }

        /// <summary>
        /// <para>Offset Reference</para>
        /// <para>Represents the following attribute in the schema: offset</para>
        /// </summary>
        [SchemaAttr(0, "offset")]
        [Index(8)]
        public StringValue Offset { get; set; }

        /// <summary>
        /// <para>Collapsed Levels Are Subtotals</para>
        /// <para>Represents the following attribute in the schema: collapsedLevelsAreSubtotals</para>
        /// </summary>
        [SchemaAttr(0, "collapsedLevelsAreSubtotals")]
        [Index(9)]
        public BooleanValue CollapsedLevelsAreSubtotals { get; set; }

        /// <summary>
        /// <para>Axis</para>
        /// <para>Represents the following attribute in the schema: axis</para>
        /// </summary>
        [SchemaAttr(0, "axis")]
        [Index(10)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotTableAxisValues> Axis { get; set; }

        /// <summary>
        /// <para>Field Position</para>
        /// <para>Represents the following attribute in the schema: fieldPosition</para>
        /// </summary>
        [SchemaAttr(0, "fieldPosition")]
        [Index(11)]
        public UInt32Value FieldPosition { get; set; }

        /// <summary>
        /// <para>References.</para>
        /// <para>Represents the following element tag in the schema: x:references.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PivotAreaReferences PivotAreaReferences
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotAreaReferences>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Future Feature Data Storage Area.</para>
        /// <para>Represents the following element tag in the schema: x:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotAreaReferences), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotArea>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotChange Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotChange.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PivotEditValue &lt;x14:editValue></description></item>
    ///   <item><description>TupleItems &lt;x14:tupleItems></description></item>
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PivotEditValue), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TupleItems), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "pivotChange")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotChange : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotChange class.
        /// </summary>
        public PivotChange() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotChange class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotChange(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotChange class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotChange(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotChange class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotChange(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>allocationMethod, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: allocationMethod</para>
        /// </summary>
        [SchemaAttr(0, "allocationMethod")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.AllocationMethodValues> AllocationMethod { get; set; }

        /// <summary>
        /// <para>weightExpression, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: weightExpression</para>
        /// </summary>
        [SchemaAttr(0, "weightExpression")]
        [Index(1)]
        public StringValue WeightExpression { get; set; }

        /// <summary>
        /// <para>PivotEditValue.</para>
        /// <para>Represents the following element tag in the schema: x14:editValue.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public PivotEditValue PivotEditValue
        {
            get => GetElement<PivotEditValue>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TupleItems.</para>
        /// <para>Represents the following element tag in the schema: x14:tupleItems.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public TupleItems TupleItems
        {
            get => GetElement<TupleItems>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotEditValue), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleItems), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotChange>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotEditValue Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:editValue.</para>
    /// </summary>
    [SchemaAttr(53, "editValue")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotEditValue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotEditValue class.
        /// </summary>
        public PivotEditValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotEditValue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PivotEditValue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>valueType, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: valueType</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "valueType")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.PivotEditValueTypeValues> ValueType { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotEditValue>(deep);
    }

    /// <summary>
    /// <para>Defines the Xstring Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:tupleItem.</para>
    /// </summary>
    [SchemaAttr(53, "tupleItem")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Xstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Xstring class.
        /// </summary>
        public Xstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Xstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Xstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Xstring>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerStyleElements Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicerStyleElements.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlicerStyleElement &lt;x14:slicerStyleElement></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlicerStyleElement), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "slicerStyleElements")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerStyleElements : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerStyleElements class.
        /// </summary>
        public SlicerStyleElements() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerStyleElements class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerStyleElements(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerStyleElements class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerStyleElements(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerStyleElements class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerStyleElements(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerStyleElement), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerStyleElements>(deep);
    }

    /// <summary>
    /// <para>Defines the DdeValues Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:values.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Value &lt;x:value></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Value))]
    [SchemaAttr(53, "values")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DdeValues : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DdeValues class.
        /// </summary>
        public DdeValues() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DdeValues class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DdeValues(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DdeValues class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DdeValues(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DdeValues class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DdeValues(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rows</para>
        /// <para>Represents the following attribute in the schema: rows</para>
        /// </summary>
        [SchemaAttr(0, "rows")]
        [Index(0)]
        public UInt32Value Rows { get; set; }

        /// <summary>
        /// <para>Columns</para>
        /// <para>Represents the following attribute in the schema: cols</para>
        /// </summary>
        [SchemaAttr(0, "cols")]
        [Index(1)]
        public UInt32Value Columns { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Value), 1, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DdeValues>(deep);
    }

    /// <summary>
    /// <para>Defines the ConditionalFormat Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:conditionalFormat.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PivotAreas &lt;x14:pivotAreas></description></item>
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(PivotAreas), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "conditionalFormat")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ConditionalFormat : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConditionalFormat class.
        /// </summary>
        public ConditionalFormat() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConditionalFormat(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConditionalFormat(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConditionalFormat class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConditionalFormat(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>scope, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: scope</para>
        /// </summary>
        [SchemaAttr(0, "scope")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.ScopeValues> Scope { get; set; }

        /// <summary>
        /// <para>type, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr(0, "type")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.RuleValues> Type { get; set; }

        /// <summary>
        /// <para>priority, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: priority</para>
        /// </summary>
        [SchemaAttr(0, "priority")]
        [Index(2)]
        public UInt32Value Priority { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true, Pattern = "\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}")]
        [SchemaAttr(0, "id")]
        [Index(3)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>PivotAreas.</para>
        /// <para>Represents the following element tag in the schema: x14:pivotAreas.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public PivotAreas PivotAreas
        {
            get => GetElement<PivotAreas>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotAreas), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotAreas Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotAreas.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PivotArea &lt;x:pivotArea></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotArea))]
    [SchemaAttr(53, "pivotAreas")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotAreas : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotAreas class.
        /// </summary>
        public PivotAreas() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotAreas class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotAreas(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotAreas class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotAreas(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotAreas class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotAreas(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Pivot Area Count</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr(0, "count")]
        [Index(0)]
        public UInt32Value Count { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotArea), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotAreas>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerStyle Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicerStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlicerStyleElements &lt;x14:slicerStyleElements></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlicerStyleElements), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "slicerStyle")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerStyle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerStyle class.
        /// </summary>
        public SlicerStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerStyle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(0)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>SlicerStyleElements.</para>
        /// <para>Represents the following element tag in the schema: x14:slicerStyleElements.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public SlicerStyleElements SlicerStyleElements
        {
            get => GetElement<SlicerStyleElements>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerStyleElements), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerStyleElement Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicerStyleElement.</para>
    /// </summary>
    [SchemaAttr(53, "slicerStyleElement")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerStyleElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerStyleElement class.
        /// </summary>
        public SlicerStyleElement() : base()
        {
        }

        /// <summary>
        /// <para>type, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "type")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerStyleTypeValues> Type { get; set; }

        /// <summary>
        /// <para>dxfId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dxfId</para>
        /// </summary>
        [SchemaAttr(0, "dxfId")]
        [Index(1)]
        public UInt32Value FormatId { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerStyleElement>(deep);
    }

    /// <summary>
    /// <para>Defines the IgnoredError Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:ignoredError.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.ReferenceSequence &lt;xne:sqref></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence))]
    [SchemaAttr(53, "ignoredError")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class IgnoredError : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the IgnoredError class.
        /// </summary>
        public IgnoredError() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the IgnoredError class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public IgnoredError(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IgnoredError class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public IgnoredError(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IgnoredError class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public IgnoredError(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>evalError, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: evalError</para>
        /// </summary>
        [SchemaAttr(0, "evalError")]
        [Index(0)]
        public BooleanValue EvalError { get; set; }

        /// <summary>
        /// <para>twoDigitTextYear, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: twoDigitTextYear</para>
        /// </summary>
        [SchemaAttr(0, "twoDigitTextYear")]
        [Index(1)]
        public BooleanValue TwoDigitTextYear { get; set; }

        /// <summary>
        /// <para>numberStoredAsText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: numberStoredAsText</para>
        /// </summary>
        [SchemaAttr(0, "numberStoredAsText")]
        [Index(2)]
        public BooleanValue NumberStoredAsText { get; set; }

        /// <summary>
        /// <para>formula, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: formula</para>
        /// </summary>
        [SchemaAttr(0, "formula")]
        [Index(3)]
        public BooleanValue Formula { get; set; }

        /// <summary>
        /// <para>formulaRange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: formulaRange</para>
        /// </summary>
        [SchemaAttr(0, "formulaRange")]
        [Index(4)]
        public BooleanValue FormulaRange { get; set; }

        /// <summary>
        /// <para>unlockedFormula, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: unlockedFormula</para>
        /// </summary>
        [SchemaAttr(0, "unlockedFormula")]
        [Index(5)]
        public BooleanValue UnlockedFormula { get; set; }

        /// <summary>
        /// <para>emptyCellReference, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: emptyCellReference</para>
        /// </summary>
        [SchemaAttr(0, "emptyCellReference")]
        [Index(6)]
        public BooleanValue EmptyCellReference { get; set; }

        /// <summary>
        /// <para>listDataValidation, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: listDataValidation</para>
        /// </summary>
        [SchemaAttr(0, "listDataValidation")]
        [Index(7)]
        public BooleanValue ListDataValidation { get; set; }

        /// <summary>
        /// <para>calculatedColumn, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: calculatedColumn</para>
        /// </summary>
        [SchemaAttr(0, "calculatedColumn")]
        [Index(8)]
        public BooleanValue CalculatedColumn { get; set; }

        /// <summary>
        /// <para>ReferenceSequence.</para>
        /// <para>Represents the following element tag in the schema: xne:sqref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Office.Excel.ReferenceSequence ReferenceSequence
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IgnoredError>(deep);
    }

    /// <summary>
    /// <para>Defines the ProtectedRange Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:protectedRange.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.ReferenceSequence &lt;xne:sqref></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence))]
    [SchemaAttr(53, "protectedRange")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ProtectedRange : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ProtectedRange class.
        /// </summary>
        public ProtectedRange() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ProtectedRange class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ProtectedRange(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ProtectedRange class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ProtectedRange(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ProtectedRange class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ProtectedRange(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>password, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: password</para>
        /// </summary>
        [StringValidator(Length = 2L)]
        [SchemaAttr(0, "password")]
        [Index(0)]
        public HexBinaryValue Password { get; set; }

        /// <summary>
        /// <para>algorithmName, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: algorithmName</para>
        /// </summary>
        [SchemaAttr(0, "algorithmName")]
        [Index(1)]
        public StringValue AlgorithmName { get; set; }

        /// <summary>
        /// <para>hashValue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hashValue</para>
        /// </summary>
        [SchemaAttr(0, "hashValue")]
        [Index(2)]
        public Base64BinaryValue HashValue { get; set; }

        /// <summary>
        /// <para>saltValue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: saltValue</para>
        /// </summary>
        [SchemaAttr(0, "saltValue")]
        [Index(3)]
        public Base64BinaryValue SaltValue { get; set; }

        /// <summary>
        /// <para>spinCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: spinCount</para>
        /// </summary>
        [SchemaAttr(0, "spinCount")]
        [Index(4)]
        public UInt32Value SpinCount { get; set; }

        /// <summary>
        /// <para>name, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(5)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>securityDescriptor, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: securityDescriptor</para>
        /// </summary>
        [SchemaAttr(0, "securityDescriptor")]
        [Index(6)]
        public StringValue SecurityDescriptor { get; set; }

        /// <summary>
        /// <para>ReferenceSequence.</para>
        /// <para>Represents the following element tag in the schema: xne:sqref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Office.Excel.ReferenceSequence ReferenceSequence
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence), 1, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ProtectedRange>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomFilter Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:customFilter.</para>
    /// </summary>
    [SchemaAttr(53, "customFilter")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class CustomFilter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomFilter class.
        /// </summary>
        public CustomFilter() : base()
        {
        }

        /// <summary>
        /// <para>operator, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: operator</para>
        /// </summary>
        [SchemaAttr(0, "operator")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.FilterOperatorValues> Operator { get; set; }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr(0, "val")]
        [Index(1)]
        public StringValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the ListItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:item.</para>
    /// </summary>
    [SchemaAttr(53, "item")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ListItem : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ListItem class.
        /// </summary>
        public ListItem() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public StringValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ListItem>(deep);
    }

    /// <summary>
    /// <para>Defines the ListItems Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:itemLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ListItem &lt;x14:item></description></item>
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ListItem), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "itemLst")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ListItems : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ListItems class.
        /// </summary>
        public ListItems() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ListItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ListItems(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ListItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ListItems(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ListItems class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ListItems(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ListItem), 0, 0, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ListItems>(deep);
    }

    /// <summary>
    /// <para>Defines the Slicer Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicer.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "slicer")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Slicer : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Slicer class.
        /// </summary>
        public Slicer() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slicer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Slicer(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slicer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Slicer(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slicer class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Slicer(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(0)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>cache, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: cache</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "cache")]
        [Index(1)]
        public StringValue Cache { get; set; }

        /// <summary>
        /// <para>caption, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: caption</para>
        /// </summary>
        [SchemaAttr(0, "caption")]
        [Index(2)]
        public StringValue Caption { get; set; }

        /// <summary>
        /// <para>startItem, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: startItem</para>
        /// </summary>
        [SchemaAttr(0, "startItem")]
        [Index(3)]
        public UInt32Value StartItem { get; set; }

        /// <summary>
        /// <para>columnCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: columnCount</para>
        /// </summary>
        [SchemaAttr(0, "columnCount")]
        [Index(4)]
        public UInt32Value ColumnCount { get; set; }

        /// <summary>
        /// <para>showCaption, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showCaption</para>
        /// </summary>
        [SchemaAttr(0, "showCaption")]
        [Index(5)]
        public BooleanValue ShowCaption { get; set; }

        /// <summary>
        /// <para>level, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: level</para>
        /// </summary>
        [SchemaAttr(0, "level")]
        [Index(6)]
        public UInt32Value Level { get; set; }

        /// <summary>
        /// <para>style, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        [SchemaAttr(0, "style")]
        [Index(7)]
        public StringValue Style { get; set; }

        /// <summary>
        /// <para>lockedPosition, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: lockedPosition</para>
        /// </summary>
        [SchemaAttr(0, "lockedPosition")]
        [Index(8)]
        public BooleanValue LockedPosition { get; set; }

        /// <summary>
        /// <para>rowHeight, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rowHeight</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "rowHeight")]
        [Index(9)]
        public UInt32Value RowHeight { get; set; }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Slicer>(deep);
    }

    /// <summary>
    /// <para>Defines the OlapSlicerCache Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:olap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OlapSlicerCacheLevelsData &lt;x14:levels></description></item>
    ///   <item><description>OlapSlicerCacheSelections &lt;x14:selections></description></item>
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OlapSlicerCacheLevelsData), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(OlapSlicerCacheSelections), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "olap")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class OlapSlicerCache : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OlapSlicerCache class.
        /// </summary>
        public OlapSlicerCache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OlapSlicerCache(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>pivotCacheId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pivotCacheId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "pivotCacheId")]
        [Index(0)]
        public UInt32Value PivotCacheId { get; set; }

        /// <summary>
        /// <para>OlapSlicerCacheLevelsData.</para>
        /// <para>Represents the following element tag in the schema: x14:levels.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public OlapSlicerCacheLevelsData OlapSlicerCacheLevelsData
        {
            get => GetElement<OlapSlicerCacheLevelsData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OlapSlicerCacheSelections.</para>
        /// <para>Represents the following element tag in the schema: x14:selections.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public OlapSlicerCacheSelections OlapSlicerCacheSelections
        {
            get => GetElement<OlapSlicerCacheSelections>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheLevelsData), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheSelections), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCache>(deep);
    }

    /// <summary>
    /// <para>Defines the TabularSlicerCache Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:tabular.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TabularSlicerCacheItems &lt;x14:items></description></item>
    ///   <item><description>ExtensionList &lt;x14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TabularSlicerCacheItems), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "tabular")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TabularSlicerCache : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TabularSlicerCache class.
        /// </summary>
        public TabularSlicerCache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TabularSlicerCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TabularSlicerCache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TabularSlicerCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TabularSlicerCache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TabularSlicerCache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TabularSlicerCache(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>pivotCacheId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pivotCacheId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "pivotCacheId")]
        [Index(0)]
        public UInt32Value PivotCacheId { get; set; }

        /// <summary>
        /// <para>sortOrder, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sortOrder</para>
        /// </summary>
        [SchemaAttr(0, "sortOrder")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheSortOrderValues> SortOrder { get; set; }

        /// <summary>
        /// <para>customListSort, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: customListSort</para>
        /// </summary>
        [SchemaAttr(0, "customListSort")]
        [Index(2)]
        public BooleanValue CustomListSort { get; set; }

        /// <summary>
        /// <para>showMissing, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showMissing</para>
        /// </summary>
        [SchemaAttr(0, "showMissing")]
        [Index(3)]
        public BooleanValue ShowMissing { get; set; }

        /// <summary>
        /// <para>crossFilter, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: crossFilter</para>
        /// </summary>
        [SchemaAttr(0, "crossFilter")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues> CrossFilter { get; set; }

        /// <summary>
        /// <para>TabularSlicerCacheItems.</para>
        /// <para>Represents the following element tag in the schema: x14:items.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public TabularSlicerCacheItems TabularSlicerCacheItems
        {
            get => GetElement<TabularSlicerCacheItems>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheItems), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TabularSlicerCache>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCachePivotTable Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotTable.</para>
    /// </summary>
    [SchemaAttr(53, "pivotTable")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerCachePivotTable : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCachePivotTable class.
        /// </summary>
        public SlicerCachePivotTable() : base()
        {
        }

        /// <summary>
        /// <para>tabId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tabId</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "tabId")]
        [Index(0)]
        public UInt32Value TabId { get; set; }

        /// <summary>
        /// <para>name, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(1)]
        public StringValue Name { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCachePivotTable>(deep);
    }

    /// <summary>
    /// <para>Defines the OlapSlicerCacheItemParent Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:p.</para>
    /// </summary>
    [SchemaAttr(53, "p")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class OlapSlicerCacheItemParent : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheItemParent class.
        /// </summary>
        public OlapSlicerCacheItemParent() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "n")]
        [Index(0)]
        public StringValue Name { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheItemParent>(deep);
    }

    /// <summary>
    /// <para>Defines the OlapSlicerCacheItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:i.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OlapSlicerCacheItemParent &lt;x14:p></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OlapSlicerCacheItemParent), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "i")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class OlapSlicerCacheItem : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheItem class.
        /// </summary>
        public OlapSlicerCacheItem() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheItem class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheItem(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheItem class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheItem(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheItem class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OlapSlicerCacheItem(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "n")]
        [Index(0)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>c, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: c</para>
        /// </summary>
        [SchemaAttr(0, "c")]
        [Index(1)]
        public StringValue DisplayName { get; set; }

        /// <summary>
        /// <para>nd, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: nd</para>
        /// </summary>
        [SchemaAttr(0, "nd")]
        [Index(2)]
        public BooleanValue NonDisplay { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheItemParent), 0, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheItem>(deep);
    }

    /// <summary>
    /// <para>Defines the OlapSlicerCacheRange Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:range.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OlapSlicerCacheItem &lt;x14:i></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OlapSlicerCacheItem), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "range")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class OlapSlicerCacheRange : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheRange class.
        /// </summary>
        public OlapSlicerCacheRange() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheRange class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheRange(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheRange class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheRange(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheRange class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OlapSlicerCacheRange(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>startItem, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: startItem</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "startItem")]
        [Index(0)]
        public UInt32Value StartItem { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheItem), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheRange>(deep);
    }

    /// <summary>
    /// <para>Defines the OlapSlicerCacheRanges Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:ranges.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OlapSlicerCacheRange &lt;x14:range></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OlapSlicerCacheRange), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "ranges")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class OlapSlicerCacheRanges : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheRanges class.
        /// </summary>
        public OlapSlicerCacheRanges() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheRanges class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheRanges(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheRanges class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheRanges(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheRanges class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OlapSlicerCacheRanges(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheRange), 0, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheRanges>(deep);
    }

    /// <summary>
    /// <para>Defines the OlapSlicerCacheLevelData Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:level.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OlapSlicerCacheRanges &lt;x14:ranges></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OlapSlicerCacheRanges), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "level")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class OlapSlicerCacheLevelData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheLevelData class.
        /// </summary>
        public OlapSlicerCacheLevelData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheLevelData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheLevelData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheLevelData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheLevelData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheLevelData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OlapSlicerCacheLevelData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>uniqueName, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: uniqueName</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "uniqueName")]
        [Index(0)]
        public StringValue UniqueName { get; set; }

        /// <summary>
        /// <para>sourceCaption, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sourceCaption</para>
        /// </summary>
        [SchemaAttr(0, "sourceCaption")]
        [Index(1)]
        public StringValue SourceCaption { get; set; }

        /// <summary>
        /// <para>count, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "count")]
        [Index(2)]
        public UInt32Value Count { get; set; }

        /// <summary>
        /// <para>sortOrder, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sortOrder</para>
        /// </summary>
        [SchemaAttr(0, "sortOrder")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheSortOrderValues> SortOrder { get; set; }

        /// <summary>
        /// <para>crossFilter, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: crossFilter</para>
        /// </summary>
        [SchemaAttr(0, "crossFilter")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues> CrossFilter { get; set; }

        /// <summary>
        /// <para>OlapSlicerCacheRanges.</para>
        /// <para>Represents the following element tag in the schema: x14:ranges.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public OlapSlicerCacheRanges OlapSlicerCacheRanges
        {
            get => GetElement<OlapSlicerCacheRanges>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheRanges), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheLevelData>(deep);
    }

    /// <summary>
    /// <para>Defines the OlapSlicerCacheLevelsData Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:levels.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OlapSlicerCacheLevelData &lt;x14:level></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OlapSlicerCacheLevelData), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "levels")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class OlapSlicerCacheLevelsData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheLevelsData class.
        /// </summary>
        public OlapSlicerCacheLevelsData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheLevelsData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheLevelsData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheLevelsData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheLevelsData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheLevelsData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OlapSlicerCacheLevelsData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr(0, "count")]
        [Index(0)]
        public UInt32Value Count { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheLevelData), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheLevelsData>(deep);
    }

    /// <summary>
    /// <para>Defines the OlapSlicerCacheSelections Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:selections.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OlapSlicerCacheSelection &lt;x14:selection></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OlapSlicerCacheSelection), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "selections")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class OlapSlicerCacheSelections : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheSelections class.
        /// </summary>
        public OlapSlicerCacheSelections() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheSelections class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheSelections(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheSelections class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheSelections(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheSelections class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OlapSlicerCacheSelections(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr(0, "count")]
        [Index(0)]
        public UInt32Value Count { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheSelection), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheSelections>(deep);
    }

    /// <summary>
    /// <para>Defines the OlapSlicerCacheSelection Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:selection.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OlapSlicerCacheItemParent &lt;x14:p></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OlapSlicerCacheItemParent), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "selection")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class OlapSlicerCacheSelection : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheSelection class.
        /// </summary>
        public OlapSlicerCacheSelection() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheSelection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheSelection(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheSelection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OlapSlicerCacheSelection(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OlapSlicerCacheSelection class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OlapSlicerCacheSelection(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "n")]
        [Index(0)]
        public StringValue Name { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheItemParent), 0, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheSelection>(deep);
    }

    /// <summary>
    /// <para>Defines the TabularSlicerCacheItems Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:items.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TabularSlicerCacheItem &lt;x14:i></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(TabularSlicerCacheItem), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "items")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TabularSlicerCacheItems : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TabularSlicerCacheItems class.
        /// </summary>
        public TabularSlicerCacheItems() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TabularSlicerCacheItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TabularSlicerCacheItems(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TabularSlicerCacheItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TabularSlicerCacheItems(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TabularSlicerCacheItems class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TabularSlicerCacheItems(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr(0, "count")]
        [Index(0)]
        public UInt32Value Count { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheItem), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TabularSlicerCacheItems>(deep);
    }

    /// <summary>
    /// <para>Defines the TabularSlicerCacheItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:i.</para>
    /// </summary>
    [SchemaAttr(53, "i")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TabularSlicerCacheItem : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TabularSlicerCacheItem class.
        /// </summary>
        public TabularSlicerCacheItem() : base()
        {
        }

        /// <summary>
        /// <para>x, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "x")]
        [Index(0)]
        public UInt32Value Atom { get; set; }

        /// <summary>
        /// <para>s, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: s</para>
        /// </summary>
        [SchemaAttr(0, "s")]
        [Index(1)]
        public BooleanValue IsSelected { get; set; }

        /// <summary>
        /// <para>nd, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: nd</para>
        /// </summary>
        [SchemaAttr(0, "nd")]
        [Index(2)]
        public BooleanValue NonDisplay { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TabularSlicerCacheItem>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCachePivotTables Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotTables.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlicerCachePivotTable &lt;x14:pivotTable></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(SlicerCachePivotTable), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "pivotTables")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerCachePivotTables : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCachePivotTables class.
        /// </summary>
        public SlicerCachePivotTables() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCachePivotTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCachePivotTables(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCachePivotTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCachePivotTables(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCachePivotTables class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerCachePivotTables(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable), 1, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCachePivotTables>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCacheData Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:data.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OlapSlicerCache &lt;x14:olap></description></item>
    ///   <item><description>TabularSlicerCache &lt;x14:tabular></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OlapSlicerCache), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TabularSlicerCache), FileFormatVersions.Office2010)]
    [SchemaAttr(53, "data")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerCacheData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCacheData class.
        /// </summary>
        public SlicerCacheData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCacheData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCacheData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerCacheData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>OlapSlicerCache.</para>
        /// <para>Represents the following element tag in the schema: x14:olap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public OlapSlicerCache OlapSlicerCache
        {
            get => GetElement<OlapSlicerCache>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TabularSlicerCache.</para>
        /// <para>Represents the following element tag in the schema: x14:tabular.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public TabularSlicerCache TabularSlicerCache
        {
            get => GetElement<TabularSlicerCache>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCache), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCache), 1, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheData>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCacheDefinitionExtensionList Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.SlicerCacheDefinitionExtension &lt;x:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SlicerCacheDefinitionExtension))]
    [SchemaAttr(53, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SlicerCacheDefinitionExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCacheDefinitionExtensionList class.
        /// </summary>
        public SlicerCacheDefinitionExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheDefinitionExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCacheDefinitionExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheDefinitionExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCacheDefinitionExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheDefinitionExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerCacheDefinitionExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SlicerCacheDefinitionExtension), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheDefinitionExtensionList>(deep);
    }

    /// <summary>
    /// Defines the DisplayBlanksAsValues enumeration.
    /// </summary>
    public enum DisplayBlanksAsValues
    {
        ///<summary>
        ///span.
        ///<para>When the item is serialized out as xml, its value is "span".</para>
        ///</summary>
        [EnumString("span")]
        Span,
        ///<summary>
        ///gap.
        ///<para>When the item is serialized out as xml, its value is "gap".</para>
        ///</summary>
        [EnumString("gap")]
        Gap,
        ///<summary>
        ///zero.
        ///<para>When the item is serialized out as xml, its value is "zero".</para>
        ///</summary>
        [EnumString("zero")]
        Zero,
    }

    /// <summary>
    /// Defines the SparklineAxisMinMaxValues enumeration.
    /// </summary>
    public enum SparklineAxisMinMaxValues
    {
        ///<summary>
        ///individual.
        ///<para>When the item is serialized out as xml, its value is "individual".</para>
        ///</summary>
        [EnumString("individual")]
        Individual,
        ///<summary>
        ///group.
        ///<para>When the item is serialized out as xml, its value is "group".</para>
        ///</summary>
        [EnumString("group")]
        Group,
        ///<summary>
        ///custom.
        ///<para>When the item is serialized out as xml, its value is "custom".</para>
        ///</summary>
        [EnumString("custom")]
        Custom,
    }

    /// <summary>
    /// Defines the SparklineTypeValues enumeration.
    /// </summary>
    public enum SparklineTypeValues
    {
        ///<summary>
        ///line.
        ///<para>When the item is serialized out as xml, its value is "line".</para>
        ///</summary>
        [EnumString("line")]
        Line,
        ///<summary>
        ///column.
        ///<para>When the item is serialized out as xml, its value is "column".</para>
        ///</summary>
        [EnumString("column")]
        Column,
        ///<summary>
        ///stacked.
        ///<para>When the item is serialized out as xml, its value is "stacked".</para>
        ///</summary>
        [EnumString("stacked")]
        Stacked,
    }

    /// <summary>
    /// Defines the PivotShowAsValues enumeration.
    /// </summary>
    public enum PivotShowAsValues
    {
        ///<summary>
        ///percentOfParent.
        ///<para>When the item is serialized out as xml, its value is "percentOfParent".</para>
        ///</summary>
        [EnumString("percentOfParent")]
        PercentOfParent,
        ///<summary>
        ///percentOfParentRow.
        ///<para>When the item is serialized out as xml, its value is "percentOfParentRow".</para>
        ///</summary>
        [EnumString("percentOfParentRow")]
        PercentOfParentRow,
        ///<summary>
        ///percentOfParentCol.
        ///<para>When the item is serialized out as xml, its value is "percentOfParentCol".</para>
        ///</summary>
        [EnumString("percentOfParentCol")]
        PercentOfParentColumn,
        ///<summary>
        ///percentOfRunningTotal.
        ///<para>When the item is serialized out as xml, its value is "percentOfRunningTotal".</para>
        ///</summary>
        [EnumString("percentOfRunningTotal")]
        PercentOfRunningTotal,
        ///<summary>
        ///rankAscending.
        ///<para>When the item is serialized out as xml, its value is "rankAscending".</para>
        ///</summary>
        [EnumString("rankAscending")]
        RankAscending,
        ///<summary>
        ///rankDescending.
        ///<para>When the item is serialized out as xml, its value is "rankDescending".</para>
        ///</summary>
        [EnumString("rankDescending")]
        RankDescending,
    }

    /// <summary>
    /// Defines the DataBarDirectionValues enumeration.
    /// </summary>
    public enum DataBarDirectionValues
    {
        ///<summary>
        ///context.
        ///<para>When the item is serialized out as xml, its value is "context".</para>
        ///</summary>
        [EnumString("context")]
        Context,
        ///<summary>
        ///leftToRight.
        ///<para>When the item is serialized out as xml, its value is "leftToRight".</para>
        ///</summary>
        [EnumString("leftToRight")]
        LeftToRight,
        ///<summary>
        ///rightToLeft.
        ///<para>When the item is serialized out as xml, its value is "rightToLeft".</para>
        ///</summary>
        [EnumString("rightToLeft")]
        RightToLeft,
    }

    /// <summary>
    /// Defines the DataBarAxisPositionValues enumeration.
    /// </summary>
    public enum DataBarAxisPositionValues
    {
        ///<summary>
        ///automatic.
        ///<para>When the item is serialized out as xml, its value is "automatic".</para>
        ///</summary>
        [EnumString("automatic")]
        Automatic,
        ///<summary>
        ///middle.
        ///<para>When the item is serialized out as xml, its value is "middle".</para>
        ///</summary>
        [EnumString("middle")]
        Middle,
        ///<summary>
        ///none.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
    }

    /// <summary>
    /// Defines the ConditionalFormattingValueObjectTypeValues enumeration.
    /// </summary>
    public enum ConditionalFormattingValueObjectTypeValues
    {
        ///<summary>
        ///num.
        ///<para>When the item is serialized out as xml, its value is "num".</para>
        ///</summary>
        [EnumString("num")]
        Numeric,
        ///<summary>
        ///percent.
        ///<para>When the item is serialized out as xml, its value is "percent".</para>
        ///</summary>
        [EnumString("percent")]
        Percent,
        ///<summary>
        ///max.
        ///<para>When the item is serialized out as xml, its value is "max".</para>
        ///</summary>
        [EnumString("max")]
        Max,
        ///<summary>
        ///min.
        ///<para>When the item is serialized out as xml, its value is "min".</para>
        ///</summary>
        [EnumString("min")]
        Min,
        ///<summary>
        ///formula.
        ///<para>When the item is serialized out as xml, its value is "formula".</para>
        ///</summary>
        [EnumString("formula")]
        Formula,
        ///<summary>
        ///percentile.
        ///<para>When the item is serialized out as xml, its value is "percentile".</para>
        ///</summary>
        [EnumString("percentile")]
        Percentile,
        ///<summary>
        ///autoMin.
        ///<para>When the item is serialized out as xml, its value is "autoMin".</para>
        ///</summary>
        [EnumString("autoMin")]
        AutoMin,
        ///<summary>
        ///autoMax.
        ///<para>When the item is serialized out as xml, its value is "autoMax".</para>
        ///</summary>
        [EnumString("autoMax")]
        AutoMax,
    }

    /// <summary>
    /// Defines the IconSetTypeValues enumeration.
    /// </summary>
    public enum IconSetTypeValues
    {
        ///<summary>
        ///3Arrows.
        ///<para>When the item is serialized out as xml, its value is "3Arrows".</para>
        ///</summary>
        [EnumString("3Arrows")]
        ThreeArrows,
        ///<summary>
        ///3ArrowsGray.
        ///<para>When the item is serialized out as xml, its value is "3ArrowsGray".</para>
        ///</summary>
        [EnumString("3ArrowsGray")]
        ThreeArrowsGray,
        ///<summary>
        ///3Flags.
        ///<para>When the item is serialized out as xml, its value is "3Flags".</para>
        ///</summary>
        [EnumString("3Flags")]
        ThreeFlags,
        ///<summary>
        ///3TrafficLights1.
        ///<para>When the item is serialized out as xml, its value is "3TrafficLights1".</para>
        ///</summary>
        [EnumString("3TrafficLights1")]
        ThreeTrafficLights1,
        ///<summary>
        ///3TrafficLights2.
        ///<para>When the item is serialized out as xml, its value is "3TrafficLights2".</para>
        ///</summary>
        [EnumString("3TrafficLights2")]
        ThreeTrafficLights2,
        ///<summary>
        ///3Signs.
        ///<para>When the item is serialized out as xml, its value is "3Signs".</para>
        ///</summary>
        [EnumString("3Signs")]
        ThreeSigns,
        ///<summary>
        ///3Symbols.
        ///<para>When the item is serialized out as xml, its value is "3Symbols".</para>
        ///</summary>
        [EnumString("3Symbols")]
        ThreeSymbols,
        ///<summary>
        ///3Symbols2.
        ///<para>When the item is serialized out as xml, its value is "3Symbols2".</para>
        ///</summary>
        [EnumString("3Symbols2")]
        ThreeSymbols2,
        ///<summary>
        ///4Arrows.
        ///<para>When the item is serialized out as xml, its value is "4Arrows".</para>
        ///</summary>
        [EnumString("4Arrows")]
        FourArrows,
        ///<summary>
        ///4ArrowsGray.
        ///<para>When the item is serialized out as xml, its value is "4ArrowsGray".</para>
        ///</summary>
        [EnumString("4ArrowsGray")]
        FourArrowsGray,
        ///<summary>
        ///4RedToBlack.
        ///<para>When the item is serialized out as xml, its value is "4RedToBlack".</para>
        ///</summary>
        [EnumString("4RedToBlack")]
        FourRedToBlack,
        ///<summary>
        ///4Rating.
        ///<para>When the item is serialized out as xml, its value is "4Rating".</para>
        ///</summary>
        [EnumString("4Rating")]
        FourRating,
        ///<summary>
        ///4TrafficLights.
        ///<para>When the item is serialized out as xml, its value is "4TrafficLights".</para>
        ///</summary>
        [EnumString("4TrafficLights")]
        FourTrafficLights,
        ///<summary>
        ///5Arrows.
        ///<para>When the item is serialized out as xml, its value is "5Arrows".</para>
        ///</summary>
        [EnumString("5Arrows")]
        FiveArrows,
        ///<summary>
        ///5ArrowsGray.
        ///<para>When the item is serialized out as xml, its value is "5ArrowsGray".</para>
        ///</summary>
        [EnumString("5ArrowsGray")]
        FiveArrowsGray,
        ///<summary>
        ///5Rating.
        ///<para>When the item is serialized out as xml, its value is "5Rating".</para>
        ///</summary>
        [EnumString("5Rating")]
        FiveRating,
        ///<summary>
        ///5Quarters.
        ///<para>When the item is serialized out as xml, its value is "5Quarters".</para>
        ///</summary>
        [EnumString("5Quarters")]
        FiveQuarters,
        ///<summary>
        ///3Stars.
        ///<para>When the item is serialized out as xml, its value is "3Stars".</para>
        ///</summary>
        [EnumString("3Stars")]
        ThreeStars,
        ///<summary>
        ///3Triangles.
        ///<para>When the item is serialized out as xml, its value is "3Triangles".</para>
        ///</summary>
        [EnumString("3Triangles")]
        ThreeTriangles,
        ///<summary>
        ///5Boxes.
        ///<para>When the item is serialized out as xml, its value is "5Boxes".</para>
        ///</summary>
        [EnumString("5Boxes")]
        FiveBoxes,
        ///<summary>
        ///NoIcons.
        ///<para>When the item is serialized out as xml, its value is "NoIcons".</para>
        ///</summary>
        [EnumString("NoIcons")]
        NoIcons,
    }

    /// <summary>
    /// Defines the PivotEditValueTypeValues enumeration.
    /// </summary>
    public enum PivotEditValueTypeValues
    {
        ///<summary>
        ///number.
        ///<para>When the item is serialized out as xml, its value is "number".</para>
        ///</summary>
        [EnumString("number")]
        Number,
        ///<summary>
        ///dateTime.
        ///<para>When the item is serialized out as xml, its value is "dateTime".</para>
        ///</summary>
        [EnumString("dateTime")]
        DateTime,
        ///<summary>
        ///string.
        ///<para>When the item is serialized out as xml, its value is "string".</para>
        ///</summary>
        [EnumString("string")]
        String,
        ///<summary>
        ///boolean.
        ///<para>When the item is serialized out as xml, its value is "boolean".</para>
        ///</summary>
        [EnumString("boolean")]
        Boolean,
        ///<summary>
        ///error.
        ///<para>When the item is serialized out as xml, its value is "error".</para>
        ///</summary>
        [EnumString("error")]
        Error,
    }

    /// <summary>
    /// Defines the AllocationMethodValues enumeration.
    /// </summary>
    public enum AllocationMethodValues
    {
        ///<summary>
        ///equalAllocation.
        ///<para>When the item is serialized out as xml, its value is "equalAllocation".</para>
        ///</summary>
        [EnumString("equalAllocation")]
        EqualAllocation,
        ///<summary>
        ///equalIncrement.
        ///<para>When the item is serialized out as xml, its value is "equalIncrement".</para>
        ///</summary>
        [EnumString("equalIncrement")]
        EqualIncrement,
        ///<summary>
        ///weightedAllocation.
        ///<para>When the item is serialized out as xml, its value is "weightedAllocation".</para>
        ///</summary>
        [EnumString("weightedAllocation")]
        WeightedAllocation,
        ///<summary>
        ///weightedIncrement.
        ///<para>When the item is serialized out as xml, its value is "weightedIncrement".</para>
        ///</summary>
        [EnumString("weightedIncrement")]
        WeightedIncrement,
    }

    /// <summary>
    /// Defines the SlicerStyleTypeValues enumeration.
    /// </summary>
    public enum SlicerStyleTypeValues
    {
        ///<summary>
        ///unselectedItemWithData.
        ///<para>When the item is serialized out as xml, its value is "unselectedItemWithData".</para>
        ///</summary>
        [EnumString("unselectedItemWithData")]
        UnselectedItemWithData,
        ///<summary>
        ///selectedItemWithData.
        ///<para>When the item is serialized out as xml, its value is "selectedItemWithData".</para>
        ///</summary>
        [EnumString("selectedItemWithData")]
        SelectedItemWithData,
        ///<summary>
        ///unselectedItemWithNoData.
        ///<para>When the item is serialized out as xml, its value is "unselectedItemWithNoData".</para>
        ///</summary>
        [EnumString("unselectedItemWithNoData")]
        UnselectedItemWithNoData,
        ///<summary>
        ///selectedItemWithNoData.
        ///<para>When the item is serialized out as xml, its value is "selectedItemWithNoData".</para>
        ///</summary>
        [EnumString("selectedItemWithNoData")]
        SelectedItemWithNoData,
        ///<summary>
        ///hoveredUnselectedItemWithData.
        ///<para>When the item is serialized out as xml, its value is "hoveredUnselectedItemWithData".</para>
        ///</summary>
        [EnumString("hoveredUnselectedItemWithData")]
        HoveredUnselectedItemWithData,
        ///<summary>
        ///hoveredSelectedItemWithData.
        ///<para>When the item is serialized out as xml, its value is "hoveredSelectedItemWithData".</para>
        ///</summary>
        [EnumString("hoveredSelectedItemWithData")]
        HoveredSelectedItemWithData,
        ///<summary>
        ///hoveredUnselectedItemWithNoData.
        ///<para>When the item is serialized out as xml, its value is "hoveredUnselectedItemWithNoData".</para>
        ///</summary>
        [EnumString("hoveredUnselectedItemWithNoData")]
        HoveredUnselectedItemWithNoData,
        ///<summary>
        ///hoveredSelectedItemWithNoData.
        ///<para>When the item is serialized out as xml, its value is "hoveredSelectedItemWithNoData".</para>
        ///</summary>
        [EnumString("hoveredSelectedItemWithNoData")]
        HoveredSelectedItemWithNoData,
    }

    /// <summary>
    /// Defines the CheckedValues enumeration.
    /// </summary>
    public enum CheckedValues
    {
        ///<summary>
        ///Unchecked.
        ///<para>When the item is serialized out as xml, its value is "Unchecked".</para>
        ///</summary>
        [EnumString("Unchecked")]
        Unchecked,
        ///<summary>
        ///Checked.
        ///<para>When the item is serialized out as xml, its value is "Checked".</para>
        ///</summary>
        [EnumString("Checked")]
        Checked,
        ///<summary>
        ///Mixed.
        ///<para>When the item is serialized out as xml, its value is "Mixed".</para>
        ///</summary>
        [EnumString("Mixed")]
        Mixed,
    }

    /// <summary>
    /// Defines the DropStyleValues enumeration.
    /// </summary>
    public enum DropStyleValues
    {
        ///<summary>
        ///combo.
        ///<para>When the item is serialized out as xml, its value is "combo".</para>
        ///</summary>
        [EnumString("combo")]
        Combo,
        ///<summary>
        ///comboedit.
        ///<para>When the item is serialized out as xml, its value is "comboedit".</para>
        ///</summary>
        [EnumString("comboedit")]
        ComboEdit,
        ///<summary>
        ///simple.
        ///<para>When the item is serialized out as xml, its value is "simple".</para>
        ///</summary>
        [EnumString("simple")]
        Simple,
    }

    /// <summary>
    /// Defines the SelectionTypeValues enumeration.
    /// </summary>
    public enum SelectionTypeValues
    {
        ///<summary>
        ///single.
        ///<para>When the item is serialized out as xml, its value is "single".</para>
        ///</summary>
        [EnumString("single")]
        Single,
        ///<summary>
        ///multi.
        ///<para>When the item is serialized out as xml, its value is "multi".</para>
        ///</summary>
        [EnumString("multi")]
        Multiple,
        ///<summary>
        ///extended.
        ///<para>When the item is serialized out as xml, its value is "extended".</para>
        ///</summary>
        [EnumString("extended")]
        Extended,
    }

    /// <summary>
    /// Defines the TextHorizontalAlignmentValues enumeration.
    /// </summary>
    public enum TextHorizontalAlignmentValues
    {
        ///<summary>
        ///left.
        ///<para>When the item is serialized out as xml, its value is "left".</para>
        ///</summary>
        [EnumString("left")]
        Left,
        ///<summary>
        ///center.
        ///<para>When the item is serialized out as xml, its value is "center".</para>
        ///</summary>
        [EnumString("center")]
        Center,
        ///<summary>
        ///right.
        ///<para>When the item is serialized out as xml, its value is "right".</para>
        ///</summary>
        [EnumString("right")]
        Right,
        ///<summary>
        ///justify.
        ///<para>When the item is serialized out as xml, its value is "justify".</para>
        ///</summary>
        [EnumString("justify")]
        Justify,
        ///<summary>
        ///distributed.
        ///<para>When the item is serialized out as xml, its value is "distributed".</para>
        ///</summary>
        [EnumString("distributed")]
        Distributed,
    }

    /// <summary>
    /// Defines the TextVerticalAlignmentValues enumeration.
    /// </summary>
    public enum TextVerticalAlignmentValues
    {
        ///<summary>
        ///top.
        ///<para>When the item is serialized out as xml, its value is "top".</para>
        ///</summary>
        [EnumString("top")]
        Top,
        ///<summary>
        ///center.
        ///<para>When the item is serialized out as xml, its value is "center".</para>
        ///</summary>
        [EnumString("center")]
        Center,
        ///<summary>
        ///bottom.
        ///<para>When the item is serialized out as xml, its value is "bottom".</para>
        ///</summary>
        [EnumString("bottom")]
        Bottom,
        ///<summary>
        ///justify.
        ///<para>When the item is serialized out as xml, its value is "justify".</para>
        ///</summary>
        [EnumString("justify")]
        Justify,
        ///<summary>
        ///distributed.
        ///<para>When the item is serialized out as xml, its value is "distributed".</para>
        ///</summary>
        [EnumString("distributed")]
        Distributed,
    }

    /// <summary>
    /// Defines the EditValidationValues enumeration.
    /// </summary>
    public enum EditValidationValues
    {
        ///<summary>
        ///text.
        ///<para>When the item is serialized out as xml, its value is "text".</para>
        ///</summary>
        [EnumString("text")]
        Text,
        ///<summary>
        ///integer.
        ///<para>When the item is serialized out as xml, its value is "integer".</para>
        ///</summary>
        [EnumString("integer")]
        Integer,
        ///<summary>
        ///number.
        ///<para>When the item is serialized out as xml, its value is "number".</para>
        ///</summary>
        [EnumString("number")]
        Number,
        ///<summary>
        ///reference.
        ///<para>When the item is serialized out as xml, its value is "reference".</para>
        ///</summary>
        [EnumString("reference")]
        Reference,
        ///<summary>
        ///formula.
        ///<para>When the item is serialized out as xml, its value is "formula".</para>
        ///</summary>
        [EnumString("formula")]
        Formula,
    }

    /// <summary>
    /// Defines the OlapSlicerCacheSortOrderValues enumeration.
    /// </summary>
    public enum OlapSlicerCacheSortOrderValues
    {
        ///<summary>
        ///natural.
        ///<para>When the item is serialized out as xml, its value is "natural".</para>
        ///</summary>
        [EnumString("natural")]
        Natural,
        ///<summary>
        ///ascending.
        ///<para>When the item is serialized out as xml, its value is "ascending".</para>
        ///</summary>
        [EnumString("ascending")]
        Ascending,
        ///<summary>
        ///descending.
        ///<para>When the item is serialized out as xml, its value is "descending".</para>
        ///</summary>
        [EnumString("descending")]
        Descending,
    }

    /// <summary>
    /// Defines the TabularSlicerCacheSortOrderValues enumeration.
    /// </summary>
    public enum TabularSlicerCacheSortOrderValues
    {
        ///<summary>
        ///ascending.
        ///<para>When the item is serialized out as xml, its value is "ascending".</para>
        ///</summary>
        [EnumString("ascending")]
        Ascending,
        ///<summary>
        ///descending.
        ///<para>When the item is serialized out as xml, its value is "descending".</para>
        ///</summary>
        [EnumString("descending")]
        Descending,
    }

    /// <summary>
    /// Defines the SlicerCacheCrossFilterValues enumeration.
    /// </summary>
    public enum SlicerCacheCrossFilterValues
    {
        ///<summary>
        ///none.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///showItemsWithDataAtTop.
        ///<para>When the item is serialized out as xml, its value is "showItemsWithDataAtTop".</para>
        ///</summary>
        [EnumString("showItemsWithDataAtTop")]
        ShowItemsWithDataAtTop,
        ///<summary>
        ///showItemsWithNoData.
        ///<para>When the item is serialized out as xml, its value is "showItemsWithNoData".</para>
        ///</summary>
        [EnumString("showItemsWithNoData")]
        ShowItemsWithNoData,
    }

    /// <summary>
    /// Defines the ObjectTypeValues enumeration.
    /// </summary>
    public enum ObjectTypeValues
    {
        ///<summary>
        ///Button.
        ///<para>When the item is serialized out as xml, its value is "Button".</para>
        ///</summary>
        [EnumString("Button")]
        Button,
        ///<summary>
        ///CheckBox.
        ///<para>When the item is serialized out as xml, its value is "CheckBox".</para>
        ///</summary>
        [EnumString("CheckBox")]
        CheckBox,
        ///<summary>
        ///Drop.
        ///<para>When the item is serialized out as xml, its value is "Drop".</para>
        ///</summary>
        [EnumString("Drop")]
        Drop,
        ///<summary>
        ///GBox.
        ///<para>When the item is serialized out as xml, its value is "GBox".</para>
        ///</summary>
        [EnumString("GBox")]
        GroupBox,
        ///<summary>
        ///Label.
        ///<para>When the item is serialized out as xml, its value is "Label".</para>
        ///</summary>
        [EnumString("Label")]
        Label,
        ///<summary>
        ///List.
        ///<para>When the item is serialized out as xml, its value is "List".</para>
        ///</summary>
        [EnumString("List")]
        List,
        ///<summary>
        ///Radio.
        ///<para>When the item is serialized out as xml, its value is "Radio".</para>
        ///</summary>
        [EnumString("Radio")]
        Radio,
        ///<summary>
        ///Scroll.
        ///<para>When the item is serialized out as xml, its value is "Scroll".</para>
        ///</summary>
        [EnumString("Scroll")]
        Scroll,
        ///<summary>
        ///Spin.
        ///<para>When the item is serialized out as xml, its value is "Spin".</para>
        ///</summary>
        [EnumString("Spin")]
        Spin,
        ///<summary>
        ///EditBox.
        ///<para>When the item is serialized out as xml, its value is "EditBox".</para>
        ///</summary>
        [EnumString("EditBox")]
        EditBox,
        ///<summary>
        ///Dialog.
        ///<para>When the item is serialized out as xml, its value is "Dialog".</para>
        ///</summary>
        [EnumString("Dialog")]
        Dialog,
    }
}