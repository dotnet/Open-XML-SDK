// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExHeaders : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13540;
    /// <inheritdoc/>
    public override string LocalName => "revHdrs";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "minRev"),
		AttributeTag.Create<UInt64Value>(0, "maxRev"),
		AttributeTag.Create<StringValue>(0, "docId"),
		AttributeTag.Create<StringValue>(0, "endpointId")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> minRev.</para>
    /// <para>Represents the following attribute in the schema: minRev </para>
    /// </summary>
    [SchemaAttr(0, "minRev")]
    public UInt64Value MinRev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> maxRev.</para>
    /// <para>Represents the following attribute in the schema: maxRev </para>
    /// </summary>
    [SchemaAttr(0, "maxRev")]
    public UInt64Value MaxRev
    {
        get { return (UInt64Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> docId.</para>
    /// <para>Represents the following attribute in the schema: docId </para>
    /// </summary>
    [SchemaAttr(0, "docId")]
    public StringValue DocId
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> endpointId.</para>
    /// <para>Represents the following attribute in the schema: endpointId </para>
    /// </summary>
    [SchemaAttr(0, "endpointId")]
    public StringValue EndpointId
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "hdr" == name)
    return new RevExHeader();
    

    return null;
}

    
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExStream : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13541;
    /// <inheritdoc/>
    public override string LocalName => "revStream";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "xrrftr" == name)
    return new RevExFuture();
    
if( 83 == namespaceId && "xrrUspt" == name)
    return new RevExUnsupported();
    
if( 83 == namespaceId && "xrrTrim" == name)
    return new RevExTrimmed();
    
if( 83 == namespaceId && "xrrrc" == name)
    return new RevExRowColumn();
    
if( 83 == namespaceId && "xrrm" == name)
    return new RevExMove();
    
if( 83 == namespaceId && "xrrc" == name)
    return new RevExChangeCell();
    
if( 83 == namespaceId && "xrrf" == name)
    return new RevExFormatting();
    
if( 83 == namespaceId && "xrrDefName" == name)
    return new RevExDefinedName();
    
if( 83 == namespaceId && "xrrdo" == name)
    return new RevExDelObj();
    
if( 83 == namespaceId && "xrrco" == name)
    return new RevExChgObj();
    
if( 83 == namespaceId && "xrrSheet" == name)
    return new RevExSheetOp();
    
if( 83 == namespaceId && "xrrList" == name)
    return new RevisionList();
    
if( 83 == namespaceId && "xrrListExpR" == name)
    return new RevListAutoExpandRw();
    
if( 83 == namespaceId && "xrrg" == name)
    return new RevGroup();
    

    return null;
}

    
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class DifferentialFormatType : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13542;
    /// <inheritdoc/>
    public override string LocalName => "dxf";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "font" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Font();
    
