// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office.MetaAttributes;

namespace DocumentFormat.OpenXml.Office.ContentType
{
/// <summary>
/// <para>Defines the ContentTypeSchema Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is ct:contentTypeSchema.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ContentTypeSchema : OpenXmlCompositeElement
{
    private const string tagName = "contentTypeSchema";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 38;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12705;
    
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
    

    private static string[] attributeTagNames = { "_","_","contentTypeName","contentTypeID","contentTypeVersion","contentTypeDescription","contentTypeScope","versionID" };
    private static byte[] attributeNamespaceIds = { 38,41,41,41,41,41,41,41 };
    
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
    /// <para> _.</para>
    /// <para>Represents the following attribute in the schema: ct:_ </para>
    /// </summary>
///<remark> xmlns:ct=http://schemas.microsoft.com/office/2006/metadata/contentType
///</remark>
    [SchemaAttr(38, "_")]
    public StringValue UnderScore
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> _.</para>
    /// <para>Represents the following attribute in the schema: ma:_ </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "_")]
    public StringValue ReservedAttributeString
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> contentTypeName.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeName </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeName")]
    public StringValue ContentTypeName
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> contentTypeID.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeID </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeID")]
    public StringValue ContentTypeID
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> contentTypeVersion.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeVersion </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeVersion")]
    public Int32Value ContentTypeVersion
    {
        get { return (Int32Value)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> contentTypeDescription.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeDescription </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeDescription")]
    public StringValue ContentTypeDescription
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> contentTypeScope.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeScope </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeScope")]
    public StringValue ContentTypeScope
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> versionID.</para>
    /// <para>Represents the following attribute in the schema: ma:versionID </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "versionID")]
    public StringValue VersionID
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ContentTypeSchema class.
    /// </summary>
    public ContentTypeSchema():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ContentTypeSchema class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContentTypeSchema(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContentTypeSchema class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContentTypeSchema(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContentTypeSchema class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContentTypeSchema(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    
    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 38 == namespaceId && "_" == name)
    return new StringValue();
    
if( 41 == namespaceId && "_" == name)
    return new StringValue();
    
if( 41 == namespaceId && "contentTypeName" == name)
    return new StringValue();
    
if( 41 == namespaceId && "contentTypeID" == name)
    return new StringValue();
    
if( 41 == namespaceId && "contentTypeVersion" == name)
    return new Int32Value();
    
if( 41 == namespaceId && "contentTypeDescription" == name)
    return new StringValue();
    
if( 41 == namespaceId && "contentTypeScope" == name)
    return new StringValue();
    
if( 41 == namespaceId && "versionID" == name)
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
        return CloneImp<ContentTypeSchema>(deep);
    }

   
}
}
 
 
