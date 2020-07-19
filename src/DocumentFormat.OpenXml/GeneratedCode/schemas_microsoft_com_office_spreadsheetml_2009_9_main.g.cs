// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "conditionalFormattings");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ConditionalFormatting>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormatting), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public BooleanValue DisablePrompts
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>xWindow, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: xWindow</para>
        /// </summary>
        public UInt32Value XWindow
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>yWindow, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: yWindow</para>
        /// </summary>
        public UInt32Value YWindow
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>count, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        public UInt32Value Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "dataValidations");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DataValidation>();
            builder.AddElement<DataValidations>()
.AddAttribute(0, "disablePrompts", a => a.DisablePrompts)
.AddAttribute(0, "xWindow", a => a.XWindow)
.AddAttribute(0, "yWindow", a => a.YWindow)
.AddAttribute(0, "count", a => a.Count);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DataValidation), 1, 0, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueRangeConstraint(1 /*:xWindow*/, true, double.NegativeInfinity, true, 65535, true) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueRangeConstraint(2 /*:yWindow*/, true, double.NegativeInfinity, true, 65535, true) { Application = ApplicationType.Excel, Version = FileFormatVersions.Office2010 });
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "sparklineGroups");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SparklineGroup>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SparklineGroup), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "slicerList");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SlicerRef>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerRef), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "protectedRanges");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ProtectedRange>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ProtectedRange), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "ignoredErrors");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<IgnoredError>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.IgnoredError), 0, 0, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "definedNames");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DefinedName>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DefinedName), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotCaches");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotCache>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotCache), 1, 0)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "slicerCaches");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SlicerCache>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCache), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCaches>(deep);
    }

    /// <summary>
    /// <para>Defines the WorkbookProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:workbookPr.</para>
    /// </summary>
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
        public UInt32Value DefaultImageDpi
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>discardImageEditData, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: discardImageEditData</para>
        /// </summary>
        public BooleanValue DiscardImageEditData
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>accuracyVersion, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: accuracyVersion</para>
        /// </summary>
        public UInt32Value AccuracyVersion
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "workbookPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<WorkbookProperties>()
.AddAttribute(0, "defaultImageDpi", a => a.DefaultImageDpi)
.AddAttribute(0, "discardImageEditData", a => a.DiscardImageEditData)
.AddAttribute(0, "accuracyVersion", a => a.AccuracyVersion);
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:defaultImageDpi*/, true, new string[] { "96", "150", "220" }) { Version = FileFormatVersions.Office2010 });
        }

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
        public StringValue DisplayFolder
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>flattenHierarchies, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: flattenHierarchies</para>
        /// </summary>
        public BooleanValue FlattenHierarchies
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dynamicSet, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dynamicSet</para>
        /// </summary>
        public BooleanValue DynamicSet
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hierarchizeDistinct, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hierarchizeDistinct</para>
        /// </summary>
        public BooleanValue HierarchizeDistinct
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mdxLong, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: mdxLong</para>
        /// </summary>
        public StringValue MdxLong
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "calculatedMember");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TupleSet>();
            builder.AddElement<CalculatedMember>()
.AddAttribute(0, "displayFolder", a => a.DisplayFolder)
.AddAttribute(0, "flattenHierarchies", a => a.FlattenHierarchies)
.AddAttribute(0, "dynamicSet", a => a.DynamicSet)
.AddAttribute(0, "hierarchizeDistinct", a => a.HierarchizeDistinct)
.AddAttribute(0, "mdxLong", a => a.MdxLong);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleSet), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:displayFolder*/, 0, 65535) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(4 /*:mdxLong*/, 32766, 1073741822) { Version = FileFormatVersions.Office2010 });
        }

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
        public BooleanValue FlattenHierarchies
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>measuresSet, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: measuresSet</para>
        /// </summary>
        public BooleanValue MeasuresSet
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hierarchizeDistinct, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hierarchizeDistinct</para>
        /// </summary>
        public BooleanValue HierarchizeDistinct
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ignore, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: ignore</para>
        /// </summary>
        public BooleanValue Ignore
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "cacheHierarchy");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SetLevels>();
            builder.AddElement<CacheHierarchy>()
.AddAttribute(0, "flattenHierarchies", a => a.FlattenHierarchies)
.AddAttribute(0, "measuresSet", a => a.MeasuresSet)
.AddAttribute(0, "hierarchizeDistinct", a => a.HierarchizeDistinct)
.AddAttribute(0, "ignore", a => a.Ignore);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SetLevels), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueConditionToAnother(0 /*:flattenHierarchies*/, 3 /*:ignore*/, new string[] { "false" }, new string[] { "true" }) { Application = ApplicationType.Excel, Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueConditionToAnother(1 /*:measuresSet*/, 3 /*:ignore*/, new string[] { "false" }, new string[] { "true" }) { Application = ApplicationType.Excel, Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueConditionToAnother(2 /*:hierarchizeDistinct*/, 3 /*:ignore*/, new string[] { "false" }, new string[] { "true" }) { Application = ApplicationType.Excel, Version = FileFormatVersions.Office2010 });
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CacheHierarchy>(deep);
    }

    /// <summary>
    /// <para>Defines the DataField Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:dataField.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.PivotShowAsValues> PivotShowAs
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.PivotShowAsValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sourceField, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sourceField</para>
        /// </summary>
        public UInt32Value SourceField
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uniqueName, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: uniqueName</para>
        /// </summary>
        public StringValue UniqueName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "dataField");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<DataField>()
.AddAttribute(0, "pivotShowAs", a => a.PivotShowAs)
.AddAttribute(0, "sourceField", a => a.SourceField)
.AddAttribute(0, "uniqueName", a => a.UniqueName);
            builder.AddConstraint(new UniqueAttributeValueConstraint(2 /*:uniqueName*/, true, null) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(2 /*:uniqueName*/, 0, 65535) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataField>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotField Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotField.</para>
    /// </summary>
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
        public BooleanValue FillDownLabels
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ignore, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: ignore</para>
        /// </summary>
        public BooleanValue Ignore
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotField");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<PivotField>()
.AddAttribute(0, "fillDownLabels", a => a.FillDownLabels)
.AddAttribute(0, "ignore", a => a.Ignore);
        }

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
        public BooleanValue FillDownLabelsDefault
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visualTotalsForSets, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visualTotalsForSets</para>
        /// </summary>
        public BooleanValue VisualTotalsForSets
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>calculatedMembersInFilters, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: calculatedMembersInFilters</para>
        /// </summary>
        public BooleanValue CalculatedMembersInFilters
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>altText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: altText</para>
        /// </summary>
        public StringValue AltText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>altTextSummary, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: altTextSummary</para>
        /// </summary>
        public StringValue AltTextSummary
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enableEdit, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: enableEdit</para>
        /// </summary>
        public BooleanValue EnableEdit
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>autoApply, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: autoApply</para>
        /// </summary>
        public BooleanValue AutoApply
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allocationMethod, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: allocationMethod</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.AllocationMethodValues> AllocationMethod
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.AllocationMethodValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>weightExpression, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: weightExpression</para>
        /// </summary>
        public StringValue WeightExpression
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hideValuesRow, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hideValuesRow</para>
        /// </summary>
        public BooleanValue HideValuesRow
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotTableDefinition");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<PivotEdits>();
            builder.AddChild<PivotChanges>();
            builder.AddChild<ConditionalFormats>();
            builder.AddElement<PivotTableDefinition>()
