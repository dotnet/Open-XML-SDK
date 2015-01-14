// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office.Excel;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
/// <summary>
/// <para>Defines the PivotCaches Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotCaches.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotCache &lt;x:pivotCache></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotCaches : OpenXmlPivotCachesElement
{
    private const string tagName = "pivotCaches";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13356;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotCaches class.
    /// </summary>
    public PivotCaches():base(){}
            /// <summary>
    ///Initializes a new instance of the PivotCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotCaches(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public PivotCaches(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PivotCaches>(deep);
    }

}
/// <summary>
/// <para>Defines the TimelineCachePivotCaches Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineCachePivotCaches.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotCache &lt;x:pivotCache></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineCachePivotCaches : OpenXmlPivotCachesElement
{
    private const string tagName = "timelineCachePivotCaches";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13362;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the TimelineCachePivotCaches class.
    /// </summary>
    public TimelineCachePivotCaches():base(){}
            /// <summary>
    ///Initializes a new instance of the TimelineCachePivotCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineCachePivotCaches(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public TimelineCachePivotCaches(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TimelineCachePivotCaches>(deep);
    }

}
/// <summary>
/// Defines the OpenXmlPivotCachesElement class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotCache &lt;x:pivotCache></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotCache))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class OpenXmlPivotCachesElement : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "pivotCache" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PivotCache();
    

    return null;
}

    
    
    
    /// <summary>
    /// Initializes a new instance of the OpenXmlPivotCachesElement class.
    /// </summary>
    protected OpenXmlPivotCachesElement(){}
    
            /// <summary>
    ///Initializes a new instance of the OpenXmlPivotCachesElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlPivotCachesElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    protected OpenXmlPivotCachesElement(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the PivotTableReferences Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTableReferences.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotTableReference &lt;x15:pivotTableReference></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PivotTableReference),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotTableReferences : OpenXmlCompositeElement
{
    private const string tagName = "pivotTableReferences";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13357;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotTableReferences class.
    /// </summary>
    public PivotTableReferences():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PivotTableReferences class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableReferences(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public PivotTableReferences(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "pivotTableReference" == name)
    return new PivotTableReference();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PivotTableReferences>(deep);
    }

   
}
/// <summary>
/// <para>Defines the QueryTable Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:queryTable.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class QueryTable : OpenXmlLeafElement
{
    private const string tagName = "queryTable";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13358;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "clipped","sourceDataName","drillThrough" };
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
    /// <para> clipped.</para>
    /// <para>Represents the following attribute in the schema: clipped </para>
    /// </summary>
    [SchemaAttr(0, "clipped")]
    public BooleanValue Clipped
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> sourceDataName.</para>
    /// <para>Represents the following attribute in the schema: sourceDataName </para>
    /// </summary>
    [SchemaAttr(0, "sourceDataName")]
    public StringValue SourceDataName
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> drillThrough.</para>
    /// <para>Represents the following attribute in the schema: drillThrough </para>
    /// </summary>
    [SchemaAttr(0, "drillThrough")]
    public BooleanValue DrillThrough
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the QueryTable class.
    /// </summary>
    public QueryTable():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "clipped" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "sourceDataName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "drillThrough" == name)
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
        return CloneImp<QueryTable>(deep);
    }

   
}
/// <summary>
/// <para>Defines the WebExtensions Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:webExtensions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WebExtension &lt;x15:webExtension></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(WebExtension),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensions : OpenXmlCompositeElement
{
    private const string tagName = "webExtensions";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13359;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the WebExtensions class.
    /// </summary>
    public WebExtensions():base(){}
    
            /// <summary>
    ///Initializes a new instance of the WebExtensions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public WebExtensions(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "webExtension" == name)
    return new WebExtension();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<WebExtensions>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TimelineCacheReferences Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineCacheRefs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineCacheReference &lt;x15:timelineCacheRef></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TimelineCacheReference),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineCacheReferences : OpenXmlCompositeElement
{
    private const string tagName = "timelineCacheRefs";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13360;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TimelineCacheReferences class.
    /// </summary>
    public TimelineCacheReferences():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TimelineCacheReferences class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineCacheReferences(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public TimelineCacheReferences(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "timelineCacheRef" == name)
    return new TimelineCacheReference();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TimelineCacheReferences>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TimelineReferences Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineRefs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineReference &lt;x15:timelineRef></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TimelineReference),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineReferences : OpenXmlCompositeElement
{
    private const string tagName = "timelineRefs";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13361;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TimelineReferences class.
    /// </summary>
    public TimelineReferences():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TimelineReferences class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineReferences(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public TimelineReferences(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "timelineRef" == name)
    return new TimelineReference();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TimelineReferences>(deep);
    }

   
}
/// <summary>
/// <para>Defines the WorkbookProperties Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:workbookPr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WorkbookProperties : OpenXmlLeafElement
{
    private const string tagName = "workbookPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13363;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "chartTrackingRefBase" };
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
    /// <para> chartTrackingRefBase.</para>
    /// <para>Represents the following attribute in the schema: chartTrackingRefBase </para>
    /// </summary>
    [SchemaAttr(0, "chartTrackingRefBase")]
    public BooleanValue ChartTrackingReferenceBase
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the WorkbookProperties class.
    /// </summary>
    public WorkbookProperties():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "chartTrackingRefBase" == name)
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
        return CloneImp<WorkbookProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TimelineStyles Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineStyles.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineStyle &lt;x15:timelineStyle></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TimelineStyle),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineStyles : OpenXmlCompositeElement
{
    private const string tagName = "timelineStyles";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13364;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "defaultTimelineStyle" };
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
    /// <para> defaultTimelineStyle.</para>
    /// <para>Represents the following attribute in the schema: defaultTimelineStyle </para>
    /// </summary>
    [SchemaAttr(0, "defaultTimelineStyle")]
    public StringValue DefaultTimelineStyle
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TimelineStyles class.
    /// </summary>
    public TimelineStyles():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TimelineStyles class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineStyles(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public TimelineStyles(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "timelineStyle" == name)
    return new TimelineStyle();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "defaultTimelineStyle" == name)
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
        return CloneImp<TimelineStyles>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DifferentialFormats Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dxfs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat &lt;x:dxf></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DifferentialFormats : OpenXmlCompositeElement
{
    private const string tagName = "dxfs";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13365;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "count" };
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
    /// <para> Format Count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DifferentialFormats class.
    /// </summary>
    public DifferentialFormats():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DifferentialFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DifferentialFormats(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public DifferentialFormats(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "dxf" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "count" == name)
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
        return CloneImp<DifferentialFormats>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Connection Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:connection.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TextProperties &lt;x15:textPr></description></item>
///<item><description>ModelTextProperties &lt;x15:modelTextPr></description></item>
///<item><description>RangeProperties &lt;x15:rangePr></description></item>
///<item><description>OleDbPrpoperties &lt;x15:oledbPr></description></item>
///<item><description>DataFeedProperties &lt;x15:dataFeedPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TextProperties),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(ModelTextProperties),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(RangeProperties),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(OleDbPrpoperties),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(DataFeedProperties),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Connection : OpenXmlCompositeElement
{
    private const string tagName = "connection";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13366;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","model","excludeFromRefreshAll","autoDelete","usedByAddin" };
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> model.</para>
    /// <para>Represents the following attribute in the schema: model </para>
    /// </summary>
    [SchemaAttr(0, "model")]
    public BooleanValue Model
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> excludeFromRefreshAll.</para>
    /// <para>Represents the following attribute in the schema: excludeFromRefreshAll </para>
    /// </summary>
    [SchemaAttr(0, "excludeFromRefreshAll")]
    public BooleanValue ExcludeFromRefreshAll
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> autoDelete.</para>
    /// <para>Represents the following attribute in the schema: autoDelete </para>
    /// </summary>
    [SchemaAttr(0, "autoDelete")]
    public BooleanValue AutoDelete
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> usedByAddin.</para>
    /// <para>Represents the following attribute in the schema: usedByAddin </para>
    /// </summary>
    [SchemaAttr(0, "usedByAddin")]
    public BooleanValue UsedByAddin
    {
        get { return (BooleanValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Connection class.
    /// </summary>
    public Connection():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Connection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Connection(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public Connection(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "textPr" == name)
    return new TextProperties();
    
if( 71 == namespaceId && "modelTextPr" == name)
    return new ModelTextProperties();
    
if( 71 == namespaceId && "rangePr" == name)
    return new RangeProperties();
    
if( 71 == namespaceId && "oledbPr" == name)
    return new OleDbPrpoperties();
    
if( 71 == namespaceId && "dataFeedPr" == name)
    return new DataFeedProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "textPr","modelTextPr","rangePr","oledbPr","dataFeedPr" };
    private static readonly byte[] eleNamespaceIds = { 71,71,71,71,71 };
    
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
    /// <para> TextProperties.</para>
    /// <para> Represents the following element tag in the schema: x15:textPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public TextProperties TextProperties
    {
        get 
        {
            return GetElement<TextProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ModelTextProperties.</para>
    /// <para> Represents the following element tag in the schema: x15:modelTextPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public ModelTextProperties ModelTextProperties
    {
        get 
        {
            return GetElement<ModelTextProperties>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> RangeProperties.</para>
    /// <para> Represents the following element tag in the schema: x15:rangePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public RangeProperties RangeProperties
    {
        get 
        {
            return GetElement<RangeProperties>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> OleDbPrpoperties.</para>
    /// <para> Represents the following element tag in the schema: x15:oledbPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public OleDbPrpoperties OleDbPrpoperties
    {
        get 
        {
            return GetElement<OleDbPrpoperties>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> DataFeedProperties.</para>
    /// <para> Represents the following element tag in the schema: x15:dataFeedPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public DataFeedProperties DataFeedProperties
    {
        get 
        {
            return GetElement<DataFeedProperties>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "model" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "excludeFromRefreshAll" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "autoDelete" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "usedByAddin" == name)
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
        return CloneImp<Connection>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CalculatedMember Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:calculatedMember.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class CalculatedMember : OpenXmlLeafElement
{
    private const string tagName = "calculatedMember";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13367;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "measureGroup","numberFormat","measure" };
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
    /// <para> measureGroup.</para>
    /// <para>Represents the following attribute in the schema: measureGroup </para>
    /// </summary>
    [SchemaAttr(0, "measureGroup")]
    public StringValue MeasureGroup
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> numberFormat.</para>
    /// <para>Represents the following attribute in the schema: numberFormat </para>
    /// </summary>
    [SchemaAttr(0, "numberFormat")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.CalculatedMemberNumberFormat> NumberFormat
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Excel.CalculatedMemberNumberFormat>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> measure.</para>
    /// <para>Represents the following attribute in the schema: measure </para>
    /// </summary>
    [SchemaAttr(0, "measure")]
    public BooleanValue Measure
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CalculatedMember class.
    /// </summary>
    public CalculatedMember():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "measureGroup" == name)
    return new StringValue();
    
if( 0 == namespaceId && "numberFormat" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2013.Excel.CalculatedMemberNumberFormat>();
    
if( 0 == namespaceId && "measure" == name)
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
        return CloneImp<CalculatedMember>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PivotTableUISettings Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTableUISettings.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FieldListActiveTabTopLevelEntity &lt;x15:activeTabTopLevelEntity></description></item>
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(FieldListActiveTabTopLevelEntity),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotTableUISettings : OpenXmlCompositeElement
{
    private const string tagName = "pivotTableUISettings";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13368;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "sourceDataName","relNeededHidden" };
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
    /// <para> sourceDataName.</para>
    /// <para>Represents the following attribute in the schema: sourceDataName </para>
    /// </summary>
    [SchemaAttr(0, "sourceDataName")]
    public StringValue SourceDataName
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> relNeededHidden.</para>
    /// <para>Represents the following attribute in the schema: relNeededHidden </para>
    /// </summary>
    [SchemaAttr(0, "relNeededHidden")]
    public BooleanValue RelNeededHidden
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotTableUISettings class.
    /// </summary>
    public PivotTableUISettings():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PivotTableUISettings class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableUISettings(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public PivotTableUISettings(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "activeTabTopLevelEntity" == name)
    return new FieldListActiveTabTopLevelEntity();
    
if( 71 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "sourceDataName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "relNeededHidden" == name)
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
        return CloneImp<PivotTableUISettings>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PivotFilter Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotFilter.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotFilter : OpenXmlLeafElement
{
    private const string tagName = "pivotFilter";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13369;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "useWholeDay" };
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
    /// <para> useWholeDay.</para>
    /// <para>Represents the following attribute in the schema: useWholeDay </para>
    /// </summary>
    [SchemaAttr(0, "useWholeDay")]
    public BooleanValue UseWholeDay
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotFilter class.
    /// </summary>
    public PivotFilter():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "useWholeDay" == name)
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
        return CloneImp<PivotFilter>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CachedUniqueNames Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:cachedUniqueNames.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CachedUniqueName &lt;x15:cachedUniqueName></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(CachedUniqueName),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class CachedUniqueNames : OpenXmlCompositeElement
{
    private const string tagName = "cachedUniqueNames";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13370;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the CachedUniqueNames class.
    /// </summary>
    public CachedUniqueNames():base(){}
    
            /// <summary>
    ///Initializes a new instance of the CachedUniqueNames class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CachedUniqueNames(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public CachedUniqueNames(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "cachedUniqueName" == name)
    return new CachedUniqueName();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<CachedUniqueNames>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CacheHierarchy Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:cacheHierarchy.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class CacheHierarchy : OpenXmlLeafElement
{
    private const string tagName = "cacheHierarchy";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13371;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "aggregatedColumn" };
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
    /// <para> aggregatedColumn.</para>
    /// <para>Represents the following attribute in the schema: aggregatedColumn </para>
    /// </summary>
    [SchemaAttr(0, "aggregatedColumn")]
    public Int32Value AggregatedColumn
    {
        get { return (Int32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CacheHierarchy class.
    /// </summary>
    public CacheHierarchy():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "aggregatedColumn" == name)
    return new Int32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<CacheHierarchy>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TimelinePivotCacheDefinition Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelinePivotCacheDefinition.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelinePivotCacheDefinition : OpenXmlLeafElement
{
    private const string tagName = "timelinePivotCacheDefinition";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13372;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "timelineData" };
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
    /// <para> timelineData.</para>
    /// <para>Represents the following attribute in the schema: timelineData </para>
    /// </summary>
    [SchemaAttr(0, "timelineData")]
    public BooleanValue TimelineData
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TimelinePivotCacheDefinition class.
    /// </summary>
    public TimelinePivotCacheDefinition():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "timelineData" == name)
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
        return CloneImp<TimelinePivotCacheDefinition>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PivotCacheIdVersion Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotCacheIdVersion.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotCacheIdVersion : OpenXmlLeafElement
{
    private const string tagName = "pivotCacheIdVersion";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13373;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "cacheIdSupportedVersion","cacheIdCreatedVersion" };
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
    /// <para> cacheIdSupportedVersion.</para>
    /// <para>Represents the following attribute in the schema: cacheIdSupportedVersion </para>
    /// </summary>
    [SchemaAttr(0, "cacheIdSupportedVersion")]
    public ByteValue CacheIdSupportedVersion
    {
        get { return (ByteValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> cacheIdCreatedVersion.</para>
    /// <para>Represents the following attribute in the schema: cacheIdCreatedVersion </para>
    /// </summary>
    [SchemaAttr(0, "cacheIdCreatedVersion")]
    public ByteValue CacheIdCreatedVersion
    {
        get { return (ByteValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotCacheIdVersion class.
    /// </summary>
    public PivotCacheIdVersion():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "cacheIdSupportedVersion" == name)
    return new ByteValue();
    
if( 0 == namespaceId && "cacheIdCreatedVersion" == name)
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
        return CloneImp<PivotCacheIdVersion>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataModel Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dataModel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ModelTables &lt;x15:modelTables></description></item>
///<item><description>ModelRelationships &lt;x15:modelRelationships></description></item>
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ModelTables),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(ModelRelationships),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataModel : OpenXmlCompositeElement
{
    private const string tagName = "dataModel";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13374;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "minVersionLoad" };
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
    /// <para> minVersionLoad.</para>
    /// <para>Represents the following attribute in the schema: minVersionLoad </para>
    /// </summary>
    [SchemaAttr(0, "minVersionLoad")]
    public ByteValue MinVersionLoad
    {
        get { return (ByteValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataModel class.
    /// </summary>
    public DataModel():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DataModel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataModel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public DataModel(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "modelTables" == name)
    return new ModelTables();
    
if( 71 == namespaceId && "modelRelationships" == name)
    return new ModelRelationships();
    
if( 71 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "modelTables","modelRelationships","extLst" };
    private static readonly byte[] eleNamespaceIds = { 71,71,71 };
    
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
    /// <para> ModelTables.</para>
    /// <para> Represents the following element tag in the schema: x15:modelTables </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public ModelTables ModelTables
    {
        get 
        {
            return GetElement<ModelTables>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ModelRelationships.</para>
    /// <para> Represents the following element tag in the schema: x15:modelRelationships </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public ModelRelationships ModelRelationships
    {
        get 
        {
            return GetElement<ModelRelationships>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "minVersionLoad" == name)
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
        return CloneImp<DataModel>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PivotTableData Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTableData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotRow &lt;x15:pivotRow></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PivotRow),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotTableData : OpenXmlCompositeElement
{
    private const string tagName = "pivotTableData";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13375;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rowCount","columnCount","cacheId" };
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
    /// <para> rowCount.</para>
    /// <para>Represents the following attribute in the schema: rowCount </para>
    /// </summary>
    [SchemaAttr(0, "rowCount")]
    public UInt32Value RowCount
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> columnCount.</para>
    /// <para>Represents the following attribute in the schema: columnCount </para>
    /// </summary>
    [SchemaAttr(0, "columnCount")]
    public UInt32Value ColumnCount
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> cacheId.</para>
    /// <para>Represents the following attribute in the schema: cacheId </para>
    /// </summary>
    [SchemaAttr(0, "cacheId")]
    public UInt32Value CacheId
    {
        get { return (UInt32Value)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotTableData class.
    /// </summary>
    public PivotTableData():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PivotTableData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public PivotTableData(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "pivotRow" == name)
    return new PivotRow();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rowCount" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "columnCount" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "cacheId" == name)
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
        return CloneImp<PivotTableData>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PivotCacheDecoupled Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotCacheDecoupled.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotCacheDecoupled : OpenXmlLeafElement
{
    private const string tagName = "pivotCacheDecoupled";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13376;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "decoupled" };
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
    /// <para> decoupled.</para>
    /// <para>Represents the following attribute in the schema: decoupled </para>
    /// </summary>
    [SchemaAttr(0, "decoupled")]
    public BooleanValue Decoupled
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotCacheDecoupled class.
    /// </summary>
    public PivotCacheDecoupled():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "decoupled" == name)
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
        return CloneImp<PivotCacheDecoupled>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataField Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dataField.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataField : OpenXmlLeafElement
{
    private const string tagName = "dataField";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13377;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "isCountDistinct" };
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
    /// <para> isCountDistinct.</para>
    /// <para>Represents the following attribute in the schema: isCountDistinct </para>
    /// </summary>
    [SchemaAttr(0, "isCountDistinct")]
    public BooleanValue IsCountDistinct
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataField class.
    /// </summary>
    public DataField():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "isCountDistinct" == name)
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
        return CloneImp<DataField>(deep);
    }

   
}
/// <summary>
/// <para>Defines the MovingPeriodState Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:movingPeriodState.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class MovingPeriodState : OpenXmlLeafElement
{
    private const string tagName = "movingPeriodState";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13378;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "referenceDateBegin","referencePeriod","referenceMultiple","movingPeriod","movingMultiple" };
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
    /// <para> referenceDateBegin.</para>
    /// <para>Represents the following attribute in the schema: referenceDateBegin </para>
    /// </summary>
    [SchemaAttr(0, "referenceDateBegin")]
    public DateTimeValue ReferenceDateBegin
    {
        get { return (DateTimeValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> referencePeriod.</para>
    /// <para>Represents the following attribute in the schema: referencePeriod </para>
    /// </summary>
    [SchemaAttr(0, "referencePeriod")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep> ReferencePeriod
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> referenceMultiple.</para>
    /// <para>Represents the following attribute in the schema: referenceMultiple </para>
    /// </summary>
    [SchemaAttr(0, "referenceMultiple")]
    public UInt32Value ReferenceMultiple
    {
        get { return (UInt32Value)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> movingPeriod.</para>
    /// <para>Represents the following attribute in the schema: movingPeriod </para>
    /// </summary>
    [SchemaAttr(0, "movingPeriod")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep> MovingPeriod
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> movingMultiple.</para>
    /// <para>Represents the following attribute in the schema: movingMultiple </para>
    /// </summary>
    [SchemaAttr(0, "movingMultiple")]
    public UInt32Value MovingMultiple
    {
        get { return (UInt32Value)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MovingPeriodState class.
    /// </summary>
    public MovingPeriodState():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "referenceDateBegin" == name)
    return new DateTimeValue();
    
if( 0 == namespaceId && "referencePeriod" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep>();
    
if( 0 == namespaceId && "referenceMultiple" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "movingPeriod" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep>();
    
if( 0 == namespaceId && "movingMultiple" == name)
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
        return CloneImp<MovingPeriodState>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SlicerCaches Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:slicerCaches.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.SlicerCache &lt;x14:slicerCache></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCache),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SlicerCaches : OpenXmlCompositeElement
{
    private const string tagName = "slicerCaches";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13379;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SlicerCaches class.
    /// </summary>
    public SlicerCaches():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SlicerCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCaches(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public SlicerCaches(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "slicerCache" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.SlicerCache();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SlicerCaches>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TableSlicerCache Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:tableSlicerCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TableSlicerCache : OpenXmlCompositeElement
{
    private const string tagName = "tableSlicerCache";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13380;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "tableId","column","sortOrder","customListSort","crossFilter" };
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
    /// <para> tableId.</para>
    /// <para>Represents the following attribute in the schema: tableId </para>
    /// </summary>
    [SchemaAttr(0, "tableId")]
    public UInt32Value TableId
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> column.</para>
    /// <para>Represents the following attribute in the schema: column </para>
    /// </summary>
    [SchemaAttr(0, "column")]
    public UInt32Value Column
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> sortOrder.</para>
    /// <para>Represents the following attribute in the schema: sortOrder </para>
    /// </summary>
    [SchemaAttr(0, "sortOrder")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheSortOrderValues> SortOrder
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheSortOrderValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> customListSort.</para>
    /// <para>Represents the following attribute in the schema: customListSort </para>
    /// </summary>
    [SchemaAttr(0, "customListSort")]
    public BooleanValue CustomListSort
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> crossFilter.</para>
    /// <para>Represents the following attribute in the schema: crossFilter </para>
    /// </summary>
    [SchemaAttr(0, "crossFilter")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues> CrossFilter
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TableSlicerCache class.
    /// </summary>
    public TableSlicerCache():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TableSlicerCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TableSlicerCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public TableSlicerCache(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 71 };
    
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
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "tableId" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "column" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "sortOrder" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheSortOrderValues>();
    
if( 0 == namespaceId && "customListSort" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "crossFilter" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TableSlicerCache>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SlicerCacheHideItemsWithNoData Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:slicerCacheHideItemsWithNoData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SlicerCacheOlapLevelName &lt;x15:slicerCacheOlapLevelName></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SlicerCacheOlapLevelName),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SlicerCacheHideItemsWithNoData : OpenXmlCompositeElement
{
    private const string tagName = "slicerCacheHideItemsWithNoData";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13381;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "count" };
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
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SlicerCacheHideItemsWithNoData class.
    /// </summary>
    public SlicerCacheHideItemsWithNoData():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SlicerCacheHideItemsWithNoData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCacheHideItemsWithNoData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public SlicerCacheHideItemsWithNoData(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "slicerCacheOlapLevelName" == name)
    return new SlicerCacheOlapLevelName();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "count" == name)
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
        return CloneImp<SlicerCacheHideItemsWithNoData>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SlicerCachePivotTables Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:slicerCachePivotTables.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable &lt;x14:pivotTable></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SlicerCachePivotTables : OpenXmlCompositeElement
{
    private const string tagName = "slicerCachePivotTables";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13382;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SlicerCachePivotTables class.
    /// </summary>
    public SlicerCachePivotTables():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SlicerCachePivotTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCachePivotTables(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public SlicerCachePivotTables(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "pivotTable" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SlicerCachePivotTables>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Survey Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:survey.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SurveyPrSurveyElementPr &lt;x15:surveyPr></description></item>
///<item><description>TitlePrSurveyElementPr &lt;x15:titlePr></description></item>
///<item><description>DescriptionPrSurveyElementPr &lt;x15:descriptionPr></description></item>
///<item><description>SurveyQuestions &lt;x15:questions></description></item>
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SurveyPrSurveyElementPr),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(TitlePrSurveyElementPr),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(DescriptionPrSurveyElementPr),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(SurveyQuestions),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Survey : OpenXmlCompositeElement
{
    private const string tagName = "survey";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13383;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","guid","title","description" };
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public UInt32Value Id
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> guid.</para>
    /// <para>Represents the following attribute in the schema: guid </para>
    /// </summary>
    [SchemaAttr(0, "guid")]
    public StringValue Guid
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Survey class.
    /// </summary>
    public Survey():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Survey class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Survey(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public Survey(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "surveyPr" == name)
    return new SurveyPrSurveyElementPr();
    
if( 71 == namespaceId && "titlePr" == name)
    return new TitlePrSurveyElementPr();
    
if( 71 == namespaceId && "descriptionPr" == name)
    return new DescriptionPrSurveyElementPr();
    
if( 71 == namespaceId && "questions" == name)
    return new SurveyQuestions();
    
if( 71 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "surveyPr","titlePr","descriptionPr","questions","extLst" };
    private static readonly byte[] eleNamespaceIds = { 71,71,71,71,71 };
    
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
    /// <para> SurveyPrSurveyElementPr.</para>
    /// <para> Represents the following element tag in the schema: x15:surveyPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public SurveyPrSurveyElementPr SurveyPrSurveyElementPr
    {
        get 
        {
            return GetElement<SurveyPrSurveyElementPr>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> TitlePrSurveyElementPr.</para>
    /// <para> Represents the following element tag in the schema: x15:titlePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public TitlePrSurveyElementPr TitlePrSurveyElementPr
    {
        get 
        {
            return GetElement<TitlePrSurveyElementPr>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> DescriptionPrSurveyElementPr.</para>
    /// <para> Represents the following element tag in the schema: x15:descriptionPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public DescriptionPrSurveyElementPr DescriptionPrSurveyElementPr
    {
        get 
        {
            return GetElement<DescriptionPrSurveyElementPr>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> SurveyQuestions.</para>
    /// <para> Represents the following element tag in the schema: x15:questions </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public SurveyQuestions SurveyQuestions
    {
        get 
        {
            return GetElement<SurveyQuestions>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "guid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
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
        return CloneImp<Survey>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Timelines Class. The root element of TimeLinePart.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Timeline &lt;x15:timeline></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Timeline),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Timelines : OpenXmlPartRootElement
{
    private const string tagName = "timelines";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13384;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    
    /// <summary>
    /// Timelines constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the Timelines.</param>
    internal Timelines(TimeLinePart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the TimeLinePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(TimeLinePart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the TimeLinePart associated with this element.
    /// </summary>
    public TimeLinePart TimeLinePart
    {
		get
		{
			return OpenXmlPart as TimeLinePart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
            /// <summary>
    ///Initializes a new instance of the Timelines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Timelines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public Timelines(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the Timelines class.
    /// </summary>
    public Timelines() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the TimeLinePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(TimeLinePart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "timeline" == name)
    return new Timeline();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Timelines>(deep);
    }

}
/// <summary>
/// <para>Defines the TimelineCacheDefinition Class. The root element of TimeLineCachePart.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineCacheDefinition.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineCachePivotTables &lt;x15:pivotTables></description></item>
///<item><description>TimelineState &lt;x15:state></description></item>
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TimelineCachePivotTables),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(TimelineState),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineCacheDefinition : OpenXmlPartRootElement
{
    private const string tagName = "timelineCacheDefinition";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13385;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "name","sourceName" };
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
    /// <para> sourceName.</para>
    /// <para>Represents the following attribute in the schema: sourceName </para>
    /// </summary>
    [SchemaAttr(0, "sourceName")]
    public StringValue SourceName
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    
    /// <summary>
    /// TimelineCacheDefinition constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the TimelineCacheDefinition.</param>
    internal TimelineCacheDefinition(TimeLineCachePart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the TimeLineCachePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(TimeLineCachePart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the TimeLineCachePart associated with this element.
    /// </summary>
    public TimeLineCachePart TimeLineCachePart
    {
		get
		{
			return OpenXmlPart as TimeLineCachePart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
            /// <summary>
    ///Initializes a new instance of the TimelineCacheDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineCacheDefinition(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public TimelineCacheDefinition(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the TimelineCacheDefinition class.
    /// </summary>
    public TimelineCacheDefinition() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the TimeLineCachePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(TimeLineCachePart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "pivotTables" == name)
    return new TimelineCachePivotTables();
    
if( 71 == namespaceId && "state" == name)
    return new TimelineState();
    
if( 71 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "pivotTables","state","extLst" };
    private static readonly byte[] eleNamespaceIds = { 71,71,71 };
    
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
    /// <para> TimelineCachePivotTables.</para>
    /// <para> Represents the following element tag in the schema: x15:pivotTables </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public TimelineCachePivotTables TimelineCachePivotTables
    {
        get 
        {
            return GetElement<TimelineCachePivotTables>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> TimelineState.</para>
    /// <para> Represents the following element tag in the schema: x15:state </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public TimelineState TimelineState
    {
        get 
        {
            return GetElement<TimelineState>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sourceName" == name)
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
        return CloneImp<TimelineCacheDefinition>(deep);
    }

}
/// <summary>
/// <para>Defines the PivotTableReference Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTableReference.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotTableReference : OpenXmlLeafElement
{
    private const string tagName = "pivotTableReference";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13386;
    
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
		if((4 & (int)version) > 0)
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
    /// Initializes a new instance of the PivotTableReference class.
    /// </summary>
    public PivotTableReference():base(){}
    
      
     
    
    
    
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
        return CloneImp<PivotTableReference>(deep);
    }

   
}
/// <summary>
/// <para>Defines the WebExtension Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:webExtension.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtension : OpenXmlCompositeElement
{
    private const string tagName = "webExtension";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13387;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "appRef" };
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
    /// <para> appRef.</para>
    /// <para>Represents the following attribute in the schema: appRef </para>
    /// </summary>
    [SchemaAttr(0, "appRef")]
    public StringValue ApplicationReference
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the WebExtension class.
    /// </summary>
    public WebExtension():base(){}
    
            /// <summary>
    ///Initializes a new instance of the WebExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public WebExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 32 == namespaceId && "f" == name)
    return new DocumentFormat.OpenXml.Office.Excel.Formula();
    

    return null;
}

        private static readonly string[] eleTagNames = { "f" };
    private static readonly byte[] eleNamespaceIds = { 32 };
    
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
            return GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "appRef" == name)
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
        return CloneImp<WebExtension>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TimelineCacheReference Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineCacheRef.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineCacheReference : OpenXmlLeafElement
{
    private const string tagName = "timelineCacheRef";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13388;
    
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
		if((4 & (int)version) > 0)
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
    /// Initializes a new instance of the TimelineCacheReference class.
    /// </summary>
    public TimelineCacheReference():base(){}
    
      
     
    
    
    
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
        return CloneImp<TimelineCacheReference>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TimelineReference Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineRef.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineReference : OpenXmlLeafElement
{
    private const string tagName = "timelineRef";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13389;
    
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
		if((4 & (int)version) > 0)
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
    /// Initializes a new instance of the TimelineReference class.
    /// </summary>
    public TimelineReference():base(){}
    
      
     
    
    
    
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
        return CloneImp<TimelineReference>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TimelineStyle Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineStyle.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineStyleElements &lt;x15:timelineStyleElements></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TimelineStyleElements),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineStyle : OpenXmlCompositeElement
{
    private const string tagName = "timelineStyle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13390;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "name" };
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
    /// Initializes a new instance of the TimelineStyle class.
    /// </summary>
    public TimelineStyle():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TimelineStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineStyle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public TimelineStyle(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "timelineStyleElements" == name)
    return new TimelineStyleElements();
    

    return null;
}

        private static readonly string[] eleTagNames = { "timelineStyleElements" };
    private static readonly byte[] eleNamespaceIds = { 71 };
    
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
    /// <para> TimelineStyleElements.</para>
    /// <para> Represents the following element tag in the schema: x15:timelineStyleElements </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public TimelineStyleElements TimelineStyleElements
    {
        get 
        {
            return GetElement<TimelineStyleElements>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
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
        return CloneImp<TimelineStyle>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TimelineStyleElement Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineStyleElement.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineStyleElement : OpenXmlLeafElement
{
    private const string tagName = "timelineStyleElement";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13391;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "type","dxfId" };
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
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleType> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleType>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> dxfId.</para>
    /// <para>Represents the following attribute in the schema: dxfId </para>
    /// </summary>
    [SchemaAttr(0, "dxfId")]
    public UInt32Value FormatId
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TimelineStyleElement class.
    /// </summary>
    public TimelineStyleElement():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleType>();
    
if( 0 == namespaceId && "dxfId" == name)
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
        return CloneImp<TimelineStyleElement>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TimelineStyleElements Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineStyleElements.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineStyleElement &lt;x15:timelineStyleElement></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TimelineStyleElement),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineStyleElements : OpenXmlCompositeElement
{
    private const string tagName = "timelineStyleElements";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13392;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TimelineStyleElements class.
    /// </summary>
    public TimelineStyleElements():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TimelineStyleElements class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineStyleElements(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public TimelineStyleElements(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "timelineStyleElement" == name)
    return new TimelineStyleElement();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TimelineStyleElements>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DbTable Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dbTable.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DbTable : OpenXmlLeafElement
{
    private const string tagName = "dbTable";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13393;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "name" };
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
    /// Initializes a new instance of the DbTable class.
    /// </summary>
    public DbTable():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
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
        return CloneImp<DbTable>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DbTables Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dbTables.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DbTable &lt;x15:dbTable></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DbTable),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DbTables : OpenXmlCompositeElement
{
    private const string tagName = "dbTables";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13394;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DbTables class.
    /// </summary>
    public DbTables():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DbTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DbTables(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public DbTables(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "dbTable" == name)
    return new DbTable();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DbTables>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DbCommand Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dbCommand.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DbCommand : OpenXmlLeafElement
{
    private const string tagName = "dbCommand";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13395;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "text" };
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
    /// <para> text.</para>
    /// <para>Represents the following attribute in the schema: text </para>
    /// </summary>
    [SchemaAttr(0, "text")]
    public StringValue Text
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DbCommand class.
    /// </summary>
    public DbCommand():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "text" == name)
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
        return CloneImp<DbCommand>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TextProperties Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:textPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.TextFields &lt;x:textFields></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.TextFields))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TextProperties : OpenXmlCompositeElement
{
    private const string tagName = "textPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13396;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "prompt","fileType","codePage","characterSet","firstRow","sourceFile","delimited","decimal","thousands","tab","space","comma","semicolon","consecutive","qualifier","delimiter" };
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
    /// <para> prompt.</para>
    /// <para>Represents the following attribute in the schema: prompt </para>
    /// </summary>
    [SchemaAttr(0, "prompt")]
    public BooleanValue Prompt
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> fileType.</para>
    /// <para>Represents the following attribute in the schema: fileType </para>
    /// </summary>
    [SchemaAttr(0, "fileType")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.FileTypeValues> FileType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.FileTypeValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> codePage.</para>
    /// <para>Represents the following attribute in the schema: codePage </para>
    /// </summary>
    [SchemaAttr(0, "codePage")]
    public UInt32Value CodePage
    {
        get { return (UInt32Value)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> characterSet.</para>
    /// <para>Represents the following attribute in the schema: characterSet </para>
    /// </summary>
    [SchemaAttr(0, "characterSet")]
    public StringValue TextCharacterSet
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> firstRow.</para>
    /// <para>Represents the following attribute in the schema: firstRow </para>
    /// </summary>
    [SchemaAttr(0, "firstRow")]
    public UInt32Value FirstRow
    {
        get { return (UInt32Value)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> sourceFile.</para>
    /// <para>Represents the following attribute in the schema: sourceFile </para>
    /// </summary>
    [SchemaAttr(0, "sourceFile")]
    public StringValue SourceFile
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> delimited.</para>
    /// <para>Represents the following attribute in the schema: delimited </para>
    /// </summary>
    [SchemaAttr(0, "delimited")]
    public BooleanValue Delimited
    {
        get { return (BooleanValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> decimal.</para>
    /// <para>Represents the following attribute in the schema: decimal </para>
    /// </summary>
    [SchemaAttr(0, "decimal")]
    public StringValue Decimal
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> thousands.</para>
    /// <para>Represents the following attribute in the schema: thousands </para>
    /// </summary>
    [SchemaAttr(0, "thousands")]
    public StringValue Thousands
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> tab.</para>
    /// <para>Represents the following attribute in the schema: tab </para>
    /// </summary>
    [SchemaAttr(0, "tab")]
    public BooleanValue TabAsDelimiter
    {
        get { return (BooleanValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> space.</para>
    /// <para>Represents the following attribute in the schema: space </para>
    /// </summary>
    [SchemaAttr(0, "space")]
    public BooleanValue Space
    {
        get { return (BooleanValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> comma.</para>
    /// <para>Represents the following attribute in the schema: comma </para>
    /// </summary>
    [SchemaAttr(0, "comma")]
    public BooleanValue Comma
    {
        get { return (BooleanValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> semicolon.</para>
    /// <para>Represents the following attribute in the schema: semicolon </para>
    /// </summary>
    [SchemaAttr(0, "semicolon")]
    public BooleanValue Semicolon
    {
        get { return (BooleanValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> consecutive.</para>
    /// <para>Represents the following attribute in the schema: consecutive </para>
    /// </summary>
    [SchemaAttr(0, "consecutive")]
    public BooleanValue Consecutive
    {
        get { return (BooleanValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> qualifier.</para>
    /// <para>Represents the following attribute in the schema: qualifier </para>
    /// </summary>
    [SchemaAttr(0, "qualifier")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.QualifierValues> Qualifier
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.QualifierValues>)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> delimiter.</para>
    /// <para>Represents the following attribute in the schema: delimiter </para>
    /// </summary>
    [SchemaAttr(0, "delimiter")]
    public StringValue Delimiter
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TextProperties class.
    /// </summary>
    public TextProperties():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TextProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public TextProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "textFields" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.TextFields();
    

    return null;
}

        private static readonly string[] eleTagNames = { "textFields" };
    private static readonly byte[] eleNamespaceIds = { 22 };
    
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
    /// <para> TextFields.</para>
    /// <para> Represents the following element tag in the schema: x:textFields </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.TextFields TextFields
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Spreadsheet.TextFields>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "prompt" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "fileType" == name)
    return new EnumValue<DocumentFormat.OpenXml.Spreadsheet.FileTypeValues>();
    
if( 0 == namespaceId && "codePage" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "characterSet" == name)
    return new StringValue();
    
if( 0 == namespaceId && "firstRow" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "sourceFile" == name)
    return new StringValue();
    
if( 0 == namespaceId && "delimited" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "decimal" == name)
    return new StringValue();
    
if( 0 == namespaceId && "thousands" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tab" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "space" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "comma" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "semicolon" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "consecutive" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "qualifier" == name)
    return new EnumValue<DocumentFormat.OpenXml.Spreadsheet.QualifierValues>();
    
if( 0 == namespaceId && "delimiter" == name)
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
        return CloneImp<TextProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ModelTextProperties Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:modelTextPr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ModelTextProperties : OpenXmlLeafElement
{
    private const string tagName = "modelTextPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13397;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "headers" };
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
    /// <para> headers.</para>
    /// <para>Represents the following attribute in the schema: headers </para>
    /// </summary>
    [SchemaAttr(0, "headers")]
    public BooleanValue Headers
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ModelTextProperties class.
    /// </summary>
    public ModelTextProperties():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "headers" == name)
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
        return CloneImp<ModelTextProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RangeProperties Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:rangePr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class RangeProperties : OpenXmlLeafElement
{
    private const string tagName = "rangePr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13398;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "sourceName" };
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
    /// <para> sourceName.</para>
    /// <para>Represents the following attribute in the schema: sourceName </para>
    /// </summary>
    [SchemaAttr(0, "sourceName")]
    public StringValue SourceName
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RangeProperties class.
    /// </summary>
    public RangeProperties():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "sourceName" == name)
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
        return CloneImp<RangeProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the OleDbPrpoperties Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:oledbPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DbTables &lt;x15:dbTables></description></item>
///<item><description>DbCommand &lt;x15:dbCommand></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DbTables),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(DbCommand),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class OleDbPrpoperties : OpenXmlCompositeElement
{
    private const string tagName = "oledbPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13399;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "connection" };
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
    /// <para> connection.</para>
    /// <para>Represents the following attribute in the schema: connection </para>
    /// </summary>
    [SchemaAttr(0, "connection")]
    public StringValue Connection
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OleDbPrpoperties class.
    /// </summary>
    public OleDbPrpoperties():base(){}
    
            /// <summary>
    ///Initializes a new instance of the OleDbPrpoperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OleDbPrpoperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public OleDbPrpoperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "dbTables" == name)
    return new DbTables();
    
if( 71 == namespaceId && "dbCommand" == name)
    return new DbCommand();
    

    return null;
}

        private static readonly string[] eleTagNames = { "dbTables","dbCommand" };
    private static readonly byte[] eleNamespaceIds = { 71,71 };
    
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
    /// <para> DbTables.</para>
    /// <para> Represents the following element tag in the schema: x15:dbTables </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public DbTables DbTables
    {
        get 
        {
            return GetElement<DbTables>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> DbCommand.</para>
    /// <para> Represents the following element tag in the schema: x15:dbCommand </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public DbCommand DbCommand
    {
        get 
        {
            return GetElement<DbCommand>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "connection" == name)
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
        return CloneImp<OleDbPrpoperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataFeedProperties Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dataFeedPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DbTables &lt;x15:dbTables></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DbTables),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataFeedProperties : OpenXmlCompositeElement
{
    private const string tagName = "dataFeedPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13400;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "connection" };
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
    /// <para> connection.</para>
    /// <para>Represents the following attribute in the schema: connection </para>
    /// </summary>
    [SchemaAttr(0, "connection")]
    public StringValue Connection
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataFeedProperties class.
    /// </summary>
    public DataFeedProperties():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DataFeedProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataFeedProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public DataFeedProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "dbTables" == name)
    return new DbTables();
    

    return null;
}

        private static readonly string[] eleTagNames = { "dbTables" };
    private static readonly byte[] eleNamespaceIds = { 71 };
    
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
    /// <para> DbTables.</para>
    /// <para> Represents the following element tag in the schema: x15:dbTables </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public DbTables DbTables
    {
        get 
        {
            return GetElement<DbTables>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "connection" == name)
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
        return CloneImp<DataFeedProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FieldListActiveTabTopLevelEntity Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:activeTabTopLevelEntity.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FieldListActiveTabTopLevelEntity : OpenXmlLeafElement
{
    private const string tagName = "activeTabTopLevelEntity";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13401;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "name","type" };
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
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public UInt32Value Type
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the FieldListActiveTabTopLevelEntity class.
    /// </summary>
    public FieldListActiveTabTopLevelEntity():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "type" == name)
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
        return CloneImp<FieldListActiveTabTopLevelEntity>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ExtensionList Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:extLst.</para>
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
[OfficeAvailability(FileFormatVersions.Office2013)]
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
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13402;
    
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
		if((4 & (int)version) > 0)
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
/// <para>Defines the CachedUniqueName Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:cachedUniqueName.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class CachedUniqueName : OpenXmlLeafElement
{
    private const string tagName = "cachedUniqueName";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13403;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "index","name" };
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
    /// <para> index.</para>
    /// <para>Represents the following attribute in the schema: index </para>
    /// </summary>
    [SchemaAttr(0, "index")]
    public UInt32Value Index
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CachedUniqueName class.
    /// </summary>
    public CachedUniqueName():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "index" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "name" == name)
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
        return CloneImp<CachedUniqueName>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ModelTable Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:modelTable.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ModelTable : OpenXmlLeafElement
{
    private const string tagName = "modelTable";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13404;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","name","connection" };
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> connection.</para>
    /// <para>Represents the following attribute in the schema: connection </para>
    /// </summary>
    [SchemaAttr(0, "connection")]
    public StringValue Connection
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ModelTable class.
    /// </summary>
    public ModelTable():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "connection" == name)
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
        return CloneImp<ModelTable>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ModelRelationship Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:modelRelationship.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ModelRelationship : OpenXmlLeafElement
{
    private const string tagName = "modelRelationship";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13405;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "fromTable","fromColumn","toTable","toColumn" };
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
    /// <para> fromTable.</para>
    /// <para>Represents the following attribute in the schema: fromTable </para>
    /// </summary>
    [SchemaAttr(0, "fromTable")]
    public StringValue FromTable
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> fromColumn.</para>
    /// <para>Represents the following attribute in the schema: fromColumn </para>
    /// </summary>
    [SchemaAttr(0, "fromColumn")]
    public StringValue FromColumn
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> toTable.</para>
    /// <para>Represents the following attribute in the schema: toTable </para>
    /// </summary>
    [SchemaAttr(0, "toTable")]
    public StringValue ToTable
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> toColumn.</para>
    /// <para>Represents the following attribute in the schema: toColumn </para>
    /// </summary>
    [SchemaAttr(0, "toColumn")]
    public StringValue ToColumn
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ModelRelationship class.
    /// </summary>
    public ModelRelationship():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "fromTable" == name)
    return new StringValue();
    
if( 0 == namespaceId && "fromColumn" == name)
    return new StringValue();
    
if( 0 == namespaceId && "toTable" == name)
    return new StringValue();
    
if( 0 == namespaceId && "toColumn" == name)
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
        return CloneImp<ModelRelationship>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ModelTables Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:modelTables.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ModelTable &lt;x15:modelTable></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ModelTable),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ModelTables : OpenXmlCompositeElement
{
    private const string tagName = "modelTables";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13406;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ModelTables class.
    /// </summary>
    public ModelTables():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ModelTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ModelTables(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public ModelTables(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "modelTable" == name)
    return new ModelTable();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ModelTables>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ModelRelationships Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:modelRelationships.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ModelRelationship &lt;x15:modelRelationship></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ModelRelationship),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ModelRelationships : OpenXmlCompositeElement
{
    private const string tagName = "modelRelationships";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13407;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ModelRelationships class.
    /// </summary>
    public ModelRelationships():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ModelRelationships class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ModelRelationships(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public ModelRelationships(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "modelRelationship" == name)
    return new ModelRelationship();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ModelRelationships>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PivotValueCell Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:c.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Xstring &lt;x15:v></description></item>
///<item><description>PivotValueCellExtra &lt;x15:x></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Xstring),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(PivotValueCellExtra),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotValueCell : OpenXmlCompositeElement
{
    private const string tagName = "c";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13408;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "i","t" };
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
    /// <para> i.</para>
    /// <para>Represents the following attribute in the schema: i </para>
    /// </summary>
    [SchemaAttr(0, "i")]
    public UInt32Value Item
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SXVCellType> Text
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SXVCellType>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotValueCell class.
    /// </summary>
    public PivotValueCell():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PivotValueCell class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotValueCell(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public PivotValueCell(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "v" == name)
    return new Xstring();
    
if( 71 == namespaceId && "x" == name)
    return new PivotValueCellExtra();
    

    return null;
}

        private static readonly string[] eleTagNames = { "v","x" };
    private static readonly byte[] eleNamespaceIds = { 71,71 };
    
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
    /// <para> Xstring.</para>
    /// <para> Represents the following element tag in the schema: x15:v </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public Xstring Xstring
    {
        get 
        {
            return GetElement<Xstring>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> PivotValueCellExtra.</para>
    /// <para> Represents the following element tag in the schema: x15:x </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public PivotValueCellExtra PivotValueCellExtra
    {
        get 
        {
            return GetElement<PivotValueCellExtra>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "i" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "t" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SXVCellType>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PivotValueCell>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Xstring Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:v.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
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
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13409;
    
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
		if((4 & (int)version) > 0)
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
/// <para>Defines the PivotValueCellExtra Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:x.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotValueCellExtra : OpenXmlLeafElement
{
    private const string tagName = "x";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13410;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "in","bc","fc","i","un","st","b" };
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
    /// <para> in.</para>
    /// <para>Represents the following attribute in the schema: in </para>
    /// </summary>
    [SchemaAttr(0, "in")]
    public UInt32Value FormatIndex
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> bc.</para>
    /// <para>Represents the following attribute in the schema: bc </para>
    /// </summary>
    [SchemaAttr(0, "bc")]
    public HexBinaryValue BackgroundColor
    {
        get { return (HexBinaryValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> fc.</para>
    /// <para>Represents the following attribute in the schema: fc </para>
    /// </summary>
    [SchemaAttr(0, "fc")]
    public HexBinaryValue ForegroundColor
    {
        get { return (HexBinaryValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> i.</para>
    /// <para>Represents the following attribute in the schema: i </para>
    /// </summary>
    [SchemaAttr(0, "i")]
    public BooleanValue Italic
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> un.</para>
    /// <para>Represents the following attribute in the schema: un </para>
    /// </summary>
    [SchemaAttr(0, "un")]
    public BooleanValue Underline
    {
        get { return (BooleanValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> st.</para>
    /// <para>Represents the following attribute in the schema: st </para>
    /// </summary>
    [SchemaAttr(0, "st")]
    public BooleanValue Strikethrough
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> b.</para>
    /// <para>Represents the following attribute in the schema: b </para>
    /// </summary>
    [SchemaAttr(0, "b")]
    public BooleanValue Bold
    {
        get { return (BooleanValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotValueCellExtra class.
    /// </summary>
    public PivotValueCellExtra():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "in" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "bc" == name)
    return new HexBinaryValue();
    
if( 0 == namespaceId && "fc" == name)
    return new HexBinaryValue();
    
if( 0 == namespaceId && "i" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "un" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "st" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "b" == name)
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
        return CloneImp<PivotValueCellExtra>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PivotTableServerFormats Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTableServerFormats.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ServerFormat &lt;x15:serverFormat></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ServerFormat),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotTableServerFormats : OpenXmlCompositeElement
{
    private const string tagName = "pivotTableServerFormats";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13411;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "count" };
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
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotTableServerFormats class.
    /// </summary>
    public PivotTableServerFormats():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PivotTableServerFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableServerFormats(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public PivotTableServerFormats(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "serverFormat" == name)
    return new ServerFormat();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "count" == name)
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
        return CloneImp<PivotTableServerFormats>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ServerFormat Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:serverFormat.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ServerFormat : OpenXmlLeafElement
{
    private const string tagName = "serverFormat";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13412;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "culture","format" };
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
    /// <para> Culture.</para>
    /// <para>Represents the following attribute in the schema: culture </para>
    /// </summary>
    [SchemaAttr(0, "culture")]
    public StringValue Culture
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Format.</para>
    /// <para>Represents the following attribute in the schema: format </para>
    /// </summary>
    [SchemaAttr(0, "format")]
    public StringValue Format
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ServerFormat class.
    /// </summary>
    public ServerFormat():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "culture" == name)
    return new StringValue();
    
if( 0 == namespaceId && "format" == name)
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
        return CloneImp<ServerFormat>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SlicerCacheOlapLevelName Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:slicerCacheOlapLevelName.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SlicerCacheOlapLevelName : OpenXmlLeafElement
{
    private const string tagName = "slicerCacheOlapLevelName";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13413;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "uniqueName","count" };
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
    /// <para> uniqueName.</para>
    /// <para>Represents the following attribute in the schema: uniqueName </para>
    /// </summary>
    [SchemaAttr(0, "uniqueName")]
    public StringValue UniqueName
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SlicerCacheOlapLevelName class.
    /// </summary>
    public SlicerCacheOlapLevelName():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "uniqueName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "count" == name)
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
        return CloneImp<SlicerCacheOlapLevelName>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SurveyPrSurveyElementPr Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:surveyPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SurveyPrSurveyElementPr : OpenXmlSurveyElementPrElement
{
    private const string tagName = "surveyPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13414;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the SurveyPrSurveyElementPr class.
    /// </summary>
    public SurveyPrSurveyElementPr():base(){}
            /// <summary>
    ///Initializes a new instance of the SurveyPrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurveyPrSurveyElementPr(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public SurveyPrSurveyElementPr(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SurveyPrSurveyElementPr>(deep);
    }

}
/// <summary>
/// <para>Defines the TitlePrSurveyElementPr Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:titlePr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TitlePrSurveyElementPr : OpenXmlSurveyElementPrElement
{
    private const string tagName = "titlePr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13415;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the TitlePrSurveyElementPr class.
    /// </summary>
    public TitlePrSurveyElementPr():base(){}
            /// <summary>
    ///Initializes a new instance of the TitlePrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TitlePrSurveyElementPr(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public TitlePrSurveyElementPr(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TitlePrSurveyElementPr>(deep);
    }

}
/// <summary>
/// <para>Defines the DescriptionPrSurveyElementPr Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:descriptionPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DescriptionPrSurveyElementPr : OpenXmlSurveyElementPrElement
{
    private const string tagName = "descriptionPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13416;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the DescriptionPrSurveyElementPr class.
    /// </summary>
    public DescriptionPrSurveyElementPr():base(){}
            /// <summary>
    ///Initializes a new instance of the DescriptionPrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DescriptionPrSurveyElementPr(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public DescriptionPrSurveyElementPr(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DescriptionPrSurveyElementPr>(deep);
    }

}
/// <summary>
/// <para>Defines the QuestionsPrSurveyElementPr Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:questionsPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class QuestionsPrSurveyElementPr : OpenXmlSurveyElementPrElement
{
    private const string tagName = "questionsPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13418;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the QuestionsPrSurveyElementPr class.
    /// </summary>
    public QuestionsPrSurveyElementPr():base(){}
            /// <summary>
    ///Initializes a new instance of the QuestionsPrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public QuestionsPrSurveyElementPr(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public QuestionsPrSurveyElementPr(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<QuestionsPrSurveyElementPr>(deep);
    }

}
/// <summary>
/// <para>Defines the QuestionPrSurveyElementPr Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:questionPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class QuestionPrSurveyElementPr : OpenXmlSurveyElementPrElement
{
    private const string tagName = "questionPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13420;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the QuestionPrSurveyElementPr class.
    /// </summary>
    public QuestionPrSurveyElementPr():base(){}
            /// <summary>
    ///Initializes a new instance of the QuestionPrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public QuestionPrSurveyElementPr(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public QuestionPrSurveyElementPr(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<QuestionPrSurveyElementPr>(deep);
    }

}
/// <summary>
/// Defines the OpenXmlSurveyElementPrElement class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class OpenXmlSurveyElementPrElement : OpenXmlCompositeElement
{
    private static string[] attributeTagNames = { "cssClass","bottom","top","left","right","width","height","position" };
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
    /// <para> cssClass.</para>
    /// <para>Represents the following attribute in the schema: cssClass </para>
    /// </summary>
    [SchemaAttr(0, "cssClass")]
    public StringValue CssClass
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> bottom.</para>
    /// <para>Represents the following attribute in the schema: bottom </para>
    /// </summary>
    [SchemaAttr(0, "bottom")]
    public Int32Value Bottom
    {
        get { return (Int32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> top.</para>
    /// <para>Represents the following attribute in the schema: top </para>
    /// </summary>
    [SchemaAttr(0, "top")]
    public Int32Value Top
    {
        get { return (Int32Value)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> left.</para>
    /// <para>Represents the following attribute in the schema: left </para>
    /// </summary>
    [SchemaAttr(0, "left")]
    public Int32Value Left
    {
        get { return (Int32Value)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> right.</para>
    /// <para>Represents the following attribute in the schema: right </para>
    /// </summary>
    [SchemaAttr(0, "right")]
    public Int32Value Right
    {
        get { return (Int32Value)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> width.</para>
    /// <para>Represents the following attribute in the schema: width </para>
    /// </summary>
    [SchemaAttr(0, "width")]
    public UInt32Value Width
    {
        get { return (UInt32Value)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> height.</para>
    /// <para>Represents the following attribute in the schema: height </para>
    /// </summary>
    [SchemaAttr(0, "height")]
    public UInt32Value Height
    {
        get { return (UInt32Value)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> position.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SurveyPosition> Position
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SurveyPosition>)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 71 };
    
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
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "cssClass" == name)
    return new StringValue();
    
if( 0 == namespaceId && "bottom" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "top" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "left" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "right" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "width" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "height" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "position" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SurveyPosition>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the OpenXmlSurveyElementPrElement class.
    /// </summary>
    protected OpenXmlSurveyElementPrElement(){}
    
            /// <summary>
    ///Initializes a new instance of the OpenXmlSurveyElementPrElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlSurveyElementPrElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    protected OpenXmlSurveyElementPrElement(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the SurveyQuestions Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:questions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>QuestionsPrSurveyElementPr &lt;x15:questionsPr></description></item>
///<item><description>SurveyQuestion &lt;x15:question></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(QuestionsPrSurveyElementPr),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(SurveyQuestion),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SurveyQuestions : OpenXmlCompositeElement
{
    private const string tagName = "questions";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13417;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SurveyQuestions class.
    /// </summary>
    public SurveyQuestions():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SurveyQuestions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurveyQuestions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public SurveyQuestions(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "questionsPr" == name)
    return new QuestionsPrSurveyElementPr();
    
if( 71 == namespaceId && "question" == name)
    return new SurveyQuestion();
    

    return null;
}

        private static readonly string[] eleTagNames = { "questionsPr","question" };
    private static readonly byte[] eleNamespaceIds = { 71,71 };
    
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
    /// <para> QuestionsPrSurveyElementPr.</para>
    /// <para> Represents the following element tag in the schema: x15:questionsPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public QuestionsPrSurveyElementPr QuestionsPrSurveyElementPr
    {
        get 
        {
            return GetElement<QuestionsPrSurveyElementPr>(0);
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
        return CloneImp<SurveyQuestions>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SurveyQuestion Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:question.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>QuestionPrSurveyElementPr &lt;x15:questionPr></description></item>
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(QuestionPrSurveyElementPr),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SurveyQuestion : OpenXmlCompositeElement
{
    private const string tagName = "question";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13419;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "binding","text","type","format","helpText","required","defaultValue","decimalPlaces","rowSource" };
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
    /// <para> binding.</para>
    /// <para>Represents the following attribute in the schema: binding </para>
    /// </summary>
    [SchemaAttr(0, "binding")]
    public UInt32Value Binding
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> text.</para>
    /// <para>Represents the following attribute in the schema: text </para>
    /// </summary>
    [SchemaAttr(0, "text")]
    public StringValue Text
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionType> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionType>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> format.</para>
    /// <para>Represents the following attribute in the schema: format </para>
    /// </summary>
    [SchemaAttr(0, "format")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionFormat> Format
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionFormat>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> helpText.</para>
    /// <para>Represents the following attribute in the schema: helpText </para>
    /// </summary>
    [SchemaAttr(0, "helpText")]
    public StringValue HelpText
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> required.</para>
    /// <para>Represents the following attribute in the schema: required </para>
    /// </summary>
    [SchemaAttr(0, "required")]
    public BooleanValue Required
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> defaultValue.</para>
    /// <para>Represents the following attribute in the schema: defaultValue </para>
    /// </summary>
    [SchemaAttr(0, "defaultValue")]
    public StringValue DefaultValue
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> decimalPlaces.</para>
    /// <para>Represents the following attribute in the schema: decimalPlaces </para>
    /// </summary>
    [SchemaAttr(0, "decimalPlaces")]
    public UInt32Value DecimalPlaces
    {
        get { return (UInt32Value)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> rowSource.</para>
    /// <para>Represents the following attribute in the schema: rowSource </para>
    /// </summary>
    [SchemaAttr(0, "rowSource")]
    public StringValue RowSource
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SurveyQuestion class.
    /// </summary>
    public SurveyQuestion():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SurveyQuestion class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurveyQuestion(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public SurveyQuestion(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "questionPr" == name)
    return new QuestionPrSurveyElementPr();
    
if( 71 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "questionPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 71,71 };
    
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
    /// <para> QuestionPrSurveyElementPr.</para>
    /// <para> Represents the following element tag in the schema: x15:questionPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public QuestionPrSurveyElementPr QuestionPrSurveyElementPr
    {
        get 
        {
            return GetElement<QuestionPrSurveyElementPr>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
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
    if( 0 == namespaceId && "binding" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "text" == name)
    return new StringValue();
    
if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionType>();
    
if( 0 == namespaceId && "format" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionFormat>();
    
if( 0 == namespaceId && "helpText" == name)
    return new StringValue();
    
if( 0 == namespaceId && "required" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "defaultValue" == name)
    return new StringValue();
    
if( 0 == namespaceId && "decimalPlaces" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "rowSource" == name)
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
        return CloneImp<SurveyQuestion>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Timeline Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timeline.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Timeline : OpenXmlCompositeElement
{
    private const string tagName = "timeline";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13421;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "name","cache","caption","showHeader","showSelectionLabel","showTimeLevel","showHorizontalScrollbar","level","selectionLevel","scrollPosition","style" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> cache.</para>
    /// <para>Represents the following attribute in the schema: cache </para>
    /// </summary>
    [SchemaAttr(0, "cache")]
    public StringValue Cache
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> caption.</para>
    /// <para>Represents the following attribute in the schema: caption </para>
    /// </summary>
    [SchemaAttr(0, "caption")]
    public StringValue Caption
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> showHeader.</para>
    /// <para>Represents the following attribute in the schema: showHeader </para>
    /// </summary>
    [SchemaAttr(0, "showHeader")]
    public BooleanValue ShowHeader
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> showSelectionLabel.</para>
    /// <para>Represents the following attribute in the schema: showSelectionLabel </para>
    /// </summary>
    [SchemaAttr(0, "showSelectionLabel")]
    public BooleanValue ShowSelectionLabel
    {
        get { return (BooleanValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> showTimeLevel.</para>
    /// <para>Represents the following attribute in the schema: showTimeLevel </para>
    /// </summary>
    [SchemaAttr(0, "showTimeLevel")]
    public BooleanValue ShowTimeLevel
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> showHorizontalScrollbar.</para>
    /// <para>Represents the following attribute in the schema: showHorizontalScrollbar </para>
    /// </summary>
    [SchemaAttr(0, "showHorizontalScrollbar")]
    public BooleanValue ShowHorizontalScrollbar
    {
        get { return (BooleanValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> level.</para>
    /// <para>Represents the following attribute in the schema: level </para>
    /// </summary>
    [SchemaAttr(0, "level")]
    public UInt32Value Level
    {
        get { return (UInt32Value)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> selectionLevel.</para>
    /// <para>Represents the following attribute in the schema: selectionLevel </para>
    /// </summary>
    [SchemaAttr(0, "selectionLevel")]
    public UInt32Value SelectionLevel
    {
        get { return (UInt32Value)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> scrollPosition.</para>
    /// <para>Represents the following attribute in the schema: scrollPosition </para>
    /// </summary>
    [SchemaAttr(0, "scrollPosition")]
    public DateTimeValue ScrollPosition
    {
        get { return (DateTimeValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Timeline class.
    /// </summary>
    public Timeline():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Timeline class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Timeline(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public Timeline(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 71 };
    
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
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "cache" == name)
    return new StringValue();
    
if( 0 == namespaceId && "caption" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showHeader" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showSelectionLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showTimeLevel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showHorizontalScrollbar" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "level" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "selectionLevel" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "scrollPosition" == name)
    return new DateTimeValue();
    
if( 0 == namespaceId && "style" == name)
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
        return CloneImp<Timeline>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TimelineCachePivotTable Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTable.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineCachePivotTable : OpenXmlLeafElement
{
    private const string tagName = "pivotTable";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13422;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "tabId","name" };
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
    /// <para> tabId.</para>
    /// <para>Represents the following attribute in the schema: tabId </para>
    /// </summary>
    [SchemaAttr(0, "tabId")]
    public UInt32Value TabId
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TimelineCachePivotTable class.
    /// </summary>
    public TimelineCachePivotTable():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "tabId" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "name" == name)
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
        return CloneImp<TimelineCachePivotTable>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SelectionTimelineRange Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:selection.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SelectionTimelineRange : TimelineRange
{
    private const string tagName = "selection";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13423;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the SelectionTimelineRange class.
    /// </summary>
    public SelectionTimelineRange():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SelectionTimelineRange>(deep);
    }

}
/// <summary>
/// <para>Defines the BoundsTimelineRange Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:bounds.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class BoundsTimelineRange : TimelineRange
{
    private const string tagName = "bounds";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13424;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the BoundsTimelineRange class.
    /// </summary>
    public BoundsTimelineRange():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BoundsTimelineRange>(deep);
    }

}
/// <summary>
/// Defines the TimelineRange class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class TimelineRange : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "startDate","endDate" };
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
    /// <para> startDate.</para>
    /// <para>Represents the following attribute in the schema: startDate </para>
    /// </summary>
    [SchemaAttr(0, "startDate")]
    public DateTimeValue StartDate
    {
        get { return (DateTimeValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> endDate.</para>
    /// <para>Represents the following attribute in the schema: endDate </para>
    /// </summary>
    [SchemaAttr(0, "endDate")]
    public DateTimeValue EndDate
    {
        get { return (DateTimeValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "startDate" == name)
    return new DateTimeValue();
    
if( 0 == namespaceId && "endDate" == name)
    return new DateTimeValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the TimelineRange class.
    /// </summary>
    protected TimelineRange(){}
    
    
    
}
/// <summary>
/// <para>Defines the AutoFilter Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:autoFilter.</para>
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
[OfficeAvailability(FileFormatVersions.Office2013)]
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
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13425;
    
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
		if((4 & (int)version) > 0)
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
/// <para>Defines the TimelineCachePivotTables Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTables.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineCachePivotTable &lt;x15:pivotTable></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TimelineCachePivotTable),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineCachePivotTables : OpenXmlCompositeElement
{
    private const string tagName = "pivotTables";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13426;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TimelineCachePivotTables class.
    /// </summary>
    public TimelineCachePivotTables():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TimelineCachePivotTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineCachePivotTables(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public TimelineCachePivotTables(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "pivotTable" == name)
    return new TimelineCachePivotTable();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TimelineCachePivotTables>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TimelineState Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:state.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SelectionTimelineRange &lt;x15:selection></description></item>
///<item><description>BoundsTimelineRange &lt;x15:bounds></description></item>
///<item><description>MovingPeriodState &lt;x15:movingPeriodState></description></item>
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SelectionTimelineRange),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(BoundsTimelineRange),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(MovingPeriodState),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineState : OpenXmlCompositeElement
{
    private const string tagName = "state";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13427;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "singleRangeFilterState","minimalRefreshVersion","lastRefreshVersion","pivotCacheId","filterType","filterId","filterTabId","filterPivotName" };
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
    /// <para> singleRangeFilterState.</para>
    /// <para>Represents the following attribute in the schema: singleRangeFilterState </para>
    /// </summary>
    [SchemaAttr(0, "singleRangeFilterState")]
    public BooleanValue SingleRangeFilterState
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> minimalRefreshVersion.</para>
    /// <para>Represents the following attribute in the schema: minimalRefreshVersion </para>
    /// </summary>
    [SchemaAttr(0, "minimalRefreshVersion")]
    public UInt32Value MinimalRefreshVersion
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> lastRefreshVersion.</para>
    /// <para>Represents the following attribute in the schema: lastRefreshVersion </para>
    /// </summary>
    [SchemaAttr(0, "lastRefreshVersion")]
    public UInt32Value LastRefreshVersion
    {
        get { return (UInt32Value)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> pivotCacheId.</para>
    /// <para>Represents the following attribute in the schema: pivotCacheId </para>
    /// </summary>
    [SchemaAttr(0, "pivotCacheId")]
    public UInt32Value PivotCacheId
    {
        get { return (UInt32Value)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> filterType.</para>
    /// <para>Represents the following attribute in the schema: filterType </para>
    /// </summary>
    [SchemaAttr(0, "filterType")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotFilterValues> FilterType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotFilterValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> filterId.</para>
    /// <para>Represents the following attribute in the schema: filterId </para>
    /// </summary>
    [SchemaAttr(0, "filterId")]
    public UInt32Value FilterId
    {
        get { return (UInt32Value)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> filterTabId.</para>
    /// <para>Represents the following attribute in the schema: filterTabId </para>
    /// </summary>
    [SchemaAttr(0, "filterTabId")]
    public UInt32Value FilterTabId
    {
        get { return (UInt32Value)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> filterPivotName.</para>
    /// <para>Represents the following attribute in the schema: filterPivotName </para>
    /// </summary>
    [SchemaAttr(0, "filterPivotName")]
    public StringValue FilterPivotName
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TimelineState class.
    /// </summary>
    public TimelineState():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TimelineState class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineState(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public TimelineState(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "selection" == name)
    return new SelectionTimelineRange();
    
if( 71 == namespaceId && "bounds" == name)
    return new BoundsTimelineRange();
    
if( 71 == namespaceId && "movingPeriodState" == name)
    return new MovingPeriodState();
    
if( 71 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "selection","bounds","movingPeriodState","extLst" };
    private static readonly byte[] eleNamespaceIds = { 71,71,71,71 };
    
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
    /// <para> SelectionTimelineRange.</para>
    /// <para> Represents the following element tag in the schema: x15:selection </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public SelectionTimelineRange SelectionTimelineRange
    {
        get 
        {
            return GetElement<SelectionTimelineRange>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> BoundsTimelineRange.</para>
    /// <para> Represents the following element tag in the schema: x15:bounds </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public BoundsTimelineRange BoundsTimelineRange
    {
        get 
        {
            return GetElement<BoundsTimelineRange>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> MovingPeriodState.</para>
    /// <para> Represents the following element tag in the schema: x15:movingPeriodState </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public MovingPeriodState MovingPeriodState
    {
        get 
        {
            return GetElement<MovingPeriodState>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "singleRangeFilterState" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "minimalRefreshVersion" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "lastRefreshVersion" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "pivotCacheId" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "filterType" == name)
    return new EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotFilterValues>();
    
if( 0 == namespaceId && "filterId" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "filterTabId" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "filterPivotName" == name)
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
        return CloneImp<TimelineState>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PivotRow Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotRow.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotValueCell &lt;x15:c></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PivotValueCell),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotRow : OpenXmlCompositeElement
{
    private const string tagName = "pivotRow";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 71;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13428;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "r","count" };
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
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public UInt32Value Reference
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotRow class.
    /// </summary>
    public PivotRow():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PivotRow class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotRow(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
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
    public PivotRow(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 71 == namespaceId && "c" == name)
    return new PivotValueCell();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "r" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "count" == name)
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
        return CloneImp<PivotRow>(deep);
    }

   
}
/// <summary>
/// Defines the TimelineStyleType enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
 
 
