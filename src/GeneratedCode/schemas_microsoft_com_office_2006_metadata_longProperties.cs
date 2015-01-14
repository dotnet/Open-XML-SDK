// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.LongProperties
{
/// <summary>
/// <para>Defines the LongProperties Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is lp:LongProperties.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LongProperty &lt;lp:LongProp></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(LongProperty))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LongProperties : OpenXmlCompositeElement
{
    private const string tagName = "LongProperties";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 40;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12711;
    
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
    /// Initializes a new instance of the LongProperties class.
    /// </summary>
    public LongProperties():base(){}
    
            /// <summary>
    ///Initializes a new instance of the LongProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LongProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LongProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LongProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LongProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LongProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 40 == namespaceId && "LongProp" == name)
    return new LongProperty();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LongProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the LongProperty Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is lp:LongProp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LongProperty : OpenXmlLeafTextElement
{
    private const string tagName = "LongProp";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 40;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12712;
    
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
    /// Initializes a new instance of the LongProperty class.
    /// </summary>
    public LongProperty():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the LongProperty class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public LongProperty(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
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
        return CloneImp<LongProperty>(deep);
    }

   
}
}
 
 
