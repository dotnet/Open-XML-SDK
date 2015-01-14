// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
/// <summary>
/// <para>Defines the PivotSource Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:pivotSource.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PivotTableName &lt;c:name></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.FormatId &lt;c:fmtId></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PivotTableName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.FormatId))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotSource : OpenXmlCompositeElement
{
    private const string tagName = "pivotSource";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13209;
    
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
    /// Initializes a new instance of the PivotSource class.
    /// </summary>
    public PivotSource():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PivotSource class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotSource(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotSource class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotSource(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotSource class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotSource(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "name" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PivotTableName();
    
if( 11 == namespaceId && "fmtId" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.FormatId();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "name","fmtId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
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
    /// <para> Pivot Name.</para>
    /// <para> Represents the following element tag in the schema: c:name </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PivotTableName PivotTableName
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.PivotTableName>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Format ID.</para>
    /// <para> Represents the following element tag in the schema: c:fmtId </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.FormatId FormatId
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.FormatId>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(2);
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
        return CloneImp<PivotSource>(deep);
    }

   
}
/// <summary>
/// <para>Defines the NumberingFormat Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:numFmt.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class NumberingFormat : OpenXmlLeafElement
{
    private const string tagName = "numFmt";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13210;
    
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
    

    private static string[] attributeTagNames = { "formatCode","sourceLinked" };
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
    /// <para> Number Format Code.</para>
    /// <para>Represents the following attribute in the schema: formatCode </para>
    /// </summary>
    [SchemaAttr(0, "formatCode")]
    public StringValue FormatCode
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Linked to Source.</para>
    /// <para>Represents the following attribute in the schema: sourceLinked </para>
    /// </summary>
    [SchemaAttr(0, "sourceLinked")]
    public BooleanValue SourceLinked
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NumberingFormat class.
    /// </summary>
    public NumberingFormat():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "formatCode" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sourceLinked" == name)
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
        return CloneImp<NumberingFormat>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ShapeProperties Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:spPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Transform2D &lt;a:xfrm></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.CustomGeometry &lt;a:custGeom></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetGeometry &lt;a:prstGeom></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Transform2D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Outline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    private const string tagName = "spPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13211;
    
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
    

    private static string[] attributeTagNames = { "bwMode" };
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
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ShapeProperties class.
    /// </summary>
    public ShapeProperties():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "xfrm" == name)
    return new DocumentFormat.OpenXml.Drawing.Transform2D();
    
if( 10 == namespaceId && "custGeom" == name)
    return new DocumentFormat.OpenXml.Drawing.CustomGeometry();
    
if( 10 == namespaceId && "prstGeom" == name)
    return new DocumentFormat.OpenXml.Drawing.PresetGeometry();
    
if( 10 == namespaceId && "noFill" == name)
    return new DocumentFormat.OpenXml.Drawing.NoFill();
    
if( 10 == namespaceId && "solidFill" == name)
    return new DocumentFormat.OpenXml.Drawing.SolidFill();
    
if( 10 == namespaceId && "gradFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GradientFill();
    
if( 10 == namespaceId && "blipFill" == name)
    return new DocumentFormat.OpenXml.Drawing.BlipFill();
    
if( 10 == namespaceId && "pattFill" == name)
    return new DocumentFormat.OpenXml.Drawing.PatternFill();
    
if( 10 == namespaceId && "grpFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GroupFill();
    
if( 10 == namespaceId && "ln" == name)
    return new DocumentFormat.OpenXml.Drawing.Outline();
    
if( 10 == namespaceId && "effectLst" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectList();
    
if( 10 == namespaceId && "effectDag" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectDag();
    
if( 10 == namespaceId && "scene3d" == name)
    return new DocumentFormat.OpenXml.Drawing.Scene3DType();
    
if( 10 == namespaceId && "sp3d" == name)
    return new DocumentFormat.OpenXml.Drawing.Shape3DType();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "xfrm","custGeom","prstGeom","noFill","solidFill","gradFill","blipFill","pattFill","grpFill","ln","effectLst","effectDag","scene3d","sp3d","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10,10,10,10,10,10,10,10,10,10,10,10 };
    
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
    /// <para> 2D Transform for Individual Objects.</para>
    /// <para> Represents the following element tag in the schema: a:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "bwMode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ShapeProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Layout Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:layout.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ManualLayout &lt;c:manualLayout></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Layout : OpenXmlCompositeElement
{
    private const string tagName = "layout";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13212;
    
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
    /// Initializes a new instance of the Layout class.
    /// </summary>
    public Layout():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Layout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Layout(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Layout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Layout(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Layout class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Layout(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "manualLayout" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ManualLayout();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "manualLayout","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11 };
    
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
    /// <para> Manual Layout.</para>
    /// <para> Represents the following element tag in the schema: c:manualLayout </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ManualLayout ManualLayout
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Layout>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FullReference Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:fullRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SequenceOfReferences &lt;c15:sqref></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SequenceOfReferences),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FullReference : OpenXmlCompositeElement
{
    private const string tagName = "fullRef";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13213;
    
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
    /// Initializes a new instance of the FullReference class.
    /// </summary>
    public FullReference():base(){}
    
            /// <summary>
    ///Initializes a new instance of the FullReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FullReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FullReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FullReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FullReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FullReference(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "sqref" == name)
    return new SequenceOfReferences();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sqref" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> SequenceOfReferences.</para>
    /// <para> Represents the following element tag in the schema: c15:sqref </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public SequenceOfReferences SequenceOfReferences
    {
        get 
        {
            return GetElement<SequenceOfReferences>(0);
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
        return CloneImp<FullReference>(deep);
    }

   
}
/// <summary>
/// <para>Defines the LevelReference Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:levelRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SequenceOfReferences &lt;c15:sqref></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SequenceOfReferences),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class LevelReference : OpenXmlCompositeElement
{
    private const string tagName = "levelRef";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13214;
    
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
    /// Initializes a new instance of the LevelReference class.
    /// </summary>
    public LevelReference():base(){}
    
            /// <summary>
    ///Initializes a new instance of the LevelReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LevelReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LevelReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LevelReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LevelReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LevelReference(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "sqref" == name)
    return new SequenceOfReferences();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sqref" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> SequenceOfReferences.</para>
    /// <para> Represents the following element tag in the schema: c15:sqref </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public SequenceOfReferences SequenceOfReferences
    {
        get 
        {
            return GetElement<SequenceOfReferences>(0);
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
        return CloneImp<LevelReference>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FormulaReference Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:formulaRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SequenceOfReferences &lt;c15:sqref></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SequenceOfReferences),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FormulaReference : OpenXmlCompositeElement
{
    private const string tagName = "formulaRef";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13215;
    
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
    /// Initializes a new instance of the FormulaReference class.
    /// </summary>
    public FormulaReference():base(){}
    
            /// <summary>
    ///Initializes a new instance of the FormulaReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FormulaReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FormulaReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FormulaReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FormulaReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FormulaReference(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "sqref" == name)
    return new SequenceOfReferences();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sqref" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> SequenceOfReferences.</para>
    /// <para> Represents the following element tag in the schema: c15:sqref </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public SequenceOfReferences SequenceOfReferences
    {
        get 
        {
            return GetElement<SequenceOfReferences>(0);
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
        return CloneImp<FormulaReference>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FilteredSeriesTitle Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredSeriesTitle.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartText &lt;c15:tx></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ChartText),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FilteredSeriesTitle : OpenXmlCompositeElement
{
    private const string tagName = "filteredSeriesTitle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13216;
    
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
    /// Initializes a new instance of the FilteredSeriesTitle class.
    /// </summary>
    public FilteredSeriesTitle():base(){}
    
            /// <summary>
    ///Initializes a new instance of the FilteredSeriesTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredSeriesTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredSeriesTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredSeriesTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredSeriesTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredSeriesTitle(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "tx" == name)
    return new ChartText();
    

    return null;
}

        private static readonly string[] eleTagNames = { "tx" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> ChartText.</para>
    /// <para> Represents the following element tag in the schema: c15:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public ChartText ChartText
    {
        get 
        {
            return GetElement<ChartText>(0);
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
        return CloneImp<FilteredSeriesTitle>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FilteredCategoryTitle Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredCategoryTitle.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AxisDataSourceType &lt;c15:cat></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AxisDataSourceType),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FilteredCategoryTitle : OpenXmlCompositeElement
{
    private const string tagName = "filteredCategoryTitle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13217;
    
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
    /// Initializes a new instance of the FilteredCategoryTitle class.
    /// </summary>
    public FilteredCategoryTitle():base(){}
    
            /// <summary>
    ///Initializes a new instance of the FilteredCategoryTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredCategoryTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredCategoryTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredCategoryTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredCategoryTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredCategoryTitle(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "cat" == name)
    return new AxisDataSourceType();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cat" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> AxisDataSourceType.</para>
    /// <para> Represents the following element tag in the schema: c15:cat </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public AxisDataSourceType AxisDataSourceType
    {
        get 
        {
            return GetElement<AxisDataSourceType>(0);
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
        return CloneImp<FilteredCategoryTitle>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FilteredAreaSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredAreaSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AreaChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AreaChartSeries),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FilteredAreaSeries : OpenXmlCompositeElement
{
    private const string tagName = "filteredAreaSeries";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13218;
    
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
    /// Initializes a new instance of the FilteredAreaSeries class.
    /// </summary>
    public FilteredAreaSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the FilteredAreaSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredAreaSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredAreaSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredAreaSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredAreaSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredAreaSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "ser" == name)
    return new AreaChartSeries();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ser" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> AreaChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public AreaChartSeries AreaChartSeries
    {
        get 
        {
            return GetElement<AreaChartSeries>(0);
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
        return CloneImp<FilteredAreaSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FilteredBarSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredBarSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BarChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BarChartSeries),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FilteredBarSeries : OpenXmlCompositeElement
{
    private const string tagName = "filteredBarSeries";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13219;
    
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
    /// Initializes a new instance of the FilteredBarSeries class.
    /// </summary>
    public FilteredBarSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the FilteredBarSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredBarSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredBarSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredBarSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredBarSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredBarSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "ser" == name)
    return new BarChartSeries();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ser" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> BarChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public BarChartSeries BarChartSeries
    {
        get 
        {
            return GetElement<BarChartSeries>(0);
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
        return CloneImp<FilteredBarSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FilteredBubbleSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredBubbleSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BubbleChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BubbleChartSeries),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FilteredBubbleSeries : OpenXmlCompositeElement
{
    private const string tagName = "filteredBubbleSeries";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13220;
    
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
    /// Initializes a new instance of the FilteredBubbleSeries class.
    /// </summary>
    public FilteredBubbleSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the FilteredBubbleSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredBubbleSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredBubbleSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredBubbleSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredBubbleSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredBubbleSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "ser" == name)
    return new BubbleChartSeries();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ser" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> BubbleChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public BubbleChartSeries BubbleChartSeries
    {
        get 
        {
            return GetElement<BubbleChartSeries>(0);
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
        return CloneImp<FilteredBubbleSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FilteredLineSeriesExtension Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredLineSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(LineChartSeries),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FilteredLineSeriesExtension : OpenXmlCompositeElement
{
    private const string tagName = "filteredLineSeries";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13221;
    
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
    /// Initializes a new instance of the FilteredLineSeriesExtension class.
    /// </summary>
    public FilteredLineSeriesExtension():base(){}
    
            /// <summary>
    ///Initializes a new instance of the FilteredLineSeriesExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredLineSeriesExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredLineSeriesExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredLineSeriesExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredLineSeriesExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredLineSeriesExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "ser" == name)
    return new LineChartSeries();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ser" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> LineChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public LineChartSeries LineChartSeries
    {
        get 
        {
            return GetElement<LineChartSeries>(0);
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
        return CloneImp<FilteredLineSeriesExtension>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FilteredPieSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredPieSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PieChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PieChartSeries),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FilteredPieSeries : OpenXmlCompositeElement
{
    private const string tagName = "filteredPieSeries";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13222;
    
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
    /// Initializes a new instance of the FilteredPieSeries class.
    /// </summary>
    public FilteredPieSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the FilteredPieSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredPieSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredPieSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredPieSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredPieSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredPieSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "ser" == name)
    return new PieChartSeries();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ser" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> PieChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public PieChartSeries PieChartSeries
    {
        get 
        {
            return GetElement<PieChartSeries>(0);
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
        return CloneImp<FilteredPieSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FilteredRadarSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredRadarSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RadarChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RadarChartSeries),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FilteredRadarSeries : OpenXmlCompositeElement
{
    private const string tagName = "filteredRadarSeries";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13223;
    
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
    /// Initializes a new instance of the FilteredRadarSeries class.
    /// </summary>
    public FilteredRadarSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the FilteredRadarSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredRadarSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredRadarSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredRadarSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredRadarSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredRadarSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "ser" == name)
    return new RadarChartSeries();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ser" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> RadarChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public RadarChartSeries RadarChartSeries
    {
        get 
        {
            return GetElement<RadarChartSeries>(0);
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
        return CloneImp<FilteredRadarSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FilteredScatterSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredScatterSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ScatterChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ScatterChartSeries),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FilteredScatterSeries : OpenXmlCompositeElement
{
    private const string tagName = "filteredScatterSeries";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13224;
    
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
    /// Initializes a new instance of the FilteredScatterSeries class.
    /// </summary>
    public FilteredScatterSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the FilteredScatterSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredScatterSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredScatterSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredScatterSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredScatterSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredScatterSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "ser" == name)
    return new ScatterChartSeries();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ser" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> ScatterChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public ScatterChartSeries ScatterChartSeries
    {
        get 
        {
            return GetElement<ScatterChartSeries>(0);
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
        return CloneImp<FilteredScatterSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FilteredSurfaceSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredSurfaceSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SurfaceChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SurfaceChartSeries),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FilteredSurfaceSeries : OpenXmlCompositeElement
{
    private const string tagName = "filteredSurfaceSeries";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13225;
    
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
    /// Initializes a new instance of the FilteredSurfaceSeries class.
    /// </summary>
    public FilteredSurfaceSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the FilteredSurfaceSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredSurfaceSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredSurfaceSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredSurfaceSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredSurfaceSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredSurfaceSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "ser" == name)
    return new SurfaceChartSeries();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ser" };
    private static readonly byte[] eleNamespaceIds = { 64 };
    
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
    /// <para> SurfaceChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public SurfaceChartSeries SurfaceChartSeries
    {
        get 
        {
            return GetElement<SurfaceChartSeries>(0);
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
        return CloneImp<FilteredSurfaceSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataLabelsRange Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:datalabelsRange.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;c15:f></description></item>
///<item><description>DataLabelsRangeChache &lt;c15:dlblRangeCache></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Formula),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(DataLabelsRangeChache),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataLabelsRange : OpenXmlCompositeElement
{
    private const string tagName = "datalabelsRange";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13226;
    
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
    /// Initializes a new instance of the DataLabelsRange class.
    /// </summary>
    public DataLabelsRange():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DataLabelsRange class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelsRange(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelsRange class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelsRange(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelsRange class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabelsRange(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "f" == name)
    return new Formula();
    
if( 64 == namespaceId && "dlblRangeCache" == name)
    return new DataLabelsRangeChache();
    

    return null;
}

        private static readonly string[] eleTagNames = { "f","dlblRangeCache" };
    private static readonly byte[] eleNamespaceIds = { 64,64 };
    
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
    /// <para> Represents the following element tag in the schema: c15:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public Formula Formula
    {
        get 
        {
            return GetElement<Formula>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> DataLabelsRangeChache.</para>
    /// <para> Represents the following element tag in the schema: c15:dlblRangeCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public DataLabelsRangeChache DataLabelsRangeChache
    {
        get 
        {
            return GetElement<DataLabelsRangeChache>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DataLabelsRange>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CategoryFilterExceptions Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:categoryFilterExceptions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CategoryFilterException &lt;c15:categoryFilterException></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(CategoryFilterException),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class CategoryFilterExceptions : OpenXmlCompositeElement
{
    private const string tagName = "categoryFilterExceptions";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13227;
    
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
    /// Initializes a new instance of the CategoryFilterExceptions class.
    /// </summary>
    public CategoryFilterExceptions():base(){}
    
            /// <summary>
    ///Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterExceptions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterExceptions(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterExceptions class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CategoryFilterExceptions(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "categoryFilterException" == name)
    return new CategoryFilterException();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<CategoryFilterExceptions>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataLabelFieldTable Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:dlblFieldTable.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DataLabelFieldTableEntry &lt;c15:dlblFTEntry></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DataLabelFieldTableEntry),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataLabelFieldTable : OpenXmlCompositeElement
{
    private const string tagName = "dlblFieldTable";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13228;
    
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
    /// Initializes a new instance of the DataLabelFieldTable class.
    /// </summary>
    public DataLabelFieldTable():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DataLabelFieldTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelFieldTable(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelFieldTable(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTable class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabelFieldTable(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "dlblFTEntry" == name)
    return new DataLabelFieldTableEntry();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DataLabelFieldTable>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ExceptionForSave Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:xForSave.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ExceptionForSave : BooleanType
{
    private const string tagName = "xForSave";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13229;
    
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
    /// Initializes a new instance of the ExceptionForSave class.
    /// </summary>
    public ExceptionForSave():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ExceptionForSave>(deep);
    }

}
/// <summary>
/// <para>Defines the ShowDataLabelsRange Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:showDataLabelsRange.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ShowDataLabelsRange : BooleanType
{
    private const string tagName = "showDataLabelsRange";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13230;
    
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
    /// Initializes a new instance of the ShowDataLabelsRange class.
    /// </summary>
    public ShowDataLabelsRange():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ShowDataLabelsRange>(deep);
    }

}
/// <summary>
/// <para>Defines the ShowLeaderLines Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:showLeaderLines.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ShowLeaderLines : BooleanType
{
    private const string tagName = "showLeaderLines";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13232;
    
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
    /// Initializes a new instance of the ShowLeaderLines class.
    /// </summary>
    public ShowLeaderLines():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ShowLeaderLines>(deep);
    }

}
/// <summary>
/// <para>Defines the AutoGeneneratedCategories Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:autoCat.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class AutoGeneneratedCategories : BooleanType
{
    private const string tagName = "autoCat";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13234;
    
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
    /// Initializes a new instance of the AutoGeneneratedCategories class.
    /// </summary>
    public AutoGeneneratedCategories():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AutoGeneneratedCategories>(deep);
    }

}
/// <summary>
/// <para>Defines the InvertIfNegativeBoolean Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:invertIfNegative.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class InvertIfNegativeBoolean : BooleanType
{
    private const string tagName = "invertIfNegative";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13248;
    
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
    /// Initializes a new instance of the InvertIfNegativeBoolean class.
    /// </summary>
    public InvertIfNegativeBoolean():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<InvertIfNegativeBoolean>(deep);
    }

}
/// <summary>
/// <para>Defines the Bubble3D Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:bubble3D.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Bubble3D : BooleanType
{
    private const string tagName = "bubble3D";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13249;
    
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
    /// Initializes a new instance of the Bubble3D class.
    /// </summary>
    public Bubble3D():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Bubble3D>(deep);
    }

}
/// <summary>
/// Defines the BooleanType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class BooleanType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "val" };
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
    /// <para> Boolean Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the BooleanType class.
    /// </summary>
    protected BooleanType(){}
    
    
    
}
/// <summary>
/// <para>Defines the ChartText Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:tx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringReference &lt;c:strRef></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.RichText &lt;c:rich></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringLiteral &lt;c:strLit></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.RichText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ChartText : OpenXmlCompositeElement
{
    private const string tagName = "tx";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13231;
    
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
    /// Initializes a new instance of the ChartText class.
    /// </summary>
    public ChartText():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ChartText class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartText(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartText class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartText(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartText class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartText(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "strRef" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.StringReference();
    
if( 11 == namespaceId && "rich" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.RichText();
    
if( 11 == namespaceId && "strLit" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.StringLiteral();
    

    return null;
}

        private static readonly string[] eleTagNames = { "strRef","rich","strLit" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
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
    /// <para> String Reference.</para>
    /// <para> Represents the following element tag in the schema: c:strRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.StringReference StringReference
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Rich Text.</para>
    /// <para> Represents the following element tag in the schema: c:rich </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.RichText RichText
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.RichText>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> String Literal.</para>
    /// <para> Represents the following element tag in the schema: c:strLit </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.StringLiteral StringLiteral
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>(2);
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
        return CloneImp<ChartText>(deep);
    }

   
}
/// <summary>
/// <para>Defines the LeaderLines Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:leaderLines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class LeaderLines : OpenXmlCompositeElement
{
    private const string tagName = "leaderLines";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13233;
    
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
    /// Initializes a new instance of the LeaderLines class.
    /// </summary>
    public LeaderLines():base(){}
    
            /// <summary>
    ///Initializes a new instance of the LeaderLines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LeaderLines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LeaderLines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LeaderLines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LeaderLines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LeaderLines(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "spPr" };
    private static readonly byte[] eleNamespaceIds = { 11 };
    
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
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(0);
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
        return CloneImp<LeaderLines>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SequenceOfReferences Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:sqref.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SequenceOfReferences : OpenXmlLeafTextElement
{
    private const string tagName = "sqref";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13235;
    
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
    /// Initializes a new instance of the SequenceOfReferences class.
    /// </summary>
    public SequenceOfReferences():base(){}
    
           /// <summary>
    /// Initializes a new instance of the SequenceOfReferences class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public SequenceOfReferences(string text):base(text)
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
        return CloneImp<SequenceOfReferences>(deep);
    }

}
/// <summary>
/// <para>Defines the Formula Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:f.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Formula : OpenXmlLeafTextElement
{
    private const string tagName = "f";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13245;
    
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
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Formula>(deep);
    }

}
/// <summary>
/// <para>Defines the TextFieldGuid Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:txfldGUID.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TextFieldGuid : OpenXmlLeafTextElement
{
    private const string tagName = "txfldGUID";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13253;
    
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
    /// Initializes a new instance of the TextFieldGuid class.
    /// </summary>
    public TextFieldGuid():base(){}
    
           /// <summary>
    /// Initializes a new instance of the TextFieldGuid class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public TextFieldGuid(string text):base(text)
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
        return CloneImp<TextFieldGuid>(deep);
    }

}
/// <summary>
/// <para>Defines the AxisDataSourceType Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:cat.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference &lt;c:multiLvlStrRef></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.NumberReference &lt;c:numRef></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral &lt;c:numLit></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringReference &lt;c:strRef></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringLiteral &lt;c:strLit></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class AxisDataSourceType : OpenXmlCompositeElement
{
    private const string tagName = "cat";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13236;
    
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
    /// Initializes a new instance of the AxisDataSourceType class.
    /// </summary>
    public AxisDataSourceType():base(){}
    
            /// <summary>
    ///Initializes a new instance of the AxisDataSourceType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisDataSourceType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisDataSourceType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisDataSourceType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisDataSourceType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AxisDataSourceType(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "multiLvlStrRef" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference();
    
if( 11 == namespaceId && "numRef" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.NumberReference();
    
if( 11 == namespaceId && "numLit" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral();
    
if( 11 == namespaceId && "strRef" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.StringReference();
    
if( 11 == namespaceId && "strLit" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.StringLiteral();
    

    return null;
}

        private static readonly string[] eleTagNames = { "multiLvlStrRef","numRef","numLit","strRef","strLit" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11 };
    
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
    /// <para> Multi Level String Reference.</para>
    /// <para> Represents the following element tag in the schema: c:multiLvlStrRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference MultiLevelStringReference
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Number Reference.</para>
    /// <para> Represents the following element tag in the schema: c:numRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.NumberReference NumberReference
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Number Literal.</para>
    /// <para> Represents the following element tag in the schema: c:numLit </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral NumberLiteral
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> StringReference.</para>
    /// <para> Represents the following element tag in the schema: c:strRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.StringReference StringReference
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> String Literal.</para>
    /// <para> Represents the following element tag in the schema: c:strLit </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.StringLiteral StringLiteral
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>(4);
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
        return CloneImp<AxisDataSourceType>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BarChartSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative &lt;c:invertIfNegative></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Shape &lt;c:shape></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Shape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class BarChartSeries : OpenXmlCompositeElement
{
    private const string tagName = "ser";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13237;
    
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
    /// Initializes a new instance of the BarChartSeries class.
    /// </summary>
    public BarChartSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the BarChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BarChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BarChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BarChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Index();
    
if( 11 == namespaceId && "order" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Order();
    
if( 11 == namespaceId && "tx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    
if( 11 == namespaceId && "invertIfNegative" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PictureOptions();
    
if( 11 == namespaceId && "dPt" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataLabels();
    
if( 11 == namespaceId && "trendline" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Trendline();
    
if( 11 == namespaceId && "errBars" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ErrorBars();
    
if( 11 == namespaceId && "cat" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData();
    
if( 11 == namespaceId && "val" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Values();
    
if( 11 == namespaceId && "shape" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Shape();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","invertIfNegative","pictureOptions","dPt","dLbls","trendline","errBars","cat","val","shape","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
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
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> InvertIfNegative.</para>
    /// <para> Represents the following element tag in the schema: c:invertIfNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative InvertIfNegative
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(5);
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
        return CloneImp<BarChartSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the LineChartSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Marker &lt;c:marker></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Smooth &lt;c:smooth></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class LineChartSeries : OpenXmlCompositeElement
{
    private const string tagName = "ser";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13238;
    
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
    /// Initializes a new instance of the LineChartSeries class.
    /// </summary>
    public LineChartSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the LineChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LineChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LineChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LineChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Index();
    
if( 11 == namespaceId && "order" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Order();
    
if( 11 == namespaceId && "tx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    
if( 11 == namespaceId && "marker" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Marker();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PictureOptions();
    
if( 11 == namespaceId && "dPt" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataLabels();
    
if( 11 == namespaceId && "trendline" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Trendline();
    
if( 11 == namespaceId && "errBars" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ErrorBars();
    
if( 11 == namespaceId && "cat" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData();
    
if( 11 == namespaceId && "val" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Values();
    
if( 11 == namespaceId && "smooth" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Smooth();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","marker","pictureOptions","dPt","dLbls","trendline","errBars","cat","val","smooth","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
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
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Marker Marker
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(5);
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
        return CloneImp<LineChartSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ScatterChartSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Marker &lt;c:marker></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.XValues &lt;c:xVal></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.YValues &lt;c:yVal></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Smooth &lt;c:smooth></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.XValues))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.YValues))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ScatterChartSeries : OpenXmlCompositeElement
{
    private const string tagName = "ser";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13239;
    
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
    /// Initializes a new instance of the ScatterChartSeries class.
    /// </summary>
    public ScatterChartSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ScatterChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ScatterChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Index();
    
if( 11 == namespaceId && "order" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Order();
    
if( 11 == namespaceId && "tx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    
if( 11 == namespaceId && "marker" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Marker();
    
if( 11 == namespaceId && "dPt" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataLabels();
    
if( 11 == namespaceId && "trendline" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Trendline();
    
if( 11 == namespaceId && "errBars" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ErrorBars();
    
if( 11 == namespaceId && "xVal" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.XValues();
    
if( 11 == namespaceId && "yVal" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.YValues();
    
if( 11 == namespaceId && "smooth" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Smooth();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","marker","dPt","dLbls","trendline","errBars","xVal","yVal","smooth","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
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
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Marker Marker
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>(4);
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
        return CloneImp<ScatterChartSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the AreaChartSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class AreaChartSeries : OpenXmlCompositeElement
{
    private const string tagName = "ser";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13240;
    
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
    /// Initializes a new instance of the AreaChartSeries class.
    /// </summary>
    public AreaChartSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the AreaChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AreaChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Index();
    
if( 11 == namespaceId && "order" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Order();
    
if( 11 == namespaceId && "tx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PictureOptions();
    
if( 11 == namespaceId && "dPt" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataLabels();
    
if( 11 == namespaceId && "trendline" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Trendline();
    
if( 11 == namespaceId && "errBars" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ErrorBars();
    
if( 11 == namespaceId && "cat" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData();
    
if( 11 == namespaceId && "val" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Values();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","pictureOptions","dPt","dLbls","trendline","errBars","cat","val","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11 };
    
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
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(4);
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
        return CloneImp<AreaChartSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PieChartSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Explosion &lt;c:explosion></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Explosion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PieChartSeries : OpenXmlCompositeElement
{
    private const string tagName = "ser";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13241;
    
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
    /// Initializes a new instance of the PieChartSeries class.
    /// </summary>
    public PieChartSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PieChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PieChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PieChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PieChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Index();
    
if( 11 == namespaceId && "order" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Order();
    
if( 11 == namespaceId && "tx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PictureOptions();
    
if( 11 == namespaceId && "explosion" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Explosion();
    
if( 11 == namespaceId && "dPt" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataLabels();
    
if( 11 == namespaceId && "cat" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData();
    
if( 11 == namespaceId && "val" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Values();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","pictureOptions","explosion","dPt","dLbls","cat","val","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11 };
    
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
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> Explosion.</para>
    /// <para> Represents the following element tag in the schema: c:explosion </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Explosion Explosion
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Explosion>(5);
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
        return CloneImp<PieChartSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BubbleChartSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative &lt;c:invertIfNegative></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.XValues &lt;c:xVal></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.YValues &lt;c:yVal></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.BubbleSize &lt;c:bubbleSize></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Bubble3D &lt;c:bubble3D></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.XValues))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.YValues))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class BubbleChartSeries : OpenXmlCompositeElement
{
    private const string tagName = "ser";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13242;
    
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
    /// Initializes a new instance of the BubbleChartSeries class.
    /// </summary>
    public BubbleChartSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the BubbleChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BubbleChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Index();
    
if( 11 == namespaceId && "order" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Order();
    
if( 11 == namespaceId && "tx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PictureOptions();
    
if( 11 == namespaceId && "invertIfNegative" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative();
    
if( 11 == namespaceId && "dPt" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataLabels();
    
if( 11 == namespaceId && "trendline" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Trendline();
    
if( 11 == namespaceId && "errBars" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ErrorBars();
    
if( 11 == namespaceId && "xVal" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.XValues();
    
if( 11 == namespaceId && "yVal" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.YValues();
    
if( 11 == namespaceId && "bubbleSize" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.BubbleSize();
    
if( 11 == namespaceId && "bubble3D" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Bubble3D();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","pictureOptions","invertIfNegative","dPt","dLbls","trendline","errBars","xVal","yVal","bubbleSize","bubble3D","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
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
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> InvertIfNegative.</para>
    /// <para> Represents the following element tag in the schema: c:invertIfNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative InvertIfNegative
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>(5);
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
        return CloneImp<BubbleChartSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RadarChartSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Marker &lt;c:marker></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class RadarChartSeries : OpenXmlCompositeElement
{
    private const string tagName = "ser";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13243;
    
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
    /// Initializes a new instance of the RadarChartSeries class.
    /// </summary>
    public RadarChartSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the RadarChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RadarChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Index();
    
if( 11 == namespaceId && "order" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Order();
    
if( 11 == namespaceId && "tx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PictureOptions();
    
if( 11 == namespaceId && "marker" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Marker();
    
if( 11 == namespaceId && "dPt" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataLabels();
    
if( 11 == namespaceId && "cat" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData();
    
if( 11 == namespaceId && "val" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Values();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","pictureOptions","marker","dPt","dLbls","cat","val","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11 };
    
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
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Marker Marker
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>(5);
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
        return CloneImp<RadarChartSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SurfaceChartSeries Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Bubble3D &lt;c:bubble3D></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SurfaceChartSeries : OpenXmlCompositeElement
{
    private const string tagName = "ser";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13244;
    
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
    /// Initializes a new instance of the SurfaceChartSeries class.
    /// </summary>
    public SurfaceChartSeries():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SurfaceChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SurfaceChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Index();
    
if( 11 == namespaceId && "order" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Order();
    
if( 11 == namespaceId && "tx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PictureOptions();
    
if( 11 == namespaceId && "cat" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData();
    
if( 11 == namespaceId && "val" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Values();
    
if( 11 == namespaceId && "bubble3D" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Bubble3D();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","pictureOptions","cat","val","bubble3D","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11 };
    
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
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> CategoryAxisData.</para>
    /// <para> Represents the following element tag in the schema: c:cat </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData CategoryAxisData
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }
    /// <summary>
    /// <para> Values.</para>
    /// <para> Represents the following element tag in the schema: c:val </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Values Values
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Values>(6);
        }
        set
        {
            SetElement(6, value);
        }
    }
    /// <summary>
    /// <para> Bubble3D.</para>
    /// <para> Represents the following element tag in the schema: c:bubble3D </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Bubble3D Bubble3D
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>(7);
        }
        set
        {
            SetElement(7, value);
        }
    }
    /// <summary>
    /// <para> SurfaceSerExtensionList.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList SurfaceSerExtensionList
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList>(8);
        }
        set
        {
            SetElement(8, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SurfaceChartSeries>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataLabelsRangeChache Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:dlblRangeCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringPoint &lt;c:pt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataLabelsRangeChache : StringDataType
{
    private const string tagName = "dlblRangeCache";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13246;
    
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
    /// Initializes a new instance of the DataLabelsRangeChache class.
    /// </summary>
    public DataLabelsRangeChache():base(){}
            /// <summary>
    ///Initializes a new instance of the DataLabelsRangeChache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelsRangeChache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelsRangeChache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelsRangeChache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelsRangeChache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabelsRangeChache(string outerXml)
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
        return CloneImp<DataLabelsRangeChache>(deep);
    }

}
/// <summary>
/// <para>Defines the DataLabelFieldTableCache Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:dlblFieldTableCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringPoint &lt;c:pt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataLabelFieldTableCache : StringDataType
{
    private const string tagName = "dlblFieldTableCache";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13254;
    
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
    /// Initializes a new instance of the DataLabelFieldTableCache class.
    /// </summary>
    public DataLabelFieldTableCache():base(){}
            /// <summary>
    ///Initializes a new instance of the DataLabelFieldTableCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelFieldTableCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTableCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelFieldTableCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTableCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabelFieldTableCache(string outerXml)
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
        return CloneImp<DataLabelFieldTableCache>(deep);
    }

}
/// <summary>
/// Defines the StringDataType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringPoint &lt;c:pt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class StringDataType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ptCount" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PointCount();
    
if( 11 == namespaceId && "pt" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.StringPoint();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ptCount","pt","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
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
    /// <para> PointCount.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PointCount PointCount
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
    
    /// <summary>
    /// Initializes a new instance of the StringDataType class.
    /// </summary>
    protected StringDataType(){}
    
            /// <summary>
    ///Initializes a new instance of the StringDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected StringDataType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StringDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected StringDataType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StringDataType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected StringDataType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the Explosion Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:explosion.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Explosion : OpenXmlLeafElement
{
    private const string tagName = "explosion";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13247;
    
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
    

    private static string[] attributeTagNames = { "val" };
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
    /// <para> Integer Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt32Value Val
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Explosion class.
    /// </summary>
    public Explosion():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
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
        return CloneImp<Explosion>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Marker Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:marker.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Symbol &lt;c:symbol></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Size &lt;c:size></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Symbol))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Size))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Marker : OpenXmlCompositeElement
{
    private const string tagName = "marker";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13250;
    
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
    /// Initializes a new instance of the Marker class.
    /// </summary>
    public Marker():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Marker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Marker(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Marker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Marker(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Marker class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Marker(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "symbol" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Symbol();
    
if( 11 == namespaceId && "size" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Size();
    
if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "symbol","size","spPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11 };
    
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
    /// <para> Symbol.</para>
    /// <para> Represents the following element tag in the schema: c:symbol </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Symbol Symbol
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Symbol>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Size.</para>
    /// <para> Represents the following element tag in the schema: c:size </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Size Size
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Size>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Marker>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataLabel Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:dLbl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Delete &lt;c:delete></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Layout &lt;c:layout></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat &lt;c:numFmt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.TextProperties &lt;c:txPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition &lt;c:dLblPos></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey &lt;c:showLegendKey></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowValue &lt;c:showVal></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName &lt;c:showCatName></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName &lt;c:showSerName></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowPercent &lt;c:showPercent></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize &lt;c:showBubbleSize></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Separator &lt;c:separator></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowValue))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowPercent))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Separator))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataLabel : OpenXmlCompositeElement
{
    private const string tagName = "dLbl";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13251;
    
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
    /// Initializes a new instance of the DataLabel class.
    /// </summary>
    public DataLabel():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DataLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabel(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Index();
    
if( 11 == namespaceId && "delete" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Delete();
    
if( 11 == namespaceId && "layout" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Layout();
    
if( 11 == namespaceId && "tx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartText();
    
if( 11 == namespaceId && "numFmt" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat();
    
if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.TextProperties();
    
if( 11 == namespaceId && "dLblPos" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition();
    
if( 11 == namespaceId && "showLegendKey" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey();
    
if( 11 == namespaceId && "showVal" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ShowValue();
    
if( 11 == namespaceId && "showCatName" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName();
    
if( 11 == namespaceId && "showSerName" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName();
    
if( 11 == namespaceId && "showPercent" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ShowPercent();
    
if( 11 == namespaceId && "showBubbleSize" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize();
    
if( 11 == namespaceId && "separator" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Separator();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","delete","layout","tx","numFmt","spPr","txPr","dLblPos","showLegendKey","showVal","showCatName","showSerName","showPercent","showBubbleSize","separator","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
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
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
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
        return CloneImp<DataLabel>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CategoryFilterException Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:categoryFilterException.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SequenceOfReferences &lt;c15:sqref></description></item>
///<item><description>ShapeProperties &lt;c15:spPr></description></item>
///<item><description>Explosion &lt;c15:explosion></description></item>
///<item><description>InvertIfNegativeBoolean &lt;c15:invertIfNegative></description></item>
///<item><description>Bubble3D &lt;c15:bubble3D></description></item>
///<item><description>Marker &lt;c15:marker></description></item>
///<item><description>DataLabel &lt;c15:dLbl></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SequenceOfReferences),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(Explosion),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(InvertIfNegativeBoolean),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(Bubble3D),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(Marker),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(DataLabel),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class CategoryFilterException : OpenXmlCompositeElement
{
    private const string tagName = "categoryFilterException";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13252;
    
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
    /// Initializes a new instance of the CategoryFilterException class.
    /// </summary>
    public CategoryFilterException():base(){}
    
            /// <summary>
    ///Initializes a new instance of the CategoryFilterException class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterException(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterException class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterException(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterException class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CategoryFilterException(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "sqref" == name)
    return new SequenceOfReferences();
    
if( 64 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 64 == namespaceId && "explosion" == name)
    return new Explosion();
    
if( 64 == namespaceId && "invertIfNegative" == name)
    return new InvertIfNegativeBoolean();
    
if( 64 == namespaceId && "bubble3D" == name)
    return new Bubble3D();
    
if( 64 == namespaceId && "marker" == name)
    return new Marker();
    
if( 64 == namespaceId && "dLbl" == name)
    return new DataLabel();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sqref","spPr","explosion","invertIfNegative","bubble3D","marker","dLbl" };
    private static readonly byte[] eleNamespaceIds = { 64,64,64,64,64,64,64 };
    
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
    /// <para> SequenceOfReferences.</para>
    /// <para> Represents the following element tag in the schema: c15:sqref </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public SequenceOfReferences SequenceOfReferences
    {
        get 
        {
            return GetElement<SequenceOfReferences>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c15:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get 
        {
            return GetElement<ShapeProperties>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Explosion.</para>
    /// <para> Represents the following element tag in the schema: c15:explosion </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public Explosion Explosion
    {
        get 
        {
            return GetElement<Explosion>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> InvertIfNegativeBoolean.</para>
    /// <para> Represents the following element tag in the schema: c15:invertIfNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public InvertIfNegativeBoolean InvertIfNegativeBoolean
    {
        get 
        {
            return GetElement<InvertIfNegativeBoolean>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> Bubble3D.</para>
    /// <para> Represents the following element tag in the schema: c15:bubble3D </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public Bubble3D Bubble3D
    {
        get 
        {
            return GetElement<Bubble3D>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c15:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public Marker Marker
    {
        get 
        {
            return GetElement<Marker>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }
    /// <summary>
    /// <para> DataLabel.</para>
    /// <para> Represents the following element tag in the schema: c15:dLbl </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public DataLabel DataLabel
    {
        get 
        {
            return GetElement<DataLabel>(6);
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
        return CloneImp<CategoryFilterException>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataLabelFieldTableEntry Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:dlblFTEntry.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TextFieldGuid &lt;c15:txfldGUID></description></item>
///<item><description>Formula &lt;c15:f></description></item>
///<item><description>DataLabelFieldTableCache &lt;c15:dlblFieldTableCache></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TextFieldGuid),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(Formula),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(DataLabelFieldTableCache),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataLabelFieldTableEntry : OpenXmlCompositeElement
{
    private const string tagName = "dlblFTEntry";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 64;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13255;
    
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
    /// Initializes a new instance of the DataLabelFieldTableEntry class.
    /// </summary>
    public DataLabelFieldTableEntry():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DataLabelFieldTableEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelFieldTableEntry(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTableEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelFieldTableEntry(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTableEntry class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabelFieldTableEntry(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "txfldGUID" == name)
    return new TextFieldGuid();
    
if( 64 == namespaceId && "f" == name)
    return new Formula();
    
if( 64 == namespaceId && "dlblFieldTableCache" == name)
    return new DataLabelFieldTableCache();
    

    return null;
}

        private static readonly string[] eleTagNames = { "txfldGUID","f","dlblFieldTableCache" };
    private static readonly byte[] eleNamespaceIds = { 64,64,64 };
    
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
    /// <para> TextFieldGuid.</para>
    /// <para> Represents the following element tag in the schema: c15:txfldGUID </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public TextFieldGuid TextFieldGuid
    {
        get 
        {
            return GetElement<TextFieldGuid>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: c15:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public Formula Formula
    {
        get 
        {
            return GetElement<Formula>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> DataLabelFieldTableCache.</para>
    /// <para> Represents the following element tag in the schema: c15:dlblFieldTableCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
    public DataLabelFieldTableCache DataLabelFieldTableCache
    {
        get 
        {
            return GetElement<DataLabelFieldTableCache>(2);
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
        return CloneImp<DataLabelFieldTableEntry>(deep);
    }

   
}
}
 
 
