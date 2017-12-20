// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.InkML
{
/// <summary>
/// <para>Defines the Ink Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:ink.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Annotation &lt;inkml:annotation></description></item>
///<item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
///<item><description>Definitions &lt;inkml:definitions></description></item>
///<item><description>Context &lt;inkml:context></description></item>
///<item><description>Trace &lt;inkml:trace></description></item>
///<item><description>TraceGroup &lt;inkml:traceGroup></description></item>
///<item><description>TraceView &lt;inkml:traceView></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Annotation))]
    [ChildElementInfo(typeof(AnnotationXml))]
    [ChildElementInfo(typeof(Definitions))]
    [ChildElementInfo(typeof(Context))]
    [ChildElementInfo(typeof(Trace))]
    [ChildElementInfo(typeof(TraceGroup))]
    [ChildElementInfo(typeof(TraceView))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Ink : OpenXmlPartRootElement
{
    private const string tagName = "ink";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12714;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "documentID" };
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
    /// <para> documentID.</para>
    /// <para>Represents the following attribute in the schema: documentID </para>
    /// </summary>
    [SchemaAttr(0, "documentID")]
    public StringValue DocumentId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Ink class.
    /// </summary>
    public Ink():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Ink class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Ink(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Ink class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Ink(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Ink class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Ink(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "annotation" == name)
    return new Annotation();
    
if( 43 == namespaceId && "annotationXML" == name)
    return new AnnotationXml();
    
if( 43 == namespaceId && "definitions" == name)
    return new Definitions();
    
if( 43 == namespaceId && "context" == name)
    return new Context();
    
if( 43 == namespaceId && "trace" == name)
    return new Trace();
    
if( 43 == namespaceId && "traceGroup" == name)
    return new TraceGroup();
    
if( 43 == namespaceId && "traceView" == name)
    return new TraceView();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "documentID" == name)
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
        return CloneImp<Ink>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Bind Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:bind.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Bind : OpenXmlLeafElement
{
    private const string tagName = "bind";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12715;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "source","target","column","variable" };
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
    /// <para> source.</para>
    /// <para>Represents the following attribute in the schema: source </para>
    /// </summary>
    [SchemaAttr(0, "source")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> column.</para>
    /// <para>Represents the following attribute in the schema: column </para>
    /// </summary>
    [SchemaAttr(0, "column")]
    public StringValue Column
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> variable.</para>
    /// <para>Represents the following attribute in the schema: variable </para>
    /// </summary>
    [SchemaAttr(0, "variable")]
    public StringValue Variable
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Bind class.
    /// </summary>
    public Bind():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "source" == name)
    return new StringValue();
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "column" == name)
    return new StringValue();
    
if( 0 == namespaceId && "variable" == name)
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
        return CloneImp<Bind>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Table Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:table.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Table : OpenXmlLeafTextElement
{
    private const string tagName = "table";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12716;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","apply","interpolation" };
    private static byte[] attributeNamespaceIds = { 1,0,0 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> apply.</para>
    /// <para>Represents the following attribute in the schema: apply </para>
    /// </summary>
    [SchemaAttr(0, "apply")]
    public EnumValue<DocumentFormat.OpenXml.InkML.TableApplyValues> Apply
    {
        get { return (EnumValue<DocumentFormat.OpenXml.InkML.TableApplyValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> interpolation.</para>
    /// <para>Represents the following attribute in the schema: interpolation </para>
    /// </summary>
    [SchemaAttr(0, "interpolation")]
    public EnumValue<DocumentFormat.OpenXml.InkML.TableInterpolationValues> Interpolation
    {
        get { return (EnumValue<DocumentFormat.OpenXml.InkML.TableInterpolationValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Table class.
    /// </summary>
    public Table():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the Table class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Table(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "apply" == name)
    return new EnumValue<DocumentFormat.OpenXml.InkML.TableApplyValues>();
    
if( 0 == namespaceId && "interpolation" == name)
    return new EnumValue<DocumentFormat.OpenXml.InkML.TableInterpolationValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Table>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Matrix Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:matrix.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Matrix : OpenXmlLeafTextElement
{
    private const string tagName = "matrix";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12717;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id" };
    private static byte[] attributeNamespaceIds = { 1 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Matrix class.
    /// </summary>
    public Matrix():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the Matrix class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Matrix(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
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
        return CloneImp<Matrix>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Mapping Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:mapping.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Bind &lt;inkml:bind></description></item>
///<item><description>Table &lt;inkml:table></description></item>
///<item><description>Matrix &lt;inkml:matrix></description></item>
///<item><description>Mapping &lt;inkml:mapping></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Bind))]
    [ChildElementInfo(typeof(Table))]
    [ChildElementInfo(typeof(Matrix))]
    [ChildElementInfo(typeof(Mapping))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Mapping : OpenXmlCompositeElement
{
    private const string tagName = "mapping";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12718;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","type","mappingRef" };
    private static byte[] attributeNamespaceIds = { 1,0,0 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.InkML.MappingTypeValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.InkML.MappingTypeValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> mappingRef.</para>
    /// <para>Represents the following attribute in the schema: mappingRef </para>
    /// </summary>
    [SchemaAttr(0, "mappingRef")]
    public StringValue MappingRef
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Mapping class.
    /// </summary>
    public Mapping():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Mapping class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Mapping(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Mapping class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Mapping(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Mapping class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Mapping(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "bind" == name)
    return new Bind();
    
if( 43 == namespaceId && "table" == name)
    return new Table();
    
if( 43 == namespaceId && "matrix" == name)
    return new Matrix();
    
if( 43 == namespaceId && "mapping" == name)
    return new Mapping();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.InkML.MappingTypeValues>();
    
if( 0 == namespaceId && "mappingRef" == name)
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
        return CloneImp<Mapping>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Channel Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:channel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Mapping &lt;inkml:mapping></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Mapping))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Channel : OpenXmlCompositeElement
{
    private const string tagName = "channel";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12719;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","name","type","default","min","max","orientation","respectTo","units" };
    private static byte[] attributeNamespaceIds = { 1,0,0,0,0,0,0,0,0 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
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
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.InkML.ChannelDataTypeValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.InkML.ChannelDataTypeValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> default.</para>
    /// <para>Represents the following attribute in the schema: default </para>
    /// </summary>
    [SchemaAttr(0, "default")]
    public StringValue Default
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> min.</para>
    /// <para>Represents the following attribute in the schema: min </para>
    /// </summary>
    [SchemaAttr(0, "min")]
    public DecimalValue Min
    {
        get { return (DecimalValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> max.</para>
    /// <para>Represents the following attribute in the schema: max </para>
    /// </summary>
    [SchemaAttr(0, "max")]
    public DecimalValue Max
    {
        get { return (DecimalValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> orientation.</para>
    /// <para>Represents the following attribute in the schema: orientation </para>
    /// </summary>
    [SchemaAttr(0, "orientation")]
    public EnumValue<DocumentFormat.OpenXml.InkML.ChannelValueOrientationValues> Orientation
    {
        get { return (EnumValue<DocumentFormat.OpenXml.InkML.ChannelValueOrientationValues>)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> respectTo.</para>
    /// <para>Represents the following attribute in the schema: respectTo </para>
    /// </summary>
    [SchemaAttr(0, "respectTo")]
    public StringValue RespectTo
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> units.</para>
    /// <para>Represents the following attribute in the schema: units </para>
    /// </summary>
    [SchemaAttr(0, "units")]
    public StringValue Units
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Channel class.
    /// </summary>
    public Channel():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Channel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Channel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Channel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Channel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Channel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Channel(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "mapping" == name)
    return new Mapping();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.InkML.ChannelDataTypeValues>();
    
if( 0 == namespaceId && "default" == name)
    return new StringValue();
    
if( 0 == namespaceId && "min" == name)
    return new DecimalValue();
    
if( 0 == namespaceId && "max" == name)
    return new DecimalValue();
    
if( 0 == namespaceId && "orientation" == name)
    return new EnumValue<DocumentFormat.OpenXml.InkML.ChannelValueOrientationValues>();
    
if( 0 == namespaceId && "respectTo" == name)
    return new StringValue();
    
if( 0 == namespaceId && "units" == name)
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
        return CloneImp<Channel>(deep);
    }

   
}
/// <summary>
/// <para>Defines the IntermittentChannels Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:intermittentChannels.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Channel &lt;inkml:channel></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Channel))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class IntermittentChannels : OpenXmlCompositeElement
{
    private const string tagName = "intermittentChannels";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12720;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the IntermittentChannels class.
    /// </summary>
    public IntermittentChannels():base(){}
    
            /// <summary>
    ///Initializes a new instance of the IntermittentChannels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public IntermittentChannels(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the IntermittentChannels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public IntermittentChannels(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the IntermittentChannels class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public IntermittentChannels(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "channel" == name)
    return new Channel();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<IntermittentChannels>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ChannelProperty Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:channelProperty.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ChannelProperty : OpenXmlLeafElement
{
    private const string tagName = "channelProperty";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12721;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "channel","name","value","units" };
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
    /// <para> channel.</para>
    /// <para>Represents the following attribute in the schema: channel </para>
    /// </summary>
    [SchemaAttr(0, "channel")]
    public StringValue Channel
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
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    public DecimalValue Value
    {
        get { return (DecimalValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> units.</para>
    /// <para>Represents the following attribute in the schema: units </para>
    /// </summary>
    [SchemaAttr(0, "units")]
    public StringValue Units
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ChannelProperty class.
    /// </summary>
    public ChannelProperty():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "channel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "value" == name)
    return new DecimalValue();
    
if( 0 == namespaceId && "units" == name)
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
        return CloneImp<ChannelProperty>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TraceFormat Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:traceFormat.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Channel &lt;inkml:channel></description></item>
///<item><description>IntermittentChannels &lt;inkml:intermittentChannels></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Channel))]
    [ChildElementInfo(typeof(IntermittentChannels))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TraceFormat : OpenXmlCompositeElement
{
    private const string tagName = "traceFormat";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12722;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id" };
    private static byte[] attributeNamespaceIds = { 1 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TraceFormat class.
    /// </summary>
    public TraceFormat():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TraceFormat class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TraceFormat(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TraceFormat class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TraceFormat(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TraceFormat class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TraceFormat(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "channel" == name)
    return new Channel();
    
if( 43 == namespaceId && "intermittentChannels" == name)
    return new IntermittentChannels();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
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
        return CloneImp<TraceFormat>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SampleRate Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:sampleRate.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SampleRate : OpenXmlLeafElement
{
    private const string tagName = "sampleRate";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12723;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "uniform","value" };
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
    /// <para> uniform.</para>
    /// <para>Represents the following attribute in the schema: uniform </para>
    /// </summary>
    [SchemaAttr(0, "uniform")]
    public BooleanValue Uniform
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    public DecimalValue Value
    {
        get { return (DecimalValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SampleRate class.
    /// </summary>
    public SampleRate():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "uniform" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "value" == name)
    return new DecimalValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SampleRate>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Latency Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:latency.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Latency : OpenXmlLeafElement
{
    private const string tagName = "latency";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12724;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "value" };
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
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    public DecimalValue Value
    {
        get { return (DecimalValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Latency class.
    /// </summary>
    public Latency():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "value" == name)
    return new DecimalValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Latency>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ActiveArea Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:activeArea.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ActiveArea : OpenXmlLeafElement
{
    private const string tagName = "activeArea";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12725;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","height","width","units" };
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
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public StringValue Size
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> height.</para>
    /// <para>Represents the following attribute in the schema: height </para>
    /// </summary>
    [SchemaAttr(0, "height")]
    public DecimalValue Height
    {
        get { return (DecimalValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> width.</para>
    /// <para>Represents the following attribute in the schema: width </para>
    /// </summary>
    [SchemaAttr(0, "width")]
    public DecimalValue Width
    {
        get { return (DecimalValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> units.</para>
    /// <para>Represents the following attribute in the schema: units </para>
    /// </summary>
    [SchemaAttr(0, "units")]
    public StringValue Units
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ActiveArea class.
    /// </summary>
    public ActiveArea():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "size" == name)
    return new StringValue();
    
if( 0 == namespaceId && "height" == name)
    return new DecimalValue();
    
if( 0 == namespaceId && "width" == name)
    return new DecimalValue();
    
if( 0 == namespaceId && "units" == name)
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
        return CloneImp<ActiveArea>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SourceProperty Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:srcProperty.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SourceProperty : OpenXmlLeafElement
{
    private const string tagName = "srcProperty";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12726;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "name","value","units" };
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
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    public DecimalValue Value
    {
        get { return (DecimalValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> units.</para>
    /// <para>Represents the following attribute in the schema: units </para>
    /// </summary>
    [SchemaAttr(0, "units")]
    public StringValue Units
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SourceProperty class.
    /// </summary>
    public SourceProperty():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "value" == name)
    return new DecimalValue();
    
if( 0 == namespaceId && "units" == name)
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
        return CloneImp<SourceProperty>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ChannelProperties Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:channelProperties.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChannelProperty &lt;inkml:channelProperty></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ChannelProperty))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ChannelProperties : OpenXmlCompositeElement
{
    private const string tagName = "channelProperties";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12727;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ChannelProperties class.
    /// </summary>
    public ChannelProperties():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ChannelProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChannelProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChannelProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChannelProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChannelProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChannelProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "channelProperty" == name)
    return new ChannelProperty();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ChannelProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Annotation Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:annotation.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Annotation : OpenXmlLeafTextElement
{
    private const string tagName = "annotation";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12728;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "type","encoding" };
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
    public StringValue Type
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> encoding.</para>
    /// <para>Represents the following attribute in the schema: encoding </para>
    /// </summary>
    [SchemaAttr(0, "encoding")]
    public StringValue Encoding
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Annotation class.
    /// </summary>
    public Annotation():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the Annotation class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Annotation(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new StringValue();
    
if( 0 == namespaceId && "encoding" == name)
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
        return CloneImp<Annotation>(deep);
    }

   
}
/// <summary>
/// <para>Defines the AnnotationXml Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:annotationXML.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.EMMA.Emma &lt;emma:emma></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.EMMA.Emma))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AnnotationXml : OpenXmlCompositeElement
{
    private const string tagName = "annotationXML";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12729;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "type","encoding","href" };
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
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public StringValue Type
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> encoding.</para>
    /// <para>Represents the following attribute in the schema: encoding </para>
    /// </summary>
    [SchemaAttr(0, "encoding")]
    public StringValue Encoding
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> href.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the AnnotationXml class.
    /// </summary>
    public AnnotationXml():base(){}
    
            /// <summary>
    ///Initializes a new instance of the AnnotationXml class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AnnotationXml(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AnnotationXml class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AnnotationXml(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AnnotationXml class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AnnotationXml(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 44 == namespaceId && "emma" == name)
    return new DocumentFormat.OpenXml.EMMA.Emma();
    

    return null;
}

        private static readonly string[] eleTagNames = { "emma" };
    private static readonly byte[] eleNamespaceIds = { 44 };
    
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
    /// <para> Emma.</para>
    /// <para> Represents the following element tag in the schema: emma:emma </para>
    /// </summary>
    /// <remark>
    /// xmlns:emma = http://www.w3.org/2003/04/emma
    /// </remark>
    public DocumentFormat.OpenXml.EMMA.Emma Emma
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.EMMA.Emma>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new StringValue();
    
if( 0 == namespaceId && "encoding" == name)
    return new StringValue();
    
if( 0 == namespaceId && "href" == name)
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
        return CloneImp<AnnotationXml>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BrushProperty Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:brushProperty.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Annotation &lt;inkml:annotation></description></item>
///<item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Annotation))]
    [ChildElementInfo(typeof(AnnotationXml))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BrushProperty : OpenXmlCompositeElement
{
    private const string tagName = "brushProperty";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12730;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "name","value","units" };
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
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    public StringValue Value
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> units.</para>
    /// <para>Represents the following attribute in the schema: units </para>
    /// </summary>
    [SchemaAttr(0, "units")]
    public StringValue Units
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BrushProperty class.
    /// </summary>
    public BrushProperty():base(){}
    
            /// <summary>
    ///Initializes a new instance of the BrushProperty class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BrushProperty(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BrushProperty class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BrushProperty(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BrushProperty class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BrushProperty(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "annotation" == name)
    return new Annotation();
    
if( 43 == namespaceId && "annotationXML" == name)
    return new AnnotationXml();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "value" == name)
    return new StringValue();
    
if( 0 == namespaceId && "units" == name)
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
        return CloneImp<BrushProperty>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Canvas Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:canvas.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TraceFormat &lt;inkml:traceFormat></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TraceFormat))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Canvas : OpenXmlCompositeElement
{
    private const string tagName = "canvas";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12731;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","traceFormatRef" };
    private static byte[] attributeNamespaceIds = { 1,0 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> traceFormatRef.</para>
    /// <para>Represents the following attribute in the schema: traceFormatRef </para>
    /// </summary>
    [SchemaAttr(0, "traceFormatRef")]
    public StringValue TraceFormatRef
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Canvas class.
    /// </summary>
    public Canvas():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Canvas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Canvas(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Canvas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Canvas(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Canvas class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Canvas(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "traceFormat" == name)
    return new TraceFormat();
    

    return null;
}

        private static readonly string[] eleTagNames = { "traceFormat" };
    private static readonly byte[] eleNamespaceIds = { 43 };
    
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
    /// <para> TraceFormat.</para>
    /// <para> Represents the following element tag in the schema: inkml:traceFormat </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
    public TraceFormat TraceFormat
    {
        get 
        {
            return GetElement<TraceFormat>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "traceFormatRef" == name)
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
        return CloneImp<Canvas>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CanvasTransform Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:canvasTransform.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Mapping &lt;inkml:mapping></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Mapping))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CanvasTransform : OpenXmlCompositeElement
{
    private const string tagName = "canvasTransform";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12732;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","invertible" };
    private static byte[] attributeNamespaceIds = { 1,0 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> invertible.</para>
    /// <para>Represents the following attribute in the schema: invertible </para>
    /// </summary>
    [SchemaAttr(0, "invertible")]
    public BooleanValue Invertible
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CanvasTransform class.
    /// </summary>
    public CanvasTransform():base(){}
    
            /// <summary>
    ///Initializes a new instance of the CanvasTransform class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CanvasTransform(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CanvasTransform class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CanvasTransform(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CanvasTransform class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CanvasTransform(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "mapping" == name)
    return new Mapping();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "invertible" == name)
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
        return CloneImp<CanvasTransform>(deep);
    }

   
}
/// <summary>
/// <para>Defines the InkSource Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:inkSource.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TraceFormat &lt;inkml:traceFormat></description></item>
///<item><description>SampleRate &lt;inkml:sampleRate></description></item>
///<item><description>Latency &lt;inkml:latency></description></item>
///<item><description>ActiveArea &lt;inkml:activeArea></description></item>
///<item><description>SourceProperty &lt;inkml:srcProperty></description></item>
///<item><description>ChannelProperties &lt;inkml:channelProperties></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TraceFormat))]
    [ChildElementInfo(typeof(SampleRate))]
    [ChildElementInfo(typeof(Latency))]
    [ChildElementInfo(typeof(ActiveArea))]
    [ChildElementInfo(typeof(SourceProperty))]
    [ChildElementInfo(typeof(ChannelProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class InkSource : OpenXmlCompositeElement
{
    private const string tagName = "inkSource";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12733;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","manufacturer","model","serialNo","specificationRef","description" };
    private static byte[] attributeNamespaceIds = { 1,0,0,0,0,0 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> manufacturer.</para>
    /// <para>Represents the following attribute in the schema: manufacturer </para>
    /// </summary>
    [SchemaAttr(0, "manufacturer")]
    public StringValue Manufacturer
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> model.</para>
    /// <para>Represents the following attribute in the schema: model </para>
    /// </summary>
    [SchemaAttr(0, "model")]
    public StringValue Model
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> serialNo.</para>
    /// <para>Represents the following attribute in the schema: serialNo </para>
    /// </summary>
    [SchemaAttr(0, "serialNo")]
    public StringValue SerialNo
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> specificationRef.</para>
    /// <para>Represents the following attribute in the schema: specificationRef </para>
    /// </summary>
    [SchemaAttr(0, "specificationRef")]
    public StringValue SpecificationRef
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the InkSource class.
    /// </summary>
    public InkSource():base(){}
    
            /// <summary>
    ///Initializes a new instance of the InkSource class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public InkSource(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the InkSource class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public InkSource(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the InkSource class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public InkSource(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "traceFormat" == name)
    return new TraceFormat();
    
if( 43 == namespaceId && "sampleRate" == name)
    return new SampleRate();
    
if( 43 == namespaceId && "latency" == name)
    return new Latency();
    
if( 43 == namespaceId && "activeArea" == name)
    return new ActiveArea();
    
if( 43 == namespaceId && "srcProperty" == name)
    return new SourceProperty();
    
if( 43 == namespaceId && "channelProperties" == name)
    return new ChannelProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "traceFormat","sampleRate","latency","activeArea","srcProperty","channelProperties" };
    private static readonly byte[] eleNamespaceIds = { 43,43,43,43,43,43 };
    
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
    /// <para> TraceFormat.</para>
    /// <para> Represents the following element tag in the schema: inkml:traceFormat </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
    public TraceFormat TraceFormat
    {
        get 
        {
            return GetElement<TraceFormat>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> SampleRate.</para>
    /// <para> Represents the following element tag in the schema: inkml:sampleRate </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
    public SampleRate SampleRate
    {
        get 
        {
            return GetElement<SampleRate>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Latency.</para>
    /// <para> Represents the following element tag in the schema: inkml:latency </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
    public Latency Latency
    {
        get 
        {
            return GetElement<Latency>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ActiveArea.</para>
    /// <para> Represents the following element tag in the schema: inkml:activeArea </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
    public ActiveArea ActiveArea
    {
        get 
        {
            return GetElement<ActiveArea>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "manufacturer" == name)
    return new StringValue();
    
if( 0 == namespaceId && "model" == name)
    return new StringValue();
    
if( 0 == namespaceId && "serialNo" == name)
    return new StringValue();
    
if( 0 == namespaceId && "specificationRef" == name)
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
        return CloneImp<InkSource>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Brush Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:brush.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Annotation &lt;inkml:annotation></description></item>
///<item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
///<item><description>BrushProperty &lt;inkml:brushProperty></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Annotation))]
    [ChildElementInfo(typeof(AnnotationXml))]
    [ChildElementInfo(typeof(BrushProperty))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Brush : OpenXmlCompositeElement
{
    private const string tagName = "brush";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12734;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","brushRef" };
    private static byte[] attributeNamespaceIds = { 1,0 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> brushRef.</para>
    /// <para>Represents the following attribute in the schema: brushRef </para>
    /// </summary>
    [SchemaAttr(0, "brushRef")]
    public StringValue BrushRef
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Brush class.
    /// </summary>
    public Brush():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Brush class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Brush(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Brush class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Brush(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Brush class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Brush(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "annotation" == name)
    return new Annotation();
    
if( 43 == namespaceId && "annotationXML" == name)
    return new AnnotationXml();
    
if( 43 == namespaceId && "brushProperty" == name)
    return new BrushProperty();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "brushRef" == name)
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
        return CloneImp<Brush>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Timestamp Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:timestamp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Timestamp : OpenXmlLeafElement
{
    private const string tagName = "timestamp";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12735;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","time","timestampRef","timeString","timeOffset" };
    private static byte[] attributeNamespaceIds = { 1,0,0,0,0 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> time.</para>
    /// <para>Represents the following attribute in the schema: time </para>
    /// </summary>
    [SchemaAttr(0, "time")]
    public DecimalValue Time
    {
        get { return (DecimalValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> timestampRef.</para>
    /// <para>Represents the following attribute in the schema: timestampRef </para>
    /// </summary>
    [SchemaAttr(0, "timestampRef")]
    public StringValue TimestampRef
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> timeString.</para>
    /// <para>Represents the following attribute in the schema: timeString </para>
    /// </summary>
    [SchemaAttr(0, "timeString")]
    public DateTimeValue TimeString
    {
        get { return (DateTimeValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> timeOffset.</para>
    /// <para>Represents the following attribute in the schema: timeOffset </para>
    /// </summary>
    [SchemaAttr(0, "timeOffset")]
    public DecimalValue TimeOffset
    {
        get { return (DecimalValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Timestamp class.
    /// </summary>
    public Timestamp():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "time" == name)
    return new DecimalValue();
    
if( 0 == namespaceId && "timestampRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "timeString" == name)
    return new DateTimeValue();
    
if( 0 == namespaceId && "timeOffset" == name)
    return new DecimalValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Timestamp>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Trace Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:trace.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Trace : OpenXmlLeafTextElement
{
    private const string tagName = "trace";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12736;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","type","continuation","priorRef","contextRef","brushRef","duration","timeOffset" };
    private static byte[] attributeNamespaceIds = { 1,0,0,0,0,0,0,0 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.InkML.TraceTypeValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.InkML.TraceTypeValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> continuation.</para>
    /// <para>Represents the following attribute in the schema: continuation </para>
    /// </summary>
    [SchemaAttr(0, "continuation")]
    public EnumValue<DocumentFormat.OpenXml.InkML.TraceContinuationValues> Continuation
    {
        get { return (EnumValue<DocumentFormat.OpenXml.InkML.TraceContinuationValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> priorRef.</para>
    /// <para>Represents the following attribute in the schema: priorRef </para>
    /// </summary>
    [SchemaAttr(0, "priorRef")]
    public StringValue PriorRef
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> contextRef.</para>
    /// <para>Represents the following attribute in the schema: contextRef </para>
    /// </summary>
    [SchemaAttr(0, "contextRef")]
    public StringValue ContextRef
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> brushRef.</para>
    /// <para>Represents the following attribute in the schema: brushRef </para>
    /// </summary>
    [SchemaAttr(0, "brushRef")]
    public StringValue BrushRef
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> duration.</para>
    /// <para>Represents the following attribute in the schema: duration </para>
    /// </summary>
    [SchemaAttr(0, "duration")]
    public DecimalValue Duration
    {
        get { return (DecimalValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> timeOffset.</para>
    /// <para>Represents the following attribute in the schema: timeOffset </para>
    /// </summary>
    [SchemaAttr(0, "timeOffset")]
    public DecimalValue TimeOffset
    {
        get { return (DecimalValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Trace class.
    /// </summary>
    public Trace():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the Trace class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Trace(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.InkML.TraceTypeValues>();
    
if( 0 == namespaceId && "continuation" == name)
    return new EnumValue<DocumentFormat.OpenXml.InkML.TraceContinuationValues>();
    
if( 0 == namespaceId && "priorRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "contextRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "brushRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "duration" == name)
    return new DecimalValue();
    
if( 0 == namespaceId && "timeOffset" == name)
    return new DecimalValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Trace>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TraceGroup Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:traceGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Annotation &lt;inkml:annotation></description></item>
///<item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
///<item><description>Trace &lt;inkml:trace></description></item>
///<item><description>TraceGroup &lt;inkml:traceGroup></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Annotation))]
    [ChildElementInfo(typeof(AnnotationXml))]
    [ChildElementInfo(typeof(Trace))]
    [ChildElementInfo(typeof(TraceGroup))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TraceGroup : OpenXmlCompositeElement
{
    private const string tagName = "traceGroup";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12737;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","contextRef","brushRef" };
    private static byte[] attributeNamespaceIds = { 1,0,0 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> contextRef.</para>
    /// <para>Represents the following attribute in the schema: contextRef </para>
    /// </summary>
    [SchemaAttr(0, "contextRef")]
    public StringValue ContextRef
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> brushRef.</para>
    /// <para>Represents the following attribute in the schema: brushRef </para>
    /// </summary>
    [SchemaAttr(0, "brushRef")]
    public StringValue BrushRef
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TraceGroup class.
    /// </summary>
    public TraceGroup():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TraceGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TraceGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TraceGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TraceGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TraceGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TraceGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "annotation" == name)
    return new Annotation();
    
if( 43 == namespaceId && "annotationXML" == name)
    return new AnnotationXml();
    
if( 43 == namespaceId && "trace" == name)
    return new Trace();
    
if( 43 == namespaceId && "traceGroup" == name)
    return new TraceGroup();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "contextRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "brushRef" == name)
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
        return CloneImp<TraceGroup>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TraceView Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:traceView.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Annotation &lt;inkml:annotation></description></item>
///<item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
///<item><description>TraceView &lt;inkml:traceView></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Annotation))]
    [ChildElementInfo(typeof(AnnotationXml))]
    [ChildElementInfo(typeof(TraceView))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TraceView : OpenXmlCompositeElement
{
    private const string tagName = "traceView";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12738;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","contextRef","traceDataRef","from","to" };
    private static byte[] attributeNamespaceIds = { 1,0,0,0,0 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> contextRef.</para>
    /// <para>Represents the following attribute in the schema: contextRef </para>
    /// </summary>
    [SchemaAttr(0, "contextRef")]
    public StringValue ContextRef
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> traceDataRef.</para>
    /// <para>Represents the following attribute in the schema: traceDataRef </para>
    /// </summary>
    [SchemaAttr(0, "traceDataRef")]
    public StringValue TraceDataRef
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> from.</para>
    /// <para>Represents the following attribute in the schema: from </para>
    /// </summary>
    [SchemaAttr(0, "from")]
    public StringValue From
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> to.</para>
    /// <para>Represents the following attribute in the schema: to </para>
    /// </summary>
    [SchemaAttr(0, "to")]
    public StringValue To
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TraceView class.
    /// </summary>
    public TraceView():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TraceView class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TraceView(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TraceView class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TraceView(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TraceView class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TraceView(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "annotation" == name)
    return new Annotation();
    
if( 43 == namespaceId && "annotationXML" == name)
    return new AnnotationXml();
    
if( 43 == namespaceId && "traceView" == name)
    return new TraceView();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "contextRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "traceDataRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "from" == name)
    return new StringValue();
    
if( 0 == namespaceId && "to" == name)
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
        return CloneImp<TraceView>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Context Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:context.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Canvas &lt;inkml:canvas></description></item>
///<item><description>CanvasTransform &lt;inkml:canvasTransform></description></item>
///<item><description>TraceFormat &lt;inkml:traceFormat></description></item>
///<item><description>InkSource &lt;inkml:inkSource></description></item>
///<item><description>Brush &lt;inkml:brush></description></item>
///<item><description>Timestamp &lt;inkml:timestamp></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Canvas))]
    [ChildElementInfo(typeof(CanvasTransform))]
    [ChildElementInfo(typeof(TraceFormat))]
    [ChildElementInfo(typeof(InkSource))]
    [ChildElementInfo(typeof(Brush))]
    [ChildElementInfo(typeof(Timestamp))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Context : OpenXmlCompositeElement
{
    private const string tagName = "context";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12739;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","contextRef","canvasRef","canvasTransformRef","traceFormatRef","inkSourceRef","brushRef","timestampRef" };
    private static byte[] attributeNamespaceIds = { 1,0,0,0,0,0,0,0 };
    
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
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> contextRef.</para>
    /// <para>Represents the following attribute in the schema: contextRef </para>
    /// </summary>
    [SchemaAttr(0, "contextRef")]
    public StringValue ContextRef
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> canvasRef.</para>
    /// <para>Represents the following attribute in the schema: canvasRef </para>
    /// </summary>
    [SchemaAttr(0, "canvasRef")]
    public StringValue CanvasRef
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> canvasTransformRef.</para>
    /// <para>Represents the following attribute in the schema: canvasTransformRef </para>
    /// </summary>
    [SchemaAttr(0, "canvasTransformRef")]
    public StringValue CanvasTransformRef
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> traceFormatRef.</para>
    /// <para>Represents the following attribute in the schema: traceFormatRef </para>
    /// </summary>
    [SchemaAttr(0, "traceFormatRef")]
    public StringValue TraceFromatRef
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> inkSourceRef.</para>
    /// <para>Represents the following attribute in the schema: inkSourceRef </para>
    /// </summary>
    [SchemaAttr(0, "inkSourceRef")]
    public StringValue InkSourceRef
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> brushRef.</para>
    /// <para>Represents the following attribute in the schema: brushRef </para>
    /// </summary>
    [SchemaAttr(0, "brushRef")]
    public StringValue BrushRef
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> timestampRef.</para>
    /// <para>Represents the following attribute in the schema: timestampRef </para>
    /// </summary>
    [SchemaAttr(0, "timestampRef")]
    public StringValue TimestampRef
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Context class.
    /// </summary>
    public Context():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Context class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Context(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Context class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Context(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Context class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Context(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "canvas" == name)
    return new Canvas();
    
if( 43 == namespaceId && "canvasTransform" == name)
    return new CanvasTransform();
    
if( 43 == namespaceId && "traceFormat" == name)
    return new TraceFormat();
    
if( 43 == namespaceId && "inkSource" == name)
    return new InkSource();
    
if( 43 == namespaceId && "brush" == name)
    return new Brush();
    
if( 43 == namespaceId && "timestamp" == name)
    return new Timestamp();
    

    return null;
}

        private static readonly string[] eleTagNames = { "canvas","canvasTransform","traceFormat","inkSource","brush","timestamp" };
    private static readonly byte[] eleNamespaceIds = { 43,43,43,43,43,43 };
    
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
    /// <para> Canvas.</para>
    /// <para> Represents the following element tag in the schema: inkml:canvas </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
    public Canvas Canvas
    {
        get 
        {
            return GetElement<Canvas>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> CanvasTransform.</para>
    /// <para> Represents the following element tag in the schema: inkml:canvasTransform </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
    public CanvasTransform CanvasTransform
    {
        get 
        {
            return GetElement<CanvasTransform>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> TraceFormat.</para>
    /// <para> Represents the following element tag in the schema: inkml:traceFormat </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
    public TraceFormat TraceFormat
    {
        get 
        {
            return GetElement<TraceFormat>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> InkSource.</para>
    /// <para> Represents the following element tag in the schema: inkml:inkSource </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
    public InkSource InkSource
    {
        get 
        {
            return GetElement<InkSource>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> Brush.</para>
    /// <para> Represents the following element tag in the schema: inkml:brush </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
    public Brush Brush
    {
        get 
        {
            return GetElement<Brush>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> Timestamp.</para>
    /// <para> Represents the following element tag in the schema: inkml:timestamp </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
    public Timestamp Timestamp
    {
        get 
        {
            return GetElement<Timestamp>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "contextRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "canvasRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "canvasTransformRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "traceFormatRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "inkSourceRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "brushRef" == name)
    return new StringValue();
    
if( 0 == namespaceId && "timestampRef" == name)
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
        return CloneImp<Context>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Definitions Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:definitions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Brush &lt;inkml:brush></description></item>
///<item><description>Canvas &lt;inkml:canvas></description></item>
///<item><description>CanvasTransform &lt;inkml:canvasTransform></description></item>
///<item><description>Context &lt;inkml:context></description></item>
///<item><description>InkSource &lt;inkml:inkSource></description></item>
///<item><description>Mapping &lt;inkml:mapping></description></item>
///<item><description>Timestamp &lt;inkml:timestamp></description></item>
///<item><description>Trace &lt;inkml:trace></description></item>
///<item><description>TraceFormat &lt;inkml:traceFormat></description></item>
///<item><description>TraceGroup &lt;inkml:traceGroup></description></item>
///<item><description>TraceView &lt;inkml:traceView></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Brush))]
    [ChildElementInfo(typeof(Canvas))]
    [ChildElementInfo(typeof(CanvasTransform))]
    [ChildElementInfo(typeof(Context))]
    [ChildElementInfo(typeof(InkSource))]
    [ChildElementInfo(typeof(Mapping))]
    [ChildElementInfo(typeof(Timestamp))]
    [ChildElementInfo(typeof(Trace))]
    [ChildElementInfo(typeof(TraceFormat))]
    [ChildElementInfo(typeof(TraceGroup))]
    [ChildElementInfo(typeof(TraceView))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Definitions : OpenXmlCompositeElement
{
    private const string tagName = "definitions";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 43;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12740;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Definitions class.
    /// </summary>
    public Definitions():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Definitions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Definitions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Definitions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Definitions(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Definitions class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Definitions(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 43 == namespaceId && "brush" == name)
    return new Brush();
    
if( 43 == namespaceId && "canvas" == name)
    return new Canvas();
    
if( 43 == namespaceId && "canvasTransform" == name)
    return new CanvasTransform();
    
if( 43 == namespaceId && "context" == name)
    return new Context();
    
if( 43 == namespaceId && "inkSource" == name)
    return new InkSource();
    
if( 43 == namespaceId && "mapping" == name)
    return new Mapping();
    
if( 43 == namespaceId && "timestamp" == name)
    return new Timestamp();
    
if( 43 == namespaceId && "trace" == name)
    return new Trace();
    
if( 43 == namespaceId && "traceFormat" == name)
    return new TraceFormat();
    
if( 43 == namespaceId && "traceGroup" == name)
    return new TraceGroup();
    
if( 43 == namespaceId && "traceView" == name)
    return new TraceView();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Definitions>(deep);
    }

   
}
/// <summary>
/// Defines the ChannelDataTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ChannelDataTypeValues
{  
	///<summary>
///integer.
///<para>When the item is serialized out as xml, its value is "integer".</para>
///</summary>
[EnumString("integer")]
Integer,
///<summary>
///decimal.
///<para>When the item is serialized out as xml, its value is "decimal".</para>
///</summary>
[EnumString("decimal")]
Decimal,
///<summary>
///boolean.
///<para>When the item is serialized out as xml, its value is "boolean".</para>
///</summary>
[EnumString("boolean")]
Boolean,
 
}
/// <summary>
/// Defines the ChannelValueOrientationValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ChannelValueOrientationValues
{  
	///<summary>
///+ve.
///<para>When the item is serialized out as xml, its value is "+ve".</para>
///</summary>
[EnumString("+ve")]
PlusVe,
///<summary>
///-ve.
///<para>When the item is serialized out as xml, its value is "-ve".</para>
///</summary>
[EnumString("-ve")]
MinusVe,
 
}
/// <summary>
/// Defines the StandardChannelPropertyNameValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardChannelPropertyNameValues
{  
	///<summary>
///threshold.
///<para>When the item is serialized out as xml, its value is "threshold".</para>
///</summary>
[EnumString("threshold")]
Threshold,
///<summary>
///resolution.
///<para>When the item is serialized out as xml, its value is "resolution".</para>
///</summary>
[EnumString("resolution")]
Resolution,
///<summary>
///quantization.
///<para>When the item is serialized out as xml, its value is "quantization".</para>
///</summary>
[EnumString("quantization")]
Quantization,
///<summary>
///noise.
///<para>When the item is serialized out as xml, its value is "noise".</para>
///</summary>
[EnumString("noise")]
Noise,
///<summary>
///accuracy.
///<para>When the item is serialized out as xml, its value is "accuracy".</para>
///</summary>
[EnumString("accuracy")]
Accuracy,
///<summary>
///crossCoupling.
///<para>When the item is serialized out as xml, its value is "crossCoupling".</para>
///</summary>
[EnumString("crossCoupling")]
CrossCoupling,
///<summary>
///skew.
///<para>When the item is serialized out as xml, its value is "skew".</para>
///</summary>
[EnumString("skew")]
Skew,
///<summary>
///minBandwidth.
///<para>When the item is serialized out as xml, its value is "minBandwidth".</para>
///</summary>
[EnumString("minBandwidth")]
MinBandwidth,
///<summary>
///peakRate.
///<para>When the item is serialized out as xml, its value is "peakRate".</para>
///</summary>
[EnumString("peakRate")]
PeakRate,
///<summary>
///distortion.
///<para>When the item is serialized out as xml, its value is "distortion".</para>
///</summary>
[EnumString("distortion")]
Distortion,
 
}
/// <summary>
/// Defines the StandardBrushPropertyNameValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardBrushPropertyNameValues
{  
	///<summary>
///width.
///<para>When the item is serialized out as xml, its value is "width".</para>
///</summary>
[EnumString("width")]
Width,
///<summary>
///height.
///<para>When the item is serialized out as xml, its value is "height".</para>
///</summary>
[EnumString("height")]
Height,
///<summary>
///color.
///<para>When the item is serialized out as xml, its value is "color".</para>
///</summary>
[EnumString("color")]
Color,
///<summary>
///transparency.
///<para>When the item is serialized out as xml, its value is "transparency".</para>
///</summary>
[EnumString("transparency")]
Transparency,
///<summary>
///tip.
///<para>When the item is serialized out as xml, its value is "tip".</para>
///</summary>
[EnumString("tip")]
Tip,
///<summary>
///rasterOp.
///<para>When the item is serialized out as xml, its value is "rasterOp".</para>
///</summary>
[EnumString("rasterOp")]
RasterOp,
///<summary>
///antiAliased.
///<para>When the item is serialized out as xml, its value is "antiAliased".</para>
///</summary>
[EnumString("antiAliased")]
AntiAliased,
///<summary>
///fitToCurve.
///<para>When the item is serialized out as xml, its value is "fitToCurve".</para>
///</summary>
[EnumString("fitToCurve")]
FitToCurve,
///<summary>
///ignorePressure.
///<para>When the item is serialized out as xml, its value is "ignorePressure".</para>
///</summary>
[EnumString("ignorePressure")]
IgnorePressure,
 
}
/// <summary>
/// Defines the StandardChannelNameValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardChannelNameValues
{  
	///<summary>
///X.
///<para>When the item is serialized out as xml, its value is "X".</para>
///</summary>
[EnumString("X")]
XCoordinate,
///<summary>
///Y.
///<para>When the item is serialized out as xml, its value is "Y".</para>
///</summary>
[EnumString("Y")]
YCoordinate,
///<summary>
///Z.
///<para>When the item is serialized out as xml, its value is "Z".</para>
///</summary>
[EnumString("Z")]
ZCoordinate,
///<summary>
///F.
///<para>When the item is serialized out as xml, its value is "F".</para>
///</summary>
[EnumString("F")]
PenTipForce,
///<summary>
///TP.
///<para>When the item is serialized out as xml, its value is "TP".</para>
///</summary>
[EnumString("TP")]
TangentPressure,
///<summary>
///BP.
///<para>When the item is serialized out as xml, its value is "BP".</para>
///</summary>
[EnumString("BP")]
ButtonPressure,
///<summary>
///S.
///<para>When the item is serialized out as xml, its value is "S".</para>
///</summary>
[EnumString("S")]
TipSwitchState,
///<summary>
///B1.
///<para>When the item is serialized out as xml, its value is "B1".</para>
///</summary>
[EnumString("B1")]
SideButton1State,
///<summary>
///B2.
///<para>When the item is serialized out as xml, its value is "B2".</para>
///</summary>
[EnumString("B2")]
SideButton2State,
///<summary>
///B3.
///<para>When the item is serialized out as xml, its value is "B3".</para>
///</summary>
[EnumString("B3")]
SideButton3State,
///<summary>
///B4.
///<para>When the item is serialized out as xml, its value is "B4".</para>
///</summary>
[EnumString("B4")]
SideButton4State,
///<summary>
///E.
///<para>When the item is serialized out as xml, its value is "E".</para>
///</summary>
[EnumString("E")]
PenInverted,
///<summary>
///OTx.
///<para>When the item is serialized out as xml, its value is "OTx".</para>
///</summary>
[EnumString("OTx")]
TiltAlongXAxis,
///<summary>
///OTy.
///<para>When the item is serialized out as xml, its value is "OTy".</para>
///</summary>
[EnumString("OTy")]
TiltAlongYAxis,
///<summary>
///OA.
///<para>When the item is serialized out as xml, its value is "OA".</para>
///</summary>
[EnumString("OA")]
PenAzimuthAngle,
///<summary>
///OE.
///<para>When the item is serialized out as xml, its value is "OE".</para>
///</summary>
[EnumString("OE")]
PenElevationAngle,
///<summary>
///OR.
///<para>When the item is serialized out as xml, its value is "OR".</para>
///</summary>
[EnumString("OR")]
PexAxisRotation,
///<summary>
///RP.
///<para>When the item is serialized out as xml, its value is "RP".</para>
///</summary>
[EnumString("RP")]
PitchRotation,
///<summary>
///RR.
///<para>When the item is serialized out as xml, its value is "RR".</para>
///</summary>
[EnumString("RR")]
RollRotation,
///<summary>
///RY.
///<para>When the item is serialized out as xml, its value is "RY".</para>
///</summary>
[EnumString("RY")]
YawRotation,
///<summary>
///C.
///<para>When the item is serialized out as xml, its value is "C".</para>
///</summary>
[EnumString("C")]
ColorValue,
///<summary>
///CR.
///<para>When the item is serialized out as xml, its value is "CR".</para>
///</summary>
[EnumString("CR")]
RedColorValue,
///<summary>
///CG.
///<para>When the item is serialized out as xml, its value is "CG".</para>
///</summary>
[EnumString("CG")]
GreenColorValue,
///<summary>
///CB.
///<para>When the item is serialized out as xml, its value is "CB".</para>
///</summary>
[EnumString("CB")]
BlueColorValue,
///<summary>
///CC.
///<para>When the item is serialized out as xml, its value is "CC".</para>
///</summary>
[EnumString("CC")]
CyanColorValue,
///<summary>
///CM.
///<para>When the item is serialized out as xml, its value is "CM".</para>
///</summary>
[EnumString("CM")]
MegentaColorValue,
///<summary>
///CY.
///<para>When the item is serialized out as xml, its value is "CY".</para>
///</summary>
[EnumString("CY")]
YellowColorValue,
///<summary>
///CK.
///<para>When the item is serialized out as xml, its value is "CK".</para>
///</summary>
[EnumString("CK")]
BlackColorValue,
///<summary>
///W.
///<para>When the item is serialized out as xml, its value is "W".</para>
///</summary>
[EnumString("W")]
StrokesWidth,
///<summary>
///T.
///<para>When the item is serialized out as xml, its value is "T".</para>
///</summary>
[EnumString("T")]
Time,
///<summary>
///SN.
///<para>When the item is serialized out as xml, its value is "SN".</para>
///</summary>
[EnumString("SN")]
SerialNumber,
///<summary>
///TW.
///<para>When the item is serialized out as xml, its value is "TW".</para>
///</summary>
[EnumString("TW")]
TouchWidth,
///<summary>
///TH.
///<para>When the item is serialized out as xml, its value is "TH".</para>
///</summary>
[EnumString("TH")]
TouchHeight,
///<summary>
///TC.
///<para>When the item is serialized out as xml, its value is "TC".</para>
///</summary>
[EnumString("TC")]
FingerTouch,
 
}
/// <summary>
/// Defines the StandardLengthUnitsValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardLengthUnitsValues
{  
	///<summary>
///m.
///<para>When the item is serialized out as xml, its value is "m".</para>
///</summary>
[EnumString("m")]
Meter,
///<summary>
///cm.
///<para>When the item is serialized out as xml, its value is "cm".</para>
///</summary>
[EnumString("cm")]
Centimeter,
///<summary>
///mm.
///<para>When the item is serialized out as xml, its value is "mm".</para>
///</summary>
[EnumString("mm")]
Millimeter,
///<summary>
///in.
///<para>When the item is serialized out as xml, its value is "in".</para>
///</summary>
[EnumString("in")]
Inche,
///<summary>
///pt.
///<para>When the item is serialized out as xml, its value is "pt".</para>
///</summary>
[EnumString("pt")]
Point,
///<summary>
///pc.
///<para>When the item is serialized out as xml, its value is "pc".</para>
///</summary>
[EnumString("pc")]
Pica,
///<summary>
///em.
///<para>When the item is serialized out as xml, its value is "em".</para>
///</summary>
[EnumString("em")]
Em,
///<summary>
///ex.
///<para>When the item is serialized out as xml, its value is "ex".</para>
///</summary>
[EnumString("ex")]
Ex,
 
}
/// <summary>
/// Defines the StandardPerLengthUnitsValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardPerLengthUnitsValues
{  
	///<summary>
///1/m.
///<para>When the item is serialized out as xml, its value is "1/m".</para>
///</summary>
[EnumString("1/m")]
PerMeter,
///<summary>
///1/cm.
///<para>When the item is serialized out as xml, its value is "1/cm".</para>
///</summary>
[EnumString("1/cm")]
PerCentimeter,
///<summary>
///1/mm.
///<para>When the item is serialized out as xml, its value is "1/mm".</para>
///</summary>
[EnumString("1/mm")]
PerMillimeter,
///<summary>
///1/in.
///<para>When the item is serialized out as xml, its value is "1/in".</para>
///</summary>
[EnumString("1/in")]
PerInche,
///<summary>
///1/pt.
///<para>When the item is serialized out as xml, its value is "1/pt".</para>
///</summary>
[EnumString("1/pt")]
PerPoint,
///<summary>
///1/pc.
///<para>When the item is serialized out as xml, its value is "1/pc".</para>
///</summary>
[EnumString("1/pc")]
PerPica,
///<summary>
///1/em.
///<para>When the item is serialized out as xml, its value is "1/em".</para>
///</summary>
[EnumString("1/em")]
PerEm,
///<summary>
///1/ex.
///<para>When the item is serialized out as xml, its value is "1/ex".</para>
///</summary>
[EnumString("1/ex")]
PerEx,
 
}
/// <summary>
/// Defines the StandardTimeUnitsValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardTimeUnitsValues
{  
	///<summary>
///s.
///<para>When the item is serialized out as xml, its value is "s".</para>
///</summary>
[EnumString("s")]
Second,
///<summary>
///ms.
///<para>When the item is serialized out as xml, its value is "ms".</para>
///</summary>
[EnumString("ms")]
Millisecond,
 
}
/// <summary>
/// Defines the StandardPerTimeUnitsValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardPerTimeUnitsValues
{  
	///<summary>
///1/s.
///<para>When the item is serialized out as xml, its value is "1/s".</para>
///</summary>
[EnumString("1/s")]
PerSecond,
///<summary>
///1/ms.
///<para>When the item is serialized out as xml, its value is "1/ms".</para>
///</summary>
[EnumString("1/ms")]
PerMillisecond,
 
}
/// <summary>
/// Defines the StandardMassForceUnitsValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardMassForceUnitsValues
{  
	///<summary>
///Kg.
///<para>When the item is serialized out as xml, its value is "Kg".</para>
///</summary>
[EnumString("Kg")]
Kilogram,
///<summary>
///g.
///<para>When the item is serialized out as xml, its value is "g".</para>
///</summary>
[EnumString("g")]
Gram,
///<summary>
///mg.
///<para>When the item is serialized out as xml, its value is "mg".</para>
///</summary>
[EnumString("mg")]
Milligram,
///<summary>
///N.
///<para>When the item is serialized out as xml, its value is "N".</para>
///</summary>
[EnumString("N")]
Newton,
///<summary>
///lb.
///<para>When the item is serialized out as xml, its value is "lb".</para>
///</summary>
[EnumString("lb")]
Pond,
 
}
/// <summary>
/// Defines the StandardPerMassForceUnitsValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardPerMassForceUnitsValues
{  
	///<summary>
///1/Kg.
///<para>When the item is serialized out as xml, its value is "1/Kg".</para>
///</summary>
[EnumString("1/Kg")]
PerKilogram,
///<summary>
///1/g.
///<para>When the item is serialized out as xml, its value is "1/g".</para>
///</summary>
[EnumString("1/g")]
PerGram,
///<summary>
///1/mg.
///<para>When the item is serialized out as xml, its value is "1/mg".</para>
///</summary>
[EnumString("1/mg")]
PerMilligram,
///<summary>
///1/N.
///<para>When the item is serialized out as xml, its value is "1/N".</para>
///</summary>
[EnumString("1/N")]
PerNewton,
///<summary>
///1/lb.
///<para>When the item is serialized out as xml, its value is "1/lb".</para>
///</summary>
[EnumString("1/lb")]
PerPond,
 
}
/// <summary>
/// Defines the StandardAngleUnitsValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardAngleUnitsValues
{  
	///<summary>
///deg.
///<para>When the item is serialized out as xml, its value is "deg".</para>
///</summary>
[EnumString("deg")]
Degree,
///<summary>
///rad.
///<para>When the item is serialized out as xml, its value is "rad".</para>
///</summary>
[EnumString("rad")]
Radian,
 
}
/// <summary>
/// Defines the StandardPerAngleUnitsValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardPerAngleUnitsValues
{  
	///<summary>
///1/deg.
///<para>When the item is serialized out as xml, its value is "1/deg".</para>
///</summary>
[EnumString("1/deg")]
PerDegree,
///<summary>
///1/rad.
///<para>When the item is serialized out as xml, its value is "1/rad".</para>
///</summary>
[EnumString("1/rad")]
PerRadian,
 
}
/// <summary>
/// Defines the StandardOtherUnitsValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardOtherUnitsValues
{  
	///<summary>
///%.
///<para>When the item is serialized out as xml, its value is "%".</para>
///</summary>
[EnumString("%")]
Percentage,
///<summary>
///dev.
///<para>When the item is serialized out as xml, its value is "dev".</para>
///</summary>
[EnumString("dev")]
DeviceResolution,
///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
 
}
/// <summary>
/// Defines the StandardPerOtherUnitsValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StandardPerOtherUnitsValues
{  
	///<summary>
///1/%.
///<para>When the item is serialized out as xml, its value is "1/%".</para>
///</summary>
[EnumString("1/%")]
PerPercentage,
///<summary>
///1/dev.
///<para>When the item is serialized out as xml, its value is "1/dev".</para>
///</summary>
[EnumString("1/dev")]
PerDeviceResolution,
 
}
/// <summary>
/// Defines the TraceTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TraceTypeValues
{  
	///<summary>
///penDown.
///<para>When the item is serialized out as xml, its value is "penDown".</para>
///</summary>
[EnumString("penDown")]
PenDown,
///<summary>
///penUp.
///<para>When the item is serialized out as xml, its value is "penUp".</para>
///</summary>
[EnumString("penUp")]
PenUp,
///<summary>
///indeterminate.
///<para>When the item is serialized out as xml, its value is "indeterminate".</para>
///</summary>
[EnumString("indeterminate")]
Indeterminate,
 
}
/// <summary>
/// Defines the TraceContinuationValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TraceContinuationValues
{  
	///<summary>
///begin.
///<para>When the item is serialized out as xml, its value is "begin".</para>
///</summary>
[EnumString("begin")]
Begin,
///<summary>
///end.
///<para>When the item is serialized out as xml, its value is "end".</para>
///</summary>
[EnumString("end")]
End,
///<summary>
///middle.
///<para>When the item is serialized out as xml, its value is "middle".</para>
///</summary>
[EnumString("middle")]
Middle,
 
}
/// <summary>
/// Defines the RasterOperationValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum RasterOperationValues
{  
	///<summary>
///black.
///<para>When the item is serialized out as xml, its value is "black".</para>
///</summary>
[EnumString("black")]
Black,
///<summary>
///notMergePen.
///<para>When the item is serialized out as xml, its value is "notMergePen".</para>
///</summary>
[EnumString("notMergePen")]
NotMergePen,
///<summary>
///maskNotPen.
///<para>When the item is serialized out as xml, its value is "maskNotPen".</para>
///</summary>
[EnumString("maskNotPen")]
MaskNotPen,
///<summary>
///notCopyPen.
///<para>When the item is serialized out as xml, its value is "notCopyPen".</para>
///</summary>
[EnumString("notCopyPen")]
NotCopyPen,
///<summary>
///maskPenNot.
///<para>When the item is serialized out as xml, its value is "maskPenNot".</para>
///</summary>
[EnumString("maskPenNot")]
MaskPenNot,
///<summary>
///not.
///<para>When the item is serialized out as xml, its value is "not".</para>
///</summary>
[EnumString("not")]
Not,
///<summary>
///xOrPen.
///<para>When the item is serialized out as xml, its value is "xOrPen".</para>
///</summary>
[EnumString("xOrPen")]
XOrPen,
///<summary>
///notMaskPen.
///<para>When the item is serialized out as xml, its value is "notMaskPen".</para>
///</summary>
[EnumString("notMaskPen")]
NotMaskPen,
///<summary>
///maskPen.
///<para>When the item is serialized out as xml, its value is "maskPen".</para>
///</summary>
[EnumString("maskPen")]
MaskPen,
///<summary>
///notXOrPen.
///<para>When the item is serialized out as xml, its value is "notXOrPen".</para>
///</summary>
[EnumString("notXOrPen")]
NotXOrPen,
///<summary>
///noOperation.
///<para>When the item is serialized out as xml, its value is "noOperation".</para>
///</summary>
[EnumString("noOperation")]
NoOperation,
///<summary>
///mergeNotPen.
///<para>When the item is serialized out as xml, its value is "mergeNotPen".</para>
///</summary>
[EnumString("mergeNotPen")]
MergeNotPen,
///<summary>
///copyPen.
///<para>When the item is serialized out as xml, its value is "copyPen".</para>
///</summary>
[EnumString("copyPen")]
CopyPen,
///<summary>
///mergePenNot.
///<para>When the item is serialized out as xml, its value is "mergePenNot".</para>
///</summary>
[EnumString("mergePenNot")]
MergePenNot,
///<summary>
///mergePen.
///<para>When the item is serialized out as xml, its value is "mergePen".</para>
///</summary>
[EnumString("mergePen")]
MergePen,
///<summary>
///white.
///<para>When the item is serialized out as xml, its value is "white".</para>
///</summary>
[EnumString("white")]
White,
 
}
/// <summary>
/// Defines the PenTipShapeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PenTipShapeValues
{  
	///<summary>
///ellipse.
///<para>When the item is serialized out as xml, its value is "ellipse".</para>
///</summary>
[EnumString("ellipse")]
Ellipse,
///<summary>
///rectangle.
///<para>When the item is serialized out as xml, its value is "rectangle".</para>
///</summary>
[EnumString("rectangle")]
Rectangle,
///<summary>
///drop.
///<para>When the item is serialized out as xml, its value is "drop".</para>
///</summary>
[EnumString("drop")]
Drop,
 
}
/// <summary>
/// Defines the MappingTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum MappingTypeValues
{  
	///<summary>
///identity.
///<para>When the item is serialized out as xml, its value is "identity".</para>
///</summary>
[EnumString("identity")]
Identity,
///<summary>
///lookup.
///<para>When the item is serialized out as xml, its value is "lookup".</para>
///</summary>
[EnumString("lookup")]
Lookup,
///<summary>
///affine.
///<para>When the item is serialized out as xml, its value is "affine".</para>
///</summary>
[EnumString("affine")]
Affine,
///<summary>
///mathml.
///<para>When the item is serialized out as xml, its value is "mathml".</para>
///</summary>
[EnumString("mathml")]
MathML,
///<summary>
///product.
///<para>When the item is serialized out as xml, its value is "product".</para>
///</summary>
[EnumString("product")]
Product,
///<summary>
///unknown.
///<para>When the item is serialized out as xml, its value is "unknown".</para>
///</summary>
[EnumString("unknown")]
Unknown,
 
}
/// <summary>
/// Defines the TableApplyValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TableApplyValues
{  
	///<summary>
///absolute.
///<para>When the item is serialized out as xml, its value is "absolute".</para>
///</summary>
[EnumString("absolute")]
Absolute,
///<summary>
///relative.
///<para>When the item is serialized out as xml, its value is "relative".</para>
///</summary>
[EnumString("relative")]
Relative,
 
}
/// <summary>
/// Defines the TableInterpolationValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TableInterpolationValues
{  
	///<summary>
///floor.
///<para>When the item is serialized out as xml, its value is "floor".</para>
///</summary>
[EnumString("floor")]
Floor,
///<summary>
///middle.
///<para>When the item is serialized out as xml, its value is "middle".</para>
///</summary>
[EnumString("middle")]
Middle,
///<summary>
///ceiling.
///<para>When the item is serialized out as xml, its value is "ceiling".</para>
///</summary>
[EnumString("ceiling")]
Ceiling,
///<summary>
///linear.
///<para>When the item is serialized out as xml, its value is "linear".</para>
///</summary>
[EnumString("linear")]
Linear,
///<summary>
///cubic.
///<para>When the item is serialized out as xml, its value is "cubic".</para>
///</summary>
[EnumString("cubic")]
Cubic,
 
}
}
 
 
