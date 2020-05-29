// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2016.Excel
{
    /// <summary>
    /// <para>Defines the RevExHeaders Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:revHdrs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RevExHeader &lt;xr:hdr></description></item>
    /// </list>
    /// </remark>
    public partial class RevExHeaders : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExHeaders class.
        /// </summary>
        public RevExHeaders() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExHeaders class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExHeaders(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExHeaders class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExHeaders(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExHeaders class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExHeaders(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>minRev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: minRev</para>
        /// </summary>
        public UInt64Value MinRev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxRev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: maxRev</para>
        /// </summary>
        public UInt64Value MaxRev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>docId, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: docId</para>
        /// </summary>
        public StringValue DocId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpointId, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: endpointId</para>
        /// </summary>
        public StringValue EndpointId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "revHdrs");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<RevExHeader>();
            builder.AddElement<RevExHeaders>()
.AddAttribute(0, "minRev", a => a.MinRev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "maxRev", a => a.MaxRev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "docId", a => a.DocId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "endpointId", a => a.EndpointId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExHeader), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExHeaders>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExStream Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:revStream.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RevExFuture &lt;xr:xrrftr></description></item>
    ///   <item><description>RevExUnsupported &lt;xr:xrrUspt></description></item>
    ///   <item><description>RevExTrimmed &lt;xr:xrrTrim></description></item>
    ///   <item><description>RevExRowColumn &lt;xr:xrrrc></description></item>
    ///   <item><description>RevExMove &lt;xr:xrrm></description></item>
    ///   <item><description>RevExChangeCell &lt;xr:xrrc></description></item>
    ///   <item><description>RevExFormatting &lt;xr:xrrf></description></item>
    ///   <item><description>RevExDefinedName &lt;xr:xrrDefName></description></item>
    ///   <item><description>RevExDelObj &lt;xr:xrrdo></description></item>
    ///   <item><description>RevExChgObj &lt;xr:xrrco></description></item>
    ///   <item><description>RevExSheetOp &lt;xr:xrrSheet></description></item>
    ///   <item><description>RevisionList &lt;xr:xrrList></description></item>
    ///   <item><description>RevListAutoExpandRw &lt;xr:xrrListExpR></description></item>
    ///   <item><description>RevGroup &lt;xr:xrrg></description></item>
    /// </list>
    /// </remark>
    public partial class RevExStream : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExStream class.
        /// </summary>
        public RevExStream() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExStream class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExStream(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExStream class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExStream(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExStream class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExStream(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "revStream");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<RevExFuture>();
            builder.AddChild<RevExUnsupported>();
            builder.AddChild<RevExTrimmed>();
            builder.AddChild<RevExRowColumn>();
            builder.AddChild<RevExMove>();
            builder.AddChild<RevExChangeCell>();
            builder.AddChild<RevExFormatting>();
            builder.AddChild<RevExDefinedName>();
            builder.AddChild<RevExDelObj>();
            builder.AddChild<RevExChgObj>();
            builder.AddChild<RevExSheetOp>();
            builder.AddChild<RevisionList>();
            builder.AddChild<RevListAutoExpandRw>();
            builder.AddChild<RevGroup>();
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExFuture), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExUnsupported), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExTrimmed), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExRowColumn), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExMove), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExChangeCell), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExFormatting), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExDefinedName), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExDelObj), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExChgObj), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExSheetOp), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevisionList), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevListAutoExpandRw), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevGroup), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExStream>(deep);
    }

    /// <summary>
    /// <para>Defines the DifferentialFormatType Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:dxf.</para>
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
    public partial class DifferentialFormatType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DifferentialFormatType class.
        /// </summary>
        public DifferentialFormatType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormatType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DifferentialFormatType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormatType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DifferentialFormatType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormatType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DifferentialFormatType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "dxf");
            builder.Availability = FileFormatVersions.Office2016;
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DifferentialFormatType>(deep);
    }

    /// <summary>
    /// <para>Defines the RevisionPtr Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:revisionPtr.</para>
    /// </summary>
    public partial class RevisionPtr : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevisionPtr class.
        /// </summary>
        public RevisionPtr() : base()
        {
        }

        /// <summary>
        /// <para>revIDLastSave, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: revIDLastSave</para>
        /// </summary>
        public UInt64Value RevIDLastSave
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>documentId, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: documentId</para>
        /// </summary>
        public StringValue DocumentId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "revisionPtr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevisionPtr>()
