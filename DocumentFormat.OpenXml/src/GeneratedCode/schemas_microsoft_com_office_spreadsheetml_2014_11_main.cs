// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace DocumentFormat.OpenXml.Office2016.ExcelAc
{
/// <summary>
/// <para>Defines the ModelTimeGroupings Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is x16:modelTimeGroupings.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ModelTimeGrouping &lt;x16:modelTimeGrouping></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ModelTimeGrouping),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ModelTimeGroupings : OpenXmlCompositeElement
{
    private const string tagName = "modelTimeGroupings";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 84;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13589;
    
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
    /// Initializes a new instance of the ModelTimeGroupings class.
    /// </summary>
    public ModelTimeGroupings():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ModelTimeGroupings class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ModelTimeGroupings(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ModelTimeGroupings class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ModelTimeGroupings(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ModelTimeGroupings class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ModelTimeGroupings(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 84 == namespaceId && "modelTimeGrouping" == name)
    return new ModelTimeGrouping();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ModelTimeGroupings>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ModelTimeGrouping Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is x16:modelTimeGrouping.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CalculatedTimeColumn &lt;x16:calculatedTimeColumn></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(CalculatedTimeColumn),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ModelTimeGrouping : OpenXmlCompositeElement
{
    private const string tagName = "modelTimeGrouping";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 84;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13590;
    
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
    

    private static string[] attributeTagNames = { "tableName","columnName","columnId" };
    private static byte[] attributeNamespaceIds = { 0,0,0 };
    
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
    /// <para> tableName.</para>
    /// <para>Represents the following attribute in the schema: tableName </para>
    /// </summary>
    [SchemaAttr(0, "tableName")]
    public StringValue TableName
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> columnName.</para>
    /// <para>Represents the following attribute in the schema: columnName </para>
    /// </summary>
    [SchemaAttr(0, "columnName")]
    public StringValue ColumnName
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> columnId.</para>
    /// <para>Represents the following attribute in the schema: columnId </para>
    /// </summary>
    [SchemaAttr(0, "columnId")]
    public StringValue ColumnId
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ModelTimeGrouping class.
    /// </summary>
    public ModelTimeGrouping():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ModelTimeGrouping class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ModelTimeGrouping(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ModelTimeGrouping class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ModelTimeGrouping(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ModelTimeGrouping class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ModelTimeGrouping(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 84 == namespaceId && "calculatedTimeColumn" == name)
    return new CalculatedTimeColumn();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "tableName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "columnName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "columnId" == name)
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
        return CloneImp<ModelTimeGrouping>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CalculatedTimeColumn Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is x16:calculatedTimeColumn.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class CalculatedTimeColumn : OpenXmlLeafElement
{
    private const string tagName = "calculatedTimeColumn";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 84;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13591;
    
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
    

    private static string[] attributeTagNames = { "columnName","columnId","contentType","isSelected" };
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
    /// <para> columnName.</para>
    /// <para>Represents the following attribute in the schema: columnName </para>
    /// </summary>
    [SchemaAttr(0, "columnName")]
    public StringValue ColumnName
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> columnId.</para>
    /// <para>Represents the following attribute in the schema: columnId </para>
    /// </summary>
    [SchemaAttr(0, "columnId")]
    public StringValue ColumnId
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> contentType.</para>
    /// <para>Represents the following attribute in the schema: contentType </para>
    /// </summary>
    [SchemaAttr(0, "contentType")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.ExcelAc.ModelTimeGroupingContentType> ContentType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.ExcelAc.ModelTimeGroupingContentType>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> isSelected.</para>
    /// <para>Represents the following attribute in the schema: isSelected </para>
    /// </summary>
    [SchemaAttr(0, "isSelected")]
    public BooleanValue IsSelected
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CalculatedTimeColumn class.
    /// </summary>
    public CalculatedTimeColumn():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "columnName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "columnId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "contentType" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.ExcelAc.ModelTimeGroupingContentType>();
    
if( 0 == namespaceId && "isSelected" == name)
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
        return CloneImp<CalculatedTimeColumn>(deep);
    }

   
}
/// <summary>
/// Defines the ModelTimeGroupingContentType enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ModelTimeGroupingContentType
{  
	///<summary>
///years.
///<para>When the item is serialized out as xml, its value is "years".</para>
///</summary>
[EnumString("years")]
Years,
///<summary>
///quarters.
///<para>When the item is serialized out as xml, its value is "quarters".</para>
///</summary>
[EnumString("quarters")]
Quarters,
///<summary>
///monthsindex.
///<para>When the item is serialized out as xml, its value is "monthsindex".</para>
///</summary>
[EnumString("monthsindex")]
Monthsindex,
///<summary>
///months.
///<para>When the item is serialized out as xml, its value is "months".</para>
///</summary>
[EnumString("months")]
Months,
///<summary>
///daysindex.
///<para>When the item is serialized out as xml, its value is "daysindex".</para>
///</summary>
[EnumString("daysindex")]
Daysindex,
///<summary>
///days.
///<para>When the item is serialized out as xml, its value is "days".</para>
///</summary>
[EnumString("days")]
Days,
///<summary>
///hours.
///<para>When the item is serialized out as xml, its value is "hours".</para>
///</summary>
[EnumString("hours")]
Hours,
///<summary>
///minutes.
///<para>When the item is serialized out as xml, its value is "minutes".</para>
///</summary>
[EnumString("minutes")]
Minutes,
///<summary>
///seconds.
///<para>When the item is serialized out as xml, its value is "seconds".</para>
///</summary>
[EnumString("seconds")]
Seconds,
 
}
}
 
 
