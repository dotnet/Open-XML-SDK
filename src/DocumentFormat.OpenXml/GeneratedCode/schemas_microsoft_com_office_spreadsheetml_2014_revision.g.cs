// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2016.Excel
{
/// <summary>
/// <para>Defines the RevExHeaders Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:revHdrs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RevExHeader &lt;xr:hdr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RevExHeader), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "revHdrs")]
public partial class RevExHeaders : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> minRev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: minRev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "minRev")]
    [Index(0)]
    public UInt64Value MinRev { get; set; }
    /// <summary>
    /// <para> maxRev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: maxRev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "maxRev")]
    [Index(1)]
    public UInt64Value MaxRev { get; set; }
    /// <summary>
    /// <para> docId, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: docId </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "docId")]
    [Index(2)]
    public StringValue DocId { get; set; }
    /// <summary>
    /// <para> endpointId, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: endpointId </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "endpointId")]
    [Index(3)]
    public StringValue EndpointId { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExHeaders class.
    /// </summary>
    public RevExHeaders():base(){}
        /// <summary>
    ///Initializes a new instance of the RevExHeaders class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RevExHeaders(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RevExHeaders(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExHeader), 0, 0, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExHeaders>(deep);

}
/// <summary>
/// <para>Defines the RevExStream Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:revStream.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RevExFuture &lt;xr:xrrftr></description></item>
///<item><description>RevExUnsupported &lt;xr:xrrUspt></description></item>
///<item><description>RevExTrimmed &lt;xr:xrrTrim></description></item>
///<item><description>RevExRowColumn &lt;xr:xrrrc></description></item>
///<item><description>RevExMove &lt;xr:xrrm></description></item>
///<item><description>RevExChangeCell &lt;xr:xrrc></description></item>
///<item><description>RevExFormatting &lt;xr:xrrf></description></item>
///<item><description>RevExDefinedName &lt;xr:xrrDefName></description></item>
///<item><description>RevExDelObj &lt;xr:xrrdo></description></item>
///<item><description>RevExChgObj &lt;xr:xrrco></description></item>
///<item><description>RevExSheetOp &lt;xr:xrrSheet></description></item>
///<item><description>RevisionList &lt;xr:xrrList></description></item>
///<item><description>RevListAutoExpandRw &lt;xr:xrrListExpR></description></item>
///<item><description>RevGroup &lt;xr:xrrg></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RevExFuture), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExUnsupported), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExTrimmed), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExRowColumn), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExMove), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExChangeCell), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExFormatting), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExDefinedName), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExDelObj), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExChgObj), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExSheetOp), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevisionList), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevListAutoExpandRw), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevGroup), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "revStream")]
public partial class RevExStream : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the RevExStream class.
    /// </summary>
    public RevExStream():base(){}
        /// <summary>
    ///Initializes a new instance of the RevExStream class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RevExStream(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RevExStream(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Choice, 1, 0)
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
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExStream>(deep);

}
/// <summary>
/// <para>Defines the DifferentialFormatType Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:dxf.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Font &lt;x:font></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.NumberingFormat &lt;x:numFmt></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Fill &lt;x:fill></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Alignment &lt;x:alignment></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Border &lt;x:border></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Protection &lt;x:protection></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ExtensionList &lt;x:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Font))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.NumberingFormat))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Fill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Alignment))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Border))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Protection))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "dxf")]
public partial class DifferentialFormatType : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the DifferentialFormatType class.
    /// </summary>
    public DifferentialFormatType():base(){}
        /// <summary>
    ///Initializes a new instance of the DifferentialFormatType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DifferentialFormatType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public DifferentialFormatType(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Font), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.NumberingFormat), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Fill), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Alignment), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Border), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Protection), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Font Properties.</para>
    /// <para> Represents the following element tag in the schema: x:font </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Spreadsheet.Font Font
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Font>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> Number Format.</para>
    /// <para> Represents the following element tag in the schema: x:numFmt </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Spreadsheet.NumberingFormat NumberingFormat
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.NumberingFormat>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> Fill.</para>
    /// <para> Represents the following element tag in the schema: x:fill </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Spreadsheet.Fill Fill
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Fill>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> Alignment.</para>
    /// <para> Represents the following element tag in the schema: x:alignment </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Spreadsheet.Alignment Alignment
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Alignment>(3);
        set => SetElement(3, value);
	}
    /// <summary>
    /// <para> Border Properties.</para>
    /// <para> Represents the following element tag in the schema: x:border </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Spreadsheet.Border Border
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Border>(4);
        set => SetElement(4, value);
	}
    /// <summary>
    /// <para> Protection Properties.</para>
    /// <para> Represents the following element tag in the schema: x:protection </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(5)]
    public DocumentFormat.OpenXml.Spreadsheet.Protection Protection
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Protection>(5);
        set => SetElement(5, value);
	}
    /// <summary>
    /// <para> Future Feature Data Storage Area.</para>
    /// <para> Represents the following element tag in the schema: x:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(6)]
    public DocumentFormat.OpenXml.Spreadsheet.ExtensionList ExtensionList
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>(6);
        set => SetElement(6, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DifferentialFormatType>(deep);

}
/// <summary>
/// <para>Defines the RevisionPtr Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:revisionPtr.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "revisionPtr")]
public partial class RevisionPtr : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> revIDLastSave, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: revIDLastSave </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "revIDLastSave")]
    [Index(0)]
    public UInt64Value RevIDLastSave { get; set; }
    /// <summary>
    /// <para> documentId, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: documentId </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "documentId")]
    [Index(1)]
    public StringValue DocumentId { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevisionPtr class.
    /// </summary>
    public RevisionPtr():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevisionPtr>(deep);

}
/// <summary>
/// <para>Defines the StateBasedObject Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:objectState.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DataValidation &lt;xr:dataValidation></description></item>
///<item><description>Hyperlink &lt;xr:hyperlink></description></item>
///<item><description>SparklineGroup &lt;xr:sparklineGroup></description></item>
///<item><description>Comments &lt;xr:comments></description></item>
///<item><description>AutoFilter &lt;xr:autoFilter></description></item>
///<item><description>pivotTableDefinition &lt;xr:pivotTableDefinition></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DataValidation), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Hyperlink), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(SparklineGroup), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Comments), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(AutoFilter), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(pivotTableDefinition), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "objectState")]
public partial class StateBasedObject : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the StateBasedObject class.
    /// </summary>
    public StateBasedObject():base(){}
        /// <summary>
    ///Initializes a new instance of the StateBasedObject class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StateBasedObject(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public StateBasedObject(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.DataValidation), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Hyperlink), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.SparklineGroup), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Comments), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.AutoFilter), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.pivotTableDefinition), 1, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
        /// <summary>
    /// <para> Represents an external link to another workbook..</para>
    /// <para> Represents the following element tag in the schema: xr:dataValidation </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(0)]
    public DataValidation DataValidation
	{
        get => GetElement<DataValidation>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> Represents a hyperlink within a cell..</para>
    /// <para> Represents the following element tag in the schema: xr:hyperlink </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(1)]
    public Hyperlink Hyperlink
	{
        get => GetElement<Hyperlink>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> Represents a sparkline group of 1 or more sparklines..</para>
    /// <para> Represents the following element tag in the schema: xr:sparklineGroup </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(2)]
    public SparklineGroup SparklineGroup
	{
        get => GetElement<SparklineGroup>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> Represents one comment within a cell..</para>
    /// <para> Represents the following element tag in the schema: xr:comments </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(3)]
    public Comments Comments
	{
        get => GetElement<Comments>(3);
        set => SetElement(3, value);
	}
    /// <summary>
    /// <para> Represents an autofilter..</para>
    /// <para> Represents the following element tag in the schema: xr:autoFilter </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(4)]
    public AutoFilter AutoFilter
	{
        get => GetElement<AutoFilter>(4);
        set => SetElement(4, value);
	}
    /// <summary>
    /// <para> Represents a PivotTable View..</para>
    /// <para> Represents the following element tag in the schema: xr:pivotTableDefinition </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(5)]
    public pivotTableDefinition pivotTableDefinition
	{
        get => GetElement<pivotTableDefinition>(5);
        set => SetElement(5, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StateBasedObject>(deep);

}
/// <summary>
/// <para>Defines the RevExHeader Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:hdr.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "hdr")]
public partial class RevExHeader : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> id, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
[RequiredValidator]
    [SchemaAttr(19, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> minRev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: minRev </para>
    /// </summary>
    [SchemaAttr(0, "minRev")]
    [Index(1)]
    public UInt64Value MinRev { get; set; }
    /// <summary>
    /// <para> maxRev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: maxRev </para>
    /// </summary>
    [SchemaAttr(0, "maxRev")]
    [Index(2)]
    public UInt64Value MaxRev { get; set; }
    /// <summary>
    /// <para> time, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: time </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "time")]
    [Index(3)]
    public DateTimeValue Time { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExHeader class.
    /// </summary>
    public RevExHeader():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExHeader>(deep);

}
/// <summary>
/// <para>Defines the RevExFuture Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrftr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RevExTest &lt;xr:xrrtest></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RevExTest), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrftr")]
public partial class RevExFuture : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }
    /// <summary>
    /// <para> sti, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sti </para>
    /// </summary>
    [SchemaAttr(0, "sti")]
    [Index(5)]
    public BooleanValue Sti { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExFuture class.
    /// </summary>
    public RevExFuture():base(){}
        /// <summary>
    ///Initializes a new instance of the RevExFuture class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RevExFuture(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RevExFuture(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Choice, 0, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExTest), 0, 0, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExFuture>(deep);

}
/// <summary>
/// <para>Defines the RevExUnsupported Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrUspt.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrUspt")]
public partial class RevExUnsupported : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExUnsupported class.
    /// </summary>
    public RevExUnsupported():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExUnsupported>(deep);

}
/// <summary>
/// <para>Defines the RevExTrimmed Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrTrim.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrTrim")]
public partial class RevExTrimmed : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExTrimmed class.
    /// </summary>
    public RevExTrimmed():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExTrimmed>(deep);

}
/// <summary>
/// <para>Defines the RevExRowColumn Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrrc.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrrc")]
public partial class RevExRowColumn : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }
    /// <summary>
    /// <para> eol, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: eol </para>
    /// </summary>
    [SchemaAttr(0, "eol")]
    [Index(5)]
    public BooleanValue Eol { get; set; }
    /// <summary>
    /// <para> ref, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "ref")]
    [Index(6)]
    public StringValue Ref { get; set; }
    /// <summary>
    /// <para> action, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: action </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "action")]
    [Index(7)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RwColAction> Action { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExRowColumn class.
    /// </summary>
    public RevExRowColumn():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExRowColumn>(deep);

}
/// <summary>
/// <para>Defines the RevExMove Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrm.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrm")]
public partial class RevExMove : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }
    /// <summary>
    /// <para> src, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "src")]
    [Index(5)]
    public StringValue Src { get; set; }
    /// <summary>
    /// <para> dst, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: dst </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "dst")]
    [Index(6)]
    public StringValue Dst { get; set; }
    /// <summary>
    /// <para> srcSh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: srcSh </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "srcSh")]
    [Index(7)]
    public StringValue SrcSh { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExMove class.
    /// </summary>
    public RevExMove():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExMove>(deep);

}
/// <summary>
/// <para>Defines the RevExChangeCell Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrc.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RevCell &lt;xr:c></description></item>
///<item><description>ChangeCellSubEdit &lt;xr:ccse></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RevCell), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ChangeCellSubEdit), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrc")]
public partial class RevExChangeCell : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> listUid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: listUid </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "listUid")]
    [Index(0)]
    public StringValue ListUid { get; set; }
    /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(1)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(2)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(3)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(4)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(5)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }
    /// <summary>
    /// <para> r, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "r")]
    [Index(6)]
    public StringValue R { get; set; }
    /// <summary>
    /// <para> t, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    [Index(7)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType> T { get; set; }
    /// <summary>
    /// <para> x, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
    [SchemaAttr(0, "x")]
    [Index(8)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt> X { get; set; }
    /// <summary>
    /// <para> w, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: w </para>
    /// </summary>
    [SchemaAttr(0, "w")]
    [Index(9)]
    public UInt32Value W { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExChangeCell class.
    /// </summary>
    public RevExChangeCell():base(){}
        /// <summary>
    ///Initializes a new instance of the RevExChangeCell class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RevExChangeCell(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RevExChangeCell(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevCell), 1, 0, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.ChangeCellSubEdit), 0, 0, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExChangeCell>(deep);

}
/// <summary>
/// <para>Defines the RevExFormatting Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrf.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DifferentialFormatType &lt;xr:dxf></description></item>
///<item><description>ExtensionList &lt;xr:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DifferentialFormatType), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrf")]
public partial class RevExFormatting : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }
    /// <summary>
    /// <para> numFmtId, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: numFmtId </para>
    /// </summary>
    [SchemaAttr(0, "numFmtId")]
    [Index(5)]
    public UInt32Value NumFmtId { get; set; }
    /// <summary>
    /// <para> xfDxf, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: xfDxf </para>
    /// </summary>
    [SchemaAttr(0, "xfDxf")]
    [Index(6)]
    public BooleanValue XfDxf { get; set; }
    /// <summary>
    /// <para> style, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [Index(7)]
    public BooleanValue Style { get; set; }
    /// <summary>
    /// <para> sqref, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sqref </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "sqref")]
    [Index(8)]
    public ListValue<StringValue> Sqref { get; set; }
    /// <summary>
    /// <para> start, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: start </para>
    /// </summary>
    [SchemaAttr(0, "start")]
    [Index(9)]
    public UInt32Value Start { get; set; }
    /// <summary>
    /// <para> length, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: length </para>
    /// </summary>
    [SchemaAttr(0, "length")]
    [Index(10)]
    public UInt32Value Length { get; set; }
    /// <summary>
    /// <para> styleUid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: styleUid </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "styleUid")]
    [Index(11)]
    public StringValue StyleUid { get; set; }
    /// <summary>
    /// <para> fBlankCell, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: fBlankCell </para>
    /// </summary>
    [SchemaAttr(0, "fBlankCell")]
    [Index(12)]
    public BooleanValue FBlankCell { get; set; }
    /// <summary>
    /// <para> applyNumberFormat, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: applyNumberFormat </para>
    /// </summary>
    [SchemaAttr(0, "applyNumberFormat")]
    [Index(13)]
    public BooleanValue ApplyNumberFormat { get; set; }
    /// <summary>
    /// <para> applyFont, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: applyFont </para>
    /// </summary>
    [SchemaAttr(0, "applyFont")]
    [Index(14)]
    public BooleanValue ApplyFont { get; set; }
    /// <summary>
    /// <para> applyFill, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: applyFill </para>
    /// </summary>
    [SchemaAttr(0, "applyFill")]
    [Index(15)]
    public BooleanValue ApplyFill { get; set; }
    /// <summary>
    /// <para> applyBorder, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: applyBorder </para>
    /// </summary>
    [SchemaAttr(0, "applyBorder")]
    [Index(16)]
    public BooleanValue ApplyBorder { get; set; }
    /// <summary>
    /// <para> applyAlignment, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: applyAlignment </para>
    /// </summary>
    [SchemaAttr(0, "applyAlignment")]
    [Index(17)]
    public BooleanValue ApplyAlignment { get; set; }
    /// <summary>
    /// <para> applyProtection, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: applyProtection </para>
    /// </summary>
    [SchemaAttr(0, "applyProtection")]
    [Index(18)]
    public BooleanValue ApplyProtection { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExFormatting class.
    /// </summary>
    public RevExFormatting():base(){}
        /// <summary>
    ///Initializes a new instance of the RevExFormatting class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RevExFormatting(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RevExFormatting(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.DifferentialFormatType), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> DifferentialFormatType.</para>
    /// <para> Represents the following element tag in the schema: xr:dxf </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(0)]
    public DifferentialFormatType DifferentialFormatType
	{
        get => GetElement<DifferentialFormatType>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: xr:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(1)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExFormatting>(deep);

}
/// <summary>
/// <para>Defines the RevExDefinedName Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrDefName.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FormulaFormula &lt;xr:formula></description></item>
///<item><description>ExtensionList &lt;xr:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(FormulaFormula), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrDefName")]
public partial class RevExDefinedName : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }
    /// <summary>
    /// <para> customView, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: customView </para>
    /// </summary>
    [SchemaAttr(0, "customView")]
    [Index(5)]
    public BooleanValue CustomView { get; set; }
    /// <summary>
    /// <para> name, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "name")]
    [Index(6)]
    public StringValue Name { get; set; }
    /// <summary>
    /// <para> function, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: function </para>
    /// </summary>
    [SchemaAttr(0, "function")]
    [Index(7)]
    public BooleanValue Function { get; set; }
    /// <summary>
    /// <para> functionGroupId, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: functionGroupId </para>
    /// </summary>
    [SchemaAttr(0, "functionGroupId")]
    [Index(8)]
    public ByteValue FunctionGroupId { get; set; }
    /// <summary>
    /// <para> shortcutKey, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: shortcutKey </para>
    /// </summary>
    [SchemaAttr(0, "shortcutKey")]
    [Index(9)]
    public ByteValue ShortcutKey { get; set; }
    /// <summary>
    /// <para> hidden, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    [Index(10)]
    public BooleanValue Hidden { get; set; }
    /// <summary>
    /// <para> customMenu, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: customMenu </para>
    /// </summary>
    [SchemaAttr(0, "customMenu")]
    [Index(11)]
    public StringValue CustomMenu { get; set; }
    /// <summary>
    /// <para> description, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    [Index(12)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> help, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: help </para>
    /// </summary>
    [SchemaAttr(0, "help")]
    [Index(13)]
    public StringValue Help { get; set; }
    /// <summary>
    /// <para> statusBar, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: statusBar </para>
    /// </summary>
    [SchemaAttr(0, "statusBar")]
    [Index(14)]
    public StringValue StatusBar { get; set; }
    /// <summary>
    /// <para> comment, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: comment </para>
    /// </summary>
    [SchemaAttr(0, "comment")]
    [Index(15)]
    public StringValue Comment { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExDefinedName class.
    /// </summary>
    public RevExDefinedName():base(){}
        /// <summary>
    ///Initializes a new instance of the RevExDefinedName class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RevExDefinedName(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RevExDefinedName(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.FormulaFormula), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> FormulaFormula.</para>
    /// <para> Represents the following element tag in the schema: xr:formula </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(0)]
    public FormulaFormula FormulaFormula
	{
        get => GetElement<FormulaFormula>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: xr:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(1)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExDefinedName>(deep);

}
/// <summary>
/// <para>Defines the RevExDelObj Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrdo.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StateBasedHeader &lt;xr:hdr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(StateBasedHeader), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrdo")]
public partial class RevExDelObj : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExDelObj class.
    /// </summary>
    public RevExDelObj():base(){}
        /// <summary>
    ///Initializes a new instance of the RevExDelObj class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RevExDelObj(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RevExDelObj(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader), 1, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> StateBasedHeader.</para>
    /// <para> Represents the following element tag in the schema: xr:hdr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(0)]
    public StateBasedHeader StateBasedHeader
	{
        get => GetElement<StateBasedHeader>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExDelObj>(deep);

}
/// <summary>
/// <para>Defines the RevExChgObj Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrco.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StateBasedHeader &lt;xr:hdr></description></item>
///<item><description>RevisionStateLink &lt;xr:link></description></item>
///<item><description>RevisionState &lt;xr:body></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(StateBasedHeader), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevisionStateLink), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevisionState), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrco")]
public partial class RevExChgObj : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExChgObj class.
    /// </summary>
    public RevExChgObj():base(){}
        /// <summary>
    ///Initializes a new instance of the RevExChgObj class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RevExChgObj(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RevExChgObj(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader), 1, 1, version: FileFormatVersions.Office2016),
    new CompositeParticle(ParticleType.Choice, 1, 1)
    {
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevisionStateLink), 0, 1, version: FileFormatVersions.Office2016),
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevisionState), 0, 1, version: FileFormatVersions.Office2016)
    }
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> StateBasedHeader.</para>
    /// <para> Represents the following element tag in the schema: xr:hdr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(0)]
    public StateBasedHeader StateBasedHeader
	{
        get => GetElement<StateBasedHeader>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExChgObj>(deep);

}
/// <summary>
/// <para>Defines the RevExSheetOp Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrSheet.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrSheet")]
public partial class RevExSheetOp : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }
    /// <summary>
    /// <para> op, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: op </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "op")]
    [Index(5)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SheetOp> Op { get; set; }
    /// <summary>
    /// <para> name, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(6)]
    public StringValue Name { get; set; }
    /// <summary>
    /// <para> idOrig, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: idOrig </para>
    /// </summary>
    [SchemaAttr(0, "idOrig")]
    [Index(7)]
    public UInt32Value IdOrig { get; set; }
    /// <summary>
    /// <para> idNew, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: idNew </para>
    /// </summary>
    [SchemaAttr(0, "idNew")]
    [Index(8)]
    public UInt32Value IdNew { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevExSheetOp class.
    /// </summary>
    public RevExSheetOp():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExSheetOp>(deep);

}
/// <summary>
/// <para>Defines the RevisionList Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrList.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrList")]
public partial class RevisionList : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }
    /// <summary>
    /// <para> Data, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: Data </para>
    /// </summary>
    [SchemaAttr(0, "Data")]
    [Index(5)]
    public BooleanValue Data { get; set; }
    /// <summary>
    /// <para> Formatting, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: Formatting </para>
    /// </summary>
    [SchemaAttr(0, "Formatting")]
    [Index(6)]
    public BooleanValue Formatting { get; set; }
    /// <summary>
    /// <para> RangeBased, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: RangeBased </para>
    /// </summary>
    [SchemaAttr(0, "RangeBased")]
    [Index(7)]
    public BooleanValue RangeBased { get; set; }
    /// <summary>
    /// <para> Fake, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: Fake </para>
    /// </summary>
    [SchemaAttr(0, "Fake")]
    [Index(8)]
    public BooleanValue Fake { get; set; }
    /// <summary>
    /// <para> ref, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "ref")]
    [Index(9)]
    public StringValue Ref { get; set; }
    /// <summary>
    /// <para> Headers, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: Headers </para>
    /// </summary>
    [SchemaAttr(0, "Headers")]
    [Index(10)]
    public BooleanValue Headers { get; set; }
    /// <summary>
    /// <para> InsDelHeaders, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: InsDelHeaders </para>
    /// </summary>
    [SchemaAttr(0, "InsDelHeaders")]
    [Index(11)]
    public BooleanValue InsDelHeaders { get; set; }
    /// <summary>
    /// <para> rId, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rId </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rId")]
    [Index(12)]
    public UInt32Value RId { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevisionList class.
    /// </summary>
    public RevisionList():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevisionList>(deep);

}
/// <summary>
/// <para>Defines the RevListAutoExpandRw Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrListExpR.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrListExpR")]
public partial class RevListAutoExpandRw : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }
    /// <summary>
    /// <para> refAdded, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: refAdded </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "refAdded")]
    [Index(5)]
    public StringValue RefAdded { get; set; }
    /// <summary>
    /// <para> listGuid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: listGuid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "listGuid")]
    [Index(6)]
    public StringValue ListGuid { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevListAutoExpandRw class.
    /// </summary>
    public RevListAutoExpandRw():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevListAutoExpandRw>(deep);

}
/// <summary>
/// <para>Defines the RevGroup Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrg.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RevExFuture &lt;xr:xrrftr></description></item>
///<item><description>RevExUnsupported &lt;xr:xrrUspt></description></item>
///<item><description>RevExTrimmed &lt;xr:xrrTrim></description></item>
///<item><description>RevExRowColumn &lt;xr:xrrrc></description></item>
///<item><description>RevExMove &lt;xr:xrrm></description></item>
///<item><description>RevExChangeCell &lt;xr:xrrc></description></item>
///<item><description>RevExFormatting &lt;xr:xrrf></description></item>
///<item><description>RevExDefinedName &lt;xr:xrrDefName></description></item>
///<item><description>RevExDelObj &lt;xr:xrrdo></description></item>
///<item><description>RevExChgObj &lt;xr:xrrco></description></item>
///<item><description>RevExSheetOp &lt;xr:xrrSheet></description></item>
///<item><description>RevisionList &lt;xr:xrrList></description></item>
///<item><description>RevListAutoExpandRw &lt;xr:xrrListExpR></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RevExFuture), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExUnsupported), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExTrimmed), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExRowColumn), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExMove), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExChangeCell), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExFormatting), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExDefinedName), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExDelObj), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExChgObj), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevExSheetOp), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevisionList), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RevListAutoExpandRw), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrg")]
public partial class RevGroup : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> rev, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "rev")]
    [Index(0)]
    public UInt64Value Rev { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(1)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> sh, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sh")]
    [Index(2)]
    public StringValue Sh { get; set; }
    /// <summary>
    /// <para> uidp, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidp")]
    [Index(3)]
    public StringValue Uidp { get; set; }
    /// <summary>
    /// <para> ctx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevGroup class.
    /// </summary>
    public RevGroup():base(){}
        /// <summary>
    ///Initializes a new instance of the RevGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RevGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RevGroup(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Choice, 1, 0)
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
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevGroup>(deep);

}
/// <summary>
/// <para>Defines the RevExTest Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrtest.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "xrrtest")]
public partial class RevExTest : OpenXmlLeafElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the RevExTest class.
    /// </summary>
    public RevExTest():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExTest>(deep);

}
/// <summary>
/// <para>Defines the RevCell Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:c.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FFormula &lt;xr:f></description></item>
///<item><description>Xstring &lt;xr:v></description></item>
///<item><description>RstType &lt;xr:is></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(FFormula), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Xstring), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RstType), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "c")]
public partial class RevCell : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> t, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues> T { get; set; }
    /// <summary>
    /// <para> nop, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: nop </para>
    /// </summary>
    [SchemaAttr(0, "nop")]
    [Index(1)]
    public BooleanValue Nop { get; set; }
    /// <summary>
    /// <para> tick, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: tick </para>
    /// </summary>
    [SchemaAttr(0, "tick")]
    [Index(2)]
    public BooleanValue Tick { get; set; }
    /// <summary>
    /// <para> rep, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: rep </para>
    /// </summary>
    [SchemaAttr(0, "rep")]
    [Index(3)]
    public UInt32Value Rep { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevCell class.
    /// </summary>
    public RevCell():base(){}
        /// <summary>
    ///Initializes a new instance of the RevCell class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RevCell(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RevCell(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.FFormula), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Xstring), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RstType), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> FFormula.</para>
    /// <para> Represents the following element tag in the schema: xr:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(0)]
    public FFormula FFormula
	{
        get => GetElement<FFormula>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> Xstring.</para>
    /// <para> Represents the following element tag in the schema: xr:v </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(1)]
    public Xstring Xstring
	{
        get => GetElement<Xstring>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> RstType.</para>
    /// <para> Represents the following element tag in the schema: xr:is </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(2)]
    public RstType RstType
	{
        get => GetElement<RstType>(2);
        set => SetElement(2, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevCell>(deep);

}
/// <summary>
/// <para>Defines the ChangeCellSubEdit Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:ccse.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RevCell &lt;xr:c></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RevCell), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "ccse")]
public partial class ChangeCellSubEdit : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> r, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "r")]
    [Index(0)]
    public StringValue R { get; set; }
    /// <summary>
    /// <para> t, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType> T { get; set; }
    /// <summary>
    /// <para> x, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
    [SchemaAttr(0, "x")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt> X { get; set; }
    /// <summary>
    /// <para> w, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: w </para>
    /// </summary>
    [SchemaAttr(0, "w")]
    [Index(3)]
    public UInt32Value W { get; set; }

    /// <summary>
    /// Initializes a new instance of the ChangeCellSubEdit class.
    /// </summary>
    public ChangeCellSubEdit():base(){}
        /// <summary>
    ///Initializes a new instance of the ChangeCellSubEdit class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChangeCellSubEdit(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public ChangeCellSubEdit(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevCell), 1, 0, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChangeCellSubEdit>(deep);

}
/// <summary>
/// <para>Defines the ExtensionList Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Extension &lt;x:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Extension))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "extLst")]
public partial class ExtensionList : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the ExtensionList class.
    /// </summary>
    public ExtensionList():base(){}
        /// <summary>
    ///Initializes a new instance of the ExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public ExtensionList(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new CompositeParticle(ParticleType.Group, 0, 1)
    {
        new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Extension), 0, 0)
        }
    }
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);

}
/// <summary>
/// <para>Defines the FormulaFormula Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:formula.</para>
/// </summary>