.AddAttribute(0, "fillDownLabelsDefault", a => a.FillDownLabelsDefault)
.AddAttribute(0, "visualTotalsForSets", a => a.VisualTotalsForSets)
.AddAttribute(0, "calculatedMembersInFilters", a => a.CalculatedMembersInFilters)
.AddAttribute(0, "altText", a => a.AltText)
.AddAttribute(0, "altTextSummary", a => a.AltTextSummary)
.AddAttribute(0, "enableEdit", a => a.EnableEdit)
.AddAttribute(0, "autoApply", a => a.AutoApply)
.AddAttribute(0, "allocationMethod", a => a.AllocationMethod)
.AddAttribute(0, "weightExpression", a => a.WeightExpression)
.AddAttribute(0, "hideValuesRow", a => a.HideValuesRow);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotEdits), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotChanges), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormats), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(3 /*:altText*/, 0, 2000) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(4 /*:altTextSummary*/, 0, 2000) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(8 /*:weightExpression*/, 0, 65535) { Version = FileFormatVersions.Office2010 });
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableDefinition>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotCacheDefinition Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotCacheDefinition.</para>
    /// </summary>
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
        public BooleanValue SlicerData
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pivotCacheId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pivotCacheId</para>
        /// </summary>
        public UInt32Value PivotCacheId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supportSubqueryNonVisual, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supportSubqueryNonVisual</para>
        /// </summary>
        public BooleanValue SupportSubqueryNonVisual
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supportSubqueryCalcMem, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supportSubqueryCalcMem</para>
        /// </summary>
        public BooleanValue SupportSubqueryCalcMem
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supportAddCalcMems, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: supportAddCalcMems</para>
        /// </summary>
        public BooleanValue SupportAddCalcMems
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotCacheDefinition");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<PivotCacheDefinition>()
.AddAttribute(0, "slicerData", a => a.SlicerData)
.AddAttribute(0, "pivotCacheId", a => a.PivotCacheId)
.AddAttribute(0, "supportSubqueryNonVisual", a => a.SupportSubqueryNonVisual)
.AddAttribute(0, "supportSubqueryCalcMem", a => a.SupportSubqueryCalcMem)
.AddAttribute(0, "supportAddCalcMems", a => a.SupportAddCalcMems);
        }

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
        public StringValue Culture
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>embeddedDataId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: embeddedDataId</para>
        /// </summary>
        public StringValue EmbeddedDataId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "connection");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<CalculatedMembers>();
            builder.AddElement<Connection>()
.AddAttribute(0, "culture", a => a.Culture)
.AddAttribute(0, "embeddedDataId", a => a.EmbeddedDataId);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.CalculatedMembers), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:culture*/, 0, 84) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(1 /*:embeddedDataId*/, 0, 65535) { Version = FileFormatVersions.Office2010 });
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Connection>(deep);
    }

    /// <summary>
    /// <para>Defines the Table Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:table.</para>
    /// </summary>
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
        public StringValue AltText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>altTextSummary, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: altTextSummary</para>
        /// </summary>
        public StringValue AltTextSummary
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "table");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Table>()
.AddAttribute(0, "altText", a => a.AltText)
.AddAttribute(0, "altTextSummary", a => a.AltTextSummary);
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:altText*/, 0, 25000) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(1 /*:altTextSummary*/, 0, 50000) { Version = FileFormatVersions.Office2010 });
        }

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
        public StringValue DefaultSlicerStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "slicerStyles");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SlicerStyle>();
            builder.AddElement<SlicerStyles>()
.AddAttribute(0, "defaultSlicerStyle", a => a.DefaultSlicerStyle, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerStyle), 0, 0, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:defaultSlicerStyle*/, 1, 255) { Version = FileFormatVersions.Office2010 });
        }

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
        public UInt32Value Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "dxfs");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat>();
            builder.AddElement<DifferentialFormats>()
.AddAttribute(0, "count", a => a.Count);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat), 0, 0)
            };
        }

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
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>icon, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: icon</para>
        /// </summary>
        public BooleanValue Icon
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>advise, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: advise</para>
        /// </summary>
        public BooleanValue Advise
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>preferPic, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: preferPic</para>
        /// </summary>
        public BooleanValue PreferPicture
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "oleItem");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DdeValues>();
            builder.AddElement<OleItem>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "icon", a => a.Icon)
.AddAttribute(0, "advise", a => a.Advise)
.AddAttribute(0, "preferPic", a => a.PreferPicture);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DdeValues), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OleItem>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotHierarchy Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotHierarchy.</para>
    /// </summary>
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
        public BooleanValue Ignore
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotHierarchy");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<PivotHierarchy>()
.AddAttribute(0, "ignore", a => a.Ignore);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotHierarchy>(deep);
    }

    /// <summary>
    /// <para>Defines the CacheField Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:cacheField.</para>
    /// </summary>
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
        public BooleanValue Ignore
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "cacheField");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<CacheField>()
.AddAttribute(0, "ignore", a => a.Ignore);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CacheField>(deep);
    }

    /// <summary>
    /// <para>Defines the Id Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:id.</para>
    /// </summary>
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
            builder.SetSchema(53, "id");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Id>(deep);
    }

    /// <summary>
    /// <para>Defines the IconFilter Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:iconFilter.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues> IconSet
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>iconId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: iconId</para>
        /// </summary>
        public UInt32Value IconId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "iconFilter");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<IconFilter>()
.AddAttribute(0, "iconSet", a => a.IconSet, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "iconId", a => a.IconId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IconFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the Filter Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:filter.</para>
    /// </summary>
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
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "filter");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Filter>()
.AddAttribute(0, "val", a => a.Val);
        }

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
        public BooleanValue And
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "customFilters");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<CustomFilter>();
            builder.AddElement<CustomFilters>()
