// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
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
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:revHdrs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RevExHeader &lt;xr:hdr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RevExHeader),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExHeaders : OpenXmlCompositeElement
{
    private const string tagName = "revHdrs";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13540;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "minRev","maxRev","docId","endpointId" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> minRev.</para>
    /// <para>Represents the following attribute in the schema: minRev </para>
    /// </summary>
    [SchemaAttr(0, "minRev")]
    public UInt64Value MinRev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> maxRev.</para>
    /// <para>Represents the following attribute in the schema: maxRev </para>
    /// </summary>
    [SchemaAttr(0, "maxRev")]
    public UInt64Value MaxRev
    {
        get { return (UInt64Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> docId.</para>
    /// <para>Represents the following attribute in the schema: docId </para>
    /// </summary>
    [SchemaAttr(0, "docId")]
    public StringValue DocId
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> endpointId.</para>
    /// <para>Represents the following attribute in the schema: endpointId </para>
    /// </summary>
    [SchemaAttr(0, "endpointId")]
    public StringValue EndpointId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "minRev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "maxRev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "docId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "endpointId" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExHeaders>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExStream Class.</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RevExFuture),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExUnsupported),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExTrimmed),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExRowColumn),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExMove),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExChangeCell),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExFormatting),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExDefinedName),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExDelObj),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExChgObj),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExSheetOp),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevisionList),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevListAutoExpandRw),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevGroup),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExStream : OpenXmlCompositeElement
{
    private const string tagName = "revStream";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13541;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExStream>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DifferentialFormatType Class.</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Font))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.NumberingFormat))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Fill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Alignment))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Border))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Protection))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class DifferentialFormatType : OpenXmlCompositeElement
{
    private const string tagName = "dxf";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13542;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Font Properties.</para>
    /// <para> Represents the following element tag in the schema: x:font </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.Font Font
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.Font>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.NumberingFormat>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.Fill>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.Alignment>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.Border>(4);
        }
        set
        {
            SetElement(4, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.Protection>(5);
        }
        set
        {
            SetElement(5, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>(6);
        }
        set
        {
            SetElement(6, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DifferentialFormatType>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevisionPtr Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:revisionPtr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevisionPtr : OpenXmlLeafElement
{
    private const string tagName = "revisionPtr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13543;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "revIDLastSave","documentId" };
    private static byte[] attributeNamespaceIds = { 0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> revIDLastSave.</para>
    /// <para>Represents the following attribute in the schema: revIDLastSave </para>
    /// </summary>
    [SchemaAttr(0, "revIDLastSave")]
    public UInt64Value RevIDLastSave
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> documentId.</para>
    /// <para>Represents the following attribute in the schema: documentId </para>
    /// </summary>
    [SchemaAttr(0, "documentId")]
    public StringValue DocumentId
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RevisionPtr class.
    /// </summary>
    public RevisionPtr():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "revIDLastSave" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "documentId" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevisionPtr>(deep);
    }

   
}
/// <summary>
/// <para>Defines the StateBasedObject Class.</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DataValidation),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Hyperlink),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(SparklineGroup),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Comments),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(AutoFilter),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(pivotTableDefinition),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class StateBasedObject : OpenXmlCompositeElement
{
    private const string tagName = "objectState";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13544;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneChoice;}
    }
    
        /// <summary>
    /// <para> Represents an external link to another workbook..</para>
    /// <para> Represents the following element tag in the schema: xr:dataValidation </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
    public DataValidation DataValidation
    {
        get 
        {
            return GetElement<DataValidation>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Hyperlink>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<SparklineGroup>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<Comments>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<AutoFilter>(4);
        }
        set
        {
            SetElement(4, value);
        }
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
        get 
        {
            return GetElement<pivotTableDefinition>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<StateBasedObject>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExHeader Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:hdr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExHeader : OpenXmlLeafElement
{
    private const string tagName = "hdr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13545;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","minRev","maxRev","time" };
    private static byte[] attributeNamespaceIds = { 19,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> minRev.</para>
    /// <para>Represents the following attribute in the schema: minRev </para>
    /// </summary>
    [SchemaAttr(0, "minRev")]
    public UInt64Value MinRev
    {
        get { return (UInt64Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> maxRev.</para>
    /// <para>Represents the following attribute in the schema: maxRev </para>
    /// </summary>
    [SchemaAttr(0, "maxRev")]
    public UInt64Value MaxRev
    {
        get { return (UInt64Value)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> time.</para>
    /// <para>Represents the following attribute in the schema: time </para>
    /// </summary>
    [SchemaAttr(0, "time")]
    public DateTimeValue Time
    {
        get { return (DateTimeValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RevExHeader class.
    /// </summary>
    public RevExHeader():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 19 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "minRev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "maxRev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "time" == name)
    return new DateTimeValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExHeader>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExFuture Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrftr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RevExTest &lt;xr:xrrtest></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RevExTest),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExFuture : OpenXmlCompositeElement
{
    private const string tagName = "xrrftr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13546;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx","sti" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> sti.</para>
    /// <para>Represents the following attribute in the schema: sti </para>
    /// </summary>
    [SchemaAttr(0, "sti")]
    public BooleanValue Sti
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    
if( 0 == namespaceId && "sti" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExFuture>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExUnsupported Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrUspt.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExUnsupported : OpenXmlLeafElement
{
    private const string tagName = "xrrUspt";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13547;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RevExUnsupported class.
    /// </summary>
    public RevExUnsupported():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExUnsupported>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExTrimmed Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrTrim.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExTrimmed : OpenXmlLeafElement
{
    private const string tagName = "xrrTrim";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13548;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RevExTrimmed class.
    /// </summary>
    public RevExTrimmed():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExTrimmed>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExRowColumn Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrrc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExRowColumn : OpenXmlLeafElement
{
    private const string tagName = "xrrrc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13549;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx","eol","ref","action" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> eol.</para>
    /// <para>Represents the following attribute in the schema: eol </para>
    /// </summary>
    [SchemaAttr(0, "eol")]
    public BooleanValue Eol
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> ref.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Ref
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> action.</para>
    /// <para>Represents the following attribute in the schema: action </para>
    /// </summary>
    [SchemaAttr(0, "action")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RwColAction> Action
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RwColAction>)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RevExRowColumn class.
    /// </summary>
    public RevExRowColumn():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    
if( 0 == namespaceId && "eol" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "ref" == name)
    return new StringValue();
    
if( 0 == namespaceId && "action" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RwColAction>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExRowColumn>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExMove Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrm.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExMove : OpenXmlLeafElement
{
    private const string tagName = "xrrm";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13550;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx","src","dst","srcSh" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> src.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
    public StringValue Src
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> dst.</para>
    /// <para>Represents the following attribute in the schema: dst </para>
    /// </summary>
    [SchemaAttr(0, "dst")]
    public StringValue Dst
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> srcSh.</para>
    /// <para>Represents the following attribute in the schema: srcSh </para>
    /// </summary>
    [SchemaAttr(0, "srcSh")]
    public StringValue SrcSh
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RevExMove class.
    /// </summary>
    public RevExMove():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    
if( 0 == namespaceId && "src" == name)
    return new StringValue();
    
if( 0 == namespaceId && "dst" == name)
    return new StringValue();
    
if( 0 == namespaceId && "srcSh" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExMove>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExChangeCell Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrc.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RevCell &lt;xr:c></description></item>
///<item><description>ChangeCellSubEdit &lt;xr:ccse></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RevCell),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ChangeCellSubEdit),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExChangeCell : OpenXmlCompositeElement
{
    private const string tagName = "xrrc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13551;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "listUid","rev","uid","sh","uidp","ctx","r","t","x","w" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> listUid.</para>
    /// <para>Represents the following attribute in the schema: listUid </para>
    /// </summary>
    [SchemaAttr(0, "listUid")]
    public StringValue ListUid
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public StringValue R
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType> T
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> x.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
    [SchemaAttr(0, "x")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt> X
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> w.</para>
    /// <para>Represents the following attribute in the schema: w </para>
    /// </summary>
    [SchemaAttr(0, "w")]
    public UInt32Value W
    {
        get { return (UInt32Value)Attributes[9]; }
        set { Attributes[9] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "listUid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    
if( 0 == namespaceId && "r" == name)
    return new StringValue();
    
if( 0 == namespaceId && "t" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>();
    
if( 0 == namespaceId && "x" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>();
    
if( 0 == namespaceId && "w" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExChangeCell>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExFormatting Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrf.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DifferentialFormatType &lt;xr:dxf></description></item>
///<item><description>ExtensionList &lt;xr:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DifferentialFormatType),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExFormatting : OpenXmlCompositeElement
{
    private const string tagName = "xrrf";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13552;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx","numFmtId","xfDxf","style","sqref","start","length","styleUid","fBlankCell","applyNumberFormat","applyFont","applyFill","applyBorder","applyAlignment","applyProtection" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> numFmtId.</para>
    /// <para>Represents the following attribute in the schema: numFmtId </para>
    /// </summary>
    [SchemaAttr(0, "numFmtId")]
    public UInt32Value NumFmtId
    {
        get { return (UInt32Value)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> xfDxf.</para>
    /// <para>Represents the following attribute in the schema: xfDxf </para>
    /// </summary>
    [SchemaAttr(0, "xfDxf")]
    public BooleanValue XfDxf
    {
        get { return (BooleanValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public BooleanValue Style
    {
        get { return (BooleanValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> sqref.</para>
    /// <para>Represents the following attribute in the schema: sqref </para>
    /// </summary>
    [SchemaAttr(0, "sqref")]
    public ListValue<StringValue> Sqref
    {
        get { return (ListValue<StringValue>)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> start.</para>
    /// <para>Represents the following attribute in the schema: start </para>
    /// </summary>
    [SchemaAttr(0, "start")]
    public UInt32Value Start
    {
        get { return (UInt32Value)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> length.</para>
    /// <para>Represents the following attribute in the schema: length </para>
    /// </summary>
    [SchemaAttr(0, "length")]
    public UInt32Value Length
    {
        get { return (UInt32Value)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> styleUid.</para>
    /// <para>Represents the following attribute in the schema: styleUid </para>
    /// </summary>
    [SchemaAttr(0, "styleUid")]
    public StringValue StyleUid
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> fBlankCell.</para>
    /// <para>Represents the following attribute in the schema: fBlankCell </para>
    /// </summary>
    [SchemaAttr(0, "fBlankCell")]
    public BooleanValue FBlankCell
    {
        get { return (BooleanValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> applyNumberFormat.</para>
    /// <para>Represents the following attribute in the schema: applyNumberFormat </para>
    /// </summary>
    [SchemaAttr(0, "applyNumberFormat")]
    public BooleanValue ApplyNumberFormat
    {
        get { return (BooleanValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> applyFont.</para>
    /// <para>Represents the following attribute in the schema: applyFont </para>
    /// </summary>
    [SchemaAttr(0, "applyFont")]
    public BooleanValue ApplyFont
    {
        get { return (BooleanValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> applyFill.</para>
    /// <para>Represents the following attribute in the schema: applyFill </para>
    /// </summary>
    [SchemaAttr(0, "applyFill")]
    public BooleanValue ApplyFill
    {
        get { return (BooleanValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> applyBorder.</para>
    /// <para>Represents the following attribute in the schema: applyBorder </para>
    /// </summary>
    [SchemaAttr(0, "applyBorder")]
    public BooleanValue ApplyBorder
    {
        get { return (BooleanValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> applyAlignment.</para>
    /// <para>Represents the following attribute in the schema: applyAlignment </para>
    /// </summary>
    [SchemaAttr(0, "applyAlignment")]
    public BooleanValue ApplyAlignment
    {
        get { return (BooleanValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> applyProtection.</para>
    /// <para>Represents the following attribute in the schema: applyProtection </para>
    /// </summary>
    [SchemaAttr(0, "applyProtection")]
    public BooleanValue ApplyProtection
    {
        get { return (BooleanValue)Attributes[18]; }
        set { Attributes[18] = value; }
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> DifferentialFormatType.</para>
    /// <para> Represents the following element tag in the schema: xr:dxf </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
    public DifferentialFormatType DifferentialFormatType
    {
        get 
        {
            return GetElement<DifferentialFormatType>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<ExtensionList>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    
if( 0 == namespaceId && "numFmtId" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "xfDxf" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "style" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "sqref" == name)
    return new ListValue<StringValue>();
    
if( 0 == namespaceId && "start" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "length" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "styleUid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "fBlankCell" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "applyNumberFormat" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "applyFont" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "applyFill" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "applyBorder" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "applyAlignment" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "applyProtection" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExFormatting>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExDefinedName Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrDefName.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FormulaFormula &lt;xr:formula></description></item>
///<item><description>ExtensionList &lt;xr:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(FormulaFormula),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExDefinedName : OpenXmlCompositeElement
{
    private const string tagName = "xrrDefName";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13553;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx","customView","name","function","functionGroupId","shortcutKey","hidden","customMenu","description","help","statusBar","comment" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> customView.</para>
    /// <para>Represents the following attribute in the schema: customView </para>
    /// </summary>
    [SchemaAttr(0, "customView")]
    public BooleanValue CustomView
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> function.</para>
    /// <para>Represents the following attribute in the schema: function </para>
    /// </summary>
    [SchemaAttr(0, "function")]
    public BooleanValue Function
    {
        get { return (BooleanValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> functionGroupId.</para>
    /// <para>Represents the following attribute in the schema: functionGroupId </para>
    /// </summary>
    [SchemaAttr(0, "functionGroupId")]
    public ByteValue FunctionGroupId
    {
        get { return (ByteValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> shortcutKey.</para>
    /// <para>Represents the following attribute in the schema: shortcutKey </para>
    /// </summary>
    [SchemaAttr(0, "shortcutKey")]
    public ByteValue ShortcutKey
    {
        get { return (ByteValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
    {
        get { return (BooleanValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> customMenu.</para>
    /// <para>Represents the following attribute in the schema: customMenu </para>
    /// </summary>
    [SchemaAttr(0, "customMenu")]
    public StringValue CustomMenu
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> help.</para>
    /// <para>Represents the following attribute in the schema: help </para>
    /// </summary>
    [SchemaAttr(0, "help")]
    public StringValue Help
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> statusBar.</para>
    /// <para>Represents the following attribute in the schema: statusBar </para>
    /// </summary>
    [SchemaAttr(0, "statusBar")]
    public StringValue StatusBar
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> comment.</para>
    /// <para>Represents the following attribute in the schema: comment </para>
    /// </summary>
    [SchemaAttr(0, "comment")]
    public StringValue Comment
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> FormulaFormula.</para>
    /// <para> Represents the following element tag in the schema: xr:formula </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
    public FormulaFormula FormulaFormula
    {
        get 
        {
            return GetElement<FormulaFormula>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<ExtensionList>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    
if( 0 == namespaceId && "customView" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "function" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "functionGroupId" == name)
    return new ByteValue();
    
if( 0 == namespaceId && "shortcutKey" == name)
    return new ByteValue();
    
if( 0 == namespaceId && "hidden" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "customMenu" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "help" == name)
    return new StringValue();
    
if( 0 == namespaceId && "statusBar" == name)
    return new StringValue();
    
if( 0 == namespaceId && "comment" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExDefinedName>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExDelObj Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrdo.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StateBasedHeader &lt;xr:hdr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(StateBasedHeader),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExDelObj : OpenXmlCompositeElement
{
    private const string tagName = "xrrdo";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13554;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> StateBasedHeader.</para>
    /// <para> Represents the following element tag in the schema: xr:hdr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
    public StateBasedHeader StateBasedHeader
    {
        get 
        {
            return GetElement<StateBasedHeader>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExDelObj>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExChgObj Class.</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(StateBasedHeader),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevisionStateLink),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevisionState),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExChgObj : OpenXmlCompositeElement
{
    private const string tagName = "xrrco";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13555;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> StateBasedHeader.</para>
    /// <para> Represents the following element tag in the schema: xr:hdr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
    public StateBasedHeader StateBasedHeader
    {
        get 
        {
            return GetElement<StateBasedHeader>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExChgObj>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExSheetOp Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrSheet.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExSheetOp : OpenXmlLeafElement
{
    private const string tagName = "xrrSheet";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13556;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx","op","name","idOrig","idNew" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> op.</para>
    /// <para>Represents the following attribute in the schema: op </para>
    /// </summary>
    [SchemaAttr(0, "op")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SheetOp> Op
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SheetOp>)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> idOrig.</para>
    /// <para>Represents the following attribute in the schema: idOrig </para>
    /// </summary>
    [SchemaAttr(0, "idOrig")]
    public UInt32Value IdOrig
    {
        get { return (UInt32Value)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> idNew.</para>
    /// <para>Represents the following attribute in the schema: idNew </para>
    /// </summary>
    [SchemaAttr(0, "idNew")]
    public UInt32Value IdNew
    {
        get { return (UInt32Value)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RevExSheetOp class.
    /// </summary>
    public RevExSheetOp():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    
if( 0 == namespaceId && "op" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SheetOp>();
    
if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idOrig" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "idNew" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExSheetOp>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevisionList Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrList.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevisionList : OpenXmlLeafElement
{
    private const string tagName = "xrrList";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13557;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx","Data","Formatting","RangeBased","Fake","ref","Headers","InsDelHeaders","rId" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Data.</para>
    /// <para>Represents the following attribute in the schema: Data </para>
    /// </summary>
    [SchemaAttr(0, "Data")]
    public BooleanValue Data
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Formatting.</para>
    /// <para>Represents the following attribute in the schema: Formatting </para>
    /// </summary>
    [SchemaAttr(0, "Formatting")]
    public BooleanValue Formatting
    {
        get { return (BooleanValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> RangeBased.</para>
    /// <para>Represents the following attribute in the schema: RangeBased </para>
    /// </summary>
    [SchemaAttr(0, "RangeBased")]
    public BooleanValue RangeBased
    {
        get { return (BooleanValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Fake.</para>
    /// <para>Represents the following attribute in the schema: Fake </para>
    /// </summary>
    [SchemaAttr(0, "Fake")]
    public BooleanValue Fake
    {
        get { return (BooleanValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> ref.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Ref
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Headers.</para>
    /// <para>Represents the following attribute in the schema: Headers </para>
    /// </summary>
    [SchemaAttr(0, "Headers")]
    public BooleanValue Headers
    {
        get { return (BooleanValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> InsDelHeaders.</para>
    /// <para>Represents the following attribute in the schema: InsDelHeaders </para>
    /// </summary>
    [SchemaAttr(0, "InsDelHeaders")]
    public BooleanValue InsDelHeaders
    {
        get { return (BooleanValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> rId.</para>
    /// <para>Represents the following attribute in the schema: rId </para>
    /// </summary>
    [SchemaAttr(0, "rId")]
    public UInt32Value RId
    {
        get { return (UInt32Value)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RevisionList class.
    /// </summary>
    public RevisionList():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    
if( 0 == namespaceId && "Data" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "Formatting" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "RangeBased" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "Fake" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "ref" == name)
    return new StringValue();
    
if( 0 == namespaceId && "Headers" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "InsDelHeaders" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "rId" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevisionList>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevListAutoExpandRw Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrListExpR.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevListAutoExpandRw : OpenXmlLeafElement
{
    private const string tagName = "xrrListExpR";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13558;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx","refAdded","listGuid" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> refAdded.</para>
    /// <para>Represents the following attribute in the schema: refAdded </para>
    /// </summary>
    [SchemaAttr(0, "refAdded")]
    public StringValue RefAdded
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> listGuid.</para>
    /// <para>Represents the following attribute in the schema: listGuid </para>
    /// </summary>
    [SchemaAttr(0, "listGuid")]
    public StringValue ListGuid
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RevListAutoExpandRw class.
    /// </summary>
    public RevListAutoExpandRw():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    
if( 0 == namespaceId && "refAdded" == name)
    return new StringValue();
    
if( 0 == namespaceId && "listGuid" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevListAutoExpandRw>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevGroup Class.</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RevExFuture),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExUnsupported),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExTrimmed),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExRowColumn),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExMove),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExChangeCell),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExFormatting),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExDefinedName),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExDelObj),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExChgObj),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevExSheetOp),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevisionList),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RevListAutoExpandRw),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevGroup : OpenXmlCompositeElement
{
    private const string tagName = "xrrg";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13559;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rev","uid","sh","uidp","ctx" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> rev.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt64Value Rev
    {
        get { return (UInt64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sh.</para>
    /// <para>Represents the following attribute in the schema: sh </para>
    /// </summary>
    [SchemaAttr(0, "sh")]
    public StringValue Sh
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uidp.</para>
    /// <para>Represents the following attribute in the schema: uidp </para>
    /// </summary>
    [SchemaAttr(0, "uidp")]
    public StringValue Uidp
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> ctx.</para>
    /// <para>Represents the following attribute in the schema: ctx </para>
    /// </summary>
    [SchemaAttr(0, "ctx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext> Ctx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>)Attributes[4]; }
        set { Attributes[4] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rev" == name)
    return new UInt64Value();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sh" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidp" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ctx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevGroup>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevExTest Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:xrrtest.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevExTest : OpenXmlLeafElement
{
    private const string tagName = "xrrtest";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13560;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RevExTest class.
    /// </summary>
    public RevExTest():base(){}
    
      
     
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevExTest>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevCell Class.</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(FFormula),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Xstring),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RstType),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevCell : OpenXmlCompositeElement
{
    private const string tagName = "c";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13561;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "t","nop","tick","rep" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues> T
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> nop.</para>
    /// <para>Represents the following attribute in the schema: nop </para>
    /// </summary>
    [SchemaAttr(0, "nop")]
    public BooleanValue Nop
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> tick.</para>
    /// <para>Represents the following attribute in the schema: tick </para>
    /// </summary>
    [SchemaAttr(0, "tick")]
    public BooleanValue Tick
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> rep.</para>
    /// <para>Represents the following attribute in the schema: rep </para>
    /// </summary>
    [SchemaAttr(0, "rep")]
    public UInt32Value Rep
    {
        get { return (UInt32Value)Attributes[3]; }
        set { Attributes[3] = value; }
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> FFormula.</para>
    /// <para> Represents the following element tag in the schema: xr:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
    public FFormula FFormula
    {
        get 
        {
            return GetElement<FFormula>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Xstring>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<RstType>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "t" == name)
    return new EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues>();
    
if( 0 == namespaceId && "nop" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "tick" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "rep" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevCell>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ChangeCellSubEdit Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:ccse.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RevCell &lt;xr:c></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RevCell),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ChangeCellSubEdit : OpenXmlCompositeElement
{
    private const string tagName = "ccse";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13562;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "r","t","x","w" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public StringValue R
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType> T
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> x.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
    [SchemaAttr(0, "x")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt> X
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> w.</para>
    /// <para>Represents the following attribute in the schema: w </para>
    /// </summary>
    [SchemaAttr(0, "w")]
    public UInt32Value W
    {
        get { return (UInt32Value)Attributes[3]; }
        set { Attributes[3] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "r" == name)
    return new StringValue();
    
if( 0 == namespaceId && "t" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>();
    
if( 0 == namespaceId && "x" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>();
    
if( 0 == namespaceId && "w" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ChangeCellSubEdit>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ExtensionList Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Extension &lt;x:ext></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Extension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ExtensionList : OpenXmlCompositeElement
{
    private const string tagName = "extLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13563;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ExtensionList>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FormulaFormula Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:formula.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class FormulaFormula : OpenXmlLeafTextElement
{
    private const string tagName = "formula";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13564;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

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
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<FormulaFormula>(deep);
    }

}
/// <summary>
/// <para>Defines the FFormula Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:f.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class FFormula : OpenXmlLeafTextElement
{
    private const string tagName = "f";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13575;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

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
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<FFormula>(deep);
    }

}
/// <summary>
/// <para>Defines the StateBasedHeader Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:hdr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RefMap &lt;xr:refmap></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RefMap),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class StateBasedHeader : OpenXmlCompositeElement
{
    private const string tagName = "hdr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13565;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "uid","eft","eftx","seft","seftx" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> eft.</para>
    /// <para>Represents the following attribute in the schema: eft </para>
    /// </summary>
    [SchemaAttr(0, "eft")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FeatureType> Eft
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FeatureType>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> eftx.</para>
    /// <para>Represents the following attribute in the schema: eftx </para>
    /// </summary>
    [SchemaAttr(0, "eftx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtFeatureType> Eftx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtFeatureType>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> seft.</para>
    /// <para>Represents the following attribute in the schema: seft </para>
    /// </summary>
    [SchemaAttr(0, "seft")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SubFeatureType> Seft
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SubFeatureType>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> seftx.</para>
    /// <para>Represents the following attribute in the schema: seftx </para>
    /// </summary>
    [SchemaAttr(0, "seftx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtSubFeatureType> Seftx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtSubFeatureType>)Attributes[4]; }
        set { Attributes[4] = value; }
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> RefMap.</para>
    /// <para> Represents the following element tag in the schema: xr:refmap </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
    public RefMap RefMap
    {
        get 
        {
            return GetElement<RefMap>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "eft" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FeatureType>();
    
if( 0 == namespaceId && "eftx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtFeatureType>();
    
if( 0 == namespaceId && "seft" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SubFeatureType>();
    
if( 0 == namespaceId && "seftx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtSubFeatureType>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<StateBasedHeader>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevisionStateLink Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:link.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevisionStateLink : OpenXmlLeafElement
{
    private const string tagName = "link";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13566;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id" };
    private static byte[] attributeNamespaceIds = { 19 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RevisionStateLink class.
    /// </summary>
    public RevisionStateLink():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 19 == namespaceId && "id" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevisionStateLink>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RevisionState Class.</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RowColVisualOps),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(HideUnhideSheet),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ShowGridlinesHeadings),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(FreezePanes),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Outlines),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RevisionState : OpenXmlCompositeElement
{
    private const string tagName = "body";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13567;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneChoice;}
    }
    
        /// <summary>
    /// <para> RowColVisualOps.</para>
    /// <para> Represents the following element tag in the schema: xr:rowColVisualOps </para>
    /// </summary>
    /// <remark>
    /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
    /// </remark>
    public RowColVisualOps RowColVisualOps
    {
        get 
        {
            return GetElement<RowColVisualOps>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<HideUnhideSheet>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<ShowGridlinesHeadings>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<FreezePanes>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<Outlines>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RevisionState>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RefMap Class.</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RefCell),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(SheetXluid),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RefOartAnchor),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RefFuture),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RefTest),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RefMap : OpenXmlCompositeElement
{
    private const string tagName = "refmap";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13568;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RefMap>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RowColVisualOps Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:rowColVisualOps.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RowColVisualOps : OpenXmlLeafElement
{
    private const string tagName = "rowColVisualOps";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13569;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "action","isRow","size","userSized" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> action.</para>
    /// <para>Represents the following attribute in the schema: action </para>
    /// </summary>
    [SchemaAttr(0, "action")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOp> Action
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOp>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> isRow.</para>
    /// <para>Represents the following attribute in the schema: isRow </para>
    /// </summary>
    [SchemaAttr(0, "isRow")]
    public BooleanValue IsRow
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public UInt32Value Size
    {
        get { return (UInt32Value)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> userSized.</para>
    /// <para>Represents the following attribute in the schema: userSized </para>
    /// </summary>
    [SchemaAttr(0, "userSized")]
    public BooleanValue UserSized
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RowColVisualOps class.
    /// </summary>
    public RowColVisualOps():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "action" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOp>();
    
if( 0 == namespaceId && "isRow" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "size" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "userSized" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RowColVisualOps>(deep);
    }

   
}
/// <summary>
/// <para>Defines the HideUnhideSheet Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:hideUnhideSheet.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class HideUnhideSheet : OpenXmlLeafElement
{
    private const string tagName = "hideUnhideSheet";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13570;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "hide" };
    private static byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> hide.</para>
    /// <para>Represents the following attribute in the schema: hide </para>
    /// </summary>
    [SchemaAttr(0, "hide")]
    public BooleanValue Hide
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the HideUnhideSheet class.
    /// </summary>
    public HideUnhideSheet():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "hide" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<HideUnhideSheet>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ShowGridlinesHeadings Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:showGridlinesHeadings.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ShowGridlinesHeadings : OpenXmlLeafElement
{
    private const string tagName = "showGridlinesHeadings";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13571;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "showGridLines","showRowCol" };
    private static byte[] attributeNamespaceIds = { 0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> showGridLines.</para>
    /// <para>Represents the following attribute in the schema: showGridLines </para>
    /// </summary>
    [SchemaAttr(0, "showGridLines")]
    public BooleanValue ShowGridLines
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> showRowCol.</para>
    /// <para>Represents the following attribute in the schema: showRowCol </para>
    /// </summary>
    [SchemaAttr(0, "showRowCol")]
    public BooleanValue ShowRowCol
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ShowGridlinesHeadings class.
    /// </summary>
    public ShowGridlinesHeadings():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "showGridLines" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showRowCol" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ShowGridlinesHeadings>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FreezePanes Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:freezePanes.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class FreezePanes : OpenXmlLeafElement
{
    private const string tagName = "freezePanes";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13572;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "sheetViewUid" };
    private static byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> sheetViewUid.</para>
    /// <para>Represents the following attribute in the schema: sheetViewUid </para>
    /// </summary>
    [SchemaAttr(0, "sheetViewUid")]
    public StringValue SheetViewUid
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the FreezePanes class.
    /// </summary>
    public FreezePanes():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "sheetViewUid" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<FreezePanes>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Outlines Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:outlines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Outline &lt;xr:outline></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Outline),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Outlines : OpenXmlCompositeElement
{
    private const string tagName = "outlines";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13573;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "isRow" };
    private static byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> isRow.</para>
    /// <para>Represents the following attribute in the schema: isRow </para>
    /// </summary>
    [SchemaAttr(0, "isRow")]
    public BooleanValue IsRow
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "isRow" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Outlines>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Outline Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:outline.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Outline : OpenXmlLeafElement
{
    private const string tagName = "outline";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13574;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "isCollapsed","level" };
    private static byte[] attributeNamespaceIds = { 0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> isCollapsed.</para>
    /// <para>Represents the following attribute in the schema: isCollapsed </para>
    /// </summary>
    [SchemaAttr(0, "isCollapsed")]
    public BooleanValue IsCollapsed
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> level.</para>
    /// <para>Represents the following attribute in the schema: level </para>
    /// </summary>
    [SchemaAttr(0, "level")]
    public ByteValue Level
    {
        get { return (ByteValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Outline class.
    /// </summary>
    public Outline():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "isCollapsed" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "level" == name)
    return new ByteValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Outline>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Xstring Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:v.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Xstring : OpenXmlLeafTextElement
{
    private const string tagName = "v";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13576;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Xstring>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RstType Class.</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Text))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Run))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RstType : OpenXmlCompositeElement
{
    private const string tagName = "is";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13577;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Text.</para>
    /// <para> Represents the following element tag in the schema: x:t </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.Text Text
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.Text>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RstType>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RefCell Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:ref.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RefCell : OpenXmlLeafElement
{
    private const string tagName = "ref";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13578;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "n","ajt","ajtx","homeRef","r","uid","uidLast" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> n.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
    [SchemaAttr(0, "n")]
    public StringValue N
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> ajt.</para>
    /// <para>Represents the following attribute in the schema: ajt </para>
    /// </summary>
    [SchemaAttr(0, "ajt")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> ajtx.</para>
    /// <para>Represents the following attribute in the schema: ajtx </para>
    /// </summary>
    [SchemaAttr(0, "ajtx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> homeRef.</para>
    /// <para>Represents the following attribute in the schema: homeRef </para>
    /// </summary>
    [SchemaAttr(0, "homeRef")]
    public BooleanValue HomeRef
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public ListValue<StringValue> R
    {
        get { return (ListValue<StringValue>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> uidLast.</para>
    /// <para>Represents the following attribute in the schema: uidLast </para>
    /// </summary>
    [SchemaAttr(0, "uidLast")]
    public StringValue UidLast
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RefCell class.
    /// </summary>
    public RefCell():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "n" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ajt" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>();
    
if( 0 == namespaceId && "ajtx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>();
    
if( 0 == namespaceId && "homeRef" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "r" == name)
    return new ListValue<StringValue>();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "uidLast" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RefCell>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SheetXluid Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:sheetUid.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class SheetXluid : OpenXmlLeafElement
{
    private const string tagName = "sheetUid";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13579;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "n","ajt","ajtx","homeRef","uid" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> n.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
    [SchemaAttr(0, "n")]
    public StringValue N
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> ajt.</para>
    /// <para>Represents the following attribute in the schema: ajt </para>
    /// </summary>
    [SchemaAttr(0, "ajt")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> ajtx.</para>
    /// <para>Represents the following attribute in the schema: ajtx </para>
    /// </summary>
    [SchemaAttr(0, "ajtx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> homeRef.</para>
    /// <para>Represents the following attribute in the schema: homeRef </para>
    /// </summary>
    [SchemaAttr(0, "homeRef")]
    public BooleanValue HomeRef
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> uid.</para>
    /// <para>Represents the following attribute in the schema: uid </para>
    /// </summary>
    [SchemaAttr(0, "uid")]
    public StringValue Uid
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SheetXluid class.
    /// </summary>
    public SheetXluid():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "n" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ajt" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>();
    
if( 0 == namespaceId && "ajtx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>();
    
if( 0 == namespaceId && "homeRef" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "uid" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SheetXluid>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RefOartAnchor Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:oartAnchor.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RefOartAnchor : OpenXmlLeafElement
{
    private const string tagName = "oartAnchor";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13580;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "n","ajt","ajtx","homeRef","r","fromRowOff","fromColOff","toRowOff","toColOff","cx","cy","x","y","oat" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> n.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
    [SchemaAttr(0, "n")]
    public StringValue N
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> ajt.</para>
    /// <para>Represents the following attribute in the schema: ajt </para>
    /// </summary>
    [SchemaAttr(0, "ajt")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> ajtx.</para>
    /// <para>Represents the following attribute in the schema: ajtx </para>
    /// </summary>
    [SchemaAttr(0, "ajtx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> homeRef.</para>
    /// <para>Represents the following attribute in the schema: homeRef </para>
    /// </summary>
    [SchemaAttr(0, "homeRef")]
    public BooleanValue HomeRef
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public StringValue R
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> fromRowOff.</para>
    /// <para>Represents the following attribute in the schema: fromRowOff </para>
    /// </summary>
    [SchemaAttr(0, "fromRowOff")]
    public Int64Value FromRowOff
    {
        get { return (Int64Value)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> fromColOff.</para>
    /// <para>Represents the following attribute in the schema: fromColOff </para>
    /// </summary>
    [SchemaAttr(0, "fromColOff")]
    public Int64Value FromColOff
    {
        get { return (Int64Value)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> toRowOff.</para>
    /// <para>Represents the following attribute in the schema: toRowOff </para>
    /// </summary>
    [SchemaAttr(0, "toRowOff")]
    public Int64Value ToRowOff
    {
        get { return (Int64Value)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> toColOff.</para>
    /// <para>Represents the following attribute in the schema: toColOff </para>
    /// </summary>
    [SchemaAttr(0, "toColOff")]
    public Int64Value ToColOff
    {
        get { return (Int64Value)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> cx.</para>
    /// <para>Represents the following attribute in the schema: cx </para>
    /// </summary>
    [SchemaAttr(0, "cx")]
    public Int64Value Cx
    {
        get { return (Int64Value)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> cy.</para>
    /// <para>Represents the following attribute in the schema: cy </para>
    /// </summary>
    [SchemaAttr(0, "cy")]
    public Int64Value Cy
    {
        get { return (Int64Value)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> x.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
    [SchemaAttr(0, "x")]
    public Int64Value X
    {
        get { return (Int64Value)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> y.</para>
    /// <para>Represents the following attribute in the schema: y </para>
    /// </summary>
    [SchemaAttr(0, "y")]
    public Int64Value Y
    {
        get { return (Int64Value)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> oat.</para>
    /// <para>Represents the following attribute in the schema: oat </para>
    /// </summary>
    [SchemaAttr(0, "oat")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.OartAnchorType> Oat
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.OartAnchorType>)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RefOartAnchor class.
    /// </summary>
    public RefOartAnchor():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "n" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ajt" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>();
    
if( 0 == namespaceId && "ajtx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>();
    
if( 0 == namespaceId && "homeRef" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "r" == name)
    return new StringValue();
    
if( 0 == namespaceId && "fromRowOff" == name)
    return new Int64Value();
    
if( 0 == namespaceId && "fromColOff" == name)
    return new Int64Value();
    
if( 0 == namespaceId && "toRowOff" == name)
    return new Int64Value();
    
if( 0 == namespaceId && "toColOff" == name)
    return new Int64Value();
    
if( 0 == namespaceId && "cx" == name)
    return new Int64Value();
    
if( 0 == namespaceId && "cy" == name)
    return new Int64Value();
    
if( 0 == namespaceId && "x" == name)
    return new Int64Value();
    
if( 0 == namespaceId && "y" == name)
    return new Int64Value();
    
if( 0 == namespaceId && "oat" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.OartAnchorType>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RefOartAnchor>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RefFuture Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:future.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RefFuture : OpenXmlLeafElement
{
    private const string tagName = "future";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13581;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RefFuture class.
    /// </summary>
    public RefFuture():base(){}
    
      
     
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RefFuture>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RefTest Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:test.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RefTest : OpenXmlLeafElement
{
    private const string tagName = "test";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13582;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "n","ajt","ajtx","homeRef" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> n.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
    [SchemaAttr(0, "n")]
    public StringValue N
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> ajt.</para>
    /// <para>Represents the following attribute in the schema: ajt </para>
    /// </summary>
    [SchemaAttr(0, "ajt")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType> Ajt
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> ajtx.</para>
    /// <para>Represents the following attribute in the schema: ajtx </para>
    /// </summary>
    [SchemaAttr(0, "ajtx")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt> Ajtx
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> homeRef.</para>
    /// <para>Represents the following attribute in the schema: homeRef </para>
    /// </summary>
    [SchemaAttr(0, "homeRef")]
    public BooleanValue HomeRef
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RefTest class.
    /// </summary>
    public RefTest():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "n" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ajt" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>();
    
if( 0 == namespaceId && "ajtx" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>();
    
if( 0 == namespaceId && "homeRef" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RefTest>(deep);
    }

   
}
/// <summary>
/// <para>Represents an external link to another workbook..</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.ExcelAc.List),(FileFormatVersions)12)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Formula1))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Formula2))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class DataValidation : OpenXmlCompositeElement
{
    private const string tagName = "dataValidation";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13583;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "type","errorStyle","imeMode","operator","allowBlank","showDropDown","showInputMessage","showErrorMessage","errorTitle","error","promptTitle","prompt","sqref" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> errorStyle.</para>
    /// <para>Represents the following attribute in the schema: errorStyle </para>
    /// </summary>
    [SchemaAttr(0, "errorStyle")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues> ErrorStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> imeMode.</para>
    /// <para>Represents the following attribute in the schema: imeMode </para>
    /// </summary>
    [SchemaAttr(0, "imeMode")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues> ImeMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> operator.</para>
    /// <para>Represents the following attribute in the schema: operator </para>
    /// </summary>
    [SchemaAttr(0, "operator")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues> Operator
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> allowBlank.</para>
    /// <para>Represents the following attribute in the schema: allowBlank </para>
    /// </summary>
    [SchemaAttr(0, "allowBlank")]
    public BooleanValue AllowBlank
    {
        get { return (BooleanValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> showDropDown.</para>
    /// <para>Represents the following attribute in the schema: showDropDown </para>
    /// </summary>
    [SchemaAttr(0, "showDropDown")]
    public BooleanValue ShowDropDown
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> showInputMessage.</para>
    /// <para>Represents the following attribute in the schema: showInputMessage </para>
    /// </summary>
    [SchemaAttr(0, "showInputMessage")]
    public BooleanValue ShowInputMessage
    {
        get { return (BooleanValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> showErrorMessage.</para>
    /// <para>Represents the following attribute in the schema: showErrorMessage </para>
    /// </summary>
    [SchemaAttr(0, "showErrorMessage")]
    public BooleanValue ShowErrorMessage
    {
        get { return (BooleanValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> errorTitle.</para>
    /// <para>Represents the following attribute in the schema: errorTitle </para>
    /// </summary>
    [SchemaAttr(0, "errorTitle")]
    public StringValue ErrorTitle
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> error.</para>
    /// <para>Represents the following attribute in the schema: error </para>
    /// </summary>
    [SchemaAttr(0, "error")]
    public StringValue Error
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> promptTitle.</para>
    /// <para>Represents the following attribute in the schema: promptTitle </para>
    /// </summary>
    [SchemaAttr(0, "promptTitle")]
    public StringValue PromptTitle
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> prompt.</para>
    /// <para>Represents the following attribute in the schema: prompt </para>
    /// </summary>
    [SchemaAttr(0, "prompt")]
    public StringValue Prompt
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> sqref.</para>
    /// <para>Represents the following attribute in the schema: sqref </para>
    /// </summary>
    [SchemaAttr(0, "sqref")]
    public ListValue<StringValue> SequenceOfReferences
    {
        get { return (ListValue<StringValue>)Attributes[12]; }
        set { Attributes[12] = value; }
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> List.</para>
    /// <para> Represents the following element tag in the schema: x12ac:list </para>
    /// </summary>
    /// <remark>
    /// xmlns:x12ac = http://schemas.microsoft.com/office/spreadsheetml/2011/1/ac
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.ExcelAc.List List
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.ExcelAc.List>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.Formula1>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.Formula2>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues>();
    
if( 0 == namespaceId && "errorStyle" == name)
    return new EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues>();
    
if( 0 == namespaceId && "imeMode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues>();
    
if( 0 == namespaceId && "operator" == name)
    return new EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues>();
    
if( 0 == namespaceId && "allowBlank" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showDropDown" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showInputMessage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showErrorMessage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "errorTitle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "error" == name)
    return new StringValue();
    
if( 0 == namespaceId && "promptTitle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "prompt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sqref" == name)
    return new ListValue<StringValue>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DataValidation>(deep);
    }

   
}
/// <summary>
/// <para>Represents a hyperlink within a cell..</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is xr:hyperlink.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Hyperlink : OpenXmlLeafElement
{
    private const string tagName = "hyperlink";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13584;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ref","id","location","tooltip","display" };
    private static byte[] attributeNamespaceIds = { 0,19,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Reference.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Reference
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
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
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Location.</para>
    /// <para>Represents the following attribute in the schema: location </para>
    /// </summary>
    [SchemaAttr(0, "location")]
    public StringValue Location
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Tool Tip.</para>
    /// <para>Represents the following attribute in the schema: tooltip </para>
    /// </summary>
    [SchemaAttr(0, "tooltip")]
    public StringValue Tooltip
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Display String.</para>
    /// <para>Represents the following attribute in the schema: display </para>
    /// </summary>
    [SchemaAttr(0, "display")]
    public StringValue Display
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Hyperlink class.
    /// </summary>
    public Hyperlink():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "ref" == name)
    return new StringValue();
    
if( 19 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "location" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tooltip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "display" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Hyperlink>(deep);
    }

   
}
/// <summary>
/// <para>Represents a sparkline group of 1 or more sparklines..</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.SeriesColor),(FileFormatVersions)14)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.NegativeColor),(FileFormatVersions)14)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.AxisColor),(FileFormatVersions)14)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.MarkersColor),(FileFormatVersions)14)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor),(FileFormatVersions)14)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor),(FileFormatVersions)14)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor),(FileFormatVersions)14)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor),(FileFormatVersions)14)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.Sparklines),(FileFormatVersions)14)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class SparklineGroup : OpenXmlCompositeElement
{
    private const string tagName = "sparklineGroup";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13585;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "manualMax","manualMin","lineWeight","type","dateAxis","displayEmptyCellsAs","markers","high","low","first","last","negative","displayXAxis","displayHidden","minAxisType","maxAxisType","rightToLeft" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> manualMax.</para>
    /// <para>Represents the following attribute in the schema: manualMax </para>
    /// </summary>
    [SchemaAttr(0, "manualMax")]
    public DoubleValue ManualMax
    {
        get { return (DoubleValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> manualMin.</para>
    /// <para>Represents the following attribute in the schema: manualMin </para>
    /// </summary>
    [SchemaAttr(0, "manualMin")]
    public DoubleValue ManualMin
    {
        get { return (DoubleValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> lineWeight.</para>
    /// <para>Represents the following attribute in the schema: lineWeight </para>
    /// </summary>
    [SchemaAttr(0, "lineWeight")]
    public DoubleValue LineWeight
    {
        get { return (DoubleValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> dateAxis.</para>
    /// <para>Represents the following attribute in the schema: dateAxis </para>
    /// </summary>
    [SchemaAttr(0, "dateAxis")]
    public BooleanValue DateAxis
    {
        get { return (BooleanValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> displayEmptyCellsAs.</para>
    /// <para>Represents the following attribute in the schema: displayEmptyCellsAs </para>
    /// </summary>
    [SchemaAttr(0, "displayEmptyCellsAs")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues> DisplayEmptyCellsAs
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues>)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> markers.</para>
    /// <para>Represents the following attribute in the schema: markers </para>
    /// </summary>
    [SchemaAttr(0, "markers")]
    public BooleanValue Markers
    {
        get { return (BooleanValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> high.</para>
    /// <para>Represents the following attribute in the schema: high </para>
    /// </summary>
    [SchemaAttr(0, "high")]
    public BooleanValue High
    {
        get { return (BooleanValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> low.</para>
    /// <para>Represents the following attribute in the schema: low </para>
    /// </summary>
    [SchemaAttr(0, "low")]
    public BooleanValue Low
    {
        get { return (BooleanValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> first.</para>
    /// <para>Represents the following attribute in the schema: first </para>
    /// </summary>
    [SchemaAttr(0, "first")]
    public BooleanValue First
    {
        get { return (BooleanValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> last.</para>
    /// <para>Represents the following attribute in the schema: last </para>
    /// </summary>
    [SchemaAttr(0, "last")]
    public BooleanValue Last
    {
        get { return (BooleanValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> negative.</para>
    /// <para>Represents the following attribute in the schema: negative </para>
    /// </summary>
    [SchemaAttr(0, "negative")]
    public BooleanValue Negative
    {
        get { return (BooleanValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> displayXAxis.</para>
    /// <para>Represents the following attribute in the schema: displayXAxis </para>
    /// </summary>
    [SchemaAttr(0, "displayXAxis")]
    public BooleanValue DisplayXAxis
    {
        get { return (BooleanValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> displayHidden.</para>
    /// <para>Represents the following attribute in the schema: displayHidden </para>
    /// </summary>
    [SchemaAttr(0, "displayHidden")]
    public BooleanValue DisplayHidden
    {
        get { return (BooleanValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> minAxisType.</para>
    /// <para>Represents the following attribute in the schema: minAxisType </para>
    /// </summary>
    [SchemaAttr(0, "minAxisType")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues> MinAxisType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> maxAxisType.</para>
    /// <para>Represents the following attribute in the schema: maxAxisType </para>
    /// </summary>
    [SchemaAttr(0, "maxAxisType")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues> MaxAxisType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> rightToLeft.</para>
    /// <para>Represents the following attribute in the schema: rightToLeft </para>
    /// </summary>
    [SchemaAttr(0, "rightToLeft")]
    public BooleanValue RightToLeft
    {
        get { return (BooleanValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> SeriesColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorSeries </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Excel.SeriesColor SeriesColor
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Excel.SeriesColor>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Excel.NegativeColor>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Excel.AxisColor>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Excel.MarkersColor>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor>(4);
        }
        set
        {
            SetElement(4, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor>(5);
        }
        set
        {
            SetElement(5, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor>(6);
        }
        set
        {
            SetElement(6, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor>(7);
        }
        set
        {
            SetElement(7, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>(8);
        }
        set
        {
            SetElement(8, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Excel.Sparklines>(9);
        }
        set
        {
            SetElement(9, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "manualMax" == name)
    return new DoubleValue();
    
if( 0 == namespaceId && "manualMin" == name)
    return new DoubleValue();
    
if( 0 == namespaceId && "lineWeight" == name)
    return new DoubleValue();
    
if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues>();
    
if( 0 == namespaceId && "dateAxis" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "displayEmptyCellsAs" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues>();
    
if( 0 == namespaceId && "markers" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "high" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "low" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "first" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "last" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "negative" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "displayXAxis" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "displayHidden" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "minAxisType" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>();
    
if( 0 == namespaceId && "maxAxisType" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>();
    
if( 0 == namespaceId && "rightToLeft" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SparklineGroup>(deep);
    }

   
}
/// <summary>
/// <para>Represents one comment within a cell..</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Authors))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.CommentList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Comments : OpenXmlCompositeElement
{
    private const string tagName = "comments";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13586;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Authors.</para>
    /// <para> Represents the following element tag in the schema: x:authors </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.Authors Authors
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.Authors>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.CommentList>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Comments>(deep);
    }

   
}
/// <summary>
/// <para>Represents an autofilter..</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.FilterColumn))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SortState))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class AutoFilter : OpenXmlCompositeElement
{
    private const string tagName = "autoFilter";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13587;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ref" };
    private static byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Cell or Range Reference.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Reference
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "ref" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AutoFilter>(deep);
    }

   
}
/// <summary>
/// <para>Represents a PivotTable View..</para>
///<para>This class is only available in Office 2016.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class pivotTableDefinition : OpenXmlCompositeElement
{
    private const string tagName = "pivotTableDefinition";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 83;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13588;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "name","cacheId","dataOnRows","dataPosition","autoFormatId","applyNumberFormats","applyBorderFormats","applyFontFormats","applyPatternFormats","applyAlignmentFormats","applyWidthHeightFormats","dataCaption","grandTotalCaption","errorCaption","showError","missingCaption","showMissing","pageStyle","pivotTableStyle","vacatedStyle","tag","updatedVersion","minRefreshableVersion","asteriskTotals","showItems","editData","disableFieldList","showCalcMbrs","visualTotals","showMultipleLabel","showDataDropDown","showDrill","printDrill","showMemberPropertyTips","showDataTips","enableWizard","enableDrill","enableFieldProperties","preserveFormatting","useAutoFormatting","pageWrap","pageOverThenDown","subtotalHiddenItems","rowGrandTotals","colGrandTotals","fieldPrintTitles","itemPrintTitles","mergeItem","showDropZones","createdVersion","indent","showEmptyRow","showEmptyCol","showHeaders","compact","outline","outlineData","compactData","published","gridDropZones","immersive","multipleFieldFilters","chartFormat","rowHeaderCaption","colHeaderCaption","fieldListSortAscending","mdxSubqueries","customListSort" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> cacheId.</para>
    /// <para>Represents the following attribute in the schema: cacheId </para>
    /// </summary>
    [SchemaAttr(0, "cacheId")]
    public UInt32Value CacheId
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> dataOnRows.</para>
    /// <para>Represents the following attribute in the schema: dataOnRows </para>
    /// </summary>
    [SchemaAttr(0, "dataOnRows")]
    public BooleanValue DataOnRows
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> dataPosition.</para>
    /// <para>Represents the following attribute in the schema: dataPosition </para>
    /// </summary>
    [SchemaAttr(0, "dataPosition")]
    public UInt32Value DataPosition
    {
        get { return (UInt32Value)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Auto Format Id.</para>
    /// <para>Represents the following attribute in the schema: autoFormatId </para>
    /// </summary>
    [SchemaAttr(0, "autoFormatId")]
    public UInt32Value AutoFormatId
    {
        get { return (UInt32Value)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Apply Number Formats.</para>
    /// <para>Represents the following attribute in the schema: applyNumberFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyNumberFormats")]
    public BooleanValue ApplyNumberFormats
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Apply Border Formats.</para>
    /// <para>Represents the following attribute in the schema: applyBorderFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyBorderFormats")]
    public BooleanValue ApplyBorderFormats
    {
        get { return (BooleanValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Apply Font Formats.</para>
    /// <para>Represents the following attribute in the schema: applyFontFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyFontFormats")]
    public BooleanValue ApplyFontFormats
    {
        get { return (BooleanValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Apply Pattern Formats.</para>
    /// <para>Represents the following attribute in the schema: applyPatternFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyPatternFormats")]
    public BooleanValue ApplyPatternFormats
    {
        get { return (BooleanValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Apply Alignment Formats.</para>
    /// <para>Represents the following attribute in the schema: applyAlignmentFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyAlignmentFormats")]
    public BooleanValue ApplyAlignmentFormats
    {
        get { return (BooleanValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Apply Width / Height Formats.</para>
    /// <para>Represents the following attribute in the schema: applyWidthHeightFormats </para>
    /// </summary>
    [SchemaAttr(0, "applyWidthHeightFormats")]
    public BooleanValue ApplyWidthHeightFormats
    {
        get { return (BooleanValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> dataCaption.</para>
    /// <para>Represents the following attribute in the schema: dataCaption </para>
    /// </summary>
    [SchemaAttr(0, "dataCaption")]
    public StringValue DataCaption
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> grandTotalCaption.</para>
    /// <para>Represents the following attribute in the schema: grandTotalCaption </para>
    /// </summary>
    [SchemaAttr(0, "grandTotalCaption")]
    public StringValue GrandTotalCaption
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> errorCaption.</para>
    /// <para>Represents the following attribute in the schema: errorCaption </para>
    /// </summary>
    [SchemaAttr(0, "errorCaption")]
    public StringValue ErrorCaption
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> showError.</para>
    /// <para>Represents the following attribute in the schema: showError </para>
    /// </summary>
    [SchemaAttr(0, "showError")]
    public BooleanValue ShowError
    {
        get { return (BooleanValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> missingCaption.</para>
    /// <para>Represents the following attribute in the schema: missingCaption </para>
    /// </summary>
    [SchemaAttr(0, "missingCaption")]
    public StringValue MissingCaption
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> showMissing.</para>
    /// <para>Represents the following attribute in the schema: showMissing </para>
    /// </summary>
    [SchemaAttr(0, "showMissing")]
    public BooleanValue ShowMissing
    {
        get { return (BooleanValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> pageStyle.</para>
    /// <para>Represents the following attribute in the schema: pageStyle </para>
    /// </summary>
    [SchemaAttr(0, "pageStyle")]
    public StringValue PageStyle
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> pivotTableStyle.</para>
    /// <para>Represents the following attribute in the schema: pivotTableStyle </para>
    /// </summary>
    [SchemaAttr(0, "pivotTableStyle")]
    public StringValue PivotTableStyleName
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> vacatedStyle.</para>
    /// <para>Represents the following attribute in the schema: vacatedStyle </para>
    /// </summary>
    [SchemaAttr(0, "vacatedStyle")]
    public StringValue VacatedStyle
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> updatedVersion.</para>
    /// <para>Represents the following attribute in the schema: updatedVersion </para>
    /// </summary>
    [SchemaAttr(0, "updatedVersion")]
    public ByteValue UpdatedVersion
    {
        get { return (ByteValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> minRefreshableVersion.</para>
    /// <para>Represents the following attribute in the schema: minRefreshableVersion </para>
    /// </summary>
    [SchemaAttr(0, "minRefreshableVersion")]
    public ByteValue MinRefreshableVersion
    {
        get { return (ByteValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> asteriskTotals.</para>
    /// <para>Represents the following attribute in the schema: asteriskTotals </para>
    /// </summary>
    [SchemaAttr(0, "asteriskTotals")]
    public BooleanValue AsteriskTotals
    {
        get { return (BooleanValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> showItems.</para>
    /// <para>Represents the following attribute in the schema: showItems </para>
    /// </summary>
    [SchemaAttr(0, "showItems")]
    public BooleanValue ShowItems
    {
        get { return (BooleanValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> editData.</para>
    /// <para>Represents the following attribute in the schema: editData </para>
    /// </summary>
    [SchemaAttr(0, "editData")]
    public BooleanValue EditData
    {
        get { return (BooleanValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> disableFieldList.</para>
    /// <para>Represents the following attribute in the schema: disableFieldList </para>
    /// </summary>
    [SchemaAttr(0, "disableFieldList")]
    public BooleanValue DisableFieldList
    {
        get { return (BooleanValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> showCalcMbrs.</para>
    /// <para>Represents the following attribute in the schema: showCalcMbrs </para>
    /// </summary>
    [SchemaAttr(0, "showCalcMbrs")]
    public BooleanValue ShowCalculatedMembers
    {
        get { return (BooleanValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> visualTotals.</para>
    /// <para>Represents the following attribute in the schema: visualTotals </para>
    /// </summary>
    [SchemaAttr(0, "visualTotals")]
    public BooleanValue VisualTotals
    {
        get { return (BooleanValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> showMultipleLabel.</para>
    /// <para>Represents the following attribute in the schema: showMultipleLabel </para>
    /// </summary>
    [SchemaAttr(0, "showMultipleLabel")]
    public BooleanValue ShowMultipleLabel
    {
        get { return (BooleanValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> showDataDropDown.</para>
    /// <para>Represents the following attribute in the schema: showDataDropDown </para>
    /// </summary>
    [SchemaAttr(0, "showDataDropDown")]
    public BooleanValue ShowDataDropDown
    {
        get { return (BooleanValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    
    /// <summary>
    /// <para> showDrill.</para>
    /// <para>Represents the following attribute in the schema: showDrill </para>
    /// </summary>
    [SchemaAttr(0, "showDrill")]
    public BooleanValue ShowDrill
    {
        get { return (BooleanValue)Attributes[31]; }
        set { Attributes[31] = value; }
    }
    
    /// <summary>
    /// <para> printDrill.</para>
    /// <para>Represents the following attribute in the schema: printDrill </para>
    /// </summary>
    [SchemaAttr(0, "printDrill")]
    public BooleanValue PrintDrill
    {
        get { return (BooleanValue)Attributes[32]; }
        set { Attributes[32] = value; }
    }
    
    /// <summary>
    /// <para> showMemberPropertyTips.</para>
    /// <para>Represents the following attribute in the schema: showMemberPropertyTips </para>
    /// </summary>
    [SchemaAttr(0, "showMemberPropertyTips")]
    public BooleanValue ShowMemberPropertyTips
    {
        get { return (BooleanValue)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> showDataTips.</para>
    /// <para>Represents the following attribute in the schema: showDataTips </para>
    /// </summary>
    [SchemaAttr(0, "showDataTips")]
    public BooleanValue ShowDataTips
    {
        get { return (BooleanValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> enableWizard.</para>
    /// <para>Represents the following attribute in the schema: enableWizard </para>
    /// </summary>
    [SchemaAttr(0, "enableWizard")]
    public BooleanValue EnableWizard
    {
        get { return (BooleanValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> enableDrill.</para>
    /// <para>Represents the following attribute in the schema: enableDrill </para>
    /// </summary>
    [SchemaAttr(0, "enableDrill")]
    public BooleanValue EnableDrill
    {
        get { return (BooleanValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> enableFieldProperties.</para>
    /// <para>Represents the following attribute in the schema: enableFieldProperties </para>
    /// </summary>
    [SchemaAttr(0, "enableFieldProperties")]
    public BooleanValue EnableFieldProperties
    {
        get { return (BooleanValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> preserveFormatting.</para>
    /// <para>Represents the following attribute in the schema: preserveFormatting </para>
    /// </summary>
    [SchemaAttr(0, "preserveFormatting")]
    public BooleanValue PreserveFormatting
    {
        get { return (BooleanValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    
    /// <summary>
    /// <para> useAutoFormatting.</para>
    /// <para>Represents the following attribute in the schema: useAutoFormatting </para>
    /// </summary>
    [SchemaAttr(0, "useAutoFormatting")]
    public BooleanValue UseAutoFormatting
    {
        get { return (BooleanValue)Attributes[39]; }
        set { Attributes[39] = value; }
    }
    
    /// <summary>
    /// <para> pageWrap.</para>
    /// <para>Represents the following attribute in the schema: pageWrap </para>
    /// </summary>
    [SchemaAttr(0, "pageWrap")]
    public UInt32Value PageWrap
    {
        get { return (UInt32Value)Attributes[40]; }
        set { Attributes[40] = value; }
    }
    
    /// <summary>
    /// <para> pageOverThenDown.</para>
    /// <para>Represents the following attribute in the schema: pageOverThenDown </para>
    /// </summary>
    [SchemaAttr(0, "pageOverThenDown")]
    public BooleanValue PageOverThenDown
    {
        get { return (BooleanValue)Attributes[41]; }
        set { Attributes[41] = value; }
    }
    
    /// <summary>
    /// <para> subtotalHiddenItems.</para>
    /// <para>Represents the following attribute in the schema: subtotalHiddenItems </para>
    /// </summary>
    [SchemaAttr(0, "subtotalHiddenItems")]
    public BooleanValue SubtotalHiddenItems
    {
        get { return (BooleanValue)Attributes[42]; }
        set { Attributes[42] = value; }
    }
    
    /// <summary>
    /// <para> rowGrandTotals.</para>
    /// <para>Represents the following attribute in the schema: rowGrandTotals </para>
    /// </summary>
    [SchemaAttr(0, "rowGrandTotals")]
    public BooleanValue RowGrandTotals
    {
        get { return (BooleanValue)Attributes[43]; }
        set { Attributes[43] = value; }
    }
    
    /// <summary>
    /// <para> colGrandTotals.</para>
    /// <para>Represents the following attribute in the schema: colGrandTotals </para>
    /// </summary>
    [SchemaAttr(0, "colGrandTotals")]
    public BooleanValue ColumnGrandTotals
    {
        get { return (BooleanValue)Attributes[44]; }
        set { Attributes[44] = value; }
    }
    
    /// <summary>
    /// <para> fieldPrintTitles.</para>
    /// <para>Represents the following attribute in the schema: fieldPrintTitles </para>
    /// </summary>
    [SchemaAttr(0, "fieldPrintTitles")]
    public BooleanValue FieldPrintTitles
    {
        get { return (BooleanValue)Attributes[45]; }
        set { Attributes[45] = value; }
    }
    
    /// <summary>
    /// <para> itemPrintTitles.</para>
    /// <para>Represents the following attribute in the schema: itemPrintTitles </para>
    /// </summary>
    [SchemaAttr(0, "itemPrintTitles")]
    public BooleanValue ItemPrintTitles
    {
        get { return (BooleanValue)Attributes[46]; }
        set { Attributes[46] = value; }
    }
    
    /// <summary>
    /// <para> mergeItem.</para>
    /// <para>Represents the following attribute in the schema: mergeItem </para>
    /// </summary>
    [SchemaAttr(0, "mergeItem")]
    public BooleanValue MergeItem
    {
        get { return (BooleanValue)Attributes[47]; }
        set { Attributes[47] = value; }
    }
    
    /// <summary>
    /// <para> showDropZones.</para>
    /// <para>Represents the following attribute in the schema: showDropZones </para>
    /// </summary>
    [SchemaAttr(0, "showDropZones")]
    public BooleanValue ShowDropZones
    {
        get { return (BooleanValue)Attributes[48]; }
        set { Attributes[48] = value; }
    }
    
    /// <summary>
    /// <para> createdVersion.</para>
    /// <para>Represents the following attribute in the schema: createdVersion </para>
    /// </summary>
    [SchemaAttr(0, "createdVersion")]
    public ByteValue CreatedVersion
    {
        get { return (ByteValue)Attributes[49]; }
        set { Attributes[49] = value; }
    }
    
    /// <summary>
    /// <para> indent.</para>
    /// <para>Represents the following attribute in the schema: indent </para>
    /// </summary>
    [SchemaAttr(0, "indent")]
    public UInt32Value Indent
    {
        get { return (UInt32Value)Attributes[50]; }
        set { Attributes[50] = value; }
    }
    
    /// <summary>
    /// <para> showEmptyRow.</para>
    /// <para>Represents the following attribute in the schema: showEmptyRow </para>
    /// </summary>
    [SchemaAttr(0, "showEmptyRow")]
    public BooleanValue ShowEmptyRow
    {
        get { return (BooleanValue)Attributes[51]; }
        set { Attributes[51] = value; }
    }
    
    /// <summary>
    /// <para> showEmptyCol.</para>
    /// <para>Represents the following attribute in the schema: showEmptyCol </para>
    /// </summary>
    [SchemaAttr(0, "showEmptyCol")]
    public BooleanValue ShowEmptyColumn
    {
        get { return (BooleanValue)Attributes[52]; }
        set { Attributes[52] = value; }
    }
    
    /// <summary>
    /// <para> showHeaders.</para>
    /// <para>Represents the following attribute in the schema: showHeaders </para>
    /// </summary>
    [SchemaAttr(0, "showHeaders")]
    public BooleanValue ShowHeaders
    {
        get { return (BooleanValue)Attributes[53]; }
        set { Attributes[53] = value; }
    }
    
    /// <summary>
    /// <para> compact.</para>
    /// <para>Represents the following attribute in the schema: compact </para>
    /// </summary>
    [SchemaAttr(0, "compact")]
    public BooleanValue Compact
    {
        get { return (BooleanValue)Attributes[54]; }
        set { Attributes[54] = value; }
    }
    
    /// <summary>
    /// <para> outline.</para>
    /// <para>Represents the following attribute in the schema: outline </para>
    /// </summary>
    [SchemaAttr(0, "outline")]
    public BooleanValue Outline
    {
        get { return (BooleanValue)Attributes[55]; }
        set { Attributes[55] = value; }
    }
    
    /// <summary>
    /// <para> outlineData.</para>
    /// <para>Represents the following attribute in the schema: outlineData </para>
    /// </summary>
    [SchemaAttr(0, "outlineData")]
    public BooleanValue OutlineData
    {
        get { return (BooleanValue)Attributes[56]; }
        set { Attributes[56] = value; }
    }
    
    /// <summary>
    /// <para> compactData.</para>
    /// <para>Represents the following attribute in the schema: compactData </para>
    /// </summary>
    [SchemaAttr(0, "compactData")]
    public BooleanValue CompactData
    {
        get { return (BooleanValue)Attributes[57]; }
        set { Attributes[57] = value; }
    }
    
    /// <summary>
    /// <para> published.</para>
    /// <para>Represents the following attribute in the schema: published </para>
    /// </summary>
    [SchemaAttr(0, "published")]
    public BooleanValue Published
    {
        get { return (BooleanValue)Attributes[58]; }
        set { Attributes[58] = value; }
    }
    
    /// <summary>
    /// <para> gridDropZones.</para>
    /// <para>Represents the following attribute in the schema: gridDropZones </para>
    /// </summary>
    [SchemaAttr(0, "gridDropZones")]
    public BooleanValue GridDropZones
    {
        get { return (BooleanValue)Attributes[59]; }
        set { Attributes[59] = value; }
    }
    
    /// <summary>
    /// <para> immersive.</para>
    /// <para>Represents the following attribute in the schema: immersive </para>
    /// </summary>
    [SchemaAttr(0, "immersive")]
    public BooleanValue StopImmersiveUi
    {
        get { return (BooleanValue)Attributes[60]; }
        set { Attributes[60] = value; }
    }
    
    /// <summary>
    /// <para> multipleFieldFilters.</para>
    /// <para>Represents the following attribute in the schema: multipleFieldFilters </para>
    /// </summary>
    [SchemaAttr(0, "multipleFieldFilters")]
    public BooleanValue MultipleFieldFilters
    {
        get { return (BooleanValue)Attributes[61]; }
        set { Attributes[61] = value; }
    }
    
    /// <summary>
    /// <para> chartFormat.</para>
    /// <para>Represents the following attribute in the schema: chartFormat </para>
    /// </summary>
    [SchemaAttr(0, "chartFormat")]
    public UInt32Value ChartFormat
    {
        get { return (UInt32Value)Attributes[62]; }
        set { Attributes[62] = value; }
    }
    
    /// <summary>
    /// <para> rowHeaderCaption.</para>
    /// <para>Represents the following attribute in the schema: rowHeaderCaption </para>
    /// </summary>
    [SchemaAttr(0, "rowHeaderCaption")]
    public StringValue RowHeaderCaption
    {
        get { return (StringValue)Attributes[63]; }
        set { Attributes[63] = value; }
    }
    
    /// <summary>
    /// <para> colHeaderCaption.</para>
    /// <para>Represents the following attribute in the schema: colHeaderCaption </para>
    /// </summary>
    [SchemaAttr(0, "colHeaderCaption")]
    public StringValue ColumnHeaderCaption
    {
        get { return (StringValue)Attributes[64]; }
        set { Attributes[64] = value; }
    }
    
    /// <summary>
    /// <para> fieldListSortAscending.</para>
    /// <para>Represents the following attribute in the schema: fieldListSortAscending </para>
    /// </summary>
    [SchemaAttr(0, "fieldListSortAscending")]
    public BooleanValue FieldListSortAscending
    {
        get { return (BooleanValue)Attributes[65]; }
        set { Attributes[65] = value; }
    }
    
    /// <summary>
    /// <para> mdxSubqueries.</para>
    /// <para>Represents the following attribute in the schema: mdxSubqueries </para>
    /// </summary>
    [SchemaAttr(0, "mdxSubqueries")]
    public BooleanValue MdxSubqueries
    {
        get { return (BooleanValue)Attributes[66]; }
        set { Attributes[66] = value; }
    }
    
    /// <summary>
    /// <para> customListSort.</para>
    /// <para>Represents the following attribute in the schema: customListSort </para>
    /// </summary>
    [SchemaAttr(0, "customListSort")]
    public BooleanValue CustomListSort
    {
        get { return (BooleanValue)Attributes[67]; }
        set { Attributes[67] = value; }
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Location.</para>
    /// <para> Represents the following element tag in the schema: x:location </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.Location Location
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.Location>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotFields>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.RowFields>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.RowItems>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.ColumnFields>(4);
        }
        set
        {
            SetElement(4, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.ColumnItems>(5);
        }
        set
        {
            SetElement(5, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.PageFields>(6);
        }
        set
        {
            SetElement(6, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.DataFields>(7);
        }
        set
        {
            SetElement(7, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.Formats>(8);
        }
        set
        {
            SetElement(8, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats>(9);
        }
        set
        {
            SetElement(9, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.ChartFormats>(10);
        }
        set
        {
            SetElement(10, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies>(11);
        }
        set
        {
            SetElement(11, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle>(12);
        }
        set
        {
            SetElement(12, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotFilters>(13);
        }
        set
        {
            SetElement(13, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage>(14);
        }
        set
        {
            SetElement(14, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage>(15);
        }
        set
        {
            SetElement(15, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList>(16);
        }
        set
        {
            SetElement(16, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "cacheId" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "dataOnRows" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "dataPosition" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "autoFormatId" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "applyNumberFormats" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "applyBorderFormats" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "applyFontFormats" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "applyPatternFormats" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "applyAlignmentFormats" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "applyWidthHeightFormats" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "dataCaption" == name)
    return new StringValue();
    
if( 0 == namespaceId && "grandTotalCaption" == name)
    return new StringValue();
    
if( 0 == namespaceId && "errorCaption" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showError" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "missingCaption" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showMissing" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "pageStyle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "pivotTableStyle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "vacatedStyle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "updatedVersion" == name)
    return new ByteValue();
    
if( 0 == namespaceId && "minRefreshableVersion" == name)
    return new ByteValue();
    
if( 0 == namespaceId && "asteriskTotals" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showItems" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "editData" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "disableFieldList" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showCalcMbrs" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "visualTotals" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showMultipleLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showDataDropDown" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showDrill" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "printDrill" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showMemberPropertyTips" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showDataTips" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "enableWizard" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "enableDrill" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "enableFieldProperties" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "preserveFormatting" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "useAutoFormatting" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "pageWrap" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "pageOverThenDown" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "subtotalHiddenItems" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "rowGrandTotals" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "colGrandTotals" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "fieldPrintTitles" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "itemPrintTitles" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "mergeItem" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showDropZones" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "createdVersion" == name)
    return new ByteValue();
    
if( 0 == namespaceId && "indent" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "showEmptyRow" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showEmptyCol" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showHeaders" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "compact" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "outline" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "outlineData" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "compactData" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "published" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "gridDropZones" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "immersive" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "multipleFieldFilters" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "chartFormat" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "rowHeaderCaption" == name)
    return new StringValue();
    
if( 0 == namespaceId && "colHeaderCaption" == name)
    return new StringValue();
    
if( 0 == namespaceId && "fieldListSortAscending" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "mdxSubqueries" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "customListSort" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<pivotTableDefinition>(deep);
    }

   
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
 
 