[SchemaAttr(83, "formula")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class FormulaFormula : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the FormulaFormula class.
    /// </summary>
    public FormulaFormula():base(){}
    
        /// <summary>
    /// Initializes a new instance of the FormulaFormula class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FormulaFormula(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaFormula>(deep);


}
/// <summary>
/// <para>Defines the FFormula Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:f.</para>
/// </summary>

[SchemaAttr(83, "f")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class FFormula : OpenXmlLeafTextElement
{
    /// <summary>
    /// Initializes a new instance of the FFormula class.
    /// </summary>
    public FFormula():base(){}
    
        /// <summary>
    /// Initializes a new instance of the FFormula class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FFormula(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FFormula>(deep);


}
/// <summary>
/// <para>Defines the StateBasedHeader Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:hdr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RefMap &lt;xr:refmap></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RefMap), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "hdr")]
public partial class StateBasedHeader : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(0)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> eft, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: eft </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "eft")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FeatureType> Eft { get; set; }
    /// <summary>
    /// <para> eftx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: eftx </para>
    /// </summary>
    [SchemaAttr(0, "eftx")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtFeatureType> Eftx { get; set; }
    /// <summary>
    /// <para> seft, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: seft </para>
    /// </summary>
    [SchemaAttr(0, "seft")]
    [Index(3)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SubFeatureType> Seft { get; set; }
    /// <summary>
    /// <para> seftx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: seftx </para>
    /// </summary>
    [SchemaAttr(0, "seftx")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtSubFeatureType> Seftx { get; set; }

    /// <summary>
    /// Initializes a new instance of the StateBasedHeader class.
    /// </summary>
    public StateBasedHeader():base(){}
        /// <summary>
    ///Initializes a new instance of the StateBasedHeader class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StateBasedHeader(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public StateBasedHeader(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefMap), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> RefMap.</para>
    /// <para> Represents the following element tag in the schema: xr:refmap </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(0)]
    public RefMap RefMap
	{
        get => GetElement<RefMap>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StateBasedHeader>(deep);

}
/// <summary>
/// <para>Defines the RevisionStateLink Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:link.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "link")]
public partial class RevisionStateLink : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> id, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
[RequiredValidator]
    [SchemaAttr(19, "id")]
    [Index(0)]
    public StringValue Id { get; set; }

    /// <summary>
    /// Initializes a new instance of the RevisionStateLink class.
    /// </summary>
    public RevisionStateLink():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevisionStateLink>(deep);

}
/// <summary>
/// <para>Defines the RevisionState Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:body.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RowColVisualOps &lt;xr:rowColVisualOps></description></item>
///<item><description>HideUnhideSheet &lt;xr:hideUnhideSheet></description></item>
///<item><description>ShowGridlinesHeadings &lt;xr:showGridlinesHeadings></description></item>
///<item><description>FreezePanes &lt;xr:freezePanes></description></item>
///<item><description>Outlines &lt;xr:outlines></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RowColVisualOps), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(HideUnhideSheet), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ShowGridlinesHeadings), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(FreezePanes), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Outlines), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "body")]
public partial class RevisionState : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the RevisionState class.
    /// </summary>
    public RevisionState():base(){}
        /// <summary>
    ///Initializes a new instance of the RevisionState class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RevisionState(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RevisionState(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOps), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.HideUnhideSheet), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.ShowGridlinesHeadings), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.FreezePanes), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Outlines), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
        /// <summary>
    /// <para> RowColVisualOps.</para>
    /// <para> Represents the following element tag in the schema: xr:rowColVisualOps </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(0)]
    public RowColVisualOps RowColVisualOps
	{
        get => GetElement<RowColVisualOps>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> HideUnhideSheet.</para>
    /// <para> Represents the following element tag in the schema: xr:hideUnhideSheet </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(1)]
    public HideUnhideSheet HideUnhideSheet
	{
        get => GetElement<HideUnhideSheet>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> ShowGridlinesHeadings.</para>
    /// <para> Represents the following element tag in the schema: xr:showGridlinesHeadings </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(2)]
    public ShowGridlinesHeadings ShowGridlinesHeadings
	{
        get => GetElement<ShowGridlinesHeadings>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> FreezePanes.</para>
    /// <para> Represents the following element tag in the schema: xr:freezePanes </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(3)]
    public FreezePanes FreezePanes
	{
        get => GetElement<FreezePanes>(3);
        set => SetElement(3, value);
	}
    /// <summary>
    /// <para> Outlines.</para>
    /// <para> Represents the following element tag in the schema: xr:outlines </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
	[Index(4)]
    public Outlines Outlines
	{
        get => GetElement<Outlines>(4);
        set => SetElement(4, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevisionState>(deep);

}
/// <summary>
/// <para>Defines the RefMap Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:refmap.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RefCell &lt;xr:ref></description></item>
///<item><description>SheetXluid &lt;xr:sheetUid></description></item>
///<item><description>RefOartAnchor &lt;xr:oartAnchor></description></item>
///<item><description>RefFuture &lt;xr:future></description></item>
///<item><description>RefTest &lt;xr:test></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RefCell), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(SheetXluid), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RefOartAnchor), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RefFuture), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(RefTest), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "refmap")]
public partial class RefMap : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the RefMap class.
    /// </summary>
    public RefMap():base(){}
        /// <summary>
    ///Initializes a new instance of the RefMap class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RefMap(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RefMap(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Choice, 1, 0)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefCell), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.SheetXluid), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefOartAnchor), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefFuture), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefTest), 1, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefMap>(deep);

}
/// <summary>
/// <para>Defines the RowColVisualOps Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:rowColVisualOps.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "rowColVisualOps")]
public partial class RowColVisualOps : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> action, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: action </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "action")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOp> Action { get; set; }
    /// <summary>
    /// <para> isRow, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: isRow </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "isRow")]
    [Index(1)]
    public BooleanValue IsRow { get; set; }
    /// <summary>
    /// <para> size, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    [Index(2)]
    public UInt32Value Size { get; set; }
    /// <summary>
    /// <para> userSized, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: userSized </para>
    /// </summary>
    [SchemaAttr(0, "userSized")]
    [Index(3)]
    public BooleanValue UserSized { get; set; }

    /// <summary>
    /// Initializes a new instance of the RowColVisualOps class.
    /// </summary>
    public RowColVisualOps():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowColVisualOps>(deep);

}
/// <summary>
/// <para>Defines the HideUnhideSheet Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:hideUnhideSheet.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "hideUnhideSheet")]
public partial class HideUnhideSheet : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> hide, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: hide </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "hide")]
    [Index(0)]
    public BooleanValue Hide { get; set; }

    /// <summary>
    /// Initializes a new instance of the HideUnhideSheet class.
    /// </summary>
    public HideUnhideSheet():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideUnhideSheet>(deep);

}
/// <summary>
/// <para>Defines the ShowGridlinesHeadings Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:showGridlinesHeadings.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "showGridlinesHeadings")]
public partial class ShowGridlinesHeadings : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> showGridLines, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: showGridLines </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "showGridLines")]
    [Index(0)]
    public BooleanValue ShowGridLines { get; set; }
    /// <summary>
    /// <para> showRowCol, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: showRowCol </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "showRowCol")]
    [Index(1)]
    public BooleanValue ShowRowCol { get; set; }

    /// <summary>
    /// Initializes a new instance of the ShowGridlinesHeadings class.
    /// </summary>
    public ShowGridlinesHeadings():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowGridlinesHeadings>(deep);

}
/// <summary>
/// <para>Defines the FreezePanes Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:freezePanes.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "freezePanes")]
public partial class FreezePanes : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> sheetViewUid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: sheetViewUid </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "sheetViewUid")]
    [Index(0)]
    public StringValue SheetViewUid { get; set; }

    /// <summary>
    /// Initializes a new instance of the FreezePanes class.
    /// </summary>
    public FreezePanes():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FreezePanes>(deep);

}
/// <summary>
/// <para>Defines the Outlines Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:outlines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Outline &lt;xr:outline></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Outline), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "outlines")]
public partial class Outlines : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> isRow, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: isRow </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "isRow")]
    [Index(0)]
    public BooleanValue IsRow { get; set; }

    /// <summary>
    /// Initializes a new instance of the Outlines class.
    /// </summary>
    public Outlines():base(){}
        /// <summary>
    ///Initializes a new instance of the Outlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Outlines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public Outlines(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Outline), 0, 0, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Outlines>(deep);

}
/// <summary>
/// <para>Defines the Outline Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:outline.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "outline")]
public partial class Outline : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> isCollapsed, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: isCollapsed </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "isCollapsed")]
    [Index(0)]
    public BooleanValue IsCollapsed { get; set; }
    /// <summary>
    /// <para> level, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: level </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "level")]
    [Index(1)]
    public ByteValue Level { get; set; }

    /// <summary>
    /// Initializes a new instance of the Outline class.
    /// </summary>
    public Outline():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Outline>(deep);

}
/// <summary>
/// <para>Defines the Xstring Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:v.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "v")]
public partial class Xstring : OpenXmlLeafTextElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the Xstring class.
    /// </summary>
    public Xstring():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Xstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Xstring(string text):base(text)
    {
    }
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }


    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Xstring>(deep);

}
/// <summary>
/// <para>Defines the RstType Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:is.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Text &lt;x:t></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Run &lt;x:r></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PhoneticRun &lt;x:rPh></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties &lt;x:phoneticPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Text))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Run))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "is")]
public partial class RstType : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the RstType class.
    /// </summary>
    public RstType():base(){}
        /// <summary>
    ///Initializes a new instance of the RstType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RstType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public RstType(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Text), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Run), 0, 32767),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticRun), 0, 32767),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Text.</para>
    /// <para> Represents the following element tag in the schema: x:t </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Spreadsheet.Text Text
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Text>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RstType>(deep);

}
/// <summary>
/// <para>Defines the RefCell Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:ref.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "ref")]
public partial class RefCell : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> n, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "n")]
    [Index(0)]
    public StringValue N { get; set; }
    /// <summary>
    /// <para> ajt, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ajt </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "ajt")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt { get; set; }
    /// <summary>
    /// <para> ajtx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ajtx </para>
    /// </summary>
    [SchemaAttr(0, "ajtx")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx { get; set; }
    /// <summary>
    /// <para> homeRef, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: homeRef </para>
    /// </summary>
    [SchemaAttr(0, "homeRef")]
    [Index(3)]
    public BooleanValue HomeRef { get; set; }
    /// <summary>
    /// <para> r, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "r")]
    [Index(4)]
    public ListValue<StringValue> R { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(5)]
    public StringValue Uid { get; set; }
    /// <summary>
    /// <para> uidLast, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uidLast </para>
    /// </summary>
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uidLast")]
    [Index(6)]
    public StringValue UidLast { get; set; }

    /// <summary>
    /// Initializes a new instance of the RefCell class.
    /// </summary>
    public RefCell():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefCell>(deep);

}
/// <summary>
/// <para>Defines the SheetXluid Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:sheetUid.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "sheetUid")]
public partial class SheetXluid : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> n, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "n")]
    [Index(0)]
    public StringValue N { get; set; }
    /// <summary>
    /// <para> ajt, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ajt </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "ajt")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt { get; set; }
    /// <summary>
    /// <para> ajtx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ajtx </para>
    /// </summary>
    [SchemaAttr(0, "ajtx")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx { get; set; }
    /// <summary>
    /// <para> homeRef, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: homeRef </para>
    /// </summary>
    [SchemaAttr(0, "homeRef")]
    [Index(3)]
    public BooleanValue HomeRef { get; set; }
    /// <summary>
    /// <para> uid, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
[RequiredValidator]
[StringValidator(IsToken = true, Pattern = @"\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}")]
    [SchemaAttr(0, "uid")]
    [Index(4)]
    public StringValue Uid { get; set; }

    /// <summary>
    /// Initializes a new instance of the SheetXluid class.
    /// </summary>
    public SheetXluid():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SheetXluid>(deep);

}
/// <summary>
/// <para>Defines the RefOartAnchor Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:oartAnchor.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "oartAnchor")]
public partial class RefOartAnchor : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> n, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "n")]
    [Index(0)]
    public StringValue N { get; set; }
    /// <summary>
    /// <para> ajt, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ajt </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "ajt")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt { get; set; }
    /// <summary>
    /// <para> ajtx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ajtx </para>
    /// </summary>
    [SchemaAttr(0, "ajtx")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx { get; set; }
    /// <summary>
    /// <para> homeRef, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: homeRef </para>
    /// </summary>
    [SchemaAttr(0, "homeRef")]
    [Index(3)]
    public BooleanValue HomeRef { get; set; }
    /// <summary>
    /// <para> r, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    [Index(4)]
    public StringValue R { get; set; }
    /// <summary>
    /// <para> fromRowOff, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: fromRowOff </para>
    /// </summary>
[NumberValidator(MinInclusive = -27273042329600, MaxInclusive = 27273042316900)]
    [SchemaAttr(0, "fromRowOff")]
    [Index(5)]
    public Int64Value FromRowOff { get; set; }
    /// <summary>
    /// <para> fromColOff, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: fromColOff </para>
    /// </summary>
[NumberValidator(MinInclusive = -27273042329600, MaxInclusive = 27273042316900)]
    [SchemaAttr(0, "fromColOff")]
    [Index(6)]
    public Int64Value FromColOff { get; set; }
    /// <summary>
    /// <para> toRowOff, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: toRowOff </para>
    /// </summary>
[NumberValidator(MinInclusive = -27273042329600, MaxInclusive = 27273042316900)]
    [SchemaAttr(0, "toRowOff")]
    [Index(7)]
    public Int64Value ToRowOff { get; set; }
    /// <summary>
    /// <para> toColOff, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: toColOff </para>
    /// </summary>
[NumberValidator(MinInclusive = -27273042329600, MaxInclusive = 27273042316900)]
    [SchemaAttr(0, "toColOff")]
    [Index(8)]
    public Int64Value ToColOff { get; set; }
    /// <summary>
    /// <para> cx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: cx </para>
    /// </summary>
[NumberValidator(MinInclusive = 0, MaxInclusive = 2147483647)]
    [SchemaAttr(0, "cx")]
    [Index(9)]
    public Int64Value Cx { get; set; }
    /// <summary>
    /// <para> cy, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: cy </para>
    /// </summary>
[NumberValidator(MinInclusive = 0, MaxInclusive = 2147483647)]
    [SchemaAttr(0, "cy")]
    [Index(10)]
    public Int64Value Cy { get; set; }
    /// <summary>
    /// <para> x, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
[NumberValidator(MinInclusive = -27273042329600, MaxInclusive = 27273042316900)]
    [SchemaAttr(0, "x")]
    [Index(11)]
    public Int64Value X { get; set; }
    /// <summary>
    /// <para> y, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: y </para>
    /// </summary>
[NumberValidator(MinInclusive = -27273042329600, MaxInclusive = 27273042316900)]
    [SchemaAttr(0, "y")]
    [Index(12)]
    public Int64Value Y { get; set; }
    /// <summary>
    /// <para> oat, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: oat </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "oat")]
    [Index(13)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.OartAnchorType> Oat { get; set; }

    /// <summary>
    /// Initializes a new instance of the RefOartAnchor class.
    /// </summary>
    public RefOartAnchor():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefOartAnchor>(deep);

}
/// <summary>
/// <para>Defines the RefFuture Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:future.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "future")]
public partial class RefFuture : OpenXmlLeafElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the RefFuture class.
    /// </summary>
    public RefFuture():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefFuture>(deep);

}
/// <summary>
/// <para>Defines the RefTest Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:test.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "test")]
public partial class RefTest : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> n, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "n")]
    [Index(0)]
    public StringValue N { get; set; }
    /// <summary>
    /// <para> ajt, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ajt </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "ajt")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt { get; set; }
    /// <summary>
    /// <para> ajtx, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: ajtx </para>
    /// </summary>
    [SchemaAttr(0, "ajtx")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx { get; set; }
    /// <summary>
    /// <para> homeRef, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: homeRef </para>
    /// </summary>
    [SchemaAttr(0, "homeRef")]
    [Index(3)]
    public BooleanValue HomeRef { get; set; }

    /// <summary>
    /// Initializes a new instance of the RefTest class.
    /// </summary>
    public RefTest():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefTest>(deep);

}
/// <summary>
/// <para>Represents an external link to another workbook..</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:dataValidation.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.ExcelAc.List &lt;x12ac:list></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Formula1 &lt;x:formula1></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Formula2 &lt;x:formula2></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.ExcelAc.List), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Formula1))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Formula2))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "dataValidation")]
public partial class DataValidation : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues> Type { get; set; }
    /// <summary>
    /// <para> errorStyle.</para>
    /// <para>Represents the following attribute in the schema: errorStyle </para>
    /// </summary>
    [SchemaAttr(0, "errorStyle")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues> ErrorStyle { get; set; }
    /// <summary>
    /// <para> imeMode.</para>
    /// <para>Represents the following attribute in the schema: imeMode </para>
    /// </summary>
    [SchemaAttr(0, "imeMode")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues> ImeMode { get; set; }
    /// <summary>
    /// <para> operator.</para>
    /// <para>Represents the following attribute in the schema: operator </para>
    /// </summary>
    [SchemaAttr(0, "operator")]
    [Index(3)]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues> Operator { get; set; }
    /// <summary>
    /// <para> allowBlank.</para>
    /// <para>Represents the following attribute in the schema: allowBlank </para>
    /// </summary>
    [SchemaAttr(0, "allowBlank")]
    [Index(4)]
    public BooleanValue AllowBlank { get; set; }
    /// <summary>
    /// <para> showDropDown.</para>
    /// <para>Represents the following attribute in the schema: showDropDown </para>
    /// </summary>
    [SchemaAttr(0, "showDropDown")]
    [Index(5)]
    public BooleanValue ShowDropDown { get; set; }
    /// <summary>
    /// <para> showInputMessage.</para>
    /// <para>Represents the following attribute in the schema: showInputMessage </para>
    /// </summary>
    [SchemaAttr(0, "showInputMessage")]
    [Index(6)]
    public BooleanValue ShowInputMessage { get; set; }
    /// <summary>
    /// <para> showErrorMessage.</para>
    /// <para>Represents the following attribute in the schema: showErrorMessage </para>
    /// </summary>
    [SchemaAttr(0, "showErrorMessage")]
    [Index(7)]
    public BooleanValue ShowErrorMessage { get; set; }
    /// <summary>
    /// <para> errorTitle.</para>
    /// <para>Represents the following attribute in the schema: errorTitle </para>
    /// </summary>
    [SchemaAttr(0, "errorTitle")]
    [Index(8)]
    public StringValue ErrorTitle { get; set; }
    /// <summary>
    /// <para> error.</para>
    /// <para>Represents the following attribute in the schema: error </para>
    /// </summary>
    [SchemaAttr(0, "error")]
    [Index(9)]
    public StringValue Error { get; set; }
    /// <summary>
    /// <para> promptTitle.</para>
    /// <para>Represents the following attribute in the schema: promptTitle </para>
    /// </summary>
    [SchemaAttr(0, "promptTitle")]
    [Index(10)]
    public StringValue PromptTitle { get; set; }
    /// <summary>
    /// <para> prompt.</para>
    /// <para>Represents the following attribute in the schema: prompt </para>
    /// </summary>
    [SchemaAttr(0, "prompt")]
    [Index(11)]
    public StringValue Prompt { get; set; }
    /// <summary>
    /// <para> sqref.</para>
    /// <para>Represents the following attribute in the schema: sqref </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "sqref")]
    [Index(12)]
    public ListValue<StringValue> SequenceOfReferences { get; set; }

    /// <summary>
    /// Initializes a new instance of the DataValidation class.
    /// </summary>
    public DataValidation():base(){}
        /// <summary>
    ///Initializes a new instance of the DataValidation class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataValidation(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public DataValidation(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.ExcelAc.List), 0, 1, version: FileFormatVersions.Office2013),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Formula1), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Formula2), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> List.</para>
    /// <para> Represents the following element tag in the schema: x12ac:list </para>
    /// </summary>
    /// <remark>
    /// xmlns:x12ac = http://schemas.microsoft.com/office/spreadsheetml/2011/1/ac
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Office2010.ExcelAc.List List
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.ExcelAc.List>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> Formula1.</para>
    /// <para> Represents the following element tag in the schema: x:formula1 </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Spreadsheet.Formula1 Formula1
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Formula1>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> Formula2.</para>
    /// <para> Represents the following element tag in the schema: x:formula2 </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Spreadsheet.Formula2 Formula2
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Formula2>(2);
        set => SetElement(2, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataValidation>(deep);

}
/// <summary>
/// <para>Represents a hyperlink within a cell..</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:hyperlink.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "hyperlink")]
public partial class Hyperlink : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> Reference.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "ref")]
    [Index(0)]
    public StringValue Reference { get; set; }
    /// <summary>
    /// <para> Relationship Id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [Index(1)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> Location.</para>
    /// <para>Represents the following attribute in the schema: location </para>
    /// </summary>
    [SchemaAttr(0, "location")]
    [Index(2)]
    public StringValue Location { get; set; }
    /// <summary>
    /// <para> Tool Tip.</para>
    /// <para>Represents the following attribute in the schema: tooltip </para>
    /// </summary>
    [SchemaAttr(0, "tooltip")]
    [Index(3)]
    public StringValue Tooltip { get; set; }
    /// <summary>
    /// <para> Display String.</para>
    /// <para>Represents the following attribute in the schema: display </para>
    /// </summary>
    [SchemaAttr(0, "display")]
    [Index(4)]
    public StringValue Display { get; set; }

    /// <summary>
    /// Initializes a new instance of the Hyperlink class.
    /// </summary>
    public Hyperlink():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Hyperlink>(deep);

}
/// <summary>
/// <para>Represents a sparkline group of 1 or more sparklines..</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:sparklineGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.SeriesColor &lt;x14:colorSeries></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.NegativeColor &lt;x14:colorNegative></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.AxisColor &lt;x14:colorAxis></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.MarkersColor &lt;x14:colorMarkers></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor &lt;x14:colorFirst></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor &lt;x14:colorLast></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor &lt;x14:colorHigh></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor &lt;x14:colorLow></description></item>
///<item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.Sparklines &lt;x14:sparklines></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.SeriesColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.NegativeColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.AxisColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.MarkersColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.Sparklines), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "sparklineGroup")]
public partial class SparklineGroup : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> manualMax, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: manualMax </para>
    /// </summary>
    [SchemaAttr(0, "manualMax")]
    [Index(0)]
    public DoubleValue ManualMax { get; set; }
    /// <summary>
    /// <para> manualMin, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: manualMin </para>
    /// </summary>
    [SchemaAttr(0, "manualMin")]
    [Index(1)]
    public DoubleValue ManualMin { get; set; }
    /// <summary>
    /// <para> lineWeight, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: lineWeight </para>
    /// </summary>
    [SchemaAttr(0, "lineWeight")]
    [Index(2)]
    public DoubleValue LineWeight { get; set; }
    /// <summary>
    /// <para> type, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(3)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues> Type { get; set; }
    /// <summary>
    /// <para> dateAxis, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: dateAxis </para>
    /// </summary>
    [SchemaAttr(0, "dateAxis")]
    [Index(4)]
    public BooleanValue DateAxis { get; set; }
    /// <summary>
    /// <para> displayEmptyCellsAs, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: displayEmptyCellsAs </para>
    /// </summary>
    [SchemaAttr(0, "displayEmptyCellsAs")]
    [Index(5)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues> DisplayEmptyCellsAs { get; set; }
    /// <summary>
    /// <para> markers, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: markers </para>
    /// </summary>
    [SchemaAttr(0, "markers")]
    [Index(6)]
    public BooleanValue Markers { get; set; }
    /// <summary>
    /// <para> high, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: high </para>
    /// </summary>
    [SchemaAttr(0, "high")]
    [Index(7)]
    public BooleanValue High { get; set; }
    /// <summary>
    /// <para> low, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: low </para>
    /// </summary>
    [SchemaAttr(0, "low")]
    [Index(8)]
    public BooleanValue Low { get; set; }
    /// <summary>
    /// <para> first, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: first </para>
    /// </summary>
    [SchemaAttr(0, "first")]
    [Index(9)]
    public BooleanValue First { get; set; }
    /// <summary>
    /// <para> last, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: last </para>
    /// </summary>
    [SchemaAttr(0, "last")]
    [Index(10)]
    public BooleanValue Last { get; set; }
    /// <summary>
    /// <para> negative, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: negative </para>
    /// </summary>
    [SchemaAttr(0, "negative")]
    [Index(11)]
    public BooleanValue Negative { get; set; }
    /// <summary>
    /// <para> displayXAxis, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: displayXAxis </para>
    /// </summary>
    [SchemaAttr(0, "displayXAxis")]
    [Index(12)]
    public BooleanValue DisplayXAxis { get; set; }
    /// <summary>
    /// <para> displayHidden, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: displayHidden </para>
    /// </summary>
    [SchemaAttr(0, "displayHidden")]
    [Index(13)]
    public BooleanValue DisplayHidden { get; set; }
    /// <summary>
    /// <para> minAxisType, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: minAxisType </para>
    /// </summary>
    [SchemaAttr(0, "minAxisType")]
    [Index(14)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues> MinAxisType { get; set; }
    /// <summary>
    /// <para> maxAxisType, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: maxAxisType </para>
    /// </summary>
    [SchemaAttr(0, "maxAxisType")]
    [Index(15)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues> MaxAxisType { get; set; }
    /// <summary>
    /// <para> rightToLeft, this property is only available in Office2010, Office2013, Office2016.</para>
    /// <para>Represents the following attribute in the schema: rightToLeft </para>
    /// </summary>
    [SchemaAttr(0, "rightToLeft")]
    [Index(16)]
    public BooleanValue RightToLeft { get; set; }

    /// <summary>
    /// Initializes a new instance of the SparklineGroup class.
    /// </summary>
    public SparklineGroup():base(){}
        /// <summary>
    ///Initializes a new instance of the SparklineGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SparklineGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public SparklineGroup(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> SeriesColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorSeries </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Office2010.Excel.SeriesColor SeriesColor
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.SeriesColor>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> NegativeColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Office2010.Excel.NegativeColor NegativeColor
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.NegativeColor>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> AxisColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorAxis </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Office2010.Excel.AxisColor AxisColor
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.AxisColor>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> MarkersColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorMarkers </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Office2010.Excel.MarkersColor MarkersColor
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.MarkersColor>(3);
        set => SetElement(3, value);
	}
    /// <summary>
    /// <para> FirstMarkerColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorFirst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor FirstMarkerColor
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor>(4);
        set => SetElement(4, value);
	}
    /// <summary>
    /// <para> LastMarkerColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorLast </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
	[Index(5)]
    public DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor LastMarkerColor
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor>(5);
        set => SetElement(5, value);
	}
    /// <summary>
    /// <para> HighMarkerColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorHigh </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
	[Index(6)]
    public DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor HighMarkerColor
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor>(6);
        set => SetElement(6, value);
	}
    /// <summary>
    /// <para> LowMarkerColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorLow </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
	[Index(7)]
    public DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor LowMarkerColor
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor>(7);
        set => SetElement(7, value);
	}
    /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: xne:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
	[Index(8)]
    public DocumentFormat.OpenXml.Office.Excel.Formula Formula
	{
        get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>(8);
        set => SetElement(8, value);
	}
    /// <summary>
    /// <para> Sparklines.</para>
    /// <para> Represents the following element tag in the schema: x14:sparklines </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
	[Index(9)]
    public DocumentFormat.OpenXml.Office2010.Excel.Sparklines Sparklines
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Sparklines>(9);
        set => SetElement(9, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SparklineGroup>(deep);

}
/// <summary>
/// <para>Represents one comment within a cell..</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:comments.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Authors &lt;x:authors></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.CommentList &lt;x:commentList></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ExtensionList &lt;x:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Authors))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.CommentList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "comments")]
public partial class Comments : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the Comments class.
    /// </summary>
    public Comments():base(){}
        /// <summary>
    ///Initializes a new instance of the Comments class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Comments(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public Comments(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Authors), 1, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.CommentList), 1, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Authors.</para>
    /// <para> Represents the following element tag in the schema: x:authors </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Spreadsheet.Authors Authors
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Authors>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> List of Comments.</para>
    /// <para> Represents the following element tag in the schema: x:commentList </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Spreadsheet.CommentList CommentList
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.CommentList>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Spreadsheet.ExtensionList ExtensionList
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>(2);
        set => SetElement(2, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Comments>(deep);

}
/// <summary>
/// <para>Represents an autofilter..</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:autoFilter.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.FilterColumn &lt;x:filterColumn></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.SortState &lt;x:sortState></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ExtensionList &lt;x:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.FilterColumn))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SortState))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "autoFilter")]
public partial class AutoFilter : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> Cell or Range Reference.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    [Index(0)]
    public StringValue Reference { get; set; }

    /// <summary>
    /// Initializes a new instance of the AutoFilter class.
    /// </summary>
    public AutoFilter():base(){}
        /// <summary>
    ///Initializes a new instance of the AutoFilter class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AutoFilter(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public AutoFilter(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.FilterColumn), 0, 0),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SortState), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoFilter>(deep);

}
/// <summary>
/// <para>Represents a PivotTable View..</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:pivotTableDefinition.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Location &lt;x:location></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotFields &lt;x:pivotFields></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.RowFields &lt;x:rowFields></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.RowItems &lt;x:rowItems></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ColumnFields &lt;x:colFields></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ColumnItems &lt;x:colItems></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PageFields &lt;x:pageFields></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.DataFields &lt;x:dataFields></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Formats &lt;x:formats></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats &lt;x:conditionalFormats></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ChartFormats &lt;x:chartFormats></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies &lt;x:pivotHierarchies></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle &lt;x:pivotTableStyleInfo></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotFilters &lt;x:filters></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage &lt;x:rowHierarchiesUsage></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage &lt;x:colHierarchiesUsage></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList &lt;x:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Location))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotFields))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.RowFields))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.RowItems))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnFields))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnItems))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PageFields))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.DataFields))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Formats))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ChartFormats))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotFilters))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(83, "pivotTableDefinition")]
public partial class pivotTableDefinition : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
    /// <summary>
    /// <para> cacheId.</para>
    /// <para>Represents the following attribute in the schema: cacheId </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "cacheId")]
    [Index(1)]
    public UInt32Value CacheId { get; set; }
    /// <summary>
    /// <para> dataOnRows.</para>
    /// <para>Represents the following attribute in the schema: dataOnRows </para>
    /// </summary>
    [SchemaAttr(0, "dataOnRows")]
    [Index(2)]
    public BooleanValue DataOnRows { get; set; }
    /// <summary>
    /// <para> dataPosition.</para>
    /// <para>Represents the following attribute in the schema: dataPosition </para>
    /// </summary>
    [SchemaAttr(0, "dataPosition")]
    [Index(3)]
    public UInt32Value DataPosition { get; set; }
    /// <summary>
    /// <para> Auto Format Id.</para>
    /// <para>Represents the following attribute in the schema: autoFormatId </para>
    /// </summary>
    [SchemaAttr(0, "autoFormatId")]
    [Index(4)]
    public UInt32Value AutoFormatId { get; set; }
    /// <summary>
    /// <para> Apply Number Formats.</para>
    /// <para>Represents the following attribute in the schema: applyNumberFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyNumberFormats")]
    [Index(5)]
    public BooleanValue ApplyNumberFormats { get; set; }
    /// <summary>
    /// <para> Apply Border Formats.</para>
    /// <para>Represents the following attribute in the schema: applyBorderFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyBorderFormats")]
    [Index(6)]
    public BooleanValue ApplyBorderFormats { get; set; }
    /// <summary>
    /// <para> Apply Font Formats.</para>
    /// <para>Represents the following attribute in the schema: applyFontFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyFontFormats")]
    [Index(7)]
    public BooleanValue ApplyFontFormats { get; set; }
    /// <summary>
    /// <para> Apply Pattern Formats.</para>
    /// <para>Represents the following attribute in the schema: applyPatternFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyPatternFormats")]
    [Index(8)]
    public BooleanValue ApplyPatternFormats { get; set; }
    /// <summary>
    /// <para> Apply Alignment Formats.</para>
    /// <para>Represents the following attribute in the schema: applyAlignmentFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyAlignmentFormats")]
    [Index(9)]
    public BooleanValue ApplyAlignmentFormats { get; set; }
    /// <summary>
    /// <para> Apply Width / Height Formats.</para>
    /// <para>Represents the following attribute in the schema: applyWidthHeightFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyWidthHeightFormats")]
    [Index(10)]
    public BooleanValue ApplyWidthHeightFormats { get; set; }
    /// <summary>
    /// <para> dataCaption.</para>
    /// <para>Represents the following attribute in the schema: dataCaption </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "dataCaption")]
    [Index(11)]
    public StringValue DataCaption { get; set; }
    /// <summary>
    /// <para> grandTotalCaption.</para>
    /// <para>Represents the following attribute in the schema: grandTotalCaption </para>
    /// </summary>
    [SchemaAttr(0, "grandTotalCaption")]
    [Index(12)]
    public StringValue GrandTotalCaption { get; set; }
    /// <summary>
    /// <para> errorCaption.</para>
    /// <para>Represents the following attribute in the schema: errorCaption </para>
    /// </summary>
    [SchemaAttr(0, "errorCaption")]
    [Index(13)]
    public StringValue ErrorCaption { get; set; }
    /// <summary>
    /// <para> showError.</para>
    /// <para>Represents the following attribute in the schema: showError </para>
    /// </summary>
    [SchemaAttr(0, "showError")]
    [Index(14)]
    public BooleanValue ShowError { get; set; }
    /// <summary>
    /// <para> missingCaption.</para>
    /// <para>Represents the following attribute in the schema: missingCaption </para>
    /// </summary>
    [SchemaAttr(0, "missingCaption")]
    [Index(15)]
    public StringValue MissingCaption { get; set; }
    /// <summary>
    /// <para> showMissing.</para>
    /// <para>Represents the following attribute in the schema: showMissing </para>
    /// </summary>
    [SchemaAttr(0, "showMissing")]
    [Index(16)]
    public BooleanValue ShowMissing { get; set; }
    /// <summary>
    /// <para> pageStyle.</para>
    /// <para>Represents the following attribute in the schema: pageStyle </para>
    /// </summary>
    [SchemaAttr(0, "pageStyle")]
    [Index(17)]
    public StringValue PageStyle { get; set; }
    /// <summary>
    /// <para> pivotTableStyle.</para>
    /// <para>Represents the following attribute in the schema: pivotTableStyle </para>
    /// </summary>
    [SchemaAttr(0, "pivotTableStyle")]
    [Index(18)]
    public StringValue PivotTableStyleName { get; set; }
    /// <summary>
    /// <para> vacatedStyle.</para>
    /// <para>Represents the following attribute in the schema: vacatedStyle </para>
    /// </summary>
    [SchemaAttr(0, "vacatedStyle")]
    [Index(19)]
    public StringValue VacatedStyle { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    [Index(20)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> updatedVersion.</para>
    /// <para>Represents the following attribute in the schema: updatedVersion </para>
    /// </summary>
    [SchemaAttr(0, "updatedVersion")]
    [Index(21)]
    public ByteValue UpdatedVersion { get; set; }
    /// <summary>
    /// <para> minRefreshableVersion.</para>
    /// <para>Represents the following attribute in the schema: minRefreshableVersion </para>
    /// </summary>
    [SchemaAttr(0, "minRefreshableVersion")]
    [Index(22)]
    public ByteValue MinRefreshableVersion { get; set; }
    /// <summary>
    /// <para> asteriskTotals.</para>
    /// <para>Represents the following attribute in the schema: asteriskTotals </para>
    /// </summary>
    [SchemaAttr(0, "asteriskTotals")]
    [Index(23)]
    public BooleanValue AsteriskTotals { get; set; }
    /// <summary>
    /// <para> showItems.</para>
    /// <para>Represents the following attribute in the schema: showItems </para>
    /// </summary>
    [SchemaAttr(0, "showItems")]
    [Index(24)]
    public BooleanValue ShowItems { get; set; }
    /// <summary>
    /// <para> editData.</para>
    /// <para>Represents the following attribute in the schema: editData </para>
    /// </summary>
    [SchemaAttr(0, "editData")]
    [Index(25)]
    public BooleanValue EditData { get; set; }
    /// <summary>
    /// <para> disableFieldList.</para>
    /// <para>Represents the following attribute in the schema: disableFieldList </para>
    /// </summary>
    [SchemaAttr(0, "disableFieldList")]
    [Index(26)]
    public BooleanValue DisableFieldList { get; set; }
    /// <summary>
    /// <para> showCalcMbrs.</para>
    /// <para>Represents the following attribute in the schema: showCalcMbrs </para>
    /// </summary>
    [SchemaAttr(0, "showCalcMbrs")]
    [Index(27)]
    public BooleanValue ShowCalculatedMembers { get; set; }
    /// <summary>
    /// <para> visualTotals.</para>
    /// <para>Represents the following attribute in the schema: visualTotals </para>
    /// </summary>
    [SchemaAttr(0, "visualTotals")]
    [Index(28)]
    public BooleanValue VisualTotals { get; set; }
    /// <summary>
    /// <para> showMultipleLabel.</para>
    /// <para>Represents the following attribute in the schema: showMultipleLabel </para>
    /// </summary>
    [SchemaAttr(0, "showMultipleLabel")]
    [Index(29)]
    public BooleanValue ShowMultipleLabel { get; set; }
    /// <summary>
    /// <para> showDataDropDown.</para>
    /// <para>Represents the following attribute in the schema: showDataDropDown </para>
    /// </summary>
    [SchemaAttr(0, "showDataDropDown")]
    [Index(30)]
    public BooleanValue ShowDataDropDown { get; set; }
    /// <summary>
    /// <para> showDrill.</para>
    /// <para>Represents the following attribute in the schema: showDrill </para>
    /// </summary>
    [SchemaAttr(0, "showDrill")]
    [Index(31)]
    public BooleanValue ShowDrill { get; set; }
    /// <summary>
    /// <para> printDrill.</para>
    /// <para>Represents the following attribute in the schema: printDrill </para>
    /// </summary>
    [SchemaAttr(0, "printDrill")]
    [Index(32)]
    public BooleanValue PrintDrill { get; set; }
    /// <summary>
    /// <para> showMemberPropertyTips.</para>
    /// <para>Represents the following attribute in the schema: showMemberPropertyTips </para>
    /// </summary>
    [SchemaAttr(0, "showMemberPropertyTips")]
    [Index(33)]
    public BooleanValue ShowMemberPropertyTips { get; set; }
    /// <summary>
    /// <para> showDataTips.</para>
    /// <para>Represents the following attribute in the schema: showDataTips </para>
    /// </summary>
    [SchemaAttr(0, "showDataTips")]
    [Index(34)]
    public BooleanValue ShowDataTips { get; set; }
    /// <summary>
    /// <para> enableWizard.</para>
    /// <para>Represents the following attribute in the schema: enableWizard </para>
    /// </summary>
    [SchemaAttr(0, "enableWizard")]
    [Index(35)]
    public BooleanValue EnableWizard { get; set; }
    /// <summary>
    /// <para> enableDrill.</para>
    /// <para>Represents the following attribute in the schema: enableDrill </para>
    /// </summary>
    [SchemaAttr(0, "enableDrill")]
    [Index(36)]
    public BooleanValue EnableDrill { get; set; }
    /// <summary>
    /// <para> enableFieldProperties.</para>
    /// <para>Represents the following attribute in the schema: enableFieldProperties </para>
    /// </summary>
    [SchemaAttr(0, "enableFieldProperties")]
    [Index(37)]
    public BooleanValue EnableFieldProperties { get; set; }
    /// <summary>
    /// <para> preserveFormatting.</para>
    /// <para>Represents the following attribute in the schema: preserveFormatting </para>
    /// </summary>
    [SchemaAttr(0, "preserveFormatting")]
    [Index(38)]
    public BooleanValue PreserveFormatting { get; set; }
    /// <summary>
    /// <para> useAutoFormatting.</para>
    /// <para>Represents the following attribute in the schema: useAutoFormatting </para>
    /// </summary>
    [SchemaAttr(0, "useAutoFormatting")]
    [Index(39)]
    public BooleanValue UseAutoFormatting { get; set; }
    /// <summary>
    /// <para> pageWrap.</para>
    /// <para>Represents the following attribute in the schema: pageWrap </para>
    /// </summary>
    [SchemaAttr(0, "pageWrap")]
    [Index(40)]
    public UInt32Value PageWrap { get; set; }
    /// <summary>
    /// <para> pageOverThenDown.</para>
    /// <para>Represents the following attribute in the schema: pageOverThenDown </para>
    /// </summary>
    [SchemaAttr(0, "pageOverThenDown")]
    [Index(41)]
    public BooleanValue PageOverThenDown { get; set; }
    /// <summary>
    /// <para> subtotalHiddenItems.</para>
    /// <para>Represents the following attribute in the schema: subtotalHiddenItems </para>
    /// </summary>
    [SchemaAttr(0, "subtotalHiddenItems")]
    [Index(42)]
    public BooleanValue SubtotalHiddenItems { get; set; }
    /// <summary>
    /// <para> rowGrandTotals.</para>
    /// <para>Represents the following attribute in the schema: rowGrandTotals </para>
    /// </summary>
    [SchemaAttr(0, "rowGrandTotals")]
    [Index(43)]
    public BooleanValue RowGrandTotals { get; set; }
    /// <summary>
    /// <para> colGrandTotals.</para>
    /// <para>Represents the following attribute in the schema: colGrandTotals </para>
    /// </summary>
    [SchemaAttr(0, "colGrandTotals")]
    [Index(44)]
    public BooleanValue ColumnGrandTotals { get; set; }
    /// <summary>
    /// <para> fieldPrintTitles.</para>
    /// <para>Represents the following attribute in the schema: fieldPrintTitles </para>
    /// </summary>
    [SchemaAttr(0, "fieldPrintTitles")]
    [Index(45)]
    public BooleanValue FieldPrintTitles { get; set; }
    /// <summary>
    /// <para> itemPrintTitles.</para>
    /// <para>Represents the following attribute in the schema: itemPrintTitles </para>
    /// </summary>
    [SchemaAttr(0, "itemPrintTitles")]
    [Index(46)]
    public BooleanValue ItemPrintTitles { get; set; }
    /// <summary>
    /// <para> mergeItem.</para>
    /// <para>Represents the following attribute in the schema: mergeItem </para>
    /// </summary>
    [SchemaAttr(0, "mergeItem")]
    [Index(47)]
    public BooleanValue MergeItem { get; set; }
    /// <summary>
    /// <para> showDropZones.</para>
    /// <para>Represents the following attribute in the schema: showDropZones </para>
    /// </summary>
    [SchemaAttr(0, "showDropZones")]
    [Index(48)]
    public BooleanValue ShowDropZones { get; set; }
    /// <summary>
    /// <para> createdVersion.</para>
    /// <para>Represents the following attribute in the schema: createdVersion </para>
    /// </summary>
    [SchemaAttr(0, "createdVersion")]
    [Index(49)]
    public ByteValue CreatedVersion { get; set; }
    /// <summary>
    /// <para> indent.</para>
    /// <para>Represents the following attribute in the schema: indent </para>
    /// </summary>
    [SchemaAttr(0, "indent")]
    [Index(50)]
    public UInt32Value Indent { get; set; }
    /// <summary>
    /// <para> showEmptyRow.</para>
    /// <para>Represents the following attribute in the schema: showEmptyRow </para>
    /// </summary>
    [SchemaAttr(0, "showEmptyRow")]
    [Index(51)]
    public BooleanValue ShowEmptyRow { get; set; }
    /// <summary>
    /// <para> showEmptyCol.</para>
    /// <para>Represents the following attribute in the schema: showEmptyCol </para>
    /// </summary>
    [SchemaAttr(0, "showEmptyCol")]
    [Index(52)]
    public BooleanValue ShowEmptyColumn { get; set; }
    /// <summary>
    /// <para> showHeaders.</para>
    /// <para>Represents the following attribute in the schema: showHeaders </para>
    /// </summary>
    [SchemaAttr(0, "showHeaders")]
    [Index(53)]
    public BooleanValue ShowHeaders { get; set; }
    /// <summary>
    /// <para> compact.</para>
    /// <para>Represents the following attribute in the schema: compact </para>
    /// </summary>
    [SchemaAttr(0, "compact")]
    [Index(54)]
    public BooleanValue Compact { get; set; }
    /// <summary>
    /// <para> outline.</para>
    /// <para>Represents the following attribute in the schema: outline </para>
    /// </summary>
    [SchemaAttr(0, "outline")]
    [Index(55)]
    public BooleanValue Outline { get; set; }
    /// <summary>
    /// <para> outlineData.</para>
    /// <para>Represents the following attribute in the schema: outlineData </para>
    /// </summary>
    [SchemaAttr(0, "outlineData")]
    [Index(56)]
    public BooleanValue OutlineData { get; set; }
    /// <summary>
    /// <para> compactData.</para>
    /// <para>Represents the following attribute in the schema: compactData </para>
    /// </summary>
    [SchemaAttr(0, "compactData")]
    [Index(57)]
    public BooleanValue CompactData { get; set; }
    /// <summary>
    /// <para> published.</para>
    /// <para>Represents the following attribute in the schema: published </para>
    /// </summary>
    [SchemaAttr(0, "published")]
    [Index(58)]
    public BooleanValue Published { get; set; }
    /// <summary>
    /// <para> gridDropZones.</para>
    /// <para>Represents the following attribute in the schema: gridDropZones </para>
    /// </summary>
    [SchemaAttr(0, "gridDropZones")]
    [Index(59)]
    public BooleanValue GridDropZones { get; set; }
    /// <summary>
    /// <para> immersive.</para>
    /// <para>Represents the following attribute in the schema: immersive </para>
    /// </summary>
    [SchemaAttr(0, "immersive")]
    [Index(60)]
    public BooleanValue StopImmersiveUi { get; set; }
    /// <summary>
    /// <para> multipleFieldFilters.</para>
    /// <para>Represents the following attribute in the schema: multipleFieldFilters </para>
    /// </summary>
    [SchemaAttr(0, "multipleFieldFilters")]
    [Index(61)]
    public BooleanValue MultipleFieldFilters { get; set; }
    /// <summary>
    /// <para> chartFormat.</para>
    /// <para>Represents the following attribute in the schema: chartFormat </para>
    /// </summary>
    [SchemaAttr(0, "chartFormat")]
    [Index(62)]
    public UInt32Value ChartFormat { get; set; }
    /// <summary>
    /// <para> rowHeaderCaption.</para>
    /// <para>Represents the following attribute in the schema: rowHeaderCaption </para>
    /// </summary>
    [SchemaAttr(0, "rowHeaderCaption")]
    [Index(63)]
    public StringValue RowHeaderCaption { get; set; }
    /// <summary>
    /// <para> colHeaderCaption.</para>
    /// <para>Represents the following attribute in the schema: colHeaderCaption </para>
    /// </summary>
    [SchemaAttr(0, "colHeaderCaption")]
    [Index(64)]
    public StringValue ColumnHeaderCaption { get; set; }
    /// <summary>
    /// <para> fieldListSortAscending.</para>
    /// <para>Represents the following attribute in the schema: fieldListSortAscending </para>
    /// </summary>
    [SchemaAttr(0, "fieldListSortAscending")]
    [Index(65)]
    public BooleanValue FieldListSortAscending { get; set; }
    /// <summary>
    /// <para> mdxSubqueries.</para>
    /// <para>Represents the following attribute in the schema: mdxSubqueries </para>
    /// </summary>
    [SchemaAttr(0, "mdxSubqueries")]
    [Index(66)]
    public BooleanValue MdxSubqueries { get; set; }
    /// <summary>
    /// <para> customListSort.</para>
    /// <para>Represents the following attribute in the schema: customListSort </para>
    /// </summary>
    [SchemaAttr(0, "customListSort")]
    [Index(67)]
    public BooleanValue CustomListSort { get; set; }

    /// <summary>
    /// Initializes a new instance of the pivotTableDefinition class.
    /// </summary>
    public pivotTableDefinition():base(){}
        /// <summary>
    ///Initializes a new instance of the pivotTableDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public pivotTableDefinition(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public pivotTableDefinition(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Location.</para>
    /// <para> Represents the following element tag in the schema: x:location </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Spreadsheet.Location Location
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Location>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> PivotFields.</para>
    /// <para> Represents the following element tag in the schema: x:pivotFields </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Spreadsheet.PivotFields PivotFields
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotFields>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> RowFields.</para>
    /// <para> Represents the following element tag in the schema: x:rowFields </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Spreadsheet.RowFields RowFields
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.RowFields>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> RowItems.</para>
    /// <para> Represents the following element tag in the schema: x:rowItems </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Spreadsheet.RowItems RowItems
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.RowItems>(3);
        set => SetElement(3, value);
	}
    /// <summary>
    /// <para> ColumnFields.</para>
    /// <para> Represents the following element tag in the schema: x:colFields </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Spreadsheet.ColumnFields ColumnFields
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ColumnFields>(4);
        set => SetElement(4, value);
	}
    /// <summary>
    /// <para> ColumnItems.</para>
    /// <para> Represents the following element tag in the schema: x:colItems </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(5)]
    public DocumentFormat.OpenXml.Spreadsheet.ColumnItems ColumnItems
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ColumnItems>(5);
        set => SetElement(5, value);
	}
    /// <summary>
    /// <para> PageFields.</para>
    /// <para> Represents the following element tag in the schema: x:pageFields </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(6)]
    public DocumentFormat.OpenXml.Spreadsheet.PageFields PageFields
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PageFields>(6);
        set => SetElement(6, value);
	}
    /// <summary>
    /// <para> DataFields.</para>
    /// <para> Represents the following element tag in the schema: x:dataFields </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(7)]
    public DocumentFormat.OpenXml.Spreadsheet.DataFields DataFields
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.DataFields>(7);
        set => SetElement(7, value);
	}
    /// <summary>
    /// <para> Formats.</para>
    /// <para> Represents the following element tag in the schema: x:formats </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(8)]
    public DocumentFormat.OpenXml.Spreadsheet.Formats Formats
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Formats>(8);
        set => SetElement(8, value);
	}
    /// <summary>
    /// <para> ConditionalFormats.</para>
    /// <para> Represents the following element tag in the schema: x:conditionalFormats </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(9)]
    public DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats ConditionalFormats
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats>(9);
        set => SetElement(9, value);
	}
    /// <summary>
    /// <para> ChartFormats.</para>
    /// <para> Represents the following element tag in the schema: x:chartFormats </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(10)]
    public DocumentFormat.OpenXml.Spreadsheet.ChartFormats ChartFormats
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ChartFormats>(10);
        set => SetElement(10, value);
	}
    /// <summary>
    /// <para> PivotHierarchies.</para>
    /// <para> Represents the following element tag in the schema: x:pivotHierarchies </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(11)]
    public DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies PivotHierarchies
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies>(11);
        set => SetElement(11, value);
	}
    /// <summary>
    /// <para> PivotTableStyle.</para>
    /// <para> Represents the following element tag in the schema: x:pivotTableStyleInfo </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(12)]
    public DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle PivotTableStyle
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle>(12);
        set => SetElement(12, value);
	}
    /// <summary>
    /// <para> PivotFilters.</para>
    /// <para> Represents the following element tag in the schema: x:filters </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(13)]
    public DocumentFormat.OpenXml.Spreadsheet.PivotFilters PivotFilters
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotFilters>(13);
        set => SetElement(13, value);
	}
    /// <summary>
    /// <para> RowHierarchiesUsage.</para>
    /// <para> Represents the following element tag in the schema: x:rowHierarchiesUsage </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(14)]
    public DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage RowHierarchiesUsage
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage>(14);
        set => SetElement(14, value);
	}
    /// <summary>
    /// <para> ColumnHierarchiesUsage.</para>
    /// <para> Represents the following element tag in the schema: x:colHierarchiesUsage </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(15)]
    public DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage ColumnHierarchiesUsage
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage>(15);
        set => SetElement(15, value);
	}
    /// <summary>
    /// <para> PivotTableDefinitionExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(16)]
    public DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList PivotTableDefinitionExtensionList
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList>(16);
        set => SetElement(16, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<pivotTableDefinition>(deep);

}
/// <summary>
/// Defines the RevisionContext enumeration.
/// </summary>
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