.AddAttribute(0, "and", a => a.And);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.CustomFilter), 1, 2, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomFilters>(deep);
    }

    /// <summary>
    /// <para>Defines the SortCondition Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:sortCondition.</para>
    /// </summary>
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
        public BooleanValue Descending
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sortBy, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sortBy</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortByValues> SortBy
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortByValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        public StringValue Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>customList, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: customList</para>
        /// </summary>
        public StringValue CustomList
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dxfId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dxfId</para>
        /// </summary>
        public UInt32Value FormatId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>iconSet, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: iconSet</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues> IconSet
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>iconId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: iconId</para>
        /// </summary>
        public UInt32Value IconId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "sortCondition");
            builder.Availability = FileFormatVersions.Office2010;
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
            builder.AddConstraint(new AttributeAbsentConditionToValue(4 /*:dxfId*/, 1 /*:sortBy*/ , "icon", "value") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeAbsentConditionToNonValue(5 /*:iconSet*/, 1 /*:sortBy*/ , "icon") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeAbsentConditionToNonValue(6 /*:iconId*/, 1 /*:sortBy*/ , "icon") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SortCondition>(deep);
    }

    /// <summary>
    /// <para>Defines the SourceConnection Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:sourceConnection.</para>
    /// </summary>
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
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "sourceConnection");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<SourceConnection>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "datastoreItem");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ExtensionList>();
            builder.AddElement<DatastoreItem>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:id*/, 0, 65535) { Version = FileFormatVersions.Office2010 });
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.ObjectTypeValues> ObjectType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.ObjectTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>checked, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: checked</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.CheckedValues> Checked
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.CheckedValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>colored, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: colored</para>
        /// </summary>
        public BooleanValue Colored
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dropLines, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dropLines</para>
        /// </summary>
        public UInt32Value DropLines
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dropStyle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dropStyle</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DropStyleValues> DropStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DropStyleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dx, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dx</para>
        /// </summary>
        public UInt32Value ScrollBarWidth
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>firstButton, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: firstButton</para>
        /// </summary>
        public BooleanValue FirstButton
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fmlaGroup, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fmlaGroup</para>
        /// </summary>
        public StringValue FmlaGroup
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fmlaLink, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fmlaLink</para>
        /// </summary>
        public StringValue FmlaLink
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fmlaRange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fmlaRange</para>
        /// </summary>
        public StringValue FmlaRange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fmlaTxbx, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fmlaTxbx</para>
        /// </summary>
        public StringValue FmlaTextbox
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>horiz, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: horiz</para>
        /// </summary>
        public BooleanValue Horizontal
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>inc, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: inc</para>
        /// </summary>
        public UInt32Value Incremental
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>justLastX, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: justLastX</para>
        /// </summary>
        public BooleanValue JustLastX
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lockText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: lockText</para>
        /// </summary>
        public BooleanValue LockText
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>max, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: max</para>
        /// </summary>
        public UInt32Value Max
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>min, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: min</para>
        /// </summary>
        public UInt32Value Min
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>multiSel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: multiSel</para>
        /// </summary>
        public StringValue MultipleSelection
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noThreeD, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: noThreeD</para>
        /// </summary>
        public BooleanValue NoThreeD
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noThreeD2, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: noThreeD2</para>
        /// </summary>
        public BooleanValue NoThreeD2
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>page, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: page</para>
        /// </summary>
        public UInt32Value Page
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sel, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sel</para>
        /// </summary>
        public UInt32Value Selected
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>seltype, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: seltype</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SelectionTypeValues> SelectionType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SelectionTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>textHAlign, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: textHAlign</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TextHorizontalAlignmentValues> TextHorizontalAlign
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TextHorizontalAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>textVAlign, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: textVAlign</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TextVerticalAlignmentValues> TextVerticalAlign
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TextVerticalAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt32Value Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>widthMin, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: widthMin</para>
        /// </summary>
        public UInt32Value MinimumWidth
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>editVal, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: editVal</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.EditValidationValues> EditVal
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.EditValidationValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>multiLine, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: multiLine</para>
        /// </summary>
        public BooleanValue MultipleLines
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>verticalBar, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: verticalBar</para>
        /// </summary>
        public BooleanValue VerticalBar
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>passwordEdit, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: passwordEdit</para>
        /// </summary>
        public BooleanValue PasswordEdit
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "formControlPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ListItems>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<FormControlProperties>()
.AddAttribute(0, "objectType", a => a.ObjectType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "checked", a => a.Checked, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "colored", a => a.Colored)
.AddAttribute(0, "dropLines", a => a.DropLines)
.AddAttribute(0, "dropStyle", a => a.DropStyle, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "dx", a => a.ScrollBarWidth)
.AddAttribute(0, "firstButton", a => a.FirstButton)
.AddAttribute(0, "fmlaGroup", a => a.FmlaGroup)
.AddAttribute(0, "fmlaLink", a => a.FmlaLink)
.AddAttribute(0, "fmlaRange", a => a.FmlaRange)
.AddAttribute(0, "fmlaTxbx", a => a.FmlaTextbox)
.AddAttribute(0, "horiz", a => a.Horizontal)
.AddAttribute(0, "inc", a => a.Incremental)
.AddAttribute(0, "justLastX", a => a.JustLastX)
.AddAttribute(0, "lockText", a => a.LockText)
.AddAttribute(0, "max", a => a.Max)
.AddAttribute(0, "min", a => a.Min)
.AddAttribute(0, "multiSel", a => a.MultipleSelection)
.AddAttribute(0, "noThreeD", a => a.NoThreeD)
.AddAttribute(0, "noThreeD2", a => a.NoThreeD2)
.AddAttribute(0, "page", a => a.Page)
.AddAttribute(0, "sel", a => a.Selected)
.AddAttribute(0, "seltype", a => a.SelectionType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "textHAlign", a => a.TextHorizontalAlign)
.AddAttribute(0, "textVAlign", a => a.TextVerticalAlign)
.AddAttribute(0, "val", a => a.Val)
.AddAttribute(0, "widthMin", a => a.MinimumWidth)
.AddAttribute(0, "editVal", a => a.EditVal, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "multiLine", a => a.MultipleLines)
.AddAttribute(0, "verticalBar", a => a.VerticalBar)
.AddAttribute(0, "passwordEdit", a => a.PasswordEdit);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ListItems), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueRangeConstraint(3 /*:dropLines*/, true, 0, true, 30000, true) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueRangeConstraint(12 /*:inc*/, true, 0, true, 30000, true) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueRangeConstraint(15 /*:max*/, true, 0, true, 30000, true) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueRangeConstraint(16 /*:min*/, true, 0, true, 30000, true) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueRangeConstraint(20 /*:page*/, true, 0, true, 30000, true) { Version = FileFormatVersions.Office2010 });
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "slicers");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Slicer>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Slicer), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sourceName, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sourceName</para>
        /// </summary>
        public StringValue SourceName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "slicerCacheDefinition");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SlicerCachePivotTables>();
            builder.AddChild<SlicerCacheData>();
            builder.AddChild<SlicerCacheDefinitionExtensionList>();
            builder.AddElement<SlicerCacheDefinition>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "sourceName", a => a.SourceName, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTables), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheData), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheDefinitionExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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
        public BooleanValue Pivot
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "conditionalFormatting");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ConditionalFormattingRule>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<ConditionalFormatting>()
.AddAttribute(0, "pivot", a => a.Pivot);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingRule), 0, 0, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>priority, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: priority</para>
        /// </summary>
        public Int32Value Priority
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>stopIfTrue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: stopIfTrue</para>
        /// </summary>
        public BooleanValue StopIfTrue
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>aboveAverage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: aboveAverage</para>
        /// </summary>
        public BooleanValue AboveAverage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>percent, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: percent</para>
        /// </summary>
        public BooleanValue Percent
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bottom, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: bottom</para>
        /// </summary>
        public BooleanValue Bottom
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>operator, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: operator</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormattingOperatorValues> Operator
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormattingOperatorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>text, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: text</para>
        /// </summary>
        public StringValue Text
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>timePeriod, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: timePeriod</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.TimePeriodValues> TimePeriod
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.TimePeriodValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rank, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rank</para>
        /// </summary>
        public UInt32Value Rank
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>stdDev, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: stdDev</para>
        /// </summary>
        public Int32Value StandardDeviation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>equalAverage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: equalAverage</para>
        /// </summary>
        public BooleanValue EqualAverage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>activePresent, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: activePresent</para>
        /// </summary>
        public BooleanValue ActivePresent
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "cfRule");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.Formula>();
            builder.AddChild<ColorScale>();
            builder.AddChild<DataBar>();
            builder.AddChild<IconSet>();
            builder.AddChild<DifferentialType>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<ConditionalFormattingRule>()
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "priority", a => a.Priority)
.AddAttribute(0, "stopIfTrue", a => a.StopIfTrue)
.AddAttribute(0, "aboveAverage", a => a.AboveAverage)
.AddAttribute(0, "percent", a => a.Percent)
.AddAttribute(0, "bottom", a => a.Bottom)
.AddAttribute(0, "operator", a => a.Operator)
.AddAttribute(0, "text", a => a.Text)
.AddAttribute(0, "timePeriod", a => a.TimePeriod)
.AddAttribute(0, "rank", a => a.Rank)
.AddAttribute(0, "stdDev", a => a.StandardDeviation)
.AddAttribute(0, "equalAverage", a => a.EqualAverage)
.AddAttribute(0, "activePresent", a => a.ActivePresent)
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 0, 3),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ColorScale), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DataBar), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.IconSet), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DifferentialType), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueRangeConstraint(1 /*:priority*/, true, 0, false, double.PositiveInfinity, true) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new UniqueAttributeValueConstraint(1 /*:priority*/, true, null) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeAbsentConditionToNonValue(3 /*:aboveAverage*/, 0 /*:type*/ , "aboveAverage") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeAbsentConditionToNonValue(4 /*:percent*/, 0 /*:type*/ , "top10") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeAbsentConditionToNonValue(5 /*:bottom*/, 0 /*:type*/ , "top10") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeAbsentConditionToNonValue(7 /*:text*/, 0 /*:type*/ , "beginsWith", "containsText", "endsWith", "notContainsText") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeAbsentConditionToNonValue(8 /*:timePeriod*/, 0 /*:type*/ , "timePeriod") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeAbsentConditionToNonValue(10 /*:stdDev*/, 0 /*:type*/ , "aboveAverage") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeAbsentConditionToNonValue(11 /*:equalAverage*/, 0 /*:type*/ , "aboveAverage") { Version = FileFormatVersions.Office2010 });
        }

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
            builder.SetSchema(53, "extLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Extension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
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
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>errorStyle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: errorStyle</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues> ErrorStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imeMode, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: imeMode</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues> ImeMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>operator, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: operator</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues> Operator
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowBlank, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: allowBlank</para>
        /// </summary>
        public BooleanValue AllowBlank
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showDropDown, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showDropDown</para>
        /// </summary>
        public BooleanValue ShowDropDown
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showInputMessage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showInputMessage</para>
        /// </summary>
        public BooleanValue ShowInputMessage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showErrorMessage, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showErrorMessage</para>
        /// </summary>
        public BooleanValue ShowErrorMessage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>errorTitle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: errorTitle</para>
        /// </summary>
        public StringValue ErrorTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>error, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: error</para>
        /// </summary>
        public StringValue Error
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>promptTitle, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: promptTitle</para>
        /// </summary>
        public StringValue PromptTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>prompt, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: prompt</para>
        /// </summary>
        public StringValue Prompt
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "dataValidation");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DataValidationForumla1>();
            builder.AddChild<DataValidationForumla2>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>();
            builder.AddElement<DataValidation>()
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "errorStyle", a => a.ErrorStyle)
.AddAttribute(0, "imeMode", a => a.ImeMode)
.AddAttribute(0, "operator", a => a.Operator)
.AddAttribute(0, "allowBlank", a => a.AllowBlank)
.AddAttribute(0, "showDropDown", a => a.ShowDropDown)
.AddAttribute(0, "showInputMessage", a => a.ShowInputMessage)
.AddAttribute(0, "showErrorMessage", a => a.ShowErrorMessage)
.AddAttribute(0, "errorTitle", a => a.ErrorTitle)
.AddAttribute(0, "error", a => a.Error)
.AddAttribute(0, "promptTitle", a => a.PromptTitle)
.AddAttribute(0, "prompt", a => a.Prompt);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DataValidationForumla1), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.DataValidationForumla2), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence), 1, 1)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(9 /*:error*/, 0, 225) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(10 /*:promptTitle*/, 0, 32) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(11 /*:prompt*/, 0, 225) { Version = FileFormatVersions.Office2010 });
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "formula1");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 1, 1)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "formula2");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 1, 1)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.Formula>();
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
        public DoubleValue ManualMax
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>manualMin, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: manualMin</para>
        /// </summary>
        public DoubleValue ManualMin
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lineWeight, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: lineWeight</para>
        /// </summary>
        public DoubleValue LineWeight
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dateAxis, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dateAxis</para>
        /// </summary>
        public BooleanValue DateAxis
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>displayEmptyCellsAs, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: displayEmptyCellsAs</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues> DisplayEmptyCellsAs
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>markers, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: markers</para>
        /// </summary>
        public BooleanValue Markers
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>high, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: high</para>
        /// </summary>
        public BooleanValue High
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>low, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: low</para>
        /// </summary>
        public BooleanValue Low
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>first, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: first</para>
        /// </summary>
        public BooleanValue First
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>last, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: last</para>
        /// </summary>
        public BooleanValue Last
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>negative, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: negative</para>
        /// </summary>
        public BooleanValue Negative
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>displayXAxis, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: displayXAxis</para>
        /// </summary>
        public BooleanValue DisplayXAxis
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>displayHidden, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: displayHidden</para>
        /// </summary>
        public BooleanValue DisplayHidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>minAxisType, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: minAxisType</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues> MinAxisType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxAxisType, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: maxAxisType</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues> MaxAxisType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rightToLeft, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rightToLeft</para>
        /// </summary>
        public BooleanValue RightToLeft
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "sparklineGroup");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SeriesColor>();
            builder.AddChild<NegativeColor>();
            builder.AddChild<AxisColor>();
            builder.AddChild<MarkersColor>();
            builder.AddChild<FirstMarkerColor>();
            builder.AddChild<LastMarkerColor>();
            builder.AddChild<HighMarkerColor>();
            builder.AddChild<LowMarkerColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.Formula>();
            builder.AddChild<Sparklines>();
            builder.AddElement<SparklineGroup>()
