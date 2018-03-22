// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Vml.Presentation
{
/// <summary>
/// <para>Ink Annotation Flag.</para>
/// <para> When the object is serialized out as xml, its qualified name is pvml:iscomment.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
public partial class InkAnnotationFlag : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12575;
    /// <inheritdoc/>
    public override string LocalName => "iscomment";
    
    internal override byte NamespaceId => 30;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
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
    /// Initializes a new instance of the InkAnnotationFlag class.
    /// </summary>
    public InkAnnotationFlag():base(){}
    
      
     
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<InkAnnotationFlag>(deep);

}
/// <summary>
/// <para>VML Diagram Text.</para>
/// <para> When the object is serialized out as xml, its qualified name is pvml:textdata.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
public partial class TextData : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12576;
    /// <inheritdoc/>
    public override string LocalName => "textdata";
    
    internal override byte NamespaceId => 30;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
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
    

    	private static readonly string[] attributeTagNames = { "id" };
    private static readonly byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    

    
        /// <summary>
    /// <para> Text Reference.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TextData class.
    /// </summary>
    public TextData():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextData>(deep);

}
}
 
 
