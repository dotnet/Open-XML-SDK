// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
    /// <summary>
    /// <para>Defines the PivotCaches Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotCaches.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PivotCache &lt;x:pivotCache></description></item>
    /// </list>
    /// </remark>
    public partial class PivotCaches : OpenXmlPivotCachesElement
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
            builder.SetSchema(71, "pivotCaches");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotCache), 1, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCaches>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineCachePivotCaches Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineCachePivotCaches.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PivotCache &lt;x:pivotCache></description></item>
    /// </list>
    /// </remark>
    public partial class TimelineCachePivotCaches : OpenXmlPivotCachesElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotCaches class.
        /// </summary>
        public TimelineCachePivotCaches() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotCaches class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCachePivotCaches(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotCaches class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCachePivotCaches(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotCaches class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineCachePivotCaches(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "timelineCachePivotCaches");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotCache), 1, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCachePivotCaches>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlPivotCachesElement Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PivotCache &lt;x:pivotCache></description></item>
    /// </list>
    /// </remark>
    public abstract partial class OpenXmlPivotCachesElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlPivotCachesElement class.
        /// </summary>
        protected OpenXmlPivotCachesElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPivotCachesElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlPivotCachesElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPivotCachesElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlPivotCachesElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPivotCachesElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OpenXmlPivotCachesElement(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotCache>();
        }
    }

    /// <summary>
    /// <para>Defines the PivotTableReferences Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTableReferences.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PivotTableReference &lt;x15:pivotTableReference></description></item>
    /// </list>
    /// </remark>
    public partial class PivotTableReferences : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableReferences class.
        /// </summary>
        public PivotTableReferences() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableReferences(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableReferences(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableReferences class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotTableReferences(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "pivotTableReferences");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<PivotTableReference>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.PivotTableReference), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableReferences>(deep);
    }

    /// <summary>
    /// <para>Defines the QueryTable Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:queryTable.</para>
    /// </summary>
    public partial class QueryTable : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the QueryTable class.
        /// </summary>
        public QueryTable() : base()
        {
        }

        /// <summary>
        /// <para>clipped, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: clipped</para>
        /// </summary>
        public BooleanValue Clipped
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sourceDataName, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sourceDataName</para>
        /// </summary>
        public StringValue SourceDataName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>drillThrough, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: drillThrough</para>
        /// </summary>
        public BooleanValue DrillThrough
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "queryTable");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<QueryTable>()
.AddAttribute(0, "clipped", a => a.Clipped)
.AddAttribute(0, "sourceDataName", a => a.SourceDataName)
.AddAttribute(0, "drillThrough", a => a.DrillThrough);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<QueryTable>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtensions Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:webExtensions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>WebExtension &lt;x15:webExtension></description></item>
    /// </list>
    /// </remark>
    public partial class WebExtensions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensions class.
        /// </summary>
        public WebExtensions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebExtensions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "webExtensions");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<WebExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.WebExtension), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensions>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineCacheReferences Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineCacheRefs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TimelineCacheReference &lt;x15:timelineCacheRef></description></item>
    /// </list>
    /// </remark>
    public partial class TimelineCacheReferences : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineCacheReferences class.
        /// </summary>
        public TimelineCacheReferences() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCacheReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCacheReferences(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCacheReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCacheReferences(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCacheReferences class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineCacheReferences(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "timelineCacheRefs");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<TimelineCacheReference>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineCacheReference), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCacheReferences>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineReferences Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineRefs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TimelineReference &lt;x15:timelineRef></description></item>
    /// </list>
    /// </remark>
    public partial class TimelineReferences : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineReferences class.
        /// </summary>
        public TimelineReferences() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineReferences(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineReferences(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineReferences class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineReferences(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "timelineRefs");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<TimelineReference>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineReference), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineReferences>(deep);
    }

    /// <summary>
    /// <para>Defines the WorkbookProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:workbookPr.</para>
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
        /// <para>chartTrackingRefBase, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: chartTrackingRefBase</para>
        /// </summary>
        public BooleanValue ChartTrackingReferenceBase
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "workbookPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<WorkbookProperties>()
.AddAttribute(0, "chartTrackingRefBase", a => a.ChartTrackingReferenceBase);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WorkbookProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineStyles Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineStyles.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TimelineStyle &lt;x15:timelineStyle></description></item>
    /// </list>
    /// </remark>
    public partial class TimelineStyles : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineStyles class.
        /// </summary>
        public TimelineStyles() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineStyles(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineStyles(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyles class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineStyles(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>defaultTimelineStyle, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: defaultTimelineStyle</para>
        /// </summary>
        public StringValue DefaultTimelineStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "timelineStyles");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<TimelineStyle>();
            builder.AddElement<TimelineStyles>()
.AddAttribute(0, "defaultTimelineStyle", a => a.DefaultTimelineStyle, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineStyle), 0, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineStyles>(deep);
    }

    /// <summary>
    /// <para>Defines the DifferentialFormats Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dxfs.</para>
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
            builder.SetSchema(71, "dxfs");
            builder.Availability = FileFormatVersions.Office2013;
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
    /// <para>Defines the Connection Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:connection.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TextProperties &lt;x15:textPr></description></item>
    ///   <item><description>ModelTextProperties &lt;x15:modelTextPr></description></item>
    ///   <item><description>RangeProperties &lt;x15:rangePr></description></item>
    ///   <item><description>OleDbPrpoperties &lt;x15:oledbPr></description></item>
    ///   <item><description>DataFeedProperties &lt;x15:dataFeedPr></description></item>
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
        /// <para>id, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>model, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: model</para>
        /// </summary>
        public BooleanValue Model
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>excludeFromRefreshAll, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: excludeFromRefreshAll</para>
        /// </summary>
        public BooleanValue ExcludeFromRefreshAll
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>autoDelete, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: autoDelete</para>
        /// </summary>
        public BooleanValue AutoDelete
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>usedByAddin, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: usedByAddin</para>
        /// </summary>
        public BooleanValue UsedByAddin
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "connection");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<TextProperties>();
            builder.AddChild<ModelTextProperties>();
            builder.AddChild<RangeProperties>();
            builder.AddChild<OleDbPrpoperties>();
            builder.AddChild<DataFeedProperties>();
            builder.AddElement<Connection>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "model", a => a.Model)