.AddAttribute(0, "revIDLastSave", a => a.RevIDLastSave, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "documentId", a => a.DocumentId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevisionPtr>(deep);
    }

    /// <summary>
    /// <para>Defines the StateBasedObject Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:objectState.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DataValidation &lt;xr:dataValidation></description></item>
    ///   <item><description>Hyperlink &lt;xr:hyperlink></description></item>
    ///   <item><description>SparklineGroup &lt;xr:sparklineGroup></description></item>
    ///   <item><description>Comments &lt;xr:comments></description></item>
    ///   <item><description>AutoFilter &lt;xr:autoFilter></description></item>
    ///   <item><description>pivotTableDefinition &lt;xr:pivotTableDefinition></description></item>
    /// </list>
    /// </remark>
    public partial class StateBasedObject : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StateBasedObject class.
        /// </summary>
        public StateBasedObject() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateBasedObject class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StateBasedObject(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateBasedObject class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StateBasedObject(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateBasedObject class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StateBasedObject(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "objectState");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DataValidation>();
            builder.AddChild<Hyperlink>();
            builder.AddChild<SparklineGroup>();
            builder.AddChild<Comments>();
            builder.AddChild<AutoFilter>();
            builder.AddChild<pivotTableDefinition>();
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.DataValidation), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Hyperlink), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.SparklineGroup), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Comments), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.AutoFilter), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.pivotTableDefinition), 1, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>Represents an external link to another workbook..</para>
        /// <para>Represents the following element tag in the schema: xr:dataValidation.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DataValidation DataValidation
        {
            get => GetElement<DataValidation>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Represents a hyperlink within a cell..</para>
        /// <para>Represents the following element tag in the schema: xr:hyperlink.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public Hyperlink Hyperlink
        {
            get => GetElement<Hyperlink>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Represents a sparkline group of 1 or more sparklines..</para>
        /// <para>Represents the following element tag in the schema: xr:sparklineGroup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public SparklineGroup SparklineGroup
        {
            get => GetElement<SparklineGroup>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Represents one comment within a cell..</para>
        /// <para>Represents the following element tag in the schema: xr:comments.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public Comments Comments
        {
            get => GetElement<Comments>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Represents an autofilter..</para>
        /// <para>Represents the following element tag in the schema: xr:autoFilter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public AutoFilter AutoFilter
        {
            get => GetElement<AutoFilter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Represents a PivotTable View..</para>
        /// <para>Represents the following element tag in the schema: xr:pivotTableDefinition.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public pivotTableDefinition pivotTableDefinition
        {
            get => GetElement<pivotTableDefinition>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StateBasedObject>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExHeader Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:hdr.</para>
    /// </summary>
    public partial class RevExHeader : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExHeader class.
        /// </summary>
        public RevExHeader() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2016</para>
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
        /// <para>minRev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: minRev</para>
        /// </summary>
        public UInt64Value MinRev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxRev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: maxRev</para>
        /// </summary>
        public UInt64Value MaxRev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: time</para>
        /// </summary>
        public DateTimeValue Time
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "hdr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevExHeader>()
.AddAttribute(19, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "minRev", a => a.MinRev)
.AddAttribute(0, "maxRev", a => a.MaxRev)
.AddAttribute(0, "time", a => a.Time, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExHeader>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExFuture Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrftr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RevExTest &lt;xr:xrrtest></description></item>
    /// </list>
    /// </remark>
    public partial class RevExFuture : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExFuture class.
        /// </summary>
        public RevExFuture() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExFuture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExFuture(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExFuture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExFuture(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExFuture class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExFuture(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sti, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sti</para>
        /// </summary>
        public BooleanValue Sti
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrftr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<RevExTest>();
            builder.AddElement<RevExFuture>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx)
.AddAttribute(0, "sti", a => a.Sti);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExTest), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExFuture>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExUnsupported Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrUspt.</para>
    /// </summary>
    public partial class RevExUnsupported : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExUnsupported class.
        /// </summary>
        public RevExUnsupported() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrUspt");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevExUnsupported>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExUnsupported>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExTrimmed Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrTrim.</para>
    /// </summary>
    public partial class RevExTrimmed : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExTrimmed class.
        /// </summary>
        public RevExTrimmed() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrTrim");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevExTrimmed>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExTrimmed>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExRowColumn Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrrc.</para>
    /// </summary>
    public partial class RevExRowColumn : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExRowColumn class.
        /// </summary>
        public RevExRowColumn() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>eol, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: eol</para>
        /// </summary>
        public BooleanValue Eol
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        public StringValue Ref
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>action, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: action</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RwColAction> Action
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RwColAction>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrrc");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevExRowColumn>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx)
.AddAttribute(0, "eol", a => a.Eol)
.AddAttribute(0, "ref", a => a.Ref, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "action", a => a.Action, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExRowColumn>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExMove Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrm.</para>
    /// </summary>
    public partial class RevExMove : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExMove class.
        /// </summary>
        public RevExMove() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>src, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: src</para>
        /// </summary>
        public StringValue Src
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dst, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: dst</para>
        /// </summary>
        public StringValue Dst
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>srcSh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: srcSh</para>
        /// </summary>
        public StringValue SrcSh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrm");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevExMove>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx)
.AddAttribute(0, "src", a => a.Src, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "dst", a => a.Dst, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "srcSh", a => a.SrcSh, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExMove>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExChangeCell Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrc.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RevCell &lt;xr:c></description></item>
    ///   <item><description>ChangeCellSubEdit &lt;xr:ccse></description></item>
    /// </list>
    /// </remark>
    public partial class RevExChangeCell : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExChangeCell class.
        /// </summary>
        public RevExChangeCell() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExChangeCell class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExChangeCell(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExChangeCell class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExChangeCell(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExChangeCell class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExChangeCell(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>listUid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: listUid</para>
        /// </summary>
        public StringValue ListUid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        public StringValue R
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType> T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>x, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt> X
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>w, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: w</para>
        /// </summary>
        public UInt32Value W
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrc");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<RevCell>();
            builder.AddChild<ChangeCellSubEdit>();
            builder.AddElement<RevExChangeCell>()
.AddAttribute(0, "listUid", a => a.ListUid, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx)
.AddAttribute(0, "r", a => a.R, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "t", a => a.T)
.AddAttribute(0, "x", a => a.X)
.AddAttribute(0, "w", a => a.W);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevCell), 1, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.ChangeCellSubEdit), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExChangeCell>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExFormatting Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrf.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DifferentialFormatType &lt;xr:dxf></description></item>
    ///   <item><description>ExtensionList &lt;xr:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class RevExFormatting : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExFormatting class.
        /// </summary>
        public RevExFormatting() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExFormatting class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExFormatting(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExFormatting class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExFormatting(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExFormatting class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExFormatting(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>numFmtId, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: numFmtId</para>
        /// </summary>
        public UInt32Value NumFmtId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>xfDxf, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: xfDxf</para>
        /// </summary>
        public BooleanValue XfDxf
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public BooleanValue Style
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sqref, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sqref</para>
        /// </summary>
        public ListValue<StringValue> Sqref
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>start, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: start</para>
        /// </summary>
        public UInt32Value Start
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>length, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: length</para>
        /// </summary>
        public UInt32Value Length
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>styleUid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: styleUid</para>
        /// </summary>
        public StringValue StyleUid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fBlankCell, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: fBlankCell</para>
        /// </summary>
        public BooleanValue FBlankCell
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>applyNumberFormat, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: applyNumberFormat</para>
        /// </summary>
        public BooleanValue ApplyNumberFormat
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>applyFont, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: applyFont</para>
        /// </summary>
        public BooleanValue ApplyFont
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>applyFill, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: applyFill</para>
        /// </summary>
        public BooleanValue ApplyFill
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>applyBorder, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: applyBorder</para>
        /// </summary>
        public BooleanValue ApplyBorder
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>applyAlignment, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: applyAlignment</para>
        /// </summary>
        public BooleanValue ApplyAlignment
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>applyProtection, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: applyProtection</para>
        /// </summary>
        public BooleanValue ApplyProtection
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrf");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DifferentialFormatType>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<RevExFormatting>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx)
.AddAttribute(0, "numFmtId", a => a.NumFmtId)
.AddAttribute(0, "xfDxf", a => a.XfDxf)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "sqref", a => a.Sqref, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "start", a => a.Start)
.AddAttribute(0, "length", a => a.Length)
.AddAttribute(0, "styleUid", a => a.StyleUid, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "fBlankCell", a => a.FBlankCell)
.AddAttribute(0, "applyNumberFormat", a => a.ApplyNumberFormat)
.AddAttribute(0, "applyFont", a => a.ApplyFont)
.AddAttribute(0, "applyFill", a => a.ApplyFill)
.AddAttribute(0, "applyBorder", a => a.ApplyBorder)
.AddAttribute(0, "applyAlignment", a => a.ApplyAlignment)
.AddAttribute(0, "applyProtection", a => a.ApplyProtection);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.DifferentialFormatType), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>DifferentialFormatType.</para>
        /// <para>Represents the following element tag in the schema: xr:dxf.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DifferentialFormatType DifferentialFormatType
        {
            get => GetElement<DifferentialFormatType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xr:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExFormatting>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExDefinedName Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrDefName.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FormulaFormula &lt;xr:formula></description></item>
    ///   <item><description>ExtensionList &lt;xr:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class RevExDefinedName : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExDefinedName class.
        /// </summary>
        public RevExDefinedName() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExDefinedName class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExDefinedName(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExDefinedName class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExDefinedName(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExDefinedName class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExDefinedName(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>customView, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: customView</para>
        /// </summary>
        public BooleanValue CustomView
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>function, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: function</para>
        /// </summary>
        public BooleanValue Function
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>functionGroupId, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: functionGroupId</para>
        /// </summary>
        public ByteValue FunctionGroupId
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>shortcutKey, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: shortcutKey</para>
        /// </summary>
        public ByteValue ShortcutKey
        {
            get => GetAttribute<ByteValue>();
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
        /// <para>customMenu, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: customMenu</para>
        /// </summary>
        public StringValue CustomMenu
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>help, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: help</para>
        /// </summary>
        public StringValue Help
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>statusBar, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: statusBar</para>
        /// </summary>
        public StringValue StatusBar
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>comment, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: comment</para>
        /// </summary>
        public StringValue Comment
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrDefName");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<FormulaFormula>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<RevExDefinedName>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx)
.AddAttribute(0, "customView", a => a.CustomView)
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "function", a => a.Function)
.AddAttribute(0, "functionGroupId", a => a.FunctionGroupId)
.AddAttribute(0, "shortcutKey", a => a.ShortcutKey)
.AddAttribute(0, "hidden", a => a.Hidden)
.AddAttribute(0, "customMenu", a => a.CustomMenu)
.AddAttribute(0, "description", a => a.Description)
.AddAttribute(0, "help", a => a.Help)
.AddAttribute(0, "statusBar", a => a.StatusBar)
.AddAttribute(0, "comment", a => a.Comment);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.FormulaFormula), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>FormulaFormula.</para>
        /// <para>Represents the following element tag in the schema: xr:formula.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public FormulaFormula FormulaFormula
        {
            get => GetElement<FormulaFormula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xr:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExDefinedName>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExDelObj Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrdo.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StateBasedHeader &lt;xr:hdr></description></item>
    /// </list>
    /// </remark>
    public partial class RevExDelObj : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExDelObj class.
        /// </summary>
        public RevExDelObj() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExDelObj class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExDelObj(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExDelObj class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExDelObj(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExDelObj class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExDelObj(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrdo");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<StateBasedHeader>();
            builder.AddElement<RevExDelObj>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader), 1, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>StateBasedHeader.</para>
        /// <para>Represents the following element tag in the schema: xr:hdr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public StateBasedHeader StateBasedHeader
        {
            get => GetElement<StateBasedHeader>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExDelObj>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExChgObj Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrco.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StateBasedHeader &lt;xr:hdr></description></item>
    ///   <item><description>RevisionStateLink &lt;xr:link></description></item>
    ///   <item><description>RevisionState &lt;xr:body></description></item>
    /// </list>
    /// </remark>
    public partial class RevExChgObj : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExChgObj class.
        /// </summary>
        public RevExChgObj() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExChgObj class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExChgObj(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExChgObj class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExChgObj(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExChgObj class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExChgObj(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrco");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<StateBasedHeader>();
            builder.AddChild<RevisionStateLink>();
            builder.AddChild<RevisionState>();
            builder.AddElement<RevExChgObj>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader), 1, 1, version: FileFormatVersions.Office2016),
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevisionStateLink), 0, 1, version: FileFormatVersions.Office2016),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevisionState), 0, 1, version: FileFormatVersions.Office2016)
                }
            };
        }

        /// <summary>
        /// <para>StateBasedHeader.</para>
        /// <para>Represents the following element tag in the schema: xr:hdr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public StateBasedHeader StateBasedHeader
        {
            get => GetElement<StateBasedHeader>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExChgObj>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExSheetOp Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrSheet.</para>
    /// </summary>
    public partial class RevExSheetOp : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExSheetOp class.
        /// </summary>
        public RevExSheetOp() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>op, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: op</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SheetOp> Op
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SheetOp>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idOrig, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: idOrig</para>
        /// </summary>
        public UInt32Value IdOrig
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idNew, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: idNew</para>
        /// </summary>
        public UInt32Value IdNew
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrSheet");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevExSheetOp>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx)
.AddAttribute(0, "op", a => a.Op, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "name", a => a.Name)
.AddAttribute(0, "idOrig", a => a.IdOrig)
.AddAttribute(0, "idNew", a => a.IdNew);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExSheetOp>(deep);
    }

    /// <summary>
    /// <para>Defines the RevisionList Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrList.</para>
    /// </summary>
    public partial class RevisionList : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevisionList class.
        /// </summary>
        public RevisionList() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: Data</para>
        /// </summary>
        public BooleanValue Data
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Formatting, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: Formatting</para>
        /// </summary>
        public BooleanValue Formatting
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>RangeBased, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: RangeBased</para>
        /// </summary>
        public BooleanValue RangeBased
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fake, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: Fake</para>
        /// </summary>
        public BooleanValue Fake
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        public StringValue Ref
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Headers, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: Headers</para>
        /// </summary>
        public BooleanValue Headers
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>InsDelHeaders, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: InsDelHeaders</para>
        /// </summary>
        public BooleanValue InsDelHeaders
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rId, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rId</para>
        /// </summary>
        public UInt32Value RId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrList");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevisionList>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx)
.AddAttribute(0, "Data", a => a.Data)
.AddAttribute(0, "Formatting", a => a.Formatting)
.AddAttribute(0, "RangeBased", a => a.RangeBased)
.AddAttribute(0, "Fake", a => a.Fake)
.AddAttribute(0, "ref", a => a.Ref, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "Headers", a => a.Headers)
.AddAttribute(0, "InsDelHeaders", a => a.InsDelHeaders)
.AddAttribute(0, "rId", a => a.RId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevisionList>(deep);
    }

    /// <summary>
    /// <para>Defines the RevListAutoExpandRw Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrListExpR.</para>
    /// </summary>
    public partial class RevListAutoExpandRw : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevListAutoExpandRw class.
        /// </summary>
        public RevListAutoExpandRw() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>refAdded, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: refAdded</para>
        /// </summary>
        public StringValue RefAdded
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>listGuid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: listGuid</para>
        /// </summary>
        public StringValue ListGuid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrListExpR");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevListAutoExpandRw>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx)
.AddAttribute(0, "refAdded", a => a.RefAdded, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "listGuid", a => a.ListGuid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevListAutoExpandRw>(deep);
    }

    /// <summary>
    /// <para>Defines the RevGroup Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrg.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RevExFuture &lt;xr:xrrftr></description></item>
    ///   <item><description>RevExUnsupported &lt;xr:xrrUspt></description></item>
    ///   <item><description>RevExTrimmed &lt;xr:xrrTrim></description></item>
    ///   <item><description>RevExRowColumn &lt;xr:xrrrc></description></item>
    ///   <item><description>RevExMove &lt;xr:xrrm></description></item>
    ///   <item><description>RevExChangeCell &lt;xr:xrrc></description></item>
    ///   <item><description>RevExFormatting &lt;xr:xrrf></description></item>
    ///   <item><description>RevExDefinedName &lt;xr:xrrDefName></description></item>
    ///   <item><description>RevExDelObj &lt;xr:xrrdo></description></item>
    ///   <item><description>RevExChgObj &lt;xr:xrrco></description></item>
    ///   <item><description>RevExSheetOp &lt;xr:xrrSheet></description></item>
    ///   <item><description>RevisionList &lt;xr:xrrList></description></item>
    ///   <item><description>RevListAutoExpandRw &lt;xr:xrrListExpR></description></item>
    /// </list>
    /// </remark>
    public partial class RevGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevGroup class.
        /// </summary>
        public RevGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt64Value Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        public StringValue Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        public StringValue Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrg");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<RevExFuture>();
            builder.AddChild<RevExUnsupported>();
            builder.AddChild<RevExTrimmed>();
            builder.AddChild<RevExRowColumn>();
            builder.AddChild<RevExMove>();
            builder.AddChild<RevExChangeCell>();
            builder.AddChild<RevExFormatting>();
            builder.AddChild<RevExDefinedName>();
            builder.AddChild<RevExDelObj>();
            builder.AddChild<RevExChgObj>();
            builder.AddChild<RevExSheetOp>();
            builder.AddChild<RevisionList>();
            builder.AddChild<RevListAutoExpandRw>();
            builder.AddElement<RevGroup>()
.AddAttribute(0, "rev", a => a.Rev, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "sh", a => a.Sh, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidp", a => a.Uidp, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "ctx", a => a.Ctx);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExFuture), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExUnsupported), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExTrimmed), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExRowColumn), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExMove), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExChangeCell), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExFormatting), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExDefinedName), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExDelObj), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExChgObj), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExSheetOp), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevisionList), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevListAutoExpandRw), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExTest Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrtest.</para>
    /// </summary>
    public partial class RevExTest : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExTest class.
        /// </summary>
        public RevExTest() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "xrrtest");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExTest>(deep);
    }

    /// <summary>
    /// <para>Defines the RevCell Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:c.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FFormula &lt;xr:f></description></item>
    ///   <item><description>Xstring &lt;xr:v></description></item>
    ///   <item><description>RstType &lt;xr:is></description></item>
    /// </list>
    /// </remark>
    public partial class RevCell : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevCell class.
        /// </summary>
        public RevCell() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevCell class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevCell(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevCell class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevCell(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevCell class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevCell(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>t, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues> T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>nop, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: nop</para>
        /// </summary>
        public BooleanValue Nop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tick, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: tick</para>
        /// </summary>
        public BooleanValue Tick
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rep, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: rep</para>
        /// </summary>
        public UInt32Value Rep
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "c");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<FFormula>();
            builder.AddChild<Xstring>();
            builder.AddChild<RstType>();
            builder.AddElement<RevCell>()
.AddAttribute(0, "t", a => a.T)
.AddAttribute(0, "nop", a => a.Nop)
.AddAttribute(0, "tick", a => a.Tick)
.AddAttribute(0, "rep", a => a.Rep);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.FFormula), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Xstring), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RstType), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>FFormula.</para>
        /// <para>Represents the following element tag in the schema: xr:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public FFormula FFormula
        {
            get => GetElement<FFormula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Xstring.</para>
        /// <para>Represents the following element tag in the schema: xr:v.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public Xstring Xstring
        {
            get => GetElement<Xstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RstType.</para>
        /// <para>Represents the following element tag in the schema: xr:is.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public RstType RstType
        {
            get => GetElement<RstType>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevCell>(deep);
    }

    /// <summary>
    /// <para>Defines the ChangeCellSubEdit Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:ccse.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RevCell &lt;xr:c></description></item>
    /// </list>
    /// </remark>
    public partial class ChangeCellSubEdit : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChangeCellSubEdit class.
        /// </summary>
        public ChangeCellSubEdit() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChangeCellSubEdit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChangeCellSubEdit(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChangeCellSubEdit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChangeCellSubEdit(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChangeCellSubEdit class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChangeCellSubEdit(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>r, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        public StringValue R
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType> T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>x, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt> X
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>w, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: w</para>
        /// </summary>
        public UInt32Value W
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "ccse");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<RevCell>();
            builder.AddElement<ChangeCellSubEdit>()
.AddAttribute(0, "r", a => a.R, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "t", a => a.T)
.AddAttribute(0, "x", a => a.X)
.AddAttribute(0, "w", a => a.W);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevCell), 1, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChangeCellSubEdit>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:extLst.</para>
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
            builder.SetSchema(83, "extLst");
            builder.Availability = FileFormatVersions.Office2016;
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
    /// <para>Defines the FormulaFormula Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:formula.</para>
    /// </summary>
    public partial class FormulaFormula : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FormulaFormula class.
        /// </summary>
        public FormulaFormula() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaFormula class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FormulaFormula(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "formula");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaFormula>(deep);
    }

    /// <summary>
    /// <para>Defines the FFormula Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:f.</para>
    /// </summary>
    public partial class FFormula : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FFormula class.
        /// </summary>
        public FFormula() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FFormula class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FFormula(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "f");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FFormula>(deep);
    }

    /// <summary>
    /// <para>Defines the StateBasedHeader Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:hdr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RefMap &lt;xr:refmap></description></item>
    /// </list>
    /// </remark>
    public partial class StateBasedHeader : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StateBasedHeader class.
        /// </summary>
        public StateBasedHeader() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateBasedHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StateBasedHeader(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateBasedHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StateBasedHeader(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateBasedHeader class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StateBasedHeader(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>eft, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: eft</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FeatureType> Eft
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FeatureType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>eftx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: eftx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtFeatureType> Eftx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtFeatureType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>seft, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: seft</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SubFeatureType> Seft
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SubFeatureType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>seftx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: seftx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtSubFeatureType> Seftx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtSubFeatureType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "hdr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<RefMap>();
            builder.AddElement<StateBasedHeader>()
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "eft", a => a.Eft, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "eftx", a => a.Eftx)
.AddAttribute(0, "seft", a => a.Seft)
.AddAttribute(0, "seftx", a => a.Seftx);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefMap), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>RefMap.</para>
        /// <para>Represents the following element tag in the schema: xr:refmap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public RefMap RefMap
        {
            get => GetElement<RefMap>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StateBasedHeader>(deep);
    }

    /// <summary>
    /// <para>Defines the RevisionStateLink Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:link.</para>
    /// </summary>
    public partial class RevisionStateLink : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevisionStateLink class.
        /// </summary>
        public RevisionStateLink() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2016</para>
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
            builder.SetSchema(83, "link");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevisionStateLink>()
.AddAttribute(19, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevisionStateLink>(deep);
    }

    /// <summary>
    /// <para>Defines the RevisionState Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:body.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RowColVisualOps &lt;xr:rowColVisualOps></description></item>
    ///   <item><description>HideUnhideSheet &lt;xr:hideUnhideSheet></description></item>
    ///   <item><description>ShowGridlinesHeadings &lt;xr:showGridlinesHeadings></description></item>
    ///   <item><description>FreezePanes &lt;xr:freezePanes></description></item>
    ///   <item><description>Outlines &lt;xr:outlines></description></item>
    /// </list>
    /// </remark>
    public partial class RevisionState : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevisionState class.
        /// </summary>
        public RevisionState() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevisionState class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevisionState(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevisionState class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevisionState(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevisionState class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevisionState(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "body");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<RowColVisualOps>();
            builder.AddChild<HideUnhideSheet>();
            builder.AddChild<ShowGridlinesHeadings>();
            builder.AddChild<FreezePanes>();
            builder.AddChild<Outlines>();
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOps), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.HideUnhideSheet), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.ShowGridlinesHeadings), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.FreezePanes), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Outlines), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>RowColVisualOps.</para>
        /// <para>Represents the following element tag in the schema: xr:rowColVisualOps.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public RowColVisualOps RowColVisualOps
        {
            get => GetElement<RowColVisualOps>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HideUnhideSheet.</para>
        /// <para>Represents the following element tag in the schema: xr:hideUnhideSheet.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public HideUnhideSheet HideUnhideSheet
        {
            get => GetElement<HideUnhideSheet>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShowGridlinesHeadings.</para>
        /// <para>Represents the following element tag in the schema: xr:showGridlinesHeadings.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public ShowGridlinesHeadings ShowGridlinesHeadings
        {
            get => GetElement<ShowGridlinesHeadings>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FreezePanes.</para>
        /// <para>Represents the following element tag in the schema: xr:freezePanes.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public FreezePanes FreezePanes
        {
            get => GetElement<FreezePanes>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Outlines.</para>
        /// <para>Represents the following element tag in the schema: xr:outlines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public Outlines Outlines
        {
            get => GetElement<Outlines>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevisionState>(deep);
    }

    /// <summary>
    /// <para>Defines the RefMap Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:refmap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RefCell &lt;xr:ref></description></item>
    ///   <item><description>SheetXluid &lt;xr:sheetUid></description></item>
    ///   <item><description>RefOartAnchor &lt;xr:oartAnchor></description></item>
    ///   <item><description>RefFuture &lt;xr:future></description></item>
    ///   <item><description>RefTest &lt;xr:test></description></item>
    /// </list>
    /// </remark>
    public partial class RefMap : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RefMap class.
        /// </summary>
        public RefMap() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RefMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RefMap(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RefMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RefMap(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RefMap class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RefMap(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "refmap");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<RefCell>();
            builder.AddChild<SheetXluid>();
            builder.AddChild<RefOartAnchor>();
            builder.AddChild<RefFuture>();
            builder.AddChild<RefTest>();
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefCell), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.SheetXluid), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefOartAnchor), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefFuture), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefTest), 1, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefMap>(deep);
    }

    /// <summary>
    /// <para>Defines the RowColVisualOps Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:rowColVisualOps.</para>
    /// </summary>
    public partial class RowColVisualOps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RowColVisualOps class.
        /// </summary>
        public RowColVisualOps() : base()
        {
        }

        /// <summary>
        /// <para>action, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: action</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOp> Action
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOp>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isRow, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: isRow</para>
        /// </summary>
        public BooleanValue IsRow
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>size, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        public UInt32Value Size
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>userSized, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: userSized</para>
        /// </summary>
        public BooleanValue UserSized
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "rowColVisualOps");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RowColVisualOps>()
.AddAttribute(0, "action", a => a.Action, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "isRow", a => a.IsRow, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "size", a => a.Size)
.AddAttribute(0, "userSized", a => a.UserSized);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowColVisualOps>(deep);
    }

    /// <summary>
    /// <para>Defines the HideUnhideSheet Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:hideUnhideSheet.</para>
    /// </summary>
    public partial class HideUnhideSheet : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the HideUnhideSheet class.
        /// </summary>
        public HideUnhideSheet() : base()
        {
        }

        /// <summary>
        /// <para>hide, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: hide</para>
        /// </summary>
        public BooleanValue Hide
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "hideUnhideSheet");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<HideUnhideSheet>()
.AddAttribute(0, "hide", a => a.Hide, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideUnhideSheet>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowGridlinesHeadings Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:showGridlinesHeadings.</para>
    /// </summary>
    public partial class ShowGridlinesHeadings : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShowGridlinesHeadings class.
        /// </summary>
        public ShowGridlinesHeadings() : base()
        {
        }

        /// <summary>
        /// <para>showGridLines, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: showGridLines</para>
        /// </summary>
        public BooleanValue ShowGridLines
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showRowCol, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: showRowCol</para>
        /// </summary>
        public BooleanValue ShowRowCol
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "showGridlinesHeadings");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ShowGridlinesHeadings>()
.AddAttribute(0, "showGridLines", a => a.ShowGridLines, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "showRowCol", a => a.ShowRowCol, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowGridlinesHeadings>(deep);
    }

    /// <summary>
    /// <para>Defines the FreezePanes Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:freezePanes.</para>
    /// </summary>
    public partial class FreezePanes : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FreezePanes class.
        /// </summary>
        public FreezePanes() : base()
        {
        }

        /// <summary>
        /// <para>sheetViewUid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: sheetViewUid</para>
        /// </summary>
        public StringValue SheetViewUid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "freezePanes");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<FreezePanes>()
.AddAttribute(0, "sheetViewUid", a => a.SheetViewUid, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FreezePanes>(deep);
    }

    /// <summary>
    /// <para>Defines the Outlines Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:outlines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Outline &lt;xr:outline></description></item>
    /// </list>
    /// </remark>
    public partial class Outlines : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Outlines class.
        /// </summary>
        public Outlines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Outlines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Outlines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Outlines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Outlines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Outlines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Outlines(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>isRow, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: isRow</para>
        /// </summary>
        public BooleanValue IsRow
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "outlines");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<Outline>();
            builder.AddElement<Outlines>()
.AddAttribute(0, "isRow", a => a.IsRow, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Outline), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Outlines>(deep);
    }

    /// <summary>
    /// <para>Defines the Outline Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:outline.</para>
    /// </summary>
    public partial class Outline : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Outline class.
        /// </summary>
        public Outline() : base()
        {
        }

        /// <summary>
        /// <para>isCollapsed, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: isCollapsed</para>
        /// </summary>
        public BooleanValue IsCollapsed
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>level, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: level</para>
        /// </summary>
        public ByteValue Level
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "outline");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<Outline>()
.AddAttribute(0, "isCollapsed", a => a.IsCollapsed, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "level", a => a.Level, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Outline>(deep);
    }

    /// <summary>
    /// <para>Defines the Xstring Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:v.</para>
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
            builder.SetSchema(83, "v");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Xstring>(deep);
    }

    /// <summary>
    /// <para>Defines the RstType Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:is.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Text &lt;x:t></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Run &lt;x:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PhoneticRun &lt;x:rPh></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties &lt;x:phoneticPr></description></item>
    /// </list>
    /// </remark>
    public partial class RstType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RstType class.
        /// </summary>
        public RstType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RstType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RstType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RstType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RstType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RstType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RstType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "is");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Text>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Run>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PhoneticRun>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Text), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Run), 0, 32767),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticRun), 0, 32767),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Text.</para>
        /// <para>Represents the following element tag in the schema: x:t.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Text Text
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Text>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RstType>(deep);
    }

    /// <summary>
    /// <para>Defines the RefCell Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:ref.</para>
    /// </summary>
    public partial class RefCell : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RefCell class.
        /// </summary>
        public RefCell() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        public StringValue N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajt, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ajt</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajtx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ajtx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>homeRef, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: homeRef</para>
        /// </summary>
        public BooleanValue HomeRef
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        public ListValue<StringValue> R
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidLast, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uidLast</para>
        /// </summary>
        public StringValue UidLast
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "ref");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RefCell>()
.AddAttribute(0, "n", a => a.N, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "ajt", a => a.Ajt, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "ajtx", a => a.Ajtx)
.AddAttribute(0, "homeRef", a => a.HomeRef)
.AddAttribute(0, "r", a => a.R, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "uidLast", a => a.UidLast, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefCell>(deep);
    }

    /// <summary>
    /// <para>Defines the SheetXluid Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:sheetUid.</para>
    /// </summary>
    public partial class SheetXluid : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SheetXluid class.
        /// </summary>
        public SheetXluid() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        public StringValue N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajt, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ajt</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajtx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ajtx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>homeRef, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: homeRef</para>
        /// </summary>
        public BooleanValue HomeRef
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        public StringValue Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "sheetUid");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<SheetXluid>()
.AddAttribute(0, "n", a => a.N, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "ajt", a => a.Ajt, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "ajtx", a => a.Ajtx)
.AddAttribute(0, "homeRef", a => a.HomeRef)
.AddAttribute(0, "uid", a => a.Uid, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SheetXluid>(deep);
    }

    /// <summary>
    /// <para>Defines the RefOartAnchor Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:oartAnchor.</para>
    /// </summary>
    public partial class RefOartAnchor : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RefOartAnchor class.
        /// </summary>
        public RefOartAnchor() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        public StringValue N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajt, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ajt</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajtx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ajtx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>homeRef, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: homeRef</para>
        /// </summary>
        public BooleanValue HomeRef
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        public StringValue R
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fromRowOff, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: fromRowOff</para>
        /// </summary>
        public Int64Value FromRowOff
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fromColOff, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: fromColOff</para>
        /// </summary>
        public Int64Value FromColOff
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>toRowOff, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: toRowOff</para>
        /// </summary>
        public Int64Value ToRowOff
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>toColOff, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: toColOff</para>
        /// </summary>
        public Int64Value ToColOff
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: cx</para>
        /// </summary>
        public Int64Value Cx
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cy, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: cy</para>
        /// </summary>
        public Int64Value Cy
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>x, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        public Int64Value X
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>
        public Int64Value Y
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>oat, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: oat</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.OartAnchorType> Oat
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.OartAnchorType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "oartAnchor");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RefOartAnchor>()
.AddAttribute(0, "n", a => a.N, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "ajt", a => a.Ajt, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "ajtx", a => a.Ajtx)
.AddAttribute(0, "homeRef", a => a.HomeRef)
.AddAttribute(0, "r", a => a.R)
.AddAttribute(0, "fromRowOff", a => a.FromRowOff, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "fromColOff", a => a.FromColOff, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "toRowOff", a => a.ToRowOff, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "toColOff", a => a.ToColOff, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "cx", a => a.Cx, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(0, "cy", a => a.Cy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(0, "x", a => a.X, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "y", a => a.Y, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "oat", a => a.Oat, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefOartAnchor>(deep);
    }

    /// <summary>
    /// <para>Defines the RefFuture Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:future.</para>
    /// </summary>
    public partial class RefFuture : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RefFuture class.
        /// </summary>
        public RefFuture() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "future");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefFuture>(deep);
    }

    /// <summary>
    /// <para>Defines the RefTest Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:test.</para>
    /// </summary>
    public partial class RefTest : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RefTest class.
        /// </summary>
        public RefTest() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        public StringValue N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajt, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ajt</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajtx, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: ajtx</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>homeRef, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: homeRef</para>
        /// </summary>
        public BooleanValue HomeRef
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "test");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RefTest>()
.AddAttribute(0, "n", a => a.N, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "ajt", a => a.Ajt, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "ajtx", a => a.Ajtx)
.AddAttribute(0, "homeRef", a => a.HomeRef);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefTest>(deep);
    }

    /// <summary>
    /// <para>Represents an external link to another workbook..</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:dataValidation.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.ExcelAc.List &lt;x12ac:list></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Formula1 &lt;x:formula1></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Formula2 &lt;x:formula2></description></item>
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
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>errorStyle</para>
        /// <para>Represents the following attribute in the schema: errorStyle</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues> ErrorStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imeMode</para>
        /// <para>Represents the following attribute in the schema: imeMode</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues> ImeMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>operator</para>
        /// <para>Represents the following attribute in the schema: operator</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues> Operator
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowBlank</para>
        /// <para>Represents the following attribute in the schema: allowBlank</para>
        /// </summary>
        public BooleanValue AllowBlank
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showDropDown</para>
        /// <para>Represents the following attribute in the schema: showDropDown</para>
        /// </summary>
        public BooleanValue ShowDropDown
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showInputMessage</para>
        /// <para>Represents the following attribute in the schema: showInputMessage</para>
        /// </summary>
        public BooleanValue ShowInputMessage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showErrorMessage</para>
        /// <para>Represents the following attribute in the schema: showErrorMessage</para>
        /// </summary>
        public BooleanValue ShowErrorMessage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>errorTitle</para>
        /// <para>Represents the following attribute in the schema: errorTitle</para>
        /// </summary>
        public StringValue ErrorTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>error</para>
        /// <para>Represents the following attribute in the schema: error</para>
        /// </summary>
        public StringValue Error
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>promptTitle</para>
        /// <para>Represents the following attribute in the schema: promptTitle</para>
        /// </summary>
        public StringValue PromptTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>prompt</para>
        /// <para>Represents the following attribute in the schema: prompt</para>
        /// </summary>
        public StringValue Prompt
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sqref</para>
        /// <para>Represents the following attribute in the schema: sqref</para>
        /// </summary>
        public ListValue<StringValue> SequenceOfReferences
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "dataValidation");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.ExcelAc.List>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Formula1>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Formula2>();
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
.AddAttribute(0, "prompt", a => a.Prompt)
.AddAttribute(0, "sqref", a => a.SequenceOfReferences, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.ExcelAc.List), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Formula1), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Formula2), 0, 1)
            };
        }

        /// <summary>
        /// <para>List.</para>
        /// <para>Represents the following element tag in the schema: x12ac:list.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x12ac = http://schemas.microsoft.com/office/spreadsheetml/2011/1/ac
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.ExcelAc.List List
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.ExcelAc.List>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Formula1.</para>
        /// <para>Represents the following element tag in the schema: x:formula1.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Formula1 Formula1
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Formula1>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Formula2.</para>
        /// <para>Represents the following element tag in the schema: x:formula2.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Formula2 Formula2
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Formula2>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataValidation>(deep);
    }

    /// <summary>
    /// <para>Represents a hyperlink within a cell..</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:hyperlink.</para>
    /// </summary>
    public partial class Hyperlink : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Hyperlink class.
        /// </summary>
        public Hyperlink() : base()
        {
        }

        /// <summary>
        /// <para>Reference</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        public StringValue Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relationship Id</para>
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
        /// <para>Location</para>
        /// <para>Represents the following attribute in the schema: location</para>
        /// </summary>
        public StringValue Location
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Tool Tip</para>
        /// <para>Represents the following attribute in the schema: tooltip</para>
        /// </summary>
        public StringValue Tooltip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Display String</para>
        /// <para>Represents the following attribute in the schema: display</para>
        /// </summary>
        public StringValue Display
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "hyperlink");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<Hyperlink>()
.AddAttribute(0, "ref", a => a.Reference, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(19, "id", a => a.Id)
.AddAttribute(0, "location", a => a.Location)
.AddAttribute(0, "tooltip", a => a.Tooltip)
.AddAttribute(0, "display", a => a.Display);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Hyperlink>(deep);
    }

    /// <summary>
    /// <para>Represents a sparkline group of 1 or more sparklines..</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:sparklineGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.SeriesColor &lt;x14:colorSeries></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.NegativeColor &lt;x14:colorNegative></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.AxisColor &lt;x14:colorAxis></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.MarkersColor &lt;x14:colorMarkers></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor &lt;x14:colorFirst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor &lt;x14:colorLast></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor &lt;x14:colorHigh></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor &lt;x14:colorLow></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Excel.Sparklines &lt;x14:sparklines></description></item>
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
            builder.SetSchema(83, "sparklineGroup");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.SeriesColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.NegativeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.AxisColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.MarkersColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.Formula>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.Sparklines>();
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
        }

        /// <summary>
        /// <para>SeriesColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorSeries.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.SeriesColor SeriesColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.SeriesColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NegativeColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.NegativeColor NegativeColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.NegativeColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>AxisColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorAxis.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.AxisColor AxisColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.AxisColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MarkersColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorMarkers.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.MarkersColor MarkersColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.MarkersColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FirstMarkerColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorFirst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor FirstMarkerColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LastMarkerColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorLast.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor LastMarkerColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HighMarkerColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorHigh.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor HighMarkerColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LowMarkerColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorLow.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor LowMarkerColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor>();
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
        public DocumentFormat.OpenXml.Office2010.Excel.Sparklines Sparklines
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Sparklines>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SparklineGroup>(deep);
    }

    /// <summary>
    /// <para>Represents one comment within a cell..</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:comments.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Authors &lt;x:authors></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.CommentList &lt;x:commentList></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.ExtensionList &lt;x:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Comments : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Comments class.
        /// </summary>
        public Comments() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comments class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Comments(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comments class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Comments(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comments class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Comments(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "comments");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Authors>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.CommentList>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Authors), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.CommentList), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Authors.</para>
        /// <para>Represents the following element tag in the schema: x:authors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Authors Authors
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Authors>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List of Comments.</para>
        /// <para>Represents the following element tag in the schema: x:commentList.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.CommentList CommentList
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.CommentList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Comments>(deep);
    }

    /// <summary>
    /// <para>Represents an autofilter..</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:autoFilter.</para>
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
            builder.SetSchema(83, "autoFilter");
            builder.Availability = FileFormatVersions.Office2016;
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
    /// <para>Represents a PivotTable View..</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:pivotTableDefinition.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Location &lt;x:location></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PivotFields &lt;x:pivotFields></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.RowFields &lt;x:rowFields></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.RowItems &lt;x:rowItems></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.ColumnFields &lt;x:colFields></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.ColumnItems &lt;x:colItems></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PageFields &lt;x:pageFields></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.DataFields &lt;x:dataFields></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Formats &lt;x:formats></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats &lt;x:conditionalFormats></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.ChartFormats &lt;x:chartFormats></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies &lt;x:pivotHierarchies></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle &lt;x:pivotTableStyleInfo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PivotFilters &lt;x:filters></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage &lt;x:rowHierarchiesUsage></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage &lt;x:colHierarchiesUsage></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList &lt;x:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class pivotTableDefinition : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the pivotTableDefinition class.
        /// </summary>
        public pivotTableDefinition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the pivotTableDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public pivotTableDefinition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the pivotTableDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public pivotTableDefinition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the pivotTableDefinition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public pivotTableDefinition(string outerXml) : base(outerXml)
        {
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
        /// <para>cacheId</para>
        /// <para>Represents the following attribute in the schema: cacheId</para>
        /// </summary>
        public UInt32Value CacheId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dataOnRows</para>
        /// <para>Represents the following attribute in the schema: dataOnRows</para>
        /// </summary>
        public BooleanValue DataOnRows
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dataPosition</para>
        /// <para>Represents the following attribute in the schema: dataPosition</para>
        /// </summary>
        public UInt32Value DataPosition
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Auto Format Id</para>
        /// <para>Represents the following attribute in the schema: autoFormatId</para>
        /// </summary>
        public UInt32Value AutoFormatId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Apply Number Formats</para>
        /// <para>Represents the following attribute in the schema: applyNumberFormats</para>
        /// </summary>
        public BooleanValue ApplyNumberFormats
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Apply Border Formats</para>
        /// <para>Represents the following attribute in the schema: applyBorderFormats</para>
        /// </summary>
        public BooleanValue ApplyBorderFormats
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Apply Font Formats</para>
        /// <para>Represents the following attribute in the schema: applyFontFormats</para>
        /// </summary>
        public BooleanValue ApplyFontFormats
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Apply Pattern Formats</para>
        /// <para>Represents the following attribute in the schema: applyPatternFormats</para>
        /// </summary>
        public BooleanValue ApplyPatternFormats
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Apply Alignment Formats</para>
        /// <para>Represents the following attribute in the schema: applyAlignmentFormats</para>
        /// </summary>
        public BooleanValue ApplyAlignmentFormats
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Apply Width / Height Formats</para>
        /// <para>Represents the following attribute in the schema: applyWidthHeightFormats</para>
        /// </summary>
        public BooleanValue ApplyWidthHeightFormats
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dataCaption</para>
        /// <para>Represents the following attribute in the schema: dataCaption</para>
        /// </summary>
        public StringValue DataCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grandTotalCaption</para>
        /// <para>Represents the following attribute in the schema: grandTotalCaption</para>
        /// </summary>
        public StringValue GrandTotalCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>errorCaption</para>
        /// <para>Represents the following attribute in the schema: errorCaption</para>
        /// </summary>
        public StringValue ErrorCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showError</para>
        /// <para>Represents the following attribute in the schema: showError</para>
        /// </summary>
        public BooleanValue ShowError
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>missingCaption</para>
        /// <para>Represents the following attribute in the schema: missingCaption</para>
        /// </summary>
        public StringValue MissingCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showMissing</para>
        /// <para>Represents the following attribute in the schema: showMissing</para>
        /// </summary>
        public BooleanValue ShowMissing
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pageStyle</para>
        /// <para>Represents the following attribute in the schema: pageStyle</para>
        /// </summary>
        public StringValue PageStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pivotTableStyle</para>
        /// <para>Represents the following attribute in the schema: pivotTableStyle</para>
        /// </summary>
        public StringValue PivotTableStyleName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>vacatedStyle</para>
        /// <para>Represents the following attribute in the schema: vacatedStyle</para>
        /// </summary>
        public StringValue VacatedStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        public StringValue Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>updatedVersion</para>
        /// <para>Represents the following attribute in the schema: updatedVersion</para>
        /// </summary>
        public ByteValue UpdatedVersion
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>minRefreshableVersion</para>
        /// <para>Represents the following attribute in the schema: minRefreshableVersion</para>
        /// </summary>
        public ByteValue MinRefreshableVersion
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>asteriskTotals</para>
        /// <para>Represents the following attribute in the schema: asteriskTotals</para>
        /// </summary>
        public BooleanValue AsteriskTotals
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItems</para>
        /// <para>Represents the following attribute in the schema: showItems</para>
        /// </summary>
        public BooleanValue ShowItems
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>editData</para>
        /// <para>Represents the following attribute in the schema: editData</para>
        /// </summary>
        public BooleanValue EditData
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>disableFieldList</para>
        /// <para>Represents the following attribute in the schema: disableFieldList</para>
        /// </summary>
        public BooleanValue DisableFieldList
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showCalcMbrs</para>
        /// <para>Represents the following attribute in the schema: showCalcMbrs</para>
        /// </summary>
        public BooleanValue ShowCalculatedMembers
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visualTotals</para>
        /// <para>Represents the following attribute in the schema: visualTotals</para>
        /// </summary>
        public BooleanValue VisualTotals
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showMultipleLabel</para>
        /// <para>Represents the following attribute in the schema: showMultipleLabel</para>
        /// </summary>
        public BooleanValue ShowMultipleLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showDataDropDown</para>
        /// <para>Represents the following attribute in the schema: showDataDropDown</para>
        /// </summary>
        public BooleanValue ShowDataDropDown
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showDrill</para>
        /// <para>Represents the following attribute in the schema: showDrill</para>
        /// </summary>
        public BooleanValue ShowDrill
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>printDrill</para>
        /// <para>Represents the following attribute in the schema: printDrill</para>
        /// </summary>
        public BooleanValue PrintDrill
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showMemberPropertyTips</para>
        /// <para>Represents the following attribute in the schema: showMemberPropertyTips</para>
        /// </summary>
        public BooleanValue ShowMemberPropertyTips
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showDataTips</para>
        /// <para>Represents the following attribute in the schema: showDataTips</para>
        /// </summary>
        public BooleanValue ShowDataTips
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enableWizard</para>
        /// <para>Represents the following attribute in the schema: enableWizard</para>
        /// </summary>
        public BooleanValue EnableWizard
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enableDrill</para>
        /// <para>Represents the following attribute in the schema: enableDrill</para>
        /// </summary>
        public BooleanValue EnableDrill
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enableFieldProperties</para>
        /// <para>Represents the following attribute in the schema: enableFieldProperties</para>
        /// </summary>
        public BooleanValue EnableFieldProperties
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>preserveFormatting</para>
        /// <para>Represents the following attribute in the schema: preserveFormatting</para>
        /// </summary>
        public BooleanValue PreserveFormatting
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>useAutoFormatting</para>
        /// <para>Represents the following attribute in the schema: useAutoFormatting</para>
        /// </summary>
        public BooleanValue UseAutoFormatting
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pageWrap</para>
        /// <para>Represents the following attribute in the schema: pageWrap</para>
        /// </summary>
        public UInt32Value PageWrap
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pageOverThenDown</para>
        /// <para>Represents the following attribute in the schema: pageOverThenDown</para>
        /// </summary>
        public BooleanValue PageOverThenDown
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>subtotalHiddenItems</para>
        /// <para>Represents the following attribute in the schema: subtotalHiddenItems</para>
        /// </summary>
        public BooleanValue SubtotalHiddenItems
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rowGrandTotals</para>
        /// <para>Represents the following attribute in the schema: rowGrandTotals</para>
        /// </summary>
        public BooleanValue RowGrandTotals
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>colGrandTotals</para>
        /// <para>Represents the following attribute in the schema: colGrandTotals</para>
        /// </summary>
        public BooleanValue ColumnGrandTotals
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fieldPrintTitles</para>
        /// <para>Represents the following attribute in the schema: fieldPrintTitles</para>
        /// </summary>
        public BooleanValue FieldPrintTitles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemPrintTitles</para>
        /// <para>Represents the following attribute in the schema: itemPrintTitles</para>
        /// </summary>
        public BooleanValue ItemPrintTitles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mergeItem</para>
        /// <para>Represents the following attribute in the schema: mergeItem</para>
        /// </summary>
        public BooleanValue MergeItem
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showDropZones</para>
        /// <para>Represents the following attribute in the schema: showDropZones</para>
        /// </summary>
        public BooleanValue ShowDropZones
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>createdVersion</para>
        /// <para>Represents the following attribute in the schema: createdVersion</para>
        /// </summary>
        public ByteValue CreatedVersion
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>indent</para>
        /// <para>Represents the following attribute in the schema: indent</para>
        /// </summary>
        public UInt32Value Indent
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showEmptyRow</para>
        /// <para>Represents the following attribute in the schema: showEmptyRow</para>
        /// </summary>
        public BooleanValue ShowEmptyRow
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showEmptyCol</para>
        /// <para>Represents the following attribute in the schema: showEmptyCol</para>
        /// </summary>
        public BooleanValue ShowEmptyColumn
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showHeaders</para>
        /// <para>Represents the following attribute in the schema: showHeaders</para>
        /// </summary>
        public BooleanValue ShowHeaders
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>compact</para>
        /// <para>Represents the following attribute in the schema: compact</para>
        /// </summary>
        public BooleanValue Compact
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>outline</para>
        /// <para>Represents the following attribute in the schema: outline</para>
        /// </summary>
        public BooleanValue Outline
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>outlineData</para>
        /// <para>Represents the following attribute in the schema: outlineData</para>
        /// </summary>
        public BooleanValue OutlineData
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>compactData</para>
        /// <para>Represents the following attribute in the schema: compactData</para>
        /// </summary>
        public BooleanValue CompactData
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>published</para>
        /// <para>Represents the following attribute in the schema: published</para>
        /// </summary>
        public BooleanValue Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>gridDropZones</para>
        /// <para>Represents the following attribute in the schema: gridDropZones</para>
        /// </summary>
        public BooleanValue GridDropZones
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>immersive</para>
        /// <para>Represents the following attribute in the schema: immersive</para>
        /// </summary>
        public BooleanValue StopImmersiveUi
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>multipleFieldFilters</para>
        /// <para>Represents the following attribute in the schema: multipleFieldFilters</para>
        /// </summary>
        public BooleanValue MultipleFieldFilters
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>chartFormat</para>
        /// <para>Represents the following attribute in the schema: chartFormat</para>
        /// </summary>
        public UInt32Value ChartFormat
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rowHeaderCaption</para>
        /// <para>Represents the following attribute in the schema: rowHeaderCaption</para>
        /// </summary>
        public StringValue RowHeaderCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>colHeaderCaption</para>
        /// <para>Represents the following attribute in the schema: colHeaderCaption</para>
        /// </summary>
        public StringValue ColumnHeaderCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fieldListSortAscending</para>
        /// <para>Represents the following attribute in the schema: fieldListSortAscending</para>
        /// </summary>
        public BooleanValue FieldListSortAscending
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mdxSubqueries</para>
        /// <para>Represents the following attribute in the schema: mdxSubqueries</para>
        /// </summary>
        public BooleanValue MdxSubqueries
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>customListSort</para>
        /// <para>Represents the following attribute in the schema: customListSort</para>
        /// </summary>
        public BooleanValue CustomListSort
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(83, "pivotTableDefinition");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Location>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotFields>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.RowFields>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.RowItems>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ColumnFields>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ColumnItems>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PageFields>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.DataFields>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Formats>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ChartFormats>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotFilters>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList>();
            builder.AddElement<pivotTableDefinition>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "cacheId", a => a.CacheId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "dataOnRows", a => a.DataOnRows)