.AddAttribute(0, "manualMax", a => a.ManualMax)
.AddAttribute(0, "manualMin", a => a.ManualMin)
.AddAttribute(0, "lineWeight", a => a.LineWeight)
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "dateAxis", a => a.DateAxis)
.AddAttribute(0, "displayEmptyCellsAs", a => a.DisplayEmptyCellsAs)
.AddAttribute(0, "markers", a => a.Markers)
.AddAttribute(0, "high", a => a.High)
.AddAttribute(0, "low", a => a.Low)
.AddAttribute(0, "first", a => a.First)
.AddAttribute(0, "last", a => a.Last)
.AddAttribute(0, "negative", a => a.Negative)
.AddAttribute(0, "displayXAxis", a => a.DisplayXAxis)
.AddAttribute(0, "displayHidden", a => a.DisplayHidden)
.AddAttribute(0, "minAxisType", a => a.MinAxisType)
.AddAttribute(0, "maxAxisType", a => a.MaxAxisType)
.AddAttribute(0, "rightToLeft", a => a.RightToLeft);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
            builder.AddConstraint(new AttributeValueConditionToAnother(1 /*:manualMin*/, 14 /*:minAxisType*/, new string[] { "0" }, new string[] { "individual", "group" }) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueRangeConstraint(2 /*:lineWeight*/, true, 0, true, 1584, true) { Version = FileFormatVersions.Office2010 });
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SparklineGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorSeries.</para>
    /// </summary>
    public partial class SeriesColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the SeriesColor class.
        /// </summary>
        public SeriesColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "colorSeries");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:auto*/, true, new string[] { "false" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesColor>(deep);
    }

    /// <summary>
    /// <para>Defines the NegativeColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorNegative.</para>
    /// </summary>
    public partial class NegativeColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the NegativeColor class.
        /// </summary>
        public NegativeColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "colorNegative");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:auto*/, true, new string[] { "false" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NegativeColor>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorAxis.</para>
    /// </summary>
    public partial class AxisColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the AxisColor class.
        /// </summary>
        public AxisColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "colorAxis");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:auto*/, true, new string[] { "false" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisColor>(deep);
    }

    /// <summary>
    /// <para>Defines the MarkersColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorMarkers.</para>
    /// </summary>
    public partial class MarkersColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the MarkersColor class.
        /// </summary>
        public MarkersColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "colorMarkers");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:auto*/, true, new string[] { "false" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MarkersColor>(deep);
    }

    /// <summary>
    /// <para>Defines the FirstMarkerColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorFirst.</para>
    /// </summary>
    public partial class FirstMarkerColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the FirstMarkerColor class.
        /// </summary>
        public FirstMarkerColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "colorFirst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:auto*/, true, new string[] { "false" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstMarkerColor>(deep);
    }

    /// <summary>
    /// <para>Defines the LastMarkerColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorLast.</para>
    /// </summary>
    public partial class LastMarkerColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the LastMarkerColor class.
        /// </summary>
        public LastMarkerColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "colorLast");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:auto*/, true, new string[] { "false" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LastMarkerColor>(deep);
    }

    /// <summary>
    /// <para>Defines the HighMarkerColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorHigh.</para>
    /// </summary>
    public partial class HighMarkerColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the HighMarkerColor class.
        /// </summary>
        public HighMarkerColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "colorHigh");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:auto*/, true, new string[] { "false" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HighMarkerColor>(deep);
    }

    /// <summary>
    /// <para>Defines the LowMarkerColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:colorLow.</para>
    /// </summary>
    public partial class LowMarkerColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the LowMarkerColor class.
        /// </summary>
        public LowMarkerColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "colorLow");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LowMarkerColor>(deep);
    }

    /// <summary>
    /// <para>Defines the Color Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:color.</para>
    /// </summary>
    public partial class Color : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the Color class.
        /// </summary>
        public Color() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "color");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Color>(deep);
    }

    /// <summary>
    /// <para>Defines the FillColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:fillColor.</para>
    /// </summary>
    public partial class FillColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the FillColor class.
        /// </summary>
        public FillColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "fillColor");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillColor>(deep);
    }

    /// <summary>
    /// <para>Defines the BorderColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:borderColor.</para>
    /// </summary>
    public partial class BorderColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the BorderColor class.
        /// </summary>
        public BorderColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "borderColor");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BorderColor>(deep);
    }

    /// <summary>
    /// <para>Defines the NegativeFillColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:negativeFillColor.</para>
    /// </summary>
    public partial class NegativeFillColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the NegativeFillColor class.
        /// </summary>
        public NegativeFillColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "negativeFillColor");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NegativeFillColor>(deep);
    }

    /// <summary>
    /// <para>Defines the NegativeBorderColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:negativeBorderColor.</para>
    /// </summary>
    public partial class NegativeBorderColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the NegativeBorderColor class.
        /// </summary>
        public NegativeBorderColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "negativeBorderColor");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NegativeBorderColor>(deep);
    }

    /// <summary>
    /// <para>Defines the BarAxisColor Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:axisColor.</para>
    /// </summary>
    public partial class BarAxisColor : ColorType
    {
        /// <summary>
        /// Initializes a new instance of the BarAxisColor class.
        /// </summary>
        public BarAxisColor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "axisColor");
            builder.Availability = FileFormatVersions.Office2010;
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
        public BooleanValue Auto
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Index</para>
        /// <para>Represents the following attribute in the schema: indexed</para>
        /// </summary>
        public UInt32Value Indexed
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alpha Red Green Blue Color Value</para>
        /// <para>Represents the following attribute in the schema: rgb</para>
        /// </summary>
        public HexBinaryValue Rgb
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Theme Color</para>
        /// <para>Represents the following attribute in the schema: theme</para>
        /// </summary>
        public UInt32Value Theme
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Tint</para>
        /// <para>Represents the following attribute in the schema: tint</para>
        /// </summary>
        public DoubleValue Tint
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<ColorType>()
                           .AddAttribute(0, "auto", a => a.Auto)
                           .AddAttribute(0, "indexed", a => a.Indexed)
                           .AddAttribute(0, "rgb", a => a.Rgb, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { Length = (4L) });
                           })
                           .AddAttribute(0, "theme", a => a.Theme)
                           .AddAttribute(0, "tint", a => a.Tint);
        }
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "sparklines");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Sparkline>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Sparkline), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "sparkline");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.Formula>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence), 1, 1)
            };
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Sparkline>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerRef Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicer.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "slicer");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<SlicerRef>()
.AddAttribute(19, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.AddConstraint(new RelationshipExistConstraint(0 /*r:id*/) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerRef>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCache Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicerCache.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "slicerCache");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<SlicerCache>()
.AddAttribute(19, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.AddConstraint(new RelationshipExistConstraint(0 /*r:id*/) { Version = FileFormatVersions.Office2010 });
        }

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
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "definedName");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ArgumentDescriptions>();
            builder.AddElement<DefinedName>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ArgumentDescriptions), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:name*/, true, typeof(DocumentFormat.OpenXml.Office2010.Excel.DefinedNames)) { Version = FileFormatVersions.Office2010 });
        }

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
        public UInt32Value Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "argumentDescriptions");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ArgumentDescription>();
            builder.AddElement<ArgumentDescriptions>()