.AddAttribute(0, "excludeFromRefreshAll", a => a.ExcludeFromRefreshAll)
.AddAttribute(0, "autoDelete", a => a.AutoDelete)
.AddAttribute(0, "usedByAddin", a => a.UsedByAddin);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TextProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ModelTextProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.RangeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.OleDbPrpoperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.DataFeedProperties), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>TextProperties.</para>
        /// <para>Represents the following element tag in the schema: x15:textPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public TextProperties TextProperties
        {
            get => GetElement<TextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ModelTextProperties.</para>
        /// <para>Represents the following element tag in the schema: x15:modelTextPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public ModelTextProperties ModelTextProperties
        {
            get => GetElement<ModelTextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RangeProperties.</para>
        /// <para>Represents the following element tag in the schema: x15:rangePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public RangeProperties RangeProperties
        {
            get => GetElement<RangeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OleDbPrpoperties.</para>
        /// <para>Represents the following element tag in the schema: x15:oledbPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public OleDbPrpoperties OleDbPrpoperties
        {
            get => GetElement<OleDbPrpoperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataFeedProperties.</para>
        /// <para>Represents the following element tag in the schema: x15:dataFeedPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DataFeedProperties DataFeedProperties
        {
            get => GetElement<DataFeedProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Connection>(deep);
    }

    /// <summary>
    /// <para>Defines the CalculatedMember Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:calculatedMember.</para>
    /// </summary>
    public partial class CalculatedMember : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CalculatedMember class.
        /// </summary>
        public CalculatedMember() : base()
        {
        }

        /// <summary>
        /// <para>measureGroup, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: measureGroup</para>
        /// </summary>
        public StringValue MeasureGroup
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>numberFormat, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: numberFormat</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.CalculatedMemberNumberFormat> NumberFormat
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.CalculatedMemberNumberFormat>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>measure, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: measure</para>
        /// </summary>
        public BooleanValue Measure
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "calculatedMember");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<CalculatedMember>()
.AddAttribute(0, "measureGroup", a => a.MeasureGroup)
.AddAttribute(0, "numberFormat", a => a.NumberFormat)
.AddAttribute(0, "measure", a => a.Measure);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CalculatedMember>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotTableUISettings Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTableUISettings.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FieldListActiveTabTopLevelEntity &lt;x15:activeTabTopLevelEntity></description></item>
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class PivotTableUISettings : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableUISettings class.
        /// </summary>
        public PivotTableUISettings() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableUISettings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableUISettings(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableUISettings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableUISettings(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableUISettings class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotTableUISettings(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>sourceDataName, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sourceDataName</para>
        /// </summary>
        public StringValue SourceDataName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>relNeededHidden, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: relNeededHidden</para>
        /// </summary>
        public BooleanValue RelNeededHidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "pivotTableUISettings");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<FieldListActiveTabTopLevelEntity>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<PivotTableUISettings>()
.AddAttribute(0, "sourceDataName", a => a.SourceDataName)
.AddAttribute(0, "relNeededHidden", a => a.RelNeededHidden);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.FieldListActiveTabTopLevelEntity), 0, 0, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableUISettings>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotFilter Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotFilter.</para>
    /// </summary>
    public partial class PivotFilter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotFilter class.
        /// </summary>
        public PivotFilter() : base()
        {
        }

        /// <summary>
        /// <para>useWholeDay, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: useWholeDay</para>
        /// </summary>
        public BooleanValue UseWholeDay
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "pivotFilter");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PivotFilter>()
.AddAttribute(0, "useWholeDay", a => a.UseWholeDay, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the CachedUniqueNames Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:cachedUniqueNames.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CachedUniqueName &lt;x15:cachedUniqueName></description></item>
    /// </list>
    /// </remark>
    public partial class CachedUniqueNames : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CachedUniqueNames class.
        /// </summary>
        public CachedUniqueNames() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CachedUniqueNames class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CachedUniqueNames(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CachedUniqueNames class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CachedUniqueNames(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CachedUniqueNames class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CachedUniqueNames(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "cachedUniqueNames");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<CachedUniqueName>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.CachedUniqueName), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CachedUniqueNames>(deep);
    }

    /// <summary>
    /// <para>Defines the CacheHierarchy Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:cacheHierarchy.</para>
    /// </summary>
    public partial class CacheHierarchy : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CacheHierarchy class.
        /// </summary>
        public CacheHierarchy() : base()
        {
        }

        /// <summary>
        /// <para>aggregatedColumn, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: aggregatedColumn</para>
        /// </summary>
        public Int32Value AggregatedColumn
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "cacheHierarchy");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<CacheHierarchy>()
.AddAttribute(0, "aggregatedColumn", a => a.AggregatedColumn, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CacheHierarchy>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelinePivotCacheDefinition Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelinePivotCacheDefinition.</para>
    /// </summary>
    public partial class TimelinePivotCacheDefinition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelinePivotCacheDefinition class.
        /// </summary>
        public TimelinePivotCacheDefinition() : base()
        {
        }

        /// <summary>
        /// <para>timelineData, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: timelineData</para>
        /// </summary>
        public BooleanValue TimelineData
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "timelinePivotCacheDefinition");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<TimelinePivotCacheDefinition>()
.AddAttribute(0, "timelineData", a => a.TimelineData);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelinePivotCacheDefinition>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotCacheIdVersion Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotCacheIdVersion.</para>
    /// </summary>
    public partial class PivotCacheIdVersion : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotCacheIdVersion class.
        /// </summary>
        public PivotCacheIdVersion() : base()
        {
        }

        /// <summary>
        /// <para>cacheIdSupportedVersion, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: cacheIdSupportedVersion</para>
        /// </summary>
        public ByteValue CacheIdSupportedVersion
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cacheIdCreatedVersion, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: cacheIdCreatedVersion</para>
        /// </summary>
        public ByteValue CacheIdCreatedVersion
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "pivotCacheIdVersion");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PivotCacheIdVersion>()
.AddAttribute(0, "cacheIdSupportedVersion", a => a.CacheIdSupportedVersion, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "cacheIdCreatedVersion", a => a.CacheIdCreatedVersion, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCacheIdVersion>(deep);
    }

    /// <summary>
    /// <para>Defines the DataModel Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dataModel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ModelTables &lt;x15:modelTables></description></item>
    ///   <item><description>ModelRelationships &lt;x15:modelRelationships></description></item>
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DataModel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataModel class.
        /// </summary>
        public DataModel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataModel(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>minVersionLoad, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: minVersionLoad</para>
        /// </summary>
        public ByteValue MinVersionLoad
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "dataModel");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<ModelTables>();
            builder.AddChild<ModelRelationships>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<DataModel>()
.AddAttribute(0, "minVersionLoad", a => a.MinVersionLoad);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ModelTables), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ModelRelationships), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>ModelTables.</para>
        /// <para>Represents the following element tag in the schema: x15:modelTables.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public ModelTables ModelTables
        {
            get => GetElement<ModelTables>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ModelRelationships.</para>
        /// <para>Represents the following element tag in the schema: x15:modelRelationships.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public ModelRelationships ModelRelationships
        {
            get => GetElement<ModelRelationships>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataModel>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotTableData Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTableData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PivotRow &lt;x15:pivotRow></description></item>
    /// </list>
    /// </remark>
    public partial class PivotTableData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableData class.
        /// </summary>
        public PivotTableData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotTableData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rowCount, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rowCount</para>
        /// </summary>
        public UInt32Value RowCount
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columnCount, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: columnCount</para>
        /// </summary>
        public UInt32Value ColumnCount
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cacheId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: cacheId</para>
        /// </summary>
        public UInt32Value CacheId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "pivotTableData");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<PivotRow>();
            builder.AddElement<PivotTableData>()
.AddAttribute(0, "rowCount", a => a.RowCount)
.AddAttribute(0, "columnCount", a => a.ColumnCount)
.AddAttribute(0, "cacheId", a => a.CacheId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.PivotRow), 1, 0, version: FileFormatVersions.Office2013)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableData>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotCacheDecoupled Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotCacheDecoupled.</para>
    /// </summary>
    public partial class PivotCacheDecoupled : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotCacheDecoupled class.
        /// </summary>
        public PivotCacheDecoupled() : base()
        {
        }

        /// <summary>
        /// <para>decoupled, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: decoupled</para>
        /// </summary>
        public BooleanValue Decoupled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "pivotCacheDecoupled");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PivotCacheDecoupled>()
