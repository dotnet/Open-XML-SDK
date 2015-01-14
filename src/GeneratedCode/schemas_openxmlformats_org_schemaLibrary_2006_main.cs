// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.CustomXmlSchemaReferences
{
/// <summary>
/// <para>Embedded Custom XML Schema Supplementary Data.</para>
/// <para> When the object is serialized out as xml, its qualified name is sl:schemaLibrary.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Schema &lt;sl:schema></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Schema))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SchemaLibrary : OpenXmlCompositeElement
{
    private const string tagName = "schemaLibrary";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 25;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12468;
    
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
    /// Initializes a new instance of the SchemaLibrary class.
    /// </summary>
    public SchemaLibrary():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SchemaLibrary class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SchemaLibrary(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SchemaLibrary class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SchemaLibrary(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SchemaLibrary class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SchemaLibrary(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 25 == namespaceId && "schema" == name)
    return new Schema();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SchemaLibrary>(deep);
    }

   
}
/// <summary>
/// <para>Custom XML Schema Reference.</para>
/// <para> When the object is serialized out as xml, its qualified name is sl:schema.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Schema : OpenXmlLeafElement
{
    private const string tagName = "schema";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 25;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12469;
    
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
    

    private static string[] attributeTagNames = { "uri","manifestLocation","schemaLocation" };
    private static byte[] attributeNamespaceIds = { 25,25,25 };
    
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
    /// <para> Custom XML Schema Namespace.</para>
    /// <para>Represents the following attribute in the schema: sl:uri </para>
    /// </summary>
///<remark> xmlns:sl=http://schemas.openxmlformats.org/schemaLibrary/2006/main
///</remark>
    [SchemaAttr(25, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Resource File Location.</para>
    /// <para>Represents the following attribute in the schema: sl:manifestLocation </para>
    /// </summary>
///<remark> xmlns:sl=http://schemas.openxmlformats.org/schemaLibrary/2006/main
///</remark>
    [SchemaAttr(25, "manifestLocation")]
    public StringValue ManifestLocation
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Custom XML Schema Location.</para>
    /// <para>Represents the following attribute in the schema: sl:schemaLocation </para>
    /// </summary>
///<remark> xmlns:sl=http://schemas.openxmlformats.org/schemaLibrary/2006/main
///</remark>
    [SchemaAttr(25, "schemaLocation")]
    public StringValue SchemaLocation
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Schema class.
    /// </summary>
    public Schema():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 25 == namespaceId && "uri" == name)
    return new StringValue();
    
if( 25 == namespaceId && "manifestLocation" == name)
    return new StringValue();
    
if( 25 == namespaceId && "schemaLocation" == name)
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
        return CloneImp<Schema>(deep);
    }

   
}
}
 
 