.AddAttribute(0, "count", a => a.Count);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ArgumentDescription), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArgumentDescriptions>(deep);
    }

    /// <summary>
    /// <para>Defines the ArgumentDescription Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:argumentDescription.</para>
    /// </summary>
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
        public UInt32Value Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "argumentDescription");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArgumentDescription>()
.AddAttribute(0, "index", a => a.Index, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:index*/, true, typeof(DocumentFormat.OpenXml.Office2010.Excel.ArgumentDescriptions)) { Version = FileFormatVersions.Office2010 });
        }

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
        public UInt32Value RowCount
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columnCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: columnCount</para>
        /// </summary>
        public UInt32Value ColumnCount
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "tupleSet");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TupleSetHeaders>();
            builder.AddChild<TupleSetRows>();
            builder.AddElement<TupleSet>()
.AddAttribute(0, "rowCount", a => a.RowCount)
.AddAttribute(0, "columnCount", a => a.ColumnCount);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleSetHeaders), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleSetRows), 1, 1, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "headers");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TupleSetHeader>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleSetHeader), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "rows");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TupleSetRow>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleSetRow), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetRows>(deep);
    }

    /// <summary>
    /// <para>Defines the TupleSetHeader Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:header.</para>
    /// </summary>
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
        public StringValue UniqueName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hierarchyName, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hierarchyName</para>
        /// </summary>
        public StringValue HierarchyName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "header");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<TupleSetHeader>()
.AddAttribute(0, "uniqueName", a => a.UniqueName)
.AddAttribute(0, "hierarchyName", a => a.HierarchyName);
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:uniqueName*/, 0, 65535) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(1 /*:hierarchyName*/, 0, 65535) { Version = FileFormatVersions.Office2010 });
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "row");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TupleSetRowItem>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleSetRowItem), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetRow>(deep);
    }

    /// <summary>
    /// <para>Defines the TupleSetRowItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:rowItem.</para>
    /// </summary>
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
        public StringValue UniqueName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>d, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: d</para>
        /// </summary>
        public StringValue DisplayName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "rowItem");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<TupleSetRowItem>()