.AddAttribute(0, "decoupled", a => a.Decoupled);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCacheDecoupled>(deep);
    }

    /// <summary>
    /// <para>Defines the DataField Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dataField.</para>
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
        /// <para>isCountDistinct, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isCountDistinct</para>
        /// </summary>
        public BooleanValue IsCountDistinct
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "dataField");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<DataField>()
.AddAttribute(0, "isCountDistinct", a => a.IsCountDistinct);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataField>(deep);
    }

    /// <summary>
    /// <para>Defines the MovingPeriodState Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:movingPeriodState.</para>
    /// </summary>
    public partial class MovingPeriodState : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MovingPeriodState class.
        /// </summary>
        public MovingPeriodState() : base()
        {
        }

        /// <summary>
        /// <para>referenceDateBegin, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: referenceDateBegin</para>
        /// </summary>
        public DateTimeValue ReferenceDateBegin
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>referencePeriod, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: referencePeriod</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep> ReferencePeriod
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>referenceMultiple, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: referenceMultiple</para>
        /// </summary>
        public UInt32Value ReferenceMultiple
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>movingPeriod, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: movingPeriod</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep> MovingPeriod
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>movingMultiple, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: movingMultiple</para>
        /// </summary>
        public UInt32Value MovingMultiple
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "movingPeriodState");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<MovingPeriodState>()
.AddAttribute(0, "referenceDateBegin", a => a.ReferenceDateBegin, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "referencePeriod", a => a.ReferencePeriod, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "referenceMultiple", a => a.ReferenceMultiple, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "movingPeriod", a => a.MovingPeriod, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "movingMultiple", a => a.MovingMultiple, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MovingPeriodState>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCaches Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:slicerCaches.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.SlicerCache &lt;x14:slicerCache></description></item>
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
            builder.SetSchema(71, "slicerCaches");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.SlicerCache>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCache), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCaches>(deep);
    }

    /// <summary>
    /// <para>Defines the TableSlicerCache Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:tableSlicerCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class TableSlicerCache : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TableSlicerCache class.
        /// </summary>
        public TableSlicerCache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableSlicerCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableSlicerCache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableSlicerCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableSlicerCache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableSlicerCache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TableSlicerCache(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>tableId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tableId</para>
        /// </summary>
        public UInt32Value TableId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>column, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: column</para>
        /// </summary>
        public UInt32Value Column
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
        /// <para>customListSort, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: customListSort</para>
        /// </summary>
        public BooleanValue CustomListSort
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
            builder.SetSchema(71, "tableSlicerCache");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<ExtensionList>();
            builder.AddElement<TableSlicerCache>()
.AddAttribute(0, "tableId", a => a.TableId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "column", a => a.Column, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "sortOrder", a => a.SortOrder)
.AddAttribute(0, "customListSort", a => a.CustomListSort)
.AddAttribute(0, "crossFilter", a => a.CrossFilter);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableSlicerCache>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCacheHideItemsWithNoData Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:slicerCacheHideItemsWithNoData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SlicerCacheOlapLevelName &lt;x15:slicerCacheOlapLevelName></description></item>
    /// </list>
    /// </remark>
    public partial class SlicerCacheHideItemsWithNoData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCacheHideItemsWithNoData class.
        /// </summary>
        public SlicerCacheHideItemsWithNoData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheHideItemsWithNoData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCacheHideItemsWithNoData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheHideItemsWithNoData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCacheHideItemsWithNoData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheHideItemsWithNoData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerCacheHideItemsWithNoData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "slicerCacheHideItemsWithNoData");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<SlicerCacheOlapLevelName>();
            builder.AddElement<SlicerCacheHideItemsWithNoData>()