.AddAttribute(0, "dataPosition", a => a.DataPosition)
.AddAttribute(0, "autoFormatId", a => a.AutoFormatId)
.AddAttribute(0, "applyNumberFormats", a => a.ApplyNumberFormats)
.AddAttribute(0, "applyBorderFormats", a => a.ApplyBorderFormats)
.AddAttribute(0, "applyFontFormats", a => a.ApplyFontFormats)
.AddAttribute(0, "applyPatternFormats", a => a.ApplyPatternFormats)
.AddAttribute(0, "applyAlignmentFormats", a => a.ApplyAlignmentFormats)
.AddAttribute(0, "applyWidthHeightFormats", a => a.ApplyWidthHeightFormats)
.AddAttribute(0, "dataCaption", a => a.DataCaption, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "grandTotalCaption", a => a.GrandTotalCaption)
.AddAttribute(0, "errorCaption", a => a.ErrorCaption)
.AddAttribute(0, "showError", a => a.ShowError)
.AddAttribute(0, "missingCaption", a => a.MissingCaption)
.AddAttribute(0, "showMissing", a => a.ShowMissing)
.AddAttribute(0, "pageStyle", a => a.PageStyle)
.AddAttribute(0, "pivotTableStyle", a => a.PivotTableStyleName)
.AddAttribute(0, "vacatedStyle", a => a.VacatedStyle)
.AddAttribute(0, "tag", a => a.Tag)
.AddAttribute(0, "updatedVersion", a => a.UpdatedVersion)
.AddAttribute(0, "minRefreshableVersion", a => a.MinRefreshableVersion)
.AddAttribute(0, "asteriskTotals", a => a.AsteriskTotals)
.AddAttribute(0, "showItems", a => a.ShowItems)
.AddAttribute(0, "editData", a => a.EditData)
.AddAttribute(0, "disableFieldList", a => a.DisableFieldList)
.AddAttribute(0, "showCalcMbrs", a => a.ShowCalculatedMembers)
.AddAttribute(0, "visualTotals", a => a.VisualTotals)
.AddAttribute(0, "showMultipleLabel", a => a.ShowMultipleLabel)
.AddAttribute(0, "showDataDropDown", a => a.ShowDataDropDown)
.AddAttribute(0, "showDrill", a => a.ShowDrill)
.AddAttribute(0, "printDrill", a => a.PrintDrill)
.AddAttribute(0, "showMemberPropertyTips", a => a.ShowMemberPropertyTips)
.AddAttribute(0, "showDataTips", a => a.ShowDataTips)
.AddAttribute(0, "enableWizard", a => a.EnableWizard)
.AddAttribute(0, "enableDrill", a => a.EnableDrill)
.AddAttribute(0, "enableFieldProperties", a => a.EnableFieldProperties)
.AddAttribute(0, "preserveFormatting", a => a.PreserveFormatting)
.AddAttribute(0, "useAutoFormatting", a => a.UseAutoFormatting)
.AddAttribute(0, "pageWrap", a => a.PageWrap)
.AddAttribute(0, "pageOverThenDown", a => a.PageOverThenDown)
.AddAttribute(0, "subtotalHiddenItems", a => a.SubtotalHiddenItems)
.AddAttribute(0, "rowGrandTotals", a => a.RowGrandTotals)
.AddAttribute(0, "colGrandTotals", a => a.ColumnGrandTotals)
.AddAttribute(0, "fieldPrintTitles", a => a.FieldPrintTitles)
.AddAttribute(0, "itemPrintTitles", a => a.ItemPrintTitles)
.AddAttribute(0, "mergeItem", a => a.MergeItem)
.AddAttribute(0, "showDropZones", a => a.ShowDropZones)
.AddAttribute(0, "createdVersion", a => a.CreatedVersion)
.AddAttribute(0, "indent", a => a.Indent)
.AddAttribute(0, "showEmptyRow", a => a.ShowEmptyRow)
.AddAttribute(0, "showEmptyCol", a => a.ShowEmptyColumn)
.AddAttribute(0, "showHeaders", a => a.ShowHeaders)
.AddAttribute(0, "compact", a => a.Compact)
.AddAttribute(0, "outline", a => a.Outline)
.AddAttribute(0, "outlineData", a => a.OutlineData)
.AddAttribute(0, "compactData", a => a.CompactData)
.AddAttribute(0, "published", a => a.Published)
.AddAttribute(0, "gridDropZones", a => a.GridDropZones)
.AddAttribute(0, "immersive", a => a.StopImmersiveUi)
.AddAttribute(0, "multipleFieldFilters", a => a.MultipleFieldFilters)
.AddAttribute(0, "chartFormat", a => a.ChartFormat)
.AddAttribute(0, "rowHeaderCaption", a => a.RowHeaderCaption)
.AddAttribute(0, "colHeaderCaption", a => a.ColumnHeaderCaption)
.AddAttribute(0, "fieldListSortAscending", a => a.FieldListSortAscending)
.AddAttribute(0, "mdxSubqueries", a => a.MdxSubqueries)
.AddAttribute(0, "customListSort", a => a.CustomListSort);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Location), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotFields), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.RowFields), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.RowItems), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnFields), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnItems), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PageFields), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DataFields), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Formats), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ChartFormats), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotFilters), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Location.</para>
        /// <para>Represents the following element tag in the schema: x:location.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Location Location
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Location>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotFields.</para>
        /// <para>Represents the following element tag in the schema: x:pivotFields.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PivotFields PivotFields
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotFields>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RowFields.</para>
        /// <para>Represents the following element tag in the schema: x:rowFields.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.RowFields RowFields
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.RowFields>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RowItems.</para>
        /// <para>Represents the following element tag in the schema: x:rowItems.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.RowItems RowItems
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.RowItems>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColumnFields.</para>
        /// <para>Represents the following element tag in the schema: x:colFields.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ColumnFields ColumnFields
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ColumnFields>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColumnItems.</para>
        /// <para>Represents the following element tag in the schema: x:colItems.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ColumnItems ColumnItems
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ColumnItems>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PageFields.</para>
        /// <para>Represents the following element tag in the schema: x:pageFields.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PageFields PageFields
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PageFields>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataFields.</para>
        /// <para>Represents the following element tag in the schema: x:dataFields.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.DataFields DataFields
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.DataFields>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Formats.</para>
        /// <para>Represents the following element tag in the schema: x:formats.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Formats Formats
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Formats>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ConditionalFormats.</para>
        /// <para>Represents the following element tag in the schema: x:conditionalFormats.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats ConditionalFormats
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartFormats.</para>
        /// <para>Represents the following element tag in the schema: x:chartFormats.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ChartFormats ChartFormats
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ChartFormats>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotHierarchies.</para>
        /// <para>Represents the following element tag in the schema: x:pivotHierarchies.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies PivotHierarchies
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotTableStyle.</para>
        /// <para>Represents the following element tag in the schema: x:pivotTableStyleInfo.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle PivotTableStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotFilters.</para>
        /// <para>Represents the following element tag in the schema: x:filters.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PivotFilters PivotFilters
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotFilters>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RowHierarchiesUsage.</para>
        /// <para>Represents the following element tag in the schema: x:rowHierarchiesUsage.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage RowHierarchiesUsage
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColumnHierarchiesUsage.</para>
        /// <para>Represents the following element tag in the schema: x:colHierarchiesUsage.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage ColumnHierarchiesUsage
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotTableDefinitionExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList PivotTableDefinitionExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<pivotTableDefinition>(deep);
    }

    /// <summary>
    /// Defines the RevisionContext enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum RevisionContext
    {
        ///<summary>
        ///normal.
        ///<para>When the item is serialized out as xml, its value is "normal".</para>
        ///</summary>
        [EnumString("normal")]
        Normal,
        ///<summary>
        ///undo.
        ///<para>When the item is serialized out as xml, its value is "undo".</para>
        ///</summary>
        [EnumString("undo")]
        Undo,
        ///<summary>
        ///redo.
        ///<para>When the item is serialized out as xml, its value is "redo".</para>
        ///</summary>
        [EnumString("redo")]
        Redo,
        ///<summary>
        ///copy.
        ///<para>When the item is serialized out as xml, its value is "copy".</para>
        ///</summary>
        [EnumString("copy")]
        Copy,
    }

    /// <summary>
    /// Defines the RwColAction enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum RwColAction
    {
        ///<summary>
        ///insr.
        ///<para>When the item is serialized out as xml, its value is "insr".</para>
        ///</summary>
        [EnumString("insr")]
        Insr,
        ///<summary>
        ///delr.
        ///<para>When the item is serialized out as xml, its value is "delr".</para>
        ///</summary>
        [EnumString("delr")]
        Delr,
        ///<summary>
        ///insc.
        ///<para>When the item is serialized out as xml, its value is "insc".</para>
        ///</summary>
        [EnumString("insc")]
        Insc,
        ///<summary>
        ///delc.
        ///<para>When the item is serialized out as xml, its value is "delc".</para>
        ///</summary>
        [EnumString("delc")]
        Delc,
    }

    /// <summary>
    /// Defines the FeatureType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum FeatureType
    {
        ///<summary>
        ///dataValidation.
        ///<para>When the item is serialized out as xml, its value is "dataValidation".</para>
        ///</summary>
        [EnumString("dataValidation")]
        DataValidation,
        ///<summary>
        ///hyperlink.
        ///<para>When the item is serialized out as xml, its value is "hyperlink".</para>
        ///</summary>
        [EnumString("hyperlink")]
        Hyperlink,
        ///<summary>
        ///rowColVisualOps.
        ///<para>When the item is serialized out as xml, its value is "rowColVisualOps".</para>
        ///</summary>
        [EnumString("rowColVisualOps")]
        RowColVisualOps,
        ///<summary>
        ///freezePanes.
        ///<para>When the item is serialized out as xml, its value is "freezePanes".</para>
        ///</summary>
        [EnumString("freezePanes")]
        FreezePanes,
        ///<summary>
        ///sparklines.
        ///<para>When the item is serialized out as xml, its value is "sparklines".</para>
        ///</summary>
        [EnumString("sparklines")]
        Sparklines,
        ///<summary>
        ///hideUnhideSheet.
        ///<para>When the item is serialized out as xml, its value is "hideUnhideSheet".</para>
        ///</summary>
        [EnumString("hideUnhideSheet")]
        HideUnhideSheet,
        ///<summary>
        ///showGridlinesHeadings.
        ///<para>When the item is serialized out as xml, its value is "showGridlinesHeadings".</para>
        ///</summary>
        [EnumString("showGridlinesHeadings")]
        ShowGridlinesHeadings,
        ///<summary>
        ///comment.
        ///<para>When the item is serialized out as xml, its value is "comment".</para>
        ///</summary>
        [EnumString("comment")]
        Comment,
        ///<summary>
        ///outlines.
        ///<para>When the item is serialized out as xml, its value is "outlines".</para>
        ///</summary>
        [EnumString("outlines")]
        Outlines,
        ///<summary>
        ///drawingElement.
        ///<para>When the item is serialized out as xml, its value is "drawingElement".</para>
        ///</summary>
        [EnumString("drawingElement")]
        DrawingElement,
        ///<summary>
        ///autoFilter.
        ///<para>When the item is serialized out as xml, its value is "autoFilter".</para>
        ///</summary>
        [EnumString("autoFilter")]
        AutoFilter,
        ///<summary>
        ///pivotTable.
        ///<para>When the item is serialized out as xml, its value is "pivotTable".</para>
        ///</summary>
        [EnumString("pivotTable")]
        PivotTable,
        ///<summary>
        ///future.
        ///<para>When the item is serialized out as xml, its value is "future".</para>
        ///</summary>
        [EnumString("future")]
        Future,
    }

    /// <summary>
    /// Defines the ExtFeatureType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum ExtFeatureType
    {
        ///<summary>
        ///reserved.
        ///<para>When the item is serialized out as xml, its value is "reserved".</para>
        ///</summary>
        [EnumString("reserved")]
        Reserved,
    }

    /// <summary>
    /// Defines the SubFeatureType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum SubFeatureType
    {
        ///<summary>
        ///none.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///future.
        ///<para>When the item is serialized out as xml, its value is "future".</para>
        ///</summary>
        [EnumString("future")]
        Future,
    }

    /// <summary>
    /// Defines the ExtSubFeatureType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum ExtSubFeatureType
    {
        ///<summary>
        ///reserved.
        ///<para>When the item is serialized out as xml, its value is "reserved".</para>
        ///</summary>
        [EnumString("reserved")]
        Reserved,
    }

    /// <summary>
    /// Defines the RowColVisualOp enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum RowColVisualOp
    {
        ///<summary>
        ///hide.
        ///<para>When the item is serialized out as xml, its value is "hide".</para>
        ///</summary>
        [EnumString("hide")]
        Hide,
        ///<summary>
        ///unhide.
        ///<para>When the item is serialized out as xml, its value is "unhide".</para>
        ///</summary>
        [EnumString("unhide")]
        Unhide,
        ///<summary>
        ///resize.
        ///<para>When the item is serialized out as xml, its value is "resize".</para>
        ///</summary>
        [EnumString("resize")]
        Resize,
        ///<summary>
        ///autosize.
        ///<para>When the item is serialized out as xml, its value is "autosize".</para>
        ///</summary>
        [EnumString("autosize")]
        Autosize,
    }

    /// <summary>
    /// Defines the SheetOp enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum SheetOp
    {
        ///<summary>
        ///insert.
        ///<para>When the item is serialized out as xml, its value is "insert".</para>
        ///</summary>
        [EnumString("insert")]
        Insert,
        ///<summary>
        ///delete.
        ///<para>When the item is serialized out as xml, its value is "delete".</para>
        ///</summary>
        [EnumString("delete")]
        Delete,
        ///<summary>
        ///reorder.
        ///<para>When the item is serialized out as xml, its value is "reorder".</para>
        ///</summary>
        [EnumString("reorder")]
        Reorder,
        ///<summary>
        ///rename.
        ///<para>When the item is serialized out as xml, its value is "rename".</para>
        ///</summary>
        [EnumString("rename")]
        Rename,
    }

    /// <summary>
    /// Defines the FillType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum FillType
    {
        ///<summary>
        ///fill.
        ///<para>When the item is serialized out as xml, its value is "fill".</para>
        ///</summary>
        [EnumString("fill")]
        Fill,
        ///<summary>
        ///array.
        ///<para>When the item is serialized out as xml, its value is "array".</para>
        ///</summary>
        [EnumString("array")]
        Array,
        ///<summary>
        ///future.
        ///<para>When the item is serialized out as xml, its value is "future".</para>
        ///</summary>
        [EnumString("future")]
        Future,
    }

    /// <summary>
    /// Defines the FillTypeExt enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum FillTypeExt
    {
        ///<summary>
        ///test.
        ///<para>When the item is serialized out as xml, its value is "test".</para>
        ///</summary>
        [EnumString("test")]
        Test,
    }

    /// <summary>
    /// Defines the AdjustType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum AdjustType
    {
        ///<summary>
        ///fmla.
        ///<para>When the item is serialized out as xml, its value is "fmla".</para>
        ///</summary>
        [EnumString("fmla")]
        Fmla,
        ///<summary>
        ///format.
        ///<para>When the item is serialized out as xml, its value is "format".</para>
        ///</summary>
        [EnumString("format")]
        Format,
        ///<summary>
        ///condFmt.
        ///<para>When the item is serialized out as xml, its value is "condFmt".</para>
        ///</summary>
        [EnumString("condFmt")]
        CondFmt,
        ///<summary>
        ///sparkline.
        ///<para>When the item is serialized out as xml, its value is "sparkline".</para>
        ///</summary>
        [EnumString("sparkline")]
        Sparkline,
        ///<summary>
        ///anchor.
        ///<para>When the item is serialized out as xml, its value is "anchor".</para>
        ///</summary>
        [EnumString("anchor")]
        Anchor,
        ///<summary>
        ///fmlaNoSticky.
        ///<para>When the item is serialized out as xml, its value is "fmlaNoSticky".</para>
        ///</summary>
        [EnumString("fmlaNoSticky")]
        FmlaNoSticky,
        ///<summary>
        ///noAdj.
        ///<para>When the item is serialized out as xml, its value is "noAdj".</para>
        ///</summary>
        [EnumString("noAdj")]
        NoAdj,
        ///<summary>
        ///fragile.
        ///<para>When the item is serialized out as xml, its value is "fragile".</para>
        ///</summary>
        [EnumString("fragile")]
        Fragile,
        ///<summary>
        ///future.
        ///<para>When the item is serialized out as xml, its value is "future".</para>
        ///</summary>
        [EnumString("future")]
        Future,
    }

    /// <summary>
    /// Defines the AdjustTypeExt enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum AdjustTypeExt
    {
        ///<summary>
        ///test.
        ///<para>When the item is serialized out as xml, its value is "test".</para>
        ///</summary>
        [EnumString("test")]
        Test,
    }

    /// <summary>
    /// Defines the OartAnchorType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public enum OartAnchorType
    {
        ///<summary>
        ///twoCell.
        ///<para>When the item is serialized out as xml, its value is "twoCell".</para>
        ///</summary>
        [EnumString("twoCell")]
        TwoCell,
        ///<summary>
        ///oneCell.
        ///<para>When the item is serialized out as xml, its value is "oneCell".</para>
        ///</summary>
        [EnumString("oneCell")]
        OneCell,
        ///<summary>
        ///absolute.
        ///<para>When the item is serialized out as xml, its value is "absolute".</para>
        ///</summary>
        [EnumString("absolute")]
        Absolute,
    }
}