.AddAttribute(0, "u", a => a.UniqueName)
.AddAttribute(0, "d", a => a.DisplayName);
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:u*/, 0, 65535) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(1 /*:d*/, 0, 65535) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetRowItem>(deep);
    }

    /// <summary>
    /// <para>Defines the SetLevel Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:setLevel.</para>
    /// </summary>
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
        public Int32Value Hierarchy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "setLevel");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<SetLevel>()
.AddAttribute(0, "hierarchy", a => a.Hierarchy, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:hierarchy*/, true, -2, true, double.PositiveInfinity, true) { Version = FileFormatVersions.Office2010 });
        }

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
        public UInt32Value Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "setLevels");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SetLevel>();
            builder.AddElement<SetLevels>()
.AddAttribute(0, "count", a => a.Count);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SetLevel), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "colorScale");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ConditionalFormattingValueObject>();
            builder.AddChild<Color>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingValueObject), 2, 0, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Color), 2, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public UInt32Value MinLength
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxLength, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        public UInt32Value MaxLength
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showValue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showValue</para>
        /// </summary>
        public BooleanValue ShowValue
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>border, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: border</para>
        /// </summary>
        public BooleanValue Border
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>gradient, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: gradient</para>
        /// </summary>
        public BooleanValue Gradient
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>direction, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: direction</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DataBarDirectionValues> Direction
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DataBarDirectionValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>negativeBarColorSameAsPositive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: negativeBarColorSameAsPositive</para>
        /// </summary>
        public BooleanValue NegativeBarColorSameAsPositive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>negativeBarBorderColorSameAsPositive, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: negativeBarBorderColorSameAsPositive</para>
        /// </summary>
        public BooleanValue NegativeBarBorderColorSameAsPositive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>axisPosition, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: axisPosition</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DataBarAxisPositionValues> AxisPosition
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DataBarAxisPositionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "dataBar");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ConditionalFormattingValueObject>();
            builder.AddChild<FillColor>();
            builder.AddChild<BorderColor>();
            builder.AddChild<NegativeFillColor>();
            builder.AddChild<NegativeBorderColor>();
            builder.AddChild<BarAxisColor>();
            builder.AddElement<DataBar>()
.AddAttribute(0, "minLength", a => a.MinLength)
.AddAttribute(0, "maxLength", a => a.MaxLength)
.AddAttribute(0, "showValue", a => a.ShowValue)
.AddAttribute(0, "border", a => a.Border)
.AddAttribute(0, "gradient", a => a.Gradient)
.AddAttribute(0, "direction", a => a.Direction)
.AddAttribute(0, "negativeBarColorSameAsPositive", a => a.NegativeBarColorSameAsPositive)
.AddAttribute(0, "negativeBarBorderColorSameAsPositive", a => a.NegativeBarBorderColorSameAsPositive)
.AddAttribute(0, "axisPosition", a => a.AxisPosition);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingValueObject), 2, 2, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.FillColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.BorderColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.NegativeFillColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.NegativeBorderColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.BarAxisColor), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueLessEqualToAnother(0 /*:minLength*/, 1 /*:maxLength*/, true) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueRangeConstraint(1 /*:maxLength*/, true, double.NegativeInfinity, true, 100, true) { Version = FileFormatVersions.Office2010 });
        }

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
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues> IconSetTypes
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showValue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showValue</para>
        /// </summary>
        public BooleanValue ShowValue
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>percent, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: percent</para>
        /// </summary>
        public BooleanValue Percent
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>reverse, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: reverse</para>
        /// </summary>
        public BooleanValue Reverse
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>custom, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: custom</para>
        /// </summary>
        public BooleanValue Custom
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "iconSet");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ConditionalFormattingValueObject>();
            builder.AddChild<ConditionalFormattingIcon>();
            builder.AddElement<IconSet>()
.AddAttribute(0, "iconSet", a => a.IconSetTypes)
.AddAttribute(0, "showValue", a => a.ShowValue)
.AddAttribute(0, "percent", a => a.Percent)
.AddAttribute(0, "reverse", a => a.Reverse)
.AddAttribute(0, "custom", a => a.Custom);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingValueObject), 2, 0, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingIcon), 0, 5, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "dxf");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Font>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.NumberingFormat>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Alignment>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Border>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Protection>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingValueObjectTypeValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingValueObjectTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>gte, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: gte</para>
        /// </summary>
        public BooleanValue GreaterThanOrEqual
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "cfvo");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.Formula>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<ConditionalFormattingValueObject>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "gte", a => a.GreaterThanOrEqual);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormattingValueObject>(deep);
    }

    /// <summary>
    /// <para>Defines the ConditionalFormattingIcon Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:cfIcon.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues> IconSet
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>iconId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: iconId</para>
        /// </summary>
        public UInt32Value IconId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "cfIcon");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ConditionalFormattingIcon>()
.AddAttribute(0, "iconSet", a => a.IconSet, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "iconId", a => a.IconId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotEdits");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<PivotEdit>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotEdit), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotChanges");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<PivotChange>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotChange), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public UInt32Value Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "conditionalFormats");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ConditionalFormat>();
            builder.AddElement<ConditionalFormats>()
.AddAttribute(0, "count", a => a.Count);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormat), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public UInt32Value Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "calculatedMembers");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.CalculatedMember>();
            builder.AddElement<CalculatedMembers>()
.AddAttribute(0, "count", a => a.Count);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.CalculatedMember), 1, 0)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotEdit");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<PivotUserEdit>();
            builder.AddChild<TupleItems>();
            builder.AddChild<PivotArea>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotUserEdit), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleItems), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotArea), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "userEdit");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.Formula>();
            builder.AddChild<PivotEditValue>();
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotEditValue), 1, 1, version: FileFormatVersions.Office2010)
            };
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "tupleItems");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<Xstring>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Xstring), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public Int32Value Field
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rule Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotAreaValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotAreaValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data Only</para>
        /// <para>Represents the following attribute in the schema: dataOnly</para>
        /// </summary>
        public BooleanValue DataOnly
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Labels Only</para>
        /// <para>Represents the following attribute in the schema: labelOnly</para>
        /// </summary>
        public BooleanValue LabelOnly
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Include Row Grand Total</para>
        /// <para>Represents the following attribute in the schema: grandRow</para>
        /// </summary>
        public BooleanValue GrandRow
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Include Column Grand Total</para>
        /// <para>Represents the following attribute in the schema: grandCol</para>
        /// </summary>
        public BooleanValue GrandColumn
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Cache Index</para>
        /// <para>Represents the following attribute in the schema: cacheIndex</para>
        /// </summary>
        public BooleanValue CacheIndex
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Outline</para>
        /// <para>Represents the following attribute in the schema: outline</para>
        /// </summary>
        public BooleanValue Outline
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Offset Reference</para>
        /// <para>Represents the following attribute in the schema: offset</para>
        /// </summary>
        public StringValue Offset
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Collapsed Levels Are Subtotals</para>
        /// <para>Represents the following attribute in the schema: collapsedLevelsAreSubtotals</para>
        /// </summary>
        public BooleanValue CollapsedLevelsAreSubtotals
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Axis</para>
        /// <para>Represents the following attribute in the schema: axis</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotTableAxisValues> Axis
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotTableAxisValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Field Position</para>
        /// <para>Represents the following attribute in the schema: fieldPosition</para>
        /// </summary>
        public UInt32Value FieldPosition
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotArea");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotAreaReferences>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            builder.AddElement<PivotArea>()
.AddAttribute(0, "field", a => a.Field)
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "dataOnly", a => a.DataOnly)
.AddAttribute(0, "labelOnly", a => a.LabelOnly)
.AddAttribute(0, "grandRow", a => a.GrandRow)
.AddAttribute(0, "grandCol", a => a.GrandColumn)
.AddAttribute(0, "cacheIndex", a => a.CacheIndex)
.AddAttribute(0, "outline", a => a.Outline)
.AddAttribute(0, "offset", a => a.Offset)
.AddAttribute(0, "collapsedLevelsAreSubtotals", a => a.CollapsedLevelsAreSubtotals)
.AddAttribute(0, "axis", a => a.Axis)
.AddAttribute(0, "fieldPosition", a => a.FieldPosition);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotAreaReferences), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
            };
        }

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
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.AllocationMethodValues> AllocationMethod
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.AllocationMethodValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>weightExpression, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: weightExpression</para>
        /// </summary>
        public StringValue WeightExpression
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotChange");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<PivotEditValue>();
            builder.AddChild<TupleItems>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<PivotChange>()