if( 22 == namespaceId && "numFmt" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.NumberingFormat();
    
if( 22 == namespaceId && "fill" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Fill();
    
if( 22 == namespaceId && "alignment" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Alignment();
    
if( 22 == namespaceId && "border" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Border();
    
if( 22 == namespaceId && "protection" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Protection();
    
if( 22 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "font","numFmt","fill","alignment","border","protection","extLst" };
    private static readonly byte[] eleNamespaceIds = { 22,22,22,22,22,22,22 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Font Properties.</para>
    /// <para> Represents the following element tag in the schema: x:font </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevisionPtr : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13543;
    /// <inheritdoc/>
    public override string LocalName => "revisionPtr";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "revIDLastSave"),
		AttributeTag.Create<StringValue>(0, "documentId")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> revIDLastSave.</para>
    /// <para>Represents the following attribute in the schema: revIDLastSave </para>
    /// </summary>
    [SchemaAttr(0, "revIDLastSave")]
    public UInt64Value RevIDLastSave
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> documentId.</para>
    /// <para>Represents the following attribute in the schema: documentId </para>
    /// </summary>
    [SchemaAttr(0, "documentId")]
    public StringValue DocumentId
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class StateBasedObject : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13544;
    /// <inheritdoc/>
    public override string LocalName => "objectState";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "dataValidation" == name)
    return new DataValidation();
    
if( 83 == namespaceId && "hyperlink" == name)
    return new Hyperlink();
    
if( 83 == namespaceId && "sparklineGroup" == name)
    return new SparklineGroup();
    
if( 83 == namespaceId && "comments" == name)
    return new Comments();
    
if( 83 == namespaceId && "autoFilter" == name)
    return new AutoFilter();
    
if( 83 == namespaceId && "pivotTableDefinition" == name)
    return new pivotTableDefinition();
    

    return null;
}

        private static readonly string[] eleTagNames = { "dataValidation","hyperlink","sparklineGroup","comments","autoFilter","pivotTableDefinition" };
    private static readonly byte[] eleNamespaceIds = { 83,83,83,83,83,83 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Represents an external link to another workbook..</para>
    /// <para> Represents the following element tag in the schema: xr:dataValidation </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExHeader : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13545;
    /// <inheritdoc/>
    public override string LocalName => "hdr";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(19, "id"),
		AttributeTag.Create<UInt64Value>(0, "minRev"),
		AttributeTag.Create<UInt64Value>(0, "maxRev"),
		AttributeTag.Create<DateTimeValue>(0, "time")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> minRev.</para>
    /// <para>Represents the following attribute in the schema: minRev </para>
    /// </summary>
    [SchemaAttr(0, "minRev")]
    public UInt64Value MinRev
    {
        get { return (UInt64Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> maxRev.</para>
    /// <para>Represents the following attribute in the schema: maxRev </para>
    /// </summary>
    [SchemaAttr(0, "maxRev")]
    public UInt64Value MaxRev
    {
        get { return (UInt64Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> time.</para>
    /// <para>Represents the following attribute in the schema: time </para>
    /// </summary>
    [SchemaAttr(0, "time")]
    public DateTimeValue Time
    {
        get { return (DateTimeValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExFuture : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13546;
    /// <inheritdoc/>
    public override string LocalName => "xrrftr";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx"),
		AttributeTag.Create<BooleanValue>(0, "sti")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> sti.</para>
    /// <para>Represents the following attribute in the schema: sti </para>
    /// </summary>
    [SchemaAttr(0, "sti")]
    public BooleanValue Sti
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "xrrtest" == name)
    return new RevExTest();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExFuture>(deep);

}
/// <summary>
/// <para>Defines the RevExUnsupported Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrUspt.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExUnsupported : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13547;
    /// <inheritdoc/>
    public override string LocalName => "xrrUspt";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExTrimmed : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13548;
    /// <inheritdoc/>
    public override string LocalName => "xrrTrim";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExRowColumn : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13549;
    /// <inheritdoc/>
    public override string LocalName => "xrrrc";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx"),
		AttributeTag.Create<BooleanValue>(0, "eol"),
		AttributeTag.Create<StringValue>(0, "ref"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RwColAction>>(0, "action")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> eol.</para>
    /// <para>Represents the following attribute in the schema: eol </para>
    /// </summary>
    [SchemaAttr(0, "eol")]
    public BooleanValue Eol
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> ref.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Ref
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> action.</para>
    /// <para>Represents the following attribute in the schema: action </para>
    /// </summary>
    [SchemaAttr(0, "action")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RwColAction> Action
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RwColAction>)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExMove : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13550;
    /// <inheritdoc/>
    public override string LocalName => "xrrm";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx"),
		AttributeTag.Create<StringValue>(0, "src"),
		AttributeTag.Create<StringValue>(0, "dst"),
		AttributeTag.Create<StringValue>(0, "srcSh")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> src.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
    public StringValue Src
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> dst.</para>
    /// <para>Represents the following attribute in the schema: dst </para>
    /// </summary>
    [SchemaAttr(0, "dst")]
    public StringValue Dst
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> srcSh.</para>
    /// <para>Represents the following attribute in the schema: srcSh </para>
    /// </summary>
    [SchemaAttr(0, "srcSh")]
    public StringValue SrcSh
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    

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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExChangeCell : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13551;
    /// <inheritdoc/>
    public override string LocalName => "xrrc";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "listUid"),
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx"),
		AttributeTag.Create<StringValue>(0, "r"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>>(0, "t"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>>(0, "x"),
		AttributeTag.Create<UInt32Value>(0, "w")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> listUid.</para>
    /// <para>Represents the following attribute in the schema: listUid </para>
    /// </summary>
    [SchemaAttr(0, "listUid")]
    public StringValue ListUid
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public StringValue R
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType> T
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> x.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
    [SchemaAttr(0, "x")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt> X
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> w.</para>
    /// <para>Represents the following attribute in the schema: w </para>
    /// </summary>
    [SchemaAttr(0, "w")]
    public UInt32Value W
    {
        get { return (UInt32Value)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "c" == name)
    return new RevCell();
    
if( 83 == namespaceId && "ccse" == name)
    return new ChangeCellSubEdit();
    

    return null;
}

    
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExFormatting : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13552;
    /// <inheritdoc/>
    public override string LocalName => "xrrf";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx"),
		AttributeTag.Create<UInt32Value>(0, "numFmtId"),
		AttributeTag.Create<BooleanValue>(0, "xfDxf"),
		AttributeTag.Create<BooleanValue>(0, "style"),
		AttributeTag.Create<ListValue<StringValue>>(0, "sqref"),
		AttributeTag.Create<UInt32Value>(0, "start"),
		AttributeTag.Create<UInt32Value>(0, "length"),
		AttributeTag.Create<StringValue>(0, "styleUid"),
		AttributeTag.Create<BooleanValue>(0, "fBlankCell"),
		AttributeTag.Create<BooleanValue>(0, "applyNumberFormat"),
		AttributeTag.Create<BooleanValue>(0, "applyFont"),
		AttributeTag.Create<BooleanValue>(0, "applyFill"),
		AttributeTag.Create<BooleanValue>(0, "applyBorder"),
		AttributeTag.Create<BooleanValue>(0, "applyAlignment"),
		AttributeTag.Create<BooleanValue>(0, "applyProtection")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> numFmtId.</para>
    /// <para>Represents the following attribute in the schema: numFmtId </para>
    /// </summary>
    [SchemaAttr(0, "numFmtId")]
    public UInt32Value NumFmtId
    {
        get { return (UInt32Value)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> xfDxf.</para>
    /// <para>Represents the following attribute in the schema: xfDxf </para>
    /// </summary>
    [SchemaAttr(0, "xfDxf")]
    public BooleanValue XfDxf
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public BooleanValue Style
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> sqref.</para>
    /// <para>Represents the following attribute in the schema: sqref </para>
    /// </summary>
    [SchemaAttr(0, "sqref")]
    public ListValue<StringValue> Sqref
    {
        get { return (ListValue<StringValue>)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> start.</para>
    /// <para>Represents the following attribute in the schema: start </para>
    /// </summary>
    [SchemaAttr(0, "start")]
    public UInt32Value Start
    {
        get { return (UInt32Value)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> length.</para>
    /// <para>Represents the following attribute in the schema: length </para>
    /// </summary>
    [SchemaAttr(0, "length")]
    public UInt32Value Length
    {
        get { return (UInt32Value)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> styleUid.</para>
    /// <para>Represents the following attribute in the schema: styleUid </para>
    /// </summary>
    [SchemaAttr(0, "styleUid")]
    public StringValue StyleUid
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> fBlankCell.</para>
    /// <para>Represents the following attribute in the schema: fBlankCell </para>
    /// </summary>
    [SchemaAttr(0, "fBlankCell")]
    public BooleanValue FBlankCell
    {
        get { return (BooleanValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> applyNumberFormat.</para>
    /// <para>Represents the following attribute in the schema: applyNumberFormat </para>
    /// </summary>
    [SchemaAttr(0, "applyNumberFormat")]
    public BooleanValue ApplyNumberFormat
    {
        get { return (BooleanValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> applyFont.</para>
    /// <para>Represents the following attribute in the schema: applyFont </para>
    /// </summary>
    [SchemaAttr(0, "applyFont")]
    public BooleanValue ApplyFont
    {
        get { return (BooleanValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> applyFill.</para>
    /// <para>Represents the following attribute in the schema: applyFill </para>
    /// </summary>
    [SchemaAttr(0, "applyFill")]
    public BooleanValue ApplyFill
    {
        get { return (BooleanValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> applyBorder.</para>
    /// <para>Represents the following attribute in the schema: applyBorder </para>
    /// </summary>
    [SchemaAttr(0, "applyBorder")]
    public BooleanValue ApplyBorder
    {
        get { return (BooleanValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> applyAlignment.</para>
    /// <para>Represents the following attribute in the schema: applyAlignment </para>
    /// </summary>
    [SchemaAttr(0, "applyAlignment")]
    public BooleanValue ApplyAlignment
    {
        get { return (BooleanValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> applyProtection.</para>
    /// <para>Represents the following attribute in the schema: applyProtection </para>
    /// </summary>
    [SchemaAttr(0, "applyProtection")]
    public BooleanValue ApplyProtection
    {
        get { return (BooleanValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "dxf" == name)
    return new DifferentialFormatType();
    
if( 83 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "dxf","extLst" };
    private static readonly byte[] eleNamespaceIds = { 83,83 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> DifferentialFormatType.</para>
    /// <para> Represents the following element tag in the schema: xr:dxf </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExDefinedName : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13553;
    /// <inheritdoc/>
    public override string LocalName => "xrrDefName";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx"),
		AttributeTag.Create<BooleanValue>(0, "customView"),
		AttributeTag.Create<StringValue>(0, "name"),
		AttributeTag.Create<BooleanValue>(0, "function"),
		AttributeTag.Create<ByteValue>(0, "functionGroupId"),
		AttributeTag.Create<ByteValue>(0, "shortcutKey"),
		AttributeTag.Create<BooleanValue>(0, "hidden"),
		AttributeTag.Create<StringValue>(0, "customMenu"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "help"),
		AttributeTag.Create<StringValue>(0, "statusBar"),
		AttributeTag.Create<StringValue>(0, "comment")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> customView.</para>
    /// <para>Represents the following attribute in the schema: customView </para>
    /// </summary>
    [SchemaAttr(0, "customView")]
    public BooleanValue CustomView
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> function.</para>
    /// <para>Represents the following attribute in the schema: function </para>
    /// </summary>
    [SchemaAttr(0, "function")]
    public BooleanValue Function
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> functionGroupId.</para>
    /// <para>Represents the following attribute in the schema: functionGroupId </para>
    /// </summary>
    [SchemaAttr(0, "functionGroupId")]
    public ByteValue FunctionGroupId
    {
        get { return (ByteValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> shortcutKey.</para>
    /// <para>Represents the following attribute in the schema: shortcutKey </para>
    /// </summary>
    [SchemaAttr(0, "shortcutKey")]
    public ByteValue ShortcutKey
    {
        get { return (ByteValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
    {
        get { return (BooleanValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> customMenu.</para>
    /// <para>Represents the following attribute in the schema: customMenu </para>
    /// </summary>
    [SchemaAttr(0, "customMenu")]
    public StringValue CustomMenu
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> help.</para>
    /// <para>Represents the following attribute in the schema: help </para>
    /// </summary>
    [SchemaAttr(0, "help")]
    public StringValue Help
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> statusBar.</para>
    /// <para>Represents the following attribute in the schema: statusBar </para>
    /// </summary>
    [SchemaAttr(0, "statusBar")]
    public StringValue StatusBar
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> comment.</para>
    /// <para>Represents the following attribute in the schema: comment </para>
    /// </summary>
    [SchemaAttr(0, "comment")]
    public StringValue Comment
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "formula" == name)
    return new FormulaFormula();
    
if( 83 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "formula","extLst" };
    private static readonly byte[] eleNamespaceIds = { 83,83 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> FormulaFormula.</para>
    /// <para> Represents the following element tag in the schema: xr:formula </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExDelObj : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13554;
    /// <inheritdoc/>
    public override string LocalName => "xrrdo";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "hdr" == name)
    return new StateBasedHeader();
    

    return null;
}

        private static readonly string[] eleTagNames = { "hdr" };
    private static readonly byte[] eleNamespaceIds = { 83 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> StateBasedHeader.</para>
    /// <para> Represents the following element tag in the schema: xr:hdr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExChgObj : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13555;
    /// <inheritdoc/>
    public override string LocalName => "xrrco";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "hdr" == name)
    return new StateBasedHeader();
    
if( 83 == namespaceId && "link" == name)
    return new RevisionStateLink();
    
if( 83 == namespaceId && "body" == name)
    return new RevisionState();
    

    return null;
}

        private static readonly string[] eleTagNames = { "hdr","link","body" };
    private static readonly byte[] eleNamespaceIds = { 83,83,83 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> StateBasedHeader.</para>
    /// <para> Represents the following element tag in the schema: xr:hdr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExSheetOp : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13556;
    /// <inheritdoc/>
    public override string LocalName => "xrrSheet";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SheetOp>>(0, "op"),
		AttributeTag.Create<StringValue>(0, "name"),
		AttributeTag.Create<UInt32Value>(0, "idOrig"),
		AttributeTag.Create<UInt32Value>(0, "idNew")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> op.</para>
    /// <para>Represents the following attribute in the schema: op </para>
    /// </summary>
    [SchemaAttr(0, "op")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SheetOp> Op
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SheetOp>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> idOrig.</para>
    /// <para>Represents the following attribute in the schema: idOrig </para>
    /// </summary>
    [SchemaAttr(0, "idOrig")]
    public UInt32Value IdOrig
    {
        get { return (UInt32Value)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> idNew.</para>
    /// <para>Represents the following attribute in the schema: idNew </para>
    /// </summary>
    [SchemaAttr(0, "idNew")]
    public UInt32Value IdNew
    {
        get { return (UInt32Value)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevisionList : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13557;
    /// <inheritdoc/>
    public override string LocalName => "xrrList";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx"),
		AttributeTag.Create<BooleanValue>(0, "Data"),
		AttributeTag.Create<BooleanValue>(0, "Formatting"),
		AttributeTag.Create<BooleanValue>(0, "RangeBased"),
		AttributeTag.Create<BooleanValue>(0, "Fake"),
		AttributeTag.Create<StringValue>(0, "ref"),
		AttributeTag.Create<BooleanValue>(0, "Headers"),
		AttributeTag.Create<BooleanValue>(0, "InsDelHeaders"),
		AttributeTag.Create<UInt32Value>(0, "rId")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Data.</para>
    /// <para>Represents the following attribute in the schema: Data </para>
    /// </summary>
    [SchemaAttr(0, "Data")]
    public BooleanValue Data
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Formatting.</para>
    /// <para>Represents the following attribute in the schema: Formatting </para>
    /// </summary>
    [SchemaAttr(0, "Formatting")]
    public BooleanValue Formatting
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> RangeBased.</para>
    /// <para>Represents the following attribute in the schema: RangeBased </para>
    /// </summary>
    [SchemaAttr(0, "RangeBased")]
    public BooleanValue RangeBased
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Fake.</para>
    /// <para>Represents the following attribute in the schema: Fake </para>
    /// </summary>
    [SchemaAttr(0, "Fake")]
    public BooleanValue Fake
    {
        get { return (BooleanValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> ref.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Ref
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Headers.</para>
    /// <para>Represents the following attribute in the schema: Headers </para>
    /// </summary>
    [SchemaAttr(0, "Headers")]
    public BooleanValue Headers
    {
        get { return (BooleanValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> InsDelHeaders.</para>
    /// <para>Represents the following attribute in the schema: InsDelHeaders </para>
    /// </summary>
    [SchemaAttr(0, "InsDelHeaders")]
    public BooleanValue InsDelHeaders
    {
        get { return (BooleanValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> rId.</para>
    /// <para>Represents the following attribute in the schema: rId </para>
    /// </summary>
    [SchemaAttr(0, "rId")]
    public UInt32Value RId
    {
        get { return (UInt32Value)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevListAutoExpandRw : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13558;
    /// <inheritdoc/>
    public override string LocalName => "xrrListExpR";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx"),
		AttributeTag.Create<StringValue>(0, "refAdded"),
		AttributeTag.Create<StringValue>(0, "listGuid")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> refAdded.</para>
    /// <para>Represents the following attribute in the schema: refAdded </para>
    /// </summary>
    [SchemaAttr(0, "refAdded")]
    public StringValue RefAdded
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> listGuid.</para>
    /// <para>Represents the following attribute in the schema: listGuid </para>
    /// </summary>
    [SchemaAttr(0, "listGuid")]
    public StringValue ListGuid
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    

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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevGroup : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13559;
    /// <inheritdoc/>
    public override string LocalName => "xrrg";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt64Value>(0, "rev"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "sh"),
		AttributeTag.Create<StringValue>(0, "uidp"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>(0, "ctx")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "xrrftr" == name)
    return new RevExFuture();
    
if( 83 == namespaceId && "xrrUspt" == name)
    return new RevExUnsupported();
    
if( 83 == namespaceId && "xrrTrim" == name)
    return new RevExTrimmed();
    
if( 83 == namespaceId && "xrrrc" == name)
    return new RevExRowColumn();
    
if( 83 == namespaceId && "xrrm" == name)
    return new RevExMove();
    
if( 83 == namespaceId && "xrrc" == name)
    return new RevExChangeCell();
    
if( 83 == namespaceId && "xrrf" == name)
    return new RevExFormatting();
    
if( 83 == namespaceId && "xrrDefName" == name)
    return new RevExDefinedName();
    
if( 83 == namespaceId && "xrrdo" == name)
    return new RevExDelObj();
    
if( 83 == namespaceId && "xrrco" == name)
    return new RevExChgObj();
    
if( 83 == namespaceId && "xrrSheet" == name)
    return new RevExSheetOp();
    
if( 83 == namespaceId && "xrrList" == name)
    return new RevisionList();
    
if( 83 == namespaceId && "xrrListExpR" == name)
    return new RevListAutoExpandRw();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevGroup>(deep);

}
/// <summary>
/// <para>Defines the RevExTest Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrtest.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExTest : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13560;
    /// <inheritdoc/>
    public override string LocalName => "xrrtest";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

    
    
    
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevCell : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13561;
    /// <inheritdoc/>
    public override string LocalName => "c";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues>>(0, "t"),
		AttributeTag.Create<BooleanValue>(0, "nop"),
		AttributeTag.Create<BooleanValue>(0, "tick"),
		AttributeTag.Create<UInt32Value>(0, "rep")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues> T
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> nop.</para>
    /// <para>Represents the following attribute in the schema: nop </para>
    /// </summary>
    [SchemaAttr(0, "nop")]
    public BooleanValue Nop
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> tick.</para>
    /// <para>Represents the following attribute in the schema: tick </para>
    /// </summary>
    [SchemaAttr(0, "tick")]
    public BooleanValue Tick
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> rep.</para>
    /// <para>Represents the following attribute in the schema: rep </para>
    /// </summary>
    [SchemaAttr(0, "rep")]
    public UInt32Value Rep
    {
        get { return (UInt32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "f" == name)
    return new FFormula();
    
if( 83 == namespaceId && "v" == name)
    return new Xstring();
    
if( 83 == namespaceId && "is" == name)
    return new RstType();
    

    return null;
}

        private static readonly string[] eleTagNames = { "f","v","is" };
    private static readonly byte[] eleNamespaceIds = { 83,83,83 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> FFormula.</para>
    /// <para> Represents the following element tag in the schema: xr:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ChangeCellSubEdit : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13562;
    /// <inheritdoc/>
    public override string LocalName => "ccse";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "r"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>>(0, "t"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>>(0, "x"),
		AttributeTag.Create<UInt32Value>(0, "w")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public StringValue R
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType> T
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> x.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
    [SchemaAttr(0, "x")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt> X
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> w.</para>
    /// <para>Represents the following attribute in the schema: w </para>
    /// </summary>
    [SchemaAttr(0, "w")]
    public UInt32Value W
    {
        get { return (UInt32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "c" == name)
    return new RevCell();
    

    return null;
}

    
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13563;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Extension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);

}
/// <summary>
/// <para>Defines the FormulaFormula Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:formula.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class FormulaFormula : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13564;
    /// <inheritdoc/>
    public override string LocalName => "formula";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class FFormula : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13575;
    /// <inheritdoc/>
    public override string LocalName => "f";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class StateBasedHeader : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13565;
    /// <inheritdoc/>
    public override string LocalName => "hdr";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FeatureType>>(0, "eft"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtFeatureType>>(0, "eftx"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SubFeatureType>>(0, "seft"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtSubFeatureType>>(0, "seftx")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> eft.</para>
    /// <para>Represents the following attribute in the schema: eft </para>
    /// </summary>
    [SchemaAttr(0, "eft")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FeatureType> Eft
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FeatureType>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> eftx.</para>
    /// <para>Represents the following attribute in the schema: eftx </para>
    /// </summary>
    [SchemaAttr(0, "eftx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtFeatureType> Eftx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtFeatureType>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> seft.</para>
    /// <para>Represents the following attribute in the schema: seft </para>
    /// </summary>
    [SchemaAttr(0, "seft")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SubFeatureType> Seft
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SubFeatureType>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> seftx.</para>
    /// <para>Represents the following attribute in the schema: seftx </para>
    /// </summary>
    [SchemaAttr(0, "seftx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtSubFeatureType> Seftx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtSubFeatureType>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "refmap" == name)
    return new RefMap();
    

    return null;
}

        private static readonly string[] eleTagNames = { "refmap" };
    private static readonly byte[] eleNamespaceIds = { 83 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> RefMap.</para>
    /// <para> Represents the following element tag in the schema: xr:refmap </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevisionStateLink : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13566;
    /// <inheritdoc/>
    public override string LocalName => "link";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(19, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevisionState : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13567;
    /// <inheritdoc/>
    public override string LocalName => "body";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "rowColVisualOps" == name)
    return new RowColVisualOps();
    
if( 83 == namespaceId && "hideUnhideSheet" == name)
    return new HideUnhideSheet();
    
if( 83 == namespaceId && "showGridlinesHeadings" == name)
    return new ShowGridlinesHeadings();
    
if( 83 == namespaceId && "freezePanes" == name)
    return new FreezePanes();
    
if( 83 == namespaceId && "outlines" == name)
    return new Outlines();
    

    return null;
}

        private static readonly string[] eleTagNames = { "rowColVisualOps","hideUnhideSheet","showGridlinesHeadings","freezePanes","outlines" };
    private static readonly byte[] eleNamespaceIds = { 83,83,83,83,83 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> RowColVisualOps.</para>
    /// <para> Represents the following element tag in the schema: xr:rowColVisualOps </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RefMap : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13568;
    /// <inheritdoc/>
    public override string LocalName => "refmap";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "ref" == name)
    return new RefCell();
    
if( 83 == namespaceId && "sheetUid" == name)
    return new SheetXluid();
    
if( 83 == namespaceId && "oartAnchor" == name)
    return new RefOartAnchor();
    
if( 83 == namespaceId && "future" == name)
    return new RefFuture();
    
if( 83 == namespaceId && "test" == name)
    return new RefTest();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefMap>(deep);

}
/// <summary>
/// <para>Defines the RowColVisualOps Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:rowColVisualOps.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RowColVisualOps : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13569;
    /// <inheritdoc/>
    public override string LocalName => "rowColVisualOps";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOp>>(0, "action"),
		AttributeTag.Create<BooleanValue>(0, "isRow"),
		AttributeTag.Create<UInt32Value>(0, "size"),
		AttributeTag.Create<BooleanValue>(0, "userSized")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> action.</para>
    /// <para>Represents the following attribute in the schema: action </para>
    /// </summary>
    [SchemaAttr(0, "action")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOp> Action
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOp>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> isRow.</para>
    /// <para>Represents the following attribute in the schema: isRow </para>
    /// </summary>
    [SchemaAttr(0, "isRow")]
    public BooleanValue IsRow
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public UInt32Value Size
    {
        get { return (UInt32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> userSized.</para>
    /// <para>Represents the following attribute in the schema: userSized </para>
    /// </summary>
    [SchemaAttr(0, "userSized")]
    public BooleanValue UserSized
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class HideUnhideSheet : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13570;
    /// <inheritdoc/>
    public override string LocalName => "hideUnhideSheet";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "hide")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> hide.</para>
    /// <para>Represents the following attribute in the schema: hide </para>
    /// </summary>
    [SchemaAttr(0, "hide")]
    public BooleanValue Hide
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ShowGridlinesHeadings : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13571;
    /// <inheritdoc/>
    public override string LocalName => "showGridlinesHeadings";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "showGridLines"),
		AttributeTag.Create<BooleanValue>(0, "showRowCol")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> showGridLines.</para>
    /// <para>Represents the following attribute in the schema: showGridLines </para>
    /// </summary>
    [SchemaAttr(0, "showGridLines")]
    public BooleanValue ShowGridLines
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> showRowCol.</para>
    /// <para>Represents the following attribute in the schema: showRowCol </para>
    /// </summary>
    [SchemaAttr(0, "showRowCol")]
    public BooleanValue ShowRowCol
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class FreezePanes : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13572;
    /// <inheritdoc/>
    public override string LocalName => "freezePanes";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "sheetViewUid")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> sheetViewUid.</para>
    /// <para>Represents the following attribute in the schema: sheetViewUid </para>
    /// </summary>
    [SchemaAttr(0, "sheetViewUid")]
    public StringValue SheetViewUid
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Outlines : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13573;
    /// <inheritdoc/>
    public override string LocalName => "outlines";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "isRow")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> isRow.</para>
    /// <para>Represents the following attribute in the schema: isRow </para>
    /// </summary>
    [SchemaAttr(0, "isRow")]
    public BooleanValue IsRow
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 83 == namespaceId && "outline" == name)
    return new Outline();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Outlines>(deep);

}
/// <summary>
/// <para>Defines the Outline Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:outline.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Outline : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13574;
    /// <inheritdoc/>
    public override string LocalName => "outline";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "isCollapsed"),
		AttributeTag.Create<ByteValue>(0, "level")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> isCollapsed.</para>
    /// <para>Represents the following attribute in the schema: isCollapsed </para>
    /// </summary>
    [SchemaAttr(0, "isCollapsed")]
    public BooleanValue IsCollapsed
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> level.</para>
    /// <para>Represents the following attribute in the schema: level </para>
    /// </summary>
    [SchemaAttr(0, "level")]
    public ByteValue Level
    {
        get { return (ByteValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Xstring : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13576;
    /// <inheritdoc/>
    public override string LocalName => "v";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

    
    
    
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RstType : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13577;
    /// <inheritdoc/>
    public override string LocalName => "is";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "t" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Text();
    
if( 22 == namespaceId && "r" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Run();
    
if( 22 == namespaceId && "rPh" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PhoneticRun();
    
if( 22 == namespaceId && "phoneticPr" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "t","r","rPh","phoneticPr" };
    private static readonly byte[] eleNamespaceIds = { 22,22,22,22 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Text.</para>
    /// <para> Represents the following element tag in the schema: x:t </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RefCell : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13578;
    /// <inheritdoc/>
    public override string LocalName => "ref";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "n"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>>(0, "ajt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>>(0, "ajtx"),
		AttributeTag.Create<BooleanValue>(0, "homeRef"),
		AttributeTag.Create<ListValue<StringValue>>(0, "r"),
		AttributeTag.Create<StringValue>(0, "uid"),
		AttributeTag.Create<StringValue>(0, "uidLast")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> n.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
    [SchemaAttr(0, "n")]
    public StringValue N
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> ajt.</para>
    /// <para>Represents the following attribute in the schema: ajt </para>
    /// </summary>
    [SchemaAttr(0, "ajt")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> ajtx.</para>
    /// <para>Represents the following attribute in the schema: ajtx </para>
    /// </summary>
    [SchemaAttr(0, "ajtx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> homeRef.</para>
    /// <para>Represents the following attribute in the schema: homeRef </para>
    /// </summary>
    [SchemaAttr(0, "homeRef")]
    public BooleanValue HomeRef
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public ListValue<StringValue> R
    {
        get { return (ListValue<StringValue>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> uidLast.</para>
    /// <para>Represents the following attribute in the schema: uidLast </para>
    /// </summary>
    [SchemaAttr(0, "uidLast")]
    public StringValue UidLast
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class SheetXluid : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13579;
    /// <inheritdoc/>
    public override string LocalName => "sheetUid";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "n"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>>(0, "ajt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>>(0, "ajtx"),
		AttributeTag.Create<BooleanValue>(0, "homeRef"),
		AttributeTag.Create<StringValue>(0, "uid")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> n.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
    [SchemaAttr(0, "n")]
    public StringValue N
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> ajt.</para>
    /// <para>Represents the following attribute in the schema: ajt </para>
    /// </summary>
    [SchemaAttr(0, "ajt")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> ajtx.</para>
    /// <para>Represents the following attribute in the schema: ajtx </para>
    /// </summary>
    [SchemaAttr(0, "ajtx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> homeRef.</para>
    /// <para>Represents the following attribute in the schema: homeRef </para>
    /// </summary>
    [SchemaAttr(0, "homeRef")]
    public BooleanValue HomeRef
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RefOartAnchor : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13580;
    /// <inheritdoc/>
    public override string LocalName => "oartAnchor";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "n"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>>(0, "ajt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>>(0, "ajtx"),
		AttributeTag.Create<BooleanValue>(0, "homeRef"),
		AttributeTag.Create<StringValue>(0, "r"),
		AttributeTag.Create<Int64Value>(0, "fromRowOff"),
		AttributeTag.Create<Int64Value>(0, "fromColOff"),
		AttributeTag.Create<Int64Value>(0, "toRowOff"),
		AttributeTag.Create<Int64Value>(0, "toColOff"),
		AttributeTag.Create<Int64Value>(0, "cx"),
		AttributeTag.Create<Int64Value>(0, "cy"),
		AttributeTag.Create<Int64Value>(0, "x"),
		AttributeTag.Create<Int64Value>(0, "y"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.OartAnchorType>>(0, "oat")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> n.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
    [SchemaAttr(0, "n")]
    public StringValue N
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> ajt.</para>
    /// <para>Represents the following attribute in the schema: ajt </para>
    /// </summary>
    [SchemaAttr(0, "ajt")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> ajtx.</para>
    /// <para>Represents the following attribute in the schema: ajtx </para>
    /// </summary>
    [SchemaAttr(0, "ajtx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> homeRef.</para>
    /// <para>Represents the following attribute in the schema: homeRef </para>
    /// </summary>
    [SchemaAttr(0, "homeRef")]
    public BooleanValue HomeRef
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public StringValue R
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> fromRowOff.</para>
    /// <para>Represents the following attribute in the schema: fromRowOff </para>
    /// </summary>
    [SchemaAttr(0, "fromRowOff")]
    public Int64Value FromRowOff
    {
        get { return (Int64Value)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> fromColOff.</para>
    /// <para>Represents the following attribute in the schema: fromColOff </para>
    /// </summary>
    [SchemaAttr(0, "fromColOff")]
    public Int64Value FromColOff
    {
        get { return (Int64Value)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> toRowOff.</para>
    /// <para>Represents the following attribute in the schema: toRowOff </para>
    /// </summary>
    [SchemaAttr(0, "toRowOff")]
    public Int64Value ToRowOff
    {
        get { return (Int64Value)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> toColOff.</para>
    /// <para>Represents the following attribute in the schema: toColOff </para>
    /// </summary>
    [SchemaAttr(0, "toColOff")]
    public Int64Value ToColOff
    {
        get { return (Int64Value)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> cx.</para>
    /// <para>Represents the following attribute in the schema: cx </para>
    /// </summary>
    [SchemaAttr(0, "cx")]
    public Int64Value Cx
    {
        get { return (Int64Value)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> cy.</para>
    /// <para>Represents the following attribute in the schema: cy </para>
    /// </summary>
    [SchemaAttr(0, "cy")]
    public Int64Value Cy
    {
        get { return (Int64Value)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> x.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
    [SchemaAttr(0, "x")]
    public Int64Value X
    {
        get { return (Int64Value)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> y.</para>
    /// <para>Represents the following attribute in the schema: y </para>
    /// </summary>
    [SchemaAttr(0, "y")]
    public Int64Value Y
    {
        get { return (Int64Value)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> oat.</para>
    /// <para>Represents the following attribute in the schema: oat </para>
    /// </summary>
    [SchemaAttr(0, "oat")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.OartAnchorType> Oat
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.OartAnchorType>)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    

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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RefFuture : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13581;
    /// <inheritdoc/>
    public override string LocalName => "future";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

    
    
    
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RefTest : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13582;
    /// <inheritdoc/>
    public override string LocalName => "test";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "n"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>>(0, "ajt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>>(0, "ajtx"),
		AttributeTag.Create<BooleanValue>(0, "homeRef")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> n.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
    [SchemaAttr(0, "n")]
    public StringValue N
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> ajt.</para>
    /// <para>Represents the following attribute in the schema: ajt </para>
    /// </summary>
    [SchemaAttr(0, "ajt")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> ajtx.</para>
    /// <para>Represents the following attribute in the schema: ajtx </para>
    /// </summary>
    [SchemaAttr(0, "ajtx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> homeRef.</para>
    /// <para>Represents the following attribute in the schema: homeRef </para>
    /// </summary>
    [SchemaAttr(0, "homeRef")]
    public BooleanValue HomeRef
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class DataValidation : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13583;
    /// <inheritdoc/>
    public override string LocalName => "dataValidation";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues>>(0, "type"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues>>(0, "errorStyle"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues>>(0, "imeMode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues>>(0, "operator"),
		AttributeTag.Create<BooleanValue>(0, "allowBlank"),
		AttributeTag.Create<BooleanValue>(0, "showDropDown"),
		AttributeTag.Create<BooleanValue>(0, "showInputMessage"),
		AttributeTag.Create<BooleanValue>(0, "showErrorMessage"),
		AttributeTag.Create<StringValue>(0, "errorTitle"),
		AttributeTag.Create<StringValue>(0, "error"),
		AttributeTag.Create<StringValue>(0, "promptTitle"),
		AttributeTag.Create<StringValue>(0, "prompt"),
		AttributeTag.Create<ListValue<StringValue>>(0, "sqref")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> errorStyle.</para>
    /// <para>Represents the following attribute in the schema: errorStyle </para>
    /// </summary>
    [SchemaAttr(0, "errorStyle")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues> ErrorStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> imeMode.</para>
    /// <para>Represents the following attribute in the schema: imeMode </para>
    /// </summary>
    [SchemaAttr(0, "imeMode")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues> ImeMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> operator.</para>
    /// <para>Represents the following attribute in the schema: operator </para>
    /// </summary>
    [SchemaAttr(0, "operator")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues> Operator
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> allowBlank.</para>
    /// <para>Represents the following attribute in the schema: allowBlank </para>
    /// </summary>
    [SchemaAttr(0, "allowBlank")]
    public BooleanValue AllowBlank
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> showDropDown.</para>
    /// <para>Represents the following attribute in the schema: showDropDown </para>
    /// </summary>
    [SchemaAttr(0, "showDropDown")]
    public BooleanValue ShowDropDown
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> showInputMessage.</para>
    /// <para>Represents the following attribute in the schema: showInputMessage </para>
    /// </summary>
    [SchemaAttr(0, "showInputMessage")]
    public BooleanValue ShowInputMessage
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> showErrorMessage.</para>
    /// <para>Represents the following attribute in the schema: showErrorMessage </para>
    /// </summary>
    [SchemaAttr(0, "showErrorMessage")]
    public BooleanValue ShowErrorMessage
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> errorTitle.</para>
    /// <para>Represents the following attribute in the schema: errorTitle </para>
    /// </summary>
    [SchemaAttr(0, "errorTitle")]
    public StringValue ErrorTitle
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> error.</para>
    /// <para>Represents the following attribute in the schema: error </para>
    /// </summary>
    [SchemaAttr(0, "error")]
    public StringValue Error
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> promptTitle.</para>
    /// <para>Represents the following attribute in the schema: promptTitle </para>
    /// </summary>
    [SchemaAttr(0, "promptTitle")]
    public StringValue PromptTitle
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> prompt.</para>
    /// <para>Represents the following attribute in the schema: prompt </para>
    /// </summary>
    [SchemaAttr(0, "prompt")]
    public StringValue Prompt
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> sqref.</para>
    /// <para>Represents the following attribute in the schema: sqref </para>
    /// </summary>
    [SchemaAttr(0, "sqref")]
    public ListValue<StringValue> SequenceOfReferences
    {
        get { return (ListValue<StringValue>)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 72 == namespaceId && "list" == name)
    return new DocumentFormat.OpenXml.Office2010.ExcelAc.List();
    
if( 22 == namespaceId && "formula1" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Formula1();
    
if( 22 == namespaceId && "formula2" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Formula2();
    

    return null;
}

        private static readonly string[] eleTagNames = { "list","formula1","formula2" };
    private static readonly byte[] eleNamespaceIds = { 72,22,22 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> List.</para>
    /// <para> Represents the following element tag in the schema: x12ac:list </para>
    /// </summary>
    /// <remark>
    /// xmlns:x12ac = http://schemas.microsoft.com/office/spreadsheetml/2011/1/ac
    /// </remark>
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Hyperlink : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13584;
    /// <inheritdoc/>
    public override string LocalName => "hyperlink";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "ref"),
		AttributeTag.Create<StringValue>(19, "id"),
		AttributeTag.Create<StringValue>(0, "location"),
		AttributeTag.Create<StringValue>(0, "tooltip"),
		AttributeTag.Create<StringValue>(0, "display")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Reference.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Reference
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Relationship Id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Location.</para>
    /// <para>Represents the following attribute in the schema: location </para>
    /// </summary>
    [SchemaAttr(0, "location")]
    public StringValue Location
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Tool Tip.</para>
    /// <para>Represents the following attribute in the schema: tooltip </para>
    /// </summary>
    [SchemaAttr(0, "tooltip")]
    public StringValue Tooltip
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Display String.</para>
    /// <para>Represents the following attribute in the schema: display </para>
    /// </summary>
    [SchemaAttr(0, "display")]
    public StringValue Display
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class SparklineGroup : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13585;
    /// <inheritdoc/>
    public override string LocalName => "sparklineGroup";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<DoubleValue>(0, "manualMax"),
		AttributeTag.Create<DoubleValue>(0, "manualMin"),
		AttributeTag.Create<DoubleValue>(0, "lineWeight"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues>>(0, "type"),
		AttributeTag.Create<BooleanValue>(0, "dateAxis"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues>>(0, "displayEmptyCellsAs"),
		AttributeTag.Create<BooleanValue>(0, "markers"),
		AttributeTag.Create<BooleanValue>(0, "high"),
		AttributeTag.Create<BooleanValue>(0, "low"),
		AttributeTag.Create<BooleanValue>(0, "first"),
		AttributeTag.Create<BooleanValue>(0, "last"),
		AttributeTag.Create<BooleanValue>(0, "negative"),
		AttributeTag.Create<BooleanValue>(0, "displayXAxis"),
		AttributeTag.Create<BooleanValue>(0, "displayHidden"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>>(0, "minAxisType"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>>(0, "maxAxisType"),
		AttributeTag.Create<BooleanValue>(0, "rightToLeft")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> manualMax.</para>
    /// <para>Represents the following attribute in the schema: manualMax </para>
    /// </summary>
    [SchemaAttr(0, "manualMax")]
    public DoubleValue ManualMax
    {
        get { return (DoubleValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> manualMin.</para>
    /// <para>Represents the following attribute in the schema: manualMin </para>
    /// </summary>
    [SchemaAttr(0, "manualMin")]
    public DoubleValue ManualMin
    {
        get { return (DoubleValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> lineWeight.</para>
    /// <para>Represents the following attribute in the schema: lineWeight </para>
    /// </summary>
    [SchemaAttr(0, "lineWeight")]
    public DoubleValue LineWeight
    {
        get { return (DoubleValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> dateAxis.</para>
    /// <para>Represents the following attribute in the schema: dateAxis </para>
    /// </summary>
    [SchemaAttr(0, "dateAxis")]
    public BooleanValue DateAxis
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> displayEmptyCellsAs.</para>
    /// <para>Represents the following attribute in the schema: displayEmptyCellsAs </para>
    /// </summary>
    [SchemaAttr(0, "displayEmptyCellsAs")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues> DisplayEmptyCellsAs
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> markers.</para>
    /// <para>Represents the following attribute in the schema: markers </para>
    /// </summary>
    [SchemaAttr(0, "markers")]
    public BooleanValue Markers
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> high.</para>
    /// <para>Represents the following attribute in the schema: high </para>
    /// </summary>
    [SchemaAttr(0, "high")]
    public BooleanValue High
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> low.</para>
    /// <para>Represents the following attribute in the schema: low </para>
    /// </summary>
    [SchemaAttr(0, "low")]
    public BooleanValue Low
    {
        get { return (BooleanValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> first.</para>
    /// <para>Represents the following attribute in the schema: first </para>
    /// </summary>
    [SchemaAttr(0, "first")]
    public BooleanValue First
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> last.</para>
    /// <para>Represents the following attribute in the schema: last </para>
    /// </summary>
    [SchemaAttr(0, "last")]
    public BooleanValue Last
    {
        get { return (BooleanValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> negative.</para>
    /// <para>Represents the following attribute in the schema: negative </para>
    /// </summary>
    [SchemaAttr(0, "negative")]
    public BooleanValue Negative
    {
        get { return (BooleanValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> displayXAxis.</para>
    /// <para>Represents the following attribute in the schema: displayXAxis </para>
    /// </summary>
    [SchemaAttr(0, "displayXAxis")]
    public BooleanValue DisplayXAxis
    {
        get { return (BooleanValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> displayHidden.</para>
    /// <para>Represents the following attribute in the schema: displayHidden </para>
    /// </summary>
    [SchemaAttr(0, "displayHidden")]
    public BooleanValue DisplayHidden
    {
        get { return (BooleanValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> minAxisType.</para>
    /// <para>Represents the following attribute in the schema: minAxisType </para>
    /// </summary>
    [SchemaAttr(0, "minAxisType")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues> MinAxisType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> maxAxisType.</para>
    /// <para>Represents the following attribute in the schema: maxAxisType </para>
    /// </summary>
    [SchemaAttr(0, "maxAxisType")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues> MaxAxisType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> rightToLeft.</para>
    /// <para>Represents the following attribute in the schema: rightToLeft </para>
    /// </summary>
    [SchemaAttr(0, "rightToLeft")]
    public BooleanValue RightToLeft
    {
        get { return (BooleanValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "colorSeries" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.SeriesColor();
    
if( 53 == namespaceId && "colorNegative" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.NegativeColor();
    
if( 53 == namespaceId && "colorAxis" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.AxisColor();
    
if( 53 == namespaceId && "colorMarkers" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.MarkersColor();
    
if( 53 == namespaceId && "colorFirst" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor();
    
if( 53 == namespaceId && "colorLast" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor();
    
if( 53 == namespaceId && "colorHigh" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor();
    
if( 53 == namespaceId && "colorLow" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor();
    
if( 32 == namespaceId && "f" == name)
    return new DocumentFormat.OpenXml.Office.Excel.Formula();
    
if( 53 == namespaceId && "sparklines" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.Sparklines();
    

    return null;
}

        private static readonly string[] eleTagNames = { "colorSeries","colorNegative","colorAxis","colorMarkers","colorFirst","colorLast","colorHigh","colorLow","f","sparklines" };
    private static readonly byte[] eleNamespaceIds = { 53,53,53,53,53,53,53,53,32,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SeriesColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorSeries </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Comments : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13586;
    /// <inheritdoc/>
    public override string LocalName => "comments";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "authors" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Authors();
    
if( 22 == namespaceId && "commentList" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.CommentList();
    
if( 22 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "authors","commentList","extLst" };
    private static readonly byte[] eleNamespaceIds = { 22,22,22 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Authors.</para>
    /// <para> Represents the following element tag in the schema: x:authors </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class AutoFilter : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13587;
    /// <inheritdoc/>
    public override string LocalName => "autoFilter";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "ref")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Cell or Range Reference.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Reference
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "filterColumn" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.FilterColumn();
    
if( 22 == namespaceId && "sortState" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.SortState();
    
if( 22 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ExtensionList();
    

    return null;
}

    
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class pivotTableDefinition : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13588;
    /// <inheritdoc/>
    public override string LocalName => "pivotTableDefinition";
    
    internal override byte NamespaceId => 83;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "name"),
		AttributeTag.Create<UInt32Value>(0, "cacheId"),
		AttributeTag.Create<BooleanValue>(0, "dataOnRows"),
		AttributeTag.Create<UInt32Value>(0, "dataPosition"),
		AttributeTag.Create<UInt32Value>(0, "autoFormatId"),
		AttributeTag.Create<BooleanValue>(0, "applyNumberFormats"),
		AttributeTag.Create<BooleanValue>(0, "applyBorderFormats"),
		AttributeTag.Create<BooleanValue>(0, "applyFontFormats"),
		AttributeTag.Create<BooleanValue>(0, "applyPatternFormats"),
		AttributeTag.Create<BooleanValue>(0, "applyAlignmentFormats"),
		AttributeTag.Create<BooleanValue>(0, "applyWidthHeightFormats"),
		AttributeTag.Create<StringValue>(0, "dataCaption"),
		AttributeTag.Create<StringValue>(0, "grandTotalCaption"),
		AttributeTag.Create<StringValue>(0, "errorCaption"),
		AttributeTag.Create<BooleanValue>(0, "showError"),
		AttributeTag.Create<StringValue>(0, "missingCaption"),
		AttributeTag.Create<BooleanValue>(0, "showMissing"),
		AttributeTag.Create<StringValue>(0, "pageStyle"),
		AttributeTag.Create<StringValue>(0, "pivotTableStyle"),
		AttributeTag.Create<StringValue>(0, "vacatedStyle"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<ByteValue>(0, "updatedVersion"),
		AttributeTag.Create<ByteValue>(0, "minRefreshableVersion"),
		AttributeTag.Create<BooleanValue>(0, "asteriskTotals"),
		AttributeTag.Create<BooleanValue>(0, "showItems"),
		AttributeTag.Create<BooleanValue>(0, "editData"),
		AttributeTag.Create<BooleanValue>(0, "disableFieldList"),
		AttributeTag.Create<BooleanValue>(0, "showCalcMbrs"),
		AttributeTag.Create<BooleanValue>(0, "visualTotals"),
		AttributeTag.Create<BooleanValue>(0, "showMultipleLabel"),
		AttributeTag.Create<BooleanValue>(0, "showDataDropDown"),
		AttributeTag.Create<BooleanValue>(0, "showDrill"),
		AttributeTag.Create<BooleanValue>(0, "printDrill"),
		AttributeTag.Create<BooleanValue>(0, "showMemberPropertyTips"),
		AttributeTag.Create<BooleanValue>(0, "showDataTips"),
		AttributeTag.Create<BooleanValue>(0, "enableWizard"),
		AttributeTag.Create<BooleanValue>(0, "enableDrill"),
		AttributeTag.Create<BooleanValue>(0, "enableFieldProperties"),
		AttributeTag.Create<BooleanValue>(0, "preserveFormatting"),
		AttributeTag.Create<BooleanValue>(0, "useAutoFormatting"),
		AttributeTag.Create<UInt32Value>(0, "pageWrap"),
		AttributeTag.Create<BooleanValue>(0, "pageOverThenDown"),
		AttributeTag.Create<BooleanValue>(0, "subtotalHiddenItems"),
		AttributeTag.Create<BooleanValue>(0, "rowGrandTotals"),
		AttributeTag.Create<BooleanValue>(0, "colGrandTotals"),
		AttributeTag.Create<BooleanValue>(0, "fieldPrintTitles"),
		AttributeTag.Create<BooleanValue>(0, "itemPrintTitles"),
		AttributeTag.Create<BooleanValue>(0, "mergeItem"),
		AttributeTag.Create<BooleanValue>(0, "showDropZones"),
		AttributeTag.Create<ByteValue>(0, "createdVersion"),
		AttributeTag.Create<UInt32Value>(0, "indent"),
		AttributeTag.Create<BooleanValue>(0, "showEmptyRow"),
		AttributeTag.Create<BooleanValue>(0, "showEmptyCol"),
		AttributeTag.Create<BooleanValue>(0, "showHeaders"),
		AttributeTag.Create<BooleanValue>(0, "compact"),
		AttributeTag.Create<BooleanValue>(0, "outline"),
		AttributeTag.Create<BooleanValue>(0, "outlineData"),
		AttributeTag.Create<BooleanValue>(0, "compactData"),
		AttributeTag.Create<BooleanValue>(0, "published"),
		AttributeTag.Create<BooleanValue>(0, "gridDropZones"),
		AttributeTag.Create<BooleanValue>(0, "immersive"),
		AttributeTag.Create<BooleanValue>(0, "multipleFieldFilters"),
		AttributeTag.Create<UInt32Value>(0, "chartFormat"),
		AttributeTag.Create<StringValue>(0, "rowHeaderCaption"),
		AttributeTag.Create<StringValue>(0, "colHeaderCaption"),
		AttributeTag.Create<BooleanValue>(0, "fieldListSortAscending"),
		AttributeTag.Create<BooleanValue>(0, "mdxSubqueries"),
		AttributeTag.Create<BooleanValue>(0, "customListSort")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> cacheId.</para>
    /// <para>Represents the following attribute in the schema: cacheId </para>
    /// </summary>
    [SchemaAttr(0, "cacheId")]
    public UInt32Value CacheId
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> dataOnRows.</para>
    /// <para>Represents the following attribute in the schema: dataOnRows </para>
    /// </summary>
    [SchemaAttr(0, "dataOnRows")]
    public BooleanValue DataOnRows
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> dataPosition.</para>
    /// <para>Represents the following attribute in the schema: dataPosition </para>
    /// </summary>
    [SchemaAttr(0, "dataPosition")]
    public UInt32Value DataPosition
    {
        get { return (UInt32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Auto Format Id.</para>
    /// <para>Represents the following attribute in the schema: autoFormatId </para>
    /// </summary>
    [SchemaAttr(0, "autoFormatId")]
    public UInt32Value AutoFormatId
    {
        get { return (UInt32Value)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Apply Number Formats.</para>
    /// <para>Represents the following attribute in the schema: applyNumberFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyNumberFormats")]
    public BooleanValue ApplyNumberFormats
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Apply Border Formats.</para>
    /// <para>Represents the following attribute in the schema: applyBorderFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyBorderFormats")]
    public BooleanValue ApplyBorderFormats
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Apply Font Formats.</para>
    /// <para>Represents the following attribute in the schema: applyFontFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyFontFormats")]
    public BooleanValue ApplyFontFormats
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Apply Pattern Formats.</para>
    /// <para>Represents the following attribute in the schema: applyPatternFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyPatternFormats")]
    public BooleanValue ApplyPatternFormats
    {
        get { return (BooleanValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Apply Alignment Formats.</para>
    /// <para>Represents the following attribute in the schema: applyAlignmentFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyAlignmentFormats")]
    public BooleanValue ApplyAlignmentFormats
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Apply Width / Height Formats.</para>
    /// <para>Represents the following attribute in the schema: applyWidthHeightFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyWidthHeightFormats")]
    public BooleanValue ApplyWidthHeightFormats
    {
        get { return (BooleanValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> dataCaption.</para>
    /// <para>Represents the following attribute in the schema: dataCaption </para>
    /// </summary>
    [SchemaAttr(0, "dataCaption")]
    public StringValue DataCaption
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> grandTotalCaption.</para>
    /// <para>Represents the following attribute in the schema: grandTotalCaption </para>
    /// </summary>
    [SchemaAttr(0, "grandTotalCaption")]
    public StringValue GrandTotalCaption
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> errorCaption.</para>
    /// <para>Represents the following attribute in the schema: errorCaption </para>
    /// </summary>
    [SchemaAttr(0, "errorCaption")]
    public StringValue ErrorCaption
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> showError.</para>
    /// <para>Represents the following attribute in the schema: showError </para>
    /// </summary>
    [SchemaAttr(0, "showError")]
    public BooleanValue ShowError
    {
        get { return (BooleanValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> missingCaption.</para>
    /// <para>Represents the following attribute in the schema: missingCaption </para>
    /// </summary>
    [SchemaAttr(0, "missingCaption")]
    public StringValue MissingCaption
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> showMissing.</para>
    /// <para>Represents the following attribute in the schema: showMissing </para>
    /// </summary>
    [SchemaAttr(0, "showMissing")]
    public BooleanValue ShowMissing
    {
        get { return (BooleanValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> pageStyle.</para>
    /// <para>Represents the following attribute in the schema: pageStyle </para>
    /// </summary>
    [SchemaAttr(0, "pageStyle")]
    public StringValue PageStyle
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> pivotTableStyle.</para>
    /// <para>Represents the following attribute in the schema: pivotTableStyle </para>
    /// </summary>
    [SchemaAttr(0, "pivotTableStyle")]
    public StringValue PivotTableStyleName
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> vacatedStyle.</para>
    /// <para>Represents the following attribute in the schema: vacatedStyle </para>
    /// </summary>
    [SchemaAttr(0, "vacatedStyle")]
    public StringValue VacatedStyle
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> updatedVersion.</para>
    /// <para>Represents the following attribute in the schema: updatedVersion </para>
    /// </summary>
    [SchemaAttr(0, "updatedVersion")]
    public ByteValue UpdatedVersion
    {
        get { return (ByteValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> minRefreshableVersion.</para>
    /// <para>Represents the following attribute in the schema: minRefreshableVersion </para>
    /// </summary>
    [SchemaAttr(0, "minRefreshableVersion")]
    public ByteValue MinRefreshableVersion
    {
        get { return (ByteValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> asteriskTotals.</para>
    /// <para>Represents the following attribute in the schema: asteriskTotals </para>
    /// </summary>
    [SchemaAttr(0, "asteriskTotals")]
    public BooleanValue AsteriskTotals
    {
        get { return (BooleanValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> showItems.</para>
    /// <para>Represents the following attribute in the schema: showItems </para>
    /// </summary>
    [SchemaAttr(0, "showItems")]
    public BooleanValue ShowItems
    {
        get { return (BooleanValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> editData.</para>
    /// <para>Represents the following attribute in the schema: editData </para>
    /// </summary>
    [SchemaAttr(0, "editData")]
    public BooleanValue EditData
    {
        get { return (BooleanValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> disableFieldList.</para>
    /// <para>Represents the following attribute in the schema: disableFieldList </para>
    /// </summary>
    [SchemaAttr(0, "disableFieldList")]
    public BooleanValue DisableFieldList
    {
        get { return (BooleanValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> showCalcMbrs.</para>
    /// <para>Represents the following attribute in the schema: showCalcMbrs </para>
    /// </summary>
    [SchemaAttr(0, "showCalcMbrs")]
    public BooleanValue ShowCalculatedMembers
    {
        get { return (BooleanValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> visualTotals.</para>
    /// <para>Represents the following attribute in the schema: visualTotals </para>
    /// </summary>
    [SchemaAttr(0, "visualTotals")]
    public BooleanValue VisualTotals
    {
        get { return (BooleanValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> showMultipleLabel.</para>
    /// <para>Represents the following attribute in the schema: showMultipleLabel </para>
    /// </summary>
    [SchemaAttr(0, "showMultipleLabel")]
    public BooleanValue ShowMultipleLabel
    {
        get { return (BooleanValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> showDataDropDown.</para>
    /// <para>Represents the following attribute in the schema: showDataDropDown </para>
    /// </summary>
    [SchemaAttr(0, "showDataDropDown")]
    public BooleanValue ShowDataDropDown
    {
        get { return (BooleanValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> showDrill.</para>
    /// <para>Represents the following attribute in the schema: showDrill </para>
    /// </summary>
    [SchemaAttr(0, "showDrill")]
    public BooleanValue ShowDrill
    {
        get { return (BooleanValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> printDrill.</para>
    /// <para>Represents the following attribute in the schema: printDrill </para>
    /// </summary>
    [SchemaAttr(0, "printDrill")]
    public BooleanValue PrintDrill
    {
        get { return (BooleanValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> showMemberPropertyTips.</para>
    /// <para>Represents the following attribute in the schema: showMemberPropertyTips </para>
    /// </summary>
    [SchemaAttr(0, "showMemberPropertyTips")]
    public BooleanValue ShowMemberPropertyTips
    {
        get { return (BooleanValue)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> showDataTips.</para>
    /// <para>Represents the following attribute in the schema: showDataTips </para>
    /// </summary>
    [SchemaAttr(0, "showDataTips")]
    public BooleanValue ShowDataTips
    {
        get { return (BooleanValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> enableWizard.</para>
    /// <para>Represents the following attribute in the schema: enableWizard </para>
    /// </summary>
    [SchemaAttr(0, "enableWizard")]
    public BooleanValue EnableWizard
    {
        get { return (BooleanValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> enableDrill.</para>
    /// <para>Represents the following attribute in the schema: enableDrill </para>
    /// </summary>
    [SchemaAttr(0, "enableDrill")]
    public BooleanValue EnableDrill
    {
        get { return (BooleanValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> enableFieldProperties.</para>
    /// <para>Represents the following attribute in the schema: enableFieldProperties </para>
    /// </summary>
    [SchemaAttr(0, "enableFieldProperties")]
    public BooleanValue EnableFieldProperties
    {
        get { return (BooleanValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> preserveFormatting.</para>
    /// <para>Represents the following attribute in the schema: preserveFormatting </para>
    /// </summary>
    [SchemaAttr(0, "preserveFormatting")]
    public BooleanValue PreserveFormatting
    {
        get { return (BooleanValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> useAutoFormatting.</para>
    /// <para>Represents the following attribute in the schema: useAutoFormatting </para>
    /// </summary>
    [SchemaAttr(0, "useAutoFormatting")]
    public BooleanValue UseAutoFormatting
    {
        get { return (BooleanValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> pageWrap.</para>
    /// <para>Represents the following attribute in the schema: pageWrap </para>
    /// </summary>
    [SchemaAttr(0, "pageWrap")]
    public UInt32Value PageWrap
    {
        get { return (UInt32Value)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> pageOverThenDown.</para>
    /// <para>Represents the following attribute in the schema: pageOverThenDown </para>
    /// </summary>
    [SchemaAttr(0, "pageOverThenDown")]
    public BooleanValue PageOverThenDown
    {
        get { return (BooleanValue)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> subtotalHiddenItems.</para>
    /// <para>Represents the following attribute in the schema: subtotalHiddenItems </para>
    /// </summary>
    [SchemaAttr(0, "subtotalHiddenItems")]
    public BooleanValue SubtotalHiddenItems
    {
        get { return (BooleanValue)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> rowGrandTotals.</para>
    /// <para>Represents the following attribute in the schema: rowGrandTotals </para>
    /// </summary>
    [SchemaAttr(0, "rowGrandTotals")]
    public BooleanValue RowGrandTotals
    {
        get { return (BooleanValue)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> colGrandTotals.</para>
    /// <para>Represents the following attribute in the schema: colGrandTotals </para>
    /// </summary>
    [SchemaAttr(0, "colGrandTotals")]
    public BooleanValue ColumnGrandTotals
    {
        get { return (BooleanValue)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> fieldPrintTitles.</para>
    /// <para>Represents the following attribute in the schema: fieldPrintTitles </para>
    /// </summary>
    [SchemaAttr(0, "fieldPrintTitles")]
    public BooleanValue FieldPrintTitles
    {
        get { return (BooleanValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> itemPrintTitles.</para>
    /// <para>Represents the following attribute in the schema: itemPrintTitles </para>
    /// </summary>
    [SchemaAttr(0, "itemPrintTitles")]
    public BooleanValue ItemPrintTitles
    {
        get { return (BooleanValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> mergeItem.</para>
    /// <para>Represents the following attribute in the schema: mergeItem </para>
    /// </summary>
    [SchemaAttr(0, "mergeItem")]
    public BooleanValue MergeItem
    {
        get { return (BooleanValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> showDropZones.</para>
    /// <para>Represents the following attribute in the schema: showDropZones </para>
    /// </summary>
    [SchemaAttr(0, "showDropZones")]
    public BooleanValue ShowDropZones
    {
        get { return (BooleanValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> createdVersion.</para>
    /// <para>Represents the following attribute in the schema: createdVersion </para>
    /// </summary>
    [SchemaAttr(0, "createdVersion")]
    public ByteValue CreatedVersion
    {
        get { return (ByteValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    
    /// <summary>
    /// <para> indent.</para>
    /// <para>Represents the following attribute in the schema: indent </para>
    /// </summary>
    [SchemaAttr(0, "indent")]
    public UInt32Value Indent
    {
        get { return (UInt32Value)Attributes[50].Value; }
        set { Attributes[50].Value = value; }
    }
    
    /// <summary>
    /// <para> showEmptyRow.</para>
    /// <para>Represents the following attribute in the schema: showEmptyRow </para>
    /// </summary>
    [SchemaAttr(0, "showEmptyRow")]
    public BooleanValue ShowEmptyRow
    {
        get { return (BooleanValue)Attributes[51].Value; }
        set { Attributes[51].Value = value; }
    }
    
    /// <summary>
    /// <para> showEmptyCol.</para>
    /// <para>Represents the following attribute in the schema: showEmptyCol </para>
    /// </summary>
    [SchemaAttr(0, "showEmptyCol")]
    public BooleanValue ShowEmptyColumn
    {
        get { return (BooleanValue)Attributes[52].Value; }
        set { Attributes[52].Value = value; }
    }
    
    /// <summary>
    /// <para> showHeaders.</para>
    /// <para>Represents the following attribute in the schema: showHeaders </para>
    /// </summary>
    [SchemaAttr(0, "showHeaders")]
    public BooleanValue ShowHeaders
    {
        get { return (BooleanValue)Attributes[53].Value; }
        set { Attributes[53].Value = value; }
    }
    
    /// <summary>
    /// <para> compact.</para>
    /// <para>Represents the following attribute in the schema: compact </para>
    /// </summary>
    [SchemaAttr(0, "compact")]
    public BooleanValue Compact
    {
        get { return (BooleanValue)Attributes[54].Value; }
        set { Attributes[54].Value = value; }
    }
    
    /// <summary>
    /// <para> outline.</para>
    /// <para>Represents the following attribute in the schema: outline </para>
    /// </summary>
    [SchemaAttr(0, "outline")]
    public BooleanValue Outline
    {
        get { return (BooleanValue)Attributes[55].Value; }
        set { Attributes[55].Value = value; }
    }
    
    /// <summary>
    /// <para> outlineData.</para>
    /// <para>Represents the following attribute in the schema: outlineData </para>
    /// </summary>
    [SchemaAttr(0, "outlineData")]
    public BooleanValue OutlineData
    {
        get { return (BooleanValue)Attributes[56].Value; }
        set { Attributes[56].Value = value; }
    }
    
    /// <summary>
    /// <para> compactData.</para>
    /// <para>Represents the following attribute in the schema: compactData </para>
    /// </summary>
    [SchemaAttr(0, "compactData")]
    public BooleanValue CompactData
    {
        get { return (BooleanValue)Attributes[57].Value; }
        set { Attributes[57].Value = value; }
    }
    
    /// <summary>
    /// <para> published.</para>
    /// <para>Represents the following attribute in the schema: published </para>
    /// </summary>
    [SchemaAttr(0, "published")]
    public BooleanValue Published
    {
        get { return (BooleanValue)Attributes[58].Value; }
        set { Attributes[58].Value = value; }
    }
    
    /// <summary>
    /// <para> gridDropZones.</para>
    /// <para>Represents the following attribute in the schema: gridDropZones </para>
    /// </summary>
    [SchemaAttr(0, "gridDropZones")]
    public BooleanValue GridDropZones
    {
        get { return (BooleanValue)Attributes[59].Value; }
        set { Attributes[59].Value = value; }
    }
    
    /// <summary>
    /// <para> immersive.</para>
    /// <para>Represents the following attribute in the schema: immersive </para>
    /// </summary>
    [SchemaAttr(0, "immersive")]
    public BooleanValue StopImmersiveUi
    {
        get { return (BooleanValue)Attributes[60].Value; }
        set { Attributes[60].Value = value; }
    }
    
    /// <summary>
    /// <para> multipleFieldFilters.</para>
    /// <para>Represents the following attribute in the schema: multipleFieldFilters </para>
    /// </summary>
    [SchemaAttr(0, "multipleFieldFilters")]
    public BooleanValue MultipleFieldFilters
    {
        get { return (BooleanValue)Attributes[61].Value; }
        set { Attributes[61].Value = value; }
    }
    
    /// <summary>
    /// <para> chartFormat.</para>
    /// <para>Represents the following attribute in the schema: chartFormat </para>
    /// </summary>
    [SchemaAttr(0, "chartFormat")]
    public UInt32Value ChartFormat
    {
        get { return (UInt32Value)Attributes[62].Value; }
        set { Attributes[62].Value = value; }
    }
    
    /// <summary>
    /// <para> rowHeaderCaption.</para>
    /// <para>Represents the following attribute in the schema: rowHeaderCaption </para>
    /// </summary>
    [SchemaAttr(0, "rowHeaderCaption")]
    public StringValue RowHeaderCaption
    {
        get { return (StringValue)Attributes[63].Value; }
        set { Attributes[63].Value = value; }
    }
    
    /// <summary>
    /// <para> colHeaderCaption.</para>
    /// <para>Represents the following attribute in the schema: colHeaderCaption </para>
    /// </summary>
    [SchemaAttr(0, "colHeaderCaption")]
    public StringValue ColumnHeaderCaption
    {
        get { return (StringValue)Attributes[64].Value; }
        set { Attributes[64].Value = value; }
    }
    
    /// <summary>
    /// <para> fieldListSortAscending.</para>
    /// <para>Represents the following attribute in the schema: fieldListSortAscending </para>
    /// </summary>
    [SchemaAttr(0, "fieldListSortAscending")]
    public BooleanValue FieldListSortAscending
    {
        get { return (BooleanValue)Attributes[65].Value; }
        set { Attributes[65].Value = value; }
    }
    
    /// <summary>
    /// <para> mdxSubqueries.</para>
    /// <para>Represents the following attribute in the schema: mdxSubqueries </para>
    /// </summary>
    [SchemaAttr(0, "mdxSubqueries")]
    public BooleanValue MdxSubqueries
    {
        get { return (BooleanValue)Attributes[66].Value; }
        set { Attributes[66].Value = value; }
    }
    
    /// <summary>
    /// <para> customListSort.</para>
    /// <para>Represents the following attribute in the schema: customListSort </para>
    /// </summary>
    [SchemaAttr(0, "customListSort")]
    public BooleanValue CustomListSort
    {
        get { return (BooleanValue)Attributes[67].Value; }
        set { Attributes[67].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "location" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Location();
    
if( 22 == namespaceId && "pivotFields" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PivotFields();
    
if( 22 == namespaceId && "rowFields" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.RowFields();
    
if( 22 == namespaceId && "rowItems" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.RowItems();
    
if( 22 == namespaceId && "colFields" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ColumnFields();
    
if( 22 == namespaceId && "colItems" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ColumnItems();
    
if( 22 == namespaceId && "pageFields" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PageFields();
    
if( 22 == namespaceId && "dataFields" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.DataFields();
    
if( 22 == namespaceId && "formats" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Formats();
    
if( 22 == namespaceId && "conditionalFormats" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats();
    
if( 22 == namespaceId && "chartFormats" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ChartFormats();
    
if( 22 == namespaceId && "pivotHierarchies" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies();
    
if( 22 == namespaceId && "pivotTableStyleInfo" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle();
    
if( 22 == namespaceId && "filters" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PivotFilters();
    
if( 22 == namespaceId && "rowHierarchiesUsage" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage();
    
if( 22 == namespaceId && "colHierarchiesUsage" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage();
    
if( 22 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "location","pivotFields","rowFields","rowItems","colFields","colItems","pageFields","dataFields","formats","conditionalFormats","chartFormats","pivotHierarchies","pivotTableStyleInfo","filters","rowHierarchiesUsage","colHierarchiesUsage","extLst" };
    private static readonly byte[] eleNamespaceIds = { 22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Location.</para>
    /// <para> Represents the following element tag in the schema: x:location </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
 
 