.AddAttribute(0, "count", a => a.Count);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.SlicerCacheOlapLevelName), 0, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheHideItemsWithNoData>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCachePivotTables Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:slicerCachePivotTables.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable &lt;x14:pivotTable></description></item>
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
            builder.SetSchema(71, "slicerCachePivotTables");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCachePivotTables>(deep);
    }

    /// <summary>
    /// <para>Defines the Survey Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:survey.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SurveyPrSurveyElementPr &lt;x15:surveyPr></description></item>
    ///   <item><description>TitlePrSurveyElementPr &lt;x15:titlePr></description></item>
    ///   <item><description>DescriptionPrSurveyElementPr &lt;x15:descriptionPr></description></item>
    ///   <item><description>SurveyQuestions &lt;x15:questions></description></item>
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Survey : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Survey class.
        /// </summary>
        public Survey() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Survey class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Survey(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Survey class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Survey(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Survey class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Survey(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public UInt32Value Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>guid, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: guid</para>
        /// </summary>
        public StringValue Guid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "survey");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<SurveyPrSurveyElementPr>();
            builder.AddChild<TitlePrSurveyElementPr>();
            builder.AddChild<DescriptionPrSurveyElementPr>();
            builder.AddChild<SurveyQuestions>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<Survey>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "guid", a => a.Guid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "description", a => a.Description);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.SurveyPrSurveyElementPr), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TitlePrSurveyElementPr), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.DescriptionPrSurveyElementPr), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.SurveyQuestions), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>SurveyPrSurveyElementPr.</para>
        /// <para>Represents the following element tag in the schema: x15:surveyPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public SurveyPrSurveyElementPr SurveyPrSurveyElementPr
        {
            get => GetElement<SurveyPrSurveyElementPr>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TitlePrSurveyElementPr.</para>
        /// <para>Represents the following element tag in the schema: x15:titlePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public TitlePrSurveyElementPr TitlePrSurveyElementPr
        {
            get => GetElement<TitlePrSurveyElementPr>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DescriptionPrSurveyElementPr.</para>
        /// <para>Represents the following element tag in the schema: x15:descriptionPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DescriptionPrSurveyElementPr DescriptionPrSurveyElementPr
        {
            get => GetElement<DescriptionPrSurveyElementPr>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SurveyQuestions.</para>
        /// <para>Represents the following element tag in the schema: x15:questions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public SurveyQuestions SurveyQuestions
        {
            get => GetElement<SurveyQuestions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Survey>(deep);
    }

    /// <summary>
    /// <para>Defines the Timelines Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Timeline &lt;x15:timeline></description></item>
    /// </list>
    /// </remark>
    public partial class Timelines : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Timelines class.
        /// </summary>
        public Timelines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timelines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Timelines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timelines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Timelines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timelines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Timelines(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "timelines");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<Timeline>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.Timeline), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Timelines>(deep);

        internal Timelines(TimeLinePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the TimeLinePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(TimeLinePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the TimeLinePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(TimeLinePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the TimeLinePart associated with this element.
        /// </summary>
        public TimeLinePart TimeLinePart
        {
            get => OpenXmlPart as TimeLinePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the TimelineCacheDefinition Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineCacheDefinition.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TimelineCachePivotTables &lt;x15:pivotTables></description></item>
    ///   <item><description>TimelineState &lt;x15:state></description></item>
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class TimelineCacheDefinition : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineCacheDefinition class.
        /// </summary>
        public TimelineCacheDefinition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCacheDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCacheDefinition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCacheDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCacheDefinition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCacheDefinition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineCacheDefinition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sourceName, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "timelineCacheDefinition");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<TimelineCachePivotTables>();
            builder.AddChild<TimelineState>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<TimelineCacheDefinition>()
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
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineCachePivotTables), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineState), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>TimelineCachePivotTables.</para>
        /// <para>Represents the following element tag in the schema: x15:pivotTables.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public TimelineCachePivotTables TimelineCachePivotTables
        {
            get => GetElement<TimelineCachePivotTables>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TimelineState.</para>
        /// <para>Represents the following element tag in the schema: x15:state.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public TimelineState TimelineState
        {
            get => GetElement<TimelineState>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCacheDefinition>(deep);

        internal TimelineCacheDefinition(TimeLineCachePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the TimeLineCachePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(TimeLineCachePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the TimeLineCachePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(TimeLineCachePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the TimeLineCachePart associated with this element.
        /// </summary>
        public TimeLineCachePart TimeLineCachePart
        {
            get => OpenXmlPart as TimeLineCachePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the PivotTableReference Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTableReference.</para>
    /// </summary>
    public partial class PivotTableReference : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableReference class.
        /// </summary>
        public PivotTableReference() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "pivotTableReference");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PivotTableReference>()
.AddAttribute(19, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableReference>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtension Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:webExtension.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
    /// </list>
    /// </remark>
    public partial class WebExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtension class.
        /// </summary>
        public WebExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>appRef, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: appRef</para>
        /// </summary>
        public StringValue ApplicationReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "webExtension");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.Formula>();
            builder.AddElement<WebExtension>()
.AddAttribute(0, "appRef", a => a.ApplicationReference, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 1, 1)
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineCacheReference Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineCacheRef.</para>
    /// </summary>
    public partial class TimelineCacheReference : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineCacheReference class.
        /// </summary>
        public TimelineCacheReference() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "timelineCacheRef");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<TimelineCacheReference>()
.AddAttribute(19, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCacheReference>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineReference Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineRef.</para>
    /// </summary>
    public partial class TimelineReference : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineReference class.
        /// </summary>
        public TimelineReference() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "timelineRef");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<TimelineReference>()
.AddAttribute(19, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineReference>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineStyle Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TimelineStyleElements &lt;x15:timelineStyleElements></description></item>
    /// </list>
    /// </remark>
    public partial class TimelineStyle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineStyle class.
        /// </summary>
        public TimelineStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineStyle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "timelineStyle");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<TimelineStyleElements>();
            builder.AddElement<TimelineStyle>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleElements), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>TimelineStyleElements.</para>
        /// <para>Represents the following element tag in the schema: x15:timelineStyleElements.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public TimelineStyleElements TimelineStyleElements
        {
            get => GetElement<TimelineStyleElements>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineStyleElement Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineStyleElement.</para>
    /// </summary>
    public partial class TimelineStyleElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineStyleElement class.
        /// </summary>
        public TimelineStyleElement() : base()
        {
        }

        /// <summary>
        /// <para>type, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleType> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dxfId, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "timelineStyleElement");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<TimelineStyleElement>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "dxfId", a => a.FormatId);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineStyleElement>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineStyleElements Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineStyleElements.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TimelineStyleElement &lt;x15:timelineStyleElement></description></item>
    /// </list>
    /// </remark>
    public partial class TimelineStyleElements : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineStyleElements class.
        /// </summary>
        public TimelineStyleElements() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyleElements class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineStyleElements(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyleElements class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineStyleElements(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyleElements class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineStyleElements(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "timelineStyleElements");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<TimelineStyleElement>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleElement), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineStyleElements>(deep);
    }

    /// <summary>
    /// <para>Defines the DbTable Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dbTable.</para>
    /// </summary>
    public partial class DbTable : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DbTable class.
        /// </summary>
        public DbTable() : base()
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "dbTable");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<DbTable>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DbTable>(deep);
    }

    /// <summary>
    /// <para>Defines the DbTables Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dbTables.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DbTable &lt;x15:dbTable></description></item>
    /// </list>
    /// </remark>
    public partial class DbTables : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DbTables class.
        /// </summary>
        public DbTables() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DbTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DbTables(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DbTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DbTables(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DbTables class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DbTables(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "dbTables");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DbTable>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.DbTable), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DbTables>(deep);
    }

    /// <summary>
    /// <para>Defines the DbCommand Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dbCommand.</para>
    /// </summary>
    public partial class DbCommand : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DbCommand class.
        /// </summary>
        public DbCommand() : base()
        {
        }

        /// <summary>
        /// <para>text, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: text</para>
        /// </summary>
        public StringValue Text
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "dbCommand");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<DbCommand>()
.AddAttribute(0, "text", a => a.Text, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DbCommand>(deep);
    }

    /// <summary>
    /// <para>Defines the TextProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:textPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.TextFields &lt;x:textFields></description></item>
    /// </list>
    /// </remark>
    public partial class TextProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextProperties class.
        /// </summary>
        public TextProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>prompt</para>
        /// <para>Represents the following attribute in the schema: prompt</para>
        /// </summary>
        public BooleanValue Prompt
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fileType</para>
        /// <para>Represents the following attribute in the schema: fileType</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.FileTypeValues> FileType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.FileTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>codePage</para>
        /// <para>Represents the following attribute in the schema: codePage</para>
        /// </summary>
        public UInt32Value CodePage
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>characterSet</para>
        /// <para>Represents the following attribute in the schema: characterSet</para>
        /// </summary>
        public StringValue TextCharacterSet
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>firstRow</para>
        /// <para>Represents the following attribute in the schema: firstRow</para>
        /// </summary>
        public UInt32Value FirstRow
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sourceFile</para>
        /// <para>Represents the following attribute in the schema: sourceFile</para>
        /// </summary>
        public StringValue SourceFile
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>delimited</para>
        /// <para>Represents the following attribute in the schema: delimited</para>
        /// </summary>
        public BooleanValue Delimited
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>decimal</para>
        /// <para>Represents the following attribute in the schema: decimal</para>
        /// </summary>
        public StringValue Decimal
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>thousands</para>
        /// <para>Represents the following attribute in the schema: thousands</para>
        /// </summary>
        public StringValue Thousands
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tab</para>
        /// <para>Represents the following attribute in the schema: tab</para>
        /// </summary>
        public BooleanValue TabAsDelimiter
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>space</para>
        /// <para>Represents the following attribute in the schema: space</para>
        /// </summary>
        public BooleanValue Space
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>comma</para>
        /// <para>Represents the following attribute in the schema: comma</para>
        /// </summary>
        public BooleanValue Comma
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>semicolon</para>
        /// <para>Represents the following attribute in the schema: semicolon</para>
        /// </summary>
        public BooleanValue Semicolon
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>consecutive</para>
        /// <para>Represents the following attribute in the schema: consecutive</para>
        /// </summary>
        public BooleanValue Consecutive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>qualifier</para>
        /// <para>Represents the following attribute in the schema: qualifier</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.QualifierValues> Qualifier
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.QualifierValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>delimiter</para>
        /// <para>Represents the following attribute in the schema: delimiter</para>
        /// </summary>
        public StringValue Delimiter
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "textPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.TextFields>();
            builder.AddElement<TextProperties>()
.AddAttribute(0, "prompt", a => a.Prompt)
.AddAttribute(0, "fileType", a => a.FileType)
.AddAttribute(0, "codePage", a => a.CodePage)
.AddAttribute(0, "characterSet", a => a.TextCharacterSet)
.AddAttribute(0, "firstRow", a => a.FirstRow)
.AddAttribute(0, "sourceFile", a => a.SourceFile)
.AddAttribute(0, "delimited", a => a.Delimited)
.AddAttribute(0, "decimal", a => a.Decimal)
.AddAttribute(0, "thousands", a => a.Thousands)
.AddAttribute(0, "tab", a => a.TabAsDelimiter)
.AddAttribute(0, "space", a => a.Space)
.AddAttribute(0, "comma", a => a.Comma)
.AddAttribute(0, "semicolon", a => a.Semicolon)
.AddAttribute(0, "consecutive", a => a.Consecutive)
.AddAttribute(0, "qualifier", a => a.Qualifier)
.AddAttribute(0, "delimiter", a => a.Delimiter);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.TextFields), 0, 1)
            };
        }

        /// <summary>
        /// <para>TextFields.</para>
        /// <para>Represents the following element tag in the schema: x:textFields.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.TextFields TextFields
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.TextFields>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ModelTextProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:modelTextPr.</para>
    /// </summary>
    public partial class ModelTextProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelTextProperties class.
        /// </summary>
        public ModelTextProperties() : base()
        {
        }

        /// <summary>
        /// <para>headers, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: headers</para>
        /// </summary>
        public BooleanValue Headers
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "modelTextPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ModelTextProperties>()
.AddAttribute(0, "headers", a => a.Headers);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTextProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the RangeProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:rangePr.</para>
    /// </summary>
    public partial class RangeProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RangeProperties class.
        /// </summary>
        public RangeProperties() : base()
        {
        }

        /// <summary>
        /// <para>sourceName, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "rangePr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<RangeProperties>()