.AddAttribute(0, "allocationMethod", a => a.AllocationMethod)
.AddAttribute(0, "weightExpression", a => a.WeightExpression);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotEditValue), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TupleItems), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(1 /*:weightExpression*/, 1, 65535) { Version = FileFormatVersions.Office2010 });
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotChange>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotEditValue Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:editValue.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.PivotEditValueTypeValues> ValueType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.PivotEditValueTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "editValue");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<PivotEditValue>()
.AddAttribute(0, "valueType", a => a.ValueType, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:valueType*/, 1, 32767) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotEditValue>(deep);
    }

    /// <summary>
    /// <para>Defines the Xstring Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:tupleItem.</para>
    /// </summary>
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "tupleItem");
            builder.Availability = FileFormatVersions.Office2010;
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "slicerStyleElements");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SlicerStyleElement>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerStyleElement), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public UInt32Value Rows
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Columns</para>
        /// <para>Represents the following attribute in the schema: cols</para>
        /// </summary>
        public UInt32Value Columns
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "values");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Value>();
            builder.AddElement<DdeValues>()
.AddAttribute(0, "rows", a => a.Rows)
.AddAttribute(0, "cols", a => a.Columns);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Value), 1, 0)
            };
        }

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
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.ScopeValues> Scope
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.ScopeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.RuleValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.RuleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>priority, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: priority</para>
        /// </summary>
        public UInt32Value Priority
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "conditionalFormat");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<PivotAreas>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<ConditionalFormat>()
.AddAttribute(0, "scope", a => a.Scope)
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "priority", a => a.Priority)
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.PivotAreas), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueSetConstraint(1 /*:type*/, true, new string[] { "none" }) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueRangeConstraint(2 /*:priority*/, true, 1, true, double.PositiveInfinity, true) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new ReferenceExistConstraint(2 /*:priority*/, "..", typeof(DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingRule), "DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingRule", 1 /*:priority*/) { Version = FileFormatVersions.Office2010 });
        }

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
        public UInt32Value Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotAreas");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotArea>();
            builder.AddElement<PivotAreas>()
.AddAttribute(0, "count", a => a.Count);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotArea), 0, 0)
            };
        }

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
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "slicerStyle");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SlicerStyleElements>();
            builder.AddElement<SlicerStyle>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerStyleElements), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:name*/, 1, 255) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new ReferenceExistConstraint(0 /*:name*/, ".", typeof(DocumentFormat.OpenXml.Spreadsheet.TableStyle), "DocumentFormat.OpenXml.Spreadsheet.TableStyle", 0 /*:name*/) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:name*/, true, typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerStyles)) { Version = FileFormatVersions.Office2010 });
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerStyleElement Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:slicerStyleElement.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerStyleTypeValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerStyleTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dxfId, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dxfId</para>
        /// </summary>
        public UInt32Value FormatId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "slicerStyleElement");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<SlicerStyleElement>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "dxfId", a => a.FormatId);
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:type*/, true, typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerStyleElements)) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new IndexReferenceConstraint(1 /*:dxfId*/, ".", null, typeof(DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat), "DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat", 0) { Version = FileFormatVersions.Office2010 });
        }

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
        public BooleanValue EvalError
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>twoDigitTextYear, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: twoDigitTextYear</para>
        /// </summary>
        public BooleanValue TwoDigitTextYear
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>numberStoredAsText, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: numberStoredAsText</para>
        /// </summary>
        public BooleanValue NumberStoredAsText
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>formula, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: formula</para>
        /// </summary>
        public BooleanValue Formula
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>formulaRange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: formulaRange</para>
        /// </summary>
        public BooleanValue FormulaRange
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>unlockedFormula, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: unlockedFormula</para>
        /// </summary>
        public BooleanValue UnlockedFormula
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>emptyCellReference, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: emptyCellReference</para>
        /// </summary>
        public BooleanValue EmptyCellReference
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>listDataValidation, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: listDataValidation</para>
        /// </summary>
        public BooleanValue ListDataValidation
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>calculatedColumn, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: calculatedColumn</para>
        /// </summary>
        public BooleanValue CalculatedColumn
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "ignoredError");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>();
            builder.AddElement<IgnoredError>()
.AddAttribute(0, "evalError", a => a.EvalError)
.AddAttribute(0, "twoDigitTextYear", a => a.TwoDigitTextYear)
.AddAttribute(0, "numberStoredAsText", a => a.NumberStoredAsText)
.AddAttribute(0, "formula", a => a.Formula)
.AddAttribute(0, "formulaRange", a => a.FormulaRange)
.AddAttribute(0, "unlockedFormula", a => a.UnlockedFormula)
.AddAttribute(0, "emptyCellReference", a => a.EmptyCellReference)
.AddAttribute(0, "listDataValidation", a => a.ListDataValidation)
.AddAttribute(0, "calculatedColumn", a => a.CalculatedColumn);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence), 1, 1)
            };
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
        public HexBinaryValue Password
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>algorithmName, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: algorithmName</para>
        /// </summary>
        public StringValue AlgorithmName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hashValue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hashValue</para>
        /// </summary>
        public Base64BinaryValue HashValue
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>saltValue, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: saltValue</para>
        /// </summary>
        public Base64BinaryValue SaltValue
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>spinCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: spinCount</para>
        /// </summary>
        public UInt32Value SpinCount
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>securityDescriptor, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: securityDescriptor</para>
        /// </summary>
        public StringValue SecurityDescriptor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "protectedRange");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>();
            builder.AddElement<ProtectedRange>()
