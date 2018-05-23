// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace DocumentFormat.OpenXml.Office.Excel
{
/// <summary>
/// <para>Defines the Macrosheet Class. The root element of MacroSheetPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is xne:macrosheet.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.SheetProperties &lt;x:sheetPr></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.SheetDimension &lt;x:dimension></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.SheetViews &lt;x:sheetViews></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties &lt;x:sheetFormatPr></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Columns &lt;x:cols></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.SheetData &lt;x:sheetData></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.SheetProtection &lt;x:sheetProtection></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.AutoFilter &lt;x:autoFilter></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.SortState &lt;x:sortState></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.DataConsolidate &lt;x:dataConsolidate></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.CustomSheetViews &lt;x:customSheetViews></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties &lt;x:phoneticPr></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting &lt;x:conditionalFormatting></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PrintOptions &lt;x:printOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PageMargins &lt;x:pageMargins></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PageSetup &lt;x:pageSetup></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.HeaderFooter &lt;x:headerFooter></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.RowBreaks &lt;x:rowBreaks></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ColumnBreaks &lt;x:colBreaks></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.CustomProperties &lt;x:customProperties></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Drawing &lt;x:drawing></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.LegacyDrawing &lt;x:legacyDrawing></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.LegacyDrawingHeaderFooter &lt;x:legacyDrawingHF></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Picture &lt;x:picture></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.OleObjects &lt;x:oleObjects></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.DrawingHeaderFooter &lt;x:drawingHF></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ExtensionList &lt;x:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetDimension))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetViews))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Columns))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetProtection))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.AutoFilter))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SortState))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.DataConsolidate))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.CustomSheetViews))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PrintOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PageMargins))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PageSetup))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.HeaderFooter))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.RowBreaks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnBreaks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.CustomProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Drawing))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.LegacyDrawing))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.LegacyDrawingHeaderFooter))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Picture))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.OleObjects))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.DrawingHeaderFooter), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Macrosheet : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 12600;
    /// <inheritdoc/>
    public override string LocalName => "macrosheet";
    
    internal override byte NamespaceId => 32;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    
	internal Macrosheet(MacroSheetPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the MacroSheetPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(MacroSheetPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the MacroSheetPart associated with this element.
    /// </summary>
    public MacroSheetPart MacroSheetPart
    {
		get => OpenXmlPart as MacroSheetPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the Macrosheet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Macrosheet(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Macrosheet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Macrosheet(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Macrosheet class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Macrosheet(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the Macrosheet class.
    /// </summary>
    public Macrosheet():base(){}
    
    /// <summary>
    /// Saves the DOM into the MacroSheetPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(MacroSheetPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "sheetPr" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.SheetProperties();
    
if( 22 == namespaceId && "dimension" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.SheetDimension();
    
if( 22 == namespaceId && "sheetViews" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.SheetViews();
    
if( 22 == namespaceId && "sheetFormatPr" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties();
    
if( 22 == namespaceId && "cols" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Columns();
    
if( 22 == namespaceId && "sheetData" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.SheetData();
    
if( 22 == namespaceId && "sheetProtection" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.SheetProtection();
    
if( 22 == namespaceId && "autoFilter" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.AutoFilter();
    
if( 22 == namespaceId && "sortState" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.SortState();
    
if( 22 == namespaceId && "dataConsolidate" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.DataConsolidate();
    
if( 22 == namespaceId && "customSheetViews" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.CustomSheetViews();
    
if( 22 == namespaceId && "phoneticPr" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties();
    
if( 22 == namespaceId && "conditionalFormatting" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting();
    
if( 22 == namespaceId && "printOptions" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PrintOptions();
    
if( 22 == namespaceId && "pageMargins" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PageMargins();
    
if( 22 == namespaceId && "pageSetup" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PageSetup();
    
if( 22 == namespaceId && "headerFooter" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.HeaderFooter();
    
if( 22 == namespaceId && "rowBreaks" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.RowBreaks();
    
if( 22 == namespaceId && "colBreaks" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ColumnBreaks();
    
if( 22 == namespaceId && "customProperties" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.CustomProperties();
    
if( 22 == namespaceId && "drawing" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Drawing();
    
if( 22 == namespaceId && "legacyDrawing" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.LegacyDrawing();
    
if( 22 == namespaceId && "legacyDrawingHF" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.LegacyDrawingHeaderFooter();
    
if( 22 == namespaceId && "picture" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Picture();
    
if( 22 == namespaceId && "oleObjects" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.OleObjects();
    
if( 22 == namespaceId && "drawingHF" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.DrawingHeaderFooter();
    
if( 22 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sheetPr","dimension","sheetViews","sheetFormatPr","cols","sheetData","sheetProtection","autoFilter","sortState","dataConsolidate","customSheetViews","phoneticPr","conditionalFormatting","printOptions","pageMargins","pageSetup","headerFooter","rowBreaks","colBreaks","customProperties","drawing","legacyDrawing","legacyDrawingHF","picture","oleObjects","drawingHF","extLst" };
    private static readonly byte[] eleNamespaceIds = { 22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Sheet Properties.</para>
    /// <para> Represents the following element tag in the schema: x:sheetPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.SheetProperties SheetProperties
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.SheetProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Macro Sheet Dimensions.</para>
    /// <para> Represents the following element tag in the schema: x:dimension </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.SheetDimension SheetDimension
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.SheetDimension>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Macro Sheet Views.</para>
    /// <para> Represents the following element tag in the schema: x:sheetViews </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.SheetViews SheetViews
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.SheetViews>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Sheet Format Properties.</para>
    /// <para> Represents the following element tag in the schema: x:sheetFormatPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties SheetFormatProperties
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Macrosheet>(deep);

}
/// <summary>
/// <para>Worksheet Sort Map. The root element of WorksheetSortMapPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is xne:worksheetSortMap.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RowSortMap &lt;xne:rowSortMap></description></item>
///<item><description>ColumnSortMap &lt;xne:colSortMap></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RowSortMap))]
    [ChildElementInfo(typeof(ColumnSortMap))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WorksheetSortMap : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 12601;
    /// <inheritdoc/>
    public override string LocalName => "worksheetSortMap";
    
    internal override byte NamespaceId => 32;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    
	internal WorksheetSortMap(WorksheetSortMapPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the WorksheetSortMapPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(WorksheetSortMapPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the WorksheetSortMapPart associated with this element.
    /// </summary>
    public WorksheetSortMapPart WorksheetSortMapPart
    {
		get => OpenXmlPart as WorksheetSortMapPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the WorksheetSortMap class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WorksheetSortMap(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WorksheetSortMap class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WorksheetSortMap(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WorksheetSortMap class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WorksheetSortMap(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the WorksheetSortMap class.
    /// </summary>
    public WorksheetSortMap():base(){}
    
    /// <summary>
    /// Saves the DOM into the WorksheetSortMapPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(WorksheetSortMapPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 32 == namespaceId && "rowSortMap" == name)
    return new RowSortMap();
    
if( 32 == namespaceId && "colSortMap" == name)
    return new ColumnSortMap();
    

    return null;
}

        private static readonly string[] eleTagNames = { "rowSortMap","colSortMap" };
    private static readonly byte[] eleNamespaceIds = { 32,32 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Row Sort Map.</para>
    /// <para> Represents the following element tag in the schema: xne:rowSortMap </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
    public RowSortMap RowSortMap
    {
        get => GetElement<RowSortMap>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Column Sort Map.</para>
    /// <para> Represents the following element tag in the schema: xne:colSortMap </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
    public ColumnSortMap ColumnSortMap
    {
        get => GetElement<ColumnSortMap>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WorksheetSortMap>(deep);

}
/// <summary>
/// <para>Defines the ReferenceSequence Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xne:sqref.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ReferenceSequence : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12602;
    /// <inheritdoc/>
    public override string LocalName => "sqref";
    
    internal override byte NamespaceId => 32;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ReferenceSequence class.
    /// </summary>
    public ReferenceSequence():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the ReferenceSequence class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ReferenceSequence(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new ListValue<StringValue>(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ReferenceSequence>(deep);

}
/// <summary>
/// <para>Defines the Formula Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xne:f.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Formula : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12603;
    /// <inheritdoc/>
    public override string LocalName => "f";
    
    internal override byte NamespaceId => 32;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Formula class.
    /// </summary>
    public Formula():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the Formula class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Formula(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);

}
/// <summary>
/// <para>Row Sort Map.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xne:rowSortMap.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RowSortMapItem &lt;xne:row></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RowSortMapItem))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RowSortMap : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12604;
    /// <inheritdoc/>
    public override string LocalName => "rowSortMap";
    
    internal override byte NamespaceId => 32;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "ref"),
		AttributeTag.Create<UInt32Value>(0, "count")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Reference.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Ref
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RowSortMap class.
    /// </summary>
    public RowSortMap():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RowSortMap class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RowSortMap(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RowSortMap class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RowSortMap(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RowSortMap class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RowSortMap(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 32 == namespaceId && "row" == name)
    return new RowSortMapItem();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowSortMap>(deep);

}
/// <summary>
/// <para>Column Sort Map.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xne:colSortMap.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ColumnSortMapItem &lt;xne:col></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ColumnSortMapItem))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColumnSortMap : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12605;
    /// <inheritdoc/>
    public override string LocalName => "colSortMap";
    
    internal override byte NamespaceId => 32;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "ref"),
		AttributeTag.Create<UInt32Value>(0, "count")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Reference.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Ref
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ColumnSortMap class.
    /// </summary>
    public ColumnSortMap():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ColumnSortMap class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColumnSortMap(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColumnSortMap class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColumnSortMap(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColumnSortMap class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColumnSortMap(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 32 == namespaceId && "col" == name)
    return new ColumnSortMapItem();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnSortMap>(deep);

}
/// <summary>
/// <para>Row.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xne:row.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RowSortMapItem : SortMapItemType
{
    internal const int ElementTypeIdConst = 12606;
    /// <inheritdoc/>
    public override string LocalName => "row";
    
    internal override byte NamespaceId => 32;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the RowSortMapItem class.
    /// </summary>
    public RowSortMapItem():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowSortMapItem>(deep);

}
/// <summary>
/// <para>Column.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xne:col.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColumnSortMapItem : SortMapItemType
{
    internal const int ElementTypeIdConst = 12607;
    /// <inheritdoc/>
    public override string LocalName => "col";
    
    internal override byte NamespaceId => 32;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ColumnSortMapItem class.
    /// </summary>
    public ColumnSortMapItem():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnSortMapItem>(deep);

}
/// <summary>
/// Defines the SortMapItemType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class SortMapItemType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "newVal"),
		AttributeTag.Create<UInt32Value>(0, "oldVal")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> New Value.</para>
    /// <para>Represents the following attribute in the schema: newVal </para>
    /// </summary>
    [SchemaAttr(0, "newVal")]
    public UInt32Value NewVal
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Old Value.</para>
    /// <para>Represents the following attribute in the schema: oldVal </para>
    /// </summary>
    [SchemaAttr(0, "oldVal")]
    public UInt32Value OldVal
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SortMapItemType class.
    /// </summary>
    protected SortMapItemType(){}
    
    
    
}
}
 
 