.AddAttribute(0, "sourceName", a => a.SourceName, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RangeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the OleDbPrpoperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:oledbPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DbTables &lt;x15:dbTables></description></item>
    ///   <item><description>DbCommand &lt;x15:dbCommand></description></item>
    /// </list>
    /// </remark>
    public partial class OleDbPrpoperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OleDbPrpoperties class.
        /// </summary>
        public OleDbPrpoperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleDbPrpoperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleDbPrpoperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleDbPrpoperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleDbPrpoperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleDbPrpoperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OleDbPrpoperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>connection, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: connection</para>
        /// </summary>
        public StringValue Connection
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "oledbPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DbTables>();
            builder.AddChild<DbCommand>();
            builder.AddElement<OleDbPrpoperties>()
.AddAttribute(0, "connection", a => a.Connection);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.DbTables), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.DbCommand), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>DbTables.</para>
        /// <para>Represents the following element tag in the schema: x15:dbTables.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DbTables DbTables
        {
            get => GetElement<DbTables>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DbCommand.</para>
        /// <para>Represents the following element tag in the schema: x15:dbCommand.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DbCommand DbCommand
        {
            get => GetElement<DbCommand>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OleDbPrpoperties>(deep);
    }

    /// <summary>
    /// <para>Defines the DataFeedProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dataFeedPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DbTables &lt;x15:dbTables></description></item>
    /// </list>
    /// </remark>
    public partial class DataFeedProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataFeedProperties class.
        /// </summary>
        public DataFeedProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataFeedProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataFeedProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataFeedProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataFeedProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataFeedProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataFeedProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>connection, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: connection</para>
        /// </summary>
        public StringValue Connection
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "dataFeedPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DbTables>();
            builder.AddElement<DataFeedProperties>()
.AddAttribute(0, "connection", a => a.Connection, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.DbTables), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>DbTables.</para>
        /// <para>Represents the following element tag in the schema: x15:dbTables.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DbTables DbTables
        {
            get => GetElement<DbTables>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataFeedProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the FieldListActiveTabTopLevelEntity Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:activeTabTopLevelEntity.</para>
    /// </summary>
    public partial class FieldListActiveTabTopLevelEntity : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FieldListActiveTabTopLevelEntity class.
        /// </summary>
        public FieldListActiveTabTopLevelEntity() : base()
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public UInt32Value Type
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "activeTabTopLevelEntity");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<FieldListActiveTabTopLevelEntity>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "type", a => a.Type);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FieldListActiveTabTopLevelEntity>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:extLst.</para>
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
            builder.SetSchema(71, "extLst");
            builder.Availability = FileFormatVersions.Office2013;
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
    /// <para>Defines the CachedUniqueName Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:cachedUniqueName.</para>
    /// </summary>
    public partial class CachedUniqueName : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CachedUniqueName class.
        /// </summary>
        public CachedUniqueName() : base()
        {
        }

        /// <summary>
        /// <para>index, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: index</para>
        /// </summary>
        public UInt32Value Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "cachedUniqueName");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<CachedUniqueName>()
.AddAttribute(0, "index", a => a.Index, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CachedUniqueName>(deep);
    }

    /// <summary>
    /// <para>Defines the ModelTable Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:modelTable.</para>
    /// </summary>
    public partial class ModelTable : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelTable class.
        /// </summary>
        public ModelTable() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>connection, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: connection</para>
        /// </summary>
        public StringValue Connection
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "modelTable");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ModelTable>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "connection", a => a.Connection, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTable>(deep);
    }

    /// <summary>
    /// <para>Defines the ModelRelationship Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:modelRelationship.</para>
    /// </summary>
    public partial class ModelRelationship : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelRelationship class.
        /// </summary>
        public ModelRelationship() : base()
        {
        }

        /// <summary>
        /// <para>fromTable, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fromTable</para>
        /// </summary>
        public StringValue FromTable
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fromColumn, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fromColumn</para>
        /// </summary>
        public StringValue FromColumn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>toTable, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: toTable</para>
        /// </summary>
        public StringValue ToTable
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>toColumn, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: toColumn</para>
        /// </summary>
        public StringValue ToColumn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "modelRelationship");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ModelRelationship>()
.AddAttribute(0, "fromTable", a => a.FromTable, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "fromColumn", a => a.FromColumn, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "toTable", a => a.ToTable, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "toColumn", a => a.ToColumn, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelRelationship>(deep);
    }

    /// <summary>
    /// <para>Defines the ModelTables Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:modelTables.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ModelTable &lt;x15:modelTable></description></item>
    /// </list>
    /// </remark>
    public partial class ModelTables : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelTables class.
        /// </summary>
        public ModelTables() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelTables(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelTables(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTables class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModelTables(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "modelTables");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<ModelTable>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ModelTable), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTables>(deep);
    }

    /// <summary>
    /// <para>Defines the ModelRelationships Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:modelRelationships.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ModelRelationship &lt;x15:modelRelationship></description></item>
    /// </list>
    /// </remark>
    public partial class ModelRelationships : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelRelationships class.
        /// </summary>
        public ModelRelationships() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelRelationships class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelRelationships(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelRelationships class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelRelationships(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelRelationships class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModelRelationships(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "modelRelationships");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<ModelRelationship>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ModelRelationship), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelRelationships>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotValueCell Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:c.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Xstring &lt;x15:v></description></item>
    ///   <item><description>PivotValueCellExtra &lt;x15:x></description></item>
    /// </list>
    /// </remark>
    public partial class PivotValueCell : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotValueCell class.
        /// </summary>
        public PivotValueCell() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotValueCell class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotValueCell(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotValueCell class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotValueCell(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotValueCell class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotValueCell(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>i, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: i</para>
        /// </summary>
        public UInt32Value Item
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SXVCellType> Text
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SXVCellType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "c");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<Xstring>();
            builder.AddChild<PivotValueCellExtra>();
            builder.AddElement<PivotValueCell>()
.AddAttribute(0, "i", a => a.Item)
.AddAttribute(0, "t", a => a.Text);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.Xstring), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.PivotValueCellExtra), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>Xstring.</para>
        /// <para>Represents the following element tag in the schema: x15:v.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public Xstring Xstring
        {
            get => GetElement<Xstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotValueCellExtra.</para>
        /// <para>Represents the following element tag in the schema: x15:x.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public PivotValueCellExtra PivotValueCellExtra
        {
            get => GetElement<PivotValueCellExtra>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotValueCell>(deep);
    }

    /// <summary>
    /// <para>Defines the Xstring Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:v.</para>
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
            builder.SetSchema(71, "v");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Xstring>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotValueCellExtra Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:x.</para>
    /// </summary>
    public partial class PivotValueCellExtra : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotValueCellExtra class.
        /// </summary>
        public PivotValueCellExtra() : base()
        {
        }

        /// <summary>
        /// <para>in, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: in</para>
        /// </summary>
        public UInt32Value FormatIndex
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bc, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: bc</para>
        /// </summary>
        public HexBinaryValue BackgroundColor
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fc, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: fc</para>
        /// </summary>
        public HexBinaryValue ForegroundColor
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>i, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: i</para>
        /// </summary>
        public BooleanValue Italic
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>un, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: un</para>
        /// </summary>
        public BooleanValue Underline
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>st, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>
        public BooleanValue Strikethrough
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>b, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>
        public BooleanValue Bold
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "x");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PivotValueCellExtra>()
.AddAttribute(0, "in", a => a.FormatIndex)
.AddAttribute(0, "bc", a => a.BackgroundColor, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Length = (4L) });
})
.AddAttribute(0, "fc", a => a.ForegroundColor, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Length = (4L) });
})
.AddAttribute(0, "i", a => a.Italic)
.AddAttribute(0, "un", a => a.Underline)
.AddAttribute(0, "st", a => a.Strikethrough)
.AddAttribute(0, "b", a => a.Bold);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotValueCellExtra>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotTableServerFormats Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTableServerFormats.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ServerFormat &lt;x15:serverFormat></description></item>
    /// </list>
    /// </remark>
    public partial class PivotTableServerFormats : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableServerFormats class.
        /// </summary>
        public PivotTableServerFormats() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableServerFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableServerFormats(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableServerFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableServerFormats(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableServerFormats class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotTableServerFormats(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "pivotTableServerFormats");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<ServerFormat>();
            builder.AddElement<PivotTableServerFormats>()
.AddAttribute(0, "count", a => a.Count, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ServerFormat), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableServerFormats>(deep);
    }

    /// <summary>
    /// <para>Defines the ServerFormat Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:serverFormat.</para>
    /// </summary>
    public partial class ServerFormat : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ServerFormat class.
        /// </summary>
        public ServerFormat() : base()
        {
        }

        /// <summary>
        /// <para>Culture</para>
        /// <para>Represents the following attribute in the schema: culture</para>
        /// </summary>
        public StringValue Culture
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Format</para>
        /// <para>Represents the following attribute in the schema: format</para>
        /// </summary>
        public StringValue Format
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "serverFormat");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ServerFormat>()
.AddAttribute(0, "culture", a => a.Culture)
.AddAttribute(0, "format", a => a.Format);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ServerFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCacheOlapLevelName Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:slicerCacheOlapLevelName.</para>
    /// </summary>
    public partial class SlicerCacheOlapLevelName : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCacheOlapLevelName class.
        /// </summary>
        public SlicerCacheOlapLevelName() : base()
        {
        }

        /// <summary>
        /// <para>uniqueName, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: uniqueName</para>
        /// </summary>
        public StringValue UniqueName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>count, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "slicerCacheOlapLevelName");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<SlicerCacheOlapLevelName>()