.AddAttribute(0, "password", a => a.Password, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute(0, "algorithmName", a => a.AlgorithmName)
.AddAttribute(0, "hashValue", a => a.HashValue)
.AddAttribute(0, "saltValue", a => a.SaltValue)
.AddAttribute(0, "spinCount", a => a.SpinCount)
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "securityDescriptor", a => a.SecurityDescriptor);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence), 1, 1)
            };
            builder.AddConstraint(new AttributeMutualExclusive(0, 1) /*:password, :algorithmName*/ { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueRangeConstraint(4 /*:spinCount*/, true, double.NegativeInfinity, true, 10000000, true) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(5 /*:name*/, 1, 255) { Version = FileFormatVersions.Office2010 });
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ProtectedRange>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomFilter Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:customFilter.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.FilterOperatorValues> Operator
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.FilterOperatorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "customFilter");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<CustomFilter>()
.AddAttribute(0, "operator", a => a.Operator)
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the ListItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:item.</para>
    /// </summary>
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
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "item");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ListItem>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "itemLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ListItem>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ListItem), 0, 0, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cache, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: cache</para>
        /// </summary>
        public StringValue Cache
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>caption, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: caption</para>
        /// </summary>
        public StringValue Caption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>startItem, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: startItem</para>
        /// </summary>
        public UInt32Value StartItem
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columnCount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: columnCount</para>
        /// </summary>
        public UInt32Value ColumnCount
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showCaption, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showCaption</para>
        /// </summary>
        public BooleanValue ShowCaption
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>level, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: level</para>
        /// </summary>
        public UInt32Value Level
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lockedPosition, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: lockedPosition</para>
        /// </summary>
        public BooleanValue LockedPosition
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rowHeight, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rowHeight</para>
        /// </summary>
        public UInt32Value RowHeight
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "slicer");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ExtensionList>();
            builder.AddElement<Slicer>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "cache", a => a.Cache, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "caption", a => a.Caption)
.AddAttribute(0, "startItem", a => a.StartItem)
.AddAttribute(0, "columnCount", a => a.ColumnCount)
.AddAttribute(0, "showCaption", a => a.ShowCaption)
.AddAttribute(0, "level", a => a.Level)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "lockedPosition", a => a.LockedPosition)
.AddAttribute(0, "rowHeight", a => a.RowHeight, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:name*/, false, null) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:name*/, 1, 32767) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueLengthConstraint(2 /*:caption*/, 1, int.MaxValue) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueRangeConstraint(4 /*:columnCount*/, true, 1, true, 20000, true) { Version = FileFormatVersions.Office2010 });
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
        public UInt32Value PivotCacheId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "olap");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<OlapSlicerCacheLevelsData>();
            builder.AddChild<OlapSlicerCacheSelections>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<OlapSlicerCache>()
.AddAttribute(0, "pivotCacheId", a => a.PivotCacheId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheLevelsData), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheSelections), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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
        public UInt32Value PivotCacheId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sortOrder, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sortOrder</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheSortOrderValues> SortOrder
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheSortOrderValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>customListSort, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: customListSort</para>
        /// </summary>
        public BooleanValue CustomListSort
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showMissing, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showMissing</para>
        /// </summary>
        public BooleanValue ShowMissing
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>crossFilter, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: crossFilter</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues> CrossFilter
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "tabular");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TabularSlicerCacheItems>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<TabularSlicerCache>()
.AddAttribute(0, "pivotCacheId", a => a.PivotCacheId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "sortOrder", a => a.SortOrder)
.AddAttribute(0, "customListSort", a => a.CustomListSort)
.AddAttribute(0, "showMissing", a => a.ShowMissing)
.AddAttribute(0, "crossFilter", a => a.CrossFilter);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheItems), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TabularSlicerCache>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCachePivotTable Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:pivotTable.</para>
    /// </summary>
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
        public UInt32Value TabId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotTable");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<SlicerCachePivotTable>()
.AddAttribute(0, "tabId", a => a.TabId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.AddConstraint(new ReferenceExistConstraint(0 /*:tabId*/, "/WorkbookPart", typeof(DocumentFormat.OpenXml.Spreadsheet.Sheet), "DocumentFormat.OpenXml.Spreadsheet.Sheet", 1 /*:sheetId*/) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCachePivotTable>(deep);
    }

    /// <summary>
    /// <para>Defines the OlapSlicerCacheItemParent Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:p.</para>
    /// </summary>
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
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "p");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<OlapSlicerCacheItemParent>()
.AddAttribute(0, "n", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

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
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>c, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: c</para>
        /// </summary>
        public StringValue DisplayName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>nd, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: nd</para>
        /// </summary>
        public BooleanValue NonDisplay
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "i");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<OlapSlicerCacheItemParent>();
            builder.AddElement<OlapSlicerCacheItem>()
.AddAttribute(0, "n", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "c", a => a.DisplayName)
.AddAttribute(0, "nd", a => a.NonDisplay);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheItemParent), 0, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public UInt32Value StartItem
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "range");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<OlapSlicerCacheItem>();
            builder.AddElement<OlapSlicerCacheRange>()
.AddAttribute(0, "startItem", a => a.StartItem, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheItem), 1, 0, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValuePatternConstraint(0 /*:startItem*/, @"(0|[1-9][0-9]*000)") { Version = FileFormatVersions.Office2010 });
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "ranges");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<OlapSlicerCacheRange>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheRange), 0, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue UniqueName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sourceCaption, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sourceCaption</para>
        /// </summary>
        public StringValue SourceCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>count, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        public UInt32Value Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sortOrder, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sortOrder</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheSortOrderValues> SortOrder
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheSortOrderValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>crossFilter, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: crossFilter</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues> CrossFilter
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "level");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<OlapSlicerCacheRanges>();
            builder.AddElement<OlapSlicerCacheLevelData>()
.AddAttribute(0, "uniqueName", a => a.UniqueName, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "sourceCaption", a => a.SourceCaption)
.AddAttribute(0, "count", a => a.Count, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "sortOrder", a => a.SortOrder)
.AddAttribute(0, "crossFilter", a => a.CrossFilter);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheRanges), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:uniqueName*/, 1, 32767) { Version = FileFormatVersions.Office2010 });
        }

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
        public UInt32Value Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "levels");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<OlapSlicerCacheLevelData>();
            builder.AddElement<OlapSlicerCacheLevelsData>()
.AddAttribute(0, "count", a => a.Count);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheLevelData), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public UInt32Value Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "selections");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<OlapSlicerCacheSelection>();
            builder.AddElement<OlapSlicerCacheSelections>()
.AddAttribute(0, "count", a => a.Count);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheSelection), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "selection");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<OlapSlicerCacheItemParent>();
            builder.AddElement<OlapSlicerCacheSelection>()
.AddAttribute(0, "n", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheItemParent), 0, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public UInt32Value Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "items");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<TabularSlicerCacheItem>();
            builder.AddElement<TabularSlicerCacheItems>()
.AddAttribute(0, "count", a => a.Count);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheItem), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TabularSlicerCacheItems>(deep);
    }

    /// <summary>
    /// <para>Defines the TabularSlicerCacheItem Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x14:i.</para>
    /// </summary>
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
        public UInt32Value Atom
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>s, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: s</para>
        /// </summary>
        public BooleanValue IsSelected
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>nd, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: nd</para>
        /// </summary>
        public BooleanValue NonDisplay
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "i");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<TabularSlicerCacheItem>()
.AddAttribute(0, "x", a => a.Atom, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "s", a => a.IsSelected)
.AddAttribute(0, "nd", a => a.NonDisplay);
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:x*/, true, typeof(DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheItems)) { Version = FileFormatVersions.Office2010 });
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "pivotTables");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<SlicerCachePivotTable>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "data");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<OlapSlicerCache>();
            builder.AddChild<TabularSlicerCache>();
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCache), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCache), 1, 1, version: FileFormatVersions.Office2010)
            };
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(53, "extLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.SlicerCacheDefinitionExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SlicerCacheDefinitionExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheDefinitionExtensionList>(deep);
    }

    /// <summary>
    /// Defines the DisplayBlanksAsValues enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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
    [OfficeAvailability(FileFormatVersions.Office2010)]
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