.AddAttribute(0, "uniqueName", a => a.UniqueName, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "count", a => a.Count, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheOlapLevelName>(deep);
    }

    /// <summary>
    /// <para>Defines the SurveyPrSurveyElementPr Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:surveyPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class SurveyPrSurveyElementPr : OpenXmlSurveyElementPrElement
    {
        /// <summary>
        /// Initializes a new instance of the SurveyPrSurveyElementPr class.
        /// </summary>
        public SurveyPrSurveyElementPr() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurveyPrSurveyElementPr(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurveyPrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyPrSurveyElementPr class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurveyPrSurveyElementPr(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "surveyPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurveyPrSurveyElementPr>(deep);
    }

    /// <summary>
    /// <para>Defines the TitlePrSurveyElementPr Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:titlePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class TitlePrSurveyElementPr : OpenXmlSurveyElementPrElement
    {
        /// <summary>
        /// Initializes a new instance of the TitlePrSurveyElementPr class.
        /// </summary>
        public TitlePrSurveyElementPr() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitlePrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TitlePrSurveyElementPr(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitlePrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TitlePrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitlePrSurveyElementPr class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TitlePrSurveyElementPr(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "titlePr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TitlePrSurveyElementPr>(deep);
    }

    /// <summary>
    /// <para>Defines the DescriptionPrSurveyElementPr Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:descriptionPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DescriptionPrSurveyElementPr : OpenXmlSurveyElementPrElement
    {
        /// <summary>
        /// Initializes a new instance of the DescriptionPrSurveyElementPr class.
        /// </summary>
        public DescriptionPrSurveyElementPr() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DescriptionPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DescriptionPrSurveyElementPr(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DescriptionPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DescriptionPrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DescriptionPrSurveyElementPr class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DescriptionPrSurveyElementPr(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "descriptionPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DescriptionPrSurveyElementPr>(deep);
    }

    /// <summary>
    /// <para>Defines the QuestionsPrSurveyElementPr Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:questionsPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class QuestionsPrSurveyElementPr : OpenXmlSurveyElementPrElement
    {
        /// <summary>
        /// Initializes a new instance of the QuestionsPrSurveyElementPr class.
        /// </summary>
        public QuestionsPrSurveyElementPr() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuestionsPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public QuestionsPrSurveyElementPr(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuestionsPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public QuestionsPrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuestionsPrSurveyElementPr class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public QuestionsPrSurveyElementPr(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "questionsPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuestionsPrSurveyElementPr>(deep);
    }

    /// <summary>
    /// <para>Defines the QuestionPrSurveyElementPr Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:questionPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class QuestionPrSurveyElementPr : OpenXmlSurveyElementPrElement
    {
        /// <summary>
        /// Initializes a new instance of the QuestionPrSurveyElementPr class.
        /// </summary>
        public QuestionPrSurveyElementPr() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuestionPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public QuestionPrSurveyElementPr(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuestionPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public QuestionPrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuestionPrSurveyElementPr class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public QuestionPrSurveyElementPr(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "questionPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuestionPrSurveyElementPr>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlSurveyElementPrElement Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public abstract partial class OpenXmlSurveyElementPrElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlSurveyElementPrElement class.
        /// </summary>
        protected OpenXmlSurveyElementPrElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSurveyElementPrElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlSurveyElementPrElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSurveyElementPrElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlSurveyElementPrElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSurveyElementPrElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OpenXmlSurveyElementPrElement(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>cssClass, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: cssClass</para>
        /// </summary>
        public StringValue CssClass
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bottom, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: bottom</para>
        /// </summary>
        public Int32Value Bottom
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>top, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: top</para>
        /// </summary>
        public Int32Value Top
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>left, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: left</para>
        /// </summary>
        public Int32Value Left
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>right, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: right</para>
        /// </summary>
        public Int32Value Right
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>width, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: width</para>
        /// </summary>
        public UInt32Value Width
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>height, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: height</para>
        /// </summary>
        public UInt32Value Height
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>position, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SurveyPosition> Position
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SurveyPosition>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<ExtensionList>();
            builder.AddElement<OpenXmlSurveyElementPrElement>()
.AddAttribute(0, "cssClass", a => a.CssClass)
.AddAttribute(0, "bottom", a => a.Bottom)
.AddAttribute(0, "top", a => a.Top)
.AddAttribute(0, "left", a => a.Left)
.AddAttribute(0, "right", a => a.Right)
.AddAttribute(0, "width", a => a.Width)
.AddAttribute(0, "height", a => a.Height)
.AddAttribute(0, "position", a => a.Position);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the SurveyQuestions Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:questions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>QuestionsPrSurveyElementPr &lt;x15:questionsPr></description></item>
    ///   <item><description>SurveyQuestion &lt;x15:question></description></item>
    /// </list>
    /// </remark>
    public partial class SurveyQuestions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurveyQuestions class.
        /// </summary>
        public SurveyQuestions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurveyQuestions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurveyQuestions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurveyQuestions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "questions");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<QuestionsPrSurveyElementPr>();
            builder.AddChild<SurveyQuestion>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.QuestionsPrSurveyElementPr), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.SurveyQuestion), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>QuestionsPrSurveyElementPr.</para>
        /// <para>Represents the following element tag in the schema: x15:questionsPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public QuestionsPrSurveyElementPr QuestionsPrSurveyElementPr
        {
            get => GetElement<QuestionsPrSurveyElementPr>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurveyQuestions>(deep);
    }

    /// <summary>
    /// <para>Defines the SurveyQuestion Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:question.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>QuestionPrSurveyElementPr &lt;x15:questionPr></description></item>
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class SurveyQuestion : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurveyQuestion class.
        /// </summary>
        public SurveyQuestion() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestion class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurveyQuestion(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestion class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurveyQuestion(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestion class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurveyQuestion(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>binding, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: binding</para>
        /// </summary>
        public UInt32Value Binding
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>text, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: text</para>
        /// </summary>
        public StringValue Text
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionType> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>format, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: format</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionFormat> Format
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionFormat>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>helpText, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: helpText</para>
        /// </summary>
        public StringValue HelpText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>required, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: required</para>
        /// </summary>
        public BooleanValue Required
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>defaultValue, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: defaultValue</para>
        /// </summary>
        public StringValue DefaultValue
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>decimalPlaces, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: decimalPlaces</para>
        /// </summary>
        public UInt32Value DecimalPlaces
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rowSource, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rowSource</para>
        /// </summary>
        public StringValue RowSource
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "question");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<QuestionPrSurveyElementPr>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<SurveyQuestion>()
.AddAttribute(0, "binding", a => a.Binding, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "text", a => a.Text)
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "format", a => a.Format)
.AddAttribute(0, "helpText", a => a.HelpText)
.AddAttribute(0, "required", a => a.Required)
.AddAttribute(0, "defaultValue", a => a.DefaultValue)
.AddAttribute(0, "decimalPlaces", a => a.DecimalPlaces)
.AddAttribute(0, "rowSource", a => a.RowSource);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.QuestionPrSurveyElementPr), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>QuestionPrSurveyElementPr.</para>
        /// <para>Represents the following element tag in the schema: x15:questionPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public QuestionPrSurveyElementPr QuestionPrSurveyElementPr
        {
            get => GetElement<QuestionPrSurveyElementPr>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurveyQuestion>(deep);
    }

    /// <summary>
    /// <para>Defines the Timeline Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timeline.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Timeline : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Timeline class.
        /// </summary>
        public Timeline() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timeline class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Timeline(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timeline class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Timeline(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timeline class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Timeline(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cache, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: cache</para>
        /// </summary>
        public StringValue Cache
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>caption, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: caption</para>
        /// </summary>
        public StringValue Caption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showHeader, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showHeader</para>
        /// </summary>
        public BooleanValue ShowHeader
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showSelectionLabel, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showSelectionLabel</para>
        /// </summary>
        public BooleanValue ShowSelectionLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showTimeLevel, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showTimeLevel</para>
        /// </summary>
        public BooleanValue ShowTimeLevel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showHorizontalScrollbar, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showHorizontalScrollbar</para>
        /// </summary>
        public BooleanValue ShowHorizontalScrollbar
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>level, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: level</para>
        /// </summary>
        public UInt32Value Level
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>selectionLevel, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: selectionLevel</para>
        /// </summary>
        public UInt32Value SelectionLevel
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>scrollPosition, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: scrollPosition</para>
        /// </summary>
        public DateTimeValue ScrollPosition
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "timeline");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<ExtensionList>();
            builder.AddElement<Timeline>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "cache", a => a.Cache, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "caption", a => a.Caption)
.AddAttribute(0, "showHeader", a => a.ShowHeader)
.AddAttribute(0, "showSelectionLabel", a => a.ShowSelectionLabel)
.AddAttribute(0, "showTimeLevel", a => a.ShowTimeLevel)
.AddAttribute(0, "showHorizontalScrollbar", a => a.ShowHorizontalScrollbar)
.AddAttribute(0, "level", a => a.Level, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "selectionLevel", a => a.SelectionLevel, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "scrollPosition", a => a.ScrollPosition)
.AddAttribute(0, "style", a => a.Style);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint(0 /*:name*/, 1, 1000) { Application = ApplicationType.Excel, Version = FileFormatVersions.Office2013 });
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Timeline>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineCachePivotTable Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTable.</para>
    /// </summary>
    public partial class TimelineCachePivotTable : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotTable class.
        /// </summary>
        public TimelineCachePivotTable() : base()
        {
        }

        /// <summary>
        /// <para>tabId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: tabId</para>
        /// </summary>
        public UInt32Value TabId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "pivotTable");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<TimelineCachePivotTable>()
.AddAttribute(0, "tabId", a => a.TabId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCachePivotTable>(deep);
    }

    /// <summary>
    /// <para>Defines the SelectionTimelineRange Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:selection.</para>
    /// </summary>
    public partial class SelectionTimelineRange : TimelineRange
    {
        /// <summary>
        /// Initializes a new instance of the SelectionTimelineRange class.
        /// </summary>
        public SelectionTimelineRange() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "selection");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SelectionTimelineRange>(deep);
    }

    /// <summary>
    /// <para>Defines the BoundsTimelineRange Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:bounds.</para>
    /// </summary>
    public partial class BoundsTimelineRange : TimelineRange
    {
        /// <summary>
        /// Initializes a new instance of the BoundsTimelineRange class.
        /// </summary>
        public BoundsTimelineRange() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "bounds");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BoundsTimelineRange>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineRange Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class TimelineRange : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineRange class.
        /// </summary>
        protected TimelineRange() : base()
        {
        }

        /// <summary>
        /// <para>startDate, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: startDate</para>
        /// </summary>
        public DateTimeValue StartDate
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endDate, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: endDate</para>
        /// </summary>
        public DateTimeValue EndDate
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<TimelineRange>()
                           .AddAttribute(0, "startDate", a => a.StartDate, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           })
                           .AddAttribute(0, "endDate", a => a.EndDate, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Defines the AutoFilter Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:autoFilter.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.FilterColumn &lt;x:filterColumn></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.SortState &lt;x:sortState></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.ExtensionList &lt;x:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class AutoFilter : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AutoFilter class.
        /// </summary>
        public AutoFilter() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AutoFilter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AutoFilter(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AutoFilter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AutoFilter(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AutoFilter class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AutoFilter(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Cell or Range Reference</para>
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
            builder.SetSchema(71, "autoFilter");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.FilterColumn>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.SortState>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            builder.AddElement<AutoFilter>()
.AddAttribute(0, "ref", a => a.Reference);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.FilterColumn), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SortState), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineCachePivotTables Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTables.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TimelineCachePivotTable &lt;x15:pivotTable></description></item>
    /// </list>
    /// </remark>
    public partial class TimelineCachePivotTables : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotTables class.
        /// </summary>
        public TimelineCachePivotTables() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCachePivotTables(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCachePivotTables(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotTables class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineCachePivotTables(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "pivotTables");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<TimelineCachePivotTable>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineCachePivotTable), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCachePivotTables>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineState Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:state.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SelectionTimelineRange &lt;x15:selection></description></item>
    ///   <item><description>BoundsTimelineRange &lt;x15:bounds></description></item>
    ///   <item><description>MovingPeriodState &lt;x15:movingPeriodState></description></item>
    ///   <item><description>ExtensionList &lt;x15:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class TimelineState : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineState class.
        /// </summary>
        public TimelineState() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineState class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineState(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineState class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineState(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineState class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineState(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>singleRangeFilterState, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: singleRangeFilterState</para>
        /// </summary>
        public BooleanValue SingleRangeFilterState
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>minimalRefreshVersion, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: minimalRefreshVersion</para>
        /// </summary>
        public UInt32Value MinimalRefreshVersion
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lastRefreshVersion, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: lastRefreshVersion</para>
        /// </summary>
        public UInt32Value LastRefreshVersion
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pivotCacheId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pivotCacheId</para>
        /// </summary>
        public UInt32Value PivotCacheId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>filterType, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: filterType</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotFilterValues> FilterType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotFilterValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>filterId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: filterId</para>
        /// </summary>
        public UInt32Value FilterId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>filterTabId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: filterTabId</para>
        /// </summary>
        public UInt32Value FilterTabId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>filterPivotName, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: filterPivotName</para>
        /// </summary>
        public StringValue FilterPivotName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(71, "state");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<SelectionTimelineRange>();
            builder.AddChild<BoundsTimelineRange>();
            builder.AddChild<MovingPeriodState>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<TimelineState>()
.AddAttribute(0, "singleRangeFilterState", a => a.SingleRangeFilterState)
.AddAttribute(0, "minimalRefreshVersion", a => a.MinimalRefreshVersion, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "lastRefreshVersion", a => a.LastRefreshVersion, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "pivotCacheId", a => a.PivotCacheId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "filterType", a => a.FilterType, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "filterId", a => a.FilterId)
.AddAttribute(0, "filterTabId", a => a.FilterTabId)
.AddAttribute(0, "filterPivotName", a => a.FilterPivotName);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.SelectionTimelineRange), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.BoundsTimelineRange), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodState), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>SelectionTimelineRange.</para>
        /// <para>Represents the following element tag in the schema: x15:selection.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public SelectionTimelineRange SelectionTimelineRange
        {
            get => GetElement<SelectionTimelineRange>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BoundsTimelineRange.</para>
        /// <para>Represents the following element tag in the schema: x15:bounds.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public BoundsTimelineRange BoundsTimelineRange
        {
            get => GetElement<BoundsTimelineRange>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MovingPeriodState.</para>
        /// <para>Represents the following element tag in the schema: x15:movingPeriodState.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public MovingPeriodState MovingPeriodState
        {
            get => GetElement<MovingPeriodState>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineState>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotRow Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotRow.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PivotValueCell &lt;x15:c></description></item>
    /// </list>
    /// </remark>
    public partial class PivotRow : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotRow class.
        /// </summary>
        public PivotRow() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotRow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotRow(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotRow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotRow(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotRow class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotRow(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>r, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        public UInt32Value Reference
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>count, this property is only available in Office2013, Office2016</para>
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
            builder.SetSchema(71, "pivotRow");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<PivotValueCell>();
            builder.AddElement<PivotRow>()
.AddAttribute(0, "r", a => a.Reference)
.AddAttribute(0, "count", a => a.Count, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.PivotValueCell), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotRow>(deep);
    }

    /// <summary>
    /// Defines the TimelineStyleType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public enum TimelineStyleType
    {
        ///<summary>
        ///selectionLabel.
        ///<para>When the item is serialized out as xml, its value is "selectionLabel".</para>
        ///</summary>
        [EnumString("selectionLabel")]
        SelectionLabel,
        ///<summary>
        ///timeLevel.
        ///<para>When the item is serialized out as xml, its value is "timeLevel".</para>
        ///</summary>
        [EnumString("timeLevel")]
        TimeLevel,
        ///<summary>
        ///periodLabel1.
        ///<para>When the item is serialized out as xml, its value is "periodLabel1".</para>
        ///</summary>
        [EnumString("periodLabel1")]
        PeriodLabel1,
        ///<summary>
        ///periodLabel2.
        ///<para>When the item is serialized out as xml, its value is "periodLabel2".</para>
        ///</summary>
        [EnumString("periodLabel2")]
        PeriodLabel2,
        ///<summary>
        ///selectedTimeBlock.
        ///<para>When the item is serialized out as xml, its value is "selectedTimeBlock".</para>
        ///</summary>
        [EnumString("selectedTimeBlock")]
        SelectedTimeBlock,
        ///<summary>
        ///unselectedTimeBlock.
        ///<para>When the item is serialized out as xml, its value is "unselectedTimeBlock".</para>
        ///</summary>
        [EnumString("unselectedTimeBlock")]
        UnselectedTimeBlock,
        ///<summary>
        ///selectedTimeBlockSpace.
        ///<para>When the item is serialized out as xml, its value is "selectedTimeBlockSpace".</para>
        ///</summary>
        [EnumString("selectedTimeBlockSpace")]
        SelectedTimeBlockSpace,
    }

    /// <summary>
    /// Defines the CalculatedMemberNumberFormat enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public enum CalculatedMemberNumberFormat
    {
        ///<summary>
        ///default.
        ///<para>When the item is serialized out as xml, its value is "default".</para>
        ///</summary>
        [EnumString("default")]
        Default,
        ///<summary>
        ///number.
        ///<para>When the item is serialized out as xml, its value is "number".</para>
        ///</summary>
        [EnumString("number")]
        Number,
        ///<summary>
        ///percent.
        ///<para>When the item is serialized out as xml, its value is "percent".</para>
        ///</summary>
        [EnumString("percent")]
        Percent,
    }

    /// <summary>
    /// Defines the SXVCellType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public enum SXVCellType
    {
        ///<summary>
        ///b.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        Boolean,
        ///<summary>
        ///n.
        ///<para>When the item is serialized out as xml, its value is "n".</para>
        ///</summary>
        [EnumString("n")]
        Number,
        ///<summary>
        ///e.
        ///<para>When the item is serialized out as xml, its value is "e".</para>
        ///</summary>
        [EnumString("e")]
        Error,
        ///<summary>
        ///str.
        ///<para>When the item is serialized out as xml, its value is "str".</para>
        ///</summary>
        [EnumString("str")]
        String,
        ///<summary>
        ///d.
        ///<para>When the item is serialized out as xml, its value is "d".</para>
        ///</summary>
        [EnumString("d")]
        Date,
        ///<summary>
        ///bl.
        ///<para>When the item is serialized out as xml, its value is "bl".</para>
        ///</summary>
        [EnumString("bl")]
        Blank,
    }

    /// <summary>
    /// Defines the MovingPeriodStep enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public enum MovingPeriodStep
    {
        ///<summary>
        ///year.
        ///<para>When the item is serialized out as xml, its value is "year".</para>
        ///</summary>
        [EnumString("year")]
        Year,
        ///<summary>
        ///quarter.
        ///<para>When the item is serialized out as xml, its value is "quarter".</para>
        ///</summary>
        [EnumString("quarter")]
        Quarter,
        ///<summary>
        ///month.
        ///<para>When the item is serialized out as xml, its value is "month".</para>
        ///</summary>
        [EnumString("month")]
        Month,
        ///<summary>
        ///week.
        ///<para>When the item is serialized out as xml, its value is "week".</para>
        ///</summary>
        [EnumString("week")]
        Week,
        ///<summary>
        ///day.
        ///<para>When the item is serialized out as xml, its value is "day".</para>
        ///</summary>
        [EnumString("day")]
        Day,
    }

    /// <summary>
    /// Defines the QuestionType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public enum QuestionType
    {
        ///<summary>
        ///checkBox.
        ///<para>When the item is serialized out as xml, its value is "checkBox".</para>
        ///</summary>
        [EnumString("checkBox")]
        CheckBox,
        ///<summary>
        ///choice.
        ///<para>When the item is serialized out as xml, its value is "choice".</para>
        ///</summary>
        [EnumString("choice")]
        Choice,
        ///<summary>
        ///date.
        ///<para>When the item is serialized out as xml, its value is "date".</para>
        ///</summary>
        [EnumString("date")]
        Date,
        ///<summary>
        ///time.
        ///<para>When the item is serialized out as xml, its value is "time".</para>
        ///</summary>
        [EnumString("time")]
        Time,
        ///<summary>
        ///multipleLinesOfText.
        ///<para>When the item is serialized out as xml, its value is "multipleLinesOfText".</para>
        ///</summary>
        [EnumString("multipleLinesOfText")]
        MultipleLinesOfText,
        ///<summary>
        ///number.
        ///<para>When the item is serialized out as xml, its value is "number".</para>
        ///</summary>
        [EnumString("number")]
        Number,
        ///<summary>
        ///singleLineOfText.
        ///<para>When the item is serialized out as xml, its value is "singleLineOfText".</para>
        ///</summary>
        [EnumString("singleLineOfText")]
        SingleLineOfText,
    }

    /// <summary>
    /// Defines the QuestionFormat enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public enum QuestionFormat
    {
        ///<summary>
        ///generalDate.
        ///<para>When the item is serialized out as xml, its value is "generalDate".</para>
        ///</summary>
        [EnumString("generalDate")]
        GeneralDate,
        ///<summary>
        ///longDate.
        ///<para>When the item is serialized out as xml, its value is "longDate".</para>
        ///</summary>
        [EnumString("longDate")]
        LongDate,
        ///<summary>
        ///shortDate.
        ///<para>When the item is serialized out as xml, its value is "shortDate".</para>
        ///</summary>
        [EnumString("shortDate")]
        ShortDate,
        ///<summary>
        ///longTime.
        ///<para>When the item is serialized out as xml, its value is "longTime".</para>
        ///</summary>
        [EnumString("longTime")]
        LongTime,
        ///<summary>
        ///shortTime.
        ///<para>When the item is serialized out as xml, its value is "shortTime".</para>
        ///</summary>
        [EnumString("shortTime")]
        ShortTime,
        ///<summary>
        ///generalNumber.
        ///<para>When the item is serialized out as xml, its value is "generalNumber".</para>
        ///</summary>
        [EnumString("generalNumber")]
        GeneralNumber,
        ///<summary>
        ///standard.
        ///<para>When the item is serialized out as xml, its value is "standard".</para>
        ///</summary>
        [EnumString("standard")]
        Standard,
        ///<summary>
        ///fixed.
        ///<para>When the item is serialized out as xml, its value is "fixed".</para>
        ///</summary>
        [EnumString("fixed")]
        Fixed,
        ///<summary>
        ///percent.
        ///<para>When the item is serialized out as xml, its value is "percent".</para>
        ///</summary>
        [EnumString("percent")]
        Percent,
        ///<summary>
        ///currency.
        ///<para>When the item is serialized out as xml, its value is "currency".</para>
        ///</summary>
        [EnumString("currency")]
        Currency,
    }

    /// <summary>
    /// Defines the SurveyPosition enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public enum SurveyPosition
    {
        ///<summary>
        ///absolute.
        ///<para>When the item is serialized out as xml, its value is "absolute".</para>
        ///</summary>
        [EnumString("absolute")]
        Absolute,
        ///<summary>
        ///fixed.
        ///<para>When the item is serialized out as xml, its value is "fixed".</para>
        ///</summary>
        [EnumString("fixed")]
        Fixed,
        ///<summary>
        ///relative.
        ///<para>When the item is serialized out as xml, its value is "relative".</para>
        ///</summary>
        [EnumString("relative")]
        Relative,
        ///<summary>
        ///static.
        ///<para>When the item is serialized out as xml, its value is "static".</para>
        ///</summary>
        [EnumString("static")]
        Static,
        ///<summary>
        ///inherit.
        ///<para>When the item is serialized out as xml, its value is "inherit".</para>
        ///</summary>
        [EnumString("inherit")]
        Inherit,
    }
}